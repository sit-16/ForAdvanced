namespace _5._3_Вызов_функций._06.Поиск_символа
{
    internal class Program
    {
        public static void Main()
        {
            string firstSentence = Console.ReadLine();
            string secondSentence = Console.ReadLine();
            Console.Write(CountLetterC(firstSentence) + CountLetterC(secondSentence));
        }

        static int CountLetterC(string sentence)
        {
            int count = 0;

            for (int i = 0; i < sentence.Length; i++)
            {
                if (sentence[i] == 'с')
                {
                    count++;
                }
            }
            return count;
        }
    }
}
