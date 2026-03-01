namespace _9._4_readonly_поля._15.Регистрация_младенцев
{
    public class Person()
    {
        public string Name { get; set; }
        public int Age { get; set; }
        public readonly Person Mom;
        public readonly Person Dad;

        public Person(string name, int age, Person mom, Person dad):this()
        { 
            this.Name = name;
            this.Age = age;
            this.Mom = mom;
            this.Dad = dad;
        }
    }
    internal class Program
    {
        static void Main(string[] args)
        {
            //var mom = new Person("Светлана", 23, null, null);
            //var dad = new Person("Алексей", 24, null, null);

            //RegisterBaby("Миша", mom, dad);
            Person mom = new Person("Светлана", 20, null, null);
            Person dad = new Person("Алексей", 20, null, null);
            Person baby = new Person("Паша", 0, mom, dad);
            Console.WriteLine($"Mom age:{baby.Mom.Age}");
            Console.WriteLine($"Dad age:{baby.Dad.Age}");
            UpdateMomAge(baby);
            UpdateDadAge(baby);
            Console.WriteLine($"Mom age:{baby.Mom.Age}");
            Console.WriteLine($"Dad age:{baby.Dad.Age}");
        }
        public static void RegisterBaby(string name, Person mom, Person dad)
        {
            Person baby = new Person(name, 0, mom, dad);
            Console.WriteLine($"Зарегистрирован новый ребёнок Имя:{baby.Name}, Мама:{baby.Mom.Name}, Папа:{baby.Dad.Name}");
            Console.WriteLine($"Mom age:{baby.Mom.Age}");
        }

        public static void UpdateMomAge(Person child)
        {
            child.Mom.Age++;
        }
        public static void UpdateDadAge(Person child)
        {
            child.Dad.Age++;
        }
    }
}
