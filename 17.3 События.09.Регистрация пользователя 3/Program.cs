using System.Runtime.CompilerServices;

namespace _17._3_События._09.Регистрация_пользователя_3
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
        public event EventHandler<UserRegisteredEventArgs> UserRegistered;
        public UserManager()
        {
            Users = new List<User>();
        }
        public void Register(User user)
        {
            Users.Add(user);
            var eventArgs = new UserRegisteredEventArgs(user.Email);
            UserRegistered?.Invoke(this, eventArgs);
        }
    }

    public class UserRegisteredEventArgs:EventArgs
    { 
        public string Email { get; }
        public UserRegisteredEventArgs(string email)
        {
            Email = email;
        }
    }


    internal class Program
    {
        static void Main(string[] args)
        {
            User user = new User("Ivan Ivanov", "test@yandex.ru", "123321");

            UserManager userManager = new UserManager();
            userManager.Register(user);

            var foundUser = userManager.Users.FirstOrDefault(x => x.Name.Equals(user.Name) && x.Email.Equals(user.Email) && x.Password.Equals(user.Password));
            if (foundUser == null)
                throw new Exception("Ошибка в добавлении пользователя");
            else
                Console.WriteLine("Ok");
        }
    }
}
