using System.Diagnostics;

namespace _17._2_Action__Func__lambda._06.Меняющий_вывод
{
    internal class Program
    {
        static void Main()
        {
            Print(new List<int> { 1, 2, 3, 4, 5 }, Twice);
        }

        static void Print(List<int> items, Action<int> action)
        {
            foreach (var item in items)
            {
                action(item);
            }
        }

        private static void Twice(int n)
        {
            Console.Write( " {0}", n *= 2);
        }
    }
}
