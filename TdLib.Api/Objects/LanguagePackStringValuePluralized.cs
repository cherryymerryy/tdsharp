using System;
using Newtonsoft.Json;

namespace TdLib
{
    /// <summary>
    /// Autogenerated TDLib APIs
    /// </summary>
    public static partial class TdApi
    {
        public partial class LanguagePackStringValue : Object
        {
            /// <summary>
            /// A language pack string which has different forms based on the number of some object it mentions. See https://www.unicode.org/cldr/charts/latest/supplemental/language_plural_rules.html for more information
            /// </summary>
            public class LanguagePackStringValuePluralized : LanguagePackStringValue
            {
                /// <summary>
                /// Data type for serialization
                /// </summary>
                [JsonProperty("@type")]
                public override string DataType { get; set; } = "languagePackStringValuePluralized";

                /// <summary>
                /// Extra data attached to the message
                /// </summary>
                [JsonProperty("@extra")]
                public override string Extra { get; set; }

                /// <summary>
                /// Value for zero objects
                /// </summary>
                [JsonConverter(typeof(Converter))]
                [JsonProperty("zero_value")]
                public string ZeroValue { get; set; }

                /// <summary>
                /// Value for one object
                /// </summary>
                [JsonConverter(typeof(Converter))]
                [JsonProperty("one_value")]
                public string OneValue { get; set; }

                /// <summary>
                /// Value for two objects
                /// </summary>
                [JsonConverter(typeof(Converter))]
                [JsonProperty("two_value")]
                public string TwoValue { get; set; }

                /// <summary>
                /// Value for few objects
                /// </summary>
                [JsonConverter(typeof(Converter))]
                [JsonProperty("few_value")]
                public string FewValue { get; set; }

                /// <summary>
                /// Value for many objects
                /// </summary>
                [JsonConverter(typeof(Converter))]
                [JsonProperty("many_value")]
                public string ManyValue { get; set; }

                /// <summary>
                /// Default value
                /// </summary>
                [JsonConverter(typeof(Converter))]
                [JsonProperty("other_value")]
                public string OtherValue { get; set; }
            }
        }
    }
}