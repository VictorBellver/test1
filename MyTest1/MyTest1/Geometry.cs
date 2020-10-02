using System;
using System.Collections.Generic;
using System.Text;

namespace MyTest1
{
    class Geometry
    {
        public static double GetVector2Dlength(double x, double y)
        {
            double aux;
            double length;
            aux = x * x + y * y;
            length = Math.Sqrt(aux);
            return length;
        }
        public static double GetVector3Dlength(double x, double y, double z)
        {
            double aux;
            double length;
            aux = x * x + y * y + z * z;
            length = Math.Sqrt(aux);
            return length;
        }
        
        public static double GetCircleArea(double r)
        {
            double aux, pi;
            pi = Math.PI;
            aux = pi * (r * r);
            return aux;

        }

        public static double GetSphereVolume(double r)
        {
            double aux;
            aux = 4.0 * Math.PI * (r * r * r);
            aux = aux / 3.0;
            return aux;

        }

        public static double GetRetangleArea(double height, double width)
        {
            double aux;
            aux = height * width;
            return aux;

        }
    }  
}
