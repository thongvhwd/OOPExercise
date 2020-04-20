using System;

namespace Exercise3.Models
{
    public abstract class Shape
    {
        public virtual double Width { get; set; }
        public virtual double Height { get; set; }
        public virtual double CalculateSurface()
        {
            throw new NotImplementedException();
        }
    }
}
