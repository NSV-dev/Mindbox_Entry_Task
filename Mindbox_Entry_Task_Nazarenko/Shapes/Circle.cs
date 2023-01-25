namespace Mindbox_Entry_Task_Nazarenko.Shapes
{
    internal class Circle
    {
        internal static double Calculate(double r) => r > 0 ? Math.Round(Math.PI * r * r, 2) : 0;
    }
}
