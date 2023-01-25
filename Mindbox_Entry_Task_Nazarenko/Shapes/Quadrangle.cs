using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Mindbox_Entry_Task_Nazarenko.Shapes
{
    internal class Quadrangle
    {
        internal static double Calculate(double a, double b) => a > 0 && b > 0 ? Math.Round(a * b, 2) : 0;
    }
}
