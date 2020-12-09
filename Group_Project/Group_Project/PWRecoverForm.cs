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
    public partial class PWRecoverForm : Form
    {
        public string result, question;
        public PWRecoverForm()
        {
            InitializeComponent();
        }

        private void btnRecover_Click(object sender, EventArgs e)
        {
            ConnectDataBases.SendOTP(txtEmail_In.Text);
        }

        private void btnChangePW_Click(object sender, EventArgs e)
        {
            string loggedInUsername = ConnectVariables.GetLoggedInUsernameAs();
            ConnectDataBases.ResetPassword(loggedInUsername, txtNewPW.Text, txtConfirmNewPW.Text);
        }

        private void btnSubmit_Click(object sender, EventArgs e)
        {
            /*
            using (DataClassesDataContext db = new DataClassesDataContext())
            {
                db.spCheckEmail(txtEmail_In.Text, "CheckSecurity", ref result, ref question, txtSecurAnw.Text, txtConfirmNewPW.Text);
                db.SubmitChanges();
                MessageBox.Show(result);
                if (result == "Enter new Password !!!")
                {
                    txtSecurityQ.Text = question;
                    gbxChangePW.Show();
                }
                else
                {
                    txtSecurityQ.Text = "";
                    gbxChangePW.Hide();
                }
            }*/
        }

        private void btnReturn_Click(object sender, EventArgs e)
        {

            string lastForm = "";


            lastForm = ConnectVariables.GetLasetLoggedFormAs();

            FormClass.pwreF.Hide();

            if (lastForm == "loginF")
            {
                FormClass.sf.Show();
            }
            else if (lastForm == "menuF")
            {
                FormClass.menuF.Show();
                FormClass.menuF.UpdateMenuFormForRole();
            }

        }

        private void exitToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        public void UpdatePWRecoverForm()
        {
            System.Console.WriteLine("ENTERING PW RECOVER LOADING");
            bool viewAsLoggedIn;
            viewAsLoggedIn = ConnectVariables.GetPasswordRecoverViewAs();
            if (viewAsLoggedIn == false)
                gbxChangePW.Hide();
            else
                gbxChangePW.Show();
            gbxRecoverPW.Show();
        }        
    }
}
