using System;3

namespace HigherLower
{
    class Program
    {
        static void Main(string[] args)
        {
            // start screen
            Console.WriteLine("------------------");
            Console.WriteLine("- HIGHER | LOWER -");
            Console.WriteLine("------------------");

            // game variables
            var isGameRunning = true;

            // game loop
            while (isGameRunning)
            {
                // selection of player
                var player = GetPlayerSelection();

                // selection of computer
                var computer = new Random().Next(1, 101);

                // set counter
                var counter = 1;

                // game logic
                while (player != computer)
                {
                    if (player > computer)
                        Console.WriteLine("Your number is too high!");
                    else
                        Console.WriteLine("Your number is too low!");

                    counter++;
                    player = GetPlayerSelection();
                }

                Console.WriteLine($"Congratulations! You matched my number in {counter} steps!\n\n");

                // restart game
                Console.WriteLine("Do you want to restart the game?\n[y] yes | [n] no");
                var input = Console.ReadLine();

                if (input.ToLower() != "y")
                    isGameRunning = false;
            }
        }

        static int GetPlayerSelection()
        {
            Console.WriteLine("Enter a number between 1 and 100:");
            var input = Console.ReadLine();

            if (int.TryParse(input, out int intVariable))
            {
                if (intVariable >= 1 && intVariable <= 100)
                    return intVariable;
            }

            return GetPlayerSelection();
        }
    }
}
