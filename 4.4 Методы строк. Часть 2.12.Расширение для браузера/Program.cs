// 4.4 Методы строк. Часть 2.12.Расширение для браузера
string input = Console.ReadLine();
int low = 0, upp = 0;
foreach (var ch in input)
{
    if (char.IsLower(ch)) low++;
    else if (char.IsUpper(ch)) upp++;
}

if (upp > low) input = input.ToUpper();
else input = input.ToLower();
Console.WriteLine(input);