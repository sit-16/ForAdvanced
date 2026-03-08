namespace CSharpEsentials2dEditor
{
    public sealed class Edge : Figure
    {
        public Point FirstPoint { get; set; }
        public Point SecondPoint { get; set; }
        public string FillColor { get; } = "чёрный";
    }
}
