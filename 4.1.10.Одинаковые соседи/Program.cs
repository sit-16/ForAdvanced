// See https://aka.ms/new-console-template for more information
internal class Program //4.1.10.Одинаковые соседи
{
    static void Main() 
    {
        string input = Console.ReadLine();
        int counter = 0;
        char previos_char = input[0];
        for (int i = 1; i < input.Length; i++)
        {
            if (input[i] == previos_char) counter++;
            previos_char = input[i];
        }
        Console.WriteLine(counter);
    }
}
