using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace test1
{
    [TestClass]
    public class UnitTest1
    {
        [TestMethod]
        public void TestMethod1()
        {
            int myage = 19;
            myage += 1;

            Console.WriteLine("hello I'm"+ myage);
        }
        [TestMethod]
        public void TestMethod2()
        {
            int myDogsAge = 4;
            myDogsAge += 1;
            Console.WriteLine("My dog is " + myDogsAge);
        }
    }
}
