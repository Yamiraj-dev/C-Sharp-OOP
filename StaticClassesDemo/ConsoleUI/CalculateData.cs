using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleUI
{
    public static class CalculateData
    {
        public static double Add(double x, double y) 
        {
            double output = x + y;

            return output;
        }

        public static double Subtract(double x, double y)
        {
            double output = x - y;

            return output;
        }

        public static double Multiply(double x, double y)
        {
            double output = x * y;

            return output;
        }

        public static double Divide(double x, double y)
        {
            double output = x / y;
            if (x == 0 || y == 0)
            {
                output = 0;
            }
            return output;
        }
    }
}

// This all ties with the SOLID principle's S - Single Responsibility Principle
// Each class should do one logical thing, meaning it can have multiple methods but under the same logic of what it does.