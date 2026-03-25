using System.Xml.Linq;

namespace _14._2_Ключевое_слово_var._06.Анонимный_тип
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //Анонимный тип
            var t = new { Name = "Test", Age = 18 };
            //Массив анонимных объектов анонимного типа
            var tables = new[] { 
                new {Name = "Test1", Age = 19 },
                new {Name = "Test2", Age = 20 }
            };

        }
    }
}
