using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;

namespace InheritanceClasses
{
    public enum DietType { Herbivore = 1, Omnivore = 99, Carnivore} /* the index is always a 0-index, but you can set any entry to any index number, 
                                                                      then entires to the right count up from that number. Carnivore's index is 100 */
    public class Animals
    {
        public Animals()
        {
            Console.WriteLine("This is Animal Constructor.");
        }

        public string AnimalName { get; set; }
        public int NumberOfLegs { get; set; }
        public bool IsMammal { get; set; }
        public bool HasFur { get; set; }
        public DietType DietType { get; set; }

        public virtual void Move() //virtual is used when you want the method to be re-written later, or OVERRIDDEN (see Cats.cs)
        {
            Console.WriteLine($"This {GetType().Name} moves.");
        }

       
    }
}
