namespace _9._5_Индексаторы._07.Команда2
{
    internal class Program
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
                get 
                {
                    if (index >= 0 && index < players.Length)
                        return players[index];
                    else throw new Exception("Ошибка");

                }
                set 
                {
                    if (index >= 0 && index < players.Length)
                        players[index] = value;
                    else throw new Exception("Ошибка");
                }
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
        static void Main(string[] args)
        {
            Team realMadrid = new Team();

            realMadrid[0] = new Player("Benzema", 9);
            realMadrid[1] = new Player("Sergio Ramos", 4);
            realMadrid[12] = new Player("Sergio Ramos2", 43);
            Console.WriteLine(realMadrid[2].Name);
        }
    }
}
