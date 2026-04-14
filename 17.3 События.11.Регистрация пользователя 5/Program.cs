namespace _17._3_События._11.Регистрация_пользователя_5
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

    public class UserRegisteredEventArgs : EventArgs
    {
        public string Email { get; }
        public UserRegisteredEventArgs(string email)
        {
            this.Email = email;
        }
    }


    public class TwoFactorAuthentication
    {
        private UserManager userManager;
        private void SendCode(object sender, UserRegisteredEventArgs eventArgs)
        {
            int code = CodeGenerator.Get();
            string Email = eventArgs.Email;
            Console.WriteLine($"Код подтверждения: {code} отправлен на почту: {Email}");
        }

        public TwoFactorAuthentication(UserManager userManager)
        {
            this.userManager = userManager;
        }

        public void TurnOn()
        {
            userManager.UserRegistered += this.SendCode;
        }

        public void TurnOff()
        {
            userManager.UserRegistered -= this.SendCode;
        }
    }

    public static class CodeGenerator
    {
        public static int Get()
        {
            return new Random().Next(1000, 9999);
        }
    }

    public class Advertisement
    {
        private UserManager userManager { get; }

        public Advertisement(UserManager userManager)
        { 
            this.userManager = userManager;
        }
        private void SendAds(object sender, UserRegisteredEventArgs eventArgs)
        {
            string email = eventArgs.Email;
            Console.WriteLine($"Последний день приобрести курс Технология Git по скидке. Отправлено на почту {email}");
        }
        public void TurnOn()
        {
            userManager.UserRegistered += this.SendAds;
        }

        public void TurnOff()
        {
            userManager.UserRegistered -= this.SendAds;
        }
    }

    internal class Program
    {
        static void Main(string[] args)
        {
            User user = new User("Ivan Ivanov", "ivanov@yandex.ru", "123321");

            UserManager userManager = new UserManager();
            var advertisement = new Advertisement(userManager);
            advertisement.TurnOn();

            userManager.Register(user);
        }
    }
}
