namespace _16._1_Делегаты._06.Использование_делегата_и_методата
{
    internal class Program
    {
        static void Main(string[] args)
        {
            List<int> df = new List<int> { 23, 34, 56, 67 };

            Console.WriteLine("Hello, World!");
        }

        private static List<int> GetAdults()
        {
            return new List<int> { 1, 1 };
        }
    }
}
