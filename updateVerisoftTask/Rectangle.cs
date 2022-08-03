using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace updateVerisoftTask
{
    public class Rectangle : Shape, GeometricObject
    {
        protected internal double width;
        protected internal double length;

        public Rectangle()
        {
            width = 1.0;
            length = 1.0;
        }
        public Rectangle(double width, double length)
        {
            this.width = width;
            this.length = length;
        }
        public Rectangle(double width, double length, string color, Boolean filled) : base(color, filled)
        {
            this.width = width;
            this.length = length;
        }

        public double getWidth()
        {
            return width;
        }
        public void setWidth(double width)
        {
            this.width = width;
        }

        public double getLength()
        {
            return length;
        }
        public void setLength(double length)
        {
            this.length = length;
        }
        public double getArea()
        {
            return (length * width);
        }
        public double getPerimeter()
        {
            return (length * 2 + width * 2);
        }

        public override string ToString()
        {
            return $"A rectangle with width :{width} and length:{length} which is a subclass of " + base.ToString();
        }
    }
}
