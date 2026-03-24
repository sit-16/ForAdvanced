namespace _14._1_Операторы__работающие_с_NULL._08.Упрости_код
{

    internal class Program
    {
        static void Print(string name)
        {
            //Console.WriteLine(name??"Неизвестное имя");

            if (name == null)
            {
                Console.WriteLine("Неизвестное имя");
            }
            else
            {
                Console.WriteLine(name);
            }
        }

        static void Main(string[] args)
        {
            Console.WriteLine("Hello, World!");
        }
    }
}
