using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Calculator.DataAccess;

namespace Calculator.BusinessLogic
{
    public class ViewServices : IViewServices
    {
        private const string ZeroWithPoint = "0,";
        private const string Point = ",";



        public Operations CurrentOperation { get; set; }
        private ICalculatorServices _calculator;
        private IDataService _data;
        private readonly string[] _oper = { "+", "-", "*", "/", "%" };

        public ViewServices(ICalculatorServices calculator, IDataService worker)
        {
            _calculator = calculator;
            _data = worker;
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

        private void ConvertOperation(string operation)
        {
            if(operation == "+")
            {
                CurrentOperation = Operations.Add;
            }
            else if(operation == "-")
            {
                CurrentOperation = Operations.Substract;
            }
            else if(operation == "*")
            {
                CurrentOperation = Operations.Multiply;
            }
            else if(operation == "/")
            {
                CurrentOperation = Operations.Split;
            }
            else
            {
                throw new ArgumentException("Invalid operation", operation);
            }
        }

        public string FindRes(double fnum, double snum, string operation)
        {
            ConvertOperation(operation);
            
                
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

            return $"{fnum} {oper} {snum} = {calcRes}";
        }

        public void Save(List<string> notes)
        {
            _data.Save(notes);
        }

        public List<string> Load()
        {
            return _data.Load();
        }
    }
}
