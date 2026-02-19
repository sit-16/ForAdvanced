namespace _5._2_Отладка_кода._Практика._09.Cумма_отр_ых_чисел_и_макс_ое
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int mx = 0;
            int s = 0;
            for (int i = 0; i < 10; i++)
            {
                int x = Convert.ToInt32(Console.ReadLine());
                if (x < 0)
                {
                    s += x;
                    if (x > mx || mx == 0)
                    {
                        mx = x;
                    }
                }
            }
            if (mx == 0) Console.WriteLine("NO");
            else
            {
                Console.WriteLine(s);
                Console.WriteLine(mx);
            }
        }
    }
}
