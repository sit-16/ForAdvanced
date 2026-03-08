namespace _10._3_Конструкторы_при_наследовании._04.Triangles
{
    public class Triangle
    {
        public double A { get; set; }
        public double B { get; set; }

        public double C { get; set; }
        public Triangle(double a, double b, double c)
        {
            A = a;
            B = b;
            C = c;
        }
        public double Perimeter()
        {
            return A + B + C;
        }
    }

    public class EquilateralTriangle : Triangle
    {
        public EquilateralTriangle(double a) : base(a, a, a)
        {
        }
    }

    internal class Program
    {
        static void Main(string[] args)
        {
            Triangle triangle = new Triangle(3, 4, 5);
            Console.WriteLine(triangle.Perimeter());

            EquilateralTriangle triangle2 = new EquilateralTriangle(3);
            Console.WriteLine(triangle2.Perimeter());
        }
    }
}
