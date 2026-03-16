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
            Counter++;
            X = x; Y = y;
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
        }
    }
}
