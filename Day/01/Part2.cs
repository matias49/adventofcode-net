using System;
using System.IO;

namespace AdventOfCode.Day._01;

internal class Part2
{
    private readonly string _input = @"Day/01/input.txt";

    public string Solve()
    {
        var lines = File.ReadAllLines(Path.Combine(Directory.GetCurrentDirectory(), _input));
        double sum = 0;

        foreach (var line in lines)
        {
            var done = false;
            var mass = double.Parse(line);
            while (!done)
            {
                mass = mass / 3;
                mass = Math.Floor(mass);
                mass = mass - 2;
                if (mass <= 0)
                    done = true;
                else
                    sum += mass;
            }
        }

        return sum.ToString();
    }
}