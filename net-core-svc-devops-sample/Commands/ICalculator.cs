namespace net_core_svc_devops_sample.Commands
{
    /// <summary>
    /// Calculator interface.
    /// </summary>
    public interface ICalculator
    {
        /// <summary>
        /// Sums two numbers.
        /// </summary>
        /// <param name="number1">The number1.</param>
        /// <param name="number2">The number2.</param>
        /// <returns></returns>
        double Sum(string number1, string number2);

        /// <summary>
        /// Subtracts two numbers.
        /// </summary>
        /// <param name="number1">The number1.</param>
        /// <param name="number2">The number2.</param>
        /// <returns></returns>
        double Subtract(string number1, string number2);

        /// <summary>
        /// Multiplies two numbers.
        /// </summary>
        /// <param name="number1">The number1.</param>
        /// <param name="number2">The number2.</param>
        /// <returns></returns>
        double Multiply(string number1, string number2);

        /// <summary>
        /// Divides two numbers.
        /// </summary>
        /// <param name="number1">The number1.</param>
        /// <param name="number2">The number2.</param>
        /// <returns></returns>
        double Divide(string number1, string number2);
    }
}