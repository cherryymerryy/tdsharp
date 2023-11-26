using System;
using Newtonsoft.Json;

namespace TdLib
{
    /// <summary>
    /// Autogenerated TDLib APIs
    /// </summary>
    public static partial class TdApi
    {
        /// <summary>
        /// Contains information about one session in a Telegram application used by the current user. Sessions must be shown to the user in the returned order
        /// </summary>
        public partial class Session : Object
        {
            /// <summary>
            /// Data type for serialization
            /// </summary>
            [JsonProperty("@type")]
            public override string DataType { get; set; } = "session";

            /// <summary>
            /// Extra data attached to the object
            /// </summary>
            [JsonProperty("@extra")]
            public override string Extra { get; set; }

            /// <summary>
            /// Session identifier
            /// </summary>
            [JsonConverter(typeof(Converter.Int64))]
            [JsonProperty("id")]
            public long Id { get; set; }

            /// <summary>
            /// True, if this session is the current session
            /// </summary>
            [JsonConverter(typeof(Converter))]
            [JsonProperty("is_current")]
            public bool IsCurrent { get; set; }

            /// <summary>
            /// True, if a 2-step verification password is needed to complete authorization of the session
            /// </summary>
            [JsonConverter(typeof(Converter))]
            [JsonProperty("is_password_pending")]
            public bool IsPasswordPending { get; set; }

            /// <summary>
            /// True, if the session wasn't confirmed from another session
            /// </summary>
            [JsonConverter(typeof(Converter))]
            [JsonProperty("is_unconfirmed")]
            public bool IsUnconfirmed { get; set; }

            /// <summary>
            /// True, if incoming secret chats can be accepted by the session
            /// </summary>
            [JsonConverter(typeof(Converter))]
            [JsonProperty("can_accept_secret_chats")]
            public bool CanAcceptSecretChats { get; set; }

            /// <summary>
            /// True, if incoming calls can be accepted by the session
            /// </summary>
            [JsonConverter(typeof(Converter))]
            [JsonProperty("can_accept_calls")]
            public bool CanAcceptCalls { get; set; }

            /// <summary>
            /// Session type based on the system and application version, which can be used to display a corresponding icon
            /// </summary>
            [JsonConverter(typeof(Converter))]
            [JsonProperty("type")]
            public SessionType Type { get; set; }

            /// <summary>
            /// Telegram API identifier, as provided by the application
            /// </summary>
            [JsonConverter(typeof(Converter))]
            [JsonProperty("api_id")]
            public int ApiId { get; set; }

            /// <summary>
            /// Name of the application, as provided by the application
            /// </summary>
            [JsonConverter(typeof(Converter))]
            [JsonProperty("application_name")]
            public string ApplicationName { get; set; }

            /// <summary>
            /// The version of the application, as provided by the application
            /// </summary>
            [JsonConverter(typeof(Converter))]
            [JsonProperty("application_version")]
            public string ApplicationVersion { get; set; }

            /// <summary>
            /// True, if the application is an official application or uses the api_id of an official application
            /// </summary>
            [JsonConverter(typeof(Converter))]
            [JsonProperty("is_official_application")]
            public bool IsOfficialApplication { get; set; }

            /// <summary>
            /// Model of the device the application has been run or is running on, as provided by the application
            /// </summary>
            [JsonConverter(typeof(Converter))]
            [JsonProperty("device_model")]
            public string DeviceModel { get; set; }

            /// <summary>
            /// Operating system the application has been run or is running on, as provided by the application
            /// </summary>
            [JsonConverter(typeof(Converter))]
            [JsonProperty("platform")]
            public string Platform { get; set; }

            /// <summary>
            /// Version of the operating system the application has been run or is running on, as provided by the application
            /// </summary>
            [JsonConverter(typeof(Converter))]
            [JsonProperty("system_version")]
            public string SystemVersion { get; set; }

            /// <summary>
            /// Point in time (Unix timestamp) when the user has logged in
            /// </summary>
            [JsonConverter(typeof(Converter))]
            [JsonProperty("log_in_date")]
            public int LogInDate { get; set; }

            /// <summary>
            /// Point in time (Unix timestamp) when the session was last used
            /// </summary>
            [JsonConverter(typeof(Converter))]
            [JsonProperty("last_active_date")]
            public int LastActiveDate { get; set; }

            /// <summary>
            /// IP address from which the session was created, in human-readable format
            /// </summary>
            [JsonConverter(typeof(Converter))]
            [JsonProperty("ip_address")]
            public string IpAddress { get; set; }

            /// <summary>
            /// A human-readable description of the location from which the session was created, based on the IP address
            /// </summary>
            [JsonConverter(typeof(Converter))]
            [JsonProperty("location")]
            public string Location { get; set; }
        }
    }
}