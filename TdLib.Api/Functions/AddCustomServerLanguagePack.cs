using System;
using System.Threading.Tasks;
using Newtonsoft.Json;

// REUSE-IgnoreStart
namespace TdLib
{
    /// <summary>
    /// Autogenerated TDLib APIs
    /// </summary>
    public static partial class TdApi
    {
        /// <summary>
        /// Adds a custom server language pack to the list of installed language packs in current localization target. Can be called before authorization
        /// </summary>
        public class AddCustomServerLanguagePack : Function<Ok>
        {
            /// <summary>
            /// Data type for serialization
            /// </summary>
            [JsonProperty("@type")]
            public override string DataType { get; set; } = "addCustomServerLanguagePack";

            /// <summary>
            /// Extra data attached to the function
            /// </summary>
            [JsonProperty("@extra")]
            public override string Extra { get; set; }

            /// <summary>
            /// Identifier of a language pack to be added
            /// </summary>
            [JsonConverter(typeof(Converter))]
            [JsonProperty("language_pack_id")]
            public string LanguagePackId { get; set; }
        }

        /// <summary>
        /// Adds a custom server language pack to the list of installed language packs in current localization target. Can be called before authorization
        /// </summary>
        public static Task<Ok> AddCustomServerLanguagePackAsync(
            this Client client, string languagePackId = default)
        {
            return client.ExecuteAsync(new AddCustomServerLanguagePack
            {
                LanguagePackId = languagePackId
            });
        }
    }
}
// REUSE-IgnoreEnd