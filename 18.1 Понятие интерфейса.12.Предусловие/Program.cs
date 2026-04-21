namespace _18._1_Понятие_интерфейса._12.Предусловие
{
    public interface IUsersStorage
    {
        List<User> GetAll();
        User TryGetById(int id);
        void Add(User user);
        bool RemoveById(int id);
        bool UpdateById(int id, string name, int age);

    }

    public class UsersInMemoryStorage : IUsersStorage
    {
        private List<User> userList;

        public UsersInMemoryStorage()
        {
            userList = new List<User>();
        }

        public List<User> GetAll()
        {
            return userList;
        }
        public User TryGetById(int id)
        {
            foreach (User user in userList)
            { 
                if (user.Id == id) return user;
            }
            return null;
        }
        public void Add(User user)
        {
            userList.Add(user);
        }

        public bool RemoveById(int id)
        {
            User user = this.TryGetById(id);
            if (user != null) 
            {
                userList.Remove(user);
                return true;
            }  
            return false;
        }

        public bool UpdateById(int id, string name, int age)
        {
            User user = this.TryGetById(id);
            if (user != null)
            {
                user.Name = name;
                user.Age = age;
                return true;
            }
            return false;
        }
    }

    public class User
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public int Age { get; set; }

    }

    internal class Program
    {
        static void Main(string[] args)
        {
            //var user = new User()
            //{
            //    Id = 1,
            //    Name = "Ivan",
            //    Age = 25
            //};
            //Console.WriteLine($"Id = {user.Id}, Name = {user.Name}, Age = {user.Age}");
            IUsersStorage usersStorage = new UsersInMemoryStorage();
            List<User> users = usersStorage.GetAll();
            Console.WriteLine(users.Count == 0);

            User user = usersStorage.TryGetById(5);
            Console.WriteLine(user == null);

            usersStorage.Add(new User { Id = 1, Name = "Josef", Age = 26 });
            usersStorage.Add(new User { Id = 2, Name = "Mark", Age = 27 });
            Console.WriteLine(users.Count == 2);

            user = usersStorage.TryGetById(2);
            Console.WriteLine(user.Name == "Mark");

            Console.WriteLine(usersStorage.UpdateById(2, "Andrew", 27));
            Console.WriteLine(usersStorage.RemoveById(2));
        }
    }
}

