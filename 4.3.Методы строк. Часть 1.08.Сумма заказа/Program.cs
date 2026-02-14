// 4.3.Методы строк. Часть 1.08.Сумма заказа
using System.Globalization;

int n  = Convert.ToInt32(Console.ReadLine());
double summ = 0;
for (int i = 0; i < n; i++)
{ 
    string[] input = Console.ReadLine().Split('#');
    summ += Convert.ToDouble(input[2],CultureInfo.CreateSpecificCulture("en-EN"));
}
Console.WriteLine(summ.ToString("0.00"));