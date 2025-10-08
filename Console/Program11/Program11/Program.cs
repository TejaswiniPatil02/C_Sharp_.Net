using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Program11
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Enter Your Number : ");
            int number = Convert.ToInt32(Console.ReadLine());

        if(number %2 ==0)
            {
                Console.WriteLine("Odd Number !!");
                Console.ReadLine();

            }
            else
            {
                Console.WriteLine("Even Number !!!");
                Console.ReadLine();
            }
        }
    }
}
