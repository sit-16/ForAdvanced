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

    public class SquareSummator: Summator
    {
        protected override int Transform(int item)
        {
            return item * item;
        }
    }

    public class CubeSummator: Summator
    {
        protected override int Transform(int item)
        {
            return item * item * item;
        }
    }

    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine(new Summator().Sum(5));
            Console.WriteLine(new SquareSummator().Sum(5));
            Console.WriteLine(new CubeSummator().Sum(5));
        }
    }
}
