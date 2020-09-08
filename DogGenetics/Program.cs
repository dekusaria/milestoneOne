using System;

namespace DogGenetics
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Write("What is your dog's name? ");
            string dogName = Console.ReadLine();

            Console.WriteLine($"Well then, I have this highly reliable report on {dogName}'s prestigious background right here.");
            Console.WriteLine("");

            Console.WriteLine($"{dogName} is: ");
            Console.WriteLine("");

            Random randomizer = new Random();
            int breed1 = randomizer.Next(1, 51);
            int breed2 = randomizer.Next(101 - breed1);
            int breed3 = randomizer.Next(101 - breed1 - breed2);
            int breed4 = randomizer.Next(101 - breed1 - breed2 - breed3);
            int breed5 = 100 - breed1 - breed2 - breed3 - breed4;

            Console.WriteLine($"{breed1}% Beagle");
            Console.WriteLine($"{breed2}% Bulldog");
            Console.WriteLine($"{breed3}% Standard Poodle");
            Console.WriteLine($"{breed4}% Husky");
            Console.WriteLine($"{breed5}% Dachshund");
            Console.WriteLine("\nWow, that's QUITE the dog!");
        }
    }
}
