using System;

namespace Group_Project
{
    public class ConnectVariables
    {
        public static bool loggedInState;
        public static string lastFormLogged, userUsername, userRole,
            charIDDP, charNameDP, charGenderDP, chareRaceDP, charClassDP, usernameDP, userIDDP, charElementDP,
            charStrDP, charConstDP, charDexDP, charWisDP, charIntelDP, charCharismaDP, charLuckDP,
            charBrawnDP, charHealthDP, charNimDP, charMemDP, charCleverDP, charCharmDP,
            charTal1DP, charTal2DP, charTal3DP,
            charQui1DP, charQui2DP, charQui3DP,

            partyIDDP, partyOwnerIDDP, partyNameDP, playerAmntDP, characterAmntDP,
            player1IDDP, player2IDDP, player3IDDP, player4IDDP, player5IDDP, player6IDDP,
            char1IDDP, char2IDDP, char3IDDP, char4IDDP, char5IDDP, char6IDDP;
        internal static void SetPasswordRecoverViewAs(bool amLoggedIn)
        {
            System.Console.WriteLine("\n\nSetting state of being logged in Before: " + loggedInState);
            loggedInState = amLoggedIn;
            System.Console.WriteLine("Setting state of being logged in After: " + loggedInState + "\n\n");
        }
        internal static bool GetPasswordRecoverViewAs()
        {
            System.Console.WriteLine("\n\nGetting state of being logged in: " + loggedInState + "\n\n");
            return loggedInState;
        }

        internal static void SetLasetLoggedFormAs(string form)
        {
            System.Console.WriteLine("\n\nSetting last form in Before: " + lastFormLogged);
            lastFormLogged = form;
            System.Console.WriteLine("Setting last form in After: " + lastFormLogged + "\n\n");
        }

        internal static string GetLasetLoggedFormAs()
        {
            System.Console.WriteLine("\n\nGetting last form: " + lastFormLogged + "\n\n");
            return lastFormLogged;
        }

        internal static void SetLoggedInUsernameAs(string username)
        {
            System.Console.WriteLine("\n\nSetting users username in Before: " + userUsername);
            userUsername = username;
            System.Console.WriteLine("Setting users username in After: " + userUsername + "\n\n");
        }
        internal static string GetLoggedInUsernameAs()
        {
            System.Console.WriteLine("\n\nGetting last form: " + userUsername + "\n\n");
            return userUsername;
        }

        internal static void SetRoleViewAs(string role)
        {
            System.Console.WriteLine("\n\nSetting users role in Before: " + userRole);
            userRole = role;
            System.Console.WriteLine("Setting users role in After: " + userRole + "\n\n");

        }
        internal static string GetRoleViewAs()
        {
            System.Console.WriteLine("\n\nGetting users role as: " + userRole + "\n\n");
            return userRole;
        }


        internal static void SetCharIDDP(string x)
        {
            charIDDP = x;
        }
        internal static string GetCharIDDP()
        {
            return charIDDP;
        }
        internal static void SetCharNameDP(string x)
        {
            charNameDP = x;
        }
        internal static string GetCharNameDP()
        {
            return charNameDP;
        }
        internal static void SetCharGenderDP(string x)
        {
            charGenderDP = x;
        }
        internal static string GetCharGenderDP()
        {
            return charGenderDP;
        }
        internal static void SetCharRaceDP(string x)
        {
            chareRaceDP = x;
        }
        internal static string GetCharRaceDP()
        {
            return chareRaceDP;
        }
        internal static void SetCharClassDP(string x)
        {
            charClassDP = x;
        }
        internal static string GetCharClassDP()
        {
            return charClassDP;
        }
        internal static void SetUsernamesDP(string x)
        {
            usernameDP = x;
        }
        internal static string GetUsernameDP()
        {
            return usernameDP;
        }
        internal static void SetUserIDDP(string x)
        {
            userIDDP = x;
        }
        internal static string GetUserIDDP()
        {
            return userIDDP;
        }
        internal static void SetCharElementDP(string x)
        {
            charElementDP = x;
        }
        internal static string GetCharElementDP()
        {
            return charElementDP;
        }
        internal static void SetCharStrengthDP(string x)
        {
            charStrDP = x;
        }
        internal static string GetCharStrengthDP()
        {
            return charStrDP;
        }
        internal static void SetCharConstDP(string x)
        {
            charConstDP = x;
        }
        internal static string GetCharConstDP()
        {
            return charConstDP;
        }
        internal static void SetCharDexDP(string x)
        {
            charDexDP = x;
        }
        internal static string GetCharDexDP()
        {
            return charDexDP;
        }
        internal static void SetCharWisDP(string x)
        {
            charWisDP = x;
        }
        internal static string GetCharWisDP()
        {
            return charWisDP;
        }
        internal static void SetCharIntelDP(string x)
        {
            charIntelDP = x;
        }
        internal static string GetCharIntelDP()
        {
            return charIntelDP;
        }
        internal static void SetCharCharismaDP(string x)
        {
            charCharismaDP = x;
        }
        internal static string GetCharCharismaDP()
        {
            return charCharismaDP;
        }
        internal static void SetCharLuckDP(string x)
        {
            charLuckDP = x;
        }
        internal static string GetCharLuckDP()
        {
            return charLuckDP;
        }
        internal static void SetCharBrawnDP(string x)
        {
            charBrawnDP = x;
        }
        internal static string GetCharBrawnDP()
        {
            return charBrawnDP;
        }
        internal static void SetCharHealthDP(string x)
        {
            charHealthDP = x;
        }
        internal static string GetCharHealthDP()
        {
            return charHealthDP;
        }
        internal static void SetCharNimDP(string x)
        {
            charNimDP = x;
        }
        internal static string GetCharNimDP()
        {
            return charNimDP;
        }
        internal static void SetCharMemDP(string x)
        {
            charMemDP = x;
        }
        internal static string GetCharMemDP()
        {
            return charMemDP;
        }
        internal static void SetCharCleverDP(string x)
        {
            charCleverDP = x;
        }
        internal static string GetCharCleverDP()
        {
            return charCleverDP;
        }
        internal static void SetCharCharmDP(string x)
        {
            charCharmDP = x;
        }
        internal static string GetCharCharmDP()
        {
            return charCharmDP;
        }
        internal static void SetCharTalDP1(string x)
        {
            charTal1DP = x;
        }
        internal static string GetCharTalDP1()
        {
            return charTal1DP;
        }
        internal static void SetCharTalDP2(string x)
        {
            charTal2DP = x;
        }
        internal static string GetCharTalDP2()
        {
            return charTal2DP;
        }
        internal static void SetCharTalDP3(string x)
        {
            charTal3DP = x;
        }
        internal static string GetCharTalDP3()
        {
            return charTal3DP;
        }
        internal static void SetCharQuiDP1(string x)
        {
            charQui1DP = x;
        }
        internal static string GetCharQuiDP1()
        {
            return charQui1DP;
        }
        internal static void SetCharQuiDP2(string x)
        {
            charQui2DP = x;
        }
        internal static string GetCharQuiDP2()
        {
            return charQui2DP;
        }
        internal static void SetCharQuiDP3(string x)
        {
            charQui3DP = x;
        }
        internal static string GetCharQuiDP3()
        {
            return charQui3DP;
        }

