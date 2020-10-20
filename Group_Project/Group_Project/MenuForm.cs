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
            switch(Role)
            {
                case 'O':
                    btnCharCreate.Enabled = false;
                    btnParCreate.Enabled = false;
                    break;
                case 'P':
                    btnParCreate.Enabled = false;
                    break;
                case 'D':
                    break;
                default:
                    break;
            }
        }
        
        private void exitToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }
    }
}
