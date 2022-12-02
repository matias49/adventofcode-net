using System.IO;

namespace AdventOfCode._2021._02;

internal class Part2
{
    private readonly string _file = @"2021/02/input.txt";

    public string Solve()
    {
        var lines = File.ReadAllLines(Path.Combine(Directory.GetCurrentDirectory(), _file));
        var x = 0;
        var y = 0;
        var aim = 0;
        foreach (var lineRead in lines)
        {
            var line = lineRead.Split(" ");
            switch (line[0])
            {
                case "forward":
                    x += int.Parse(line[1]);
                    y += aim * int.Parse(line[1]);
                    break;
                case "down":
                    aim += int.Parse(line[1]);
                    break;
                case "up":
                    aim -= int.Parse(line[1]);
                    break;
            }
        }


        return (x * y).ToString();
    }
}