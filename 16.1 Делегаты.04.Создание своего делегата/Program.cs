namespace _16._1_Делегаты._04.Создание_своего_делегата
{
    internal class Program
    {
        delegate bool Predicate(int x);
        static bool IsAdult(int age)
        { 
            return age >= 18;
        }

        static void Main(string[] args)
        {
            var x = 25;
            Predicate predicate = IsAdult;
            var result = predicate?.Invoke(x);
            Console.WriteLine(result);
        }
    }
}
