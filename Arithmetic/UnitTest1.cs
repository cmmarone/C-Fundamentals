using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;

namespace Arithmetic
{
    [TestClass]
    public class UnitTest1
    {
        [TestMethod]
        public void SimpleOperators()
        {
            int a = 22;
            int b = 15;

            //addition
            int sum = a + b;
            sum += 3; //this is shorthand addition

            Console.WriteLine(sum);

            //subtraction
            int difference = a - b;

            Console.WriteLine($"this is the difference: {difference}");

            //multiplication
            int product = a * b;
            Console.WriteLine($"this is the product: {product}");

            //division
            int quotient = a / b;
            Console.WriteLine($"this is the quotient: {quotient}");

            //modulus
            int remainder = a % b;
            Console.WriteLine($"the remainder is: {remainder}");


            //jumping to structs??
            DateTime now = DateTime.Now;
            DateTime someday = new DateTime(1978, 1, 1);

            TimeSpan timeSpan = now - someday;
            Console.WriteLine(timeSpan);
            Console.WriteLine(timeSpan.Days);
            Console.WriteLine(timeSpan.TotalMilliseconds);
        }
    }
}
