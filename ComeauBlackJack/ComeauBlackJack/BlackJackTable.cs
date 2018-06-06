using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ComeauBlackJack
{
    public partial class BlackJackTable : Form
    {
        // Maintain current player and deck for access.
        Player currentPlayer = new Player("Guest", 1000);
        ActiveDeck currentDeck;

        public BlackJackTable()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            //// Add a new player and deal five cards.
            //Player newPlayer = new Player("Andrew", 1000);
            //currentDeck.DealCards(5, newPlayer);

            //// Clear the list box and show the player's cards.
            //lstHand.Items.Clear();
            //foreach(PlayingCard pCard in newPlayer.PlayerHand)
            //{
            //    lstHand.Items.Add(pCard.CardName);
            //}

            //// Display the total for the hand.
            //label1.Text = "Hand total: " + newPlayer.GetHandValue().ToString();
            
            //// Discard the player's cards.
            //foreach(PlayingCard pCard in newPlayer.PlayerHand)
            //{
            //    currentDeck.Discard(pCard);
            //}
            //newPlayer.PlayerHand.Clear();

            //// Display the number of cards remaining in the deck.
            //lblCardsLeft.Text = "Cards remaining: " + 
            //    currentDeck.RemainingCards.Count.ToString();
        }

        private void BlackJackTable_Load(object sender, EventArgs e)
        {
            // Shuffle a new deck when the form loads and update
            // the player stats in the corner.
            currentDeck = new ActiveDeck(SourceDeck, false);
            UpdatePlayerStats();
        }

        private void UpdatePlayerStats()
        {
            // Update the player stats as needed.

            try
            {
                lblPlayerName.Text = "Playing as: " + currentPlayer.PlayerName;
                lblScore.Text = "Current Bank: " + currentPlayer.BankAmount.ToString("$###,###.##");
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Error ...");
            }

        }

        private void ChangePlayer_Click(object sender, EventArgs e)
        {
            string newPlayerName = "";
            string loadPlayerName = "";
            bool getScore = false;

            try
            {
                // Open the player selection dialog.
                using(PlayerLoad plForm = new PlayerLoad())
                {
                    if(plForm.ShowDialog(this) == DialogResult.OK)
                    {
                        // Get the dialog values.
                        newPlayerName = plForm.txtPlayerName.Text;
                        loadPlayerName = plForm.LoadedPlayerName;
                        getScore = plForm.chkGetScore.Checked;

                        // Give precedence to a new player name.
                        if (newPlayerName.Length > 0)
                        { 
                            currentPlayer.PlayerName = newPlayerName;
                            currentPlayer.BankAmount = 1000;
                        }
                        else if (loadPlayerName.Length > 0)
                        {
                            currentPlayer.PlayerName = loadPlayerName;
                            if(getScore)
                            {
                                currentPlayer.BankAmount = plForm.PlayerScore;
                            }
                        }
                    }

                }

                // Update the player statistics on the form.
                UpdatePlayerStats();

            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Error ...");
            }
            
        }

        private void exitToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }
    }
}
