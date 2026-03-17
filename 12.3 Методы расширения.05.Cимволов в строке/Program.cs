namespace _12._3_Методы_расширения._05.Cимволов_в_строке
{
    public static class StringHelpers
    {
        public static int CharCount(this string s, char c)
        {
            int counter = 0;
            foreach (var ch in s)
            {
                if (ch == c) counter++;
            }
            return counter;
        }
    }

    internal class Program
    {
        static void Main(string[] args)
        {
            string s = "Hello world";
            char c = 'l';
            int i = s.CharCount(c);
            Console.WriteLine(i);
        }
    }
}
