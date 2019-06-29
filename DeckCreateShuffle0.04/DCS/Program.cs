using static System.Console;

namespace DCS004
{
    class Program
    {
        static void Main()
        {
            WriteLine("Deck 1");
            //first deck for the banker
            Deck Deck1 = new Deck();
            Deck1.Unbox();
            Deck1.Shuffle();
            Deck1.Show();

            WriteLine();
            WriteLine();
            //second deck for the punter
            WriteLine("Deck 2");
            Deck Deck2 = new Deck();
            Deck2.Unbox();
            //it's hasn't shuffle
            Deck2.Show();
            ReadLine();
        }
    }
}