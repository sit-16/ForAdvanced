namespace _11._2_virtual_override._06.Трансформаторы
{
    public class Summator
    {
        protected virtual int Transform(int item)
        {
            return item;
        }

        public int Sum(int N)
        {
            int result = 0;
            for (int i = 1; i <= N; i++)
            {
                result += this.Transform(i);
            }
            return result;
        }
    }

    public class PowerSummator : Summator
    {
        public int P { get; set; }
        public PowerSummator(int p)
        {
            P = p;
        }
        protected override int Transform(int item)
        {
            int result = 1;
            for (int i = 0; i < P; i++)
                result *= item;
            return result;
        }
    }

    public class SquareSummator: PowerSummator
    {
        public SquareSummator():base(2)
        {
            
        }
    }

    public class CubeSummator: PowerSummator
    {
        public CubeSummator() : base(3)
        {

        }
    }


    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine(new Summator().Sum(5));
            Console.WriteLine(new PowerSummator(1).Sum(5));

            Console.WriteLine(new SquareSummator().Sum(5));
            Console.WriteLine(new PowerSummator(2).Sum(5));

            Console.WriteLine(new CubeSummator().Sum(5));
            Console.WriteLine(new PowerSummator(3).Sum(5));
        }
    }
}
