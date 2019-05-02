using System;
using net_core_svc_devops_sample.Commands;
using NUnit.Framework;

namespace Tests
{
    /// <summary>
    /// calculator controller test class.
    /// </summary>
    public class CalculatorTest
    {
        /// <summary>
        /// Asserts the sum.
        /// </summary>
        [Test]
        public void Assert_Sum()
        {
            var calculator = new Calculator();
            var response = calculator.Sum("1", "2");
            Assert.IsNotNull(response);
            Assert.AreEqual(3, response);

            Assert.Throws<ArgumentOutOfRangeException>(() => calculator.Sum("3", "a"));
        }

        /// <summary>
        /// Asserts the subtract.
        /// </summary>
        [Test]
        public void Assert_Subtract()
        {
            var calculator = new Calculator();
            var response = calculator.Subtract("3", "1");
            Assert.IsNotNull(response);
            Assert.AreEqual(2, response);

            Assert.Throws<ArgumentOutOfRangeException>(() => calculator.Subtract("3", "a"));
        }

        /// <summary>
        /// Asserts the multiply.
        /// </summary>
        [Test]
        public void Assert_Multiply()
        {
            var calculator = new Calculator();
            var response = calculator.Multiply("3", "3");
            Assert.IsNotNull(response);
            Assert.AreEqual(9, response);

            Assert.Throws<ArgumentOutOfRangeException>(() => calculator.Multiply("3", "a"));
        }

        /// <summary>
        /// Asserts the divide.
        /// </summary>
        [Test]
        public void Assert_Divide()
        {
            var calculator = new Calculator();
            var response = calculator.Divide("10", "2");
            Assert.IsNotNull(response);
            Assert.AreEqual(5d, response);

            Assert.Throws<ArgumentOutOfRangeException>(() => calculator.Divide("3", "a"));

            Assert.Throws<Exception>(() => calculator.Divide("3", "0"));
        }
    }
}