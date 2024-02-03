using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

//localhost:xx/api/NumberMachine/{id}
namespace Assignment1.Controllers
{
    /// <summary>
    /// Receives an integer input, returns the
    /// input after being multiplied by 2, added to by 4,
    /// multiplied by 3, and then subtracted 5 from.
    /// </summary>
    /// <param name="id">integer input</param>
    /// <returns>id multiplied by 2, plus four, multiplied by 3, minus 5 </returns>
    /// <example>
    /// GET localhost:xx/api/NumberMachine/10 -> 31
    /// GET localhost:xx/api/NumberMachine/-5  -> -23
    /// GET localhost:xx/api/NumberMachine/30  -> 187
    /// </example>
    
    [Route("api/[controller]/{id}")]
    [ApiController]
    public class NumberMachineController : ControllerBase
    {
        public int Get(int id)
        {
            int step1 = id * 2;
            int step2 = step1 + 4;
            int step3 = step2 * 3;
            int step4 = step3 - 5;

            return step4;

        }

    }
}
