using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Calculator.DataAccess
{
    public class Note
    {
        public int Id { get; set; }
        public double FirstNum { get; set; }
        public double SecondNum { get; set; }
        public double Result { get; set; }
        public string Operation { get; set; }
    }
}
