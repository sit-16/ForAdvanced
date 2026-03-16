namespace _12._1_Статические_члены._Поля_и_методы._15.Совершеннолетие
{
    public class Person
    { 
        public int Age {  get; set; }
        public static int LegalAge { get; set; } = 18;
        public Person(int age)
        {
            Age = age;
        }
        public static void IncreaseLegalAge(int year)
        {
            LegalAge += year;
        }

        public bool IsAdult()
        {
            return Age >= LegalAge;
        }
    }
    internal class Program
    {
        static void Main(string[] args)
        {
            Person pers = new Person(18);
            if (pers.IsAdult())
                Console.WriteLine("YES");
            else
                Console.WriteLine("NO");

            Person.IncreaseLegalAge(1);
            if (pers.IsAdult())
                Console.WriteLine("YES");
            else
                Console.WriteLine("NO");
        }
    }
}
