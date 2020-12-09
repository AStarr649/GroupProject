using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Group_Project
{
    public partial class PartyMakerForm : Form
    {
        public char viewBy = '0', curListSel = '0';
        public int rowIndex = 0;

        public PartyMakerForm()
        {
            InitializeComponent();
        }

        private void exitToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void btnReturnMenu_Click(object sender, EventArgs e)
        {
            Update('S');
            Update('P');
            if (txtPartyName.Text == "")
            {
                MessageBox.Show("Please SAVE or DELETE party before continuing.");
            }
            else
            {

                Update('L');
                FormClass.parMakeF.Hide();
                FormClass.menuF.Show();
            }
        }


        public void OnShowForm()
        {
            Update('D');
        }


        private void OnEnterSearch(object sender, EventArgs e)
        {
            if (txtbxSearch.Text == "Search by Username")
            {
                txtbxSearch.Text = "";
                txtbxSearch.ForeColor = Color.Black;
            }
        }

        private void OnLeaveSearch(object sender, EventArgs e)
        {
            if (txtbxSearch.Text == "")
            {
                txtbxSearch.Text = "Search by Username";
                txtbxSearch.ForeColor = Color.LightGray;
            }
        }

        private void btnRemovePt_Click(object sender, EventArgs e)
        {
            if (curListSel == 'C')
            {
                rowIndex = dbListCharList.CurrentRow.Index;
                dbListCharList.Rows.RemoveAt(rowIndex);
            }
            else if (curListSel == 'P')
            {
                rowIndex = dbListPartyList.CurrentRow.Index;
                dbListPartyList.Rows.RemoveAt(rowIndex);
            }
            else
            {
                MessageBox.Show("Please select a value to remove.");
            }
        }

        private void btnAdd2Pt_Click(object sender, EventArgs e)
        {
            bool found = ConnectDataBases.SearchForUser(txtbxSearch.Text);
            bool copy = false;
            if (found)
            {
                for (int i = 0; i < dbListPartyList.Rows.Count; i++)
                {
                    Console.WriteLine("\nPARTY MAKER FORM: i : " + i);
                    if (dbListPartyList.Rows.Count > 0)
                    {
                        Console.WriteLine("\nPARTY MAKER FORM: " + dbListPartyList.Rows[i].Cells[0].Value.ToString());
                        if (dbListPartyList.Rows[i].Cells[0].Value.ToString() == txtbxSearch.Text)
                            copy = true;
                        else
                            copy = false;
                    }
                    else
                        copy = false;
                }
                if (copy)
                {
                    MessageBox.Show("A person can only join once!");
                }
                else
                {
                    rowIndex = dbListPartyList.Rows.Add();
                    dbListPartyList.Rows[rowIndex].Cells[0].Value = ConnectVariables.GetUsernameDP();
                    dbListPartyList.Rows[rowIndex].Cells[1].Value = ConnectVariables.GetUserIDDP();
                }
            }
        }


        private void btnSelectChar_Click(object sender, EventArgs e)
        {
            FormClass.parMakeF.Hide();

            FormClass.charListF.Update('S');
            FormClass.charListF.Update('Z');
            FormClass.charListF.Update('M');
            FormClass.charListF.Update('C');

            FormClass.charListF.Show();

            //ConnectDataBases.LoadUserCharacter();
        }


        private void DoEnterCharList(object sender, EventArgs e)
        {
            curListSel = 'C';
        }


        private void DoEnterPartyList(object sender, EventArgs e)
        {
            curListSel = 'P';
        }

       /* private void btnDeleteParty_Click(object sender, EventArgs e)
        {
            ConnectDataBases.DeleteParty(ConnectVariables.GetPartyIDDP());
            FormClass.parMakeF.Hide();
            FormClass.menuF.Show();
        }
       */
       
        private void btnSave_Click(object sender, EventArgs e)
        {

        }
       
        public void Update(char VALUE = '0')
        {
            //Load all the info from the vairables saved
            if (VALUE == 'D')
            {
                Console.WriteLine("\nPARTY MAKER FORM: Updating Search Text");
                Console.WriteLine("\nPARTY MAKER FORM: Value of  viewBy: " + viewBy);
                txtbxSearch.Text = "Search by Username";
                txtbxSearch.ForeColor = Color.LightGray;
                if (viewBy == 'V')
                {
                    Console.WriteLine("\nPARTY MAKER FORM: Entered as Viewer");

                    txtPartyName.Enabled = false;
                    btnSave.Visible = false;
                    btnAdd2Pt.Visible = false;
                    btnRemovePt.Visible = false;
                    lblAddUser.Enabled = false;
                    txtbxSearch.Enabled = false;
                    btnDeleteParty.Enabled = false;
                    btnSelectChar.Visible = false;
                    btnLoadParty.Visible = true;
                }
                else
                {

                    if (ConnectVariables.GetRoleViewAs() == "Dungeon Master")
                    {
                        Console.WriteLine("\nPARTY MAKER FORM: Entered as DM");
                        txtPartyName.Enabled = true;

                        btnSave.Visible = true;
                        btnAdd2Pt.Visible = true;
                        btnRemovePt.Visible = true;
                        lblAddUser.Enabled = true;
                        txtbxSearch.Enabled = true;
                        btnDeleteParty.Enabled = true;

                        btnSelectChar.Visible = false;
                        btnLoadParty.Visible = false;
                    }
                    else if (ConnectVariables.GetRoleViewAs() == "Player")
                    {
                        Console.WriteLine("\nPARTY MAKER FORM: Entered as Player");
                        txtPartyName.Enabled = false;

                        btnSave.Visible = true;
                        btnAdd2Pt.Visible = false;
                        btnRemovePt.Visible = false;
                        lblAddUser.Enabled = false;
                        txtbxSearch.Enabled = false;
                        btnDeleteParty.Enabled = false;
                        btnSelectChar.Visible = true;
                        btnLoadParty.Visible = true;
                    }
                }
            }
            else if (VALUE == 'V')
            {
                viewBy = 'V';
            }
            else if (VALUE == 'N')
            {
                viewBy = 'N';
            }
            else if (VALUE == 'L')
            {
                dbListCharList.Rows.Clear();
                dbListPartyList.Rows.Clear();
                txtPartyName.Text = "";
            }
            else if (VALUE == 'P')
            {
                ConnectDataBases.UpdatePartyAmount();
            }
            else if (VALUE == 'R')
            {
                LoadForm();
            }
            else if (VALUE == 'S')
            {
                string role = ConnectVariables.GetRoleViewAs();
                string playerID1 = "", playerID2 = "", playerID3 = "", playerID4 = "", playerID5 = "", playerID6 = "",
                           charID1 = "", charID2 = "", charID3 = "", charID4 = "", charID5 = "", charID6 = "",
                           userID = ConnectVariables.GetLoggedInUsernameAs(),
                           partyID = ConnectVariables.GetPartyIDDP(),
                           partyName = txtPartyName.Text;
                ConnectVariables.SetPartyNameDP(partyName);
                userID = ConnectDataBases.GetUserId(userID);
                int pInt = dbListPartyList.Rows.Count, cInt = dbListCharList.Rows.Count;
                Console.WriteLine("\nPARTY MAKER FORM: pInt Value: " + pInt);
                Console.WriteLine("\nPARTY MAKER FORM: cInt Value: " + cInt);

                if (role == "Dungeon Master")
                {
                    if (txtPartyName.Text == "")
                    {
                        MessageBox.Show("Please fill out all input before saving.");
                    }
                    else
                    {
                       
                        if (pInt > 0)
                        {
                            switch (pInt)
                            {
                                case 1:
                                    {
                                        playerID1 = ConnectDataBases.GetUserId(dbListPartyList.Rows[0].Cells[0].Value.ToString());
                                        playerID2 = "";
                                        playerID3 = "";
                                        playerID4 = "";
                                        playerID5 = "";
                                        playerID6 = "";
                                        break;
                                    }
                                case 2:
                                    {
                                        playerID1 = ConnectDataBases.GetUserId(dbListPartyList.Rows[0].Cells[0].Value.ToString());
                                        playerID2 = ConnectDataBases.GetUserId(dbListPartyList.Rows[1].Cells[0].Value.ToString());
                                        playerID3 = "";
                                        playerID4 = "";
                                        playerID5 = "";
                                        playerID6 = "";
                                        break;
                                    }
                                case 3:
                                    {
                                        playerID1 = ConnectDataBases.GetUserId(dbListPartyList.Rows[0].Cells[0].Value.ToString());
                                        playerID2 = ConnectDataBases.GetUserId(dbListPartyList.Rows[1].Cells[0].Value.ToString());
                                        playerID3 = ConnectDataBases.GetUserId(dbListPartyList.Rows[2].Cells[0].Value.ToString());
                                        playerID4 = "";
                                        playerID5 = "";
                                        playerID6 = "";
                                        break;
                                    }
                                case 4:
                                    {
                                        playerID1 = ConnectDataBases.GetUserId(dbListPartyList.Rows[0].Cells[0].Value.ToString());
                                        playerID2 = ConnectDataBases.GetUserId(dbListPartyList.Rows[1].Cells[0].Value.ToString());
                                        playerID3 = ConnectDataBases.GetUserId(dbListPartyList.Rows[2].Cells[0].Value.ToString());
                                        playerID4 = ConnectDataBases.GetUserId(dbListPartyList.Rows[3].Cells[0].Value.ToString());
                                        playerID5 = "";
                                        playerID6 = "";
                                        break;
                                    }
                                case 5:
                                    {
                                        playerID1 = ConnectDataBases.GetUserId(dbListPartyList.Rows[0].Cells[0].Value.ToString());
                                        playerID2 = ConnectDataBases.GetUserId(dbListPartyList.Rows[1].Cells[0].Value.ToString());
                                        playerID3 = ConnectDataBases.GetUserId(dbListPartyList.Rows[2].Cells[0].Value.ToString());
                                        playerID4 = ConnectDataBases.GetUserId(dbListPartyList.Rows[3].Cells[0].Value.ToString());
                                        playerID5 = ConnectDataBases.GetUserId(dbListPartyList.Rows[4].Cells[0].Value.ToString());
                                        playerID6 = "";
                                        break;
                                    }
                                case 6:
                                    {
                                        playerID1 = ConnectDataBases.GetUserId(dbListPartyList.Rows[0].Cells[0].Value.ToString());
                                        playerID2 = ConnectDataBases.GetUserId(dbListPartyList.Rows[1].Cells[0].Value.ToString());
                                        playerID3 = ConnectDataBases.GetUserId(dbListPartyList.Rows[2].Cells[0].Value.ToString());
                                        playerID4 = ConnectDataBases.GetUserId(dbListPartyList.Rows[3].Cells[0].Value.ToString());
                                        playerID5 = ConnectDataBases.GetUserId(dbListPartyList.Rows[4].Cells[0].Value.ToString());
                                        playerID6 = ConnectDataBases.GetUserId(dbListPartyList.Rows[5].Cells[0].Value.ToString());
                                        break;
                                    }
                            }
                        }
                        if (cInt > 0)
                        {
                            switch (cInt)
                            {
                                case 1:
                                    {
                                        charID1 = ConnectDataBases.GetUserId(dbListCharList.Rows[0].Cells[0].Value.ToString());
                                        charID2 = "";
                                        charID3 = "";
                                        charID4 = "";
                                        charID5 = "";
                                        charID6 = "";
                                        break;
                                    }
                                case 2:
                                    {
                                        charID1 = ConnectDataBases.GetUserId(dbListCharList.Rows[0].Cells[0].Value.ToString());
                                        charID2 = ConnectDataBases.GetUserId(dbListCharList.Rows[1].Cells[0].Value.ToString());
                                        charID3 = "";
                                        charID4 = "";
                                        charID5 = "";
                                        charID6 = "";
                                        break;
                                    }
                                case 3:
                                    {
                                        charID1 = ConnectDataBases.GetUserId(dbListCharList.Rows[0].Cells[0].Value.ToString());
                                        charID2 = ConnectDataBases.GetUserId(dbListCharList.Rows[1].Cells[0].Value.ToString());
                                        charID3 = ConnectDataBases.GetUserId(dbListCharList.Rows[2].Cells[0].Value.ToString());
                                        charID4 = "";
                                        charID5 = "";
                                        charID6 = "";
                                        break;
                                    }
                                case 4:
                                    {
                                        charID1 = ConnectDataBases.GetUserId(dbListCharList.Rows[0].Cells[0].Value.ToString());
                                        charID2 = ConnectDataBases.GetUserId(dbListCharList.Rows[1].Cells[0].Value.ToString());
                                        charID3 = ConnectDataBases.GetUserId(dbListCharList.Rows[2].Cells[0].Value.ToString());
                                        charID4 = ConnectDataBases.GetUserId(dbListCharList.Rows[3].Cells[0].Value.ToString());
                                        charID5 = "";
                                        charID6 = "";
                                        break;
                                    }
                                case 5:
                                    {
                                        charID1 = ConnectDataBases.GetUserId(dbListCharList.Rows[0].Cells[0].Value.ToString());
                                        charID2 = ConnectDataBases.GetUserId(dbListCharList.Rows[1].Cells[0].Value.ToString());
                                        charID3 = ConnectDataBases.GetUserId(dbListCharList.Rows[2].Cells[0].Value.ToString());
                                        charID4 = ConnectDataBases.GetUserId(dbListCharList.Rows[3].Cells[0].Value.ToString());
                                        charID5 = ConnectDataBases.GetUserId(dbListCharList.Rows[4].Cells[0].Value.ToString());
                                        charID6 = "";
                                        break;
                                    }
                                case 6:
                                    {
                                        charID1 = ConnectDataBases.GetUserId(dbListCharList.Rows[0].Cells[0].Value.ToString());
                                        charID2 = ConnectDataBases.GetUserId(dbListCharList.Rows[1].Cells[0].Value.ToString());
                                        charID3 = ConnectDataBases.GetUserId(dbListCharList.Rows[2].Cells[0].Value.ToString());
                                        charID4 = ConnectDataBases.GetUserId(dbListCharList.Rows[3].Cells[0].Value.ToString());
                                        charID5 = ConnectDataBases.GetUserId(dbListCharList.Rows[4].Cells[0].Value.ToString());
                                        charID6 = ConnectDataBases.GetUserId(dbListCharList.Rows[5].Cells[0].Value.ToString());
                                        break;
                                    }
                            }
                        }
                        ConnectDataBases.UpdateParty(pInt, cInt, userID, partyID, partyName,
                     playerID1, playerID2, playerID3, playerID4, playerID5, playerID6,
                      charID1, charID2, charID3, charID4, charID5, charID6);
                        ConnectVariables.SetPlayer1IDDP(playerID1);
                        ConnectVariables.SetPlayer2IDDP(playerID2);
                        ConnectVariables.SetPlayer3IDDP(playerID3);
                        ConnectVariables.SetPlayer4IDDP(playerID4);
                        ConnectVariables.SetPlayer5IDDP(playerID5);
                        ConnectVariables.SetPlayer6IDDP(playerID6);
                        ConnectVariables.SetChar1IDDP(charID1);
                        ConnectVariables.SetChar2IDDP(charID2);
                        ConnectVariables.SetChar3IDDP(charID3);
                        ConnectVariables.SetChar4IDDP(charID4);
                        ConnectVariables.SetChar5IDDP(charID5);
                        ConnectVariables.SetChar6IDDP(charID6);
                    }
                }
                else if (role == "Player")
                {
                    if (cInt > 0)
                    {
                        switch (cInt)
                        {
                            case 1:
                                {
                                    charID1 = ConnectDataBases.GetUserId(dbListCharList.Rows[0].Cells[0].Value.ToString());
                                    charID2 = "";
                                    charID3 = "";
                                    charID4 = "";
                                    charID5 = "";
                                    charID6 = "";
                                    break;
                                }
                            case 2:
                                {
                                    charID1 = ConnectDataBases.GetUserId(dbListCharList.Rows[0].Cells[0].Value.ToString());
                                    charID2 = ConnectDataBases.GetUserId(dbListCharList.Rows[1].Cells[0].Value.ToString());
                                    charID3 = "";
                                    charID4 = "";
                                    charID5 = "";
                                    charID6 = "";
                                    break;
                                }
                            case 3:
                                {
                                    charID1 = ConnectDataBases.GetUserId(dbListCharList.Rows[0].Cells[0].Value.ToString());
                                    charID2 = ConnectDataBases.GetUserId(dbListCharList.Rows[1].Cells[0].Value.ToString());
                                    charID3 = ConnectDataBases.GetUserId(dbListCharList.Rows[2].Cells[0].Value.ToString());
                                    charID4 = "";
                                    charID5 = "";
                                    charID6 = "";
                                    break;
                                }
                            case 4:
                                {
                                    charID1 = ConnectDataBases.GetUserId(dbListCharList.Rows[0].Cells[0].Value.ToString());
                                    charID2 = ConnectDataBases.GetUserId(dbListCharList.Rows[1].Cells[0].Value.ToString());
                                    charID3 = ConnectDataBases.GetUserId(dbListCharList.Rows[2].Cells[0].Value.ToString());
                                    charID4 = ConnectDataBases.GetUserId(dbListCharList.Rows[3].Cells[0].Value.ToString());
                                    charID5 = "";
                                    charID6 = "";
                                    break;
                                }
                            case 5:
                                {
                                    charID1 = ConnectDataBases.GetUserId(dbListCharList.Rows[0].Cells[0].Value.ToString());
                                    charID2 = ConnectDataBases.GetUserId(dbListCharList.Rows[1].Cells[0].Value.ToString());
                                    charID3 = ConnectDataBases.GetUserId(dbListCharList.Rows[2].Cells[0].Value.ToString());
                                    charID4 = ConnectDataBases.GetUserId(dbListCharList.Rows[3].Cells[0].Value.ToString());
                                    charID5 = ConnectDataBases.GetUserId(dbListCharList.Rows[4].Cells[0].Value.ToString());
                                    charID6 = "";
                                    break;
                                }
                            case 6:
                                {
                                    charID1 = ConnectDataBases.GetUserId(dbListCharList.Rows[0].Cells[0].Value.ToString());
                                    charID2 = ConnectDataBases.GetUserId(dbListCharList.Rows[1].Cells[0].Value.ToString());
                                    charID3 = ConnectDataBases.GetUserId(dbListCharList.Rows[2].Cells[0].Value.ToString());
                                    charID4 = ConnectDataBases.GetUserId(dbListCharList.Rows[3].Cells[0].Value.ToString());
                                    charID5 = ConnectDataBases.GetUserId(dbListCharList.Rows[4].Cells[0].Value.ToString());
                                    charID6 = ConnectDataBases.GetUserId(dbListCharList.Rows[5].Cells[0].Value.ToString());
                                    break;
                                }
                        }
                    }
                    ConnectDataBases.UpdateParty(pInt, cInt, userID, partyID, partyName,
                 playerID1, playerID2, playerID3, playerID4, playerID5, playerID6,
                  charID1, charID2, charID3, charID4, charID5, charID6);
                    ConnectVariables.SetPlayer1IDDP(playerID1);
                    ConnectVariables.SetPlayer2IDDP(playerID2);
                    ConnectVariables.SetPlayer3IDDP(playerID3);
                    ConnectVariables.SetPlayer4IDDP(playerID4);
                    ConnectVariables.SetPlayer5IDDP(playerID5);
                    ConnectVariables.SetPlayer6IDDP(playerID6);
                    ConnectVariables.SetChar1IDDP(charID1);
                    ConnectVariables.SetChar2IDDP(charID2);
                    ConnectVariables.SetChar3IDDP(charID3);
                    ConnectVariables.SetChar4IDDP(charID4);
                    ConnectVariables.SetChar5IDDP(charID5);
                    ConnectVariables.SetChar6IDDP(charID6);
                }
            }
            

        }

        private void OnLeaveName(object sender, EventArgs e)
        {

            if (txtPartyName.Text == "")
            {
                txtPartyName.Text = "Party Name";
                txtPartyName.ForeColor = Color.LightGray;
            }
        }

        private void OnEnterName(object sender, EventArgs e)
        {

            if (txtPartyName.Text == "Party Name")
            {
                txtPartyName.Text = "";
                txtPartyName.ForeColor = Color.Black;
            }
        }

        private void btnLoadParty_Click(object sender, EventArgs e)
        {

            FormClass.partyLF.Update('A');
            Update('V');
            Update('L');
            FormClass.partyLF.Update('C');

            FormClass.parMakeF.Hide();
            FormClass.partyLF.Show();
        }

        public void LoadForm()
        {

            txtPartyName.Text = ConnectVariables.GetPartyNameDP();
            txtPartyCreatorName.Text = ConnectDataBases.GetUsername(ConnectVariables.GetPartyOwnerIDDP());


            ConnectDataBases.GetPartyPlayerAmnt();
                ConnectDataBases.GetPartyCharacterAmnt();
                int pInt = Int32.Parse(ConnectVariables.GetPlayerAmntDP()), cInt = Int32.Parse(ConnectVariables.GetCharacterAmntDP()), rowIndex =0;
                Console.WriteLine("\nPARTY MAKER FORM: pInt Value: " + pInt);
                Console.WriteLine("\nPARTY MAKER FORM: cInt Value: " + cInt);
                if (pInt > 0) 
                {
                    switch (pInt)
                    {
                        case 1:
                            {
                                rowIndex = dbListPartyList.Rows.Add();
                                dbListPartyList.Rows[rowIndex].Cells[0].Value = ConnectDataBases.GetUsername(ConnectVariables.GetPlayer1IDDP());
                            break;
                            }
                        case 2:
                            {
                                rowIndex = dbListPartyList.Rows.Add();
                                dbListPartyList.Rows[rowIndex].Cells[0].Value = ConnectDataBases.GetUsername(ConnectVariables.GetPlayer1IDDP());
                                rowIndex += dbListPartyList.Rows.Add();
                                dbListPartyList.Rows[rowIndex].Cells[0].Value = ConnectDataBases.GetUsername(ConnectVariables.GetPlayer2IDDP());
                                break;
                            }
                        case 3:
                            {
                                rowIndex = dbListPartyList.Rows.Add();
                                dbListPartyList.Rows[rowIndex].Cells[0].Value = ConnectDataBases.GetUsername(ConnectVariables.GetPlayer1IDDP());
                                rowIndex = dbListPartyList.Rows.Add();
                                dbListPartyList.Rows[rowIndex].Cells[0].Value = ConnectDataBases.GetUsername(ConnectVariables.GetPlayer2IDDP());
                                rowIndex = dbListPartyList.Rows.Add();
                                dbListPartyList.Rows[rowIndex].Cells[0].Value = ConnectDataBases.GetUsername(ConnectVariables.GetPlayer3IDDP());
                                break;
                            }
                        case 4:
                            {
                                rowIndex = dbListPartyList.Rows.Add();
                                dbListPartyList.Rows[rowIndex].Cells[0].Value = ConnectDataBases.GetUsername(ConnectVariables.GetPlayer1IDDP());
                                rowIndex = dbListPartyList.Rows.Add();
                                dbListPartyList.Rows[rowIndex].Cells[0].Value = ConnectDataBases.GetUsername(ConnectVariables.GetPlayer2IDDP());
                                rowIndex = dbListPartyList.Rows.Add();
                                dbListPartyList.Rows[rowIndex].Cells[0].Value = ConnectDataBases.GetUsername(ConnectVariables.GetPlayer3IDDP());
                                rowIndex = dbListPartyList.Rows.Add();
                                dbListPartyList.Rows[rowIndex].Cells[0].Value = ConnectDataBases.GetUsername(ConnectVariables.GetPlayer4IDDP());
                                break;
                            }
                        case 5:
                            {
                                rowIndex = dbListPartyList.Rows.Add();
                                dbListPartyList.Rows[rowIndex].Cells[0].Value = ConnectDataBases.GetUsername(ConnectVariables.GetPlayer1IDDP());
                                rowIndex = dbListPartyList.Rows.Add();
                                dbListPartyList.Rows[rowIndex].Cells[0].Value = ConnectDataBases.GetUsername(ConnectVariables.GetPlayer2IDDP());
                                rowIndex = dbListPartyList.Rows.Add();
                                dbListPartyList.Rows[rowIndex].Cells[0].Value = ConnectDataBases.GetUsername(ConnectVariables.GetPlayer3IDDP());
                                rowIndex = dbListPartyList.Rows.Add();
                                dbListPartyList.Rows[rowIndex].Cells[0].Value = ConnectDataBases.GetUsername(ConnectVariables.GetPlayer4IDDP());
                                rowIndex = dbListPartyList.Rows.Add();
                                dbListPartyList.Rows[rowIndex].Cells[0].Value = ConnectDataBases.GetUsername(ConnectVariables.GetPlayer5IDDP());
                                break;
                            }
                        case 6:
                            {
                                rowIndex = dbListPartyList.Rows.Add();
                                dbListPartyList.Rows[rowIndex].Cells[0].Value = ConnectDataBases.GetUsername(ConnectVariables.GetPlayer1IDDP());
                                rowIndex = dbListPartyList.Rows.Add();
                                dbListPartyList.Rows[rowIndex].Cells[0].Value = ConnectDataBases.GetUsername(ConnectVariables.GetPlayer2IDDP());
                                rowIndex = dbListPartyList.Rows.Add();
                                dbListPartyList.Rows[rowIndex].Cells[0].Value = ConnectDataBases.GetUsername(ConnectVariables.GetPlayer3IDDP());
                                rowIndex = dbListPartyList.Rows.Add();
                                dbListPartyList.Rows[rowIndex].Cells[0].Value = ConnectDataBases.GetUsername(ConnectVariables.GetPlayer4IDDP());
                                rowIndex = dbListPartyList.Rows.Add();
                                dbListPartyList.Rows[rowIndex].Cells[0].Value = ConnectDataBases.GetUsername(ConnectVariables.GetPlayer5IDDP());
                                rowIndex = dbListPartyList.Rows.Add();
                                dbListPartyList.Rows[rowIndex].Cells[0].Value = ConnectDataBases.GetUsername(ConnectVariables.GetPlayer6IDDP());
                                break;
                            }
                    }
                }
                if (cInt > 0)
                {
                    switch (cInt)
                    {
                        case 1:
                            {
                                rowIndex = dbListCharList.Rows.Add();
                                dbListCharList.Rows[rowIndex].Cells[0].Value = ConnectDataBases.GetUsername(ConnectVariables.GetChar1IDDP());
                                break;
                            }
                        case 2:
                            {
                                rowIndex = dbListCharList.Rows.Add();
                                dbListCharList.Rows[rowIndex].Cells[0].Value = ConnectDataBases.GetUsername(ConnectVariables.GetChar1IDDP());
                                rowIndex = dbListCharList.Rows.Add();
                                dbListCharList.Rows[rowIndex].Cells[0].Value = ConnectDataBases.GetUsername(ConnectVariables.GetChar2IDDP());
                                break;
                            }
                        case 3:
                            {
                                rowIndex = dbListCharList.Rows.Add();
                                dbListCharList.Rows[rowIndex].Cells[0].Value = ConnectDataBases.GetUsername(ConnectVariables.GetChar1IDDP());
                                rowIndex = dbListCharList.Rows.Add();
                                dbListCharList.Rows[rowIndex].Cells[0].Value = ConnectDataBases.GetUsername(ConnectVariables.GetChar2IDDP());
                                rowIndex = dbListCharList.Rows.Add();
                                dbListCharList.Rows[rowIndex].Cells[0].Value = ConnectDataBases.GetUsername(ConnectVariables.GetChar3IDDP());
                                break;
                            }
                        case 4:
                            {
                                rowIndex = dbListCharList.Rows.Add();
                                dbListCharList.Rows[rowIndex].Cells[0].Value = ConnectDataBases.GetUsername(ConnectVariables.GetChar1IDDP());
                                rowIndex = dbListCharList.Rows.Add();
                                dbListCharList.Rows[rowIndex].Cells[0].Value = ConnectDataBases.GetUsername(ConnectVariables.GetChar2IDDP());
                                rowIndex = dbListCharList.Rows.Add();
                                dbListCharList.Rows[rowIndex].Cells[0].Value = ConnectDataBases.GetUsername(ConnectVariables.GetChar3IDDP());
                                rowIndex = dbListCharList.Rows.Add();
                                dbListCharList.Rows[rowIndex].Cells[0].Value = ConnectDataBases.GetUsername(ConnectVariables.GetChar4IDDP());
                            break;
                            }
                        case 5:
                            {
                                rowIndex = dbListCharList.Rows.Add();
                                dbListCharList.Rows[rowIndex].Cells[0].Value = ConnectDataBases.GetUsername(ConnectVariables.GetChar1IDDP());
                                rowIndex = dbListCharList.Rows.Add();
                                dbListCharList.Rows[rowIndex].Cells[0].Value = ConnectDataBases.GetUsername(ConnectVariables.GetChar2IDDP());
                                rowIndex = dbListCharList.Rows.Add();
                                dbListCharList.Rows[rowIndex].Cells[0].Value = ConnectDataBases.GetUsername(ConnectVariables.GetChar3IDDP());
                                rowIndex = dbListCharList.Rows.Add();
                                dbListCharList.Rows[rowIndex].Cells[0].Value = ConnectDataBases.GetUsername(ConnectVariables.GetChar4IDDP());
                                rowIndex = dbListCharList.Rows.Add();
                                dbListCharList.Rows[rowIndex].Cells[0].Value = ConnectDataBases.GetUsername(ConnectVariables.GetChar5IDDP());
                                break;
                            }
                        case 6:
                            {
                                rowIndex = dbListCharList.Rows.Add();
                                dbListCharList.Rows[rowIndex].Cells[0].Value = ConnectDataBases.GetUsername(ConnectVariables.GetChar1IDDP());
                                rowIndex = dbListCharList.Rows.Add();
                                dbListCharList.Rows[rowIndex].Cells[0].Value = ConnectDataBases.GetUsername(ConnectVariables.GetChar2IDDP());
                                rowIndex = dbListCharList.Rows.Add();
                                dbListCharList.Rows[rowIndex].Cells[0].Value = ConnectDataBases.GetUsername(ConnectVariables.GetChar3IDDP());
                                rowIndex = dbListCharList.Rows.Add();
                                dbListCharList.Rows[rowIndex].Cells[0].Value = ConnectDataBases.GetUsername(ConnectVariables.GetChar4IDDP());
                                rowIndex = dbListCharList.Rows.Add();
                                dbListCharList.Rows[rowIndex].Cells[0].Value = ConnectDataBases.GetUsername(ConnectVariables.GetChar5IDDP());
                                rowIndex = dbListCharList.Rows.Add();
                                dbListCharList.Rows[rowIndex].Cells[0].Value = ConnectDataBases.GetUsername(ConnectVariables.GetChar6IDDP());
                                break;
                            }
                    }

                }

            
        }

    }
}
