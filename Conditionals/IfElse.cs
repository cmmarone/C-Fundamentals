using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;

namespace Conditionals
{
    [TestClass]
    public class IfElse
    {
        [TestMethod]
        public void IfStatements()
        {
            bool userIsHungry = true;
            if (userIsHungry)
            {
                Console.WriteLine("Eat something!!!"); //will print
            }

            bool userIsSoHungry = false;
            if (userIsSoHungry)
            {
                Console.WriteLine("Great!"); //won't print
            }

            int hoursSpentStudying = 1;
            if (hoursSpentStudying < 16)
            {
                Console.WriteLine("Are you even trying?"); //will print
            }
        }
        [TestMethod]
        public void IfElseStatements()
        {
            bool choresAreDone = false;
            if (choresAreDone)
            {
                Console.WriteLine("Have fun at the movies");
            }
            else
            {
                Console.WriteLine("You must stay home and finish your chores");
            }

            //how to parse
            string input = "2";
            int totalHours = int.Parse(input); //'input' value must be able to become an int, otherwise, won't parse

            if (totalHours >= 8)
            {
                Console.WriteLine("You should be well rested!!");
            }
            else
            {
                Console.WriteLine("You might be tired today.");
                if (totalHours < 4)
                {
                    Console.WriteLine("You should get more SLEEP!!!");
                }
            }

            int age = 22;
            if (age > 17)
            {
                Console.WriteLine("You are an Adult!!"); // prints if age is 18 or higher
            }
            else
            {
                if (age > 6)
                {
                    Console.WriteLine("You are a kid");//will print if age is 7-17
                }
                else if (age > 0)
                {
                    Console.WriteLine("You are far too young to be on a computer");//prints if age is 1-6
                }
                else
                {
                    Console.WriteLine("You are not born yet"); //prints if age is 0 or negative
                }
            }

            if (age < 65 && age > 18) // YES, you have to put the variable on both sides of &&. otherwise it doesn't know '&& >'
            {
                Console.WriteLine("Age is between 19 and 64");
            }

            if (age > 65 || age < 18)
            {
                Console.WriteLine("Age is either Greater than 65 or Less than 18");
            }

            if (age == 21)
            {
                Console.WriteLine("Age is 21.");
            }
            if (age != 36)
            {
                Console.WriteLine("Age is not equal to 36");
            }
        }
    }
}
