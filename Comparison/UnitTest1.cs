using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;
using System.Collections.Generic;

namespace Comparison
{
    [TestClass]
    public class UnitTest1
    {
        [TestMethod]
        public void ComparisonOperators()
        {
            //start with variables
            int age = 25;
            string userName = "Mick";

            //check to see if something is equal to something else
            bool equals = age == 41; //in the container 'equals', make comparison between age and 41. that sets the bool value
            Console.WriteLine(equals);

            bool userIsTerry = userName == "Terry"; //this would be like an if statement that userName equals Terry
            Console.WriteLine(userIsTerry);
            Console.WriteLine("User is 41: " + equals);

            //using the '!'(bang) operator
            bool notEqual = age != 122;
            Console.WriteLine($"User is not 122: { notEqual}");

            //userName is not Justion
            bool userIsNotJustin = userName != "Justin";
            Console.WriteLine("User is not Justin: " + userIsNotJustin);


            List<string> firstList = new List<string>();
            firstList.Add(userName);

            List<string> secondList = new List<string>();
            secondList.Add(userName);

            //compares the lists, not the contents. the lists are not truly the same, since they are named different, therefore take up different areas of the memory
            bool listAreEqual = firstList == secondList;
            Console.WriteLine($"The lists are equal?: {listAreEqual}");



            //greater than
            bool greaterThan = age > 12;



            //greater than or equal to
            bool greaterThanOrEqual = age >= 24;
            Console.WriteLine(greaterThanOrEqual);



            //less than
            bool lessThan = age < 66;
            Console.WriteLine(lessThan);



            //less than or equal to
            bool lessThanOrEqualTo = age <= 24;
            Console.WriteLine(lessThanOrEqualTo);



            //we have the or '||'
            bool orValue = equals || lessThan;

            bool trueValue = true;
            bool falseValue = false;

            bool tOrT = trueValue || trueValue;
            bool tOrF = trueValue || falseValue;
            bool fOrT = falseValue || trueValue;
            bool fOrF = falseValue || falseValue;
            Console.WriteLine($"True or True: {tOrT}");
            Console.WriteLine($"True or False: {tOrF}");
            Console.WriteLine($"False or True: {fOrT}");
            Console.WriteLine($"False or False: {fOrF}");


            // and '&&'
            bool andValue = greaterThan && orValue;

            bool tAndT = trueValue && trueValue;
            bool tAndF = trueValue && falseValue;
            bool fAndT = falseValue && trueValue;
            bool fAndF = falseValue && falseValue;

            Console.WriteLine($"True and True: {tAndT}");
            Console.WriteLine($"True and False: {tAndF}");
            Console.WriteLine($"False and True: {fAndT}");
            Console.WriteLine($"False and False: {fAndF}");
            
        }
    }
}
