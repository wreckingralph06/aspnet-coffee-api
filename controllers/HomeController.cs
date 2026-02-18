using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.StaticAssets;
using System;

namespace coffeeTime.controllers
{
    [ApiController]
    [Route("[controller]")]
    public class CoffeeController : ControllerBase
    {
        public static int callCounter = 0;
        public static string orderMessage = "Your piping hot coffee is ready";

        [HttpGet("/brew-coffee")]
        public IActionResult DisplayOrders()
        {
            callCounter++;

            var todayDate = DateTime.Now;

            //var todayDate = new DateTime(2026, 4, 1);
            if (todayDate.Month == 4 && todayDate.Day == 1)
            {
                Response.StatusCode = 418;
                return new EmptyResult();
            }

            if (callCounter % 5 == 0)
            {
                Response.StatusCode = 503;
                return new EmptyResult();
            }

            var response = new
            {
                message = orderMessage,
                prepared = DateTimeOffset.Now.ToString("o")
            };

            return Ok(response); 
        }
    }
}
