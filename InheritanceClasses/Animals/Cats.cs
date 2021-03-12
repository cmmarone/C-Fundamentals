using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace InheritanceClasses
{
    public class Cats : Animals  //making Cats an inheritance class of class Animals
    {
        public Cats()
        {
            Console.WriteLine("This is the Cats constructor.");
            IsMammal = true;                            //called from Animals
            DietType = DietType.Carnivore;             //called from Animals
        }
        public bool IsEvil { get; set; }
        public int HowManyWhiskers { get; set; }
        public string Color { get; set; }
        public string HairLength { get; set; }

        public virtual void MakeSound()
        {
            Console.WriteLine("Meow");
        }

        public override void Move()        //overrides the previously built public virtual Move() method from Animal class. Why not just make a new method? Because this is for teaching purposes
        {
            Console.WriteLine($"The {GetType().Name} moves quickly!");
        }
    }

    public class Liger : Cats   
    {
        public Liger()
        {
            Console.WriteLine("This is the Liger constructor.");
        }

        public override void Move()
        {
            Console.WriteLine($"The {GetType().Name} stalks its prey.");
            base.Move();
        }
        public override void MakeSound()
        {
            Console.WriteLine("Roar.");
        }

    }

    public class Lion : Cats   //class Lion is NOT inheriting Liger.  Forget the way they're stacked visually in the code.
    {
        public Lion()
        {
            Console.WriteLine("This is a Lion Constructor");
        }
        public override void MakeSound()
        {
            Console.WriteLine("Twinkle Toes");
        }

    }
}
