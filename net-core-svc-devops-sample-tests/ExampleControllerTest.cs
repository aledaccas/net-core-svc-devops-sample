using Microsoft.AspNetCore.Mvc;
using net_core_svc_devops_sample.Controllers;
using net_core_svc_devops_sample.Entities;
using NUnit.Framework;
using Tests.Mocks;

namespace Tests
{
    public class ExampleControllerTest
    {
        /// <summary>
        /// Asserts the sum.
        /// </summary>
        [Test]
        public void Assert_Sum()
        {
            var example = new ExampleController(CalculatorMock.GetMock());
            var response = example.Sum("1", "2");
            Assert.IsNotNull(response);
            Assert.AreEqual("3", ((Response)((OkObjectResult)response).Value).ResponseData);

            response = example.Sum("3", "a");
            Assert.IsNotNull(response);
            Assert.IsInstanceOf<BadRequestObjectResult>(response);
        }

        /// <summary>
        /// Asserts the subtract.
        /// </summary>
        [Test]
        public void Assert_Subtract()
        {
            var example = new ExampleController(CalculatorMock.GetMock());
            var response = example.Subtract("3", "1");
            Assert.IsNotNull(response);
            Assert.AreEqual("2", ((Response)((OkObjectResult)response).Value).ResponseData);

            response = example.Subtract("3", "a");
            Assert.IsNotNull(response);
            Assert.IsInstanceOf<BadRequestObjectResult>(response);
        }

        /// <summary>
        /// Asserts the multiply.
        /// </summary>
        [Test]
        public void Assert_Multiply()
        {
            var example = new ExampleController(CalculatorMock.GetMock());
            var response = example.Multiply("3", "3");
            Assert.IsNotNull(response);
            Assert.AreEqual("9", ((Response)((OkObjectResult)response).Value).ResponseData);

            response = example.Multiply("3", "a");
            Assert.IsNotNull(response);
            Assert.IsInstanceOf<BadRequestObjectResult>(response);
        }

        /// <summary>
        /// Asserts the divide.
        /// </summary>
        [Test]
        public void Assert_Divide()
        {
            var example = new ExampleController(CalculatorMock.GetMock());
            var response = example.divide("10", "2");
            Assert.IsNotNull(response);
            Assert.AreEqual("5", ((Response)((OkObjectResult)response).Value).ResponseData);

            response = example.divide("3", "a");
            Assert.IsNotNull(response);
            Assert.IsInstanceOf<BadRequestObjectResult>(response);

            response = example.divide("3", "0");
            Assert.IsNotNull(response);
            Assert.IsInstanceOf<BadRequestObjectResult>(response);
        }
    }
}