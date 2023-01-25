using Mindbox_Entry_Task_Nazarenko.Shapes;

namespace Mindbox_Entry_Task_Nazarenko
{
    public class AreaCalculator
    {
        public static double CalculateAreaBySides(params double[] sides)
        {
            int sidesQuantity = sides.Length;

            foreach (var a in sides)
                if (a <= 0)
                    return 0;

            if (sidesQuantity == 1)
                return Circle.Calculate(sides[0]);

            if (sidesQuantity == 2)
                return Quadrangle.Calculate(sides[0], sides[1]);

            if (sidesQuantity == 3)
                return Triangle.Calculate(sides[0], sides[1], sides[2]);

            return 0;
        }
    }
}