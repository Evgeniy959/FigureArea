using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FigureArea
{
    public class Circle : Figure
    {
        public Circle() { }

        public double CalcArea(double a, double b = 0, double c = 0)
        {
            if (a <= 0.0)
                throw new ArgumentException("Указанный радиус не является положительным числом");
            return Math.Round(Math.PI * a * a, 3);
        }
    }
}
