namespace _9._5_Индексаторы._10.Словарь
{
    internal class Program
    {
        public class Word
        {
            /// <summary>
            /// Исходное слово
            /// </summary>
            public string Source { get; }

            /// <summary>
            /// Перевод исходного слова
            /// </summary>
            public string Target { get; set; }

            public Word(string source, string target)
            {
                Source = source;
                Target = target;
            }
        }


        public class Dictionary
        {
            private Word[] words;
            public Dictionary()
            {
                words = new Word[]
                {
                    new Word("red", "красный"),
                    new Word("blue", "синий"),
                    new Word("green", "зеленый")
                };
            }
            public string this[string sourceWord]
            {
                get
                {
                    foreach (var word in words)
                    {
                        if (sourceWord == word.Source)
                            return word.Target; 
                    }
                    return null;
                }
                set 
                {
                    foreach (var word in words)
                    {
                        if (sourceWord == word.Source)
                            word.Target = value;
                    }
                }
            }
        }
        static void Main(string[] args)
        {
            Dictionary dict = new Dictionary();
            Console.WriteLine(dict["blue"]);
            dict["blue"] = "голубой";
            Console.WriteLine(dict["blue"]);
        }
    }
}
