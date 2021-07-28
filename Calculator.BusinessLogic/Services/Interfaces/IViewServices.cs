using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Calculator.BusinessLogic
{
    public interface IViewServices
    {
        public Operations CurrentOperation { get; set; }

        public string FindRes(double num1, double num2, string operation);
        public string PointLogic(string msg);
        public void Save(List<string> notes);
        public List<string> Load();
    }
}
