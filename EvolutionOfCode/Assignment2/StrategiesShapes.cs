using System;
using System.Collections.Generic;

namespace EvolutionOfCode.Assignment2_2
{
    public interface IPerimeterCalculationStrategy
    {
        public double Execute();
    }

    public class SquarePerimeterCalculationStrategy : IPerimeterCalculationStrategy
    {
        private readonly Square _square;

        public SquarePerimeterCalculationStrategy(Square square)
        {
            _square = square;
        }

        public double Execute()
        {
            return _square.Side * 4.0;
        }
    }

    public class RectanglePerimeterCalculationStrategy : IPerimeterCalculationStrategy
    {
        private readonly Rectangle _rectangle;

        public RectanglePerimeterCalculationStrategy(Rectangle rectangle)
        {
            _rectangle = rectangle;
        }

        public double Execute()
        {
            return _rectangle.Height * 2.0 + _rectangle.Length * 2.0;
        }
    }

    public class CirclePerimeterCalculationStrategy : IPerimeterCalculationStrategy
    {
        private readonly Circle _circle;

        public CirclePerimeterCalculationStrategy(Circle circle)
        {
            _circle = circle;
        }

        public double Execute()
        {
            return 2.0 * Math.PI * _circle.Radius;
        }
    }

    public class PerimeterCalculationFactory
    {
        public IPerimeterCalculationStrategy GetStrategy(IShape shape)
        {
            return shape switch
            {
                Square square => new SquarePerimeterCalculationStrategy(square),
                Rectangle triangle => new RectanglePerimeterCalculationStrategy(triangle),
                Circle circle => new CirclePerimeterCalculationStrategy(circle),
                _ => throw new Exception("No shape has been found")
            };
        }
    }

    public interface IShape
    {

    }

    public class Square : IShape
    {
        public double Side { get; set; }
    }

    public class Rectangle : IShape
    {
        public double Height { get; set; }
        public double Length { get; set; }
    }

    public class Circle : IShape
    {
        public double Radius { get; set; }
    }

    public class StrategiesShapes
    {
        public List<double> Run()
        {
            var triangle = new Rectangle
            {
                Height = 2.0,
                Length = 5.0
            };

            var square = new Square
            {
                Side = 3.0
            };

            var circle = new Circle
            {
                Radius = 2.0
            };

            var factory = new PerimeterCalculationFactory();

            var shapes = new List<IShape>
            {
                triangle,
                square,
                circle
            };

            var retVal = new List<double>();

            foreach (var shape in shapes)
            {
                retVal.Add(factory.GetStrategy(shape).Execute());
            }

            return retVal;
        }
    }
}