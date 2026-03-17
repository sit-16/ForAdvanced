namespace _12._2_Статический_конструктор._Статический_класс._04.Класс_А
{
    public class A
    {
        static A()
        {
            Console.WriteLine("Да! Я понял как создавать статический конструктор!");
        }
    }

    internal class Program
    {
        static void Main(string[] args)
        {
           var a = new A();
        }
    }
}
