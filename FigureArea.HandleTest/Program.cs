using FigureArea;

namespace FigureArea.HandleTest
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Figure figure = new Figure();
            Console.WriteLine(figure.GetFigureInfo("triangle", 60, 40, 50));
            Console.WriteLine(figure.GetFigureInfo("triangle", 7, 10, 13));
            Console.WriteLine(figure.GetFigureInfo("triangle", 20, 15, 25));
            Console.WriteLine(figure.GetFigureInfo("circle", 15));
            Console.WriteLine(figure.GetFigureInfo("asdf", 55));

            // ArgumentException
            Console.WriteLine(figure.GetFigureInfo("triangle", 0, 40, 50));
            Console.WriteLine(figure.GetFigureInfo("triangle", 60, 40, 120));
            Console.WriteLine(figure.GetFigureInfo("circle", 0));
            
        }
    }
}