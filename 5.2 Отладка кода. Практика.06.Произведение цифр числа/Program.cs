namespace _5._2_Отладка_кода._Практика._06.Произведение_цифр_числа
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int n = Convert.ToInt32(Console.ReadLine());
            int product = 1;
            while (n > 0)
            {
                int digit = n % 10;
                product = product * digit;
                n = n / 10;
            }

            Console.WriteLine(product);
        }
    }
}
