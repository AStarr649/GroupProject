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
    public partial class char_RacesForm : Form
    {
        public char_RacesForm()
        {
            InitializeComponent();
        }

        private void btnSelect_Click(object sender, EventArgs e)
        {
            FormClass.charF.char_Race = lbxRaces.SelectedIndex.ToString();
            this.Close();
            FormClass.charF.Enabled = true;
        }

        private void btnCancel_Click(object sender, EventArgs e)
        {
            this.Close();
            FormClass.charF.Enabled = true;
        }
    }
}
