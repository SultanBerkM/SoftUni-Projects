using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Shapes
{
    public class Rectangle : Shape
    {
        private double height;
        private double width;

        public Rectangle(double width, double height)
        {
           
            Width = width;
            Height = height;
        }

        public double Width
        {
            get { return width; }
            private set { width = value; }
        }

        public double Height
        {
            get { return height; }
            private set { height = value; }
        }

        public override double CalculateArea()
        {
            return 2 * this.Width + 2 * this.Height;
        }

        public override double CalculatePerimeter()
        {
            return this.Width * this.Height;
        }

        public override string Draw()
        {
            return base.Draw();
        }
    }
}
