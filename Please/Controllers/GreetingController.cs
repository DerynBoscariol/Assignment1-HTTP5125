using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

//localhost:xx/api/Greeting/{id}
namespace Assignment1.Controllers
{
    /// <summary>
    /// Returns string "Hello World!" through a POST request
    /// </summary>
    /// <returns> string "Hello World!" </returns>
    /// <example>
    /// POST localhost:xx/api/Greeting -> "Hello World!"
    /// </example>

    [ApiController]
    public class GreetingController : ControllerBase
    {
        [Route("api/[controller]")]
        public string Post()
        {
            
            return "Hello World!";

        }


        /// <summary>
        /// Receives an int input, returns a greeting message with the input
        /// </summary>
        /// <param name="id">int input</param>
        /// <returns>string "Greetings to {id} people!" </returns>
        /// <example>
        /// GET localhost:xx/api/Greeting/3 -> "Greetings to 3 people!"
        /// GET localhost:xx/api/Greeting/6 -> "Greetings to 6 people!"
        /// GET localhost:xx/api/Greeting/0 -> "Greetings to 0 people!"
        /// </example>
        [Route("api/[controller]/{id}")]
        public string Get(int id)
        {
            
            string message = String.Concat("Greetings to " + id + " people!");
            return message;

        }

    }
}
