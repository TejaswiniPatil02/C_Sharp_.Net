using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Program08
{
    class Program
    {
        static void Main(string[] args)
        {
            //assignment Opearator

            int x = 10;
            x += 5;
            Console.WriteLine("x += 5: " + x);          // 10+5= 15
            x *= 15;
            Console.WriteLine("x *= 5 : " + x);         //15*15= 225
            x /= 2;
            Console.WriteLine("x /= 5 : " + x);       // 225/2=112

            Console.ReadLine();
        }
    }
}
