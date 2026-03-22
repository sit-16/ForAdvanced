namespace Andromeda.DeepSpace
{
    public class Star
    {
        public string Observe()
        {
            return "Supernova detected";
        }
    }
}

namespace Earth.Observatory
{
    public class Telescope
    {
        public static void Main()
        {
            // Создайте переменную-объект newStar класса Star 
            Andromeda.DeepSpace.Star newStar = new Andromeda.DeepSpace.Star();
            // Выведите результат работы метода Observe() в консоль
            Console.WriteLine(newStar.Observe());
        }
    }
}
