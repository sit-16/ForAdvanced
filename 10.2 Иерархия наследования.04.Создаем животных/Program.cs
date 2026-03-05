namespace _10._2_Иерархия_наследования._04.Создаем_животных
{
    public class Animal
    {
        public void Breathe() { }
        public void Eat() { }
    }
    public class Fish : Animal
    {
        public void Swim() { }
    }

    public class Bird : Animal
    {
        public void LayEggs() { }
    }
    public class FlyingBird : Bird
    {
        public void Fly() { }
    }

    internal class Program
    {
        static void Main(string[] args)
        {
            var a = new Animal();
            var b = new Animal();
        }
    }
}
