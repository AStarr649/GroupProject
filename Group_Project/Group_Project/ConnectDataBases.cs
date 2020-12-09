using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SqlClient;
using System.Data;
using System.Windows.Forms;

namespace Group_Project
{
    class ConnectDataBases
    {
        public static string dataConnection =
           "Data Source=cstnt.tstc.edu;" +
           "Initial Catalog=inew2330fa20;" +
           "User Id=group7fa202330;" +
           "Password=1964375;";
        internal static bool LoginCheck(string username, string password, string role)
        {
            bool valid = false;
            try
            {
                SqlConnection dataConnect = new SqlConnection(dataConnection);
                string query = "SELECT * FROM group7fa202330.userAccount WHERE username = '" +
                    username + "' AND user_password = '" + password + "';";
                SqlDataAdapter dataAdapter = new SqlDataAdapter(query, dataConnection);
                DataTable dataTable = new DataTable();
                try
                {
                    dataAdapter.Fill(dataTable);
                    if (dataTable.Rows.Count == 1)
                    {
                        valid = true;

                        ConnectVariables.SetLoggedInUsernameAs(username);
                    }
                    else
                    {
                        valid = false;
                        MessageBox.Show("Please enter a valid username and password");
                    }
                    Console.WriteLine("Valid: " + valid);
                }
                catch (SqlException x)
                {
                    Console.WriteLine(x.ToString());
                }
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.ToString());
            }

            if (valid)
            {
                //Update Cur ROle HERE
                try
                {
                    SqlConnection dataConnect = new SqlConnection(dataConnection);
                    dataConnect.Open();
                    //Select one Account to edit
                    string query = "UPDATE group7fa202330.userAccount SET user_role = '" + role + "' WHERE username = '" +
                    username + "';";
                    SqlCommand dataCommand = new SqlCommand(query, dataConnect);
                    Console.WriteLine(dataCommand.CommandText);

                    dataCommand.ExecuteNonQuery();
                    try
                    {
                        //Test for updated role
                        query = "SELECT * FROM group7fa202330.userAccount WHERE username = '" + username + "' AND user_role = '" + role + "';";
                        SqlDataAdapter dataAdapter = new SqlDataAdapter(query, dataConnection);
                        DataTable dataTabel = new DataTable();

                        dataAdapter.Fill(dataTabel);
                        if (dataTabel.Rows.Count == 1)
                        {
                            valid = true;
                        }
                        else
                        {
                            valid = false;
                        }

                        if (valid)
                        {
                            Console.WriteLine("Role updated corrctlly!");
                            ConnectVariables.SetRoleViewAs(role);
                        }
                        else
                            Console.WriteLine("Role update ERROR!");
                    }
                    catch (SqlException x)
                    {
                        Console.WriteLine(x.ToString());
                    }
                    dataConnect.Close();
                }
                catch (SqlException x)
                {
                    Console.WriteLine(x.ToString());
                }
                //MessageBox.Show("You have entered the program as: " + role);
            }
            return valid;
        }

        internal static void ResetPassword(string username, string newUserPassword, string newUserPasswordCon)
        {
            bool valid = false;
            try
            {
                SqlConnection dataConnect = new SqlConnection(dataConnection);
                dataConnect.Open();

                // Test if username is valid
                string query = "SELECT * FROM group7fa202330.userAccount WHERE username = '" +
                    username + "';";
                SqlDataAdapter dataAdaptValid = new SqlDataAdapter(query, dataConnection);
                DataTable dataTabelValid = new DataTable();
                dataAdaptValid.Fill(dataTabelValid);
                //
                if (dataTabelValid.Rows.Count == 1)
                {
                    //Select one email
                    query = "SELECT * FROM group7fa202330.userAccount WHERE username = '" +
                    username + "'; UPDATE group7fa202330.userAccount SET user_password = '" + newUserPassword + "' WHERE username = '" +
                    username + "';";
                    SqlCommand dataCommand = new SqlCommand(query, dataConnect);
                    Console.WriteLine(dataCommand.CommandText);

                    dataCommand.ExecuteNonQuery();
                    try
                    {
                        //Test for updated password
                        query = "SELECT * FROM group7fa202330.userAccount WHERE username = '" +
                    username + "' and user_password = '" + newUserPassword + "';";
                        SqlDataAdapter dataAdapter = new SqlDataAdapter(query, dataConnection);
                        DataTable dataTabel = new DataTable();

                        dataAdapter.Fill(dataTabel);
                        if (dataTabel.Rows.Count == 1)
                        {
                            valid = true;
                        }
                        else
                        {
                            valid = false;
                        }

                        if (valid)
                        {
                            MessageBox.Show("Password sucessfully updated!");
                            Console.WriteLine("Password updated corrctlly!");
                        }
                        else
                            Console.WriteLine("Password update ERROR!");
                    }
                    catch (SqlException x)
                    {
                        Console.WriteLine("EXCEPTION TEST UPDATED PASSWORD: " + x.ToString());
                    }
                    dataConnect.Close();
                }

                else
                {
                    MessageBox.Show("The username you have chosen is not valid. Please enter a different username.");
                }
            }
            catch (Exception x)
            {
                Console.WriteLine("EXCEPTION UPDATE PASSWORD: " + x.ToString());
            }

        }

