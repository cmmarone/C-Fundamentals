using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;

namespace Classes
{

    public class Person
    {
        //below are properties

        public string FullName
        {
            get
            {
                return $"{FirstName} {LastName}";
            }
        }
        public string FirstName { get; set; } // this is the shorthand way of writing out...

        private string _lastName;           // this
        public string LastName              //  |
        {
            get { return _lastName; }       //  |    here, we want the user last name to be private outside our class
            set { _lastName = value; }      // _|
        }


        public DateTime DateOfBirth { get; set; } //initializing DateOfBirth as a property of class Person. This one uses a struct DateTime

        public int Age                             //this takes in DOB and returns age
        {
            get
            {
                TimeSpan ageSpan = DateTime.Now - DateOfBirth;
                double totalAgeInYears = ageSpan.TotalDays / 365.25;
                int yearsOfAge = Convert.ToInt32(Math.Floor(totalAgeInYears));
                return yearsOfAge;         
            }
        }

        public Vehicle Transport { get; set; } //just for demonstration, we can call classes defined anywhere in our solution. This one uses a class we created to initialize Transport


        //below is constructor
        public Person() { }   //to create a custom constructor, C# requires us to create a blank one first

        //below, initializing firstName, lastName, dateOfBirth
        public Person(string firstName, string lastName, DateTime dateOfBirth) //building our person
        {
            FirstName = firstName;
            LastName = lastName;
            DateOfBirth = dateOfBirth;
        }

    }

}
