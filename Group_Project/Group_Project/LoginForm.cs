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
        public string obsPass, playPass, dmPass;

        private void LoginForm_Load(object sender, EventArgs e)
        {
            uSet = new UserSettings();
            uSet.BackgroundColor = Color.AliceBlue;
            this.DataBindings.Add(new Binding("BackColor", uSet, "BackgroundColor"));
        }

        void LoginForm_FormClosing(object sender, FormClosingEventArgs e)
        {
            uSet.Save();
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

        }

        private void btnInformation_Click(object sender, EventArgs e)
        {
            FormClass.infoF.Visible = true;
        }

        private void btnSubmit_Click(object sender, EventArgs e)
        {
            if(cboRole.SelectedIndex == 0 && txtPassWord.Text == obsPass)
            {
                FormClass.menuF.Role = 'O';
                FormClass.menuF.Visible = true;
                this.FormClosing += new FormClosingEventHandler(LoginForm_FormClosing);
                this.Visible = false;
            }
            else if(cboRole.SelectedIndex == 1 && txtPassWord.Text == playPass)
            {
                FormClass.menuF.Role = 'P';
                FormClass.menuF.Visible = true;
                this.FormClosing += new FormClosingEventHandler(LoginForm_FormClosing);
                this.Visible = false;
            }
            else if(cboRole.SelectedIndex == 2 && txtPassWord.Text == dmPass)
            {
                FormClass.menuF.Role = 'D';
                FormClass.menuF.Visible = true;
                this.FormClosing += new FormClosingEventHandler(LoginForm_FormClosing);
                this.Visible = false;
            }
            else
            {
                MessageBox.Show("Incorrect password entered. Please ensure password entered correctly for selected role.",
                    "Invalid password");
            }
        }
    }
}
