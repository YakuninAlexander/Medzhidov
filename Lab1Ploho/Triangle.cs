using System;
namespace Lab1Ploho
{
    public class Triangle
    {
        int a1, a2, a3, s1, s2, s3;


        public Triangle(int a1, int a2, int a3, int s1, int s2, int s3)
        {
            this.a1 = a1;
            this.a2 = a2;
            this.a3 = a3;
            this.s1 = s1;
            this.s2 = s2;
            this.s3 = s3;
        }

        public double sOkr()
        {
            double s = (s1 + s2 + s3) / 2;
            double area = Math.Sqrt(s * (s - s1) * (s - s2) * (s - s3));
            double rOrk = area / s;
            return 3.14 * rOrk * rOrk;
        }

        public string getInfo()
        {
            string info = "";
            if (a1 < 90.0 && a2 < 90.0 && a3 < 90.0)
            {
                info += "Остроугольный треугольник";
            }
            else if (a1 > 90.0 || a2 > 90.0 || a3 > 90.0)
            {
                info += "Тупоугольный треугольник";
            }
            else
            {
                info += "Прямоугольный треугольник";
            }
            double s = (s1 + s2 + s3) / 2;
            double S = Math.Sqrt(s * (s - s1) * (s - s2) * (s - s3));
            info += "\nПлощадь: " + S;
            double p = s1 + s2 + s3;
            info += "\nПериметр: " + p;

            if (s1 == s2 && s2 == s3)
                info += "\nРавносторонний";
            else if (s1 == s2 || s1 == s3 || s2 == s3)
                info += "\nРавнобедренный";
            else
                info += "\nРазносторонний";

            return info;
        }

        public double SOkr()
        {
            double s = (s1 + s2 + s3) / 2;
            double area = Math.Sqrt(s * (s - s1) * (s - s2) * (s - s3));
            double ROkr = (s1 * s2 * s3) / (4 * area);
            return 3.14 * ROkr * ROkr;
        }
    }
}
