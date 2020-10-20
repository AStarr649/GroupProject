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
            using (DataClassesDataContext db = new DataClassesDataContext())
            {
                db.spCheckEmail(txtEmail_In.Text, "CheckEmail", ref result, ref question, txtSecurAnw.Text, txtConfirmNewPW.Text);
                db.SubmitChanges();
                MessageBox.Show(result);
                if(result == "Enter new Password !!!")
                {
                    txtSecurityQ.Text = question;
                    gbxChangePW.Show();
                }
                else
                {
                    txtSecurityQ.Text = "";
                    gbxChangePW.Hide();
                }
            }
        }

        private void btnChangePW_Click(object sender, EventArgs e)
        {
            if(txtNewPW.Text == txtConfirmNewPW.Text)
            {
                using (DataClassesDataContext db = new DataClassesDataContext())
                {
                    db.spCheckEmail(txtEmail_In.Text, "ChangePassword", ref result, txtSecurAnw.Text, txtConfirmNewPW.Text);
                    db.SubmitChanges();
                    MessageBox.Show(result);
                    txtEmail_In.Text = "";
                    txtSecurAnw.Text = "";
                    txtNewPW.Text = "";
                    txtConfirmNewPW.Text = "";
                    txtSecurityQ.Text = "";
                    gbxSecurity.Hide();
                    gbxChangePW.Hide();
                }
            }
            else
            {
                MessageBox.Show("Password does not match.");
            }
        }

        private void btnSubmit_Click(object sender, EventArgs e)
        {
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
            }
        }

        private void PWRecoverForm_Load(object sender, EventArgs e)
        {
            gbxSecurity.Hide();
            gbxChangePW.Hide();
        }
    }
}
