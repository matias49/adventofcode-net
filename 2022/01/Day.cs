using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;

namespace AdventOfCode._2022._01;

public class Day
{
    public static void Solve()
    {
        var day = new Day();
        Console.WriteLine(day.Part1());
        Console.WriteLine(day.Part2());
    }

    private List<List<int>> GetData(string filePath)
    {
        var data = new List<List<int>>();
        var lines = File.ReadAllLines(Path.Combine(Directory.GetCurrentDirectory(), filePath));
        var currentElf = new List<int>();
        foreach (var line in lines)
            if (line != "")
            {
                currentElf.Add(int.Parse(line));
            }
            else
            {
                data.Add(currentElf);
                currentElf = new List<int>();
            }

        return data;
    }

    private List<int> CalcSum(List<List<int>> data)
    {
        var elfSum = new List<int>();
        foreach (var elf in data) elfSum.Add(elf.Aggregate((i, i1) => i + i1));

        return elfSum;
    }

    public int Part1()
    {
        var data = GetData("2022/01/input.txt");
        var elfCalories = CalcSum(data);
        elfCalories = elfCalories.OrderByDescending(i => i).ToList();

        return elfCalories.ElementAt(0);
    }

    public int Part2()
    {
        var data = GetData("2022/01/input.txt");
        var elfCalories = CalcSum(data);
        elfCalories = elfCalories.OrderByDescending(i => i).ToList();

        return elfCalories.ElementAt(0) + elfCalories.ElementAt(1) + elfCalories.ElementAt(2);
    }
}