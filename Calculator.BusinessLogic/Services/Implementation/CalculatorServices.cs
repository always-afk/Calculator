using System;

namespace Calculator.BusinessLogic
{
    public class CalculatorServices : ICalculatorServices
    {
        public CalculatorServices() { }

        public double Add(double fnum, double snum)
        {
            return fnum + snum;
        }

        public double Subtract(double fnum, double snum)
        {
            return fnum - snum;
        }

        public double Multiply(double fnum, double snum)
        {
            return fnum * snum;
        }

        public double Split(double fnum, double snum)
        {
            if (snum == 0)
            {
                return 0;
            }
            return fnum / snum;
        }

        public double Percent(double fnum, double snum)
        {
            return Multiply(Split(snum, fnum), 100);
        }

        public double Sqrt(double num)
        {
            return Math.Sqrt(num);
        }

        public double Pow2(double num)
        {
            return Math.Pow(num, 2.0);
        }
    }
}