        [Obsolete]
        internal static void CreateAccount(string txtboxFirstName, string txtboxLastName, string txtboxEmail,
            string txtboxUsername, string txtboxPassword)
        {
            try
            {

                int userID;
                SqlConnection dataConnect = new SqlConnection(dataConnection);
                dataConnect.Open();

                // Test if username has been used
                string query = "SELECT * FROM group7fa202330.userAccount WHERE username = '" +
                    txtboxUsername + "';";
                SqlDataAdapter dataAdaptValid = new SqlDataAdapter(query, dataConnection);
                DataTable dataTabelValid = new DataTable();
                dataAdaptValid.Fill(dataTabelValid);
                //
                if (dataTabelValid.Rows.Count == 1)
                {
                    MessageBox.Show("The username you have chosen is already existing. Please enter a different username.");
                }
                else
                {
                    SqlCommand dataCommand = new SqlCommand("INSERT INTO group7fa202330.userAccount " +
                    "(user_id, user_password, user_first_name, user_last_name, username , user_email, user_role)" +
                    "VALUES (@userID, @userPassword, @userFName, @userLName, @username, @userEmail, NULL)", dataConnect);

                    Console.WriteLine("Command_1: " + dataCommand);

                    string IDquery = "SELECT * FROM group7fa202330.userAccount";
                    SqlDataAdapter dataAdapter = new SqlDataAdapter(IDquery, dataConnection);
                    DataTable dataTable = new DataTable();

                    try
                    {
                        dataAdapter.Fill(dataTable);
                        userID = dataTable.Rows.Count + 1;
                        Console.WriteLine(userID);

                        dataCommand.Parameters.Add("@userID", userID.ToString());
                        dataCommand.Parameters.Add("@userPassword", txtboxPassword);
                        dataCommand.Parameters.Add("@userFName", txtboxFirstName);
                        dataCommand.Parameters.Add("@userLName", txtboxLastName);
                        dataCommand.Parameters.Add("@username", txtboxUsername);
                        dataCommand.Parameters.Add("@userEmail", txtboxEmail);

                        Console.WriteLine("Command_2: " + dataCommand);
                        dataCommand.ExecuteNonQuery();
                        dataConnect.Close();

                        MessageBox.Show("Account Created Successfully!" + Environment.NewLine +
                                "Please click on [RETURN] inorder to login.");

                    }
                    catch (SqlException x)
                    {
                        Console.WriteLine(x.ToString());
                    }

                    dataConnect.Close();
                }
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.ToString());
            }
        }

        internal static bool SendOTP(string userEmail)
        {
            string newOTP = "";
            Random rn = new Random();
            int randomNumber;
            bool valid = false;
            //Test if users email is valid in the database.
            try
            {
                SqlConnection dataConnect = new SqlConnection(dataConnection);
                string query = "SELECT * FROM group7fa202330.userAccount WHERE user_email = '" +
                    userEmail + "';";
                SqlDataAdapter dataAdapter = new SqlDataAdapter(query, dataConnection);
                DataTable dataTable = new DataTable();
                try
                {
                    dataAdapter.Fill(dataTable);
                    if (dataTable.Rows.Count == 1)
                    {
                        valid = true;
                    }
                    else
                    {
                        valid = false;
                    }
                }
                catch (SqlException x)
                {
                    Console.WriteLine(x.ToString());
                }
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.ToString());
            }
            if (valid)
            {
                //Generate OTP
                for (int i = 0; newOTP.Length <= 5; i++)
                {

                    randomNumber = rn.Next(0, 9);
                    while (i == 0 && randomNumber == 0)
                    {
                        randomNumber = rn.Next(0, 9);
                    }
                    newOTP = newOTP + randomNumber;

                    Console.Out.WriteLine(newOTP);
                }
                //update the database
                try
                {
                    SqlConnection dataConnect = new SqlConnection(dataConnection);
                    dataConnect.Open();
                    //Select one email
                    string query = "SELECT * FROM group7fa202330.userAccount WHERE user_email = '" +
                    userEmail + "'; UPDATE group7fa202330.userAccount SET user_password = '" + newOTP + "' WHERE user_email = '" +
                    userEmail + "';";
                    SqlCommand dataCommand = new SqlCommand(query, dataConnect);
                    Console.WriteLine(dataCommand.CommandText);

                    dataCommand.ExecuteNonQuery();
                    try
                    {
                        //Test for updated password
                        query = "SELECT * FROM group7fa202330.userAccount WHERE user_email = '" + userEmail + "' AND user_password = '" + newOTP + "';";
                        SqlDataAdapter dataAdapter = new SqlDataAdapter(query, dataConnection);
                        DataTable dataTabel = new DataTable();

                        dataAdapter.Fill(dataTabel);
                        if (dataTabel.Rows.Count == 1)
                        {
                            valid = true;
                        }
                        else
                        {
                            valid = false;
                        }

                        if (valid)
                        {
                            Console.WriteLine("Password updated corrctlly!");
                        }
                        else
                            Console.WriteLine("Password update ERROR!");
                    }
                    catch (SqlException x)
                    {
                        Console.WriteLine(x.ToString());
                    }
                    dataConnect.Close();
                }
                catch (SqlException x)
                {
                    Console.WriteLine(x.ToString());
                }

                MessageBox.Show("An email has been sent to " + userEmail + " containing the OTP.");
                //FormClass.liF.Visible = true;
                //FormClass.fpF.Visible = false;

                Console.Out.WriteLine("Completed : " + newOTP);
            }
            else
                MessageBox.Show("The email you have entered was invalid. Please try again or create an account.");
            return valid;
        }

        [Obsolete]
        internal static void CreateCharacter(
            string username, string charName,
            string charRace, string charGender,
            string charElement, string charClass,
            string charStrenth, string charConstitution, string charDexterity, string charWisdom, string charIntelligence, string charCharisma, string charLuck,
            string charBrawn, string charHealth, string charNimbility, string charMemory, string charCleverness, string charCharm,
            string charTalents1, string charTalents2, string charTalents3,
            string charQuirks1, string charQuirks2, string charQuirks3)
        {
            try
            {
                int charID;
                SqlConnection dataConnect = new SqlConnection(dataConnection);
                dataConnect.Open();
                string userID = GetUserId(username);



                //Test if character already exists under the user with everythign the same


                SqlCommand dataCommand = new SqlCommand("INSERT INTO group7fa202330.userCharacter " +
                    "(user_id, character_id, character_name, " +
                    "character_gender, character_race, " +
                    "character_primary_class, character_elemental_affinity," +
                    "character_strength_points, character_constitution_points, character_dexterity_points, character_wisdom_points, character_intelligence_points, character_charisma_points, character_luck_points, " +
                    "character_brawn, character_health, character_nimbility, character_memory, character_cleverness, character_charm, " +
                    "character_talents_1, character_talents_2, character_talents_3," +
                    "character_quirks_1, character_quirks_2, character_quirks_3)" +

                    "Values ( @userID, @charID, @charName," +
                    "@charGend, @charRace," +
                    "@charClass, @charElement," +
                    "@charStrenth, @charConst, @charDext, @charWis, @charIntel, @charChar, @charLuck," +
                    "@charBrawn, @charHealth, @charNimb, @charMemory, @charClever, @charCharm," +
                    "@charTal1, @charTal2, @charTal3," +
                    "@charQuirk1, @charQuirk2, @charQuirk3)", dataConnect);

                Console.WriteLine("Command_1: " + dataCommand);

                string IDquery = "SELECT * FROM group7fa202330.userCharacter";
                SqlDataAdapter dataAdapter = new SqlDataAdapter(IDquery, dataConnection);
                DataTable dataTable = new DataTable();
                try
                {
                    dataAdapter.Fill(dataTable);
                    charID = dataTable.Rows.Count + 1;
                    Console.WriteLine(charID);

                    dataCommand.Parameters.Add("@userID", userID);
                    dataCommand.Parameters.Add("@charID", charID.ToString());
                    dataCommand.Parameters.Add("@charName", charName);

                    dataCommand.Parameters.Add("@charGend", charGender);
                    dataCommand.Parameters.Add("@charRace", charRace);

                    dataCommand.Parameters.Add("@charClass", charClass);
                    dataCommand.Parameters.Add("@charElement", charElement);

                    dataCommand.Parameters.Add("@charStrenth", charStrenth);
                    dataCommand.Parameters.Add("@charConst", charConstitution);
                    dataCommand.Parameters.Add("@charDext", charDexterity);
                    dataCommand.Parameters.Add("@charWis", charWisdom);
                    dataCommand.Parameters.Add("@charIntel", charIntelligence);
                    dataCommand.Parameters.Add("@charChar", charCharisma);
                    dataCommand.Parameters.Add("@charLuck", charLuck);

                    dataCommand.Parameters.Add("@charBrawn", charBrawn);
                    dataCommand.Parameters.Add("@charHealth", charHealth);
                    dataCommand.Parameters.Add("@charNimb", charNimbility);
                    dataCommand.Parameters.Add("@charMemory", charMemory);
                    dataCommand.Parameters.Add("@charClever", charCleverness);
                    dataCommand.Parameters.Add("@charCharm", charCharm);

                    dataCommand.Parameters.Add("@charTal1", charTalents1);
                    dataCommand.Parameters.Add("@charTal2", charTalents2);
                    dataCommand.Parameters.Add("@charTal3", charTalents3);

                    dataCommand.Parameters.Add("@charQuirk1", charQuirks1);
                    dataCommand.Parameters.Add("@charQuirk2", charQuirks2);
                    dataCommand.Parameters.Add("@charQuirk3", charQuirks3);

                    Console.WriteLine("Command_2: " + dataCommand);
                    dataCommand.ExecuteNonQuery();
                    dataConnect.Close();

                    MessageBox.Show("Character Created Successfully!");
                }

                catch (SqlException x)
                {
                    Console.WriteLine(x.ToString());
                }

                dataConnect.Close();
            }
            catch (SqlException ex)
            {
                Console.WriteLine(ex.ToString());
            }
        }


        [Obsolete]
        internal static void UpdateCharacter(
            string username, string charName,
            string charRace, string charGender,
            string charElement, string charClass,
            string charStrenth, string charConstitution, string charDexterity, string charWisdom, string charIntelligence, string charCharisma, string charLuck,
            string charBrawn, string charHealth, string charNimbility, string charMemory, string charCleverness, string charCharm,
            string charTalents1, string charTalents2, string charTalents3,
            string charQuirks1, string charQuirks2, string charQuirks3)
        {
            try
            {
                SqlConnection dataConnect = new SqlConnection(dataConnection);
                dataConnect.Open();

                //Updating character
                string userID = GetUserId(username), charID = "";
                SqlCommand dataCommand = new SqlCommand("UPDATE group7fa202330.userCharacter SET " +
                "character_name = '" + charName + "' , " +
                "character_gender = '" + charGender + "' , " +
                "character_race = '" + charRace + "' , " +
                "character_primary_class = '" + charClass + "' , " +
                "character_elemental_affinity = '" + charElement + "' , " +
                "character_strength_points = '" + charStrenth + "' , " +
                "character_constitution_points = '" + charConstitution + "' , " +
                "character_dexterity_points = '" + charDexterity + "' , " +
                "character_wisdom_points = '" + charWisdom + "' , " +
                " character_intelligence_points = '" + charIntelligence + "' , " +
                "character_charisma_points = '" + charCharisma + "' , " +
                "character_luck_points = '" + charLuck + "' , " +
                "character_brawn = '" + charBrawn + "' , " +
                "character_health = '" + charHealth + "' , " +
                "character_nimbility = '" + charNimbility + "' , " +
                "character_memory = '" + charMemory + "' , " +
                "character_cleverness = '" + charCleverness + "' , " +
                "character_charm = '" + charCharm + "' , " +
                "character_talents_1 = '" + charTalents1 + "' , " +
                "character_talents_2 = '" + charTalents2 + "' , " +
                "character_talents_3 = '" + charTalents3 + "' , " +
                "character_quirks_1 = '" + charQuirks1 + "' , " +
                "character_quirks_2 = '" + charQuirks2 + "' , " +
                "character_quirks_3 = '" + charQuirks3 + "' " +
                "WHERE user_id = '" + userID + "' AND character_id = '" + charID + "';", dataConnect);

                Console.WriteLine("Command_1: " + dataCommand);
                dataCommand.ExecuteNonQuery();
                MessageBox.Show("Character Updated Successfully!");

                dataConnect.Close();
            }
            catch (SqlException ex)
            {
                Console.WriteLine(ex.ToString());
            }
        }
        internal static string GetUserId(string username)
        {
            string user_ID = "";
            try
            {
                string query = "SELECT user_id FROM group7fa202330.userAccount WHERE username = '" +
                    username + "';";

                using (SqlConnection dataConnect = new SqlConnection(dataConnection))
                {
                    SqlCommand dataCommand = new SqlCommand(query, dataConnect);
                    dataConnect.Open();
                    SqlDataReader reader = dataCommand.ExecuteReader();
                    while (reader.Read())
                    {
                        user_ID = ReadSingleRow((IDataRecord)reader, 0);
                    }
                }
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.ToString());
            }
            return user_ID;
        }
        internal static string GetUsername(string userID)
        {
            string username = "";
            try
            {
                string query = "SELECT username FROM group7fa202330.userAccount WHERE user_id = '" +
                    userID + "';";

                using (SqlConnection dataConnect = new SqlConnection(dataConnection))
                {
                    SqlCommand dataCommand = new SqlCommand(query, dataConnect);
                    dataConnect.Open();
                    SqlDataReader reader = dataCommand.ExecuteReader();
                    while (reader.Read())
                    {
                        username = ReadSingleRow((IDataRecord)reader, 0);
                    }
                }
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.ToString());
            }
            return username;
        }

        private static string ReadSingleRow(IDataRecord record, int value)
        {
            string returnValue = record[value].ToString();
            return returnValue;
        }
        internal static int GetAllCharacters()
        {
            int totalCharacters = 0;
            SqlConnection dataConnect = new SqlConnection(dataConnection);
            dataConnect.Open();

            string query = "SELECT * FROM group7fa202330.userCharacter;";
            SqlDataAdapter dataAdaptValid = new SqlDataAdapter(query, dataConnection);
            DataTable dataTabelValid = new DataTable();
            dataAdaptValid.Fill(dataTabelValid);
            totalCharacters = dataTabelValid.Rows.Count;

            return totalCharacters;
        }

        internal static int GetUsersCharactersAmount()
        {
            int totalCharacters = 0;
            string userID = GetUserId(ConnectVariables.GetLoggedInUsernameAs());
            SqlConnection dataConnect = new SqlConnection(dataConnection);
            dataConnect.Open();

            // Test if username has been used
            string query = "SELECT * FROM group7fa202330.userCharacter WHERE user_id = '" +
                userID + "';";
            SqlDataAdapter dataAdaptValid = new SqlDataAdapter(query, dataConnection);
            DataTable dataTabelValid = new DataTable();
            dataAdaptValid.Fill(dataTabelValid);
            totalCharacters = dataTabelValid.Rows.Count;

            return totalCharacters;
        }

        internal static string GetUsersCharacters(int currentIndex = 0, char searchFor = '0')
        {
            if (currentIndex == 0)
            {
                currentIndex += 1;
            }

            string userID = ConnectVariables.GetLoggedInUsernameAs();
            userID = GetUserId(userID);

            using (SqlConnection dataConnect = new SqlConnection(dataConnection))
            {
                SqlCommand dataCommand;
                if (searchFor == 'A')
                {
                    dataCommand = new SqlCommand("" +
                    "With CurrentSelection AS " +
                    "( " +
                    "select user_id, character_id, character_name, character_gender, character_race, character_primary_class, " +
                    "ROW_NUMBER() OVER (ORDER BY character_name) AS RowNumber " +
                    "FROM group7fa202330.userCharacter" +
                    ") " +
                    "Select * FROM CurrentSelection WHERE RowNumber = '" + currentIndex + "';", dataConnect);
                }
                else
                {
                    dataCommand = new SqlCommand("" +
                    "With CurrentSelection AS " +
                    "( " +
                    "select user_id, character_id, character_name, character_gender, character_race, character_primary_class, " +
                    "ROW_NUMBER() OVER (ORDER BY character_name) AS RowNumber " +
                    "FROM group7fa202330.userCharacter where user_id = '" + userID + "' " +
                    ") " +
                    "Select * FROM CurrentSelection WHERE RowNumber = '" + currentIndex + "';", dataConnect);
                }

                Console.WriteLine(dataCommand.CommandText);

                dataConnect.Open();
                SqlDataReader reader = dataCommand.ExecuteReader();
                while (reader.Read())
                {
                    userID = ReadSingleRow((IDataRecord)reader, 0);
                    string charID = ReadSingleRow((IDataRecord)reader, 1);
                    string charName = ReadSingleRow((IDataRecord)reader, 2);
                    string charGender = ReadSingleRow((IDataRecord)reader, 3);
                    string chareRace = ReadSingleRow((IDataRecord)reader, 4);
                    string charClass = ReadSingleRow((IDataRecord)reader, 5);
                    ConnectVariables.SetCharIDDP(charID);
                    ConnectVariables.SetCharNameDP(charName);
                    ConnectVariables.SetCharGenderDP(charGender);
                    ConnectVariables.SetCharRaceDP(chareRace);
                    ConnectVariables.SetCharClassDP(charClass);
                    string username = GetUsername(userID);
                    ConnectVariables.SetUsernamesDP(username);
                }

            }


            return currentIndex.ToString();
        }
        internal static void LoadUserCharacter(string charID, string userID)
        {
            //search the database for the character to loadin the info


            using (SqlConnection dataConnect = new SqlConnection(dataConnection))
            {
                SqlCommand dataCommand = new SqlCommand("" +
                "Select * from group7fa202330.userCharacter " +
                "Where user_id = '" + userID + "' and character_id = '" + charID + "';", dataConnect);

                Console.WriteLine(dataCommand.CommandText);

                dataConnect.Open();
                SqlDataReader reader = dataCommand.ExecuteReader();
                while (reader.Read())
                {
                    string charName = ReadSingleRow((IDataRecord)reader, 2);
                    string charGender = ReadSingleRow((IDataRecord)reader, 3);
                    string chareRace = ReadSingleRow((IDataRecord)reader, 4);
                    string charClass = ReadSingleRow((IDataRecord)reader, 5);
                    string charElement = ReadSingleRow((IDataRecord)reader, 6);
                    string charStr = ReadSingleRow((IDataRecord)reader, 7);
                    string charConst = ReadSingleRow((IDataRecord)reader, 8);
                    string charDex = ReadSingleRow((IDataRecord)reader, 9);
                    string charWis = ReadSingleRow((IDataRecord)reader, 10);
                    string charIntel = ReadSingleRow((IDataRecord)reader, 11);
                    string charCharisma = ReadSingleRow((IDataRecord)reader, 12);
                    string charLuck = ReadSingleRow((IDataRecord)reader, 13);
                    string charBrawn = ReadSingleRow((IDataRecord)reader, 14);
                    string charHealth = ReadSingleRow((IDataRecord)reader, 15);
                    string charNimbility = ReadSingleRow((IDataRecord)reader, 16);
                    string charMemory = ReadSingleRow((IDataRecord)reader, 17);
                    string charClever = ReadSingleRow((IDataRecord)reader, 18);
                    string charCharm = ReadSingleRow((IDataRecord)reader, 19);
                    string charTal1 = ReadSingleRow((IDataRecord)reader, 20);
                    string charTal2 = ReadSingleRow((IDataRecord)reader, 21);
                    string charTal3 = ReadSingleRow((IDataRecord)reader, 22);
                    string charQui1 = ReadSingleRow((IDataRecord)reader, 23);
                    string charQui2 = ReadSingleRow((IDataRecord)reader, 24);
                    string charQui3 = ReadSingleRow((IDataRecord)reader, 25);
                    ConnectVariables.SetCharNameDP(charName);
                    ConnectVariables.SetCharGenderDP(charGender);
                    ConnectVariables.SetCharRaceDP(chareRace);
                    ConnectVariables.SetCharClassDP(charClass);
                    ConnectVariables.SetCharElementDP(charElement);
                    ConnectVariables.SetCharStrengthDP(charStr);
                    ConnectVariables.SetCharConstDP(charConst);
                    ConnectVariables.SetCharDexDP(charDex);
                    ConnectVariables.SetCharWisDP(charWis);
                    ConnectVariables.SetCharIntelDP(charIntel);
                    ConnectVariables.SetCharCharismaDP(charCharisma);
                    ConnectVariables.SetCharLuckDP(charLuck);
                    ConnectVariables.SetCharBrawnDP(charBrawn);
                    ConnectVariables.SetCharHealthDP(charHealth);
                    ConnectVariables.SetCharNimDP(charNimbility);
                    ConnectVariables.SetCharMemDP(charMemory);
                    ConnectVariables.SetCharCleverDP(charClever);
                    ConnectVariables.SetCharCharmDP(charCharm);
                    ConnectVariables.SetCharTalDP1(charTal1);
                    ConnectVariables.SetCharTalDP2(charTal2);
                    ConnectVariables.SetCharTalDP3(charTal3);
                    ConnectVariables.SetCharQuiDP1(charQui1);
                    ConnectVariables.SetCharQuiDP2(charQui2);
                    ConnectVariables.SetCharQuiDP3(charQui3);

                    Console.WriteLine("" +
                           "UserID: " + userID + "\n" +
                           "CharacterID: " + charID + "\n" +
                           "CharacterName: " + charName + "\n" +
                           "CharacterGender: " + charGender + "\n" +
                           "CharacterRace: " + chareRace + "\n" +
                           "CharacterClass: " + charClass + "\n" +
                           "CharacterElement: " + charElement + "\n" +
                           "CharacterStr: " + charStr + "\n" +
                           "CharacterConst: " + charConst + "\n" +
                           "CharacterDex: " + charDex + "\n" +
                           "CharacterWis: " + charWis + "\n" +
                           "CharacterIntel: " + charIntel + "\n" +
                           "CharacterCharisma: " + charCharisma + "\n" +
                           "CharacterLuck: " + charLuck + "\n" +
                           "CharacterBrawn: " + charBrawn + "\n" +
                           "Characterhealth: " + charHealth + "\n" +
                           "CharacterNimbility: " + charNimbility + "\n" +
                           "CharacterMemory: " + charMemory + "\n" +
                           "CharacterCleverness: " + charClever + "\n" +
                           "CharacterCharm: " + charCharm + "\n" +
                           "CharacterTalents1: " + charTal1 + "\n" +
                           "CharacterTalents2: " + charTal2 + "\n" +
                           "CharacterTalents3: " + charTal3 + "\n" +
                           "CharacterQuirks1: " + charQui1 + "\n" +
                           "CharacterQuirks2: " + charQui2 + "\n" +
                           "CharacterQuirks3: " + charQui3);
                }
                string username = GetUsername(userID);
                ConnectVariables.SetUsernamesDP(username);
                Console.WriteLine("Username: " + username);
            }
        }

        internal static bool SearchForUser(string username)
        {
            bool valid = false;
            try
            {
                SqlConnection dataConnect = new SqlConnection(dataConnection);
                string query = "SELECT * FROM group7fa202330.userAccount WHERE username = '" +
                    username + "';";
                SqlDataAdapter dataAdapter = new SqlDataAdapter(query, dataConnection);
                DataTable dataTable = new DataTable();
                dataAdapter.Fill(dataTable);
                if (dataTable.Rows.Count == 1)
                {
                    valid = true;
                    ConnectVariables.SetUsernamesDP(username);
                    ConnectVariables.SetUserIDDP(username);
                }
                else
                {
                    MessageBox.Show("Please enter a valid username!");
                }
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.ToString());
            }
            return valid;
        }
        internal static bool SearchForCharacter(string username, string charID)
        {
            bool valid = false;
            /*
            try
            {
                SqlConnection dataConnect = new SqlConnection(dataConnection);
                string query = "SELECT * FROM group7fa202330.userAccount WHERE username = '" +
                    username + "';";
                SqlDataAdapter dataAdapter = new SqlDataAdapter(query, dataConnection);
                DataTable dataTable = new DataTable();
                dataAdapter.Fill(dataTable);
                if (dataTable.Rows.Count == 1)
                {
                    valid = true;
                    ConnectVariables.SetUsernamesDP(username);
                    ConnectVariables.SetUserIDDP(username);
                }
                else
                {
                    MessageBox.Show("Please enter a valid username!");
                }
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.ToString());
            }
            */
            return valid;
        }


        internal static void CreateParty()
        {
            try
            {
                SqlConnection dataConnect;
                SqlDataAdapter dataAdapter;
                DataTable dataTable;
                int partyID;
                try
                {
                    dataConnect = new SqlConnection(dataConnection);
                    string queryCheck = "SELECT * FROM group7fa202330.userParty;";
                    dataAdapter = new SqlDataAdapter(queryCheck, dataConnection);
                    dataTable = new DataTable();
                    dataAdapter.Fill(dataTable);
                    partyID = dataTable.Rows.Count + 1;
                    ConnectVariables.SetPartyIDDP(partyID.ToString());
                    Console.WriteLine(partyID);
                }
                catch (Exception x)
                {
                    Console.WriteLine(x.ToString());
                }


                dataConnect = new SqlConnection(dataConnection);
                dataConnect.Open();



                //Test if party already exists under the user with everythign the same


                SqlCommand dataCommand = new SqlCommand("INSERT INTO group7fa202330.userParty(owner_user_id, party_id)" +
                " values('" + GetUserId(ConnectVariables.GetLoggedInUsernameAs()) + "', '" +
                ConnectVariables.GetPartyIDDP() + "');", dataConnect);

                Console.WriteLine("Command_1: " + dataCommand);

                dataCommand.ExecuteNonQuery();
                MessageBox.Show("Party Created Successfully!");
                dataConnect.Close();
            }
            catch (SqlException ex)
            {
                Console.WriteLine(ex.ToString());
            }

        }

        /*
        internal static void DeleteParty(string v)
        {
            try
            {
                SqlConnection dataConnect;
                dataConnect = new SqlConnection(dataConnection);
                dataConnect.Open();

                SqlCommand dataCommand = new SqlCommand("delete from group7fa202330.userParty where owner_user_id = '" +
                    GetUserId(ConnectVariables.GetLoggedInUsernameAs()) + "' and party_id = '" +
                ConnectVariables.GetPartyIDDP() + "';", dataConnect);

                Console.WriteLine("Command_1: " + dataCommand);

                dataCommand.ExecuteNonQuery();
                MessageBox.Show("Party Deleted Successfully!");
                dataConnect.Close();
            }
            catch (SqlException ex)
            {
                Console.WriteLine(ex.ToString());
            }
        }
        */


        internal static void UpdateParty(int playerAmnt = 0, int charAmnt = 0, string userID = "", string partyID = "", string partyName = "",
            string playerID1 = "", string playerID2 = "", string playerID3 = "", string playerID4 = "", string playerID5 = "", string playerID6 = "",
            string charID1 = "", string charID2 = "", string charID3 = "", string charID4 = "", string charID5 = "", string charID6 = "")
        {
            if (playerAmnt > 0)
            {
                try
                {
                    SqlConnection dataConnect = new SqlConnection(dataConnection);
                    dataConnect.Open();

                    //Updating Player Party
                    string commandStart = "UPDATE group7fa202330.userParty SET " +
                    "player_amnt = '" + playerAmnt + "' ",
                    commandEnd = " WHERE owner_user_id = '" + userID + "' AND party_id = '" + partyID + "';", stringduring = "";
                    StringBuilder builtCommand = new StringBuilder(commandStart);
                    string[] playerArray = { playerID1, playerID2, playerID3, playerID4, playerID5, playerID6 },
                        dBPlayerArray = { "player_user_id1", "player_user_id2", "player_user_id3", "player_user_id4", "player_user_id5", "player_user_id6" };

                    for (int i = 0; i < playerAmnt; i++)
                    {
                        stringduring = ", " + dBPlayerArray[i] + " = '" + playerArray[i] + "'";
                        builtCommand.Append(stringduring);
                    }
                    builtCommand.Append(commandEnd);

                    SqlCommand dataCommand = new SqlCommand(builtCommand.ToString(), dataConnect);

                    Console.WriteLine("Command_1: " + builtCommand.ToString());
                    dataCommand.ExecuteNonQuery();

                    Console.WriteLine("Updated Players party and name");

                    dataConnect.Close();
                }
                catch (SqlException ex)
                {
                    Console.WriteLine(ex.ToString());
                }
            }
            if (charAmnt > 0)
            {
                try
                {
                    SqlConnection dataConnect = new SqlConnection(dataConnection);
                    dataConnect.Open();

                    //Updating Player Party
                    string commandStart = "UPDATE group7fa202330.userParty SET " +
                    "char_amnt = '" + charAmnt + "' ",
                    commandEnd = " WHERE owner_user_id = '" + userID + "' AND party_id = '" + partyID + "';", stringduring = "";
                    StringBuilder builtCommand = new StringBuilder(commandStart);
                    string[] playerArray = { charID1, charID2, charID3, charID4, charID5, charID6 },
                        dBPlayerArray = { "character_id1", "character_id2", "character_id3", "character_id4", "character_id5", "character_id6" };

                    for (int i = 0; i < playerAmnt; i++)
                    {
                        stringduring = ", " + dBPlayerArray[i] + " = '" + playerArray[i] + "'";
                        builtCommand.Append(stringduring);
                    }
                    builtCommand.Append(commandEnd);

                    SqlCommand dataCommand = new SqlCommand(builtCommand.ToString(), dataConnect);

                    Console.WriteLine("Command_1: " + builtCommand.ToString());
                    dataCommand.ExecuteNonQuery();

                    Console.WriteLine("Updated Characters party and name");

                    dataConnect.Close();
                }
                catch (SqlException ex)
                {
                    Console.WriteLine(ex.ToString());
                }
            }
            try
            {
                SqlConnection dataConnect = new SqlConnection(dataConnection);
                dataConnect.Open();

                //Updating Name Party

                SqlCommand dataCommand = new SqlCommand("UPDATE group7fa202330.userParty SET " +
                "party_name = '" + partyName + "', player_amnt = '" + playerAmnt + "',char_amnt = '" + charAmnt + "'" +
                " WHERE owner_user_id = '" + userID + "' AND party_id = '" + partyID + "';", dataConnect);

                Console.WriteLine("Command_1: " + dataCommand.CommandText.ToString());
                dataCommand.ExecuteNonQuery();

                Console.WriteLine("Updated party name");

                dataConnect.Close();
            }
            catch (SqlException ex)
            {
                Console.WriteLine(ex.ToString());
            }
        }


        internal static int GetUsersPartyAmount()
        {
            int totalParties = 0;
            string userID = GetUserId(ConnectVariables.GetLoggedInUsernameAs());
            string role = ConnectVariables.GetRoleViewAs();
            if (role == "Dungeon Master")
            {

                SqlConnection dataConnect = new SqlConnection(dataConnection);
                dataConnect.Open();

                // Test if username has been used
                string query = "SELECT * FROM group7fa202330.userParty WHERE owner_user_id = '" +
                    userID + "';";
                SqlDataAdapter dataAdaptValid = new SqlDataAdapter(query, dataConnection);
                DataTable dataTabelValid = new DataTable();
                dataAdaptValid.Fill(dataTabelValid);
                totalParties = dataTabelValid.Rows.Count;
            }
            else if (role == "Player")
            {

                SqlConnection dataConnect = new SqlConnection(dataConnection);
                dataConnect.Open();

                // Test if username has been used
                string query = "Select * from group7fa202330.userParty " +
                    "where player_user_id1 = '" + userID + "' " +
                    "or player_user_id2 = '" + userID + "' " +
                    "or player_user_id3 = '" + userID + "' " +
                    "or player_user_id4 = '" + userID + "' " +
                    "or player_user_id5 = '" + userID + "' " +
                    "or player_user_id6 = '" + userID + "';";
                SqlDataAdapter dataAdaptValid = new SqlDataAdapter(query, dataConnection);
                DataTable dataTabelValid = new DataTable();
                dataAdaptValid.Fill(dataTabelValid);
                totalParties = dataTabelValid.Rows.Count;
            }

            return totalParties;
        }

        internal static int GetAllParties()
        {
            int totalParties = 0;
            SqlConnection dataConnect = new SqlConnection(dataConnection);
            dataConnect.Open();

            string query = "SELECT * FROM group7fa202330.userParty;";
            SqlDataAdapter dataAdaptValid = new SqlDataAdapter(query, dataConnection);
            DataTable dataTabelValid = new DataTable();
            dataAdaptValid.Fill(dataTabelValid);
            totalParties = dataTabelValid.Rows.Count;

            return totalParties;
        }
        internal static void SetPartyRow()
        {
            //ConnectVariables make get sets for each playerId and characterID
        }

        internal static string GetPartyName(string partyID)
        {
            string partyName = "";
            try
            {
                string query = "SELECT party_name FROM group7fa202330.userParty WHERE party_id = '" +
                    partyID + "';";

                using (SqlConnection dataConnect = new SqlConnection(dataConnection))
                {
                    SqlCommand dataCommand = new SqlCommand(query, dataConnect);
                    dataConnect.Open();
                    SqlDataReader reader = dataCommand.ExecuteReader();
                    while (reader.Read())
                    {
                        partyName = ReadSingleRow((IDataRecord)reader, 0);
                    }
                }
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.ToString());
            }
            return partyName;
        }








        internal static string GetParty(int currentIndex = 0, char searchFor = '0', int partyId = 0)
        {
            if (currentIndex == 0)
            {
                currentIndex += 1;
            }

            string userID = ConnectVariables.GetLoggedInUsernameAs();
            userID = GetUserId(userID);
            Console.WriteLine("Search for: " + searchFor);
            string role = ConnectVariables.GetRoleViewAs();
            SqlCommand dataCommand = new SqlCommand();

            using (SqlConnection dataConnect = new SqlConnection(dataConnection))
            {
                if (role == "Dungeon Master")
                {
                    if (searchFor == 'A')
                    {
                        dataCommand = new SqlCommand("" +
                        "With CurrentSelection AS " +
                        "( " +
                        "SELECT owner_user_id, party_id, party_name, " +
                        "player_user_id1, player_user_id2, player_user_id3, player_user_id4, player_user_id5, player_user_id6, " +
                        "character_id1, character_id2, character_id3, character_id4, character_id5, character_id6, " +
                        "ROW_NUMBER() OVER(ORDER BY party_name) AS RowNumber " +
                        "FROM group7fa202330.userParty" +
                        ") " +
                        "Select * FROM CurrentSelection WHERE RowNumber = '" + currentIndex + "';", dataConnect);
                    }
                    else if (searchFor == 'P')
                    {
                        dataCommand = new SqlCommand("" +
                       "With CurrentSelection AS " +
                       "( " +
                       "SELECT owner_user_id, party_id, party_name, " +
                       "player_user_id1, player_user_id2, player_user_id3, player_user_id4, player_user_id5, player_user_id6, " +
                       "character_id1, character_id2, character_id3, character_id4, character_id5, character_id6, " +
                       "ROW_NUMBER() OVER(ORDER BY party_name) AS RowNumber " +
                       "FROM group7fa202330.userParty where owner_user_id = '" + userID + "' " +
                       ") " +
                       "Select * FROM CurrentSelection WHERE party_id = '" + partyId + "';", dataConnect);
                    }
                    else
                    {
                        dataCommand = new SqlCommand("" +
                        "With CurrentSelection AS " +
                        "( " +
                        "SELECT owner_user_id, party_id, party_name, " +
                        "player_user_id1, player_user_id2, player_user_id3, player_user_id4, player_user_id5, player_user_id6, " +
                        "character_id1, character_id2, character_id3, character_id4, character_id5, character_id6, " +
                        "ROW_NUMBER() OVER(ORDER BY party_name) AS RowNumber " +
                        "FROM group7fa202330.userParty where owner_user_id = '" + userID + "' " +
                        ") " +
                        "Select * FROM CurrentSelection WHERE RowNumber = '" + currentIndex + "';", dataConnect);
                    }
                }
                else if (role == "Player")
                {
                    if (searchFor == 'P')
                    {
                        dataCommand = new SqlCommand("" +
                       "With CurrentSelection AS " +
                       "( " +
                       "SELECT owner_user_id, party_id, party_name, " +
                       "player_user_id1, player_user_id2, player_user_id3, player_user_id4, player_user_id5, player_user_id6, " +
                       "character_id1, character_id2, character_id3, character_id4, character_id5, character_id6, " +
                       "ROW_NUMBER() OVER(ORDER BY party_name) AS RowNumber " +
                       "FROM group7fa202330.userParty where player_user_id1 = '" + userID + "' " +
                            "or player_user_id2 = '" + userID + "' " +
                            "or player_user_id3 = '" + userID + "' " +
                            "or player_user_id4 = '" + userID + "' " +
                            "or player_user_id5 = '" + userID + "' " +
                            "or player_user_id6 = '" + userID + "' " +
                            ") " +
                       "Select * FROM CurrentSelection WHERE party_id = '" + partyId + "';", dataConnect);
                    }
                    else
                    {
                        dataCommand = new SqlCommand("" +
                            "With CurrentSelection AS " +
                            "( " +
                            "SELECT owner_user_id, party_id, party_name, " +
                            "player_user_id1, player_user_id2, player_user_id3, player_user_id4, player_user_id5, player_user_id6, " +
                            "character_id1, character_id2, character_id3, character_id4, character_id5, character_id6, " +
                            "ROW_NUMBER() OVER(ORDER BY party_name) AS RowNumber " +
                            "FROM group7fa202330.userParty where player_user_id1 = '" + userID + "' " +
                            "or player_user_id2 = '" + userID + "' " +
                            "or player_user_id3 = '" + userID + "' " +
                            "or player_user_id4 = '" + userID + "' " +
                            "or player_user_id5 = '" + userID + "' " +
                            "or player_user_id6 = '" + userID + "' " +
                            ") " +
                            "Select * FROM CurrentSelection WHERE RowNumber = '" + currentIndex + "';", dataConnect);
                    }
                }
                else
                {
                    if (searchFor == 'A')
                    {
                        dataCommand = new SqlCommand("" +
                        "With CurrentSelection AS " +
                        "( " +
                        "SELECT owner_user_id, party_id, party_name, " +
                        "player_user_id1, player_user_id2, player_user_id3, player_user_id4, player_user_id5, player_user_id6, " +
                        "character_id1, character_id2, character_id3, character_id4, character_id5, character_id6, " +
                        "ROW_NUMBER() OVER(ORDER BY party_name) AS RowNumber " +
                        "FROM group7fa202330.userParty" +
                        ") " +
                        "Select * FROM CurrentSelection WHERE RowNumber = '" + currentIndex + "';", dataConnect);
                    }
                }


                Console.WriteLine(dataCommand.CommandText);

                try
                {
                    dataConnect.Open();

                    SqlDataReader reader = dataCommand.ExecuteReader();
                    while (reader.Read())
                    {
                        userID = ReadSingleRow((IDataRecord)reader, 0);
                        string partyID = ReadSingleRow((IDataRecord)reader, 1);
                        string partyName = ReadSingleRow((IDataRecord)reader, 2);
                        string player1 = ReadSingleRow((IDataRecord)reader, 3);
                        string player2 = ReadSingleRow((IDataRecord)reader, 4);
                        string player3 = ReadSingleRow((IDataRecord)reader, 5);
                        string player4 = ReadSingleRow((IDataRecord)reader, 6);
                        string player5 = ReadSingleRow((IDataRecord)reader, 7);
                        string player6 = ReadSingleRow((IDataRecord)reader, 8);
                        string char1 = ReadSingleRow((IDataRecord)reader, 8);
                        string char2 = ReadSingleRow((IDataRecord)reader, 9);
                        string char3 = ReadSingleRow((IDataRecord)reader, 10);
                        string char4 = ReadSingleRow((IDataRecord)reader, 11);
                        string char5 = ReadSingleRow((IDataRecord)reader, 12);
                        string char6 = ReadSingleRow((IDataRecord)reader, 13);
                        ConnectVariables.SetPartyOwnerIDDP(userID);
                        ConnectVariables.SetPartyIDDP(partyID);
                        ConnectVariables.SetPartyNameDP(partyName);
                        ConnectVariables.SetPlayer1IDDP(player1);
                        ConnectVariables.SetPlayer2IDDP(player2);
                        ConnectVariables.SetPlayer3IDDP(player3);
                        ConnectVariables.SetPlayer4IDDP(player4);
                        ConnectVariables.SetPlayer5IDDP(player5);
                        ConnectVariables.SetPlayer6IDDP(player6);
                        ConnectVariables.SetChar1IDDP(char1);
                        ConnectVariables.SetChar2IDDP(char2);
                        ConnectVariables.SetChar3IDDP(char3);
                        ConnectVariables.SetChar4IDDP(char4);
                        ConnectVariables.SetChar5IDDP(char5);
                        ConnectVariables.SetChar6IDDP(char6);
                    }

                    dataConnect.Close();

                }

                catch (Exception x)
                {
                    Console.WriteLine(x.Message);
                }

            }


            return currentIndex.ToString();
        }


        internal static void GetPartyCharacterAmnt()
        {
            string partyID = ConnectVariables.GetPartyIDDP();

            using (SqlConnection dataConnect = new SqlConnection(dataConnection))
            {
                SqlCommand dataCommand = new SqlCommand("" +
                    "SELECT char_amnt FROM group7fa202330.userParty " +
                    "WHERE party_id = '" + partyID + "';", dataConnect);

                Console.WriteLine(dataCommand.CommandText);

                dataConnect.Open();
                SqlDataReader reader = dataCommand.ExecuteReader();
                while (reader.Read())
                {
                    string total = ReadSingleRow((IDataRecord)reader, 0);
                    ConnectVariables.SetCharacterAmntDP(total);
                }

                dataConnect.Close();
            }
        }



        internal static void GetPartyPlayerAmnt()
        {
            string partyID = ConnectVariables.GetPartyIDDP();

            using (SqlConnection dataConnect = new SqlConnection(dataConnection))
            {
                SqlCommand dataCommand = new SqlCommand("" +
                    "SELECT player_amnt FROM group7fa202330.userParty " +
                    "WHERE party_id = '" + partyID + "';", dataConnect);

                Console.WriteLine(dataCommand.CommandText);

                dataConnect.Open();
                SqlDataReader reader = dataCommand.ExecuteReader();
                while (reader.Read())
                {
                    string total = ReadSingleRow((IDataRecord)reader, 0);
                    ConnectVariables.SetPlayerAmntDP(total);
                }
            }
        }

        internal static void UpdatePartyAmount()
        {

            string partyID = ConnectVariables.GetPartyIDDP();

            string[] playerIDs = { ConnectVariables.GetPlayer1IDDP() ,
            ConnectVariables.GetPlayer2IDDP(),
            ConnectVariables.GetPlayer3IDDP(),
            ConnectVariables.GetPlayer4IDDP(),
            ConnectVariables.GetPlayer5IDDP(),
            ConnectVariables.GetPlayer6IDDP()},
            charIDs = { ConnectVariables.GetChar1IDDP(),
            ConnectVariables.GetChar2IDDP(),
            ConnectVariables.GetChar3IDDP(),
            ConnectVariables.GetChar4IDDP(),
            ConnectVariables.GetChar5IDDP(),
            ConnectVariables.GetChar6IDDP()};

            for (int i = 0; i < playerIDs.Length; i++)
            {
                if (playerIDs[i].Equals(""))
                {
                    playerIDs[i] = "";
                }
                Console.WriteLine("Nulled Player id: " + playerIDs[i]);
            }

            for (int i = 0; i < charIDs.Length; i++)
            {
                if (charIDs[i].Equals(""))
                {
                    charIDs[i] = "";
                }
                Console.WriteLine("Nulled Character id: " + charIDs[i]);
            }


            ConnectVariables.SetPlayer1IDDP(playerIDs[0]);
            ConnectVariables.SetPlayer2IDDP(playerIDs[1]);
            ConnectVariables.SetPlayer3IDDP(playerIDs[2]);
            ConnectVariables.SetPlayer4IDDP(playerIDs[3]);
            ConnectVariables.SetPlayer5IDDP(playerIDs[4]);
            ConnectVariables.SetPlayer6IDDP(playerIDs[5]);
            ConnectVariables.SetChar1IDDP(charIDs[0]);
            ConnectVariables.SetChar2IDDP(charIDs[1]);
            ConnectVariables.SetChar3IDDP(charIDs[2]);
            ConnectVariables.SetChar4IDDP(charIDs[3]);
            ConnectVariables.SetChar5IDDP(charIDs[4]);
            ConnectVariables.SetChar6IDDP(charIDs[5]);

            try
            {
                SqlConnection dataConnect = new SqlConnection(dataConnection);
                dataConnect.Open();

                //Updating Name Party

                SqlCommand dataCommand = new SqlCommand("UPDATE group7fa202330.userParty SET " +
                " player_user_id1 = '" + ConnectVariables.GetPlayer1IDDP() +
                "', player_user_id2 = '" + ConnectVariables.GetPlayer2IDDP() +
                "', player_user_id3 = '" + ConnectVariables.GetPlayer3IDDP() +
                "', player_user_id4 = '" + ConnectVariables.GetPlayer4IDDP() +
                "', player_user_id5 = '" + ConnectVariables.GetPlayer5IDDP() +
                "', player_user_id6 = '" + ConnectVariables.GetPlayer6IDDP() +
                "', character_id1 = '" + ConnectVariables.GetChar1IDDP() +
                "', character_id2 = '" + ConnectVariables.GetChar2IDDP() +
                "', character_id3 = '" + ConnectVariables.GetChar3IDDP() +
                "', character_id4 = '" + ConnectVariables.GetChar4IDDP() +
                "', character_id5 = '" + ConnectVariables.GetChar5IDDP() +
                "', character_id6 = '" + ConnectVariables.GetChar6IDDP() +

                "' WHERE owner_user_id = '" + GetUserId(ConnectVariables.GetLoggedInUsernameAs()) +
                "' AND party_id = '" + partyID +
                "';", dataConnect); ;

                Console.WriteLine("Command_1: " + dataCommand.CommandText.ToString());
                dataCommand.ExecuteNonQuery();

                Console.WriteLine("Updated party IDS");

                dataConnect.Close();
            }
            catch (SqlException ex)
            {
                Console.WriteLine(ex.ToString());
            }

        }
    }
}

