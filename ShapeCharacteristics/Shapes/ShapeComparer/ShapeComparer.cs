using ShapeCharacteristics.Shapes.ShapeBasedRecords;

namespace ShapeCharacteristics.Shapes.ShapeComparer
{
    internal class ShapeComparer : IComparer<Shape>
    {
        public enum SortBy { SurfaceArea, Perimeter }

        public SortBy SortByProperty { get; set; }

        public int Compare(Shape shape1, Shape shape2)
        {
            if (SortByProperty == SortBy.SurfaceArea)
            {
                return shape1.SurfaceArea.CompareTo(shape2.SurfaceArea);
            }
            else
            {
                return shape1.Perimeter.CompareTo(shape2.Perimeter);
            }
        }
    }
}
