using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace updateVerisoftTask
{
    public abstract class Shape
    {
        protected internal string color;
        protected internal Boolean filled;

        public Shape()
        {
            color = "green";
            filled = true;
        }
        public Shape(string color, Boolean filled)
        {
            this.color = color;
            this.filled = filled;
        }
        public string getColor()
        {
            return color;
        }
        public void setColor(string color)
        {
            this.color = color;
        }
        public Boolean isFiiled()
        {
            return filled;
        }
        public void setFiiled(Boolean filled)
        {
            this.filled = filled;
        }

        public override string ToString()
        {
            if (filled)
                return $"A shape with color pf {color} and filled";
            return $"A shape with color pf {color} and  not filled";
        }
    }
}
