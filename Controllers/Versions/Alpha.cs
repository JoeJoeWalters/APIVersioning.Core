using APIVersioning.Core.Common;
using Microsoft.AspNetCore.Mvc;
using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace APIVersioning.Core.Controllers.Alpha
{
    /// <summary>
    /// This object can be shared between Alpha items
    /// </summary>
    [JsonObject(MemberSerialization = MemberSerialization.OptOut)]
    public class CoreObject : BaseJsonObject
    {
        /// <summary>
        /// A Value that would only exist in Alpha objects
        /// </summary>
        [JsonProperty]
        public String AlphaValue { get; set; }
    }

    /// <summary>
    /// The Beta API controller which has now been deprecated
    /// </summary>
    [ApiVersion("0.1", Deprecated = true)]
    [Route("api/examples")]
    public class AlphaController : Controller
    {
        [HttpGet]
        [Route("get")]
        public String GetV03() => $"This is the Alpha V0.1 controller => {JsonConvert.SerializeObject(new CoreObject() { AlphaValue = "V0.1" })}";
    }
}
