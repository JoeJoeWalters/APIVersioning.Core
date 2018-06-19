using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace APIVersioning.Core.Controllers
{
    /// <summary>
    /// The Alpha API controller which has now been deprecated but 
    /// inherited the properties of the alpha controller
    /// </summary>
    [ApiVersion("0.2", Deprecated = false)]
    [ApiVersion("0.3", Deprecated = false)]
    [Route("api/examples")]
    public class BetaController : Controller
    {
        [HttpGet, MapToApiVersion("0.2")]
        [Route("get")]
        public String GetV02() => "This is the V0.2 Beta controller";

        [HttpGet, MapToApiVersion("0.3")]
        [Route("get")]
        public String GetV03() => "This is the V0.3 Beta controller";
    }
}
