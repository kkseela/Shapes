using ShapeCharacteristics.Shapes.ShapeBasedRecords;

namespace ShapeCharacteristics.Shapes.interfaces
{
    internal interface IShapeFactory
    {
        IShape ShapeInstanceCreator(string shapeType);
        Dictionary<string, int> GetInstanceDetails();
    }
}
