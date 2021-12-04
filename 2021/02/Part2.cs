using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AdventOfCode._2021._02
{
    internal class Part2
    {
        readonly string file = @"2021/02/input.txt";
        public string Solve()
        {
            string[] lines = File.ReadAllLines(Path.Combine(Directory.GetCurrentDirectory(), file));
            int x = 0;
            int y = 0;
            int aim = 0;
            foreach (string lineRead in lines)
            {
                string[] line = lineRead.Split(" ");
                switch (line[0])
                {
                    case "forward":
                        x += int.Parse(line[1]);
                        y += (aim * int.Parse(line[1]));
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
}
