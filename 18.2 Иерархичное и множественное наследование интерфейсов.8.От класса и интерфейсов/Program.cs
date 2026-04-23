namespace _18._2_Иерархичное_и_множественное_наследование_интерфейсов._8.От_класса_и_интерфейсов
{
    public interface IStudent
    {
        int Year { get; set; }
        void DoHomework();
    }

    public interface IWorker
    {
        // Зарплата
        int Salary { get; set; }
        void Work();
    }

    public class Person
    {
        string Name { get; set; }
        int Age { get; set; }
    }

    public class Student: Person, IStudent, IWorker
    {
        public int Year { get; set; }
        public int Salary { get; set; }
        public void Work()
        { }
        public void DoHomework()
        { }
    }


    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hello, World!");
        }
    }
}