        internal static void SetPartyIDDP(string x)
        {
            partyIDDP = x;
        }
        internal static string GetPartyIDDP()
        {
            return partyIDDP;
        }
        internal static void SetPartyOwnerIDDP(string x)
        {
            partyOwnerIDDP = x;
        }
        internal static string GetPartyOwnerIDDP()
        {
            return partyOwnerIDDP;
        }

        internal static void SetPlayerAmntDP(string x)
        {
            playerAmntDP = x;
        }
        internal static string GetPlayerAmntDP()
        {
            return playerAmntDP;
        }
        internal static void SetPartyNameDP(string x)
        {
            partyNameDP = x;
        }
        internal static string GetPartyNameDP()
        {
            return partyNameDP;
        }

        internal static void SetPlayer1IDDP(string x)
        {
            player1IDDP = x;
        }
        internal static string GetPlayer1IDDP()
        {
            return player1IDDP;
        }

        internal static void SetPlayer2IDDP(string x)
        {
            player2IDDP = x;
        }
        internal static string GetPlayer2IDDP()
        {
            return player2IDDP;
        }
        internal static void SetPlayer3IDDP(string x)
        {
            player3IDDP = x;
        }
        internal static string GetPlayer3IDDP()
        {
            return player3IDDP;
        }
        internal static void SetPlayer4IDDP(string x)
        {
            player4IDDP = x;
        }
        internal static string GetPlayer4IDDP()
        {
            return player4IDDP;
        }
        internal static void SetPlayer5IDDP(string x)
        {
            player5IDDP = x;
        }
        internal static string GetPlayer5IDDP()
        {
            return player5IDDP;
        }
        internal static void SetPlayer6IDDP(string x)
        {
            player6IDDP = x;
        }
        internal static string GetPlayer6IDDP()
        {
            return player6IDDP;
        }
        internal static void SetChar1IDDP(string x)
        {
            char1IDDP = x;
        }
        internal static string GetChar1IDDP()
        {
            return char1IDDP;
        }
        internal static void SetChar2IDDP(string x)
        {
            char2IDDP = x;
        }
        internal static string GetChar2IDDP()
        {
            return char2IDDP;
        }
        internal static void SetChar3IDDP(string x)
        {
            char3IDDP = x;
        }
        internal static string GetChar3IDDP()
        {
            return char3IDDP;
        }
        internal static void SetChar4IDDP(string x)
        {
            char4IDDP = x;
        }
        internal static string GetChar4IDDP()
        {
            return char4IDDP;
        }
        internal static void SetChar5IDDP(string x)
        {
            char5IDDP = x;
        }
        internal static string GetChar5IDDP()
        {
            return char5IDDP;
        }
        internal static void SetChar6IDDP(string x)
        {
            char6IDDP = x;
        }
        internal static string GetChar6IDDP()
        {
            return char6IDDP;
        }
        internal static void SetCharacterAmntDP(string x)
        {
            characterAmntDP = x;
        }
        internal static string GetCharacterAmntDP()
        {
            return characterAmntDP;
        }

    }
}

