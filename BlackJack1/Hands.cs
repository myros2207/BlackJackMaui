using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BlackJack1
{
    internal class Hands
    {

        List<Card> cards = new List<Card>();
        public void AddCard ( Card card)
        {
            cards.Add(card);

        }
        public void CountPoints()
        {
        }
    }
}
