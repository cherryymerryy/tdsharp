using System;
using Newtonsoft.Json;

namespace TdLib
{
    /// <summary>
    /// AUTOGENERATED: DO NOT EDIT!
    /// </summary>
    public partial class TdApi
    {
        public partial class PageBlock : Object
        {
            public class PageBlockSubheader : PageBlock
            {
                [JsonProperty("@type")] public override string DataType { get; set; } = "pageBlockSubheader";

                [JsonProperty("@extra")] public override string Extra { get; set; }

                [JsonConverter(typeof(Converter))]
                [JsonProperty("subheader")]
                public RichText Subheader { get; set; }
            }
        }
    }
}