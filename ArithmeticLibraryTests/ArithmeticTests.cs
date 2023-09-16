using Microsoft.VisualStudio.TestTools.UnitTesting;


namespace ArithmeticLibrary.Tests
{

    [TestClass()]
    public class ArithmeticTests
    {
        readonly Arithmetic _arith = new();

        [TestMethod()]
        public void AddTest()
        {
            var num1 = 1;
            var num2 = 2;

            Assert.IsTrue(_arith.Add(num1, num2) == num1 + num2);
        }

        [TestMethod()]
        public void SubstractTest()
        {
            var num1 = 3;
            var num2 = 1;
            
            Assert.IsTrue(_arith.Substract(num1, num2) == num1 - num2);
        }

        [TestMethod()]
        public void MultiplyTest()
        {
            var num1 = 3;
            var num2 = 2;

            Assert.IsTrue(_arith.Multiply(num1, num2) == num1 * num2);
        }

        [TestMethod()]
        public void DivideTest()
        {
            var num1 = 10;
            var num2 = 5;

            Assert.IsTrue(_arith.Divide(num1, num2) == num1 / num2);
        }

        [TestMethod()]
        public void ModulusTest()
        {
            var num1 = 6;
            var num2 = 3;

            Assert.IsTrue(_arith.Modulus(num1, num2) == num1 % num2);
        }

        [TestMethod()]
        public void IncrementTest()
        {
            var num1 = 1;

            Assert.IsTrue(_arith.Increment(num1) == ++num1);
        }

        [TestMethod()]
        public void DecrementTest()
        {
            var num1 = 1;

            Assert.IsTrue(_arith.Decrement(num1) == --num1);
        }

        [TestMethod()]
        public void NegateTest()
        {
            var num1 = 1;

            Assert.IsTrue(_arith.Negate(num1) == -num1);
        }
    }
}