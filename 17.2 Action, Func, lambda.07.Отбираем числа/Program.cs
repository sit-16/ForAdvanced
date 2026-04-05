namespace _17._2_Action__Func__lambda._07.Отбираем_числа
{
    class Program
    {
        static void Main()
        {
            Print(new List<int> { 1, 2, 3, 4, 5 }, IsEven);
        }

        static void Print(List<int> items, Func<int, bool> predicate)
        {
            foreach (var item in items)
            {
                if (predicate(item))
                {
                    Console.Write(item + " ");
                }
            }
        }

        private static bool IsEven(int n)
        {
            return n % 2 == 0;
        }

    }
}
