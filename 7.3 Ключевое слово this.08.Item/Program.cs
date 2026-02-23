namespace _7._3_Ключевое_слово_this._08.Item
{
    public class Item
    {
        public string Name;
        public int Weight;
        public string SpecialAbility;

        public Item() : this("", 0, "")
        { }

        public Item(string Name, int Weight) : this(Name, Weight, "")
        { }
        public Item(string Name, int Weight, string SpecialAbility)
        { 
            this.Name = Name;
            this.Weight = Weight;
            this.SpecialAbility = SpecialAbility;
        }
        public void ShowItem()
        {
            Console.WriteLine($"{Name}:{Weight}({SpecialAbility})");
        }  
    }


    internal class Program
    {
        static void Main(string[] args)
        {
            Item item1 = new Item();
            Item item2 = new Item("Меч", 10);
            Item item3 = new Item("Лук", 5, "Возгорание");
            Item item4 = new Item("Щит", 15, "Дополнительный урон");
            item1.ShowItem();
            item2.ShowItem();
            item3.ShowItem();
            item4.ShowItem();
        }
    }
}
