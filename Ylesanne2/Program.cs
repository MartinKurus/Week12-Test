using System;
using System.IO;

namespace Ylesanne2
{
    class Program
    {
        static void Main(string[] args)
        {
            String newPath = @"C:\Users\opilane\Samples\logitpe";
            string car1 = $@"{newPath}\toyota.txt";
            string car2 = $@"{newPath}\bmw.txt";
            string car3 = $@"{newPath}\tesla.txt";

            bool directoryExists = Directory.Exists(newPath);
            bool car1Exists = File.Exists(car1);
            bool car2Exists = File.Exists(car2);
            bool car3Exists = File.Exists(car3);

            if (directoryExists && car1Exists && car2Exists && car3Exists)
            {
                Console.WriteLine($"{car1} on juba olemas.");
                Console.WriteLine($"{car2} on juba olemas.");
                Console.WriteLine($"{car3} on juba olemas.");
            }
            else
            {
                File.Create(car1);
                File.Create(car2);
                File.Create(car3);
                Console.WriteLine($"Txt failid on loodud.");
            }
            Console.ReadLine();
        }
    }
}
