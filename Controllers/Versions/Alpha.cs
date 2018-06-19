using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace APIVersioning.Core.Controllers
{
    /// <summary>
    /// The Beta API controller which has now been deprecated
    /// </summary>
    [ApiVersion("0.1", Deprecated = false)]
    [Route("api/examples")]
    public class AlphaController : Controller
    {
        [HttpGet]
        [Route("get")]
        public String GetAlpha() => "This is the Alpha controller";
    }
}
