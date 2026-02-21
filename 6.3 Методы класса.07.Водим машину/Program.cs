using System.Runtime.ConstrainedExecution;

namespace _6._3_Методы_класса._07.Водим_машину
{
    public class Car
    {
        public void Drive()
        {
            Console.WriteLine("Вын-вын!");
        }
    }

    public class Zebra
    {
        string[] color = { "Полоска белая", "Полоска черная" };
        bool isBlack = false;
        public void GetStripe()
        {
            Console.WriteLine(color[isBlack ? 1 : 0]);
            isBlack = !isBlack;
        }
    }

    internal class Program
    {
        static void Main(string[] args)
        {
            //Car car = new Car();
            //car.Drive();
            Zebra zebra1 = new Zebra();
            zebra1.GetStripe();
            zebra1.GetStripe();
            zebra1.GetStripe();
            zebra1.GetStripe();
            Console.WriteLine();
            Zebra zebra2 = new Zebra();
            zebra2.GetStripe();
            zebra2.GetStripe();
        }
    }
}
