using System;
using System.Collections.Generic;
using System.Text;

namespace MyTest1
{
    class Ejercicios
    {
        //Ejercicio: Hacer una función que imprima por pantalla los numeros del 0 al 99
        //Nunca se debe hacer que una funcion imprima por pantalla salvo que el ejercicio lo pida especificamente
        public static void Ejercicio1()
        {
            int contador = 0;
            while (contador <= 99)
            {
                System.Console.WriteLine(contador);
                contador++;
                //contador++; es lo mismo que contador = contador + 1; y a su vez ambos son lo mismo que contador += 1;
            }
        }
        public static void Ejercicio2(int n)
        {
            int i = 0;
            while (i <= n)
            {
                if (Utils.IsEven(i))
                    System.Console.WriteLine(i);
                i++;
            }
        }
    }  
}       
