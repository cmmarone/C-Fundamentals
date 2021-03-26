using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MC_W1D3_ConditionsAndLoops
{
    [TestClass]
    public class W2D2_Calculator
    {
        public double NumOne { get; set; }
        public double NumTwo { get; set; }

        public W2D2_Calculator()
        {

        }

        public W2D2_Calculator(double numOne, double numTwo)
        {
            NumOne = numOne;
            NumTwo = numTwo;
        }



        public double Add(double numOne, double numTwo)
        {
            double sum = numOne + numTwo;
            return sum;
        }

        public double SubtractSecondFromFirst(double numOne, double numTwo)
        {
            double difference = numOne - numTwo;
            return difference;
        }

        public double Multiply(double numOne, double numTwo)
        {
            double product = numOne * numTwo;
            return product;
        }

        public double Divide(double numOne, double numTwo)
        {
            double quotient = numOne / numTwo;
            return quotient;
        }







        [TestMethod]
        public void TestAddition()
        {

            W2D2_Calculator calculate = new W2D2_Calculator();

            double testSum = calculate.Add(10, 5);
            Console.WriteLine(testSum);

        }

        [TestMethod]
        public void TestSubtraction()
        {

            W2D2_Calculator calculate = new W2D2_Calculator();

            double testDifference = calculate.SubtractSecondFromFirst(10, 5);
            Console.WriteLine(testDifference);

        }

        [TestMethod]
        public void TestMultiplication()
        {

            W2D2_Calculator calculate = new W2D2_Calculator();

            double testProduct = calculate.Multiply(10, 5);
            Console.WriteLine(testProduct);

        }


        [TestMethod]
        public void TestDivision()
        {

            W2D2_Calculator calculate = new W2D2_Calculator();

            double testQuotient = calculate.Divide(10, 5);
            Console.WriteLine(testQuotient);

        }








    }
}
