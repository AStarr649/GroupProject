using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Group_Project
{
    class FormClass
    {
        public static LoginForm sf = new LoginForm();
        public static InfoForm infoF = new InfoForm();
        public static MenuForm menuF = new MenuForm();
        public static PartyLists partyLF = new PartyLists();
        public static PartyMakerForm parMakeF = new PartyMakerForm();
        public static PWRecoverForm pwreF = new PWRecoverForm();
        public static CharacterList charListF = new CharacterList();
        public static Char_CreationForm charF = new Char_CreationForm();
        public static char_ClassesForm cClassF = new char_ClassesForm();
        public static char_RacesForm cRaceF = new char_RacesForm();
        public static CreateAccountForm createAccF = new CreateAccountForm();
        public static ConnectDataBases conDB = new ConnectDataBases();
        public static ConnectVariables conV = new ConnectVariables();
        public static Char_SelectEditForm cSEF = new Char_SelectEditForm();
        public static PartySelectEditForm pSEF = new PartySelectEditForm();
    }
}
