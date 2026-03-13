namespace _11._3_Базовый_класс_Object._08.Вывод_футболиста_2
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
        public override string ToString()
        {
            return $"{this.Name} играет под номером {this.Number}";
        }
    }

    internal class Program
    {
        static void Main(string[] args)
        {
            Player player = new Player("Sergio Ramos", 4);
            Console.WriteLine(player);
        }
    }
}
