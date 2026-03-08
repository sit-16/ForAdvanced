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


    public sealed class Circle : Figure
    {
        public double Radius { get; set; }
        public Point Center { get; set; }
    }

    public sealed class Edge : Figure
    {
        public Point FirstPoint { get; set; }
        public Point SecondPoint { get; set; }
        public string FillColor { get; } = "чёрный";
    }


    internal class Program
    {
        static void Main(string[] args)
        {
            // 06 Фигура
            Figure figure = new Figure();
            figure.Layer = 1;
            Console.WriteLine($"Слой:{figure.Layer}, Цвет границ:{figure.EdgeColor}, Толщина границ: {figure.EdgeThickness}, Цвет заливки:{figure.FillColor}");

            figure.EdgeThickness = 3.4;
            figure.EdgeColor = "красный";
            figure.FillColor = "зелёный";
            Console.WriteLine($"Слой:{figure.Layer}, Цвет границ:{figure.EdgeColor}, Толщина границ: {figure.EdgeThickness}, Цвет заливки:{figure.FillColor}");

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
            Console.WriteLine($"Радиус:{circle.Radius}, X:{circle.Center.X_Position} Y: {circle.Center.Y_Position}");
            Console.WriteLine($"Слой:{circle.Layer}, Цвет границ:{circle.EdgeColor}, Толщина границ: {circle.EdgeThickness}, Цвет заливки:{circle.FillColor}");

            //09 Отрезок
            Edge edge = new Edge();
            edge.FirstPoint = new Point()
            {
                X_Position = 2.3,
                Y_Position = 3.5
            };
            edge.SecondPoint = new Point()
            {
                X_Position = 3.5,
                Y_Position = 7.3
            };
            edge.Layer = -4;
            edge.EdgeThickness = 7.2;
            edge.EdgeColor = "красный";

            Console.WriteLine($"X:{edge.FirstPoint.X_Position} Y:{edge.FirstPoint.Y_Position}");
            Console.WriteLine($"X:{edge.SecondPoint.X_Position} Y:{edge.SecondPoint.Y_Position}");
            Console.WriteLine($"Слой:{edge.Layer}, Цвет границ:{edge.EdgeColor}, Толщина границ: {edge.EdgeThickness}, Цвет заливки:{edge.FillColor}");

            // 10 Вертикальные отрезки
            Edge[] edges = new Edge[]
            {
                new Edge()
                {
                    FirstPoint = new Point()
                    {
                        X_Position = 4.5,
                        Y_Position = 3.6
                    },
                    SecondPoint = new Point()
                    {
                        X_Position = 7.3,
                        Y_Position = 2.4
                    }
                },
                new Edge()
                {
                    FirstPoint = new Point()
                    {
                        X_Position = 1.8,
                        Y_Position = 2.1
                    },
                    SecondPoint = new Point()
                    {
                        X_Position = 1.8,
                        Y_Position = 6.5
                    }
                },
                new Edge()
                {
                    FirstPoint = new Point()
                    {
                        X_Position = 5.6,
                        Y_Position = 7.8
                    },
                    SecondPoint = new Point()
                    {
                        X_Position = 9.1,
                        Y_Position = 3.4
                    }
                },
                new Edge()
                {
                    FirstPoint = new Point()
                    {
                        X_Position = 3.2,
                        Y_Position = 4.5
                    },
                    SecondPoint = new Point()
                    {
                        X_Position = 3.2,
                        Y_Position = 1.6
                    }
                }
            };

            ShowVerticalEdges(edges);
        }
        public static void ShowVerticalEdges(Edge[] edges)
        {
            foreach (Edge edge in edges)
            {
                if (edge.FirstPoint.X_Position == edge.SecondPoint.X_Position)
                {
                    double X1 = edge.FirstPoint.X_Position; double Y1 = edge.FirstPoint.Y_Position;
                    double X2 = edge.SecondPoint.X_Position; double Y2 = edge.SecondPoint.Y_Position;
                    Console.WriteLine($"{X1} {Y1} {X2} {Y2}");
                }
            }
        }

    }
}
