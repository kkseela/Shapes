using ShapeCharacteristics.Constants;
using ShapeCharacteristics.Shapes.ShapeBasedRecords;

namespace ShapeCharacteristics.Shapes
{
    internal class Rectangle : Square
    {
        public override Shape CalculateShapeParameters<T>(T shapeInputArgs)
        {
            Shape rectangleOutputData;

            if (!(shapeInputArgs is RectangleParams))
            {
                Console.WriteLine("param type missmatch. Execution incomplete.");
                throw new NotSupportedException();
            }

            try
            {
                var rectangleInputData = shapeInputArgs as RectangleParams;

                if (rectangleInputData.Sides == rectangleInputData.Length)
                {
                    rectangleOutputData = base.CalculateShapeParameters(shapeInputArgs);
                }
                else
                {
                    rectangleOutputData = new Shape
                                                (
                                                    Contants.Rectangle,
                                                    (2 * (rectangleInputData.Sides + rectangleInputData.Length)),
                                                    (rectangleInputData.Sides * rectangleInputData.Length)
                                                );
                }
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.Message);
                throw;
            }

            return rectangleOutputData;
        }
    }
}
