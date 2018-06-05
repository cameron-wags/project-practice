﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace practice_api.Controllers
{
    [Produces("application/json")]
    [Route("api/Mod")]
    public class DivideController : Controller
    {
        public string Get([FromQuery] string value1, [FromQuery] string value2)
        {

            return (int.Parse(value1) / int.Parse(value2)).ToString();
        }
    }
}