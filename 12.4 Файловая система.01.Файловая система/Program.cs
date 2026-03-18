namespace _12._4_Файловая_система._01.Файловая_система
{
    using System.IO;
    internal class Program
    {
        static void Main(string[] args)
        {
            const int width = 8;
            Console.WriteLine($"{"Имя",-width}|" +
                    $" {"Формат",-width}|" +
                    $"{"Тип",-width}|" +
                    $"{"Объём Гб",width}|" +
                    $"{"Free Гб",width}|" +
                    $"{"Free %",width}|");
            var driveInfo = DriveInfo.GetDrives();
            foreach (var dr in driveInfo)
            {
                if (dr.IsReady && dr.DriveFormat == "NTFS") Console.WriteLine($"{dr.Name,-width}|" +
                    $" {dr.DriveFormat,-width}|{dr.DriveType,-width}|" +
                    $"{dr.TotalSize/Math.Pow(1024,3),width:f2}|" +
                    $"{dr.TotalFreeSpace / Math.Pow(1024, 3),width:f2}|" +
                    $"{((double)dr.TotalFreeSpace/ dr.TotalSize),width:P2}|");
            }
            
        }
    }
}
