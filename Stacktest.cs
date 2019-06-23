using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using System.Collections.Generic;
using StackOperations;
using System.Linq;


namespace Stackoperation_Test
{
    [TestClass]
    public class Stacktest
    {
        [TestMethod]
        public void Stack_push_test()
        {
            //arrange
            Stack<string> mystack = new Stack<string>();
            string pushnumber = "23";
            //act
            var result = MyStackclass.Push(mystack,pushnumber);
            //assert
            Assert.AreEqual(result.Pop(), pushnumber);
        }

        [TestMethod]
        public void Stack_pop_test()
        {
            //arrange
            Stack<string> mystack = new Stack<string>();
            string pushnumber = "23";
            string pushnumber1 = "55";
            //act
            var result = MyStackclass.Push(mystack, pushnumber);
            var result1 = MyStackclass.Push(result, pushnumber1);
            var result2 = MyStackclass.Pop(result1);
            //assert
            Assert.AreEqual(result2.Peek(), pushnumber);
        }

        [TestMethod]
        public void Stack_pop_test1()
        {
            //arrange
            Stack<string> mystack = new Stack<string>();            
            //act
            var result2 = MyStackclass.Pop(mystack);
            //assert
            Assert.AreEqual(result2,mystack);
        }

        [TestMethod]
        public void Stack_push_test1()
        {
            //arrange
            Stack<string> mystack = new Stack<string>();
            string pushnumber = "ab";
            //act
            var result = MyStackclass.Push(mystack, pushnumber);
            //assert
            Assert.AreEqual(result, mystack);
        }

        [TestMethod]
        public void Stack_max_test()
        {
            //arrange
            Stack<string> mystack = new Stack<string>();
            string pushnumber = "25";
            string pushnumber1 = "55";

            //act
            var result = MyStackclass.Push(mystack, pushnumber);
            var result1 = MyStackclass.Push(result, pushnumber1);

            var result2 = MyStackclass.MaxNumber(result1);
            //assert
            Assert.AreEqual(pushnumber1, result2.Max());
        }

        [TestMethod]
        public void Stack_max_test1()
        {
            //arrange
            Stack<string> mystack = new Stack<string>();
            //act           
            var result2 = MyStackclass.MaxNumber(mystack);
            //assert
            Assert.AreEqual(mystack, result2);
        }
    }
}
