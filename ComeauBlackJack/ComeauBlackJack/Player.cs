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
        private List<string> cPlayerhand = new List<string>();
        private string cName;
        private double cBank;

        public List<string> PlayerHand
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

        public Player()
        {
            cName = "Guest";
            cBank = 1000;
        }

        public Player(string PlayerName)
        {
            cName = PlayerName;
        }

        public int GetHandValue()
        {
            int returnValue = 0;

            try
            {
                foreach(string c in cPlayerhand)
                {
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
