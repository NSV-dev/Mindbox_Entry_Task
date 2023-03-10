using Mindbox_Entry_Task_Nazarenko.Shapes;

namespace Mindbox_Entry_Task_Nazarenko
{
    /// <summary>
    /// Фасад библиотеки, которая умеет вычислять площадь круга по радиусу и треугольника по трем сторонам.
    /// Также может проверить является ли треугольник прямоугольным
    /// </summary>
    /// <remarks>
    /// Для внешнего пользования доступен только этот класс.
    /// Классы Shapes недоступны для внешнего пользования.
    /// </remarks>
    public class AreaCalculator
    {
        /// <summary>
        /// Calculate area of any geometric shape by it's sides
        /// </summary>
        /// <param name="sides">Unlimited number of sides</param>
        /// <returns>Area</returns>
        public static double AreaBySides(params double[] sides)
        {
            foreach (var a in sides)
                if (a <= 0)
                    throw new ArgumentOutOfRangeException("Sides can't be less than zero");

            return sides.Length switch
            {
                1 => Circle.Calculate(sides[0]),
                2 => Rectangle.Calculate(sides[0], sides[1]),
                3 => Triangle.Calculate(sides[0], sides[1], sides[2]),
                _ => throw new Exception("Too much sides")
            };
        }

        /// <summary>
        /// Calculate area of a circle by radius
        /// </summary>
        /// <param name="r">Radius</param>
        /// <returns>Area of a circle</returns>
        public static double CircleArea(double r) 
            => Circle.Calculate(r);

        /// <summary>
        /// Calculate srea of a Rectangle by it's sides
        /// </summary>
        /// <param name="a">Side A</param>
        /// <param name="b">Side B</param>
        /// <returns>Area of a Rectangle</returns>
        public static double RectangleArea(double a, double b) 
            => Rectangle.Calculate(a, b);

        /// <summary>
        /// Calculate area of a triangle by it's sides
        /// </summary>
        /// <param name="a">Side A</param>
        /// <param name="b">Side B</param>
        /// <param name="c">Side C</param>
        /// <returns>Area of a triangle</returns>
        public static double TriangleArea(double a, double b, double c) 
            => Triangle.Calculate(a, b, c);

        /// <summary>
        /// Check if triangle is right
        /// </summary>
        /// <param name="a">Side A</param>
        /// <param name="b">Side B</param>
        /// <param name="c">Side C</param>
        /// <returns>true if triangle is right</returns>
        public static bool IsRiaghtTriangle(double a, double b, double c)
            => Triangle.IsRight(a, b, c);
    }
}