using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Calculator
{
    public class IntCalculator:GenericCalculator<int>
    {
        public override int Add(int input1, int input2)
        {
            return input1 + input2;
        }

        public override int Sub(int input1, int input2)
        {
            return input1 - input2;
        }

        public override int Multiply(int input1, int input2)
        {

            return input1 * input2;
        }

        public override int Divide(int input1, int input2)
        {
            return input1 / input2;
        }

    }
}

