namespace sit16.ProtectStudentAge3
{
    public class Student
    {
        private string name;
        private int age;

        public string Name
        {
            // геттер
            get
            {
                return name;
            }
            // Сеттер
            set
            {
                if (value.Length <= 1)
                {
                    throw new Exception("Имя должно состоять как минимум из 2 букв.");
                }

                foreach (var c in value)
                {
                    if (!char.IsLetter(c))
                    {
                        throw new Exception("Имя должно состоять только букв.");
                    }
                }

                name = value;
            }
        }
        public int Age
        {
            get { return age; }
            set
            {
                if (value < 16) throw new Exception(@"//ошибка, так как меньше предыдущего возраста");
                if (value < age) throw new Exception(@"//ошибка, так как некорректный возраст");
                age = value;
            }
        }

        public Student(string name, int age)
        {
            Name = name;
            Age = age;
        }
    }
    internal class Program
    {
        static void Main(string[] args)
        {
            Student student1 = new Student("Иосиф", 16);
            Console.WriteLine(student1.Age);

            student1.Age = 25;
            Console.WriteLine(student1.Age);

            student1.Age = 20;
            student1.Age = 15;
        }
    }
}
