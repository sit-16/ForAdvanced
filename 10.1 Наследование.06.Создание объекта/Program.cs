namespace _10._1_Наследование._06.Создание_объекта
{
    internal class Program
    {
        public class User
        {
            public string Name { get; set; }
            public int Age { get; set; }
        }

        /// <summary>
        /// Водитель
        /// </summary>
        public class Driver : User
        {
            /// <summary>
            /// Категория вождения (A, B, C)
            /// </summary>
            public char Category { get; set; }
        }


        static void Main(string[] args)
        {
            var d1 = new Driver()
            {
                Name = "Василий",
                Age = 35,
                Category = 'B'
            };
            var d2 = new Driver()
            {
                Name = "Виктор",
                Age = 23,
                Category = 'C'
            };
            Console.WriteLine(d1.Age + d2.Age);
        }
    }
}
