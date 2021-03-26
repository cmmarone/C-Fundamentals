using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DeveloperTeamChallenge
{
    public static class RandomGenerator
    {
        public static int[] GenerateID()
        {
            int[] valueStorage = new int[5];
            for (int i = 0; i < valueStorage.Length; i++)
            {
                System.Threading.Thread.Sleep(500);
                Random rng = new Random();
                int randomNumber = rng.Next(0, 10);
                valueStorage[i] = randomNumber;
     
            }
            return valueStorage;
        }
    }
}
