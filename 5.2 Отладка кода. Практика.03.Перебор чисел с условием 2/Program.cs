namespace _5._2_Отладка_кода._Практика._03.Перебор_чисел_с_условием_2
{
    class Program
    {
        static void Main()
        {
            int a = 0;
            for (int i = 1; i <= 1000; i++)
            {
                if (i % 2 != 0)
                {
                    a = a + i;
                }
            }

            Console.WriteLine(a);
        }
    }
}