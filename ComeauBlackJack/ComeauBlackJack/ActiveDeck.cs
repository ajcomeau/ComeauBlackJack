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
        private ImageList cDeck;
        private ImageList cUsed;
        private bool cUseJokers;

        public ImageList currentDeck
        {
            get { return cDeck; }
            set { cDeck = value; }
        }

        public ImageList DiscardPile
        {
            get { return cUsed; }
            set { cUsed = value; }
        }

        public bool UseJokers
        {
            get { return cUseJokers; }
            set { cUseJokers = value; }
        }

        public bool ShuffleDeck(bool CollectPlayerHands)
        {
            bool returnResult = false;
            try
            {

            }
            catch (Exception ex)
            {

                throw ex;
            }


            return returnResult;

        }

        public bool DealCards(int Number, Player Receiver)
        {

        }

    }


}
