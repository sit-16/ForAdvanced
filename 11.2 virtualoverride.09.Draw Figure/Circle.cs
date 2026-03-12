namespace CSharpEsentials2dEditor
{
    public sealed class Circle : Figure
    {
        public double Radius { get; set; }
        public Point Center { get; set; }
        public Circle(int layer, string edgeColor, double edgeThickness, string fillColor, Point center, double radius) : base(layer, edgeColor, edgeThickness, fillColor)
        {
            Center = center;
            Radius = radius;
        }

        public override void Draw()
        {
            base.Draw();
            Console.WriteLine($"Окружность радиуса {Radius} с центром X:{Center.X_Position} Y:{Center.Y_Position}");
        }
    }
}
