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
    public partial class InfoForm : Form
    {
        public string infoText = "This program is a collaborated project created by Alexander Starr and Ty Robinson." +
            "\n\nEach role has certain privelages that others may not, for example Observers cannot edit characters or parties.";

        public InfoForm()
        {
            InitializeComponent();
            lblInfo.Text = infoText;
        }

        private void btnOkay_Click(object sender, EventArgs e)
        {
            this.Visible = false;
        }
    }
}
