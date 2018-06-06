using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace practice_api.Controllers
{
    [Produces("application/json")]
    [Route("api/Mod")]
    public class ModController : Controller
    {
        public string Get([FromQuery] string value1, [FromQuery] string value2)
        {
            var result = "";
            try
            {
                result = (int.Parse(value1) % int.Parse(value2)).ToString();
            }
            catch (ArgumentNullException e)
            {
                result = "Null input";
            }
            catch (FormatException e)
            {
                result = "Invalid input";
            }

            return result;
        }
    }
}