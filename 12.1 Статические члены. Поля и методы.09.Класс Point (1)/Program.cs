using System.Diagnostics.Metrics;

namespace _12._1_Статические_члены._Поля_и_методы._09.Класс_Point__1_
{
    public class Point 
    {
        public static int Counter { get; set; }
        public int X { get; }
        public int Y { get; }
        public Point(int x, int y)
        {
            Counter ++;
            X = x; Y = y;
        }

        public static double LengthPoints(Point p1, Point p2)
        {
            return Math.Sqrt(Math.Pow((p1.X - p2.X), 2) + Math.Pow((p1.Y - p2.Y), 2));
        }
    }

    internal class Program
    {
        static void Main(string[] args)
        {
            Point point1 = new Point(1, 1);
            Console.WriteLine(Point.Counter);

            Point point2 = new Point(2, 3);
            Console.WriteLine(Point.Counter);
            Point point3 = new Point(1, 5);
            Point point4 = new Point(5, 5);

            Console.WriteLine(Point.LengthPoints(point3, point4));
        }
    }
}
