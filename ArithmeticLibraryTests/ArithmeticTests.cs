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
            int num1 = 1;
            int num2 = 2;

            // add the two numbers and compare the result to the expected result
            Assert.IsTrue(_arith.Add(num1, num2) == num1 + num2);
            //add the two negated numbers and compare the result to the expected result
            Assert.IsTrue(_arith.Add(_arith.Negate(num1), _arith.Negate(num2)) == -num1 + -num2);

            decimal num3 = 1.0m;
            decimal num4 = 2.0m;

            // add the two numbers and compare the result to the expected result
            Assert.IsTrue(_arith.Add(num3, num4) == num3 + num4);
            // add the two negated numbers and compare the result to the expected result
            Assert.IsTrue(_arith.Add(_arith.Negate(num3), _arith.Negate(num4)) == -num3 + -num4);

            float num5 = 1.0f;
            float num6 = 2.0f;

            // add the two numbers and compare the result to the expected result
            Assert.IsTrue(_arith.Add(num5, num6) == num5 + num6);
            // add the two negated numbers and compare the result to the expected result
            Assert.IsTrue(_arith.Add(_arith.Negate(num5), _arith.Negate(num6)) == -num5 + -num6);

            double num7 = 1.0;
            double num8 = 2.0;

            // add the two numbers and compare the result to the expected result
            Assert.IsTrue(_arith.Add(num7, num8) == num7 + num8);
            // add the two negated numbers and compare the result to the expected result
            Assert.IsTrue(_arith.Add(_arith.Negate(num7), _arith.Negate(num8)) == -num7 + -num8);
        }

        [TestMethod()]
        public void SubtractTest()
        {
            int num1 = 3;
            int num2 = 1;

            // subtract the two numbers and compare the result to the expected result
            Assert.IsTrue(_arith.Subtract(num1, num2) == num1 - num2);
            // subtract the two negated numbers and compare the result to the expected result
            Assert.IsTrue(_arith.Subtract(_arith.Negate(num1), _arith.Negate(num2)) == -num1 - -num2);

            decimal num3 = 3.0m;
            decimal num4 = 1.0m;

            // subtract the two numbers and compare the result to the expected result
            Assert.IsTrue(_arith.Subtract(num3, num4) == num3 - num4);
            // subtract the two negated numbers and compare the result to the expected result
            Assert.IsTrue(_arith.Subtract(_arith.Negate(num3), _arith.Negate(num4)) == -num3 - -num4);

            float num5 = 1.0f;
            float num6 = 2.0f;

            // subtract the two numbers and compare the result to the expected result
            Assert.IsTrue(_arith.Subtract(num5, num6) == num5 - num6);
            // subtract the two negated numbers and compare the result to the expected result
            Assert.IsTrue(_arith.Subtract(_arith.Negate(num5), _arith.Negate(num6)) == -num5 - -num6);

            double num7 = 1.0;
            double num8 = 2.0;

            // subtract the two numbers and compare the result to the expected result
            Assert.IsTrue(_arith.Subtract(num7, num8) == num7 - num8);
            // subtract the two negated numbers and compare the result to the expected result
            Assert.IsTrue(_arith.Subtract(_arith.Negate(num7), _arith.Negate(num8)) == -num7 - -num8);
        }

        [TestMethod()]
        public void MultiplyTest()
        {
            int num1 = 3;
            int num2 = 2;

            // multiply the two numbers and compare the result to the expected result
            Assert.IsTrue(_arith.Multiply(num1, num2) == num1 * num2);
            // multiply the two negated numbers and compare the result to the expected result
            Assert.IsTrue(_arith.Multiply(_arith.Negate(num1), _arith.Negate(num2)) == -num1 * -num2);

            decimal num3 = 3.0m;
            decimal num4 = 2.0m;

            // multiply the two numbers and compare the result to the expected result
            Assert.IsTrue(_arith.Multiply(num3, num4) == num3 * num4);
            // multiply the two negated numbers and compare the result to the expected result
            Assert.IsTrue(_arith.Multiply(_arith.Negate(num3), _arith.Negate(num4)) == -num3 * -num4);

            float num5 = 1.0f;
            float num6 = 2.0f;

            // multiply the two numbers and compare the result to the expected result
            Assert.IsTrue(_arith.Multiply(num5, num6) == num5 * num6);
            // multiply the two negated numbers and compare the result to the expected result
            Assert.IsTrue(_arith.Multiply(_arith.Negate(num5), _arith.Negate(num6)) == -num5 * -num6);

            double num7 = 1.0;
            double num8 = 2.0;

            // multiply the two numbers and compare the result to the expected result
            Assert.IsTrue(_arith.Multiply(num7, num8) == num7 * num8);
            // multiply the two negated numbers and compare the result to the expected result
            Assert.IsTrue(_arith.Multiply(_arith.Negate(num7), _arith.Negate(num8)) == -num7 * -num8);
        }

        [TestMethod()]
        public void DivideTest()
        {
            int num1 = 10;
            int num2 = 5;

            // divide the two numbers and compare the result to the expected result
            Assert.IsTrue(_arith.Divide(num1, num2) == num1 / num2);
            // divide the two negated numbers and compare the result to the expected result
            Assert.IsTrue(_arith.Divide(_arith.Negate(num1), _arith.Negate(num2)) == -num1 / -num2);

            decimal num3 = 10.0m;
            decimal num4 = 5.0m;

            // divide the two numbers and compare the result to the expected result
            Assert.IsTrue(_arith.Divide(num3, num4) == num3 / num4);
            // divide the two negated numbers and compare the result to the expected result
            Assert.IsTrue(_arith.Divide(_arith.Negate(num3), _arith.Negate(num4)) == -num3 / -num4);

            float num5 = 1.0f;
            float num6 = 2.0f;

            // divide the two numbers and compare the result to the expected result
            Assert.IsTrue(_arith.Divide(num5, num6) == num5 / num6);
            // divide the two negated numbers and compare the result to the expected result
            Assert.IsTrue(_arith.Divide(_arith.Negate(num5), _arith.Negate(num6)) == -num5 / -num6);

            double num7 = 1.0;
            double num8 = 2.0;

            // divide the two numbers and compare the result to the expected result
            Assert.IsTrue(_arith.Divide(num7, num8) == num7 / num8);
            // divide the two negated numbers and compare the result to the expected result
            Assert.IsTrue(_arith.Divide(_arith.Negate(num7), _arith.Negate(num8)) == -num7 / -num8);
        }

        [TestMethod()]
        public void ModulusTest()
        {
            int num1 = 6;
            int num2 = 3;

            // Get the modulus of the two numbers and compare the result to the expected result
            Assert.IsTrue(_arith.Modulus(num1, num2) == num1 % num2);
            // Get the modulus of the two negated numbers and compare the result to the expected result
            Assert.IsTrue(_arith.Modulus(_arith.Negate(num1), _arith.Negate(num2)) == -num1 % -num2);

            decimal num3 = 6.0m;
            decimal num4 = 3.0m;

            // Get the modulus of the two numbers and compare the result to the expected result
            Assert.IsTrue(_arith.Modulus(num3, num4) == num3 % num4);
            // Get the modulus of the two negated numbers and compare the result to the expected result
            Assert.IsTrue(_arith.Modulus(_arith.Negate(num3), _arith.Negate(num4)) == -num3 % -num4);

            float num5 = 1.0f;
            float num6 = 2.0f;

            // Get the modulus of the two numbers and compare the result to the expected result
            Assert.IsTrue(_arith.Modulus(num5, num6) == num5 % num6);
            // Get the modulus of the two negated numbers and compare the result to the expected result
            Assert.IsTrue(_arith.Modulus(_arith.Negate(num5), _arith.Negate(num6)) == -num5 % -num6);

            double num7 = 1.0;
            double num8 = 2.0;

            // Get the modulus of the two numbers and compare the result to the expected result
            Assert.IsTrue(_arith.Modulus(num7, num8) == num7 % num8);
            // Get the modulus of the two negated numbers and compare the result to the expected result
            Assert.IsTrue(_arith.Modulus(_arith.Negate(num7), _arith.Negate(num8)) == -num7 % -num8);
        }

        [TestMethod()]
        public void IncrementTest()
        {
            // basic increment tests
            int num1 = 1;

            Assert.IsTrue(_arith.Increment(num1) == ++num1);

            decimal num2 = 1.0m;

            Assert.IsTrue(_arith.Increment(num2) == ++num2);

            float num3 = 1.0f;

            Assert.IsTrue(_arith.Increment(num3) == ++num3);

            double num4 = 1.0;

            Assert.IsTrue(_arith.Increment(num4) == ++num4);
        }

        [TestMethod()]
        public void DecrementTest()
        {
            // basic decrement tests
            int num1 = 1;

            Assert.IsTrue(_arith.Decrement(num1) == --num1);

            decimal num2 = 1.0m;

            Assert.IsTrue(_arith.Decrement(num2) == --num2);

            float num3 = 1.0f;

            Assert.IsTrue(_arith.Decrement(num3) == --num3);

            double num4 = 1.0;

            Assert.IsTrue(_arith.Decrement(num4) == --num4);
        }

        [TestMethod()]
        public void NegateTest()
        {
            // basic negate tests
            int num1 = 1;

            Assert.IsTrue(_arith.Negate(num1) == -num1);

            decimal num2 = 1.0m;

            Assert.IsTrue(_arith.Negate(num2) == -num2);

            float num3 = 1.0f;

            Assert.IsTrue(_arith.Negate(num3) == -num3);

            double num4 = 1.0;

            Assert.IsTrue(_arith.Negate(num4) == -num4);
        }
    }
}