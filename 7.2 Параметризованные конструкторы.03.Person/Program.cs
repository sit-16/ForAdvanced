namespace _7._2_Параметризованные_конструкторы._03.Person
{
    internal class Program
    {
        public class Person
        {
            public string FirstName;
            public string LastName;
            public int Age;

            public Person(string sFirstName, string sLastName, int iAge)
            {
                FirstName = sFirstName;
                LastName = sLastName;
                Age = iAge;
            }

            public string GetFullName()
                { return $"{LastName} {FirstName}"; }
            public bool IsAdult()
                { return Age>=18; }
        }


        static void Main(string[] args)
        {
            Person person = new Person("Иосиф", "Дзеранов", 26);
            Console.WriteLine(person.GetFullName());
            Console.WriteLine(person.IsAdult());
        }
    }
}
