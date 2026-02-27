namespace _9._3_Свойства._05.Добавляем_свойство
{
    internal class Program
    {
        public class MyClass
        {
            private int field;
            public int Property
            {
                get { return field; }
                set { field = value; }
            }
        }
        static void Main(string[] args)
        {
            MyClass instance = new MyClass();
            instance.Property = 14;
            Console.WriteLine(instance.Property);
        }
    }
}
