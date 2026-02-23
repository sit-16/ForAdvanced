namespace _7._2_Параметризованные_конструкторы._06.Football_player
{
    public class FootballPlayer
    {
        public string Name;
        public string Surname;
        public int Goals;
        public int Assists;
        public FootballPlayer(string name, string surname)
        {
            Name = name;
            Surname = surname;
            Goals = 0;
            Assists = 0;
        }
        public void AddScore(int value)
        {
            Goals+= value;
        }
        public void AddAssists(int value)
        {
            Assists+= value;
        }
        public void ShowStatistics()
        {
            Console.WriteLine($"{Surname} {Name} - голы: {Goals}, передачи: {Assists}");
        }
    }
    internal class Program
    {
        static void Main(string[] args)
        {
            FootballPlayer player1 = new FootballPlayer("Cristiano", "Ronaldo");
            player1.AddScore(711);
            player1.AddAssists(169);
            player1.ShowStatistics();

            FootballPlayer player2 = new FootballPlayer("Lionel", "Messi");
            player2.AddScore(682);
            player2.AddAssists(240);
            player2.ShowStatistics();
        }
    }
}
