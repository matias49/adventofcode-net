using System;
using System.IO;

namespace AdventOfCode.Day._01;

internal class Part1
{
    private readonly string _input = @"Day/01/input.txt";

    public string Solve()
    {
        var lines = File.ReadAllLines(Path.Combine(Directory.GetCurrentDirectory(), _input));
        double sum = 0;

        foreach (var line in lines)
        {
            var mass = double.Parse(line);
            mass /= 3;
            mass = Math.Floor(mass);
            mass -= 2;
            sum += mass;
        }

        return sum.ToString();
    }
}