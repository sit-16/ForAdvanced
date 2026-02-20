namespace _6._2_Понятие_класса._10.Создание_класса_с_полями
{
    public class School
    {
        public string Name = "Неизвестно";
        public int Number = -1;
    }

    public class Student
    {
        public string FirstName = "Неизвестное имя";
        public string LastName = "Неизвестная фамилия";
        public int Age = -1;
        public double Rating = 0.1;
        public void PrintSmallInfo()
        {
            Console.WriteLine($"{LastName} {FirstName[0]}.");
        }
    }

    internal class Program
    {     
        static void Main(string[] args)
        {
            var test = new School();
            var stud = new Student();
            stud.FirstName = "Иосиф";
            stud.LastName = "Дзеранов";
            stud.PrintSmallInfo();
        }
    }
}
