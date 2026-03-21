namespace _12._4_Файловая_система._13.File.Чтение_и_запись
{
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
            using (FileStream fstream = new FileStream($@"{path}\note.txt", FileMode.OpenOrCreate))
            {
                //преобразуем строку в массив байтов
                byte[] array = System.Text.Encoding.Default.GetBytes(text);
                //запись массива байтов в файл
                fstream.Write(array, 0, array.Length);
                Console.WriteLine("Текст записан в файл.");
            }

            //Чтение из файла
            Console.WriteLine("Выполним чтение из файла.");
            using (FileStream fstream = new FileStream(@$"{path}\note.txt", FileMode.Open) )
            {
                //создаём массив для хранения данных из файла
                byte[] array = new byte[fstream.Length];
                //считываем данные из файла в массив
                fstream.Read(array, 0, array.Length);
                string file_text = System.Text.Encoding.Default.GetString(array);
                Console.WriteLine(@$"Текст из файла: {file_text}");
            }
        }
    }
}
