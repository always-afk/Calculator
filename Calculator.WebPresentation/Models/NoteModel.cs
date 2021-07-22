using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Calculator.WebPresentation.Models
{
    public class NoteModel
    {
        public double FirstNum { get; set; }
        public double SecondNum { get; set; }
        public double Result { get; set; }
        public string Operation { get; set; }
    }
}
