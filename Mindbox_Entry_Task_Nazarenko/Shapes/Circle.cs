using System.Runtime.CompilerServices;

[assembly: InternalsVisibleTo("Mindbox_Entry_Task_NazarenkoTests")]
namespace Mindbox_Entry_Task_Nazarenko.Shapes
{
    internal class Circle
    {
        /// <summary>
        /// Calculate area of a circle by radius
        /// </summary>
        /// <param name="r">Radius</param>
        /// <returns>Area of a circle</returns>
        internal static double Calculate(double r) => r > 0 ? Math.Round(Math.PI * r * r, 2) : 0;
    }
}
