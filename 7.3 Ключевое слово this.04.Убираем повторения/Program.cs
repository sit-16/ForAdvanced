namespace _7._3_Ключевое_слово_this._04.Убираем_повторения
{
    public class Phone
    {
        public string Name; // название
        public int Price; // цена в рублях
        public int Memory; // объем памяти в ГБ
        public bool IsAvailable; // доступна или нет

        public Phone(string name):this(name, 5000, 8, true)
        {}

        public Phone(string name, int price) : this(name, price, 8, true)
        {}

        public Phone(string name, int price, int memory) : this(name, price, memory, true)
        {}
        public Phone(string name, int price, int memory, bool isAvailable)
        {
            Name = name;
            Price = price;
            Memory = memory;
            IsAvailable = isAvailable;
        }
    }


    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hello, World!");
        }
    }
}
