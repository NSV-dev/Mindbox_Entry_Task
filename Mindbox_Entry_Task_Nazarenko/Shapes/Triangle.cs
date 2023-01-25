namespace Mindbox_Entry_Task_Nazarenko.Shapes
{
    internal class Triangle
    {
        internal static double Calculate(double a, double b, double c)
        {
            if (a <= 0 || b <= 0 || c <= 0)
                return 0;
            if (!IsTriangle(a, b, c))
                return 0;

            double p = (a + b + c) / 2;
            return Math.Round(Math.Sqrt(p * (p - a) * (p - b) * (p - c)), 2);
        }

        public static bool IsRight(double a, double b, double c)
        {
            if (a <= 0 || b <= 0 || c <= 0)
                return false;
            if (!IsTriangle(a, b, c))
                return false;

            if (a > c)
                (a, c) = (c, a);
            if (b > c)
                (b, c) = (c, b);

            return a * a + b * b == c * c;
        }

        private static bool IsTriangle(double a, double b, double c)
            => (a + b > c) && (a + c > b) && (b + c > a);
    }
}
