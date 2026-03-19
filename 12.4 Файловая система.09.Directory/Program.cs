namespace _12._4_Файловая_система._09.Directory
{
    using System.IO;
    internal class Program
    {
        static void Main(string[] args)
        {
            string path = @"C:\Users\Public\Documents";
            string newPath = @"C:\Users\Public\Pictures";
            string newDir = @"MyCatalog";

            string sourcePath = string.Join('\\', [path, newDir]);
            string targetPath = string.Join('\\', [newPath, newDir]);

            // dynamic DirectoryInfo
            DirectoryInfo dir = new DirectoryInfo(sourcePath);
            if (dir.Exists)
                Console.WriteLine($"Директория \"{newDir}\" НЕ создана, т.к. уже существует в \"{path}\".");
            else
            {
                dir.Create();
                Console.WriteLine($"Директория \"{newDir}\" СОЗДАНА в \"{path}\".");
            }

            // static Directory
            if (Directory.Exists(targetPath))
                Console.WriteLine($"Директория \"{newDir}\" НЕ перемещена, т.к. уже существует в \"{newPath}\".");
            else
            {

                Directory.Move(sourcePath, targetPath);
                Console.WriteLine($"Директория \"{newDir}\" ПЕРЕМЕЩЕНА в \"{newPath}\".");
            }
        }
    }
}
