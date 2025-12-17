using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Program16
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Please Enter Your Name : ");
            string name = Console.ReadLine();

            if(name == "")
            {
                Console.WriteLine("You Did Not Enter Your Name !!");
            }
            else
            {
                Console.WriteLine("Hello" +  name);
            }
            Console.ReadKey();
        }
    }
}
