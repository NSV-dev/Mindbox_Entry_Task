using System.Runtime.CompilerServices;

[assembly: InternalsVisibleTo("Mindbox_Entry_Task_NazarenkoTests")]
namespace Mindbox_Entry_Task_Nazarenko.Shapes
{
    internal class Quadrangle
    {
        /// <summary>
        /// Calculate srea of a quadrangle by it's sides
        /// </summary>
        /// <param name="a">Side A</param>
        /// <param name="b">Side B</param>
        /// <returns>Area of a quadrangle</returns>
        internal static double Calculate(double a, double b) => a > 0 && b > 0 ? Math.Round(a * b, 2) : 0;
    }
}
