using System;
using System.Collections.Generic;
using System.Text;

namespace Calculator
{
    public class OperationAdd:Operation
    {
        public override double GetResult()
        {
            double result = 0;
            result = NumberA + NumberB;
            return result;
        }
    }
}
