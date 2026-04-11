namespace _17._3_События._08.Регистрация_пользователя_2
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
            this.Users.Add(user);
            UserRegistered.Invoke(this, new UserRegisteredEventArgs(user.Email));
        }
    }

public class UserRegisteredEventArgs : EventArgs
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
            EventArgs arg = new UserRegisteredEventArgs("Test2@yandex.ru");

            var info = typeof(UserRegisteredEventArgs).GetProperty("Email");
            if (info.CanWrite == false)
                Console.WriteLine("Ok");
            else
                throw new Exception("Свойство Email должно быть только для чтения");
        }
    }
}
