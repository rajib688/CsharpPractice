using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SolidPrinciple
{

    public class RectangleGeometry  /* Open Closed Desgin principle*/
    {
        public double Width; 
        public double Height;

        public double CalculateRectangleArea()
        {
            return Width* Height;
        }
    }

    public class AdvanceRectangleGeometry : RectangleGeometry /*Open Closed Desgin principle*/
    { 
        public double CalculatePerimeter()
        {
            return 2 * (Width * Height);
        }
    }

    //public class Geometry // Open Closed Desgin principle role violation kore 
    //{
    //    public double CalculateRectangleArea(double width, double height)
    //    {
    //        return width* height;
    //    }

    //    public double CalculateCircleArea(double radius)
    //    {
    //        return Math.PI * radius * radius;
    //    }
    //}

    public class CarProvider  // Open Closed Desgin principle role violation kore 
    {
        public object GetCar(string opition)
        {
            switch(opition)
            {
                case "BMW":
                    return new BMW();
                    break;
                case "Ferari":
                    return new Ferari();
                    break; 
                case "Toyota":
                    return new Toyota();
                    break;
                default:
                    return null;
            }
        }
    }
}
