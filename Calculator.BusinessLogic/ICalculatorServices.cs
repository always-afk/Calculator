using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Calculator.BusinessLogic
{
    public interface ICalculatorServices
    {
        public double Add(double fnum, double snum);
        public double Subtract(double fnum, double snum);
        public double Multiply(double fnum, double snum);
        public double Split(double fnum, double snum);
        public double Percent(double fnum, double snum);
    }
}
