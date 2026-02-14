// 4.4 Методы строк. Часть 2.14.Извлечение слов
string input = Console.ReadLine();
var words = new Queue<string>();
string tempWord = "";
bool toWrite = false;
for (int i = 0; i < input.Length; i++)
{
    char ch = input[i];
    if (ch == '[') { toWrite = true; tempWord = ""; }
    else if (ch == ']' && tempWord.Length > 0) { toWrite = false; words.Enqueue(tempWord); tempWord = ""; }
    else if (toWrite) tempWord += ch;

}
if (words.Count>0) Console.WriteLine(string.Join(", ", words));
else Console.WriteLine("Эта строка не содержит ключевых наборов");

