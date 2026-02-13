// 4.3.Методы строк. Часть 1.07.Автандил и дабстеп
string input = Console.ReadLine();
string[] output = input.Split("WUB", StringSplitOptions.RemoveEmptyEntries);
Console.WriteLine(string.Join(' ', output));