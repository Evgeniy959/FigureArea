using System.Reflection;

namespace FigureArea
{
    public class Figure
    {
        public Figure() { }

        public string GetFigureInfo(string typeFigure, double param1, double param2 = 0, double param3 = 0)
        {
            var type = Type.GetType($"FigureArea.{typeFigure}", false, true);
            if (type != null)
            {
                var figure = (Figure)Activator.CreateInstance(type);
                MethodInfo info = type.GetMethod("CalcArea");
                object[] param = { param1, param2, param3 };
                var area = info.Invoke(figure, param);
                if (figure is Triangle)
                {
                    MethodInfo infoT = type.GetMethod("IsRectangular");
                    object[] paramT = { param1, param2, param3 };
                    bool isRight = (bool)infoT.Invoke(figure, paramT);
                    if (isRight)
                    {
                        return $"Type: {type.Name}, Площадь = {area}, треугольник прямоугольный";
                    }
                    if (!isRight)
                    {
                        return $"Type: {type.Name}, Площадь = {area}, треугольник непрямоугольный";
                    }
                }
                else return $"Type: {type.Name}, Площадь = {area}";
            }
            return "Неверный тип фигуры";

        }
    }
}