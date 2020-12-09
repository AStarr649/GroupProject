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
    public partial class PartySelectEditForm : Form
    {
        public PartySelectEditForm()
        {
            InitializeComponent();
        }

        private void btnLoadPlayerParties_Click(object sender, EventArgs e)
        {
           
                FormClass.partyLF.Update('Z');
                FormClass.parMakeF.Update('N');
                FormClass.partyLF.Update('C');
                FormClass.pSEF.Hide();
                FormClass.partyLF.Show();
        }

        private void btnLoadAllParties_Click(object sender, EventArgs e)
        {
            FormClass.partyLF.Update('A');
            FormClass.parMakeF.Update('V');
            FormClass.partyLF.Update('C');
            FormClass.pSEF.Hide();
            FormClass.partyLF.Show();
        }
    }
}
