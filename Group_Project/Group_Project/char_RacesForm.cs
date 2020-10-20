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
        
        private void lbxRaces_SelectedIndexChanged(object sender, EventArgs e)
        {
            switch (lbxRaces.SelectedIndex)
            {
                case 0:
                    lblRaceDesc.Text = "Most common race. Capable of any class. While most common in general, Humans have many " +
                        "subdivisions and ethnically diverse variants.";
                    break;
                case 1:
                    lblRaceDesc.Text = "Frog-like people, can cling to surfaces and use extendable tongues. Phibids' skin secretes " +
                        "a constant mucus film, some family lines' mucus have become toxic to certain races.";
                    break;
                case 2:
                    lblRaceDesc.Text = "Dog people with features akin to doberman pinchers," +
                    " their sense of smell is considered the best of all civilized races.";
                    break;
                case 3:
                    lblRaceDesc.Text = "Pronounced as 'En-Eld', sophisticated high-class subsect of elves with typically" +
                    "pale skin and features.";
                    break;
                case 4:
                    lblRaceDesc.Text = "Generally low-class elves, often servants to the wealthy or powerful. Highly dexterous.";
                    break;
                case 5:
                    lblRaceDesc.Text = "Impoverous within most cities with a historically rich cultural background." +
                        "Despite their current state, they retain high pride in their heritage.";
                    break;
                case 6:
                    lblRaceDesc.Text = "Large, hulking race with rock-like skin. Generally spiritually focused personalities.";
                    break;
                case 7:
                    lblRaceDesc.Text = "A short, rat featured race. Often shunned and untrusted by others with histories to" +
                        "contribute to such racism. Their resiliance is noteworthy.";
                    break;
                case 8:
                    lblRaceDesc.Text = "Avian race with typcially hawk-like features. Some familial lines are capable of short" +
                        " distance flight. All are incredibly snobbish and look down on other races.";
                    break;
                case 9:
                    lblRaceDesc.Text = "Hyper attractive race of fox people, both male and female variants. Often use their " +
                        "beauty as a way to earn a living, either as 'services' or idols.";
                    break;
                default:
                    lblRaceDesc.Text = "";
                    break;
            }
            
        }
    }
}
