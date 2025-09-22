using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Program04                           //Find the largest 3 Numbers
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Enter First Number : ");
            int a = Convert.ToInt32(Console.ReadLine());

            Console.Write("Enter Second Number : ");
            int b = Convert.ToInt32(Console.ReadLine());

            Console.Write("Enter Third Number : ");
            int c = Convert.ToInt32(Console.ReadLine());

            int largest = a;
            if (b > largest) largest = b;
            if (c > largest) largest = c;

            Console.WriteLine("Largest Number is : " + largest);
        }
    }
}
