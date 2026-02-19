namespace _5._2_Отладка_кода._Практика._08.Кол_во_и_пр_ие_неотр_х_чисел
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int count = 0;
            int p = 1;
            for (int i = 0; i < 10; i++)
            {
                int x = Convert.ToInt32(Console.ReadLine());
                if (x >= 0)
                {
                    p = p * x;
                    count = count + 1;
                }
            }
            if (count > 0)
            {
                Console.WriteLine(count);
                Console.WriteLine(p);
            }
            else
            {
                Console.WriteLine("NO");
            }
        }
    }
}
