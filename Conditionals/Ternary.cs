using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Conditionals
{
    [TestClass]
    public class Ternary
    {
        [TestMethod]
        public void Ternaries()
        {
            int age = 31;
            bool isAdult = (age > 17) ? true : false;
            Console.WriteLine("Age is over 17: " + isAdult);

            int numOne = 10;
            int numTwo = (numOne == 10) ? 30 : 20;
            Console.WriteLine(numTwo); //prints 30 b/c (conditional) is true

            Console.WriteLine((numTwo == 30) ? "true" : "false"); //here's how use ternary in a C.WL.  (this prints true)


            int numOneB = 10; 
            int numTwoB = (numOneB == 5) ? 30 : 20;
            Console.WriteLine(numTwoB); //prints 20, b/c (conditional) is false


        }
    }
}
