using System;
using net_core_svc_devops_sample.Commands;
using NSubstitute;
using NSubstitute.ExceptionExtensions;

namespace Tests.Mocks
{
    /// <summary>
    /// Calculator Mock class.
    /// </summary>
    public static class CalculatorMock
    {
        /// <summary>
        /// Gets the mock.
        /// </summary>
        /// <returns></returns>
        public static ICalculator GetMock()
        {
            var calculator = Substitute.For<ICalculator>();

            calculator.Sum("1", "2").Returns(3);
            calculator.Subtract("3", "1").Returns(2);
            calculator.Multiply("3", "3").Returns(9);
            calculator.Divide("10", "2").Returns(5);
            calculator.Sum("3", "a").Throws(new ArgumentOutOfRangeException("", "number 2 is invalid."));
            calculator.Subtract("3", "a").Throws(new ArgumentOutOfRangeException("", "number 2 is invalid."));
            calculator.Multiply("3", "a").Throws(new ArgumentOutOfRangeException("", "number 2 is invalid."));
            calculator.Divide("3", "a").Throws(new ArgumentOutOfRangeException("", "number 2 is invalid."));
            calculator.Divide("3", "0").Throws(new ArgumentOutOfRangeException("", "number 2 can´t be 0."));
            
            return calculator;
        }
    }
}