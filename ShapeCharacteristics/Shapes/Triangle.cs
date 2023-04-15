using ShapeCharacteristics.Constants;
using ShapeCharacteristics.Shapes.interfaces;
using ShapeCharacteristics.Shapes.ShapeBasedRecords;

namespace ShapeCharacteristics.Shapes
{
    internal class Triangle : IShape
    {
        private string GetName(double sideA, double sideB, double sideC)
        {
            if (sideA == sideB && sideB == sideC)
            {
                return Contants.EquilateralTriangle;
            }
            else if (sideA == sideB || sideA == sideC || sideB == sideC)
            {
                return Contants.IsoscelesTriangle;
            }
            else
            {
                return Contants.Triangle;
            }
        }

        //clarity needed on req. need to check with PO for correctness
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

                double p = (triangleInputData.sideA + triangleInputData.baseB + triangleInputData.sideC) / 2;
                double height = 2 * Math.Sqrt(p * (p - triangleInputData.sideA) * (p - triangleInputData.baseB) * (p - triangleInputData.sideC)) / triangleInputData.baseB;
                var area = (height * triangleInputData.baseB) / 2;

                triangleOutputData = new Shape
                (
                    GetName(triangleInputData.sideA, triangleInputData.baseB, triangleInputData.sideC),
                    (triangleInputData.sideA + triangleInputData.baseB + triangleInputData.sideC),
                    (area)
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
