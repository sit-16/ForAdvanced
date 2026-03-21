namespace _12._4_Файловая_система._15.File.Задача
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string[] plans =
            {
                "1.Пройти курс \"C# для продвинутых\"",
                "2.Пройти курс \"LINQ\"",
                "3.Пройти курс \"C# ООП\""
            };

            string path = @"C:\Users\Public\Documents\Мои планы";
            DirectoryInfo directory = new DirectoryInfo(path);
            if (!directory.Exists)
            {
                directory.Create();
            }

            string fname = "Список задач.txt";
            using (StreamWriter sw = new StreamWriter(@$"{path}\{fname}", false, System.Text.Encoding.Default))
            { 
                foreach (string plan in plans) 
                {
                    sw.WriteLine(plan);
                }    
            }
        }
    }
}
