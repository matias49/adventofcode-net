using System.IO;

namespace AdventOfCode._2021._01;

internal class Part2
{
    private readonly string _file = @"2021/01/input.txt";

    public string Solve()
    {
        var lines = File.ReadAllLines(Path.Combine(Directory.GetCurrentDirectory(), _file));
        var count = 0;
        for (var i = 3; i < lines.Length; i++)
        {
            var v1 = int.Parse(lines[i - 3]) + int.Parse(lines[i - 2]) + int.Parse(lines[i - 1]);
            var v2 = int.Parse(lines[i - 2]) + int.Parse(lines[i - 1]) + int.Parse(lines[i]);
            if (v2 > v1) count++;
        }

        return count.ToString();
    }
}