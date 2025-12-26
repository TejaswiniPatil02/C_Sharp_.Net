using System;

namespace Program18
{
    class Program
    {
        static void Main(string[] args)
        {
            Random random = new Random();
            bool playagain = true;
            string player;
            string computer;

            while(playagain)
            {
                player = " ";
                computer = " ";
                while( player != "ROCK" && player != "PAPER" && player != " SCISSORS")
                { 
                Console.Write("Enter ROCK, PAPER, OR SCISSORS:");
                player = Console.ReadLine();
                player = player.ToUpper();
                }

                switch (random.Next(1,4))
                {
                    case 1:
                        computer = "ROCK";
                        break;
                    case 2:
                        computer = "PAPER";
                        break;
                    case 3:
                        computer = "SCISSORS";
                        break;

                }

                Console.WriteLine("player: " + player);
                Console.WriteLine("computer: " + computer);

                switch (player)
                {
                    case "ROCK":
                        if (computer == "ROCK")
                        {
                            Console.WriteLine("Its a draw !!");
                        }
                        else if (computer == "PAPER") 
                        {
                            Console.WriteLine("You lose !!");
                        }
                        else
                        {
                            Console.WriteLine("You Win !!!");
                        }
                        break;
                    case "PAPER":
                        if (computer == "ROCK")
                        {
                            Console.WriteLine("You Win !!");
                        }
                        else if (computer == "PAPER")
                        {
                            Console.WriteLine("Its a draw!!");
                        }
                        else
                        {
                            Console.WriteLine("You lose !!!");
                        }
                        break;
                    case "SCISSORS":
                        if (computer == "ROCK")
                        {
                            Console.WriteLine("You lose !!");
                        }
                        else if (computer == "PAPER")
                        {
                            Console.WriteLine("You Win !!");
                        }
                        else
                        {
                            Console.WriteLine(" Its a draw!!!!");
                        }
                        break;
                }
            }

           
            Console.ReadLine();
        }
    }
}
