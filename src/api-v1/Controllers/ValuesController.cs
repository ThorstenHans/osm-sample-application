using System;
using System.Collections.Generic;
using Microsoft.AspNetCore.Mvc;

namespace SampleAPI.Controllers
{
    [ApiController]
    [Route("api/values")]
    public class ValuesController : ControllerBase
    {
        [HttpGet]
        [Route("")]
        public IActionResult GetValues()
        {
            var values = new List<string> { "Value 1", "Value 2", "Value 3" };
            return Ok(values);
        }
    }
}