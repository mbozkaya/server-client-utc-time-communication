using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using DistributedApi.Extension;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace DistributedApi.Controllers
{
    [Route("[controller]")]
    [ApiController]
    public class DateController : ControllerBase
    {
        [HttpGet("Get")]
        public IActionResult Get() => Ok(DateTime.Now.LocalizeTimeStamp());

        [HttpGet("Custom")]
        public IActionResult Custom(int year, int month, int day) => Ok(new DateTime(year, month, day).LocalizeTimeStamp());
    }
}
