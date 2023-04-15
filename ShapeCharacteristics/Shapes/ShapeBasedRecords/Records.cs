namespace ShapeCharacteristics.Shapes.ShapeBasedRecords
{
    // To support different format serialization Shape record has been modified based on requirement
    //public record Shape(string Name, double Perimeter, double SurfaceArea)

    [Serializable]
    public record Shape(string Name, double Perimeter, double SurfaceArea)
    {
        public Shape() : this(default!, default!, default!) { }
    }
    public record CircleParams(double Radius);

    //public record TriangleParams(double Base, double Height);
    public record TriangleParams(double sideA, double baseB, double sideC);
    public record SquareParams(double Sides);
    public record RectangleParams(double Sides, double Length) : SquareParams(Sides);
}
