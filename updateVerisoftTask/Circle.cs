using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace updateVerisoftTask 
{
    public class Circle : Shape, GeometricObject
    {
        protected internal double radius;

        public Circle()
        {

            radius = 1.0;
        }
        public Circle(double radius)
        {
            this.radius = radius;
        }
        public Circle(double radius, string color, Boolean filled) : base(color, filled)
        {
            this.radius = radius;

        }
        public double getRadius()
        {
            return radius;

        }
        public void setRadius(double radius)
        {
            this.radius = radius;
        }
        public double getArea()
        {

            return (radius * radius * Math.PI);
        }

        public double getPerimeter()
        {
            return (radius * 2 * Math.PI);
        }
        public override string ToString()
        {
            return $"A Circle with radius  of {radius}  which is a subclass of " + base.ToString();
        }

    }
}




