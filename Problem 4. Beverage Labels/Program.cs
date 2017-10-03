using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Problem_4.Beverage_Labels
{
    class Program
    {
        static void Main(string[] args)
        {
            var name = Console.ReadLine();

            var volume = int.Parse(Console.ReadLine());

            var energy = int.Parse(Console.ReadLine());

            var sugar = int.Parse(Console.ReadLine());

            var totalenergy = energy * volume / 100.00;
            var totalsugar = sugar * volume / 100.00;

            Console.WriteLine("{0}ml {1}:", volume, name);
            Console.WriteLine("{0}kcal, {1}g sugars", totalenergy, totalsugar );
        }
    }
}
