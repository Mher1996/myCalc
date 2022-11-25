using System;
using System.Collections.Generic;
using System.Text;

namespace ConsoleCalc
{
    public class CalcPage
    {
        public  double Add(double firstNumber, double secondNumber)
        {
            return firstNumber + secondNumber;
        }
        public  double Subtract(double firstNumber, double secondNumber)
        {
            return firstNumber - secondNumber;
        }
        public double Multiply(double firstNumber, double secondNumber)
        {
            return firstNumber * secondNumber;
        }
        public double Divide(double firstNumber, double secondNumber)
        {
            return firstNumber / secondNumber;
        }
        public   double RaisingPower(double number, int degree)
        {
            double result = 1;
            for (int i = 1; i <= degree; i++)
            {
                if (degree != 0)
                {
                    result = result * number;
                }
                else
                {
                    return 1;
                }
            }

            return result;
        }
        public double PercentOfNumber(double number, double percent)
        {
            return (number * percent) / 100;
        }
    }
}
