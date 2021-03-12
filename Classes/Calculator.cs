using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Classes
{
    public class Calculator
    {

        //public = access modifier, int = return type, Add = method signature (fancy way of saying it's the name of the method), () = parameters
        public int Add(int numOne, int numTwo)
        {
            int sum = numOne + numTwo;
            return sum; 
        }

        /* Think about what the method is going to give as a result.  
         If you write a method that takes an integer and multiplies it by two,
        you want to get that result returned so you can use it.  Therefore in this situation you
        would want a return type of "int" */

        public double Add(double numOne, double numTwo)
        {
            double sum = numOne + numTwo;
            return sum;
        }

        public int CalculateAge(DateTime birthdate)
        {
            TimeSpan ageSpan = DateTime.Now - birthdate;
            double totalAgeInYears = ageSpan.TotalDays / 365.25;
            int years = Convert.ToInt32(Math.Floor(totalAgeInYears));
            return years;                                                 //this outputs actual age in years
        }
    }
}
