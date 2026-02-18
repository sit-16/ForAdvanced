namespace _5._2_Отладка_кода._Практика._05.Cумма_чётных_чисел
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int s = 0;
            for (int i = 0; i < 7; i++)
            {
                int n = Convert.ToInt32(Console.ReadLine());
                if (n % 2 == 0)
                {
                    s = s + n;
                }
            }

            Console.WriteLine(s);
        }
    }
}
