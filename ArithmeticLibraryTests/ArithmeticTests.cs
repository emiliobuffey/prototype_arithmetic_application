using Microsoft.VisualStudio.TestTools.UnitTesting;
using ArithmeticLibrary;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


namespace ArithmeticLibrary.Tests
{

    [TestClass()]
    public class ArithmeticTests
    {
        readonly Arithmetic _arith = new();

        [TestMethod()]
        public void AddTest()
        {
            Assert.IsTrue(_arith.Add(1, 2) == 3);
        }

        [TestMethod()]
        public void SubstractTest()
        {
            Assert.Fail();
        }

        [TestMethod()]
        public void MultiplyTest()
        {
            Assert.Fail();
        }

        [TestMethod()]
        public void DivideTest()
        {
            Assert.Fail();
        }

        [TestMethod()]
        public void ModulusTest()
        {
            Assert.Fail();
        }

        [TestMethod()]
        public void IncrementTest()
        {
            Assert.Fail();
        }

        [TestMethod()]
        public void DecrementTest()
        {
            Assert.Fail();
        }

        [TestMethod()]
        public void NegateTest()
        {
            Assert.Fail();
        }
    }
}