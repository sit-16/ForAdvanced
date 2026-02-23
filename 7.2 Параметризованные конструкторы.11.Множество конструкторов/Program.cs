namespace _7._2_Параметризованные_конструкторы._11.Множество_конструкторов
{
    public class MyClass
    {
        public MyClass(string st)
        {}
        public MyClass(string st, int i)
        { }
        public MyClass(string st, int i, bool b)
        { }
    }

    internal class Program
    {
        static void Main(string[] args)
        {
            MyClass m1 = new MyClass("test");
            MyClass m2 = new MyClass("test2", 4);
            MyClass m3 = new MyClass("test3", 4, false);
        }
    }
}
