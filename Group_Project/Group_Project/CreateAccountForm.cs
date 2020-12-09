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
    public partial class CreateAccountForm : Form
    {
        public CreateAccountForm()
        {
            InitializeComponent();
        }

        private void exitToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        [Obsolete]
        private void btnCreateAcct_Click(object sender, EventArgs e)
        {
            //checking if all fields are filled
            if (txtFName.Text == "" || txtLName.Text == "" || txtEmail.Text == "" ||
                txtUsername.Text == "" || txtPassword.Text == "" || txtConfirmPW.Text == "")
            {
                MessageBox.Show("All fields must be filled before creating account.");
            }
            else if(txtPassword.Text != txtConfirmPW.Text)
            {
                MessageBox.Show("You passwords must match");
            }
            else 
            { 
                ConnectDataBases.CreateAccount(txtFName.Text, txtLName.Text, txtEmail.Text, txtUsername.Text, txtPassword.Text);
            }
        }

        private void btnReturn_Click(object sender, EventArgs e)
        {
            FormClass.createAccF.Hide();
            FormClass.sf.Show();
        }
    }
}
