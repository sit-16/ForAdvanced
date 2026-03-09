//using System.Drawing;

namespace CSharpEsentials2dEditor
{


    internal class Program
    {
        static void Main(string[] args)
        {
            /*
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

            // 11 Многоугольник
            Polygon polygon = new Polygon();

            polygon.Layer = 0;
            polygon.EdgeThickness = 2.4;
            polygon.EdgeColor = "красный";
            polygon.FillColor = "белый";

            polygon.Points = new List<Point>() {
                new Point() {
                    X_Position = 5.6,
                    Y_Position = 3.4
                }, new Point(){
                    X_Position = 6.7,
                    Y_Position = 2.4
                }, new Point() {
                    X_Position = 5.1,
                    Y_Position = 2.4
                },new Point() {
                    X_Position = 2.2,
                    Y_Position = 7.1
                }
            };
            foreach (Point p in polygon.Points)
            {
                Console.WriteLine($"X:{p.X_Position} Y:{p.Y_Position}");
            }
            Console.WriteLine($"Слой:{polygon.Layer}, Цвет границ:{polygon.EdgeColor}, Толщина границ: {polygon.EdgeThickness}, Цвет заливки:{polygon.FillColor}");
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
            */
            /*
            var edge = new Edge(1, "красный", 2, "белый", new Point(0, 0), new Point(10, 10));
            var circle = new Circle(2, "синий", 1.5, "жёлтый", new Point(5, 5), 10);
            var polygon = new Polygon(3, "зелёный", 1, "серый", new List<Point> { new Point(0, 0), new Point(5, 0), new Point(5, 5), new Point(0, 5) });

            Console.WriteLine($"{edge.Layer}, {edge.EdgeColor}, {edge.EdgeThickness}, {edge.FillColor}");
            Console.WriteLine($"{circle.Layer}, {circle.EdgeColor}, {circle.EdgeThickness}, {circle.FillColor}");
            Console.WriteLine($"{polygon.Layer}, {polygon.EdgeColor}, {polygon.EdgeThickness}, {polygon.FillColor}");
            */
            Circle circle = new Circle(2, "red", 1, "white", new Point(3, 5), 4);
            Edge edge = new Edge(0, "black", 5.6, "black", new Point(1, 2), new Point(5, -4));
            Polygon polygon = new Polygon(3, "blue", 6.7, "green", new List<Point> { new Point(2, 3), new Point(5, 6), new Point(4, 5) });
            Edge edge2 = new Edge(1, "black", 7.8, "black", new Point(2, 3), new Point(4, -6));
            Circle circle2 = new Circle(9, "yellow", 3, "black", new Point(1, 7), 6);

            Figure nearestFigure = FindNearestFigure(new Figure[] { circle, edge, polygon, edge2, circle2 });

            Console.WriteLine($"Слой:{nearestFigure.Layer}, Цвет границ:{nearestFigure.EdgeColor}, Толщина границ:{nearestFigure.EdgeThickness}, Цвет заливки:{nearestFigure.FillColor}");
        }
        public static Figure FindNearestFigure(Figure[] figures)
        {
            Figure resultFigure = figures[0];
            int maxLayer = figures[0].Layer;
            foreach (Figure f in figures)
            {
                if(f.Layer > maxLayer)
                    resultFigure = f;
            }
            return resultFigure;
        }

    }
}
