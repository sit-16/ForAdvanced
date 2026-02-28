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


public class User
{
    public User field;

    public string Name { get; set; }
    public void Method1()
    {
        field.Name = "NoName"; // ?
    }
}

internal class Program
{
    static void Main(string[] args)
    {
        var v = new User();
        v.Method1();
        Console.WriteLine(v.field.Name);
        v.field.Name = "dfdf";
    }
}