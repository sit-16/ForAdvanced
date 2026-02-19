namespace _5._3_Вызов_функций._08.Слитно
{
    internal class Program
    {
        public static void Main()
        {
            string input = Console.ReadLine();

            string result = RemoveSpaces(input);

            Console.WriteLine(result);
        }

        static string RemoveSpaces(string text)
        {
            string result = "";

            for (int i = 0; i < text.Length; i++)
            {
                if (text[i] != ' ')
                {
                    result += text[i];
                }
            }

            return result;
        }
    }
}
