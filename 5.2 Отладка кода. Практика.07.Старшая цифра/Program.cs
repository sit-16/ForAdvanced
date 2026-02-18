namespace _5._2_Отладка_кода._Практика._07.Старшая_цифра
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int n = Convert.ToInt32(Console.ReadLine());
            while (n > 10)
            {
                n = n / 10;
            }
            Console.WriteLine(n);
        }
    }
}
