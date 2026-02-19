namespace _5._2_Отладка_кода._Практика._10.Макс_ая_цифра_числа_кратная_3
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int n = Convert.ToInt32(Console.ReadLine());
            int maxDigit = -1;
            while (n > 0)
            {
                int digit = n % 10;
                if (digit % 3 == 0)
                {
                    if (digit > maxDigit)
                    {
                        maxDigit = digit;
                    }
                }
                n = n / 10;
            }
            if (maxDigit == -1)
            {
                Console.WriteLine("NO");
            }
            else
            {
                Console.WriteLine(maxDigit);
            }
        }
    }
}
