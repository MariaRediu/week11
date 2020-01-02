using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Calculator
{
    class Program
    {
        static void Main(string[] args)
        {
            List<int> number = new List<int> { 2, 4, 6, 8 };
            List<double> doubleNumber = new List<double> { 1.1, 3.3, 5.5 };

            OperationCalculator<int> intOperation = new OperationCalculator<int>(new IntCalculator());
            OperationCalculator<double> doubleOperation = new OperationCalculator<double>(new DoubleCalculator());

            try
            {
                Console.WriteLine("Integer Calculation");
                Console.WriteLine("Addition : {0}", intOperation.Sum(number));
                Console.WriteLine("Substraction : {0}", intOperation.Sub(number));
                Console.WriteLine("Mulitplication : {0}", intOperation.Multiply(number));
                Console.WriteLine("Division : {0}", intOperation.Divide(number));


                Console.WriteLine("Double Calculation");
    
                    Console.WriteLine("Addition : {0}", doubleOperation.Sum(doubleNumber));
                Console.WriteLine("Substraction : {0}", doubleOperation.Sub(doubleNumber));
                Console.WriteLine("Mulitplication : {0}", doubleOperation.Multiply(doubleNumber));
                Console.WriteLine("Division : {0}", doubleOperation.Divide(doubleNumber));

            }
            catch (DivideByZeroException ex)
            {
                Console.WriteLine("Division Error : {0}", ex.Message);
            }
            catch (Exception ex)
            {
                Console.WriteLine(" Error : {0}", ex.Message);
            }

            Console.ReadLine();
        }
    }


}
    
