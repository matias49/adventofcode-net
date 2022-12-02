using System.IO;

namespace AdventOfCode._2021._02;

internal class Part1
{
    private readonly string _file = @"2021/02/input.txt";

    public string Solve()
    {
        var lines = File.ReadAllLines(Path.Combine(Directory.GetCurrentDirectory(), _file));
        var x = 0;
        var y = 0;
        foreach (var lineRead in lines)
        {
            var line = lineRead.Split(" ");
            switch (line[0])
            {
                case "forward":
                    x += int.Parse(line[1]);
                    break;
                case "down":
                    y += int.Parse(line[1]);
                    break;
                case "up":
                    y -= int.Parse(line[1]);
                    break;
            }
        }


        return (x * y).ToString();
    }
}