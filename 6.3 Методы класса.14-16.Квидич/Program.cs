namespace _6._3_Методы_класса._14_16.Квидич
{
    public class Team
    {
        public string Name = "Gryffindor";
        public int Points;
        public void PrintInfo()
        {
            Console.WriteLine($"{Name}:{Points}");
        }
    }

    public class Quidditch
    { 
        public Team RedTeam = new Team();
        public Team BlueTeam = new Team();
        public void ShowScore()
        {
            Console.WriteLine($"{RedTeam.Name}:{RedTeam.Points}");
            Console.WriteLine($"{BlueTeam.Name}:{BlueTeam.Points}");
        }
        public void RedSnitch()
        {
            RedTeam.Points += 150;
            Console.WriteLine("Red Team Won!");
        }
        public void BlueSnitch()
        {
            BlueTeam.Points += 150;
            Console.WriteLine("Blue Team Won!");
        }

    }


    internal class Program
    {
        static void Main(string[] args)
        {
            //Team team = new Team();
            //team.PrintInfo();
            //team.Points += 100;
            //team.PrintInfo();
            //team.Name = "Slytherin";
            //team.PrintInfo();
            //team.Points -= 50;
            //team.Points += 100;
            //team.PrintInfo();

            //Quidditch quidditch = new Quidditch();
            //quidditch.RedTeam.Name = "Hufflepuff";
            //quidditch.BlueTeam.Name = "Ravenclaw";
            //quidditch.ShowScore();
            //quidditch.RedTeam.Points += 10;
            //quidditch.BlueTeam.Name = "Gryffindor";
            //quidditch.ShowScore();

            Quidditch quidditch = new Quidditch();
            quidditch.RedTeam.Name = "Hufflepuff";
            quidditch.BlueTeam.Name = "Ravenclaw";
            quidditch.RedTeam.Points += 100;
            quidditch.BlueTeam.Points += 90;
            quidditch.ShowScore();
            quidditch.BlueSnitch();
            quidditch.ShowScore();
        }
    }
}
