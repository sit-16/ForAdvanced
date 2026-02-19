namespace _5._3_Вызов_функций._04.Четное_нечетное
{
    internal class Program
    {
        static void Main()
        {
            int a = ReadNumber();
            int b = ReadNumber();

            int sum = Sum(a, b);

            Console.WriteLine("Сума: " + sum);

            if (IsEven(sum))
            {
                Console.WriteLine("Сумма четная ");
            }
            else
            {
                Console.WriteLine("Сумма нечетная ");
            }
        }

        static int ReadNumber()
        {
            return int.Parse(Console.ReadLine());
        }

        static int Sum(int a, int b)
        {
            return a + b;
        }

        static bool IsEven(int x)
        {
            return x % 2 == 0;
        }
    }
}
