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
        /// Resets list of installed backgrounds to its default value
        /// </summary>
        public class ResetInstalledBackgrounds : Function<Ok>
        {
            /// <summary>
            /// Data type for serialization
            /// </summary>
            [JsonProperty("@type")]
            public override string DataType { get; set; } = "resetInstalledBackgrounds";

            /// <summary>
            /// Extra data attached to the function
            /// </summary>
            [JsonProperty("@extra")]
            public override string Extra { get; set; }


        }

        /// <summary>
        /// Resets list of installed backgrounds to its default value
        /// </summary>
        public static Task<Ok> ResetInstalledBackgroundsAsync(
            this Client client)
        {
            return client.ExecuteAsync(new ResetInstalledBackgrounds
            {
                
            });
        }
    }
}
// REUSE-IgnoreEnd