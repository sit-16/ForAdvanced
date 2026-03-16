namespace _12._1_Статические_члены._Поля_и_методы._09.Класс_Constants
{
    public class Constants
    {
        public static int TimeoutSeconds { get; set; }
        public static string AdminLogin {  get; set; }
        public static string AdminPassword { get; set; }
        public static bool Development { get; set; }
    }


    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hello, World!");
        }
    }
}
