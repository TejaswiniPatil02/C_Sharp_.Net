using System;

namespace Program17
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hello World!");

            Random random = new Random();
            bool playagain = true;
            int min = 1;
            int max = 100;
            int guess;
            int number;
            int guesses;
            string response;

            while(playagain)
                {
                guess = 0;
                guesses = 0;
                response = " ";
                number = random.Next(min, max + 1);

                while (guess != number)
                {
                    Console.WriteLine("Guess a number between" + min + " - " + max + ":");
                    guess = Convert.ToInt32(Console.ReadLine());
                    Console.WriteLine("Guess: " + guess);

                    if (guess > number)
                    {
                        Console.WriteLine(guess + " is to high!!");
                    }
                    else if (guess < number)
                    {
                        Console.WriteLine(guess + " is to low!!");
                    }
                    guesses++;
                }
                Console.WriteLine("Number : " + number);
                Console.WriteLine("YOU WIN !!!");
                Console.WriteLine("guesses :" + guesses);

                Console.WriteLine("Would you like to play again (Y/N) : ");
                response = Console.ReadLine();
                response = response.ToUpper();

                if (response == "Y")
                {
                    playagain = true;
                }
                else
                {
                    playagain = false;
                }

            }

            Console.WriteLine("Thanks for playing !...... I Guess");


            Console.ReadKey();
        }
    }
}
