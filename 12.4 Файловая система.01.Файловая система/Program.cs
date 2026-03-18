namespace _12._4_Файловая_система._01.Файловая_система
{
    using System.IO;
    internal class Program
    {
        static void Main(string[] args)
        {
            var driveInfo = DriveInfo.GetDrives();
            foreach (var dr in driveInfo)
            {
                if (dr.IsReady) Console.WriteLine($"{dr.Name,5}|" +
                    $" {dr.DriveFormat,-10}|{dr.DriveType,7}|" +
                    $"{dr.TotalSize/Math.Pow(1024,3),7:f2} Гб|" +
                    $"{dr.TotalFreeSpace / Math.Pow(1024, 3),7:f2} Гб|" +
                    $"{((double)dr.TotalFreeSpace/ dr.TotalSize),7:P2}|");
                else Console.WriteLine($"{dr.Name,5}| {"Not ready",-10}");
            }
            
        }
    }
}
