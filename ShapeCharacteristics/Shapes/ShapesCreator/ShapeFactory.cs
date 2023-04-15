using ShapeCharacteristics.Shapes.interfaces;
using System.Drawing;

namespace ShapeCharacteristics.Shapes.ShapesCreator
{
    internal class ShapeFactory : IShapeFactory
    {
        Dictionary<string, int> instanceCount = new Dictionary<string, int>();
        private IShape shape;
        public IShape ShapeInstanceCreator(string shapeType)
        {
            switch (shapeType.Trim().ToLower())
            {
                case "circle":
                    shape = new Circle();
                    break;
                case "triangle":
                    shape = new Triangle();
                    break;
                case "square":
                    shape = new Square();
                    break;
                case "rectangle":
                    shape = new Rectangle();
                    break;

                default: throw new ArgumentException("Invalid type", "type");
            }

            if (!instanceCount.TryAdd(shapeType.Trim().ToLower(), 1))
            {
                // key already exists, update its value
                instanceCount[shapeType.Trim().ToLower()] += 1;
            }
            return shape;
        }

        public Dictionary<string, int> GetInstanceDetails()
        {
            return instanceCount;
        }
    }
}
