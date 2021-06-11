using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Calculator
{
    static class CalculatorOperations
    {
        public enum Operation
        {
            Add,
            Substract,
            Multiply,
            Split,
            Percent,
            Sqrt,
            Pow2
        }
        public static double Add(double fnum, double snum)
        {
            return fnum + snum;
        }

        public static double Subtract(double fnum, double snum)
        {
            return fnum - snum;
        }

        public static double Multiply(double fnum, double snum)
        {
            return fnum * snum;
        }

        public static double Split(double fnum, double snum)
        {
            return fnum / snum;
        }

        public static double Percent(double fnum, double snum)
        {
            return Multiply(Split(snum, fnum), 100);
        }

        public static double Sqrt(double num)
        {
            return Math.Sqrt(num);
        }

        public static double Pow2(double num)
        {
            return Math.Pow(num, 2.0);
        }
    }
}
