// 4.2.Символы (сhar).10.Игра в слова
int n = Convert.ToInt32(Console.ReadLine());
bool order = false; // Маша
char curChar, prevChar;
string input;
prevChar = Console.ReadLine()[^1];
for (int i = 1; i < n; i++)
{
    input = Console.ReadLine();
    curChar = input[0];
    if (char.ToLower(curChar) != prevChar) break;
    prevChar = input[^1];
    order = !order;
}
Console.WriteLine(order ? "Паша" : "Маша");




