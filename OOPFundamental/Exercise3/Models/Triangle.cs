namespace Exercise3.Models
{
    public class Triangle : Shape
    {
        public override double CalculateSurface()
        {
            return Width * Height / 2;
        }
    }
}
