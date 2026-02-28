using System.Collections.ObjectModel;
using System.Globalization;
using static System.Runtime.InteropServices.JavaScript.JSType;

namespace _9._4_readonly_поля._08.Дробь
{
    public class Fraction
    {
        public readonly int Numerator; // числитель
        public readonly int Denominator; // знаменатель
        public readonly double Value; // значение дроби

        public Fraction(int num, int den)
        {
            if (den <= 0) throw new ArgumentException("Знаменатель должен быть больше 0!");
            this.Numerator = num;
            this.Denominator = den;
            this.Value = num / den;
        }
    }



    internal class Program
    {
        public static void Main()
        {
            Fraction ratio = new Fraction(10, -2);
            Console.WriteLine($"{ratio.Numerator}/{ratio.Denominator} = {ratio.Value.ToString(CultureInfo.InvariantCulture)} ");
        }
    }
}
