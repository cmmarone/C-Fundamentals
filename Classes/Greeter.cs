using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Classes
{
    public class Greeter
    {
        public void SayHello(string name) //void works here because we don't need anything useable returned to the program, we just want to show the user
        {
            Console.WriteLine($"Hello, {name}!");
        }

        public void SayHello()
        {
            Console.WriteLine("Hello");
        }

        Random _random = new Random();
        public void GetRandomGreeting()
        {
            string[] availableGreetings = new string[] { "Good morning", "What's up", "What's up Dawg", "Howdy" };
            int randomNumber = _random.Next(0, availableGreetings.Length); //limits random number to between 0 and 3
            string randomGreeting = availableGreetings.ElementAt(randomNumber);
            Console.WriteLine($"{randomGreeting}");
        }
    }
}
