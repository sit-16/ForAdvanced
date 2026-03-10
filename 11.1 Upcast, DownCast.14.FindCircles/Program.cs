namespace CSharpEsentials2dEditor
{


    internal class Program
    {
        static void Main(string[] args)
        {
            //Circle circle = new Circle(2, "red", 1, "white", new Point(3, 5), 4);
            //Edge edge = new Edge(0, "black", 5.6, "black", new Point(1, 2), new Point(5, -4));
            //Polygon polygon = new Polygon(3, "blue", 6.7, "green", new List<Point> { new Point(2, 3), new Point(5, 6), new Point(4, 5) });
            //Edge edge2 = new Edge(1, "black", 7.8, "black", new Point(2, 3), new Point(4, -6));
            //Circle circle2 = new Circle(9, "yellow", 3, "black", new Point(1, 7), 6);

            //List<Circle> circles = FindCircles(new Figure[] { circle, edge, polygon, edge2, circle2 });

            //foreach (Circle c in circles)
            //{
            //    Console.WriteLine($"Radius: {c.Radius}");
            //}
            Circle circle = new Circle(5, "r", -1, "d", new Point(3, 5), 4);
            Edge edge = new Edge(0, "t", 5.6, "d", new Point(1, 2), new Point(5, -4));

            Polygon polygon1 = new Polygon(3, "g", 6.5, "p", new List<Point> { new Point(5, 8), new Point(1, 7), new Point(4, 5) });
            Polygon polygon2 = new Polygon(2, "d", 6.7, "y", new List<Point> { new Point(1, -6), new Point(1, 6), new Point(5.6, 6), new Point(4, 7) });
            Polygon polygon = new Polygon(3, "d", 1.7, "k", new List<Point> { new Point(2, 3), new Point(5, 6), new Point(4, 9) });

            Edge edge2 = new Edge(1, "f", 7.8, "r", new Point(2, 3), new Point(4, -6));
            Circle circle2 = new Circle(89, "n", 3, "p", new Point(1, 7), 6);

            Figure[] figures = new Figure[] { circle, edge, circle2, polygon2, polygon, edge2, polygon1 };

            RepaintEdges(figures);
            Console.WriteLine(edge.EdgeColor);
            Console.WriteLine(edge2.EdgeColor);
        }
        public static void RepaintEdges(Figure[] figures)
        {
            foreach (var f in figures)
            {
                Edge edge = f as Edge;
                if (edge != null) edge.EdgeColor = "голубой";
            }
        }

        public static List<Circle> FindCircles_is(Figure[] figures) //DownCasting IS
        {
            var resultCircles = new List<Circle>();
            foreach (var f in figures)
            {
                if (f is Circle) resultCircles.Add((Circle)f);
            }
            return resultCircles;
        }

        public static List<Circle> FindCircles(Figure[] figures) //DownCasting AS
        {
            var resultCircles = new List<Circle>();
            foreach (var f in figures)
            {
                var circ = f as Circle;
                if (circ != null) resultCircles.Add(circ);
            }
            return resultCircles;
        }

        public static Figure FindNearestFigure(Figure[] figures) // UpCasting
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
