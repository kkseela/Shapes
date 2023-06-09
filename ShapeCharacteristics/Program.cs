﻿using ShapeCharacteristics.Constants;
using ShapeCharacteristics.SerializationDeSerialization.Binary;
using ShapeCharacteristics.SerializationDeSerialization.JSON;
using ShapeCharacteristics.SerializationDeSerialization.XML;
using ShapeCharacteristics.Shapes.interfaces;
using ShapeCharacteristics.Shapes.ShapeBasedRecords;
using ShapeCharacteristics.Shapes.ShapeComparer;
using ShapeCharacteristics.Shapes.ShapesCreator;
using System.Collections.Immutable;

namespace ShapeCharacteristics
{
    internal class Program
    {
        static void Main(string[] args)
        {
            List<Shape> shapeList = new List<Shape>();
            IShapeFactory _shapeFactory; //IShapeFactoryInstance cnt;
            _shapeFactory = new ShapeFactory();

            ImmutableSortedDictionary<double, Shape> _sd;


            Console.WriteLine("Shape is Circle");
            var circle = _shapeFactory.ShapeInstanceCreator("circle"); //new Circle();
            var circleOutput = circle.CalculateShapeParameters(new CircleParams(20.2));
            Console.WriteLine($"{Contants.ResultOfShape}\n {circleOutput.Name} \n {Contants.PerimeterOfShape} {circleOutput.Perimeter} \n {Contants.SurfaceAreaOfShape} {circleOutput.SurfaceArea}");
            shapeList.Add(circleOutput);

            Console.WriteLine("Shape belongs to Triangle");
            var triangle = _shapeFactory.ShapeInstanceCreator("triangle"); //new Triangle();
            var triangleOutput = triangle.CalculateShapeParameters(new TriangleParams(20.2, 40, 20.4));
            Console.WriteLine($"{Contants.ResultOfShape}\n {triangleOutput.Name} \n {Contants.PerimeterOfShape} {triangleOutput.Perimeter} \n {Contants.SurfaceAreaOfShape} {triangleOutput.SurfaceArea}");
            shapeList.Add(triangleOutput);

            Console.WriteLine("Shape belongs to Triangle");
            var triangle1 = _shapeFactory.ShapeInstanceCreator("triangle"); //new Triangle();
            var triangleOutput1 = triangle1.CalculateShapeParameters(new TriangleParams(20.4, 40, 20.4));
            Console.WriteLine($"{Contants.ResultOfShape}\n {triangleOutput1.Name} \n {Contants.PerimeterOfShape} {triangleOutput1.Perimeter} \n {Contants.SurfaceAreaOfShape} {triangleOutput1.SurfaceArea}");
            shapeList.Add(triangleOutput1);

            Console.WriteLine("Shape belongs to Triangle");
            var triangle2 = _shapeFactory.ShapeInstanceCreator("triangle"); //new Triangle();
            var triangleOutput2 = triangle2.CalculateShapeParameters(new TriangleParams(20, 20, 20));
            Console.WriteLine($"{Contants.ResultOfShape}\n {triangleOutput2.Name} \n {Contants.PerimeterOfShape} {triangleOutput2.Perimeter} \n {Contants.SurfaceAreaOfShape} {triangleOutput2.SurfaceArea}");
            shapeList.Add(triangleOutput2);

            Console.WriteLine("Shape is Square");
            var square = _shapeFactory.ShapeInstanceCreator("square"); //new Square();
            var squareOutput = square.CalculateShapeParameters(new SquareParams(40));
            Console.WriteLine($"{Contants.ResultOfShape}\n {squareOutput.Name} \n {Contants.PerimeterOfShape} {squareOutput.Perimeter} \n {Contants.SurfaceAreaOfShape} {squareOutput.SurfaceArea}");
            shapeList.Add(squareOutput);

            Console.WriteLine("Shape is Rectangle");
            var rectangle = _shapeFactory.ShapeInstanceCreator("Rectangle"); //new Rectangle();
            var rectangleOutput = rectangle.CalculateShapeParameters(new RectangleParams(20.2, 40));
            Console.WriteLine($"{Contants.ResultOfShape}\n {rectangleOutput.Name} \n {Contants.PerimeterOfShape} {rectangleOutput.Perimeter} \n {Contants.SurfaceAreaOfShape} {rectangleOutput.SurfaceArea}");
            shapeList.Add(rectangleOutput);

            Console.WriteLine("Shape is based on input");
            var unknown = _shapeFactory.ShapeInstanceCreator("square"); //new Rectangle();
            var unknownOutput = unknown.CalculateShapeParameters(new RectangleParams(40, 40));
            Console.WriteLine($"{Contants.ResultOfShape} \n {unknownOutput.Name} \n {Contants.PerimeterOfShape} {unknownOutput.Perimeter} \n {Contants.SurfaceAreaOfShape} {unknownOutput.SurfaceArea}");
            shapeList.Add(unknownOutput);

            Console.WriteLine("\n\n\t\t **************** Shape Instance Count *************************** ");
            Console.WriteLine($"\n Total instance count is: {_shapeFactory.GetInstanceDetails().Values.Sum()}\n");
            foreach (var output in _shapeFactory.GetInstanceDetails())
            {
                Console.WriteLine($" {output.Key} instances: {output.Value}");
                Console.WriteLine("\n");
            }


            Console.WriteLine("If you want list of shapes to be sorted by {S} SurfaceArea or {P} Perimeter");
            ConsoleKeyInfo keyInfo;
            do
            {
                Console.WriteLine("\nChoose S/P:");
                keyInfo = Console.ReadKey();
            } while (keyInfo.Key != ConsoleKey.S && keyInfo.Key != ConsoleKey.P);

            ShapeComparer comparer = new ShapeComparer();
            if (keyInfo.Key == ConsoleKey.S)
            {                
                comparer.SortByProperty = ShapeComparer.SortBy.SurfaceArea;
                shapeList.Sort(comparer);
                //Alternate for Icomparer implementation to sort a collection.
                _sd = shapeList.ToImmutableSortedDictionary(s => s.SurfaceArea, s => s);
            }
            else
            {
                comparer.SortByProperty = ShapeComparer.SortBy.Perimeter;
                shapeList.Sort(comparer);
                //Alternate for Icomparer implementation to sort a collection.
                _sd = shapeList.ToImmutableSortedDictionary(s => s.Perimeter, s => s);
            }


            string xmlPath = Path.Combine(Environment.CurrentDirectory, $"Resources\\{Contants.XMLFileName}");
            string jsonPath = Path.Combine(Environment.CurrentDirectory, $"Resources\\{Contants.JsonFileName}");
            string binaryPath = Path.Combine(Environment.CurrentDirectory, $"Resources\\{Contants.BinaryFileName}");


            IFormatFactory factory = new XmlFactory();
            IWriter writer = factory.CreateWriter();
            writer.Write(_sd.Values.ToList(), xmlPath);
            //writer.Write(shapeList, xmlPath);


            //IFormatFactory factory = new XmlFactory();
            IReader reader = factory.CreateReader();
            var xmlData = reader.Read<List<Shape>>(xmlPath);

            factory = new JsonFactory();
            writer = factory.CreateWriter();
            writer.Write(_sd.Values.ToList(), jsonPath);
            //writer.Write(shapeList, jsonPath);

            reader = factory.CreateReader();
            var jsonData = reader.Read<List<Shape>>(jsonPath);

            factory = new BinaryFactory();
            writer = factory.CreateWriter();
            writer.Write(_sd.Values.ToList(), binaryPath);
            //writer.Write(shapeList, binaryPath);

            reader = factory.CreateReader();
            var binaryData = reader.Read<List<Shape>>(binaryPath);

            Console.WriteLine("\n\n\t\t **************** Xml Data *************************** ");
            foreach (var output in xmlData)
            {
                Console.WriteLine($"{Contants.ResultOfShape}\n {output.Name} \n {Contants.PerimeterOfShape} {output.Perimeter} \n {Contants.SurfaceAreaOfShape} {output.SurfaceArea}");
                Console.WriteLine("\n");
            }

            Console.WriteLine("\n\n\t\t **************** Json Data *************************** ");
            foreach (var output in jsonData)
            {
                Console.WriteLine($"{Contants.ResultOfShape}\n {output.Name} \n {Contants.PerimeterOfShape} {output.Perimeter} \n {Contants.SurfaceAreaOfShape} {output.SurfaceArea}");
                Console.WriteLine("\n");
            }

            Console.WriteLine("\n\n\t\t **************** Binary Data *************************** ");
            foreach (var output in binaryData)
            {
                Console.WriteLine($"{Contants.ResultOfShape}\n {output.Name} \n {Contants.PerimeterOfShape} {output.Perimeter} \n {Contants.SurfaceAreaOfShape} {output.SurfaceArea}");
                Console.WriteLine("\n");
            }

        }

    }
}