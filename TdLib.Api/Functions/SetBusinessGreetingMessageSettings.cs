using System;
using System.Threading.Tasks;
using Newtonsoft.Json;

namespace TdLib
{
    /// <summary>
    /// Autogenerated TDLib APIs
    /// </summary>
    public static partial class TdApi
    {
        /// <summary>
        /// Changes the business greeting message settings of the current user. Requires Telegram Business subscription
        /// </summary>
        public class SetBusinessGreetingMessageSettings : Function<Ok>
        {
            /// <summary>
            /// Data type for serialization
            /// </summary>
            [JsonProperty("@type")]
            public override string DataType { get; set; } = "setBusinessGreetingMessageSettings";

            /// <summary>
            /// Extra data attached to the function
            /// </summary>
            [JsonProperty("@extra")]
            public override string Extra { get; set; }

            /// <summary>
            /// The new settings for the greeting message of the business; pass null to disable the greeting message
            /// </summary>
            [JsonConverter(typeof(Converter))]
            [JsonProperty("greeting_message_settings")]
            public BusinessGreetingMessageSettings GreetingMessageSettings { get; set; }
        }

        /// <summary>
        /// Changes the business greeting message settings of the current user. Requires Telegram Business subscription
        /// </summary>
        public static Task<Ok> SetBusinessGreetingMessageSettingsAsync(
            this Client client, BusinessGreetingMessageSettings greetingMessageSettings = default)
        {
            return client.ExecuteAsync(new SetBusinessGreetingMessageSettings
            {
                GreetingMessageSettings = greetingMessageSettings
            });
        }
    }
}