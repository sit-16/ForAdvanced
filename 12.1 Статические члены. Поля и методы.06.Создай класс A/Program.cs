namespace _12._1_Статические_члены._Поля_и_методы._06.Создай_класс_A
{
    public class A
    {
        public static int Field1;// { get; set; }
        public string Field2;
    }

    internal class Program
    {
        static void Main(string[] args)
        {
            A.Field1 = 1;
            A a = new A();
            a.Field2 = "*";

            Console.WriteLine("Field1:{0}, Field2:{1}", A.Field1, a.Field2);
        }
    }
}
