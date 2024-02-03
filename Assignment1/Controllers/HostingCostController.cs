using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace Assignment1.Controllers
{
    /// <summary>
    /// Receives an integer input representing a number of days,
    /// returns a series of strings detailing how much it would cost to
    /// purchase web hosting for that many days at the price of $5.50/Fortnight
    /// plus 13% tax
    /// </summary>
    /// <param name="id">integer input</param>
    /// <returns>string "Total = $(cost based on input) CAD" </returns>
    /// <example>
    /// GET localhost:xx/api/HostingCost/0 -> "1 fortnights at $5.50/FN = $5.50 CAD
    ///                                         HST 13% = $0.72 CAD
    ///                                         Total = $6.22 CAD"
    /// GET localhost:xx/api/HostingCost/14 -> "2 fortnights at $5.50/FN = $11 CAD
    ///                                         HST 13% = $1.43 CAD
    ///                                         Total = $12.43 CAD"
    /// GET localhost:xx/api/HostingCost/15 -> "2 fortnights at $5.50/FN = $11 CAD
    ///                                         HST 13% = $1.43 CAD
    ///                                         Total = $12.43 CAD"
    /// GET localhost:xx/api/HostingCost/21 -> "2 fortnights at $5.50/FN = $11 CAD
    ///                                         HST 13% = $1.43 CAD
    ///                                         Total = $12.43 CAD"
    /// GET localhost:xx/api/HostingCost/28 -> "3 fortnights at $5.50/FN = $16.5 CAD
    ///                                         HST 13% = $2.145 CAD
    ///                                         Total = $18.645 CAD"
    /// </example>

    [Route("api/[controller]/{id}")]
    [ApiController]
    public class HostingCostController : ControllerBase
    {
        public string Get(int id)
        {
            //First I divide the number of days (id) by 14 to figure out how
            //many fortnights are being charged for. I recieve this value as a
            //decimal because that is the value type later required to round.
            decimal FN = id / 14;
            //I add 1 to FN because I am rounding up to the nearest fortnight
            var upFN = FN + 1;
            //I then use the Math.Ceiling() function to round the decimal
            var roundFN = Math.Ceiling(upFN);
            //Then I convert the value type back into an integer using
            //Convert.ToInt32()
            var numRoundFN = Convert.ToInt32(roundFN);
            //Then I multiple the rounded number of fortnights by the rate to
            //get the inital cost
            var cost = 5.50 * numRoundFN;
            //I multiply the cost by 0.13 to get the hst value and then add
            //them together
            var hst = cost * 0.13;
            var totalCost = cost + hst;
            //I turn totalCost, cost, and hst into strings using .ToString()
            //and put "0.00" in the brackets in attempt to display only two
            //decimal places but it did not work
            totalCost.ToString("0.00");
            cost.ToString("0.00");
            hst.ToString("0.00");
            //I make 3 concatenated strings to combine the output phrases with
            //each corresponding value
            var totalMessage = String.Concat("Total = $" + totalCost + " CAD");
            var costMessage = String.Concat(upFN + " fortnights at $5.50/FN = $" + cost + " CAD");
            var taxMessage = String.Concat("HST 13% = $" + hst + " CAD");
            //I return a concatenated string of the previous 3 strings so that
            //I can include Environment.Newline which will present the final
            //string on 3 seperate lines
            return String.Concat(costMessage + Environment.NewLine + taxMessage + Environment.NewLine + totalMessage);
        }
    }
}
