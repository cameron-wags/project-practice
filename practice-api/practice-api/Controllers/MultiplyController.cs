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
        //[Route("api/Math/Multiply")]
        public IActionResult Get()
        {
            return Ok();
        }

        //[HttpGet]
        //public IActionResult Divide(int arg1, int arg2)
        //{
        //    if (arg2 == 0)
        //    {
        //        return BadRequest("Cannot divide by zero");
        //    }
        //    else
        //    {
        //        return Ok(arg1 / arg2);
        //    }
        //}
    }
}