using System;

namespace Lab1Norm
{
    class Program
    {
        public static void printTriangleInfo(Triangle t)
        {
            string info = "";
            var angleType = t.getTriangleTypeByAngles();
            var sideType = t.getTriangleTypeBySides();
            
            if (angleType == TriangleAngleTypes.Acute)
                info += "Остроугольный треугольник";
            else if (angleType == TriangleAngleTypes.Obtuse)
                info += "Тупоугольный треугольник";
            else
                info += "Прямоугольный треугольник";

            info += "\nПлощадь: " + t.Area;
            info += "\nПериметр: " + t.Perimeter;

            if (sideType == TriangleSideTypes.Equilateral)
                info += "\nРавносторонний";
            else if (sideType == TriangleSideTypes.Isosceles)
                info += "\nРавнобедренный";
            else
                info += "\nРазносторонний";

            Console.WriteLine(info);
            Console.WriteLine(t.getInscribedCircleArea());
            Console.WriteLine(t.getCircumcircleCircleArea());
        }

        static void Main(string[] args)
        {
            Triangle t = new Triangle(37, 53, 90, 3, 4, 5);
            printTriangleInfo(t);
        }
    }
}
