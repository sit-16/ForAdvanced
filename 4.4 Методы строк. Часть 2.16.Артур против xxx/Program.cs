// 4.4 Методы строк. Часть 2.16.Артур против xxx
string input = Console.ReadLine();
string result = input;
while (result.Contains("xxx"))
{
    result = result.Replace("xxx","xx");
    Console.WriteLine(result);
}
Console.WriteLine(input.Length - result.Length);






/*
int collect = 0;
int counter = 0;
foreach (var ch in input)
{
    if (ch == 'x') collect++;
    else collect = 0;
    if (collect == 3)
    {
        counter++;
        collect--;
        continue; 
    }
}
Console.WriteLine(counter);
*/
