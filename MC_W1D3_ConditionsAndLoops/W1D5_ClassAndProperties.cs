using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MC_W1D3_ConditionsAndLoops
{
    //Part 1
    public class User  
    {

        //Part 2
        public string FirstName { get; set; }             
        public string LastName { get; set; }
        public int IDNumber { get; }
        public DateTime DateOfBirth { get; set; }



        //Part 3
        public User()            
        {

        }

        public User(string firstName, string lastName, int idNumber, DateTime dateOfBirth)
        {
            FirstName = firstName;
            LastName = lastName;
            IDNumber = idNumber;
            DateOfBirth = dateOfBirth;
        }




        //Bonus
        public string FullName(string firstName, string lastName)
        {
            string fullName = $"{firstName} {lastName}";
            return fullName;
        }




        //Double bonus
        public int Age()
        {
            TimeSpan ageSpan = DateTime.Now - DateOfBirth;
            double totalAgeInYears = ageSpan.TotalDays / 365.25;
            int yearsOfAge = Convert.ToInt32(Math.Floor(totalAgeInYears));
            return yearsOfAge;
        }

    }
}
