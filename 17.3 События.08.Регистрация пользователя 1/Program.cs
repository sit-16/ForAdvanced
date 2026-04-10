namespace _17._3_События._08.Регистрация_пользователя_1
{
    public class User
    {
        public string Name;
        public string Email;
        public string Password;

        public User(string name, string email, string password)
        {
            Name = name;
            Email = email;
            Password = password;
        }
    }

    public class UserManager
    {
        public List<User> Users { get; }
        public UserManager()
        {
            Users = new List<User>();
        }
        public void  Register(User user)
        { 
            this.Users.Add(user);
        }
    }


    internal class Program
    {
        static void Main(string[] args)
        {
            UserManager userManager = new UserManager();
            userManager.Register(new User("Алексей", "a.potapov@gmail.com", "qwerty123"));
            Console.WriteLine($"Пользователь {userManager.Users[0].Name} зарегистрирован");
        }
    }
}
