using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ComeauBlackJack
{
    // Enumeration for assigning card status.
    public enum CardAssignment
    {
        ActiveDeck,   // Available to be dealt
        Player,       // In a player's hand.
        DiscardPile   // Played and discarded.
    }

    // Class used to pass references to specific cards around.
    public class PlayingCard
    {
        private string cCardName;
        private Player cPlayer;
        private CardAssignment cAssigned;
        private bool cFaceDown;

        public string CardName
        {
            // Image key of the card, i.e. "9_Clubs.bmp"
            get { return cCardName; }
            set { cCardName = value; }
        }

        public CardAssignment Assigned
        {
            // What is the card's status?
            get { return cAssigned; }
            set
            {
                cAssigned = value;
                // If the card is not assigned to a player
                // make sure it's face up.
                cFaceDown = (value == CardAssignment.Player);
            }
        }

        public Player PlayerAssign
        {
            // Which player is holding the card?
            get { return cPlayer; }
            set { cPlayer = value; }
        }

        public int CardValue
        {
            // Call to ActiveDeck function for convenience.
            get { return ActiveDeck.GetCardValue(cCardName); }
        }

        public bool FaceDown
        {
            // Is the card facedown?
            get { return cFaceDown; }
            set { cFaceDown = value; }
        }
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
                // Return the list of cards assigned to players.
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
                    if (pCard.Assigned == CardAssignment.ActiveDeck && pCard.CardValue > 0)
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
                    if (pCard.Assigned == CardAssignment.DiscardPile && pCard.CardValue > 0)
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

        public ActiveDeck(ImageList SourceDeck, bool UseJokers)
        {
            // Constructor to obtain complete new deck.
            ShuffleDeck(SourceDeck);
            cUseJokers = UseJokers;
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

        public void ReorderCards()
        {
            PlayingCard pCard;
            Random rand = new Random(DateTime.Now.Millisecond);

            try
            {
                //Shuffle the deck by repeatedly pulling out a random card
                //and sending it to the end of the deck.
                for (int x = 1; x <= 500; x++)
                {
                    pCard = cCurrentDeck[rand.Next(cCurrentDeck.Count - 1)];
                    if (pCard.Assigned == CardAssignment.ActiveDeck)
                    {
                        cCurrentDeck.Remove(pCard);
                        cCurrentDeck.Add(pCard);
                    }
                }
            }
            catch (Exception ex)
            {
                throw ex;
            }

        }

        public bool ShuffleDeck(ImageList newDeck)
        {
            // Initialize an entire new deck from ImageList.
            bool result = false;
            PlayingCard pCard;
           
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
            }
            catch (Exception ex)
            {
                throw ex;
            }

            return result;
        }

        public bool ShuffleDeck(bool IncludePlayerHands, bool Reorder)
        {
            // Reset the deck by recycling the discard pile.
            bool result = false;
            PlayingCard pCard;

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

                // Shuffle if necessary.
                if (Reorder)
                    ReorderCards();

                result = true;
            }
            catch (Exception ex)
            {
                result = false;
                throw ex;
            }
            return result;

        }

        public bool Discard(List<PlayingCard> Discarded)
        {
            // Find a card and put it in the discard pile.
            bool result = false;
            PlayingCard deckCard;
            try
            {
                foreach(PlayingCard pCard in Discarded)
                {
                    // Search by card name.
                    deckCard = cCurrentDeck.Find(p => p.CardName == pCard.CardName);
                    deckCard.Assigned = CardAssignment.DiscardPile;
                    deckCard.PlayerAssign = null;
                }
            }
            catch (Exception ex)
            {
                throw ex;
            }

            return result;
        }


        public bool Discard(PlayingCard Discarded)
        {
            // Find a card and put it in the discard pile.
            bool result = false;
            PlayingCard deckCard;
            try
            {
                // Search by card name.
                deckCard = cCurrentDeck.Find(p => p.CardName == Discarded.CardName);
                deckCard.Assigned = CardAssignment.DiscardPile;
                deckCard.PlayerAssign = null;
            }
            catch (Exception ex)
            {
                throw ex;
            }

            return result;
        }

        public bool DealCards(int NumberOfCards, Player Receiver, bool Facedown)
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
                    // If there are fewer cards remaining than the number requested,
                    // recycle the discard pile.
                    this.ShuffleDeck(false, true);
                }

                for (int x = 1; x <= NumberOfCards; x++)
                {
                    // For each card requested, search the deck at random
                    // for an available card.
                    cardAvailable = false;

                    while (!cardAvailable)
                    {
                        deckIndex = rand.Next(cCurrentDeck.Count - 1);
                        pCard = cCurrentDeck[deckIndex];
                        // Once a card is found, add it to the player's hand and
                        // update its properties.
                        if(pCard.Assigned == CardAssignment.ActiveDeck & GetCardValue(pCard.CardName) > 0)
                        {
                            cardAvailable = true;
                            pCard.Assigned = CardAssignment.Player;
                            pCard.PlayerAssign = Receiver;
                            pCard.FaceDown = Facedown;
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
