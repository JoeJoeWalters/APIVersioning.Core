using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace APIVersioning.Core.Controllers.Versions
{
    /// <summary>
    /// Version 2.x controller with tagged methods per version
    /// </summary>
    [ApiVersion("2.0")]
    [Route("api/examples")]
    public class V2Controller : Controller
    {
        [HttpGet]
        [Route("get")]
        public String GetV20() => "This is the V2.0 controller";
    }
}
