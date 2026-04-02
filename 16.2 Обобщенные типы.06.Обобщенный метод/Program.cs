namespace _16._2_Обобщенные_типы._06.Обобщенный_метод
{
    internal class Program
    {
        static void Main()
        {
            string[] names = { "Josef", "Vadim", "Ivan" };
            PrintArray(names);
        }

        static void PrintArray<T>(T[] items)
        {
            foreach (var item in items)
            {
                Console.WriteLine(item);
            }
        }
    }
}
