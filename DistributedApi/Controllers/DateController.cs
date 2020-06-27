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

        [HttpPost("Custom")]
        public IActionResult Custom(DTO.PostDto model) => Ok(new DateTime(model.Year, model.Month, model.Day, model.Hour, model.Minute, model.Second).LocalizeTimeStamp());
    }
}
