using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Progran07
{
    class Program
    {
        static void Main(string[] args)
        {
            int a = 10, b = 5;
            bool c = true, d = false;

                //arithmatic operators

            Console.WriteLine("Addition : " + (a + b));
            Console.WriteLine("Substraction : " + (a - b));
            Console.WriteLine("Multiplication : " + (a * b));
            Console.WriteLine("Division : " + (a / b));
            Console.WriteLine("Modulo : " + (a % b));
            Console.ReadLine();

            //comparion operators

            Console.WriteLine("a is Equal to b ??? " + (a == b));
            Console.WriteLine("A is grater than b : " + (a > b));
            Console.WriteLine("A is less than B : " + (a < b));
            Console.WriteLine("A is not equal to b : " + (a != b));
            Console.ReadLine();

            // logical Operators 

            Console.WriteLine("c && d :" + (c && d));
            Console.WriteLine(" c || d : " + (c || d));
            Console.WriteLine("c != d : " + (c != d));


            Console.ReadLine();




        }
    }
}
