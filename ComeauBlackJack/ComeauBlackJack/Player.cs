using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ComeauBlackJack
{
    public class Player
    {
        ImageList _hand;

        private ImageList cPlayerhand;

        public ImageList PlayerHand
        {
            get { return cPlayerhand; }
            set { cPlayerhand = value; }
        }

    }
}
