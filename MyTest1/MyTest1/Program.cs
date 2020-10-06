using System;
using System.Dynamic;
using System.Security.Cryptography.X509Certificates;

namespace MyTest1
{
    class Program
    {   
        static void Main(string[] args)
        {
            //Probar las soluciones para cada una de las formulas planteadas y terminar de configurar el puto Visual Studio

            //Prueba Volumen de la esfera
            double spVolume;
            spVolume = Geometry.GetSphereVolume(4.0);

            //Prueba Area Rectangulo
            double recArea;
            recArea = Geometry.GetRetangleArea(2.0, 4.0);

            //Primera clase IfElse
            int minValue;
            minValue = Utils.GetMinValue(8, -12);
            minValue = Utils.GetMinValue(4, 5);

            //Segunda clase IfElse
            int maxValue;
            maxValue = Utils.GetMaxValue(8, -12);

            //Segunda clase IfElse, boleanos
            bool sol;
            sol = Utils.IsEven(7);
            sol = Utils.IsEven(324);

            //Prueba de while
            Ejercicios.Ejercicio1();
            Ejercicios.Ejercicio2(66);
        }
    }
}
