using ShapeCharacteristics.Shapes.interfaces;
using ShapeCharacteristics.Shapes.ShapeBasedRecords;

namespace ShapeCharacteristics.Shapes
{
    internal class Triangle : IShape
    {

        public Shape CalculateShapeParameters<T>(T shapeInputArgs)
        {
            Shape triangleOutputData;

            if (!(shapeInputArgs is TriangleParams))
            {
                Console.WriteLine("param type missmatch. Execution incomplete.");
                throw new NotSupportedException();
            }

            try
            {
                var triangleInputData = shapeInputArgs as TriangleParams;

                triangleOutputData = new Shape
                (
                    "Triangle",
                    (triangleInputData.Base + triangleInputData.Height +
                    Math.Sqrt(triangleInputData.Base * triangleInputData.Base + triangleInputData.Height * triangleInputData.Height)),
                    (triangleInputData.Base * triangleInputData.Height / 2)
                );
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.Message);
                throw;
            }

            return triangleOutputData;
        }
    }
}
