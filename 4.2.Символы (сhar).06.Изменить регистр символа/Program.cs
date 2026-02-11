// 4.2.Символы (сhar).06.Изменить регистр символа
char ch = Convert.ToChar(Console.ReadLine());
ch = char.IsUpper(ch) ? char.ToLower(ch) : char.ToUpper(ch);
Console.WriteLine(ch);
