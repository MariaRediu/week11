using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Calculator
{
  public class OperationCalculator<T>
    {
        GenericCalculator<T> _calc;
        public OperationCalculator(GenericCalculator<T> calc)
        {
            this._calc = calc;
        }
        public T Sum(List<T> item)
        {
            dynamic sum = 0;

            for (int i = 0; i < item.Count; i++)
            {
                sum = _calc.Add(sum, item[i]);
            }


            return sum;
        }

        public T Sub(List<T> item)
        {
            dynamic sub = 0;
            for (int i = 0; i < item.Count; i++)
            {
                sub = _calc.Sub(sub, item[i]);
            }
            return sub;
        }

        public T Multiply(List<T> item)
        {
          
            dynamic multiply = 1;

            for (int i = 0; i < item.Count; i++)
            {
                multiply = _calc.Multiply(multiply, item[i]);
            }
            return multiply;
        }
        public T Divide(List<T> item)
        {
            dynamic div = 1;
            for (int i = 0; i < item.Count; i++)
            {
                if (div == 1)
                {
                     div = _calc.Divide(item[i], div);
                }
                else

                {
                    div = _calc.Divide(div, item[i]);

                }
            }

            return div;
        }
    }
}

