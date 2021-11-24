using System;
using System.Collections.Generic;
using System.IO;

namespace Ylesanne3
{
    class Program
    {
        static void Main(string[] args)
        {
            List<string> tesla = new List<string>();
            List<string> bmw = new List<string>();
            List<string> toyota = new List<string>();

            string filePath = @"C:\Users\opilane\samples\logitpe\cars.txt";
            string[] logitpe = File.ReadAllLines(filePath);

            string teslaPath = @"C:\Users\opilane\samples\logitpe\tesla.txt";

            string bmwPath = @"C:\Users\opilane\samples\logitpe\bmw.txt";

            string toyotaPath = @"C:\Users\opilane\samples\logitpe\toyota.txt";

            foreach (string element in logitpe)
            {
                if (element.Contains("Tesla"))
                {
                    tesla.Add(element);
                }
                if (element.Contains("BMW"))
                {
                    bmw.Add(element);
                }
                if (element.Contains("Toyota"))
                {
                    toyota.Add(element);
                }
            }


            File.WriteAllLines(teslaPath, tesla);
            File.WriteAllLines(bmwPath, bmw);
            File.WriteAllLines(toyotaPath, toyota);
        }
    }
}
