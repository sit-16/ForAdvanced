namespace _16._2_Обобщенные_типы._07.Обобщенный_метод_2
{
    internal class Program
    {
        static void Main()
        {
            int[] numbers = { 1, 2, 3, 2, 4, 2 };
            int occurrences = FindOccurrencesCount(numbers, 2);
            Console.WriteLine(occurrences);

            string[] names = { "Josef", "Vadim", "Josef", "Ivan" };
            int occurrences2 = FindOccurrencesCount(names, "Josef");
            Console.WriteLine(occurrences2);
        }

        static int FindOccurrencesCount<T>(T[] array, T item)
        {
            int counter = 0;
            foreach (var itm in array)
            {
                if (itm.Equals(item)) counter++;
            }
            return counter;
        }
    }
}
