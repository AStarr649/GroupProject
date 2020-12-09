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
    public partial class char_ClassesForm : Form
    {
        public char_ClassesForm()
        {
            InitializeComponent();
        }

        private void btnSelect_Click(object sender, EventArgs e)
        {
            FormClass.charF.class_index = lbxClasses.SelectedIndex;
            FormClass.charF.char_Class = lbxClasses.SelectedItem.ToString();
            FormClass.charF.Update('C');
            FormClass.cClassF.Hide();
            FormClass.charF.Show();
        }

        private void btnCancel_Click(object sender, EventArgs e)
        {
            FormClass.cClassF.Hide();
            FormClass.charF.Show();
        }

        private void lbxClasses_SelectedIndexChanged(object sender, EventArgs e)
        {
            switch (lbxClasses.SelectedIndex)
            {
                case 0:
                    lblClassDesc.Text = "Physically power, often acting without thinking.";
                    break;
                case 1:
                    lblClassDesc.Text = "Strong, heavily armored class, the 'tank' of battles.";
                    break;
                case 2:
                    lblClassDesc.Text = "Spiritualist capable of restorative magicks and enchancements.";
                    break;
                case 3:
                    lblClassDesc.Text = "Weavers of elemental magicks, preferences to elemental affinity.";
                    break;
                case 4:
                    lblClassDesc.Text = "Masters of tracking and ranged weaponry.";
                    break;
                case 5:
                    lblClassDesc.Text = "Deceptive, under-handed, can sneak or talk their way out of most situations.";
                    break;
                case 6:
                    lblClassDesc.Text = "Deadly ambush assassins with either melee or aranged weapons.";
                    break;
                case 7:
                    lblClassDesc.Text = "Proficient in combining elemental magicks with specialized ranged-weaponry.";
                    break;
                case 8:
                    lblClassDesc.Text = "One in tune with several elements to provide support and healing.";
                    break;
                default:
                    lblClassDesc.Text = "";
                    break;
            }
        }
    }
}
