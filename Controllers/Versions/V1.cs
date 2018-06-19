using APIVersioning.Core.Common;
using Microsoft.AspNetCore.Mvc;
using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace APIVersioning.Core.Controllers.V1
{
    /// <summary>
    /// This object can be shared between V1 items as it is breaks Beta
    /// </summary>
    [JsonObject(MemberSerialization = MemberSerialization.OptOut)]
    public class CoreObject : BaseJsonObject
    {
        /// <summary>
        /// A Value that would only exist in V1 objects
        /// </summary>
        [JsonProperty]
        public String V1Value { get; set; }
    }

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
        public String GetV10() => $"This is the V1.0 controller => {JsonConvert.SerializeObject(new CoreObject() { V1Value = "V1.0" })}";

        [HttpGet, MapToApiVersion("1.1")]
        [Route("get")]
        public String GetV11() => $"This is the V1.0 controller => {JsonConvert.SerializeObject(new CoreObject() { V1Value = "V1.1" })}";

        [HttpGet, MapToApiVersion("1.2")]
        [Route("get")]
        public String GetV12() => $"This is the V1.0 controller => {JsonConvert.SerializeObject(new CoreObject() { V1Value = "V1.2" })}";
    }
}
