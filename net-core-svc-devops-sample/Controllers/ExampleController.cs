using System;
using Microsoft.AspNetCore.Mvc;
using net_core_svc_devops_sample.Commands;
using net_core_svc_devops_sample.Entities;

namespace net_core_svc_devops_sample.Controllers
{
    /// <summary>
    /// Example controller class.
    /// </summary>
    /// <seealso cref="Microsoft.AspNetCore.Mvc.Controller" />
    [Produces("application/json")]
    public class ExampleController : Controller
    {
        /// <summary>
        /// The calculator
        /// </summary>
        private readonly ICalculator _calculator;

        /// <summary>
        /// Initializes a new instance of the <see cref="ExampleController"/> class.
        /// </summary>
        /// <param name="calculator">The calculator.</param>
        public ExampleController(ICalculator calculator)
        {
            _calculator = calculator;
        }

        /// <summary>
        /// Sums the specified number1.
        /// </summary>
        /// <param name="number1">The number1.</param>
        /// <param name="number2">The number2.</param>
        /// <returns></returns>
        [HttpGet]
        [Route("api/example/sum/{number1}/{number2}")]
        [ProducesResponseType(200)]
        [ProducesResponseType(400)]
        public IActionResult Sum(string number1, string number2)
        {
            try
            {
                return Ok(new Response { ResponseData = _calculator.Sum(number1, number2).ToString() });
            }
            catch (Exception e)
            {
                return BadRequest(e);
            }
        }

        /// <summary>
        /// Subtracts the specified number1.
        /// </summary>
        /// <param name="number1">The number1.</param>
        /// <param name="number2">The number2.</param>
        /// <returns></returns>
        [HttpGet]
        [Route("api/example/subtract/{number1}/{number2}")]
        [ProducesResponseType(200)]
        [ProducesResponseType(400)]
        public IActionResult Subtract(string number1, string number2)
        {
            try
            {
                return Ok(new Response { ResponseData = _calculator.Subtract(number1, number2).ToString() });
            }
            catch (Exception e)
            {
                return BadRequest(e);
            }
        }

        /// <summary>
        /// Multiplies the specified number1.
        /// </summary>
        /// <param name="number1">The number1.</param>
        /// <param name="number2">The number2.</param>
        /// <returns></returns>
        [HttpGet]
        [Route("api/example/multiply/{number1}/{number2}")]
        [ProducesResponseType(200)]
        [ProducesResponseType(400)]
        public IActionResult Multiply(string number1, string number2)
        {
            try
            {
                return Ok(new Response { ResponseData = _calculator.Multiply(number1, number2).ToString() });
            }
            catch (Exception e)
            {
                return BadRequest(e);
            }
        }

        /// <summary>
        /// Divides the specified number1.
        /// </summary>
        /// <param name="number1">The number1.</param>
        /// <param name="number2">The number2.</param>
        /// <returns></returns>
        [HttpGet]
        [Route("api/example/divide/{number1}/{number2}")]
        [ProducesResponseType(200)]
        [ProducesResponseType(400)]
        public IActionResult divide(string number1, string number2)
        {
            try
            {
                return Ok(new Response { ResponseData = _calculator.Divide(number1, number2).ToString() });
            }
            catch (Exception e)
            {
                return BadRequest(e);
            }

        }
    }
}