using System;

namespace net_core_svc_devops_sample.Commands
{
    /// <summary>
    /// Calculates simple operations between two numbers.
    /// </summary>
    /// <seealso cref="net_core_svc_devops_sample.Commands.ICalculator" />
    public class Calculator: ICalculator
    {
        /// <summary>
        /// Sums two numbers.
        /// </summary>
        /// <param name="number1">The number1.</param>
        /// <param name="number2">The number2.</param>
        /// <returns></returns>
        public double Sum(string number1, string number2)
        {
            if (!double.TryParse(number1, out var n1))
                throw new ArgumentOutOfRangeException(nameof(number1), "number 1 is not a number.");
            if (!double.TryParse(number2, out var n2))
                throw new ArgumentOutOfRangeException(nameof(number2), "number 2 is not a number.");
            return n1 + n2;
        }

        /// <summary>
        /// Subtracts two numbers.
        /// </summary>
        /// <param name="number1">The number1.</param>
        /// <param name="number2">The number2.</param>
        /// <returns></returns>
        public double Subtract(string number1, string number2)
        {
            if (!double.TryParse(number1, out var n1))
                throw new ArgumentOutOfRangeException(nameof(number1), "number 1 is not a number.");
            if (!double.TryParse(number2, out var n2))
                throw new ArgumentOutOfRangeException(nameof(number2), "number 2 is not a number.");
            return n1 - n2;
        }

        /// <summary>
        /// Multiplies two numbers.
        /// </summary>
        /// <param name="number1">The number1.</param>
        /// <param name="number2">The number2.</param>
        /// <returns></returns>
        public double Multiply(string number1, string number2)
        {
            if (!double.TryParse(number1, out var n1))
                throw new ArgumentOutOfRangeException(nameof(number1), "number 1 is not a number.");
            if (!double.TryParse(number2, out var n2))
                throw new ArgumentOutOfRangeException(nameof(number2), "number 2 is not a number.");
            return n1 * n2;
        }

        /// <summary>
        /// Divides two numbers.
        /// </summary>
        /// <param name="number1">The number1.</param>
        /// <param name="number2">The number2.</param>
        /// <returns></returns>
        public double Divide(string number1, string number2)
        {
            if (!double.TryParse(number1, out var n1))
                throw new ArgumentOutOfRangeException(nameof(number1), "number 1 is not a number.");
            if (!double.TryParse(number2, out var n2))
                throw new ArgumentOutOfRangeException(nameof(number2), "number 2 is not a number.");
            if (n2 == 0d)
                throw new Exception("number 2 cannot be 0.");
            return n1 / n2;
        }
    }
}