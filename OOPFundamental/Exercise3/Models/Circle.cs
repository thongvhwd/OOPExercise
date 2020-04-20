using System;

namespace Exercise3.Models
{
    public class Circle : Shape
    {
        public override double Width {
            get { return base.Width; }
            set
            {
                base.Width = value;
                base.Height = value;
            }
        }

        public override double Height
        {
            get { return base.Height; }
            set
            {
                base.Height = value;
                base.Width = value;
            }
        }

        public override double CalculateSurface()
        {
            return Math.PI * (Width / 2);
        }
    }
}
