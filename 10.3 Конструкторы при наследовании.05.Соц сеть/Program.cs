namespace _10._3_Конструкторы_при_наследовании._05.Соц_сеть
{
    public class User
    {
        public string Name { get; set; }
        public User(string name)
        {
            this.Name = name; 
        }
        public void SendMessage(User user, string message) { }
        public void Post(string message) { }
        public string GetInfo() 
        {
            return $"Имя={this.Name}";
        }
    }

    public class Person : User 
    {
        private int Age { get; set; }
        public Person(string name, int age) : base(name)
        {
            Age = age;
        }
        public new string GetInfo()
        {
            return $"Имя={this.Name}, Возраст={this.Age}";
        }
        public void Subscribe(User user) 
        { }
    }

    public class Community : User 
    {
        private string Description { get; set; }
        public Community(string name, string description):base(name)
        {
            this.Description = description;
        }
        public new string GetInfo()
        {
            return $"Имя={this.Name}, Описание={this.Description}";
        }
    }

    internal class Program
    {
        static void Main(string[] args)
        {
            User user = new User("Josef");
            Console.WriteLine(user.GetInfo());
            user.SendMessage(user, "123");
            user.Post("123123");

            Person person = new Person("Josef", 15);
            Console.WriteLine(person.GetInfo());
            person.SendMessage(person, "123");
            person.Post("123123");
            person.Subscribe(person);

            Community community = new Community("Josef", "desc");
            Console.WriteLine(community.GetInfo());
            community.SendMessage(community, "123");
            community.Post("123123");
        }
    }
}
