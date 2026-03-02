namespace _9._5_Индексаторы._06.Команда
{
    public class Team
    {
        Player[] players;
        public Team()
        {
            players = new Player[10];
        }
        public Player this[int index] 
        {
            get { return players[index]; }
            set { players[index] = value; }
        }
    }

    public class Player
    {
        public string Name { get; }
        public int Number { get; }
        public Player(string name, int number)
        {
            Name = name;
            Number = number;
        }
    }
    internal class Program
    {
        static void Main(string[] args)
        {
            Team realMadrid = new Team();
            realMadrid[0] = new Player("Benzema", 9);
            realMadrid[1] = new Player("Sergio Ramos", 4);

            Console.WriteLine(realMadrid[1].Name);
        }
    }
}