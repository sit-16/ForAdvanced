// 4.4 Методы строк. Часть 2.08.Какой символ встречается раньше
string input = Console.ReadLine();
int posX = input.IndexOf('x');
int posW = input.IndexOf('w');
if (posW == -1 && posX == -1) Console.WriteLine("-1");
else if (posX == -1 && posW >= 0) Console.WriteLine("w");
else if (posW == -1 && posX >= 0) Console.WriteLine("x");
else if (posX < posW) Console.WriteLine("x");
else if (posW < posX) Console.WriteLine("w");