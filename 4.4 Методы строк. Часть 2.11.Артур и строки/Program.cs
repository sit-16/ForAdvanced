// 4.4 Методы строк. Часть 2.11.Артур и строки
/*
string stA = Console.ReadLine();
string stB = Console.ReadLine();
Console.WriteLine(string.Compare(stA.ToLower(), stB.ToLower()));
*/

string s = Console.ReadLine().ToLower();
string t = Console.ReadLine().ToLower();

int result = 0;

for (int i = 0; i < s.Length; i++)
{
    if (s[i] < t[i])
    {
        result = -1;
        break;
    }
    if (s[i] > t[i])
    {
        result = 1;
        break;
    }
}
Console.WriteLine(result);