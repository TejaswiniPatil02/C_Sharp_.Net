using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace program12
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Enter Your Marks : ");
            int marks = Convert.ToInt32(Console.ReadLine());
            

            if (marks >= 99)
            {
                Console.WriteLine("Grade A !!");
            }
            else if (marks >= 80)
            {
                Console.WriteLine("Grade B !!");
            }
            else if (marks >= 70)
            {
                Console.WriteLine("Grade C !!!");
            }
            else if (marks >= 60)
            {
                Console.WriteLine("Grade D !!!");
            }
            else
            {
                Console.WriteLine("You Are Not Eligible bcoz Grade D are last You Try Again");
            }
            Console.ReadLine();
        }
    }
}
