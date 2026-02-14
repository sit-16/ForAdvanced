// 4.4 Методы строк. Часть 2.09.Две одинаковые буквы
string st = Console.ReadLine();
char ch = st[0];
while(true)
{
    st = st.Substring(1);
    if (st.Contains(ch))
    {
        Console.WriteLine(ch);
        break;
    }
    ch = st[0];
}