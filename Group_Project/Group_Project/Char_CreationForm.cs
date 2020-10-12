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
                STR--;
                cur_stat++;
                lblStr.Text = Convert.ToString(STR);
                lblStatPts.Text = Convert.ToString(cur_stat) + "/" + Convert.ToString(MAX_STAT);
            }
            else if (cur_stat == MAX_STAT)
            {
                MessageBox.Show("You cannot go above the Max stat points.", MSG_TITLE);
            }
            else if (STR == 1)
            {
                MessageBox.Show("You cannot go below 1 in a stat.", MSG_TITLE);
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
        }

        private void btnDexMinus_Click(object sender, EventArgs e)
        {
            if (cur_stat < MAX_STAT)
            {
                DEX--;
                cur_stat++;
                lblDex.Text = Convert.ToString(DEX);
                lblStatPts.Text = Convert.ToString(cur_stat) + "/" + Convert.ToString(MAX_STAT);
            }
            else if (cur_stat == MAX_STAT)
            {
                MessageBox.Show("You cannot go above the Max stat points.", MSG_TITLE);
            }
            else if (DEX == 1)
            {
                MessageBox.Show("You cannot go below 1 in a stat.", MSG_TITLE);
            }
        }

        private void btnWisMinus_Click(object sender, EventArgs e)
        {
            if (cur_stat < MAX_STAT)
            {
                WIS--;
                cur_stat++;
                lblWis.Text = Convert.ToString(WIS);
                lblStatPts.Text = Convert.ToString(cur_stat) + "/" + Convert.ToString(MAX_STAT);
            }
            else if (cur_stat == MAX_STAT)
            {
                MessageBox.Show("You cannot go above the Max stat points.", MSG_TITLE);
            }
            else if (WIS == 1)
            {
                MessageBox.Show("You cannot go below 1 in a stat.", MSG_TITLE);
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
        }

        private void btnReturn_Click(object sender, EventArgs e)
        {
            this.Close();
            FormClass.menuF.Visible = true;
        }

        private void btnRaceOpt_Click(object sender, EventArgs e)
        {
            FormClass.cRaceF.Visible = true;
            this.Enabled = false;
        }

        private void btnClassOpt_Click(object sender, EventArgs e)
        {
            this.Enabled = false;
            FormClass.cClassF.Visible = true;
        }

        private void btnIntMinus_Click(object sender, EventArgs e)
        {
            if (cur_stat < MAX_STAT)
            {
                INT--;
                cur_stat++;
                lblInt.Text = Convert.ToString(INT);
                lblStatPts.Text = Convert.ToString(cur_stat) + "/" + Convert.ToString(MAX_STAT);
            }
            else if (cur_stat == MAX_STAT)
            {
                MessageBox.Show("You cannot go above the Max stat points.", MSG_TITLE);
            }
            else if (INT == 1)
            {
                MessageBox.Show("You cannot go below 1 in a stat.", MSG_TITLE);
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
        }

        private void btnChaMinus_Click(object sender, EventArgs e)
        {
            if (cur_stat < MAX_STAT)
            {
                CHA--;
                cur_stat++;
                lblCha.Text = Convert.ToString(CHA);
                lblStatPts.Text = Convert.ToString(cur_stat) + "/" + Convert.ToString(MAX_STAT);
            }
            else if (cur_stat == MAX_STAT)
            {
                MessageBox.Show("You cannot go above the Max stat points.", MSG_TITLE);
            }
            else if (CHA == 1)
            {
                MessageBox.Show("You cannot go below 1 in a stat.", MSG_TITLE);
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
        }

        private void btnConMinus_Click(object sender, EventArgs e)
        {
            if (cur_stat < MAX_STAT)
            {
                CON--;
                cur_stat++;
                lblCon.Text = Convert.ToString(CON);
                lblStatPts.Text = Convert.ToString(cur_stat) + "/" + Convert.ToString(MAX_STAT);
            }
            else if (cur_stat == MAX_STAT)
            {
                MessageBox.Show("You cannot go above the Max stat points.", MSG_TITLE);
            }
            else if (CON == 1)
            {
                MessageBox.Show("You cannot go below 1 in a stat.", MSG_TITLE);
            }
        }

        private void btnLukMin_Click(object sender, EventArgs e)
        {
            if (cur_stat < MAX_STAT)
            {
                LUK--;
                cur_stat++;
                lblLuk.Text = Convert.ToString(LUK);
                lblStatPts.Text = Convert.ToString(cur_stat) + "/" + Convert.ToString(MAX_STAT);
            }
            else if (cur_stat == MAX_STAT)
            {
                MessageBox.Show("You cannot go above the Max stat points.", MSG_TITLE);
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
    }
}
