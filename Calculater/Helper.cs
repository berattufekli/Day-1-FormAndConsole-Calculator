using System;
using System.Collections.Generic;
using System.Text;

namespace Calculator
{
    static public class Helper
    {
   
        static public double Plus(double mum1, double num2)
        {
            return mum1 + num2;
        }

        static public double Minus(double mum1, double num2)
        {
            return mum1 - num2;
        }


        static public double Multiply(double mum1, double num2)
        {
            return mum1 * num2;
        }

        static public double Divide(double mum1, double num2)
        {
            return mum1 / num2;
        }

        static public double Pow(double num1, double num2)
        {
            return Math.Pow(num1, num2);
        }

        static public double Sqrt(double num1)
        {
            return Math.Sqrt(num1);
        }
    }
}