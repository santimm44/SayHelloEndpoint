using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;

namespace SayHelloEndpoint.Controllers
{
    [ApiController]
    [Route("api/[controller]")]
    public class SayHelloController : ControllerBase
    {
        [HttpPost]
        [Route("Greetings/{userInput}")]
        public string GreetUser(string userInput)
        {
            return "Hello, " + userInput + ".";
        }

    }
}