using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SolidPrinciples
{
    public class RectangleGeometry
    {
        public double width, height;
        public double CalculateRectangleArea()
        {
            return width + height;
        }
    }

    public class AdvanceRectangleGeometry : RectangleGeometry
    { 
        public double CalculatePerimeter()
        {
            return 2 * (width + height);
        }
    }
}
