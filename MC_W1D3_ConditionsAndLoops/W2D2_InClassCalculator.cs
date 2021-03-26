using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MC_W1D3_ConditionsAndLoops
{
    public class W2D2_InClassCalculator
    {
        public int Addition(int numOne, int numTwo)
        {
            int sum = numOne + numTwo;
            return sum;
        }

        public int Subtraction(int numOne, int numTwo)
        {
            int difference = numOne - numTwo;
            return difference;
        }

        public int Multiplication(int numOne, int numTwo)
        {
            int product = numOne * numTwo;
            return product;
        }

        public int Division(int numOne, int numTwo)
        {
            int quotient = numOne / numTwo;
            return quotient;
        }
    }

    [TestClass]
    public class CalculatorTestClass
    {
        private int numOne = 27;
        private int numTwo = 3;
        W2D2_InClassCalculator calculate = new W2D2_InClassCalculator();

        [TestMethod]
        public void TestingAdditionMethodShouldReturnTrue()
        {

            int sum = calculate.Addition(numOne, numTwo);

            Assert.AreEqual(sum, (numOne + numTwo));
        }



    }
}
