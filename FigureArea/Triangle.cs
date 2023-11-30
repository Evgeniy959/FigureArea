using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FigureArea
{
    public class Triangle : Figure
    {
        private double[] sides;

        public Triangle() { }

        public double CalcArea(double a, double b, double c)
        {
            CheckException(a, b, c);
            double p = (a + b + c) / 2;
            return Math.Round(Math.Sqrt(p * (p - a) * (p - b) * (p - c)), 3);
        }

        public bool IsRectangular(double a, double b, double c)
        {
            CheckException(a, b, c);
            sides = new double[3] { a, b, c };
            Array.Sort(sides);
            return Math.Pow(sides[0], 2) + Math.Pow(sides[1], 2) == Math.Pow(sides[2], 2);
        }

        public void CheckException(double a, double b, double c)
        {
            if (a <= 0 || b <= 0 || c <= 0)
                throw new ArgumentException("Длина стороны должна быть положительным числом");
            else if (a + b < c || b + c < a || a + c < b)
                throw new ArgumentException("Стороны не образуют треугольник");
        }
    }
}
