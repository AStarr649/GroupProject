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
    public partial class PartyLists : Form
    {
        public int pages = 0, maxPages = 0, currentPags = 0, rowIndex = 0, maxPartyIndex = 0, currentPartyIndex = 0, selectedParty = 0;
        public char returnValue = '0', searchFor = '0';
        public PartyLists()
        {
            InitializeComponent();
        }

        private void exitToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void btnReturn_Click(object sender, EventArgs e)
        {
            FormClass.partyLF.Hide();
            FormClass.menuF.Show();
        }

        private void btnViewParty_Click(object sender, EventArgs e)
        {
            selectedParty = dbListPartiesList.CurrentRow.Index;
            Console.WriteLine("\nPARTY LIST FORM: Selected Party for Party View: " + selectedParty);
            string partyID = "", partyCreatorID = "";
            try
            {
                partyID= dbListPartiesList.Rows[selectedParty].Cells[2].Value.ToString();
                partyCreatorID = dbListPartiesList.Rows[selectedParty].Cells[3].Value.ToString();
                ConnectVariables.SetPartyOwnerIDDP(partyCreatorID);
            }
            catch (Exception x)
            {
                Console.WriteLine(x.Message);
            }

            Console.WriteLine("\nPARTY LIST FORM: PartyID for Party View: " + partyID);
            ConnectVariables.SetPartyIDDP(partyID);
            ConnectDataBases.GetParty(selectedParty, 'P', Int32.Parse(partyID));
            
            FormClass.parMakeF.Update('D');
            FormClass.parMakeF.Update('R');
            FormClass.parMakeF.Update('G');
            FormClass.partyLF.Hide();
            FormClass.parMakeF.Show();
        }
        public void Update(char VALUE = '0')
        {
            if (VALUE == 'C')
            {

                Update('L');
                maxPages = maxPartyIndex / 10;
                rowIndex = 0;
                // Updates index page 
                if (pages < 0)
                {
                    currentPartyIndex = 0;
                }
                else if (pages == maxPages)
                {
                    currentPartyIndex = rowIndex + pages * 10;
                }
                else
                {
                    currentPartyIndex = rowIndex + pages * 10;
                }

                for (int i = currentPartyIndex; i < maxPartyIndex && rowIndex <= 9; i++)
                {
                    rowIndex = dbListPartiesList.Rows.Add();
                    ConnectDataBases.GetParty(i + 1, searchFor);    

                    //CREATE CV FOR PARTIES
                    dbListPartiesList.Rows[rowIndex].Cells[0].Value = ConnectDataBases.GetPartyName(ConnectVariables.GetPartyIDDP());
                    dbListPartiesList.Rows[rowIndex].Cells[1].Value = ConnectDataBases.GetUsername(ConnectVariables.GetPartyOwnerIDDP());
                    dbListPartiesList.Rows[rowIndex].Cells[2].Value = ConnectVariables.GetPartyIDDP();
                    dbListPartiesList.Rows[rowIndex].Cells[3].Value = ConnectVariables.GetPartyOwnerIDDP();
                    currentPartyIndex = i;
                    Console.WriteLine("\n''PARTY LIST FORM: Party Name: " + ConnectDataBases.GetPartyName(ConnectVariables.GetPartyIDDP()));
                    Console.WriteLine("  Party owner Username: " + ConnectDataBases.GetUsername(ConnectVariables.GetPartyOwnerIDDP()));
                    Console.WriteLine("  Current Page Index: " + pages);
                    Console.WriteLine("  Max Page Index: " + maxPages);
                    Console.WriteLine("  Row Index: " + rowIndex);
                    Console.WriteLine("  Current Party Index: " + currentPartyIndex);
                    Console.WriteLine("''Max Party Index: " + maxPartyIndex);
                }
                //Button Updates to page 
                Update('O');

            }
            else if (VALUE == 'L')
            {
                dbListPartiesList.Rows.Clear();
                dbListPlayersCharactersList.Rows.Clear();
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
                maxPartyIndex = ConnectDataBases.GetAllParties();
                searchFor = 'A';
            }
            else if (VALUE == 'Z')
            {
                maxPartyIndex = ConnectDataBases.GetUsersPartyAmount();
                searchFor = 'Z';
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
        }

        private void btnNext_Click(object sender, EventArgs e)
        {
            Update('L');
            Update('N');
        }

        private void btnPrevious_Click(object sender, EventArgs e)
        {
            Update('L');
            Update('P');
        }
    }
}
