using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ComeauBlackJack
{
    public enum CardAssignment
    {
        ActiveDeck,
        Player,
        DiscardPile
    }

    public class PlayingCard
    {
        public string CardName;
        public CardAssignment Assigned;
    }

    class ActiveDeck
    {
        // The available and used cards are maintained in
        // string Lists that store the keys referencing the 
        // cards in the source ImageList.
        private List<PlayingCard> cCurrentDeck = new List<PlayingCard>();
        private bool cUseJokers;

        public List<PlayingCard> CurrentDeck
        {
            get { return cCurrentDeck; }
            set { cCurrentDeck = value; }
        }

        public List<string> PlayerCards
        {
            get
            {
                List<string> returnList = new List<string>();
                foreach(PlayingCard pCard in cCurrentDeck)
                {
                    if(pCard.Assigned == CardAssignment.Player)
                    {
                        returnList.Add(pCard.CardName);
                    }
                }

                return returnList;
            }
        }

        public List<string> RemainingCards
        {
            // Available cards.
            get
            {
                List<string> returnList = new List<string>();
                foreach (PlayingCard pCard in cCurrentDeck)
                {
                    if (pCard.Assigned == CardAssignment.ActiveDeck)
                    {
                        returnList.Add(pCard.CardName);
                    }
                }

                return returnList;
            }
        }

        public List<string> DiscardPile
        {
            // Used cards.
            get
            {
                List<string> returnList = new List<string>();
                foreach (PlayingCard pCard in cCurrentDeck)
                {
                    if (pCard.Assigned == CardAssignment.DiscardPile)
                    {
                        returnList.Add(pCard.CardName);
                    }
                }

                return returnList;

            }
        }

        public bool UseJokers
        {
            // Indicates if game should use jokers.
            get { return cUseJokers; }
            set { cUseJokers = value; }
        }

        public ActiveDeck(ImageList SourceDeck)
        {
            // Constructor to obtain complete new deck.
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

        public bool ShuffleDeck(ImageList newDeck)
        {
            bool result = false;
            PlayingCard pCard;
            Random rand = new Random(DateTime.Now.Millisecond);

            cCurrentDeck.Clear();
            try
            {
                foreach(string card in newDeck.Images.Keys)
                {
                    pCard = new PlayingCard();
                    pCard.Assigned = CardAssignment.ActiveDeck;
                    pCard.CardName = card;
                    cCurrentDeck.Add(pCard);
                }

                //Shuffle
                for (int x = 1; x <= 500; x++)
                {
                    pCard = cCurrentDeck[rand.Next(cCurrentDeck.Count - 1)];
                    cCurrentDeck.Remove(pCard);
                    cCurrentDeck.Add(pCard);
                }

            }
            catch (Exception ex)
            {
                throw ex;
            }

            return result;
        }

        public bool ShuffleDeck(bool IncludePlayerHands, bool Reorder)
        {
            // Recycle the discard pile.
            bool result = false;
            PlayingCard pCard;
            Random rand = new Random();

            try
            {
                // Iterate through the deck and reassign cards as necessary.
                for (int x = 0; x < cCurrentDeck.Count; x++)
                {
                    pCard = cCurrentDeck[x];
                    if (pCard.Assigned != CardAssignment.ActiveDeck)
                    {
                        if (pCard.Assigned == CardAssignment.Player && IncludePlayerHands)
                            pCard.Assigned = CardAssignment.ActiveDeck;
                        else if (pCard.Assigned == CardAssignment.DiscardPile)
                            pCard.Assigned = CardAssignment.ActiveDeck;
                    }
                }

                if (Reorder)
                {
                    for(int x = 1; x <= 500; x++)
                    {
                        pCard = cCurrentDeck[rand.Next(cCurrentDeck.Count - 1)];
                        cCurrentDeck.Remove(pCard);
                        cCurrentDeck.Add(pCard);
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

        public bool Discard(PlayingCard Discarded)
        {
            bool result = false;
            PlayingCard deckCard;
            try
            {
                deckCard = cCurrentDeck.Find(p => p.CardName == Discarded.CardName);
                deckCard.Assigned = CardAssignment.DiscardPile;
            }
            catch (Exception ex)
            {

                throw ex;
            }


            return result;

        }

        public bool DealCards(int NumberOfCards, Player Receiver)
        {
            // Deal the specified number of cards to the player.
            bool result = false;
            bool cardAvailable = false;
            int deckIndex;
            Random rand = new Random(DateTime.Now.Millisecond);
            PlayingCard pCard;
            
            try
            {             
                if (NumberOfCards > this.RemainingCards.Count)
                {
                    this.ShuffleDeck(false, true);
                }

                for (int x = 1; x <= NumberOfCards; x++)
                {
                    cardAvailable = false;

                    while (!cardAvailable)
                    {
                        deckIndex = rand.Next(cCurrentDeck.Count - 1);
                        pCard = cCurrentDeck[deckIndex];
                        if(pCard.Assigned == CardAssignment.ActiveDeck & GetCardValue(pCard.CardName) > 0)
                        {
                            cardAvailable = true;
                            pCard.Assigned = CardAssignment.Player;
                            cCurrentDeck[deckIndex] = pCard;
                            Receiver.PlayerHand.Add(pCard);
                        }
                    }
                }
            }
            catch (Exception ex)
            {
                throw ex;
            }

            return result;
        }

    }


}
