﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using static System.Runtime.InteropServices.JavaScript.JSType;

namespace OpenClosedV1
{
    public class Client
    {
        public CalculatorV10 _calculator;

        public Client()
        {
            _calculator = new CalculatorV10();
        }

        public void ProcessData(Data d)
        {
            // int result = _calculator.Calculate(d);
            //...
        }
    }
}
