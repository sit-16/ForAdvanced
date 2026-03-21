namespace _12._4_Файловая_система._13.File.Чтение_и_запись2
{
    using System;
    using System.IO;
    internal class Program
    {
        static void Main(string[] args)
        {
            //Создаём каталог для файла
            string path = @"C:\Files";
            DirectoryInfo dir = new DirectoryInfo(path);
            if (!dir.Exists)
            {
                dir.Create();
                Console.WriteLine($"Директория создана \"{path}\".");
            }
            Console.Write("Введите строку для записи в файл:");
            string text = Console.ReadLine();

            //Запись в файл
            Console.WriteLine("Запись в файл");
            using (StreamWriter fstream = new StreamWriter(@$"{path}\note.txt",false,System.Text.Encoding.Default))
            {
                fstream.WriteLine(text);
            }

            //Дозапись в файл
            Console.WriteLine("Дозапись в файл");
            using (StreamWriter fstream = new StreamWriter(@$"{path}\note.txt",true,System.Text.Encoding.Default))
            {
                fstream.WriteLine("Дозапись1");
                fstream.Write(1.1);
                fstream.WriteLine("Дозапись2");
            }

            //Чтение из файла
            Console.WriteLine("Чтение из файла");
            using (StreamReader fstream = new StreamReader(@$"{path}\note.txt"))
            {
                Console.WriteLine(fstream.ReadToEnd());
            }

        }
    }
}
