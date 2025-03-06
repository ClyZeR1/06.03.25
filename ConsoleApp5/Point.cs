using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp5
{
    class Point
    {
        private double x;
        private double y;
        private static int count = 0;

        public Point(double x, double y)
        {
            this.x = x;
            this.y = y;
            count++;
        }

        public void Print()
        {
            Console.WriteLine($"Точка ({x}, {y})");
        }

        public static int Count => count;
    }
}
