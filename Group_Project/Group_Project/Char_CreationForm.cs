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
    public partial class Char_CreationForm : Form
    {
        public int class_index;
        const int MAX_STAT = 40;
        int cur_stat = 40, stat_cost = 1, STR = 10, CON = 10, DEX = 10, INT = 10, WIS = 10, CHA = 10, LUK = 10;

        const string STAT_ALERT = "You do not have enough points to spend.";
        const string STAT_MSG = "This Stat can go no higher";
        const string MSG_TITLE = "HEY! Listen!!";
        public string char_Class, char_Race;

        public Char_CreationForm()
        {
            InitializeComponent();
            lblStatPts.Text = Convert.ToString(cur_stat) + "/" + Convert.ToString(MAX_STAT);
            lblStr.Text = Convert.ToString(STR);
            lblCon.Text = Convert.ToString(CON);
            lblDex.Text = Convert.ToString(DEX);
            lblInt.Text = Convert.ToString(INT);
            lblWis.Text = Convert.ToString(WIS);
            lblCha.Text = Convert.ToString(CHA);
            lblLuk.Text = Convert.ToString(LUK);
        }

        private void btnStrMinus_Click(object sender, EventArgs e)
        {
            if (cur_stat < MAX_STAT && STR >= 2)
            {
                if (STR <= 12 && cur_stat <= MAX_STAT)
                {
                    stat_cost = 1;
                    STR--;
                    cur_stat = cur_stat + stat_cost;
                    lblStr.Text = Convert.ToString(STR);
                    lblStatPts.Text = Convert.ToString(cur_stat) + "/" + Convert.ToString(MAX_STAT);
                }
                else if (STR >= 12 && STR <= 14 && cur_stat <= MAX_STAT)
                {
                    stat_cost = 2;
                    STR--;
                    cur_stat = cur_stat + stat_cost;
                    lblStr.Text = Convert.ToString(STR);
                    lblStatPts.Text = Convert.ToString(cur_stat) + "/" + Convert.ToString(MAX_STAT);
                }
                else if (STR >= 15 && STR <= 16 && cur_stat <= MAX_STAT)
                {
                    stat_cost = 3;
                    STR--;
                    cur_stat = cur_stat + stat_cost;
                    lblStr.Text = Convert.ToString(STR);
                    lblStatPts.Text = Convert.ToString(cur_stat) + "/" + Convert.ToString(MAX_STAT);
                }
                else if (STR >= 17)
                {
                    stat_cost = 4;
                    STR--;
                    cur_stat = cur_stat + stat_cost;
                    lblStr.Text = Convert.ToString(STR);
                    lblStatPts.Text = Convert.ToString(cur_stat) + "/" + Convert.ToString(MAX_STAT);
                }
                else
                {
                    MessageBox.Show(STAT_MSG, MSG_TITLE);
                }
            }
            else if (STR == 1)
            {
                MessageBox.Show("You cannot go below 1 in a stat.", MSG_TITLE);
            }
            if (STR >= 1 && STR < 5)
            {
                lblBrawn.Text = "Terrible";
            }
            else if (STR >= 5 && STR < 10)
            {
                lblBrawn.Text = "Poor";
            }
            else if (STR >= 10 && STR < 14)
            {
                lblBrawn.Text = "Average";
            }
            else if (STR >= 14 && STR < 17)
            {
                lblBrawn.Text = "Above Average";
            }
            else
            {
                lblBrawn.Text = "Extraordinary";
            }
        }


        private void btnStrPlus_Click(object sender, EventArgs e)
        {
            if (cur_stat > 0 && STR <= 18)
            {
                if (STR < 12)
                {
                    STR++;
                    cur_stat = cur_stat - stat_cost;
                    lblStr.Text = Convert.ToString(STR);
                    lblStatPts.Text = Convert.ToString(cur_stat) + "/" + Convert.ToString(MAX_STAT);
                }
                else if (STR >= 12 && STR <= 14 && cur_stat >= 2)
                {
                    stat_cost = 2;
                    STR++;
                    cur_stat = cur_stat - stat_cost;
                    lblStr.Text = Convert.ToString(STR);
                    lblStatPts.Text = Convert.ToString(cur_stat) + "/" + Convert.ToString(MAX_STAT);
                }
                else if (STR >= 15 && STR <= 16 && cur_stat >= 3)
                {
                    stat_cost = 3;
                    STR++;
                    cur_stat = cur_stat - stat_cost;
                    lblStr.Text = Convert.ToString(STR);
                    lblStatPts.Text = Convert.ToString(cur_stat) + "/" + Convert.ToString(MAX_STAT);
                }
                else if (STR == 17 && cur_stat >= 4)
                {
                    stat_cost = 4;
                    STR++;
                    cur_stat = cur_stat - stat_cost;
                    lblStr.Text = Convert.ToString(STR);
                    lblStatPts.Text = Convert.ToString(cur_stat) + "/" + Convert.ToString(MAX_STAT);
                }
                else
                {
                    MessageBox.Show(STAT_MSG, MSG_TITLE);
                }
            }
            else
            {
                MessageBox.Show(STAT_ALERT, MSG_TITLE);
            }
            if (STR >= 1 && STR < 5)
            {
                lblBrawn.Text = "Terrible";
            }
            else if (STR >= 5 && STR < 10)
            {
                lblBrawn.Text = "Poor";
            }
            else if (STR >= 10 && STR < 14)
            {
                lblBrawn.Text = "Average";
            }
            else if (STR >= 14 && STR < 17)
            {
                lblBrawn.Text = "Above Average";
            }
            else
            {
                lblBrawn.Text = "Extraordinary";
            }
        }

        private void btnDexPlus_Click(object sender, EventArgs e)
        {
            if (cur_stat > 0 && DEX <= 18)
            {
                if (DEX < 12)
                {
                    DEX++;
                    cur_stat = cur_stat - stat_cost;
                    lblDex.Text = Convert.ToString(DEX);
                    lblStatPts.Text = Convert.ToString(cur_stat) + "/" + Convert.ToString(MAX_STAT);
                }
                else if (DEX >= 12 && DEX <= 14 && cur_stat >= 2)
                {
                    stat_cost = 2;
                    DEX++;
                    cur_stat = cur_stat - stat_cost;
                    lblDex.Text = Convert.ToString(DEX);
                    lblStatPts.Text = Convert.ToString(cur_stat) + "/" + Convert.ToString(MAX_STAT);
                }
                else if (DEX >= 15 && DEX <= 16 && cur_stat >= 3)
                {
                    stat_cost = 3;
                    DEX++;
                    cur_stat = cur_stat - stat_cost;
                    lblDex.Text = Convert.ToString(DEX);
                    lblStatPts.Text = Convert.ToString(cur_stat) + "/" + Convert.ToString(MAX_STAT);
                }
                else if (DEX == 17 && cur_stat >= 4)
                {
                    stat_cost = 4;
                    DEX++;
                    cur_stat = cur_stat - stat_cost;
                    lblDex.Text = Convert.ToString(DEX);
                    lblStatPts.Text = Convert.ToString(cur_stat) + "/" + Convert.ToString(MAX_STAT);
                }
                else
                {
                    MessageBox.Show(STAT_MSG, MSG_TITLE);
                }
            }
            else
            {
                MessageBox.Show(STAT_ALERT, MSG_TITLE);
            }
            if (DEX >= 1 && DEX < 5)
            {
                lblNimble.Text = "Terrible";
            }
            else if (DEX >= 5 && DEX < 10)
            {
                lblNimble.Text = "Poor";
            }
            else if (DEX >= 10 && DEX < 14)
            {
                lblNimble.Text = "Average";
            }
            else if (DEX >= 14 && DEX < 17)
            {
                lblNimble.Text = "Above Average";
            }
            else
            {
                lblNimble.Text = "Extraordinary";
            }
        }

        private void btnDexMinus_Click(object sender, EventArgs e)
        {
            if (cur_stat < MAX_STAT && DEX >= 2)
            {
                if (DEX <= 12 && cur_stat <= MAX_STAT)
                {
                    stat_cost = 1;
                    DEX--;
                    cur_stat = cur_stat + stat_cost;
                    lblStr.Text = Convert.ToString(DEX);
                    lblStatPts.Text = Convert.ToString(cur_stat) + "/" + Convert.ToString(MAX_STAT);
                }
                else if (DEX >= 12 && DEX <= 14 && cur_stat <= MAX_STAT)
                {
                    stat_cost = 2;
                    DEX--;
                    cur_stat = cur_stat + stat_cost;
                    lblStr.Text = Convert.ToString(DEX);
                    lblStatPts.Text = Convert.ToString(cur_stat) + "/" + Convert.ToString(MAX_STAT);
                }
                else if (DEX >= 15 && DEX <= 16 && cur_stat <= MAX_STAT)
                {
                    stat_cost = 3;
                    DEX--;
                    cur_stat = cur_stat + stat_cost;
                    lblStr.Text = Convert.ToString(DEX);
                    lblStatPts.Text = Convert.ToString(cur_stat) + "/" + Convert.ToString(MAX_STAT);
                }
                else if (DEX >= 17)
                {
                    stat_cost = 4;
                    DEX--;
                    cur_stat = cur_stat + stat_cost;
                    lblStr.Text = Convert.ToString(DEX);
                    lblStatPts.Text = Convert.ToString(cur_stat) + "/" + Convert.ToString(MAX_STAT);
                }
                else
                {
                    MessageBox.Show(STAT_MSG, MSG_TITLE);
                }
            }
            else if (DEX == 1)
            {
                MessageBox.Show("You cannot go below 1 in a stat.", MSG_TITLE);
            }
            if (DEX >= 1 && DEX < 5)
            {
                lblNimble.Text = "Terrible";
            }
            else if (DEX >= 5 && DEX < 10)
            {
                lblNimble.Text = "Poor";
            }
            else if (DEX >= 10 && DEX < 14)
            {
                lblNimble.Text = "Average";
            }
            else if (DEX >= 14 && DEX < 17)
            {
                lblNimble.Text = "Above Average";
            }
            else
            {
                lblNimble.Text = "Extraordinary";
            }
        }

        private void btnWisMinus_Click(object sender, EventArgs e)
        {
            if (cur_stat < MAX_STAT && WIS >= 2)
            {
                if (WIS <= 12 && cur_stat <= MAX_STAT)
                {
                    stat_cost = 1;
                    WIS--;
                    cur_stat = cur_stat + stat_cost;
                    lblStr.Text = Convert.ToString(WIS);
                    lblStatPts.Text = Convert.ToString(cur_stat) + "/" + Convert.ToString(MAX_STAT);
                }
                else if (WIS >= 12 && WIS <= 14 && cur_stat <= MAX_STAT)
                {
                    stat_cost = 2;
                    WIS--;
                    cur_stat = cur_stat + stat_cost;
                    lblStr.Text = Convert.ToString(WIS);
                    lblStatPts.Text = Convert.ToString(cur_stat) + "/" + Convert.ToString(MAX_STAT);
                }
                else if (WIS >= 15 && WIS <= 16 && cur_stat <= MAX_STAT)
                {
                    stat_cost = 3;
                    WIS--;
                    cur_stat = cur_stat + stat_cost;
                    lblStr.Text = Convert.ToString(WIS);
                    lblStatPts.Text = Convert.ToString(cur_stat) + "/" + Convert.ToString(MAX_STAT);
                }
                else if (WIS >= 17)
                {
                    stat_cost = 4;
                    WIS--;
                    cur_stat = cur_stat + stat_cost;
                    lblStr.Text = Convert.ToString(WIS);
                    lblStatPts.Text = Convert.ToString(cur_stat) + "/" + Convert.ToString(MAX_STAT);
                }
                else
                {
                    MessageBox.Show(STAT_MSG, MSG_TITLE);
                }
            }
            else if (WIS == 1)
            {
                MessageBox.Show("You cannot go below 1 in a stat.", MSG_TITLE);
            }
            if (WIS >= 1 && WIS < 5)
            {
                lblMemory.Text = "Terrible";
            }
            else if (WIS >= 5 && WIS < 10)
            {
                lblMemory.Text = "Poor";
            }
            else if (WIS >= 10 && WIS < 14)
            {
                lblMemory.Text = "Average";
            }
            else if (WIS >= 14 && WIS < 17)
            {
                lblMemory.Text = "Above Average";
            }
            else
            {
                lblMemory.Text = "Extraordinary";
            }
        }

        private void btnWisPlus_Click(object sender, EventArgs e)
        {
            if (cur_stat > 0 && WIS <= 18)
            {
                if (WIS < 12)
                {
                    WIS++;
                    cur_stat = cur_stat - stat_cost;
                    lblWis.Text = Convert.ToString(WIS);
                    lblStatPts.Text = Convert.ToString(cur_stat) + "/" + Convert.ToString(MAX_STAT);
                }
                else if (WIS >= 12 && WIS <= 14 && cur_stat >= 2)
                {
                    stat_cost = 2;
                    WIS++;
                    cur_stat = cur_stat - stat_cost;
                    lblWis.Text = Convert.ToString(WIS);
                    lblStatPts.Text = Convert.ToString(cur_stat) + "/" + Convert.ToString(MAX_STAT);
                }
                else if (WIS >= 15 && WIS <= 16 && cur_stat >= 3)
                {
                    stat_cost = 3;
                    WIS++;
                    cur_stat = cur_stat - stat_cost;
                    lblWis.Text = Convert.ToString(WIS);
                    lblStatPts.Text = Convert.ToString(cur_stat) + "/" + Convert.ToString(MAX_STAT);
                }
                else if (WIS == 17 && cur_stat >= 4)
                {
                    stat_cost = 4;
                    WIS++;
                    cur_stat = cur_stat - stat_cost;
                    lblWis.Text = Convert.ToString(WIS);
                    lblStatPts.Text = Convert.ToString(cur_stat) + "/" + Convert.ToString(MAX_STAT);
                }
                else
                {
                    MessageBox.Show(STAT_MSG, MSG_TITLE);
                }
            }
            else
            {
                MessageBox.Show(STAT_ALERT, MSG_TITLE);
            }
            if (WIS >= 1 && WIS < 5)
            {
                lblMemory.Text = "Terrible";
            }
            else if (WIS >= 5 && WIS < 10)
            {
                lblMemory.Text = "Poor";
            }
            else if (WIS >= 10 && WIS < 14)
            {
                lblMemory.Text = "Average";
            }
            else if (WIS >= 14 && WIS < 17)
            {
                lblMemory.Text = "Above Average";
            }
            else
            {
                lblMemory.Text = "Extraordinary";
            }
        }


        private void btnIntMinus_Click(object sender, EventArgs e)
        {
            if (cur_stat < MAX_STAT && INT >= 2)
            {
                if (INT <= 12 && cur_stat <= MAX_STAT)
                {
                    stat_cost = 1;
                    INT--;
                    cur_stat = cur_stat + stat_cost;
                    lblStr.Text = Convert.ToString(INT);
                    lblStatPts.Text = Convert.ToString(cur_stat) + "/" + Convert.ToString(MAX_STAT);
                }
                else if (INT >= 12 && INT <= 14 && cur_stat <= MAX_STAT)
                {
                    stat_cost = 2;
                    INT--;
                    cur_stat = cur_stat + stat_cost;
                    lblStr.Text = Convert.ToString(INT);
                    lblStatPts.Text = Convert.ToString(cur_stat) + "/" + Convert.ToString(MAX_STAT);
                }
                else if (INT >= 15 && INT <= 16 && cur_stat <= MAX_STAT)
                {
                    stat_cost = 3;
                    INT--;
                    cur_stat = cur_stat + stat_cost;
                    lblStr.Text = Convert.ToString(INT);
                    lblStatPts.Text = Convert.ToString(cur_stat) + "/" + Convert.ToString(MAX_STAT);
                }
                else if (INT >= 17)
                {
                    stat_cost = 4;
                    INT--;
                    cur_stat = cur_stat + stat_cost;
                    lblStr.Text = Convert.ToString(INT);
                    lblStatPts.Text = Convert.ToString(cur_stat) + "/" + Convert.ToString(MAX_STAT);
                }
                else
                {
                    MessageBox.Show(STAT_MSG, MSG_TITLE);
                }
            }
            else if (INT == 1)
            {
                MessageBox.Show("You cannot go below 1 in a stat.", MSG_TITLE);
            }
            if (INT >= 1 && INT < 5)
            {
                lblClever.Text = "Terrible";
            }
            else if (INT >= 5 && INT < 10)
            {
                lblClever.Text = "Poor";
            }
            else if (INT >= 10 && INT < 14)
            {
                lblClever.Text = "Average";
            }
            else if (INT >= 14 && INT < 17)
            {
                lblClever.Text = "Above Average";
            }
            else
            {
                lblClever.Text = "Extraordinary";
            }
        }

        private void btnIntPlus_Click(object sender, EventArgs e)
        {
            if (cur_stat > 0 && INT <= 18)
            {
                if (INT < 12)
                {
                    INT++;
                    cur_stat = cur_stat - stat_cost;
                    lblInt.Text = Convert.ToString(INT);
                    lblStatPts.Text = Convert.ToString(cur_stat) + "/" + Convert.ToString(MAX_STAT);
                }
                else if (INT >= 12 && INT <= 14 && cur_stat >= 2)
                {
                    stat_cost = 2;
                    INT++;
                    cur_stat = cur_stat - stat_cost;
                    lblInt.Text = Convert.ToString(INT);
                    lblStatPts.Text = Convert.ToString(cur_stat) + "/" + Convert.ToString(MAX_STAT);
                }
                else if (INT >= 15 && INT <= 16 && cur_stat >= 3)
                {
                    stat_cost = 3;
                    INT++;
                    cur_stat = cur_stat - stat_cost;
                    lblInt.Text = Convert.ToString(INT);
                    lblStatPts.Text = Convert.ToString(cur_stat) + "/" + Convert.ToString(MAX_STAT);
                }
                else if (INT == 17 && cur_stat >= 4)
                {
                    stat_cost = 4;
                    INT++;
                    cur_stat = cur_stat - stat_cost;
                    lblInt.Text = Convert.ToString(INT);
                    lblStatPts.Text = Convert.ToString(cur_stat) + "/" + Convert.ToString(MAX_STAT);
                }
                else
                {
                    MessageBox.Show(STAT_MSG, MSG_TITLE);
                }
            }
            else
            {
                MessageBox.Show(STAT_ALERT, MSG_TITLE);
            }
            if (INT >= 1 && INT < 5)
            {
                lblClever.Text = "Terrible";
            }
            else if (INT >= 5 && INT < 10)
            {
                lblClever.Text = "Poor";
            }
            else if (INT >= 10 && INT < 14)
            {
                lblClever.Text = "Average";
            }
            else if (INT >= 14 && INT < 17)
            {
                lblClever.Text = "Above Average";
            }
            else
            {
                lblClever.Text = "Extraordinary";
            }
        }

        private void btnChaMinus_Click(object sender, EventArgs e)
        {
            if (cur_stat < MAX_STAT && CHA >= 2)
            {
                if (CHA <= 12 && cur_stat <= MAX_STAT)
                {
                    stat_cost = 1;
                    CHA--;
                    cur_stat = cur_stat + stat_cost;
                    lblStr.Text = Convert.ToString(CHA);
                    lblStatPts.Text = Convert.ToString(cur_stat) + "/" + Convert.ToString(MAX_STAT);
                }
                else if (CHA >= 12 && CHA <= 14 && cur_stat <= MAX_STAT)
                {
                    stat_cost = 2;
                    CHA--;
                    cur_stat = cur_stat + stat_cost;
                    lblStr.Text = Convert.ToString(CHA);
                    lblStatPts.Text = Convert.ToString(cur_stat) + "/" + Convert.ToString(MAX_STAT);
                }
                else if (CHA >= 15 && CHA <= 16 && cur_stat <= MAX_STAT)
                {
                    stat_cost = 3;
                    CHA--;
                    cur_stat = cur_stat + stat_cost;
                    lblStr.Text = Convert.ToString(CHA);
                    lblStatPts.Text = Convert.ToString(cur_stat) + "/" + Convert.ToString(MAX_STAT);
                }
                else if (CHA >= 17)
                {
                    stat_cost = 4;
                    CHA--;
                    cur_stat = cur_stat + stat_cost;
                    lblStr.Text = Convert.ToString(CHA);
                    lblStatPts.Text = Convert.ToString(cur_stat) + "/" + Convert.ToString(MAX_STAT);
                }
                else
                {
                    MessageBox.Show(STAT_MSG, MSG_TITLE);
                }
            }
            else if (CHA == 1)
            {
                MessageBox.Show("You cannot go below 1 in a stat.", MSG_TITLE);
            }
            if (CHA >= 1 && CHA < 5)
            {
                lblCharm.Text = "Terrible";
            }
            else if (CHA >= 5 && CHA < 10)
            {
                lblCharm.Text = "Poor";
            }
            else if (CHA >= 10 && CHA < 14)
            {
                lblCharm.Text = "Average";
            }
            else if (CHA >= 14 && CHA < 17)
            {
                lblCharm.Text = "Above Average";
            }
            else
            {
                lblCharm.Text = "Extraordinary";
            }
        }

        private void btnChaPlus_Click(object sender, EventArgs e)
        {
            if (cur_stat > 0 && CHA <= 18)
            {
                if (CHA < 12)
                {
                    CHA++;
                    cur_stat = cur_stat - stat_cost;
                    lblCha.Text = Convert.ToString(CHA);
                    lblStatPts.Text = Convert.ToString(cur_stat) + "/" + Convert.ToString(MAX_STAT);
                }
                else if (CHA >= 12 && CHA <= 14 && cur_stat >= 2)
                {
                    stat_cost = 2;
                    CHA++;
                    cur_stat = cur_stat - stat_cost;
                    lblCha.Text = Convert.ToString(CHA);
                    lblStatPts.Text = Convert.ToString(cur_stat) + "/" + Convert.ToString(MAX_STAT);
                }
                else if (CHA >= 15 && CHA <= 16 && cur_stat >= 3)
                {
                    stat_cost = 3;
                    CHA++;
                    cur_stat = cur_stat - stat_cost;
                    lblCha.Text = Convert.ToString(CHA);
                    lblStatPts.Text = Convert.ToString(cur_stat) + "/" + Convert.ToString(MAX_STAT);
                }
                else if (CHA == 17 && cur_stat >= 4)
                {
                    stat_cost = 4;
                    CHA++;
                    cur_stat = cur_stat - stat_cost;
                    lblCha.Text = Convert.ToString(CHA);
                    lblStatPts.Text = Convert.ToString(cur_stat) + "/" + Convert.ToString(MAX_STAT);
                }
                else
                {
                    MessageBox.Show(STAT_MSG, MSG_TITLE);
                }
            }
            else
            {
                MessageBox.Show(STAT_ALERT, MSG_TITLE);
            }
            if (CHA >= 1 && CHA < 5)
            {
                lblCharm.Text = "Terrible";
            }
            else if (CHA >= 5 && CHA < 10)
            {
                lblCharm.Text = "Poor";
            }
            else if (CHA >= 10 && CHA < 14)
            {
                lblCharm.Text = "Average";
            }
            else if (CHA >= 14 && CHA < 17)
            {
                lblCharm.Text = "Above Average";
            }
            else
            {
                lblCharm.Text = "Extraordinary";
            }
        }

        private void btnConPlus_Click(object sender, EventArgs e)
        {
            if (cur_stat > 0 && CON <= 18)
            {
                if (CON < 12)
                {
                    CON++;
                    cur_stat = cur_stat - stat_cost;
                    lblCon.Text = Convert.ToString(CON);
                    lblStatPts.Text = Convert.ToString(cur_stat) + "/" + Convert.ToString(MAX_STAT);
                }
                else if (CON >= 12 && CON <= 14 && cur_stat >= 2)
                {
                    stat_cost = 2;
                    CON++;
                    cur_stat = cur_stat - stat_cost;
                    lblCon.Text = Convert.ToString(CON);
                    lblStatPts.Text = Convert.ToString(cur_stat) + "/" + Convert.ToString(MAX_STAT);
                }
                else if (CON >= 15 && CON <= 16 && cur_stat >= 3)
                {
                    stat_cost = 3;
                    CON++;
                    cur_stat = cur_stat - stat_cost;
                    lblCon.Text = Convert.ToString(CON);
                    lblStatPts.Text = Convert.ToString(cur_stat) + "/" + Convert.ToString(MAX_STAT);
                }
                else if (CON == 17 && cur_stat >= 4)
                {
                    stat_cost = 4;
                    CON++;
                    cur_stat = cur_stat - stat_cost;
                    lblCon.Text = Convert.ToString(CON);
                    lblStatPts.Text = Convert.ToString(cur_stat) + "/" + Convert.ToString(MAX_STAT);
                }
                else
                {
                    MessageBox.Show(STAT_MSG, MSG_TITLE);
                }
            }
            else
            {
                MessageBox.Show(STAT_ALERT, MSG_TITLE);
            }
            if (CON >= 1 && CON < 5)
            {
                lblHealth.Text = "Terrible";
            }
            else if (CON >= 5 && CON < 10)
            {
                lblHealth.Text = "Poor";
            }
            else if (CON >= 10 && CON < 14)
            {
                lblHealth.Text = "Average";
            }
            else if (CON >= 14 && CON < 17)
            {
                lblHealth.Text = "Above Average";
            }
            else
            {
                lblHealth.Text = "Extraordinary";
            }
        }

        private void btnLoad_Click(object sender, EventArgs e)
        {
            if (FormClass.charListF.searchFor == 'A')
            {
                Update('O');
                FormClass.charListF.Update('M');
                FormClass.charListF.Update('C');
                FormClass.charF.Hide();
                FormClass.charListF.Show();
            }
            else
            {
                Update('X');
                FormClass.charListF.Update('L');
                Update('L');
                FormClass.charListF.Update('C');
                FormClass.charListF.Show();
                FormClass.charF.Hide();
            }
        }

        private void btnClear_Click(object sender, EventArgs e)
        {
            Update('X');
            FormClass.charF.Update('M');
        }

        private void btnSelect_Click(object sender, EventArgs e)
        {
            //for selecting character into party
        }

        private void btnConMinus_Click(object sender, EventArgs e)
        {
            if (cur_stat < MAX_STAT && CON >= 2)
            {
                if (CON <= 12 && cur_stat <= MAX_STAT)
                {
                    stat_cost = 1;
                    CON--;
                    cur_stat = cur_stat + stat_cost;
                    lblStr.Text = Convert.ToString(CON);
                    lblStatPts.Text = Convert.ToString(cur_stat) + "/" + Convert.ToString(MAX_STAT);
                }
                else if (CON >= 12 && CON <= 14 && cur_stat <= MAX_STAT)
                {
                    stat_cost = 2;
                    CON--;
                    cur_stat = cur_stat + stat_cost;
                    lblStr.Text = Convert.ToString(CON);
                    lblStatPts.Text = Convert.ToString(cur_stat) + "/" + Convert.ToString(MAX_STAT);
                }
                else if (CON >= 15 && CON <= 16 && cur_stat <= MAX_STAT)
                {
                    stat_cost = 3;
                    CON--;
                    cur_stat = cur_stat + stat_cost;
                    lblStr.Text = Convert.ToString(CON);
                    lblStatPts.Text = Convert.ToString(cur_stat) + "/" + Convert.ToString(MAX_STAT);
                }
                else if (CON >= 17)
                {
                    stat_cost = 4;
                    CON--;
                    cur_stat = cur_stat + stat_cost;
                    lblStr.Text = Convert.ToString(CON);
                    lblStatPts.Text = Convert.ToString(cur_stat) + "/" + Convert.ToString(MAX_STAT);
                }
                else
                {
                    MessageBox.Show(STAT_MSG, MSG_TITLE);
                }
            }
            else if (CON == 1)
            {
                MessageBox.Show("You cannot go below 1 in a stat.", MSG_TITLE);
            }
            if (CON >= 1 && CON < 5)
            {
                lblHealth.Text = "Terrible";
            }
            else if (CON >= 5 && CON < 10)
            {
                lblHealth.Text = "Poor";
            }
            else if (CON >= 10 && CON < 14)
            {
                lblHealth.Text = "Average";
            }
            else if (CON >= 14 && CON < 17)
            {
                lblHealth.Text = "Above Average";
            }
            else
            {
                lblHealth.Text = "Extraordinary";
            }
        }


        private void btnLukMin_Click(object sender, EventArgs e)
        {
            if (cur_stat < MAX_STAT && LUK >= 2)
            {
                if (LUK <= 12 && cur_stat <= MAX_STAT)
                {
                    stat_cost = 1;
                    LUK--;
                    cur_stat = cur_stat + stat_cost;
                    lblStr.Text = Convert.ToString(LUK);
                    lblStatPts.Text = Convert.ToString(cur_stat) + "/" + Convert.ToString(MAX_STAT);
                }
                else if (LUK >= 12 && LUK <= 14 && cur_stat <= MAX_STAT)
                {
                    stat_cost = 2;
                    LUK--;
                    cur_stat = cur_stat + stat_cost;
                    lblStr.Text = Convert.ToString(LUK);
                    lblStatPts.Text = Convert.ToString(cur_stat) + "/" + Convert.ToString(MAX_STAT);
                }
                else if (LUK >= 15 && LUK <= 16 && cur_stat <= MAX_STAT)
                {
                    stat_cost = 3;
                    LUK--;
                    cur_stat = cur_stat + stat_cost;
                    lblStr.Text = Convert.ToString(LUK);
                    lblStatPts.Text = Convert.ToString(cur_stat) + "/" + Convert.ToString(MAX_STAT);
                }
                else if (LUK >= 17)
                {
                    stat_cost = 4;
                    LUK--;
                    cur_stat = cur_stat + stat_cost;
                    lblStr.Text = Convert.ToString(LUK);
                    lblStatPts.Text = Convert.ToString(cur_stat) + "/" + Convert.ToString(MAX_STAT);
                }
                else
                {
                    MessageBox.Show(STAT_MSG, MSG_TITLE);
                }
            }
            else if (LUK == 1)
            {
                MessageBox.Show("You cannot go below 1 in a stat.", MSG_TITLE);
            }
        }

        private void btnLukPlus_Click(object sender, EventArgs e)
        {
            if (cur_stat > 0 && LUK <= 18)
            {
                if (LUK < 12)
                {
                    LUK++;
                    cur_stat = cur_stat - stat_cost;
                    lblLuk.Text = Convert.ToString(LUK);
                    lblStatPts.Text = Convert.ToString(cur_stat) + "/" + Convert.ToString(MAX_STAT);
                }
                else if (LUK >= 12 && LUK <= 14 && cur_stat >= 2)
                {
                    stat_cost = 2;
                    LUK++;
                    cur_stat = cur_stat - stat_cost;
                    lblLuk.Text = Convert.ToString(LUK);
                    lblStatPts.Text = Convert.ToString(cur_stat) + "/" + Convert.ToString(MAX_STAT);
                }
                else if (LUK >= 15 && LUK <= 16 && cur_stat >= 3)
                {
                    stat_cost = 3;
                    LUK++;
                    cur_stat = cur_stat - stat_cost;
                    lblLuk.Text = Convert.ToString(LUK);
                    lblStatPts.Text = Convert.ToString(cur_stat) + "/" + Convert.ToString(MAX_STAT);
                }
                else if (LUK == 17 && cur_stat >= 4)
                {
                    stat_cost = 4;
                    LUK++;
                    cur_stat = cur_stat - stat_cost;
                    lblLuk.Text = Convert.ToString(LUK);
                    lblStatPts.Text = Convert.ToString(cur_stat) + "/" + Convert.ToString(MAX_STAT);
                }
                else
                {
                    MessageBox.Show(STAT_MSG, MSG_TITLE);
                }
            }
            else
            {
                MessageBox.Show(STAT_ALERT, MSG_TITLE);
            }
        }

        [Obsolete]
        private void btnCreate_Click(object sender, EventArgs e)
        {
            if (
                   lblUsernameToPresent.Text == "" || txtCharName.Text == "" ||
                   lblRace.Text == "" || cmbGender.Text == "" || lblClass.Text == "" || cmbElemental.Text == "" ||
               lblStr.Text == "" || lblCon.Text == "" || lblDex.Text == "" || lblWis.Text == "" || lblInt.Text == "" || lblCha.Text == "" || lblLuk.Text == "" ||
               lblBrawn.Text == "" || lblHealth.Text == "" || lblNimble.Text == "" || lblMemory.Text == "" || lblClever.Text == "" || lblCharm.Text == "" ||
               cmbTalent1.Text == "" || cmbTalent2.Text == "" || cmbTalent3.Text == "" ||
               cmbQuirk1.Text == "" || cmbQuirk2.Text == "" || cmbQuirk3.Text == "")
            {
                MessageBox.Show("Please fill out all empty entries before creating.");
            }
            else
                ConnectDataBases.CreateCharacter(
                lblUsernameToPresent.Text, txtCharName.Text,
                lblRace.Text, cmbGender.Text,
                cmbElemental.Text, lblClass.Text,
                lblStr.Text, lblCon.Text, lblDex.Text, lblWis.Text, lblInt.Text, lblCha.Text, lblLuk.Text,
                lblBrawn.Text, lblHealth.Text, lblNimble.Text, lblMemory.Text, lblClever.Text, lblCharm.Text,
                cmbTalent1.Text, cmbTalent2.Text, cmbTalent3.Text,
                cmbQuirk1.Text, cmbQuirk2.Text, cmbQuirk3.Text);
        }
        [Obsolete]
        private void btnSave_Click(object sender, EventArgs e)
        {
            if (
                lblUsernameToPresent.Text == "" || txtCharName.Text == "" ||
                lblRace.Text == "" || cmbGender.Text == "" || lblClass.Text == "" || cmbElemental.Text == "" ||
            lblStr.Text == "" || lblCon.Text == "" || lblDex.Text == "" || lblWis.Text == "" || lblInt.Text == "" || lblCha.Text == "" || lblLuk.Text == "" ||
            lblBrawn.Text == "" || lblHealth.Text == "" || lblNimble.Text == "" || lblMemory.Text == "" || lblClever.Text == "" || lblCharm.Text == "" ||
            cmbTalent1.Text == "" || cmbTalent2.Text == "" || cmbTalent3.Text == "" ||
            cmbQuirk1.Text == "" || cmbQuirk2.Text == "" || cmbQuirk3.Text == "")
            {
                MessageBox.Show("Please fill out all empty entries before saving.");
            }
            else
                ConnectDataBases.UpdateCharacter(
                    lblUsernameToPresent.Text, txtCharName.Text,
                    lblRace.Text, cmbGender.Text,
                    cmbElemental.Text, lblClass.Text,
                    lblStr.Text, lblCon.Text, lblDex.Text, lblWis.Text, lblInt.Text, lblCha.Text, lblLuk.Text,
                    lblBrawn.Text, lblHealth.Text, lblNimble.Text, lblMemory.Text, lblClever.Text, lblCharm.Text,
                    cmbTalent1.Text, cmbTalent2.Text, cmbTalent3.Text,
                    cmbQuirk1.Text, cmbQuirk2.Text, cmbQuirk3.Text);
        }
        private void btnClassOpt_Click(object sender, EventArgs e)
        {
            FormClass.charF.Hide();
            FormClass.cClassF.Show();
        }

        private void btnReturn_Click(object sender, EventArgs e)
        {
            Update('X');
            FormClass.charF.Hide();
            FormClass.menuF.Show();
        }

        private void btnRaceOpt_Click(object sender, EventArgs e)
        {
            FormClass.cRaceF.Show();
            FormClass.charF.Hide();
        }
        public void Update(char VALUE = '0', string classText = "0")
        {
            Console.WriteLine("VALUE: " + VALUE);
            if (VALUE == 'M')//update button for creating characters 
            {
                //FEATURES
                lblUsernameToPresent.Text = ConnectVariables.GetLoggedInUsernameAs();
                txtCharName.Enabled = true;
                btnRaceOpt.Enabled = true;
                cmbGender.Enabled = true;
                btnClassOpt.Enabled = true;
                cmbElemental.Enabled = true;
                btnStrMinus.Enabled = true;
                btnStrPlus.Enabled = true;
                btnConMinus.Enabled = true;
                btnConPlus.Enabled = true;
                btnDexMinus.Enabled = true;
                btnDexPlus.Enabled = true;
                btnWisMinus.Enabled = true;
                btnWisPlus.Enabled = true;
                btnIntMinus.Enabled = true;
                btnIntPlus.Enabled = true;
                btnLukMin.Enabled = true;
                btnLukPlus.Enabled = true;
                cmbTalent1.Enabled = true;
                cmbTalent2.Enabled = true;
                cmbTalent3.Enabled = true;
                cmbQuirk1.Enabled = true;
                cmbQuirk2.Enabled = true;
                cmbQuirk3.Enabled = true;

                //CONTROLLS
                btnClear.Visible = true;
                btnSave.Visible = false;
                btnCreate.Visible = true;
                btnSelect.Visible = false;
            }
            else if (VALUE == 'L')//update button for loading characters you own
            {
                //FEATURES
                txtCharName.Enabled = true;
                btnRaceOpt.Enabled = true;
                cmbGender.Enabled = true;
                btnClassOpt.Enabled = true;
                cmbElemental.Enabled = true;
                btnStrMinus.Enabled = true;
                btnStrPlus.Enabled = true;
                btnConMinus.Enabled = true;
                btnConPlus.Enabled = true;
                btnDexMinus.Enabled = true;
                btnDexPlus.Enabled = true;
                btnWisMinus.Enabled = true;
                btnWisPlus.Enabled = true;
                btnIntMinus.Enabled = true;
                btnIntPlus.Enabled = true;
                btnLukMin.Enabled = true;
                btnLukPlus.Enabled = true;
                cmbTalent1.Enabled = true;
                cmbTalent2.Enabled = true;
                cmbTalent3.Enabled = true;
                cmbQuirk1.Enabled = true;
                cmbQuirk2.Enabled = true;
                cmbQuirk3.Enabled = true;

                //CONTROLLS
                btnClear.Visible = true;
                btnSave.Visible = true;
                btnCreate.Visible = false;
                btnSelect.Visible = false;
            }
            else if (VALUE == 'O')//update button for loading characters you dont own
            {
                //FEATURES
                txtCharName.Enabled = false;
                btnRaceOpt.Enabled = false;
                cmbGender.Enabled = false;
                btnClassOpt.Enabled = false;
                cmbElemental.Enabled = false;
                btnStrMinus.Enabled = false;
                btnStrPlus.Enabled = false;
                btnConMinus.Enabled = false;
                btnConPlus.Enabled = false;
                btnDexMinus.Enabled = false;
                btnDexPlus.Enabled = false;
                btnWisMinus.Enabled = false;
                btnWisPlus.Enabled = false;
                btnIntMinus.Enabled = false;
                btnIntPlus.Enabled = false;
                btnChaMinus.Enabled = false;
                btnChaPlus.Enabled = false;
                btnLukMin.Enabled = false;
                btnLukPlus.Enabled = false;
                cmbTalent1.Enabled = false;
                cmbTalent2.Enabled = false;
                cmbTalent3.Enabled = false;
                cmbQuirk1.Enabled = false;
                cmbQuirk2.Enabled = false;
                cmbQuirk3.Enabled = false;


                //CONTROLLS
                btnClear.Visible = false;
                btnSave.Visible = false;
                btnCreate.Visible = false;
                btnSelect.Visible = false;
            }
            else if (VALUE == 'R')//update race
            {
                Console.WriteLine("Updated Race");
                lblRace.Text = char_Race;
            }
            else if (VALUE == 'C')
            {
                if (classText == "0")
                {
                    Console.WriteLine("Updated Class");
                    Console.WriteLine("Class: " + char_Class);
                    lblClass.Text = char_Class;
                }
                if (lblClass.Text == "Brute")
                {
                    System.Console.WriteLine("Class Setting Image: " + lblClass.Text);
                    Image image1 = Image.FromFile("BruteIcon.jpg");

                    picClassIcon.BackgroundImage = image1;

                    System.Console.WriteLine("Class Set Image: " + lblClass.Text);
                }
                else if (lblClass.Text == "Guardsman")
                {
                    Image image2 = Image.FromFile("GuardsmanIcon.jpg");
                    picClassIcon.BackgroundImage = image2;
                }
                else if (lblClass.Text == "Oracle")
                {
                    Image image3 = Image.FromFile("OracleIcon.jpg");
                    picClassIcon.BackgroundImage = image3;
                }
                else if (lblClass.Text == "Archon")
                {
                    Image image4 = Image.FromFile("ArchonIcon.jpg");
                    picClassIcon.BackgroundImage = image4;
                }
                else if (lblClass.Text == "Huntsman")
                {
                    Image image5 = Image.FromFile("HuntsmanIcon.jpg");
                    picClassIcon.BackgroundImage = image5;
                }
                else if (lblClass.Text == "Reprobate")
                {
                    Image image6 = Image.FromFile("ReprobateIcon.jpg");
                    picClassIcon.BackgroundImage = image6;
                }
                else if (lblClass.Text == "Reaper")
                {
                    Image image7 = Image.FromFile("ReaperIcon.jpg");
                    picClassIcon.BackgroundImage = image7;
                }
                else if (lblClass.Text == "Caster")
                {
                    Image image8 = Image.FromFile("CasterIcon.jpg");
                    picClassIcon.BackgroundImage = image8;
                }
                else if (lblClass.Text == "Elementalist")
                {

                    Image image9 = Image.FromFile("ElementalistIcon.jpg");
                    picClassIcon.BackgroundImage = image9;
                }
            }//update class
            else if (VALUE == 'F')//Load Pre Existing Info For Characters
            {
                string c = "updateImage";
                lblUsernameToPresent.Text = ConnectVariables.GetUsernameDP();
                txtCharName.Text = ConnectVariables.GetCharNameDP();
                lblRace.Text = ConnectVariables.GetCharRaceDP();
                cmbGender.Text = ConnectVariables.GetCharGenderDP();
                lblClass.Text = ConnectVariables.GetCharClassDP();
                cmbElemental.Text = ConnectVariables.GetCharElementDP();
                lblStr.Text = ConnectVariables.GetCharStrengthDP();
                lblCon.Text = ConnectVariables.GetCharConstDP();
                lblDex.Text = ConnectVariables.GetCharDexDP();
                lblWis.Text = ConnectVariables.GetCharWisDP();
                lblInt.Text = ConnectVariables.GetCharIntelDP();
                lblCha.Text = ConnectVariables.GetCharCharismaDP();
                lblLuk.Text = ConnectVariables.GetCharLuckDP();
                lblBrawn.Text = ConnectVariables.GetCharBrawnDP();
                lblHealth.Text = ConnectVariables.GetCharHealthDP();
                lblNimble.Text = ConnectVariables.GetCharNimDP();
                lblMemory.Text = ConnectVariables.GetCharMemDP();
                lblClever.Text = ConnectVariables.GetCharCleverDP();
                lblCharm.Text = ConnectVariables.GetCharCharmDP();
                cmbTalent1.Text = ConnectVariables.GetCharTalDP1();
                cmbTalent2.Text = ConnectVariables.GetCharTalDP2();
                cmbTalent3.Text = ConnectVariables.GetCharTalDP3();
                cmbQuirk1.Text = ConnectVariables.GetCharQuiDP1();
                cmbQuirk2.Text = ConnectVariables.GetCharQuiDP2();
                cmbQuirk3.Text = ConnectVariables.GetCharQuiDP3();
                Update('C', c);
            }
            else if (VALUE == 'X')
            {
                lblUsernameToPresent.Text = "";
                txtCharName.Text = "";
                lblRace.Text = "";
                cmbGender.Text = "";
                lblClass.Text = "";
                cmbElemental.Text = "";
                lblStr.Text = "";
                lblCon.Text = "";
                lblDex.Text = "";
                lblWis.Text = "";
                lblInt.Text = "";
                lblCha.Text = "";
                lblLuk.Text = "";
                lblBrawn.Text = "";
                lblHealth.Text = "";
                lblNimble.Text = "";
                lblMemory.Text = "";
                lblClever.Text = "";
                lblCharm.Text = "";
                cmbTalent1.Text = "";
                cmbTalent2.Text = "";
                cmbTalent3.Text = "";
                cmbQuirk1.Text = "";
                cmbQuirk2.Text = "";
                cmbQuirk3.Text = "";
            }


            Console.WriteLine("UPDATED CF FORM!");
        }

    }
}
