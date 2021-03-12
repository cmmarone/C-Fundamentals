using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;

namespace LoopExamples
{
    [TestClass]
    public class LoopTests
    {
        [TestMethod]
        public void WhileLoops()
        {
            //just for setup
            int total = 1;

            //please keep running as long as int is not 10
            while (total != 10)
            {
                Console.WriteLine(total);
                total = total + 1;
            }
            //that will produce a list of 1 thru 9


            total = 0; // you can change a variable whenever you want?

            while (true) //when set to true, while will just start running. you're basically telling it the outcome of a conditional
            {
                if (total == 10)
                {
                    Console.WriteLine("Goal Reached");
                    break; //you can use "break;" in a while loop. this was needed to escape because the while loop is set to keep running
                }

                total++; //++ is a shorthand for 'total = total + 1'
            }

            //new setup
            Random random = new Random();

            int someCount;
            bool keepLooping = true;

            while (keepLooping)
            {                         //0 inclusive, 20 exclusive. so, it's 19 (0-19)
                someCount = random.Next(0, 20);

                if (someCount == 6 || someCount == 10)
                {
                    continue; // ooo, what's that? it's a keyword.
                }

                Console.WriteLine(someCount);

                if (someCount == 15)
                {
                    keepLooping = false;
                }
            }


        }

        [TestMethod]
        public void ForLoops()
        {
            int studentCount = 21;

            //Initialization of LCV; conditional; updates value of LCV)
            for (int i = 0; i < studentCount; i++)
            {
                Console.WriteLine(i);
            }

            string[] students = { "Adam", "Justin", "Joshua", "Amanda", "Danielle", "Ingeborg" };

            for (int i = 0; i < students.Length; i++)
            {
                Console.WriteLine($"WElcome to the class {students[i]} !");
            }
        }

        [TestMethod]
        public void ForEachLoops()
        {
            string[] students = { "Adam", "Justin", "Joshua", "Amanda", "Danielle", "Ingeborg" };
                           //initialized string 'student' here
            foreach (string student in students)
            {
                Console.WriteLine(student + " is a student in the class");
            }

            //string is an array of char
            string MyName = "Terry Eugene Edward Brown";
            foreach (char letter in MyName)
            {
                if (letter != ' ')
                {
                    Console.WriteLine(letter);
                }
            }
        }

        [TestMethod]
        public void DoWhileLoops()
        {
            int iterator = 0;
            //I always run at least once!
            do 
            {
                Console.WriteLine("Hello");
                iterator++;
            } while (iterator < 5);

            do
            {
                Console.WriteLine("My do while condition is False!!");
            } while (false);

            while (false)
            {     //linter is telling us the code is unreachable (in background of VS)
                Console.WriteLine("MY while condition is false");
            }
 

        }


    }
	
}
