
namespace _7._2_Параметризованные_конструкторы._07.Четные_и_нечетные
{
    internal class Program
    {

        public class Selector
        {
            int[] ArrayOdd;
            int[] ArrayEven;

            public Selector(int[] arr)
            {
                int oddCnt = 0;
                int evenCnt = 0;
                foreach (var n in arr)
                {
                    if (n % 2 != 0) oddCnt++;
                    else evenCnt++;
                }
                ArrayOdd = new int[oddCnt];
                ArrayEven = new int[evenCnt];
                oddCnt = 0;
                evenCnt = 0;
                foreach (var n in arr)
                {
                    if (n % 2 != 0) ArrayOdd[oddCnt++] = n;
                    else ArrayEven[evenCnt++] = n;
                }
            }
            public void PrintOdds()
            {
                Console.Write(string.Join(" ", ArrayOdd));
            }
            public void PrintEvens()
            {
                Console.Write(string.Join(" ", ArrayEven));
            }
        }


        static void Main(string[] args)
        {
            int[] numbers = new int[] { 11, 12, 13, 14, 15, 16, 22, 44, 66 };
            Selector selector = new Selector(numbers);

            selector.PrintOdds();
            Console.WriteLine();
            selector.PrintEvens();
        }
    }
}
