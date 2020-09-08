using System;

namespace HealthyHearts
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Write("What is your age? ");
            int age = Convert.ToInt32(Console.ReadLine());
            int max = 220 - age;
            int zoneMin = max / 2;
            int zoneMax = (max * 85) / 100;
            Console.WriteLine($"Your maximum heart rate should be {max} beats per minute.");
            Console.WriteLine($"Your target HR Zone is {zoneMin} - {zoneMax} beats per minute.");

        }
    }
}
