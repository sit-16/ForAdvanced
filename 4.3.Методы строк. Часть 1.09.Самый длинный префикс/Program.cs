// 4.3.Методы строк. Часть 1.09.Самый длинный префикс

int n = Convert.ToInt32(Console.ReadLine());
string[] array = new string[n];
for (int i = 0; i < n; i++) array[i] = Console.ReadLine();
string pref = string.Empty;
for (int i = 0; i < array[0].Length; i++)
{
    char ch = array[0][i];
    bool flag = true;
    for (int j = 1; j < n; j++)
    {
        if (i >= array[j].Length) { flag = false; break; }
        if (array[j] == string.Empty) { flag = false; break; }
        if (array[j].Substring(i, 1)[0] != ch) { flag = false; break; }
    }
    if (flag) pref += ch;
    else break;
}
Console.WriteLine(pref == string.Empty ? "НЕТ" : pref);
