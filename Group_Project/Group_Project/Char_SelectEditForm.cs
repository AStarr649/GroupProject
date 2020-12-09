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
    public partial class Char_SelectEditForm : Form
    {
        public Char_SelectEditForm()
        {
            InitializeComponent();
        }

        private void btnCreateChar_Click(object sender, EventArgs e)
        {
            FormClass.cSEF.Hide();
            FormClass.charF.Update('M');
            FormClass.charListF.Update('Z');
            FormClass.charListF.Update('B');
            FormClass.charF.Show();
        }

        private void btnLoadChar_Click(object sender, EventArgs e)
        {
            FormClass.cSEF.Hide();
            FormClass.charF.Update('L');
            FormClass.charListF.Update('Z');
            FormClass.charListF.Update('M');
            FormClass.charListF.Update('C');
            FormClass.charListF.Show();
        }
    }
}
