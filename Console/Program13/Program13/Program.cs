using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Program13
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Enter yor Age :");
            int age = Convert.ToInt32(Console.ReadLine());

            Console.Write("Enter yor Weight : ");
            int waight = Convert.ToInt32(Console.ReadLine());

            if (age >= 18)
            {
             if(waight >=55)
                {
                    Console.WriteLine("You are eligible for blodd donation");
                }
                else
                {
                    Console.WriteLine("Yor are Not eligible for blood donation : Your Weight is too low");
                }
                Console.ReadLine();
            }
            else
            {
                Console.WriteLine("Yor Are Not eligible : Age is low ");
            }
            Console.ReadLine();
        }
    }
}
