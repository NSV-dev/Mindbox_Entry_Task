namespace Mindbox_Entry_Task_Nazarenko
{
    public class AreaCalculator
    {
        public static double CalculateAreaBySides(params double[] sides)
        {
            int sidesQuantity = sides.Length;

            if (sidesQuantity == 1)
                return OneSide(sides[0]);
        }

        private static double OneSide(double r) => Math.PI * r * r;

    }
}