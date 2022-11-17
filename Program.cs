using PickRandomCards;

internal class Program
{
    private static bool _play;
    private static bool _again;
    private static void Main(string[] args)
    {

        do
        {
            Console.Write("Enter the number of cards to pick: ");
            string _line = Console.ReadLine();
            _play = !int.TryParse(_line, out int _numberOfCards);
            if (!_play)
            {


                CardPicker card = new CardPicker();
                string[] cardArray = card.PickSomeCards(_numberOfCards);
                for (int i = 0; i < cardArray.Length; i++)
                {
                    Console.WriteLine(cardArray[i]);


                }
                Console.WriteLine("Play again?");
                _again = Console.ReadLine() == "yes" ? true : false;
            }
            else
            {
                Console.WriteLine("Please input right number");

            }
        }
        while (_play || _again);
    }     
            

}