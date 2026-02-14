// 4.4 Методы строк. Часть 2.07.Нижний регистр
string input = Console.ReadLine();
int counter = 0;
for (int i = 0; i < input.Length; i++)
{
    string test = input.Substring(i, 1);
    string low = test.ToLower();
    string upp = test.ToUpper();
    if (low != upp && test == low) counter++;
}
Console.WriteLine(counter);