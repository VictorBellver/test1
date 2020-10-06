using System;
using System.Collections.Generic;
using System.Security.Cryptography.X509Certificates;
using System.Text;

namespace MyTest1
{
    class Utils
    {
        public static int GetMinValue(int a, int b)
        {
            if (a < b)
            {

                return a;

            }
            else
            {

                return b;

            }
        }
        public static int GetMaxValue(int a, int b)
        {
             if (a > b)
             {

                return a;

             }
             else
             {

                return b;

             }
        }
        
        public static bool IsEven(int value)
        {
            if ((value % 2) == 0)
                return true;
            else
                return false;
        }


    }   
}
