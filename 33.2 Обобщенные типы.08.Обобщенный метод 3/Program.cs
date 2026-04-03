namespace _33._2_Обобщенные_типы._08.Обобщенный_метод_3
{
    internal class Program
    {
        static void Main()
        {
            List<int> numbers = new List<int> { 1, 2, 3, 4, 5 };
            Reverse(numbers);
            Console.WriteLine(string.Join(", ", numbers));

            List<string> names = new List<string> { "Josef", "Vadim", "Ivan" };
            Reverse(names);
            Console.WriteLine(string.Join(", ", names));
        }

        static void Reverse<T>(List<T> array)
        {
            array.Reverse();
        }
    }
}
