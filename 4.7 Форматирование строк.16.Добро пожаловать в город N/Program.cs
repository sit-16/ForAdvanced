// 4.7 Форматирование строк.16.Добро пожаловать в город N
int n = Convert.ToInt32(Console.ReadLine());
for (int i = 0; i < n; i++)
{
    string[] input = Console.ReadLine().Split();
    Console.WriteLine("Добрый день, {0}! Рады приветствовать вас в городе {1}!", input[0], input[1]);
}
