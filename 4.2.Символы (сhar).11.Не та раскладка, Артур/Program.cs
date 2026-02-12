// 4.2.Символы (сhar).11.Не та раскладка, Артур
string englishAlphabet = "qwertyuiop[]asdfghjkl;'zxcvbnm,.";
string russianAlphabet = "йцукенгшщзхъфывапролджэячсмитьбю";
var dict = new Dictionary<char, char>();
for (int i = 0; i < russianAlphabet.Length; i++)
    dict.Add(russianAlphabet[i], englishAlphabet[i]);
int n = Convert.ToInt32(Console.ReadLine());
for (int i = 0; i < n; i++)
{
    string input = Console.ReadLine();
    string translate = string.Empty;
    foreach (var ch in input)
    {
        if (dict.ContainsKey(ch)) translate += dict[ch];
        else translate += ch;
    }
    Console.WriteLine(translate);
}