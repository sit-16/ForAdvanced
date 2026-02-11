namespace Strings
{
    internal class Program //4.1.9.Strings
    {
        static void Main(string[] args)
        {
            int count_plus = 0;
            int count_asterisk = 0;
            string input = Console.ReadLine();
            foreach (var ch in input)
            { 
                if (ch == '+') count_plus++;
                else if (ch == '*') count_asterisk++;
            }
            Console.WriteLine($"Символ + встречается {count_plus} раз");
            Console.WriteLine($"Символ * встречается {count_asterisk} раз");
        }
    }
}
