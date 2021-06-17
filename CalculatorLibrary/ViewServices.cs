using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CalculatorLibrary
{
    public class ViewServices
    {
        private const string ZeroWithPoint = "0,";
        private const string Point = ",";

        public Operations CurrentOperation;

        public ViewServices() { }

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

        public string FindRes(string num1, string num2)
        {

        }
    }
}
