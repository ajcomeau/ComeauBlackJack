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
        Player tablePlayer = new Player("Guest", 1000, false);
        Player dealerPlayer = new Player("Dealer", 1000, true);
        ActiveDeck currentDeck;

        const string BLUEBACK = "Backface_Blue.bmp";
        const string REDBACK = "Backface_Red.bmp";

        public BlackJackTable()
        {
            InitializeComponent();
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
                lblPlayerName.Text = "Playing as: " + tablePlayer.PlayerName;
                lblPlayer.Text = tablePlayer.PlayerName;
                lblScore.Text = "Current Bank: " + tablePlayer.BankAmount.ToString("$###,###.##");
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Error ...");
            }

        }

        private void DisplayHand(Player SpecificPlayer)
        {
            int leftPos = 1;
            int topPos = 5;
            int rowCount = 1;
            int handValue = SpecificPlayer.GetHandValue();

            try
            {
                Panel focusPanel;

                if (SpecificPlayer.Dealer)
                    focusPanel = panelDealer;
                else
                    focusPanel = panelPlayer;

                focusPanel.Controls.Clear();

                foreach (PlayingCard card in SpecificPlayer.PlayerHand)
                {
                    // Create a new picturebox for each card image 
                    // apply the correct settings and add to the form
                    // controls.
                    PictureBox newCard = new PictureBox();
                    
                    newCard.Location = new Point(leftPos, topPos);
                    newCard.Size = new Size(50, 70);
                    newCard.SizeMode = PictureBoxSizeMode.AutoSize;

                    if (card.FaceDown)
                        newCard.Image = SourceDeck.Images[REDBACK];
                    else
                        newCard.Image = SourceDeck.Images[card.CardName];
                    
                    focusPanel.Controls.Add(newCard);
                    newCard.BringToFront();

                    // Wrap to a new row when the form's width is about to
                    // be exceeded.
                    if ((leftPos + 100) > focusPanel.Width)
                    {
                        rowCount++;
                        topPos += 15;
                        leftPos = (rowCount * 25);
                    }
                    else
                    {
                        leftPos += 30;
                    }
                }

                // Update hand values.
                if (SpecificPlayer.Dealer)
                    lblDealerHandValue.Text = handValue.ToString();
                else
                    lblPlayerHandValue.Text = handValue.ToString();
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
                            tablePlayer.PlayerName = newPlayerName;
                            tablePlayer.BankAmount = 1000;
                        }
                        else if (loadPlayerName.Length > 0)
                        {
                            tablePlayer.PlayerName = loadPlayerName;
                            if(getScore)
                            {
                                tablePlayer.BankAmount = plForm.PlayerScore;
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

        private void DealHand_Click(object sender, EventArgs e)
        {
            try
            {
                // Clear player hands.

                currentDeck.Discard(dealerPlayer.PlayerHand);
                currentDeck.Discard(tablePlayer.PlayerHand);
                dealerPlayer.PlayerHand.Clear();
                tablePlayer.PlayerHand.Clear();

                // If the current deck is getting low, shuffle.
                if (currentDeck.RemainingCards.Count < 18)
                {
                    currentDeck.ShuffleDeck(true, true);
                }

                // Deal two cards face up to the player.
                currentDeck.DealCards(2, tablePlayer, false);

                // Deal two cards to the dealer, one facedown
                currentDeck.DealCards(1, dealerPlayer, true);
                currentDeck.DealCards(1, dealerPlayer, false);

                // Display hands.
                DisplayHand(dealerPlayer);
                DisplayHand(tablePlayer);

            }
            catch (Exception ex)
            {
                throw ex;
            }
        }


    }
}
