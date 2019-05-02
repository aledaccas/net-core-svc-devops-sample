using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using net_core_svc_devops_sample.Commands;
using net_core_svc_devops_sample.Entities;

namespace net_core_svc_devops_sample.Controllers
{
    [Produces("application/json")]
    public class ExampleController : Controller
    {
        private readonly ICalculator _calculator;

        public ExampleController(ICalculator calculator)
        {
            _calculator = calculator;
        }

        [HttpGet]
        [Route("api/example/sum/{number1}/{number2}")]
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

        [HttpGet]
        [Route("api/example/subtract/{number1}/{number2}")]
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

        [HttpGet]
        [Route("api/example/multiply/{number1}/{number2}")]
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

        [HttpGet]
        [Route("api/example/divide/{number1}/{number2}")]
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