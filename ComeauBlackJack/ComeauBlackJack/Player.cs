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
    public class Player:IEnumerable<string>
    {
        // Class to store player details including the player's hand.
        private List<string> cPlayerhand = new List<string>();
        private string cName;
        private double cBank;

        public List<string> PlayerHand
        {
            // Player's current hand stored as a list of key values.
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

        public Player()
        {
            // Default constructor for guest player
            // with starting bank of $1000.
            cName = "Guest";
            cBank = 1000;
        }

        public Player(string PlayerName, double BankAmount)
        {
            cName = PlayerName;
            cBank = BankAmount;
        }

        public int GetHandValue()
        {
            // Function to return value of player's hand
            // anytime it's needed.
            //TODO: Finish to account for Aces in hand.

            int returnValue = 0;

            try
            {
                // For each card in the hand, call the static function
                // GetCardValue in the ActiveDeck class and return sum.
                foreach(string c in cPlayerhand)
                {
                    // Count Aces as 11 unless the hand is over 10 already.
                    if (c.ToUpper().StartsWith("ACE") && returnValue > 10)
                        returnValue++;
                    else
                        returnValue += ActiveDeck.GetCardValue(c);
                }
            }
            catch (Exception ex)
            {
                throw ex;
            }

            return returnValue;
        }

        public void SavePlayerStats()
        { 
            

        }

        public IEnumerator<string> GetEnumerator()
        {
            // IEnumerable function to allow iteration through
            // cards in player's hand.
            foreach (string i in cPlayerhand)
            {
                if (i == null)
                    break;

                yield return i;
            }
        }

        IEnumerator IEnumerable.GetEnumerator()
        {
             return this.GetEnumerator();
        }
    }
}
