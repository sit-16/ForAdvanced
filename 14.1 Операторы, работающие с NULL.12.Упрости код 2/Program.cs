namespace _14._1_Операторы__работающие_с_NULL._12.Упрости_код_2
{
    public class Company
    {
        public string Name { get; set; }

        public Company(string name)
        {
            Name = name;
        }
    }


    internal class Program
    {
        static void Main(string[] args)
        {
            Print(new Company("МММ"));
            Print(new Company(null));
        }
        
        static void Print(Company company)
        {
            Console.WriteLine(company?.Name?? "Неизвестное имя");
            //if (company == null || company.Name == null)
            //{
            //    Console.WriteLine("Неизвестное имя");
            //}
            //else
            //{
            //    Console.WriteLine(company.Name);
            //}
        }
    }
}
