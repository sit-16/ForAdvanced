namespace _5._2_Отладка_кода._Практика._04.Факториал
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int n = Convert.ToInt32(Console.ReadLine());
            int a = 1;
            for (int i = 1; i <= n; i++)
            {
                a = a * i;
            }

            Console.WriteLine(a);
        }
    }
}
