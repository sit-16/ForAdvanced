using System.Reflection.Emit;

namespace _6._4_Моделирование_классов._07.Официант
{
    public class Table
    {
        public int Number;
        public List<string> Guests;
    }

    public class Waiter
    {
        public string Name;
        public List<Table> Tables;
    }
    

    internal class Program
    {
        static void Main(string[] args)
        {
            Table tableA = new Table();
            tableA.Number = 4;
            tableA.Guests = ["Гость 4"];

            Table tableB = new Table();
            tableB.Number = 7;
            tableB.Guests = ["Гость 12"];

            Waiter valeria = new Waiter();
            valeria.Name = "Валерия";
            valeria.Tables = [tableA];

            Waiter konstantin = new Waiter();
            konstantin.Name = "Константин";
            konstantin.Tables = [tableB];

            Console.WriteLine($"Официант {valeria.Name} обслуживает стол {valeria.Tables[0].Number}");
            Console.WriteLine($"Официант {konstantin.Name} обслуживает стол {konstantin.Tables[0].Number}");
        }
    }
}
