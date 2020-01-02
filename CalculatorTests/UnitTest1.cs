using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using Calculator;

namespace CalculatorTests
{
    [TestClass]
    public class UnitTest1
    {

        private IntCalculator calc;
        private DoubleCalculator doublecalc;

        [TestInitialize]
        public void Setup()
        {
            calc = new IntCalculator();
            doublecalc = new DoubleCalculator();
        }
        [TestMethod]
        [DataRow(2,3,5)]
        public void Should_Be_AddInt(int input1,int input2,int expected)
        {
            //Act
            int actual = calc.Add(input1, input2);
           

            //Assert
            Assert.AreEqual(actual, expected);

        }

        [TestMethod]
        [DataRow(5, 2, 3)]
        public void Should_Be_SubInt(int input1, int input2, int expected)
        {
            //Act
            int actual = calc.Sub(input1, input2);
            //Assert
            Assert.AreEqual(actual, expected);

        }

        [TestMethod]
        [DataRow(2, 3, 6)]
        public void Should_Be_MultiplyInt(int input1, int input2, int expected)
        {
            //Act
            int actual = calc.Multiply(input1, input2);
            //Assert
            Assert.AreEqual(actual, expected);

        }

        [TestMethod]
        [DataRow(6, 2, 3)]
        public void Should_Be_DivideInt(int input1, int input2, int expected)
        {
            //Act
            int actual = calc.Divide(input1, input2);
            //Assert
            Assert.AreEqual(actual, expected);

        }
        [TestMethod]
        [DataRow(2.1, 3.1, 5.2)]
        public void Should_Be_Add(double inp1, double inp2, double expected)
        {
            //Act
            double actual = doublecalc.Add(inp1, inp2);


            //Assert
            Assert.AreEqual(actual, expected);

        }

        [TestMethod]
        [DataRow(5.3, 2.0, 3.3)]
        public void Should_Be_Sub(double inp1, double inp2, double expected)
        {
            //Act
            double actual = doublecalc.Sub(inp1, inp2);
            //Assert
            Assert.AreEqual(actual, expected);

        }

        [TestMethod]
        [DataRow(2.1, 3.1, 6.51)]
        public void Should_Be_Multiply(double inp1, double inp2, double expected)
        {
            //Act
            double actual = doublecalc.Multiply(inp1, inp2);
            //Assert
            Assert.AreEqual(actual, expected);

        }

        [TestMethod]
        [DataRow(6.2, 2.2, 2.81818181818182)]
        public void Should_Be_Divide(double inp1, double inp2, double expected)
        {
            //Act
            double actual = doublecalc.Divide(inp1, inp2);
            //Assert
            Assert.AreEqual(actual, expected);

        }
    }
}
