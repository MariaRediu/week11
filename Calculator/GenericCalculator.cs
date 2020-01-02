using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Calculator
{
   public abstract class GenericCalculator<T>
    {
        public abstract T Add(T input1, T input2);
        public abstract T Sub(T input1, T input2);
        public abstract T Multiply(T input1, T input2);
        public abstract T Divide(T input1, T input2);
    }
}
