using System;
namespace Lab1Norm
{
    public class Triangle
    {
        int angleAC, angleAB, angleBC, a, b, c;

        const double PI = 3.14;

        double? _area = null;
        double? _semiperimeter = null;


        public int Perimeter
        {
            get => a + b + c;
        }

        double Semiperimeter
        {
            get
            {
                if (_semiperimeter.HasValue) return _semiperimeter.Value;
                _semiperimeter = Perimeter / 2;
                return _semiperimeter.Value;
            }
        }

        public double Area
        {
            get
            {
                if (_area.HasValue) return _area.Value;
                _area = Math.Sqrt(Semiperimeter * (Semiperimeter - a) * (Semiperimeter - b) * (Semiperimeter - c));
                return _area.Value;
            }
        }

        public Triangle(int angleAC, int angleAB, int angleBC, int a, int b, int c)
        {
            this.angleAC = angleAC;
            this.angleAB = angleAB;
            this.angleBC = angleBC;
            this.a = a;
            this.b = b;
            this.c = c;
        }

        public double getInscribedCircleArea() //площадь вписанной окружности
        {
            double radius = Area / Semiperimeter;
            return PI * radius * radius;
        }

        public TriangleAngleTypes getTriangleTypeByAngles()
        {
            if (angleAC < 90.0 && angleAB < 90.0 && angleBC < 90.0)
                return TriangleAngleTypes.Acute;
            if (angleAC > 90.0 || angleAB > 90.0 || angleBC > 90.0)
                return TriangleAngleTypes.Obtuse;
            return TriangleAngleTypes.Right;
        }

        public TriangleSideTypes getTriangleTypeBySides()
        {
            if (a == b && b == c)
                return TriangleSideTypes.Equilateral;
            if (a == b || a == c || b == c)
                return TriangleSideTypes.Isosceles;
            return TriangleSideTypes.Scalene;
        }

        public double getCircumcircleCircleArea() //площадь описанной окружности
        {
            double radius = a * b * c / (4 * Area);
            return PI * radius * radius;
        }
    }
}
