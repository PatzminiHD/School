using _240126_Lib_Inherit;

namespace _240209_Use_Lib_Vererbung
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Interpolate interpolate = new Interpolate()
            {
                X1 = 1,
                X2 = 3,
                Y1 = 1,
                Y2 = 3,
                X = 2,
            };

            Console.WriteLine($"Slope:     {interpolate.CalcSlope()}");
            Console.WriteLine($"Intersect: {interpolate.intercept()}");
            Console.WriteLine($"Y:         {interpolate.Y()}");
        }
    }
}