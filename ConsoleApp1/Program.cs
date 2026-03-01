//namespace ConsoleApp1
//{
//    internal class Program
//    {
//        static void Main(string[] args)
//        {


//            string[] days4 = new string[] { "пн", "вт", "ср", "чт", "пт", "сб", "вс" };
//            string[] days5 = ["пн", "вт", "ср", "чт", "пт", "сб", "вс" ];
//            string[] days6 = { "пн", "вт", "ср", "чт", "пт", "сб", "вс" }; // почему так раобтает ?!
//            string[] days7;
//            days7 = { "пн", "вт", "ср", "чт", "пт", "сб", "вс" }; // не работает
//            days7 = [ "пн", "вт", "ср", "чт", "пт", "сб", "вс" ]; // работает

//            var days1 = new Dictionary<string, int>() // как эти скобки вписываются в логишу присвоения множеств ? Шиворот на выворот же присваивается
//            {
//                ["пн"] = 0,
//                ["вт"] = 0,
//                ["ср"] = 0,
//                ["чт"] = 0,
//                ["пт"] = 0,
//                ["сб"] = 0,
//                ["вс"] = 0
//            };
//            var days2 = new Dictionary<string, int>()
//            {
//                {"пн", 0},
//                {"вт", 0},
//                {"ср", 0},
//                {"чт", 0},
//                {"пт", 0},
//                {"сб", 0},
//                {"вс", 0}
//            };
//        }
//    }
//}


//public class User
//{
//    private User field;

//    public string Name { get; set; }
//    public void Method1(User user)
//    {
//        field = user;
//        field.Name = "NoName"; // Нет ошибки
//    }
//}

//internal class Program
//{
//    static void Main(string[] args)
//    {
//        var v = new User();
//        var v1 = new User();
//        v.Method1(v1);
//    }
//}
public class User
{
    public string Name { get; }
    public int Age { get; }
    public User(string name, int age)
    {
        Name = name;
        Age = age;
    }
}

public class Company
{
    private User[] users;

    public Company()
    {
        users = new User[]
        {
            new User("Иосиф", 25),
            new User("Тимур", 28),
            new User("Вася", 18),
            new User("Таня", 32)
        };
    }
public User this[int index]
    {
        get { return users[index]; }
        set { users[index] = value; }
    }


}

internal class Programm
{
    static void Main()
    {
        var user1 = new User("AAAA", 1);
        var user2 = new User("BBB", 3);
        var company = new Company();
        Console.WriteLine($"{company[0].Name} : {company[0].Age}");
        company[0] = user1;
        Console.WriteLine($"{company[0].Name} : {company[0].Age}");

    }
}
