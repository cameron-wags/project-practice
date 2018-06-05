using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace practice_api.Controllers
{
    [Produces("application/json")]
    [Route("api/Divide")]
    public class DivideController : Controller
    {
        public string Get([FromQuery] string arg1, [FromQuery] string arg2)
        {

            return (int.Parse(arg1) / int.Parse(arg2)).ToString();
        }
    }
}