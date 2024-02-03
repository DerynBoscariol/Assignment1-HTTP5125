using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

//localhost:xx/api/square/{id}
namespace Assignment1.Controllers
{

    /// <summary>
    /// Receives an integer input, returns the
    /// input multiplied by itself
    /// </summary>
    /// <param name="id">integer input</param>
    /// <returns>id multiplied by itself </returns>
    /// <example>
    /// GET localhost:xx/api/Square/2 -> 4
    /// GET localhost:xx/api/Square/-2 -> 4
    /// GET localhost:xx/api/Square/10 -> 100
    /// </example>

    [Route("api/[controller]/{id}")]
    [ApiController]
    public class SquareController : ControllerBase
    {
        public int Get(int id)
        {
            return id * id;
        }
    }
}
