namespace DiceGame
{
    class Program
    {
        static void Main(string[] args)
        {
            int playerRandomNumber;
            int enemyRandomNumber;
            int playerpoints = 0;
            int AIpoints = 0;
            
            Random random = new Random();
            
            for (int i = 0; i < 3; i++)
            {
                Console.WriteLine("press any key to roll the dice");

                Console.ReadKey();

                playerRandomNumber = random.Next(1, 7);
                
                Console.WriteLine("your number is: " + playerRandomNumber);

                Console.WriteLine("waiting ... ");
                System.Threading.Thread.Sleep(1000);

                enemyRandomNumber = random.Next(1, 7);
                Console.WriteLine("AI number is: "+ enemyRandomNumber);

                if (playerRandomNumber>enemyRandomNumber)
                {
                    playerpoints++;
                    Console.WriteLine("palyer Wins this round");
                }
                else if (playerRandomNumber<enemyRandomNumber)
                {
                    AIpoints++;
                    Console.WriteLine("AI wins this round ");
                }
                else
                {
                    Console.WriteLine("Tie");
                }

                Console.WriteLine("player: "+ playerpoints + "  AI: "+AIpoints + ".");
                Console.WriteLine();
            }
            
            if (playerpoints>AIpoints)
            {
                Console.WriteLine("You Wins!");
            }
            else if (playerpoints<AIpoints)
            {
                Console.WriteLine("You lose!");
            }
            else
            {
                Console.WriteLine("it's a Tie");
            }
            Console.ReadKey();
        }
    }
}

 
