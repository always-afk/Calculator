using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Calculator
{
    static class CalculatorOperations
    {
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
    }
}
