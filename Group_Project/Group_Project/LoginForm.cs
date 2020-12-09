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
    public partial class LoginForm : Form
    {
        public UserSettings uSet;
        //public string obsPass="pass7", playPass="pass3", dmPass="pass1";

        private void LoginForm_Load(object sender, EventArgs e)
        {
            uSet = new UserSettings();
            uSet.BackgroundColor = Color.AliceBlue;
            this.DataBindings.Add(new Binding("BackColor", uSet, "BackgroundColor"));
        }

        void LoginForm_FormClosing(object sender, FormClosingEventArgs e)
        {
            //uSet.Save();
        }

        public LoginForm()
        {
            InitializeComponent();
        }

        private void exitToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void linkPWReset_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            this.Visible = false;
            bool loggedIn = false;
            string form = "loginF";
            Console.WriteLine("\n\nForm: " + form);
            ConnectVariables.SetPasswordRecoverViewAs(loggedIn);
            ConnectVariables.SetLasetLoggedFormAs(form);
            FormClass.pwreF.Visible = true;
            FormClass.pwreF.UpdatePWRecoverForm();
        }

        private void lnkCreateAcct_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            this.Visible = false;
            FormClass.createAccF.Show();
        }

        private void btnInformation_Click(object sender, EventArgs e)
        {
            try
            {
                FormClass.infoF.Show();
            }
            catch (Exception x)
            {
                Console.WriteLine(x);
            }
        }

        private void btnSubmit_Click(object sender, EventArgs e)
        {
            if (cboRole.Text != "")
            {
                bool valid = ConnectDataBases.LoginCheck(txtUserID.Text, txtPassWord.Text, cboRole.Text);
                if (valid)
                {
                    //This is suppose to be tied to the user settings of theme/customization 
                    //being saved to that user. if the user changes the theme or font or watever settings 
                    //we make for customization, it saves and keeps those choices throughout the program 
                    //from form to form
                    this.FormClosing += new FormClosingEventHandler(LoginForm_FormClosing);                        
                    this.Visible = false; 
                    FormClass.menuF.Visible = true;
                    FormClass.menuF.UpdateMenuFormForRole();
                    txtUserID.Text = "";
                    txtPassWord.Text = "";
                }
            }
            else
            {
                MessageBox.Show("Please select a role to login as.");
            }
        }
    }
}
