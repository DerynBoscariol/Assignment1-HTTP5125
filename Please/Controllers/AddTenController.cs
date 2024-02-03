using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

//localhost:xx/api/AddTen/{id}
namespace Assignment1.Controllers
{

    /// <summary>
    /// Receives an integer input, returns the sum of the input and ten
    /// </summary>
    /// <param name="id">integer input</param>
    /// <returns>The sum of the integer and ten</returns>
    /// <example>
    /// GET localhost:xx/api/AddTen/21 -> 31
    /// GET localhost:xx/api/AddTen/0 -> 10
    /// GET localhost:xx/api/AddTen/-9 -> 1
    /// </example>
    [Route("api/[controller]/{id}")]
    [ApiController]
    public class AddTenController : ControllerBase
    {
        public int Get(int id)
        {
            return id + 10;
        }
    }
}
