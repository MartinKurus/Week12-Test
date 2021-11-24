using System;
using System.IO;

namespace Ylesanne5
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Random facts so interesting you'll say omg!");
            Console.WriteLine("Mitut fakti sa soovid?");

            int userNumber = Convert.ToInt32(Console.ReadLine());
            GetJokes(userNumber);

        }
        private static void GetJokes(int Factnumber)
        {
            string filepath = @"C:\Users\opilane\Samples\logitpe\funfacts.txt";
            string[] funfacts = File.ReadAllLines(filepath);

            if (Factnumber > funfacts.Length)
            {
                Factnumber = funfacts.Length;
            }
            for (int i = 0; i < Factnumber; i++)
            {
                Console.WriteLine(funfacts[i]);
            }
        }
    }
}
