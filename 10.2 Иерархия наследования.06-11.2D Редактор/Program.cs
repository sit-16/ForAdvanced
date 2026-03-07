namespace _10._2_Иерархия_наследования._06_11._2D_Редактор
{
    public class Figure
    {
        public int Layer { get; set; }
        public string EdgeColor { get; set; } = "чёрный";
        public double EdgeThickness { get; set; } = 1;
        public string FillColor { get; set; } = "белый";
    }

    public class Point
    {
        public double X_Position { get; set; }
        public double Y_Position { get; set; }
    }


    public sealed class Circle: Figure
    {
        public double Radius { get; set; }
        public Point Center { get; set; }
    }




    internal class Program
    {
        static void Main(string[] args)
        {
            // 06 Фигура
            Figure figure = new Figure();
            figure.Layer = 1;
            Console.WriteLine($"Слой:{figure.Layer}, Цвет границ:{figure.EdgeColor}, Толщина границ: { figure.EdgeThickness}, Цвет заливки:{ figure.FillColor}");

            figure.EdgeThickness = 3.4;
            figure.EdgeColor = "красный";
            figure.FillColor = "зелёный";
            Console.WriteLine($"Слой:{figure.Layer}, Цвет границ:{figure.EdgeColor}, Толщина границ: { figure.EdgeThickness}, Цвет заливки:{ figure.FillColor}");

            //08 Окружность
            Circle circle = new Circle();
            circle.Radius = 10;
            circle.Center = new Point()
            {
                X_Position = 3.6,
                Y_Position = -2.5
            };
            circle.Layer = 3;
            circle.EdgeThickness = 3.4;
            circle.EdgeColor = "синий";
            circle.FillColor = "зелёный";
            Console.WriteLine($"Радиус:{circle.Radius}, X:{circle.Center.X_Position} Y: { circle.Center.Y_Position}");
            Console.WriteLine($"Слой:{circle.Layer}, Цвет границ:{circle.EdgeColor}, Толщина границ: { circle.EdgeThickness}, Цвет заливки:{ circle.FillColor}");

            //09 Отрезок

        }
    }
}
