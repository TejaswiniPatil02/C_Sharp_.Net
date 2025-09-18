using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace practise03
{
    class Program
    {
        static void Main(string[] args)
        {
            /*Console.Write("Enter Your Name : ");
            string name = Console.ReadLine();
            Console.WriteLine("Hello," + name + "!!!!!!!");
            Console.ReadLine();
            */
            Console.Write("Enter yor name:");
            string name = Console.ReadLine();
            Console.Write("Enter Your Age:");
            int age =Convert.ToInt32 ( Console.ReadLine());
            Console.Write("Enter your marks:");
            double marks = Convert.ToDouble(Console.ReadLine());
            Console.Write("Enter This is student or not : ");
            string isstudent = Console.ReadLine();



            Console.WriteLine("!!!!!!!!!.....Hello All ....!!!!!!!!");
            Console.WriteLine("Name: " + name);
            Console.WriteLine("age:" + age);
            Console.WriteLine("marks:" + marks);
            Console.WriteLine("isStudent:" + isstudent);
            Console.ReadLine();
            
        }
    }
}
