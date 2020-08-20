using System;
using System.Collections.Generic;
using Microsoft.AspNetCore.Mvc;

namespace SampleAPI.Controllers {
    [ApiController]
    [Route ("api/values")]
    public class ValuesController : ControllerBase {
        [HttpGet]
        [Route ("")]
        public IActionResult GetValues () {
            var values = new List<string> { "Value 4", "Value 5", "Value 6" };
            return Ok (values);
        }
    }
}