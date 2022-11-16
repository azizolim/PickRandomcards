using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PickRandomCards
{
    internal class CardPicker
    {
        static Random random= new Random();

        public string[] PickSomeCards(int _numberOfCards) 
        {
            string[] _pickedCards = new string[_numberOfCards];
            for (int i = 0; i < _numberOfCards; i++) 
            {
                _pickedCards[i] = RandomValue() + " of " + RandomSuit();
            }
            return _pickedCards;
        }

        private static string RandomSuit()
        {
            int value = random.Next(1,5);
            if (value == 1) return "Spades";
            if (value == 2) return "Hearts";
            if(value == 3) return "Clubs";
            return "Diamonds";
        }

        private static string RandomValue()
        {
            int value = random.Next(1, 14);
            if (value == 1) return "Ace";
            if (value == 11) return "Jack";
            if (value == 12) return "Queen";
            if (value == 13) return "King";
            return value.ToString();
        }
    }
}
