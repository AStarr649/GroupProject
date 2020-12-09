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
    public partial class MenuForm : Form
    {
        public char Role;

        public MenuForm()
        {
            InitializeComponent();
        }

        private void exitToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void btnCharCreate_Click(object sender, EventArgs e)
        {
            FormClass.cSEF.Show();
            FormClass.menuF.Hide();
            FormClass.charF.Update();
        }

        private void passwordManagerToolStripMenuItem_Click(object sender, EventArgs e)
        {
            bool loggedIn = true;
            string form = "menuF";
            Console.WriteLine("\n\nForm: " + form);
            ConnectVariables.SetPasswordRecoverViewAs(loggedIn);
            ConnectVariables.SetLasetLoggedFormAs(form); ;
            FormClass.pwreF.Visible = true;
            FormClass.menuF.Hide();
            FormClass.pwreF.UpdatePWRecoverForm();
        }

        public void UpdateMenuFormForRole()
        {
            string role = ConnectVariables.GetRoleViewAs();

            if (role == "Observer")
            {
                btnCharCreate.Enabled = false;
                btnParCreate.Enabled = false;
                btnCharBrowse.Enabled = true;
                btnViewParty.Enabled = true;
            }
            else if (role == "Player")
            {
                btnCharCreate.Enabled = true;
                btnParCreate.Enabled = false;
                btnCharBrowse.Enabled = true;
                btnViewParty.Enabled = true;
            }
            else if (role == "Dungeon Master")
            {
                btnCharCreate.Enabled = false;
                btnParCreate.Enabled = true;
                btnCharBrowse.Enabled = true;
                btnViewParty.Enabled = true;
            }

        }

        private void btnLogOut_Click(object sender, EventArgs e)
        {
            FormClass.menuF.Hide();
            FormClass.sf.Show();
        }

        private void btnParCreate_Click(object sender, EventArgs e)
        {
            ConnectDataBases.CreateParty();
            FormClass.parMakeF.OnShowForm();
            FormClass.menuF.Hide();
            FormClass.parMakeF.Show();
        }

        private void btnCharBrowse_Click(object sender, EventArgs e)
        {
            FormClass.charF.Update('O');
            FormClass.charListF.Update('A');
            FormClass.charListF.Update('M');
            FormClass.charListF.Update('C');
            FormClass.menuF.Hide();
            FormClass.charListF.Show();
        }

        private void btnViewParty_Click(object sender, EventArgs e)
        {
            FormClass.menuF.Hide();
            if (ConnectVariables.GetRoleViewAs() == "Observer")
            {

                FormClass.partyLF.Update('A');
                FormClass.parMakeF.Update('V');
                FormClass.partyLF.Update('C');

                FormClass.menuF.Hide();
                FormClass.partyLF.Show();
            }
            else
            {
                FormClass.pSEF.Show();
            }
        }
    }
}
