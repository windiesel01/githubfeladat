using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Teszt
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Adj meg egy számot:");
            int szam1 = Convert.ToInt32(Console.ReadLine());
            Console.Write("Adj meg még egy számot:");
            int szam2 = Convert.ToInt32(Console.ReadLine());

            if (szam1 > szam2)
            {
                Console.WriteLine($"\tA nagyobb szám:{szam1}");
            }
            else
            {
                Console.WriteLine($"\tA nagyobb szám:{szam2}");
            }
        }
    }
}
