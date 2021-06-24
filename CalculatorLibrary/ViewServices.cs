using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DBWorker;

namespace CalculatorLibrary
{
    public class ViewServices
    {
        private const string ZeroWithPoint = "0,";
        private const string Point = ",";
        
        

        public Operations CurrentOperation { get; set; }
        private CalculatorServices _calculator;
        private readonly string[] _oper = { "+", "-", "*", "/", "%" };

        public ViewServices() 
        {
            _calculator = new CalculatorServices();
        }

        public string PointLogic(string msg)
        {
            string res = msg;
            if (String.IsNullOrEmpty(msg))
            {
                res += ZeroWithPoint;
            }
            else if (!msg.Contains(Point))
            {
                res += Point;
            }

            return res;
        }

        public Note FindRes(string num1, string num2)
        {
            if (!String.IsNullOrEmpty(num1) && !String.IsNullOrEmpty(num2))
            {
                var fnum = Convert.ToDouble(num2);                
                var snum = Convert.ToDouble(num1);
                var calcRes = 0.0;
                var oper = "";

                switch (CurrentOperation)
                {
                    case Operations.Add:
                        calcRes = _calculator.Add(fnum, snum);
                        oper = _oper[0];
                        break;
                    case Operations.Substract:
                        calcRes = _calculator.Subtract(fnum, snum);
                        oper = _oper[1];
                        break;
                    case Operations.Multiply:
                        calcRes = _calculator.Multiply(fnum, snum);
                        oper = _oper[2];
                        break;
                    case Operations.Split:
                        calcRes = _calculator.Split(fnum, snum);
                        oper = _oper[3];
                        break;
                    case Operations.Percent:
                        calcRes = _calculator.Percent(fnum, snum);
                        oper = _oper[4];
                        break;
                }

                return new Note { FirstNum = fnum, SecondNum = snum, Result = calcRes, Operation = oper };
                              
            }
            return null;
        }
    }
}
