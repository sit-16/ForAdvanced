namespace _17._2_Action__Func__lambda._14.Незачеты_и_автоматы
{
    public class Student
    {
        public readonly string Name;
        public readonly int Mark;

        public Student(string name, int mark)
        {
            Name = name;
            Mark = mark;
        }
    }

    class Program
    {
        static void Main(string[] args)
        {
            List<Student> group = new List<Student> {
            new Student("Паша", 45),
            new Student("Гриша", 58),
            new Student("Сергей", 63),
            new Student("Олег", 87)
            };

            // здесь вызывайте метод Show
            /*Console.WriteLine("Автоматы:");
            Show(group, x => x.Mark > 85);
            Console.WriteLine("Незачет:");
            Show(group, x => x.Mark < 51);*/
            Console.WriteLine("Надо сдавать зачет:");
            Show(group, x => x.Mark > 50 && x.Mark < 86);
        }
        // здесь напишите метод Show
        static void Show(List<Student> sturents, Func<Student, bool> predicate)
        {
            foreach (var student in sturents)
            {
                if (predicate(student))
                {
                    Console.WriteLine($"{student.Name} - {student.Mark}");
                }
            }
        }
    }
}
