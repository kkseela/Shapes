using ShapeCharacteristics.Constants;
using ShapeCharacteristics.Shapes.interfaces;
using ShapeCharacteristics.Shapes.ShapeBasedRecords;

namespace ShapeCharacteristics.Shapes
{
    internal class Square : IShape
    {
        public virtual Shape CalculateShapeParameters<T>(T shapeInputArgs)
        {
            Shape triangleOutputData;

            if (!(shapeInputArgs is SquareParams))
            {
                Console.WriteLine("param type missmatch. Execution incomplete.");
                throw new NotSupportedException();
            }

            try
            {
                var squareInputData = shapeInputArgs as SquareParams;

                triangleOutputData = new Shape
                (
                    Contants.Square,
                    (4 * squareInputData.Sides),
                    (squareInputData.Sides * squareInputData.Sides)
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
