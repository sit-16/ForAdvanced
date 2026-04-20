namespace _18._1_Понятие_интерфейса._10.Реализация_студента_2
{
    interface IStudent
    { 
        string Name { get; set; }
        void ListeningLection();
        void DoHomework(string st);
        void PrepareForExam();

    }

    public class Student:IStudent
    {
        public string Name { get; set; }

        public Student(string name)
        { 
            this.Name = name;
        }
        public void ListeningLection()
        {
            Console.WriteLine("ListeningLection");
        }
        public void DoHomework(string st)
        {
            Console.WriteLine("DoHomework");
        }
        public void PrepareForExam()
        {
            Console.WriteLine("PrepareForExam");
        }
    }

    internal class Program
    {
        static void Main(string[] args)
        {
            IStudent student = new Student("Josef");
            student.ListeningLection();
            student.DoHomework("123");
            student.PrepareForExam();
        }
    }
}
