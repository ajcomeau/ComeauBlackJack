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

        // Enumeration to indicate player with
        // higher score or winning hand.
        enum HighPlayer
        {
            DealerWin,
            DealerBlackJack,
            PlayerWin,
            PlayerBlackJack,
            Push,
            Dealer,
            Player,
            Undetermined,
        }

        // Enumeration to indicate the stage
        // of each hand.
        enum PlayerTurn
        {
            Player,
            Dealer,
            Close
        }

        // Maintain current players and deck for access.
        Player tablePlayer = new Player("Guest", 1000, false);
        Player dealerPlayer = new Player("Dealer", 1000, true);
        ActiveDeck currentDeck;
        PlayerTurn Turn = PlayerTurn.Player;

        const string BLUEBACK = "Backface_Blue.bmp";
        const string REDBACK = "Backface_Red.bmp";
        const int BLACKJACK = 21;

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

        private void ChangePlayer_Click(object sender, EventArgs e)
        {
            // Change the current player.
            string newPlayerName = "";
            string loadPlayerName = "";
            bool getScore = false;

            try
            {
                // Clear the table and start a new game.
                ClearTable();

                // Open the player selection dialog.
                using (PlayerLoad plForm = new PlayerLoad())
                {
                    if (plForm.ShowDialog(this) == DialogResult.OK)
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
                            // Load an existing player from the score file.
                            tablePlayer.PlayerName = loadPlayerName;
                            if (getScore)
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

        private void UpdatePlayerStats()
        {
            // Update the player stats as needed.

            try
            {
                lblPlayerName.Text = "Playing as: " + tablePlayer.PlayerName;
                lblPlayer.Text = tablePlayer.PlayerName + ": ";
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

            // Refresh the display of a player's hand and update the
            // total value on the screen.

            try
            {
                Panel focusPanel;

                // Determine which panel to populate with cards.
                if (SpecificPlayer.Dealer)
                    focusPanel = panelDealer;
                else
                    focusPanel = panelPlayer;

                // Clear the cards from the panel.
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

                    // Substitute back images for facedown cards.
                    if (card.FaceDown)
                        newCard.Image = SourceDeck.Images[REDBACK];
                    else
                        newCard.Image = SourceDeck.Images[card.CardName];

                    // Add card to panel.
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
                    lblDealerHandValue.Text = "Total: " + handValue.ToString();
                else
                    lblPlayerHandValue.Text = "Total: " + handValue.ToString();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Error ...");
            }

        }

        private void ClearPlayerHands()
        {
            try
            {
                // Clear player hands.
                currentDeck.Discard(dealerPlayer.PlayerHand);
                currentDeck.Discard(tablePlayer.PlayerHand);
                dealerPlayer.PlayerHand.Clear();
                tablePlayer.PlayerHand.Clear();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Error ...");
            }

        }

        private void ClearTable()
        {

            try
            {
                // Clear the board
                ClearPlayerHands();
                currentDeck.ShuffleDeck(SourceDeck);
                panelDealer.Controls.Clear();
                panelPlayer.Controls.Clear();
                lblDealerHandValue.Text = "";
                lblPlayerHandValue.Text = "";
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Error ...");
            }
        }

        private void DealButtonSwitch()
        {
            try
            {
                btnDeal.Enabled = !btnDeal.Enabled;
                btnHit.Enabled = !btnHit.Enabled;
                btnStand.Enabled = !btnStand.Enabled;
                dealToolStripMenuItem.Enabled = !dealToolStripMenuItem.Enabled;
                hitToolStripMenuItem.Enabled = !hitToolStripMenuItem.Enabled;
                standToolStripMenuItem.Enabled = !standToolStripMenuItem.Enabled;

            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Error ...");
            }
            
        }
        private void DealHand_Click(object sender, EventArgs e)
        {
            double playerBet = 0;

            try
            {
                ClearPlayerHands();
                PlayerPicture.Image = null;
                DealerPicture.Image = null;

                // If the current deck is getting low, shuffle.
                if (currentDeck.RemainingCards.Count < 18)
                {
                    currentDeck.ShuffleDeck(true, true);
                }

                if (double.TryParse(txtBet.Text, out playerBet))
                {
                    DealButtonSwitch();
                    txtBet.ReadOnly = true;

                    // Deal two cards face up to the player.
                    currentDeck.DealCards(2, tablePlayer, false);

                    // Deal two cards to the dealer, one facedown
                    currentDeck.DealCards(1, dealerPlayer, true);
                    currentDeck.DealCards(1, dealerPlayer, false);

                    // Display hands.
                    DisplayHand(dealerPlayer);
                    DisplayHand(tablePlayer);

                    // Turn the play over to the player at the table.
                    Turn = PlayerTurn.Player;

                    // Look for immediate Blackjack
                    HandProgress(EvaluateHands());
                }
                else
                {
                    MessageBox.Show("Please enter a valid amount for the bet.");
                    txtBet.Text = "";
                }
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }

        private void HitButton_Click(object sender, EventArgs e)
        {
            HighPlayer evalResult;
            try
            {
                // Deal a card to the player at the table and redipslay hand.
                currentDeck.DealCards(1, tablePlayer, false);
                DisplayHand(tablePlayer);
                evalResult = EvaluateHands();
                HandProgress(evalResult);

                // If the dealer won, display the hand.
                if (evalResult < HighPlayer.PlayerWin)
                    DisplayHand(dealerPlayer);
            }
            catch (Exception ex)
            {

                MessageBox.Show(ex.Message, "Error ...");
            }
        }

        private void StandButton_Click(object sender, EventArgs e)
        {
            int dealerHandValue;

            try
            {
                // Turn it over to the dealer to complete the hand.
                Turn = PlayerTurn.Dealer;
                ShowDealerHand();

                // Get the new hand value.
                dealerHandValue = dealerPlayer.GetHandValue();

                // If the dealer is dealt 17 or more, stand.
                if (dealerHandValue > 16)
                    HandProgress(EvaluateHands());
                else
                {
                    while (dealerPlayer.GetHandValue() < 17)
                    {
                        currentDeck.DealCards(1, dealerPlayer, false);
                        HandProgress(EvaluateHands());
                    }
                }

                DisplayHand(dealerPlayer);

            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Error ...");
            }
        }

        private void ProcessBet(Player BettingPlayer, double AdjAmount)
        {
            try
            {
                // Adjust player's bank amount.
                BettingPlayer.BankAmount += AdjAmount;
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Error ...");
            }
        }

        private void HandProgress(HighPlayer status)
        {
            double betAmount;

            try
            {
                // Get the bet amount from the form.
                betAmount = double.Parse(txtBet.Text);

                // If either player has won, show the dealer's hand.
                if (status <= HighPlayer.Push)
                    ShowDealerHand();

                // Display the appropriate message and adjust the bank
                // depending on the winning player.
                switch (status)
                {
                    case HighPlayer.DealerWin:
                        MessageBox.Show("Dealer wins.");
                        ProcessBet(tablePlayer, (betAmount * -1));
                        break;
                    case HighPlayer.DealerBlackJack:
                        DealerPicture.Image = MiscImagery.Images["Blackjack.jpg"];
                        MessageBox.Show("Dealer has Blackjack.");
                        ProcessBet(tablePlayer, (betAmount * -1));
                        break;
                    case HighPlayer.PlayerWin:
                        MessageBox.Show("You win!");
                        ProcessBet(tablePlayer, (betAmount));
                        break;
                    case HighPlayer.PlayerBlackJack:
                        PlayerPicture.Image = MiscImagery.Images["Blackjack.jpg"];
                        MessageBox.Show("BLACKJACK!");
                        ProcessBet(tablePlayer, (betAmount));
                        break;
                    case HighPlayer.Push:
                        if (Turn == PlayerTurn.Close)
                            MessageBox.Show("You and the Dealer push ... sorry.");
                        break;
                    default:
                        break;
                }

                // Update the player stats on the form.
                UpdatePlayerStats();

                // Adjust the controls.
                if (Turn == PlayerTurn.Close)
                {
                    txtBet.ReadOnly = false;
                    DealButtonSwitch();
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Error ...");
            }
        }

        private void ShowDealerHand()
        {
            try
            {
                // Turn the dealer's cards face up.
                foreach (PlayingCard pCard in dealerPlayer.PlayerHand)
                    pCard.FaceDown = false;

                // Show the dealer's entire hand.
                DisplayHand(dealerPlayer);
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Error ...");
            }
        }

        private HighPlayer EvaluateHands()
        {
            // Compare the player hands to determine the result
            // of the play.
            HighPlayer result = HighPlayer.Undetermined;
            int playerHand = tablePlayer.GetHandValue();
            int dealerHand = dealerPlayer.GetHandValue();

            try
            {
                // If it's no longer the table player's turn,
                // show the dealer hand.
                if(Turn < PlayerTurn.Player)
                    ShowDealerHand();

                // Look for a push.
                if (playerHand == dealerHand)
                {
                    result = HighPlayer.Push;
                    // If the hands are 21 or higher, end.
                    if (playerHand >= BLACKJACK)
                        Turn = PlayerTurn.Close;
                }
                    

                // Look for a bust
                if (result == HighPlayer.Undetermined)
                {
                    if (playerHand > BLACKJACK && dealerHand < BLACKJACK)
                    { 
                        // Table player busts.
                        result = HighPlayer.DealerWin;
                        PlayerPicture.Image = MiscImagery.Images["Bust.jpg"];
                    }
                    else if (dealerHand > BLACKJACK && playerHand < BLACKJACK)
                    { 
                        // Dealer busts.
                        result = HighPlayer.PlayerWin;
                        DealerPicture.Image = MiscImagery.Images["Bust.jpg"];
                    }

                    if (result != HighPlayer.Undetermined) Turn = PlayerTurn.Close;
                }

                // Look for a player with 21.
                if (result == HighPlayer.Undetermined)
                {
                    if (playerHand == BLACKJACK || dealerHand == BLACKJACK)
                    {
                        Turn = PlayerTurn.Close;
                        if (playerHand == BLACKJACK)
                            result = HighPlayer.PlayerBlackJack;
                        else
                            result = HighPlayer.DealerBlackJack;
                    }
                }

                // Look for a non-winning high player.
                if (result == HighPlayer.Undetermined)
                    result = (playerHand > dealerHand) ? HighPlayer.Player : HighPlayer.Dealer;

                // The dealer must stand on 17 or greater.
                if (Turn == PlayerTurn.Dealer && dealerHand > 16)
                {
                    if (result != HighPlayer.Push)
                        result = (playerHand > dealerHand) ? HighPlayer.PlayerWin : HighPlayer.DealerWin;

                    Turn = PlayerTurn.Close;
                }

            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Error ...");
            }

            return result;

        }

        private void exitToolStripMenuItem_Click(object sender, EventArgs e)
        {
            // Exit the application.
            Application.Exit();
        }


    }
}
