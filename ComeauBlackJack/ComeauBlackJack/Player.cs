using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.SqlClient;
using System.Collections;
using System.Drawing;

namespace ComeauBlackJack
{
    public class Player
    {
        // Class to store player details including the player's hand.
        private List<PlayingCard> cPlayerhand = new List<PlayingCard>();
        private string cName;
        private double cBank;
        private bool cDealer;

        public List<PlayingCard> PlayerHand
        {
            get { return cPlayerhand; }
            set { cPlayerhand = value; }
        }

        public string PlayerName
        {
            get { return cName; }
            set { cName = value; }
        }

        public double BankAmount
        {
            get { return cBank; }
            set { cBank = value; }
        }

        public bool Dealer
        {
            get { return cDealer; }
            set { cDealer = value; }
        }

        public Player()
        {
            // Default constructor for guest player
            // with starting bank of $1000.
            cName = "Guest";
            cBank = 1000;
        }

        public Player(string PlayerName, double BankAmount, bool IsDealer)
        {
            cName = PlayerName;
            cBank = BankAmount;
            cDealer = IsDealer;
        }

        public int GetHandValue()
        {
            // Function to return value of player's hand
            // anytime it's needed.

            int returnValue = 0;
            int numberOfAces = 0;

            try
            {
                // For each card in the hand, call the static function
                // GetCardValue in the ActiveDeck class and return sum.
                foreach(PlayingCard c in cPlayerhand)
                {
                    // Only count face up cards.
                    if(!c.FaceDown)
                    { 
                    // Count Aces last.
                    if (c.CardName.ToUpper().StartsWith("ACE"))
                        numberOfAces++;
                    else
                        returnValue += ActiveDeck.GetCardValue(c.CardName);
                    }
                }

                // For each Ace, add 11 if the hand is 10 or less.
                // Otherwise, add 1.
                for(int x = 1; x <= numberOfAces; x++)
                {
                    if (returnValue > 10)
                        returnValue++;
                    else
                        returnValue += 11;                    
                }
            }
            catch (Exception ex)
            {
                throw ex;
            }

            return returnValue;
        }

        public void DiscardHand()
        {
            try
            {
                foreach(PlayingCard pCard in cPlayerhand)
                {
                    
                }
            }
            catch (Exception ex)
            {

                throw ex;
            }


        }

        public void SavePlayerStats()
        { 
            

        }

        public IEnumerator<string> GetEnumerator()
        {
            // IEnumerable function to allow iteration through
            // cards in player's hand.
            foreach (PlayingCard i in cPlayerhand)
            {
                if (i.CardName == null)
                    break;

                yield return i.CardName;
            }
        }

        //IEnumerator IEnumerable.GetEnumerator()
        //{
        //     return this.GetEnumerator();
        //}
    }
}
