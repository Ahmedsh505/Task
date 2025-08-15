using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Task06
{
    public struct Point
    {
        public int X { get; set; }
        public int Y { get; set; }

        public Point(int x)
        {
            X = x;
            Y = 0;
        }

        public Point(int x, int y)
        {
            X = x;
            Y = y;
        }

        public void DisplayPoint()
        {
            Console.WriteLine($"Point: ({X}, {Y})");
        }

        public override string ToString()
        {
            return $"Point Coordinates X: {X}, Y: {Y}";
        }
    }
}