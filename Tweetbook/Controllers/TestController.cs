
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Tweetbook.Controllers
{
    public class TestController : Controller
    {
        [HttpGet("api/user")]
        public IActionResult Get()
        {
            return Ok(new { name = "Mike" });
        }
        [HttpGet("aaa/test")]
        public IActionResult GetMore()
        {
            return Ok(new { test = "TEST!" });
        }
    }
}
