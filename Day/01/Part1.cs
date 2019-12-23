using System;
using System.IO;
namespace Day1
{

    internal class Part1 {
        string input = @"Day/01/input.txt";
        public string Solve() {
            string[] lines = File.ReadAllLines(Path.Combine(Directory.GetCurrentDirectory(), input));
            double sum = 0;

            foreach (string line in lines)
            {
                double mass = Double.Parse(line);
                mass = mass / 3;
                mass = Math.Floor(mass);
                mass = mass - 2;
                sum += mass;

            }   
            return sum.ToString();
        }
    }
}