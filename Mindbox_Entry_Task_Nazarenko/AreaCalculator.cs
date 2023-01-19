namespace Mindbox_Entry_Task_Nazarenko
{
    public class AreaCalculator
    {
        public static double CalculateAreaBySides(params double[] sides)
        {
            int sidesQuantity = sides.Length;

            if (sidesQuantity == 1)
                return OneSide(sides[0]);

            if (sidesQuantity == 2)
                return TwoSides(sides[0], sides[1]);

            if (sidesQuantity == 3)
                return ThreeSides(sides);

            return 0;
        }

        private static double OneSide(double r) => Math.PI * r * r;

        private static double TwoSides(double a, double b) => a * b;

        private static double ThreeSides(double[] sides)
        {
            var isRight = IsRight(sides);
            if (isRight.flag)
                return isRight.area;

            double p = (sides[0] + sides[1] + sides[2]) / 2;
            return Math.Sqrt(p * (p - sides[0]) * (p - sides[1]) * (p - sides[2]));
        }

        private static (bool flag, double area) IsRight(double[] sides)
        {
            int maxIndex = MaxIndex(sides);

            List<int> indexes = new() { 0, 1, 2 };
            indexes.Remove(maxIndex);

            double a = sides[indexes[0]];
            double b = sides[indexes[1]];
            double c = sides[maxIndex];

            if (a * a + b * b == c * c)
                return (true, a * b / 2);
            return (false, 0);
        }

        private static int MaxIndex(params double[] doubles)
        {
            double max = -1;
            int res = 0;

            for (int i = 0; i < doubles.Length; i++)
                if (doubles[i] > max)
                {
                    max = doubles[i];
                    res = i;
                }

            return res;
        }
    }
}