using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AdventOfCode._2021._01
{
    internal class Part1
    {
        readonly string file = @"2021/01/input.txt";
        public string Solve()
        {
            string[] lines = File.ReadAllLines(Path.Combine(Directory.GetCurrentDirectory(), file));
            int count = 0;
            for (int i = 1; i < lines.Length; i++)
            {
                if (int.Parse(lines[i]) > int.Parse(lines[i - 1]))
                {
                    count++;
                }
            }

            return count.ToString();
        }
    }
}
