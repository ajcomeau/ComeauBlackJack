using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ComeauBlackJack
{
    class ActiveDeck
    {
        // The available and used cards are maintained in
        // string Lists that store the keys referencing the 
        // cards in the source ImageList.
        private List<string> cDeck = new List<string>();
        private List<string> cUsed = new List<string>();
        private bool cUseJokers;

        public List<string> currentDeck
        {
            // Available cards.
            get { return cDeck; }
            set { cDeck = value; }
        }

        public List<string> DiscardPile
        {
            // Used cards.
            get { return cUsed; }
            set { cUsed = value; }
        }

        public bool UseJokers
        {
            // Indicates if game should use jokers.
            get { return cUseJokers; }
            set { cUseJokers = value; }
        }

        public ActiveDeck(ImageList SourceDeck)
        {
            // Constructor to obtain new deck.
            ShuffleDeck(SourceDeck);
        }

        public static int GetCardValue(string Key)
        {
            // Parse the key value for the card (i.e. 3_clubs.bmp)
            // to get the value for the card.
            int returnValue = 0;
            string valuePart = "";

            try
            {
                valuePart = Key.Substring(0, Key.IndexOf('_'));

                // If it's a face card, assign a value manually.
                // Otherwise, take the number at the front of the key value.
                if (!int.TryParse(valuePart, out returnValue))
                {
                    switch (valuePart.ToUpper())
                    {
                        case "JACK":
                            returnValue = 10;
                            break;
                        case "QUEEN":
                            returnValue = 10;
                            break;
                        case "KING":
                            returnValue = 10;
                            break;
                        case "ACE":
                            returnValue = 11;
                            break;
                        default:
                            returnValue = 0;
                            break;
                    }
                }
            }
            catch (Exception ex)
            {
                throw ex;
            }

            return returnValue;
        }

        public bool ShuffleDeck(ImageList NewDeck)
        {
            bool result = false;
            Random rand = new Random(DateTime.Now.Millisecond);
            string keyPick = "";

            try
            {
                // Clear any cards in the discard pile.
                DiscardPile.Clear();

                // Clear the remaining cards from the active deck.
                cDeck.Clear();

                // Insert five cards at random from the source deck.
                while(cDeck.Count < 5)
                {
                    keyPick = NewDeck.Images.Keys[rand.Next(NewDeck.Images.Keys.Count- 1)];

                    if (ActiveDeck.GetCardValue(keyPick) > 0 && !cDeck.Contains(keyPick))
                    {
                        cDeck.Add(keyPick);
                    }
                }

                // Then iterate through the new deck and place each card at random in the active deck.
                foreach (string c in NewDeck.Images.Keys)
                {
                    if (!cDeck.Contains(c) && GetCardValue(c) > 0)
                    {
                        cDeck.Insert(rand.Next(cDeck.Count - 1) , c);
                    }
                }

                result = true;

            }
            catch (Exception ex)
            {
                result = false;
                throw ex;
            }

            return result;

        }

        public bool DealCards(int Number, Player Receiver)
        {
            // Not completed yet.
            bool result = false;

            try
            {

            }
            catch (Exception ex)
            {
                throw ex;
            }


            return result;
        }

    }


}
