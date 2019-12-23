using System;
using System.IO;
namespace Day1
{

    internal class Part2
    {
        string input = @"Day/01/input.txt";
        public string Solve()
        {
            string[] lines = File.ReadAllLines(Path.Combine(Directory.GetCurrentDirectory(), input));
            double sum = 0;

            foreach (string line in lines)
            {
                bool done = false;
                double mass = Double.Parse(line);
                while (!done)
                {
                    mass = mass / 3;
                    mass = Math.Floor(mass);
                    mass = mass - 2;
                    if (mass <= 0)
                    {
                        done = true;
                    }
                    else
                    {
                        sum += mass;
                    }
                }
            }
            return sum.ToString();
        }
    }
}