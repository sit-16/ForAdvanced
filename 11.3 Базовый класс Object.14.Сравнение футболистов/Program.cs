namespace _11._3_Базовый_класс_Object._14.Сравнение_футболистов
{
    public class Player
    {
        public string Name { get; }
        public int Number { get; }
        public Player(string name, int number)
        {
            Name = name;
            Number = number;
        }
        public override bool Equals(object? obj)
        {
            if (obj == null) return false;
            if (obj.GetType() != this.GetType()) return false;
            Player other = (Player) obj;
            return this.Name.Equals(other.Name)&& this.Number.Equals(other.Number);
        }

        public override int GetHashCode()
        {
            string combo = string.Format("{0}{1}", this.Name, this.Number);
            return combo.GetHashCode();
        }
    }

    internal class Program
    {
        public static void Main()
        {
            Player player1 = new Player("Sergio Ramos", 4);
            Player player2 = new Player("Sergio Ramos", 4);
            Console.WriteLine(player1.Equals(player2));
            Console.WriteLine(player1.GetHashCode());
            Console.WriteLine(player2.GetHashCode());
        }
    }
}
