namespace _10._1_Наследование._05.Работник
{
    public class User
    {
        public string Name { get; set; }
        public int Age { get; set; }
    }

    public class Worker : User
    {
        public decimal Salary { get; set; }
    }


    internal class Program
    {
        static void Main(string[] args)
        {
            var w1 = new Worker()
            {
                Name = "Иван",
                Age = 25,
                Salary = 1000
            };
            var w2 = new Worker()
            {
                Name = "Вася",
                Age = 26,
                Salary = 2000
            };
            Console.WriteLine(w1.Salary + w2.Salary);
        }
    }
}