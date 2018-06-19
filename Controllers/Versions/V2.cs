using APIVersioning.Core.Common;
using Microsoft.AspNetCore.Mvc;
using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace APIVersioning.Core.Controllers.V2
{
    /// <summary>
    /// This object can be shared between V2 items as it is breaks V1
    /// </summary>
    [JsonObject(MemberSerialization = MemberSerialization.OptOut)]
    public class CoreObject : BaseJsonObject
    {
        /// <summary>
        /// A Value that would only exist in V2 objects
        /// </summary>
        [JsonProperty]
        public String V2Value { get; set; }
    }

    /// <summary>
    /// Version 2.x controller with tagged methods per version
    /// </summary>
    [ApiVersion("2.0")]
    [Route("api/examples")]
    public class V2Controller : Controller
    {
        [HttpGet]
        [Route("get")]
        public String GetV20() => $"This is the V2.0 controller => {JsonConvert.SerializeObject(new CoreObject() { V2Value = "V2" })}";
    }
}
