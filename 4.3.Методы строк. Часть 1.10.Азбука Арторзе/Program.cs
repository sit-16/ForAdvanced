// 4.3.Методы строк. Часть 1.10.Азбука Арторзе
string input = Console.ReadLine();
string result = input.Replace("--", "2");
result = result.Replace("-.", "1");
result = result.Replace(".", "0");
Console.WriteLine(result);