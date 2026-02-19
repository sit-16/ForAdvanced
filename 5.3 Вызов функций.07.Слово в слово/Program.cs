namespace _5._3_Вызов_функций._07.Слово_в_слово
{
    internal class Program
    {
        static void Main()
        {
            string sentence = Console.ReadLine();
            string word = Console.ReadLine();

            bool result = ContainsFullWord(sentence, word);
            Console.WriteLine(result);
        }

        static bool ContainsFullWord(string sentence, string word)
        {
            string[] words = sentence.Split(" ");

            foreach (string w in words)
            {
                if (w == word)
                {
                    return true;
                }
            }

            return false;
        }
    }
}
