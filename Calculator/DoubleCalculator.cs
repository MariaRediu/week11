using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Calculator
{
   public class DoubleCalculator:GenericCalculator<double>
    {
        public override double Add(double input1, double input2)
        {
            return input1 + input2;
        }
        public override double Sub(double input1, double input2)
        {
            return input1 - input2;
        }

        public override double Multiply(double input1, double input2)
        {
            return input1 * input2;
        }


        public override double Divide(double input1, double input2)
        {
            return input1 / input2;
        }
    }
}

