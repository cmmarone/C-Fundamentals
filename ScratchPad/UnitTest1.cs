using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;

namespace ScratchPad
{
    [TestClass]
    public class UnitTest1
    {
        MethodRepo _methodRepo = new MethodRepo();


        [TestMethod]
        public void TestPrompt2()
        {
            int a = 5;
            int b = 6;

          int difference =  _methodRepo.Subtract(a, b);
      
            Assert.AreEqual(difference, (a - b));
        }
    }
}
