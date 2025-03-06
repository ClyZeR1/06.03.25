using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1
{
    class Program
    {
        static void Main()
        {
            Point[] points = new Point[5];
            for (int i = 0; i < points.Length; i++)
            {
                Console.WriteLine($"Введите координаты {i + 1}-й точки:");
                double x = Convert.ToDouble(Console.ReadLine());
                double y = Convert.ToDouble(Console.ReadLine());
                points[i] = new Point(x, y);
            }

            int minIndex = 0;
            double minDistance = points[0].Length();
            for (int i = 1; i < points.Length; i++)
            {
                double distance = points[i].Length();
                if (distance < minDistance)
                {
                    minDistance = distance;
                    minIndex = i;
                }
            }
            Console.WriteLine($"Ближайшая точка: ({points[minIndex].X}, {points[minIndex].Y})");

            // Вывод точек по четвертям
            Console.WriteLine("Точки в 1-й четверти:");
            foreach (var point in points)
                if (point.X > 0 && point.Y > 0) point.Print();

            Console.WriteLine("Точки во 2-й четверти:");
            foreach (var point in points)
                if (point.X < 0 && point.Y > 0) point.Print();

            Console.WriteLine("Точки в 3-й четверти:");
            foreach (var point in points)
                if (point.X < 0 && point.Y < 0) point.Print();

            Console.WriteLine("Точки в 4-й четверти:");
            foreach (var point in points)
                if (point.X > 0 && point.Y < 0) point.Print();

            Console.ReadKey();
        }
    }
}
