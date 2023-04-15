using ShapeCharacteristics.Shapes.ShapeBasedRecords;

namespace ShapeCharacteristics.Shapes.interfaces
{
    internal interface IShape
    {
        Shape CalculateShapeParameters<T>(T shapeInputArgs);

    }
}
