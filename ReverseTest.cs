using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using reversestring;
using System.Collections.Generic;

namespace ReverseTringTest
{
    [TestClass]
    public class ReverseTest
    {
        [TestMethod]
        public void TestFormetho1()
        {
            //Arrange
            string input = "qqwerty";
            string output = "ytrewqq";

            //Act
            var result = Program.Revwithstack(input);
            //Assert
            Assert.AreEqual(output,result);
        }
        [TestMethod]
        public void TestFormethod2()
        {
            //Arrange
            string input = "qqwerty";
            string output = "ytrewqq";

            //Act
            var result = Program.ReverseString(input);
            //Assert
            Assert.AreEqual(output, result);
        }

        [TestMethod]
        public void TestFormethod3()
        {
            //Arrange
            string input = "qqwerty";
            string output = "ytrewqq";

            //Act
            var result = Program.ReverseNostack(input);
            //Assert
            Assert.AreEqual(output, result);
        }
    }
}
