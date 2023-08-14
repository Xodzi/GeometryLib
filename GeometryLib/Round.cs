namespace GeometryLib
{
    public class Round : IShape
    {
        public double Radius { get; }

        public Round(double radius)
        {
            Radius = radius;
        }

        public double CalculateArea()
        {
            return Math.PI * Radius * Radius;
        }


    }
}