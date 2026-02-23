using System.Xml.Linq;

namespace _7._2_Параметризованные_конструкторы._04.Dog
{
    internal class Program
    {
        public class Dog
        {
            public string Name;
            public int Age;
            public Dog(string sName, int iAge)
            {
                Name = sName;
                Age = iAge;
            }
            public string GetDescription()
            {
                return $"{Name} is {Age} years old";
            }
            public string Speak(string speech)
            {
                return $"{Name} says {speech}";
            }
        }


        static void Main(string[] args)
        {
            Dog dog = new Dog("Песик", 2);
            Console.WriteLine(dog.GetDescription());
            Console.WriteLine(dog.Speak("Woof Woof"));
            Console.WriteLine(dog.Speak("Bow Wow"));
        }
    }
}
