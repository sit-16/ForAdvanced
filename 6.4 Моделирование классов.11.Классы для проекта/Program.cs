namespace _6._4_Моделирование_классов._11.Классы_для_проекта
{
    internal class Program
    {
        public enum WeekDayEnum
        {
            Monday,
            Tuesda,
            Wednesday,
            Thursday,
            Friday,
            Saturday,
            Sunday
        };
        public class Schedule
        {
            public List<WeekDay> WeekDays;
           
        }
        public class WeekDay
        {
            public WeekDayEnum Name;
            public List<Lesson> Lessons;
        }
        public class Lesson
        {
            public Course Cource;
            public Group StudentGroup;
            public int Time;
            public int Duration;
        }
        public class Course
        {
            public string Name;
            public Employee Teacher;
        }
        public class Employee
        {
            public string FullName;
            public string Position;
            public double Salary;
            public string Gender;
        }
        public class Group
        {
            public string Name;
            public List<Student> Students;
        }
        public class Student
        {
            public string FullName;
            public string Gender;
            public int BirthDate;
        }


        public class User
        {
            public string Name;
            public string PhoneNumber;
            public User()
            {
                Name = "Поликарп";
                PhoneNumber = "+7(000)000 00 00";
            }
        }


        static void Main(string[] args)
        {
            Console.WriteLine("Hello, World!");
        }
    }
}
