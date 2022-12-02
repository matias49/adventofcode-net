using System.IO;

namespace AdventOfCode._2021._01;

internal class Part1
{
    private readonly string _file = @"2021/01/input.txt";

    public string Solve()
    {
        var lines = File.ReadAllLines(Path.Combine(Directory.GetCurrentDirectory(), _file));
        var count = 0;
        for (var i = 1; i < lines.Length; i++)
            if (int.Parse(lines[i]) > int.Parse(lines[i - 1]))
                count++;

        return count.ToString();
    }
}