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
    public partial class CharacterList : Form
    {
        public int  pages = 0, maxPages = 0, currentPags = 0, rowIndex = 0 , maxCharIndex = 0, currentCharIndex = 0, selectedChar = 0;
        public char returnValue = '0', searchFor = '0';
        bool partyCharSelet = false;

        private void dbListCharList_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        public CharacterList()
        {
            InitializeComponent();
            btnPrevious.Enabled = false;
        }

        private void exitToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void btnView_Click(object sender, EventArgs e)
        {           
            selectedChar = dbListCharList.CurrentRow.Index;
            //MessageBox.Show("Index in data view table selected: " + selectedChar);

            if (selectedChar < 0)
            {
                MessageBox.Show("Please select a character \nto view before viewing characters.");
            }
            else
            {
                ConnectDataBases.LoadUserCharacter(dbListCharList.Rows[selectedChar].Cells[5].Value.ToString(),
                        ConnectDataBases.GetUserId(dbListCharList.Rows[selectedChar].Cells[4].Value.ToString()));
                FormClass.charListF.Hide();
                if (partyCharSelet)
                {

                    //FormClass.parMakeF.Update('C');
                    FormClass.parMakeF.Update('R');
                    FormClass.parMakeF.Show();
                }
                else
                {
                    FormClass.charF.Update('F');
                    FormClass.charF.Show();
                }
            }
            partyCharSelet = false;
        }

        private void btnReturn_Click(object sender, EventArgs e)
        {
            if (returnValue == 'M')
            {
                FormClass.charListF.Hide();
                FormClass.menuF.Show();
            }
            else if (returnValue == 'B')
            {
                FormClass.charListF.Hide();
                FormClass.charF.Show();
            }
        }
        public void Update(char VALUE = '0')
        {

            if (VALUE == 'C')//Player Character from character creation/update forms
            {
                Update('L');
                maxPages = maxCharIndex / 10;
                rowIndex = 0;
                // Updates index page 
                if (pages < 0)
                {
                    currentCharIndex = 0;
                }
                else if (pages == maxPages)
                {
                    currentCharIndex = rowIndex + pages * 10;
                }
                else
                {
                    currentCharIndex = rowIndex + pages * 10;
                }

                for (int i = currentCharIndex; i < maxCharIndex && rowIndex <= 9; i++)
                {
                    rowIndex = dbListCharList.Rows.Add();
                    ConnectDataBases.GetUsersCharacters(i + 1, searchFor);

                    dbListCharList.Rows[rowIndex].Cells[0].Value = ConnectVariables.GetCharNameDP();
                    dbListCharList.Rows[rowIndex].Cells[1].Value = ConnectVariables.GetCharGenderDP();
                    dbListCharList.Rows[rowIndex].Cells[2].Value = ConnectVariables.GetCharClassDP();
                    dbListCharList.Rows[rowIndex].Cells[3].Value = ConnectVariables.GetCharRaceDP();
                    dbListCharList.Rows[rowIndex].Cells[4].Value = ConnectVariables.GetUsernameDP();
                    dbListCharList.Rows[rowIndex].Cells[5].Value = ConnectVariables.GetCharIDDP();
                    currentCharIndex = i;
                    Console.WriteLine("Current Page Index: " + pages);
                    Console.WriteLine("Max Page Index: " + maxPages);
                    Console.WriteLine("Row Index: " + rowIndex);
                    Console.WriteLine("Current Char Index: " + currentCharIndex);
                    Console.WriteLine("Max Char Index: " + maxCharIndex);
                }
                //Button Updates to page 
                Update('O');
            }
            else if (VALUE == 'P')//Last Page
            {
                pages -= 1;
                Update('C');
            }
            else if (VALUE == 'N')//Next Page
            {
                pages += 1;
                Update('C');
            }
            else if (VALUE == 'L')
            {
                dbListCharList.Rows.Clear();
            }
            else if (VALUE == 'M')// Return to menu
            {
                currentCharIndex = 0;
                pages = 0;
                Update('L');
                returnValue = 'M';
            }
            else if (VALUE == 'B')// Return to char Create form
            {
                currentCharIndex = 0;
                pages = 0;
                Update('L');
                returnValue = 'B';
            }
            else if (VALUE == 'O')//update buttons
            {
                if (pages <= 0)
                {
                    pages = 0;
                    btnPrevious.Enabled = false;
                    btnNext.Enabled = true;
                }
                else if (pages == maxPages)
                {
                    btnNext.Enabled = false;
                    btnPrevious.Enabled = true;
                }
                else
                {
                    btnPrevious.Enabled = true;
                    btnNext.Enabled = true;
                }
            }
            else if (VALUE == 'A')
            {
                maxCharIndex = ConnectDataBases.GetAllCharacters();
                searchFor = 'A';
            }
            else if (VALUE == 'Z')
            {
                maxCharIndex = ConnectDataBases.GetUsersCharactersAmount();
                searchFor = 'Z';
            }
            else if (VALUE == 'S')
            {
                partyCharSelet = true;
            }
        }

        private void btnNext_Click(object sender, EventArgs e)
        {
            Update('N');
        }

        private void btnPrevious_Click(object sender, EventArgs e)
        {
            Update('P');
        }
    }
}
