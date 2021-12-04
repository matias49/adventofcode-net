using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AdventOfCode._2021._01
{
    internal class Part2
    {
        readonly string file = @"2021/01/input.txt";
        public string Solve()
        {
            string[] lines = File.ReadAllLines(Path.Combine(Directory.GetCurrentDirectory(), file));
            int count = 0;
            for (int i = 3; i < lines.Length; i++)
            {
                int v1 = int.Parse(lines[i - 3]) + int.Parse(lines[i - 2]) + int.Parse(lines[i - 1]);
                int v2 = int.Parse(lines[i - 2]) + int.Parse(lines[i - 1]) + int.Parse(lines[i]);
                if (v2 > v1)
                {
                    count++;
                }
            }
            
            return count.ToString();
        }
    }
}
