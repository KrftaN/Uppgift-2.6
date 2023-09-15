using System;
using System.Linq;

namespace Uppgift_2._6
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Skriv en mening:");
            char[] punkt = { '.' };
            string input = Console.ReadLine().TrimEnd(punkt);

            Console.WriteLine(string.Join(" ", input.Split(' ').Reverse()) + ".");
            Console.ReadKey();
        }
    }
}
