﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Calculator.DataAccess
{
    public interface IDataAccess
    {
        public void Save(List<string> notes);
        public List<string> Load();
    }
}
