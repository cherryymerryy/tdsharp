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
        /// Changes a personal profile photo of a contact user
        /// </summary>
        public class SetUserPersonalProfilePhoto : Function<Ok>
        {
            /// <summary>
            /// Data type for serialization
            /// </summary>
            [JsonProperty("@type")]
            public override string DataType { get; set; } = "setUserPersonalProfilePhoto";

            /// <summary>
            /// Extra data attached to the function
            /// </summary>
            [JsonProperty("@extra")]
            public override string Extra { get; set; }

            /// <summary>
            /// User identifier
            /// </summary>
            [JsonConverter(typeof(Converter))]
            [JsonProperty("user_id")]
            public long UserId { get; set; }

            /// <summary>
            /// Profile photo to set; pass null to delete the photo; inputChatPhotoPrevious isn't supported in this function
            /// </summary>
            [JsonConverter(typeof(Converter))]
            [JsonProperty("photo")]
            public InputChatPhoto Photo { get; set; }
        }

        /// <summary>
        /// Changes a personal profile photo of a contact user
        /// </summary>
        public static Task<Ok> SetUserPersonalProfilePhotoAsync(
            this Client client, long userId = default, InputChatPhoto photo = default)
        {
            return client.ExecuteAsync(new SetUserPersonalProfilePhoto
            {
                UserId = userId, Photo = photo
            });
        }
    }
}
// REUSE-IgnoreEnd