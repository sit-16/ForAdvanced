// 4.2.Символы (сhar).09.Цифры в тексте
string input = Console.ReadLine();
List<char> digits =    new List<char>();
foreach (var ch in input)
{
    if (char.IsDigit(ch)) digits.Add(ch);
}
Console.WriteLine(string.Join(' ', digits));