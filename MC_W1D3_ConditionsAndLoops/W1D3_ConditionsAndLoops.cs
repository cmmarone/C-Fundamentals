using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;

namespace MC_W1D3_ConditionsAndLoops
{
    [TestClass]
    public class W1D3_ConditionsAndLoops
    {
        [TestMethod]
        public void Challenge1()
        {

            string maryPoppins = "Supercalifragilisticexpialidocious";
            foreach (char letter in maryPoppins)
            {
                Console.WriteLine(letter);
            }
        }

        [TestMethod]
        public void Challenge2()
        {
            string maryPoppins = "Supercalifragilisticexpialidocious";
            foreach (char letter in maryPoppins)
            {
                if (letter != 'i')
                {
                    Console.WriteLine("not an i");
                }
                else
                {
                    Console.WriteLine('i');
                }
            }
        }




        [TestMethod]
        public void ChallengeBonus1()
        {
            string maryPoppins = "Supercalifragilisticexpialidocious";

            Console.WriteLine(maryPoppins.Length);

        }



        [TestMethod]
        public void ChallengeBonus2()
        {
            string maryPoppins = "Supercalifragilisticexpialidocious";
            foreach (char letter in maryPoppins)
            {
                if (letter != 'i' && letter != 'l')
                {
                    Console.WriteLine("not an i");
                }
                else if (letter == 'l')
                {
                    Console.WriteLine('L');
                }
                else
                {
                    Console.WriteLine('i');
                }
            }

        }
    }
}
