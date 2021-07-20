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

        public string FindRes(string num1, string num2);
        public string PointLogic(string msg);
        public void Save(List<string> notes);
        public List<string> Load();
    }
}
