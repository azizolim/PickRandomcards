using PickRandomCards;

internal class Program
{
    private static bool _play; 
    private static void Main(string[] args)
    {
        
        do
        {
            Console.Write("Enter the number of cards to pick: ");
            string _line = Console.ReadLine();
            if (int.TryParse(_line, out int _numberOfCards))
            {
                _play = false; 
                CardPicker card = new CardPicker();
                string[] cardArray = card.PickSomeCards(_numberOfCards);
                for (int i = 0; i < cardArray.Length; i++)
                {
                    Console.WriteLine(cardArray[i]);

                }    
            }
            else
            {
                Console.WriteLine("Please input right number");
                _play = true;
            }
        }
        while (_play == true);
    }

}