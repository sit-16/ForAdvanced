namespace _14._1_Операторы__работающие_с_NULL._09.Информации_о_пользователе
{

    public class UserProfile
    {
        public string Name { get; set; }
        public string Gender { get; set; }
        public string Country { get; set; }

        public UserProfile(string name)
        {
            Name = name;
        }

        public void DisplayUserInfo()
        {
            Console.WriteLine($"Имя: {Name}");
            Console.WriteLine($"Пол: {Gender ?? "Пол не указан"}");
            Console.WriteLine($"Страна: {Country ?? "Страна не указана"}");
        }
    }

    internal class Program
    {
        public static void Main()
        {
            UserProfile usProf = new UserProfile("Алина") { Gender = "Жен" };
            usProf.DisplayUserInfo();
        }
    }
}
