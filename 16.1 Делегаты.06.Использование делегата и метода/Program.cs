namespace _16._1_Делегаты._06.Использование_делегата_и_метода
{
    using System;
    using System.Collections.Generic;

    namespace CSharpEssentials
    {
        class Program
        {
            // делегат
            delegate bool Predicate(int year);

            // метод делегата
            private static bool IsAdult(int year)
            {
                return year >= 18;
            }

            // Здесь реализуйте метод GetAdults
            private static List<int> GetAdults(List<int> ages, Predicate myDelegate) 
            {
                var res =  new List<int>();
                foreach (var age in ages)
                {
                    if (myDelegate.Invoke(age))
                        res.Add(age);
                }
                return res;
            }

            static void Main()
            {
                List<int> years = new List<int> { 13, 17, 18, 19, 20, 50 };

                List<int> adults = GetAdults(years, IsAdult);

                foreach (var adult in adults)
                {
                    Console.WriteLine(adult);
                }
            }
        }
    }
}
