using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;
using System.Collections.Generic;

namespace Interfaces
{
    [TestClass]
    public class IFruitTests
    {
        [TestMethod]
        public void CallingInterfaceMethods()
        {
            //--> not using this --> Banana banana = new Banana()
            IFruit banana = new Banana();

            string output = banana.Peel();
            Console.WriteLine(output);

            Console.WriteLine("The banana is peeled: " + banana.IsPeeled);




            IFruit grape = new Grape();

            string output2 = grape.Peel();
            Console.WriteLine(output2);

            Console.WriteLine("The grape is peeled?: " + grape.IsPeeled);

            //Assert.IsTrue(banana.IsPeeled);
        }

        [TestMethod]
        public void InterfacesAndCollections()
        {
            Orange orange = new Orange();

            List<IFruit> FruitSalad = new List<IFruit>()
            {
                new Banana(),
                new Grape()
            };

            foreach (IFruit fruit in FruitSalad)
            {
                Console.WriteLine(fruit.Name);
                Console.WriteLine(fruit.Peel());

                Assert.IsInstanceOfType(fruit, typeof(IFruit));
            }

        }


        //helper method
        private string GetFruitName(IFruit fruit)
        {
            return $"This fruit is called {fruit.Name}.";
        }

        [TestMethod]
        public void InterfacesInMethods()
        {
            //we are going to use a class that implements IFruit
            Grape grape = new Grape();

            string output = GetFruitName(grape);

            Console.WriteLine(output);

            Assert.IsTrue(output.Contains("This fruit is called Grape."));
        }

        [TestMethod]
        public void TypeOfInstance()
        {
            List<IFruit> fruitSalad = new List<IFruit>
            {
                new Orange(true),
                new Orange(),
                new Grape(),
                new Orange(),
                new Orange(),
                new Banana(true),
                new Grape()
            };

            Console.WriteLine("Is the orange peeled?");

            foreach (IFruit fruit in fruitSalad)
            {
                //this is called pattern matching
                if (fruit is Orange orange) // first of all, is it an orange?
                {
                    if (orange.IsPeeled) // now, is it peeled?
                    {
                        Console.WriteLine("Yeah, it's peeled.");
                        orange.Squeeze();
                    }
                    else
                    {
                        Console.WriteLine("That's an orange, but it's not peeled.");
                    }
                }
                else if (fruit.GetType() == typeof(Grape))
                {
                    Console.WriteLine("That's a grape.");
                }
                else if (fruit.IsPeeled)
                {
                    Console.WriteLine("That's a peeled Banana.");
                }
                else
                {
                    Console.WriteLine("That's a Banana.");
                }
            }

        }
    }
}
