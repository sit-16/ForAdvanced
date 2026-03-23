using System;
// Подключи статический импорт требуемого класса
using static System.Math;

public static class DataStorage 
{
    public static int Value { get;} = 4;
}

namespace CSharpEssentials
{
    public class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine(Sqrt(DataStorage.Value));
        }

    }
}
