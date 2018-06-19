using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace APIVersioning.Core.Controllers.Versions
{
    /// <summary>
    /// Version 1.x controller with tagged methods per version
    /// </summary>
    [ApiVersion("1.0")]
    [ApiVersion("1.1")]
    [ApiVersion("1.2")]
    [Route("api/examples")]
    public class V1Controller : Controller
    {
        [HttpGet, MapToApiVersion("1.0")]
        [Route("get")]
        public String GetV10() => "This is the V1.0 controller";

        [HttpGet, MapToApiVersion("1.1")]
        [Route("get")]
        public String GetV11() => "This is the V1.1 controller";

        [HttpGet, MapToApiVersion("1.2")]
        [Route("get")]
        public String GetV12() => "This is the V1.2 controller";
    }
}
