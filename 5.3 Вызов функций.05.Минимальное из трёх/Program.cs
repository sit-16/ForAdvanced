namespace _5._3_Вызов_функций._05.Минимальное_из_трёх
{
    internal class Program
    {
        static void Main()
        {
            double a = ReadNumber();
            double b = ReadNumber();
            double c = ReadNumber();

            double min = MinOfThree(a, b, c);

            Console.WriteLine(min);
        }

        static double ReadNumber()
        {
            return double.Parse(Console.ReadLine());
        }

        static double Min(double a, double b)
        {
            return a < b ? a : b;
        }

        static double MinOfThree(double a, double b, double c)
        {
            double minAB = Min(a, b);
            return Min(minAB, c);
        }
    }
}
