// 4.4 Методы строк. Часть 2.13.Конвертер
string input = Console.ReadLine();
string newExt = Console.ReadLine();
string existExt = "", existNam = "";
bool goodExt = true;
int coma = input.LastIndexOf('.');
if (coma == -1) goodExt = false;
else
{
    existExt = input.Substring(coma + 1);
    existNam = input.Substring(0, coma);
    if (string.IsNullOrEmpty(existExt)) goodExt = false;
    foreach (var ch in existExt)
        if (!(char.IsLetter(ch) || char.IsDigit(ch))) goodExt = false;
}
if (goodExt) Console.WriteLine(existNam + newExt);
else Console.WriteLine("Корректное расширение файла не найдено");

