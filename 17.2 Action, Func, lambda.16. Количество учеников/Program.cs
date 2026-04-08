namespace _17._2_Action__Func__lambda._16._Количество_учеников
{
    public class Student
    {
        public readonly string FIO;
        public readonly int Grade;
        public readonly double Performance;

        public Student(string fio, int grade, double performance)
        {
            FIO = fio;
            Grade = grade;
            Performance = performance;
        }
    }

    public class School
    {
        public List<Student> Students;
        public int Count(Func<Student, bool> predicate)
        {
            int count = 0;
            foreach (var student in this.Students)
            {
                if (predicate(student)) count++;
            }
            
            return count;
        }
    }


    internal class Program
    {
        public static void Main()
        {
            School school = new School();
            school.Students = new List<Student>()
            {
                new Student("Багаев Аслан", 10, 4.3),
                new Student("Абаев Георгий", 8, 5),
                new Student("Дзуцев Михаил", 2, 3.8),
                new Student("Елоев Сармат", 11, 4.6)
            };
            Console.WriteLine(school.Count(x => x.Grade > 2));
            Console.WriteLine(school.Count(x => x.FIO.Contains("Багаев")));
        }
    }
}
