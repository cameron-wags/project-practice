using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace practice_api.Controllers
{
    [Produces("application/json")]
    [Route("api/Multiply")]
    public class MultiplyController : Controller
    {
        [HttpGet]
        public string Get([FromQuery] string value1, [FromQuery] string value2)
        {
            int val1, val2;
            try
            {
                val1 = int.Parse(value1);
                val2 = int.Parse(value2);
            }
            catch (Exception e)
            {
                return "";
            }
            return (""+(val1*val2)+"");
        }

    }
}