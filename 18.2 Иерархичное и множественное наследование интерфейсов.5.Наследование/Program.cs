namespace _18._2_Иерархичное_и_множественное_наследование_интерфейсов._5.Наследование
{
    public interface IInterfaceA
    { 
        bool Prop1 { get; set; }
        int Prop2 { get; set; }
    }

    public interface IInterfaceB
    {
        string Prop3 { get; set; }
        void Method1 (string param);
    }

    public class MyClass : IInterfaceA, IInterfaceB
    {
        public bool Prop1 { get; set; }
        public int Prop2 { get; set; }
        public string Prop3 { get; set; }
        public void Method1(string param)
        { }
    }
    internal class Program
    {
        static void Main(string[] args)
        {
            IInterfaceA A = new MyClass();
            IInterfaceB B = new MyClass();
            MyClass C = new MyClass();
            
        }
    }
}
