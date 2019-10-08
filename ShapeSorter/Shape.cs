using System;

namespace ShapeSorter
{
    public class Shape : IComparable
    {
        protected internal double _area;

        public int CompareTo(object obj)
        {
            if (obj == null) return 1;
            Shape otherShape = obj as Shape;
            if (otherShape != null)
                return this._area.CompareTo(otherShape._area);
            else throw new Exception("Object is not a shape");
;        }
    }

    public class Square : Shape {
        public Square(double side)
        { _area = side * side; }
    }
    public class Triangle : Shape {
        public Triangle(double baselength, double height)
        { _area = baselength * (height / 2); }
    }
    public class Circle : Shape {
        public Circle(double radius) {
            _area = (radius*radius) * Math.PI;
        }
    }
    public class Rectangle : Shape {
        public Rectangle(double width, double height) {
            _area = width * height;
        }
    }
    public class CustomShape : Shape {
        public CustomShape (double area) {
            _area = area;
        }
    }


}
