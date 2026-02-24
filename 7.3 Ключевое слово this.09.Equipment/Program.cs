namespace _7._3_Ключевое_слово_this._09.Equipment
{
    internal class Program
    {
        public class Character
        {
            public Equipment equipment;
            public Character()
            {
                this.equipment = new Equipment([new Item("Меч", 10), new Item("Лук", 5)]);
            }
        }


        public class Equipment
        {
            public Item[] items;
            public Equipment(Item[] items)
            {
                this.items = items;
            }
            public int GetWeightOfEquipment()
            {
                int sumWeight = 0;
                foreach (var it in items)
                {
                    sumWeight += it.Weight;
                }
                return sumWeight;
            }
        }

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

        public static void Secret(Character pers, string[] itemsDescriptions)
        {
            int weightSecret = 0;
            int weightMax = 20;
            string[] names = new string[itemsDescriptions.Length];
            int[] weight = new int[itemsDescriptions.Length];
            int cnt = 0;
            foreach (var rec in itemsDescriptions)
            {
                string[] pair = rec.Split(' ');
                names[cnt] = pair[0];
                weight[cnt] = Convert.ToInt32(pair[1]);
                weightSecret += weight[cnt];
                cnt++;
            }
            if (weightSecret <= weightMax)
            {
                Item[] items = new Item[cnt];
                for (int i = 0; i < cnt; i++)
                {
                    items[i] = new Item(names[i], weight[i]);                    
                }
                pers.equipment.items = items;
                Console.WriteLine("Персонаж забрал снаряжение");
            }
            else Console.WriteLine("Слишком тяжёлое снаряжение");
        }

        static void Main()
        {
            Item item1 = new Item();
            Item item2 = new Item("Меч", 10);
            Item item3 = new Item("Лук", 5, "Возгорание");
            Item item4 = new Item("Щит", 15, "Дополнительный урон");
            Item[] items = { item1, item2, item3, item4 };
            Equipment equipment = new Equipment(items);
            Console.WriteLine($"Вес всех предметов: {equipment.GetWeightOfEquipment()}");

            Character character = new Character();
            character.equipment.items[0].ShowItem();
            character.equipment.items[1].ShowItem();
            Console.WriteLine($"Общий вес: {character.equipment.GetWeightOfEquipment()}");

            Character pers = new Character();
            string[] itemsDescriptions = new string[] { "Щит 4", "Сабля 3", "Посох 4" };
            Secret(pers, itemsDescriptions);
        }
    }
}