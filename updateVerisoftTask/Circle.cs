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




/*enter A for circle or B for rectangle
A
enter a radius
4
enter a color
green
enter  1 for fiiled 0 for not filled
1
enter A for circle or B for rectangle
B
enter a width
3
enter a length
2
enter a color
red
enter  1 for fiiled 0 for not filled
0
A Circle with radius  of 4  which is a subclass of A shape with color pf green and filled
 perimeter : 25.132741228718345
 area: 50.26548245743669
A rectangle with width :3 and length:2 which is a subclass of A shape with color pf red and  not filled
 perimeter : 10
 area: 6*/