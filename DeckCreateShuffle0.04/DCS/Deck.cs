using System.Text;
using static System.Console;

namespace DCS004
{
    class Deck
    {
        private const byte size = 52, suitNum = 4;

        private const int shufTime = 2000;
        //creating the new array for cards = values + suits
        private readonly string[] cards = new string[size];

        public void Unbox()
        {
            //arrays for values and suits
            char[] Face = new char[size / suitNum];
            char[] Suit = new char[suitNum];
            //counters
            byte i = 0, j = 0, k = 0;
            //adding values from all possible values
            for (i = 0; i < size / suitNum; i++)
            {
                Face[i] = GV.GetFaces(i);
            }
            //adding suits from all possible suits
            for (i = 0; i < suitNum; i++)
            {
                Suit[i] = GV.GetSuits(i);
            }

            for (i = 0; i < size; i++)
            {
                cards[i] += Face[j];
                cards[i] += Suit[k];
                //next code concatenate values and suits in order to suits sequence
                if (i % suitNum != suitNum - 1)
                    k++;
                else
                {
                    k = 0;
                    j++;
                }
            }
        }
        //shuffling based on Durstenfeld's algorithm
        public void Shuffle()
        {   //shuffle in the shuftime
            for (int k = 1; k <= shufTime; k++)
            {
                for (byte i = size - 1; i > 0; i--)
                {
                    byte j = RandomGen.RNCryp(i);
                    StringBuilder m = new StringBuilder(cards[i]);
                    cards[i] = cards[j];
                    cards[j] = m.ToString();
                }
            }
        }

        public void Show()
        {
            for (byte i = 0; i < size; i++)
            {
                Write(cards[i]);
                if (i % 2 == 1)
                    Write(' ');
            }
        }
    }
}
