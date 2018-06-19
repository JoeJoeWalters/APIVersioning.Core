using APIVersioning.Core.Common;
using Microsoft.AspNetCore.Mvc;
using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace APIVersioning.Core.Controllers.Beta
{
    /// <summary>
    /// This object can be shared between Alpha items as it is breaks Alpha
    /// </summary>
    [JsonObject(MemberSerialization = MemberSerialization.OptOut)]
    public class CoreObject : BaseJsonObject
    {
        /// <summary>
        /// A Value that would only exist in Beta objects
        /// </summary>
        [JsonProperty]
        public String BetaValue { get; set; }
    }

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
        public String GetV02() => $"This is the Beta V0.2 controller => {JsonConvert.SerializeObject(new CoreObject() { BetaValue = "V0.1" })}";

        [HttpGet, MapToApiVersion("0.3")]
        [Route("get")]
        public String GetV03() => $"This is the Beta V0.3 controller => {JsonConvert.SerializeObject(new CoreObject() { BetaValue = "V0.3" })}";
    }
}
