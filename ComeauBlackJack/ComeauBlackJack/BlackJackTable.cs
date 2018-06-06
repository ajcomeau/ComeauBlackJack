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

        Player currentPlayer = new Player("Andrew", 1000);
        ActiveDeck currentDeck;

        public BlackJackTable()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {

            // Testing of class functions.

            PlayingCard deckCard;

            // Add a new player and deal five cards.
            Player newPlayer = new Player("Andrew", 1000);
            currentDeck.DealCards(5, newPlayer);

            // Clear the list box and show the player's cards.
            lstHand.Items.Clear();
            foreach(PlayingCard pCard in newPlayer.PlayerHand)
            {
                lstHand.Items.Add(pCard.CardName);
            }

            // Display the total for the hand.
            label1.Text = "Hand total: " + newPlayer.GetHandValue().ToString();
            
            // Discard the player's cards.
            foreach(PlayingCard pCard in newPlayer.PlayerHand)
            {
                currentDeck.Discard(pCard);
            }
            newPlayer.PlayerHand.Clear();

            // Display the number of cards remaining in the deck.
            lblCardsLeft.Text = "Cards remaining: " + currentDeck.RemainingCards.Count.ToString();

        }

        private void BlackJackTable_Load(object sender, EventArgs e)
        {
            currentDeck = new ActiveDeck(SourceDeck);
        }
    }
}
