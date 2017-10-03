using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Problem_5.Character_Stats
{
    class Program
    {
        static void Main(string[] args)
        {
            var name = Console.ReadLine();
            var currentHealth = int.Parse(Console.ReadLine());
            var mahHealth = int.Parse(Console.ReadLine());
            var currentEnergy = int.Parse(Console.ReadLine());
            var mahEnergy = int.Parse(Console.ReadLine());

            Console.WriteLine("Name: {0}", name);

            Console.WriteLine("Health: " + '|' + new string('|', currentHealth) +
                               new string('.', mahHealth - currentHealth) + '|');

            Console.WriteLine("Energy: " + '|' + new string('|', currentEnergy) +
                              new string('.', mahEnergy - currentEnergy) + '|');
        }
    }
}
