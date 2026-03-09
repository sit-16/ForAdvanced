namespace CSharpEsentials2dEditor
{
    public class Figure
    {
        public int Layer { get; set; }
        public string EdgeColor { get; set; } = "чёрный";
        public double EdgeThickness { get; set; } = 1;
        public string FillColor { get; set; } = "белый";
        public Figure(int layer, string edgeColor, double edgeThickness, string fillColor)
        {
            Layer = layer;
            EdgeColor = edgeColor;
            EdgeThickness = edgeThickness;
            FillColor = fillColor;
        }
    }
}
