using System;
using System.Collections.Generic;

namespace EvolutionOfCode.Assignment2_1
{

    public interface IShape
    {
        public double CalculatePerimeter();
    }

    public class Square : IShape
    {
        private readonly double _side;

        public Square(double side)
        {
            _side = side;
        }

        public double CalculatePerimeter()
        {
            return _side * 4.0;
        }
    }

    public class Rectangle : IShape
    {
        private readonly double _height;
        private readonly double _length;

        public Rectangle(double height, double length)
        {
            _height = height;
            _length = length;
        }

        public double CalculatePerimeter()
        {
            return _height * 2.0 + _length * 2.0;
        }
    }

    public class Circle : IShape
    {
        private readonly double _radius;

        public Circle(double radius)
        {
            _radius = radius;
        }

        public double CalculatePerimeter()
        {
            return 2.0 * Math.PI * _radius;
        }
    }

    public class OOShapes
    {
        public List<double> Run()
        {
            var triangle = new Rectangle(2.0, 5.0);
            var square = new Square(3.0);
            var circle = new Circle(2.0);

            var shapes = new List<IShape>
            {
                triangle,
                square,
                circle
            };

            var retVal = new List<double>();
            
            foreach (var shape in shapes)
            {
                retVal.Add(shape.CalculatePerimeter());
            }

            return retVal;
        }
    }
}