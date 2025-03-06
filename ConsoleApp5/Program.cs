using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp5
{
    class Program
    {
        static void Main(string[] args)
        {
            // 2-й способ
            Point[] points2 = new Point[]
            {
            new Point(3, 4),
            new Point(7, 4),
            new Point(7, 6),
            new Point(3, 6)
            };

            Console.WriteLine("\n 2-й способ: ");
            foreach (var point in points2)
            {
                point.Print();
            }

            // 3-й способ
            Point[] points3 = new Point[4];
            Console.WriteLine("\n 3-й способ: ");
            for (int i = 0; i < points3.Length; i++)
            {
                Console.WriteLine($"Введите координаты {i + 1}-й точки:");
                double x = Convert.ToDouble(Console.ReadLine());
                double y = Convert.ToDouble(Console.ReadLine());
                points3[i] = new Point(x, y);
            }

            foreach (var point in points3)
            {
                point.Print();
            }

            // 4-й способ
            List<Point> points4 = new List<Point>();
            int n = 4;

            Console.WriteLine("\n 4-й способ: ");
            for (int i = 0; i < n; i++)
            {
                Console.Write($"x {i + 1} точки - ");
                int x = Convert.ToInt32(Console.ReadLine());
                Console.Write($"y {i + 1} точки - ");
                int y = Convert.ToInt32(Console.ReadLine());
                points4.Add(new Point(x, y));
                Console.WriteLine();
            }

            foreach (var point in points4)
            {
                point.Print();
            }

            Console.WriteLine($"\n Количество созданных точек: {Point.Count}");

            Console.ReadKey();
        }
    }
}