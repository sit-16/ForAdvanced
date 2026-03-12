namespace CSharpEsentials2dEditor
{


    internal class Program
    {
        static void Main(string[] args)
        {
            Figure figure = new Figure(3, "красный", 6.3, "серый");
            figure.Draw();
            Figure circle = new Circle(5, "голубой", -1, "чёрный", new Point(3, 5), 4);
            circle.Draw();
        }
    }
}
