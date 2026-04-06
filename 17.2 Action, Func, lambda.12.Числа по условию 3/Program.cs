namespace _17._2_Action__Func__lambda._12.Числа_по_условию_3
{
    class Program
    {
        static void Main()
        {
            Func<int, bool> predicate = n => n * 2 % 10 == 6;

            Print(new List<int> { 1, 2, 3, 4, 5, 7, 13, 27 }, predicate);
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
    }
}
