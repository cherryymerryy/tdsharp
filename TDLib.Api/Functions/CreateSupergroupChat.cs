using System;
using Newtonsoft.Json;

namespace TdLib
{
    /// <summary>
    /// AUTOGENERATED: DO NOT EDIT!
    /// </summary>
    public partial class TdApi
    {
        public class CreateSupergroupChat : Function<Chat>
        {
            [JsonProperty("@type")] public override string DataType { get; set; } = "createSupergroupChat";

            [JsonProperty("@extra")] public override string Extra { get; set; }

            [JsonConverter(typeof(Converter))]
            [JsonProperty("supergroup_id")]
            public int SupergroupId { get; set; }

            [JsonConverter(typeof(Converter))]
            [JsonProperty("force")]
            public bool Force { get; set; }
        }
    }
}