using System;
using System.Globalization;

namespace Cassino
{
    class Program
    {
        static void Main(string[] args)
        {
            double odds = .75;
            Random random = new Random();

            Guy player = new Guy() { Cash = 100, Name = "Player 1" };
            Guy player2 = new Guy() { Cash = 100, Name = "Player 2" };

            Console.WriteLine("Welcome to the Cassino " + player.Name + " .The odds are " + odds.ToString("F2", CultureInfo.InvariantCulture));
            while (player.Cash > 0)
            {
                player.WriteMyInfo();
                Console.Write("How much money do you want to bet: ");
                string howMuch = Console.ReadLine();
                if (int.TryParse(howMuch, out int amount))
                {
                    int pot = player.GiveCash(amount) * 2;
                    if (pot > 0)
                    {
                        if (random.NextDouble() > odds)
                        {
                            int winnings = pot;
                            Console.WriteLine("You win " + winnings);
                            player.ReceiveCash(winnings);
                        }
                        else
                        {
                            Console.WriteLine("Bad luck, you lose.");
                        }
                    }
                }
                else
                {
                    Console.WriteLine("Please enter a valid number.");
                }
            }
            Console.WriteLine("The house always wins!");

            Console.WriteLine("Welcome to the Cassino " + player2.Name + " .The odds are " + odds.ToString("F2", CultureInfo.InvariantCulture));
            while (player2.Cash > 0)
            {
                player2.WriteMyInfo();
                Console.Write("How much money do you want to bet: ");
                string howMuch = Console.ReadLine();
                if (int.TryParse(howMuch, out int amount))
                {
                    int pot = player2.GiveCash(amount) * 2;
                    if (pot > 0)
                    {
                        if (random.NextDouble() > odds)
                        {
                            int winnings = pot;
                            Console.WriteLine("You win " + winnings);
                            player2.ReceiveCash(winnings);
                        }
                        else
                        {
                            Console.WriteLine("Bad luck, you lose.");
                        }
                    }
                }
                else
                {
                    Console.WriteLine("Please enter a valid number.");
                }
            }
            Console.WriteLine("The house always wins!");
        }

    }
}
