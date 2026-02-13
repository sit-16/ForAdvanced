// 4.3.Методы строк. Часть 1.04.Заглавные буквы
string[] name = Console.ReadLine().Split();
if (char.IsUpper(name[0][0]) && char.IsUpper(name[1][0]))
    Console.WriteLine("YES");
else Console.WriteLine("NO");
