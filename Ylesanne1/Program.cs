using System;
using System.IO;

namespace Ylesanne1
{
    class Program
    {
        static void Main(string[] args)
        {
            string newPath = @"C:\Users\opilane\Samples";
            Console.WriteLine("Sisesta kausta nimi:");
            string kaust = Console.ReadLine();

            string newDirectory = $@"{newPath}\{kaust}";
            bool directoryExists = Directory.Exists(newDirectory);
            if (directoryExists)
            {
                Console.WriteLine($"{kaust} already exists in Samples");
            }
            else
            {
                Directory.CreateDirectory(newDirectory);
                Console.WriteLine($"Directory {kaust} has been created");
            }
            Console.ReadLine();
        }
    }
}
