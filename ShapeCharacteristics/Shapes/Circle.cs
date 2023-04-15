using ShapeCharacteristics.Constants;
using ShapeCharacteristics.Shapes.interfaces;
using ShapeCharacteristics.Shapes.ShapeBasedRecords;

namespace ShapeCharacteristics.Shapes
{
    internal class Circle : IShape
    {
        public Shape CalculateShapeParameters<T>(T shapeInputArgs)
        {
            Shape CrlData;

            if (!(shapeInputArgs is CircleParams))
            {
                Console.WriteLine("param type missmatch. Execution incomplete.");
                throw new NotSupportedException();
            }

            try
            {
                var circleParameters = shapeInputArgs as CircleParams;

                CrlData = new Shape
                (
                    Contants.Circle,
                    (2 * Math.PI * circleParameters.Radius),
                    (Math.PI * circleParameters.Radius * circleParameters.Radius)
                );
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.Message);
                throw;
            }

            return CrlData;
        }
    }
}
