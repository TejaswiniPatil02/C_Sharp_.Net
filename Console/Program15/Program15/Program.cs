using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Program15
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Enter Side A : ");
            double a = Convert.ToDouble(Console.ReadLine());

            Console.WriteLine("Enter Side B : ");
            double b = Convert.ToDouble(Console.ReadLine());

            double c = Math.Sqrt((a * a) + (b * b));

            Console.WriteLine("The hypotenuse is : " +c);
            Console.ReadKey();
        }
    }
}
