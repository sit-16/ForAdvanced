namespace _12._4_Файловая_система._12.File
{
    using System.IO;
    internal class Program
    {
        static void Main(string[] args)
        {
            string dir_path = @"C:\Files";
            string[] files_new = new string[]
            {
                @"C:\Files\file1.txt",
                @"C:\Files\file2.csv",
                @"C:\Files\file3.txt",
                @"C:\Files\file4.csv",
                @"C:\Files\file5.txt"
            };

            // Формирование исходных данных
            Console.WriteLine("Подготовка набора файлов:");
            if (!Directory.Exists(dir_path)) Directory.CreateDirectory(dir_path);
            foreach (string file in files_new)
            {
                if (!File.Exists(file))
                {
                    File.Create(file).Close();
                    Console.WriteLine($"Файл \"{file}\" СОЗДАН.");
                }
                else
                    Console.WriteLine($"Файл \"{file}\" НЕ создан, т.к. уже существует.");
            }

            // Решение задачи
            Console.WriteLine($"\nНазвания файлов в директории \"{dir_path}\" у которых расширение \"txt\":");
            DirectoryInfo checkDir = new DirectoryInfo(dir_path);

            Console.WriteLine($" {"Имя",-10}|{" Время создания",-20}|{" Размер, Б",-5}");
            foreach (var file in checkDir.GetFiles())
            {
                if (file.Extension.Equals(".txt", StringComparison.OrdinalIgnoreCase))
                    Console.WriteLine($" {file.Name,-10}|{file.CreationTime,20}|{file.Length,5}");
            }
        }
    }
}

