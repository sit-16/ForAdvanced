namespace _7._2_Параметризованные_конструкторы._05.Point
{
    public class Point
    {
        public int X;
        public int Y;
        public Point(int x, int y)
        {
            this.X = x;
            this.Y = y;
        }
        public double CalculateDistance(Point point)
        {
            double distance = Math.Sqrt(Math.Pow(this.X - point.X,2) + Math.Pow(this.Y - point.Y, 2));
            return distance;
        }

        public string Print() 
        {
            return ($"({this.X},{this.Y})");
        }
    }

    internal class Program
    {
        static void Main(string[] args)
        {
            Point firstPoint = new Point(1, 2);
            Console.WriteLine(firstPoint.Print());

            Point secondPoint = new Point(4, 6);
            Console.WriteLine(secondPoint.Print());

            Console.WriteLine(firstPoint.CalculateDistance(secondPoint));
            Console.WriteLine(secondPoint.CalculateDistance(firstPoint));
        }
    }
}
