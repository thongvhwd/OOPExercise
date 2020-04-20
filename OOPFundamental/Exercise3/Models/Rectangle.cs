namespace Exercise3.Models
{
    public class Rectangle : Shape
    {
        public override double CalculateSurface()
        {
            return Width * Height;
        }
    }
}
