// 4.2.Символы (сhar).08.Начало - конец
string st1 = Console.ReadLine();
string st2 = Console.ReadLine();
if (char.ToLower(st1[0]) == char.ToLower(st2[^1]))
    Console.WriteLine("YES");
else Console.WriteLine("NO");