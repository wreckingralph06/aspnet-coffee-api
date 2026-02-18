using coffeeTime.controllers;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Xunit;

namespace coffeeTime.tests
{
    public class CoffeeControllerTests
    {
        private CoffeeController CreateController()
        {
            var controller = new CoffeeController();

            controller.ControllerContext = new ControllerContext()
            {
                HttpContext = new DefaultHttpContext()
            };

            return controller;
        }

        [Fact]
        public void DisplayOrders_Return200Status()
        {
            var controller = CreateController();
            var result = controller.DisplayOrders();

            var response = Assert.IsType<OkObjectResult>(result);
            Assert.Equal(200, response.StatusCode ?? 200);
        }

        [Fact]
        public void DisplayOrders_Return503Status()
        {
            CoffeeController.callCounter = 0;

            var controller = CreateController();
            IActionResult result = null;

            for (int i = 1; i <= 5; i++)
            {
                result = controller.DisplayOrders();
            }

            Assert.IsType<EmptyResult>(result);
            Assert.Equal(503, controller.Response.StatusCode);
        }

        [Fact]
        public void DisplayOrders_Return418Status()
        {
            var controller = CreateController();
            var result = controller.DisplayOrders();

            Assert.IsType<EmptyResult>(result);
            Assert.Equal(418, controller.Response.StatusCode);
        }
    }
}