using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;
using System.Collections.Generic;

namespace ReferenceTypes
{
    [TestClass]
    public class UnitTest1
    {
        [TestMethod]
        public void Strings()
        {
            string name;

            string declared;
            declared = "this is initialized";

            string declareAndInitialize = "This is both declaring and initializing";

            string firstName = "Adam";
            string lastName = "Wolanin";

            string concatenatedFullName = firstName + " " + lastName;

            string interpolationFullName = $"{firstName} {lastName}";

            string compositeFullName = string.Format("{0} {1}", firstName, lastName);

            Console.WriteLine(firstName);
            Console.WriteLine(lastName);
            Console.WriteLine(concatenatedFullName);
            Console.WriteLine(interpolationFullName);
            Console.WriteLine(compositeFullName);
        
        }
        [TestMethod]
        public void Collections()
        {
            string stringExample = "Hello World";

            string[] stringArray = { "Hello", "World!", "Why", "is it", "always", stringExample };
            string[] differentStringArray = { "some", "word" };
            // use 2 to get thirdItem because 0-index (0 is first item)
            string thirdItem = stringArray[2];
            Console.WriteLine(thirdItem);
            differentStringArray[1] = "idk";
            //we can re-write a value in the array
            stringArray[0] = "Hey There";
            Console.WriteLine(stringArray[0]);
            Console.WriteLine(differentStringArray[1]);

            //Lists
            List<string> listOfStrings = new List<string>();
            List<int> listOfInts = new List<int>();
            //add to list
            listOfStrings.Add("First string for our list");
            listOfInts.Add(310569);

            Console.WriteLine(listOfInts[0]);

            //Created queue
            Queue<string> firstInFirstOut = new Queue<string>();
            //add to queue
            firstInFirstOut.Enqueue("I'm First");
            firstInFirstOut.Enqueue("I'm Next");

            //.Dequeue() takes items one by one. "Next in line please!"
            string firstItem = firstInFirstOut.Dequeue();
            Console.WriteLine(firstItem);

            //Dictionary
            Dictionary<int, string> keyAndValue = new Dictionary<int, string>();

            keyAndValue.Add(7, "Agent");

            string valueSeven = keyAndValue[7];
            /*displays "Agent". the int value of 7 is the dictionary position, 
            the other values like 5 and 6 are still empty. So we named it valueSeven */
            Console.WriteLine(valueSeven);





            //other types of collections. check into later

            //sorted list. like list/dictionary combo
            SortedList<int, string> sortedKeyAndValue = new SortedList<int, string>();
            //hash set
            HashSet<int> uniqueList = new HashSet<int>();
            //stack, like a reverse queue
            Stack<string> lastInFirstOut = new Stack<string>();


        }
        [TestMethod]
        public void Classes()
        {

            //this will create a random number generator
            Random rng = new Random();

            int randomNumber = rng.Next();

            Console.WriteLine(randomNumber);
        }


    }
}
