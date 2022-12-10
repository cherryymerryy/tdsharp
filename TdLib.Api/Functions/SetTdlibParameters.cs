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
        /// Sets the parameters for TDLib initialization. Works only when the current authorization state is authorizationStateWaitTdlibParameters
        /// </summary>
        public class SetTdlibParameters : Function<Ok>
        {
            /// <summary>
            /// Data type for serialization
            /// </summary>
            [JsonProperty("@type")]
            public override string DataType { get; set; } = "setTdlibParameters";

            /// <summary>
            /// Extra data attached to the function
            /// </summary>
            [JsonProperty("@extra")]
            public override string Extra { get; set; }

            /// <summary>
            /// Pass true to use Telegram test environment instead of the production environment
            /// </summary>
            [JsonConverter(typeof(Converter))]
            [JsonProperty("use_test_dc")]
            public bool UseTestDc { get; set; }

            /// <summary>
            /// The path to the directory for the persistent database; if empty, the current working directory will be used
            /// </summary>
            [JsonConverter(typeof(Converter))]
            [JsonProperty("database_directory")]
            public string DatabaseDirectory { get; set; }

            /// <summary>
            /// The path to the directory for storing files; if empty, database_directory will be used
            /// </summary>
            [JsonConverter(typeof(Converter))]
            [JsonProperty("files_directory")]
            public string FilesDirectory { get; set; }

            /// <summary>
            /// Encryption key for the database
            /// </summary>
            [JsonConverter(typeof(Converter))]
            [JsonProperty("database_encryption_key")]
            public byte[] DatabaseEncryptionKey { get; set; }

            /// <summary>
            /// Pass true to keep information about downloaded and uploaded files between application restarts
            /// </summary>
            [JsonConverter(typeof(Converter))]
            [JsonProperty("use_file_database")]
            public bool UseFileDatabase { get; set; }

            /// <summary>
            /// Pass true to keep cache of users, basic groups, supergroups, channels and secret chats between restarts. Implies use_file_database
            /// </summary>
            [JsonConverter(typeof(Converter))]
            [JsonProperty("use_chat_info_database")]
            public bool UseChatInfoDatabase { get; set; }

            /// <summary>
            /// Pass true to keep cache of chats and messages between restarts. Implies use_chat_info_database
            /// </summary>
            [JsonConverter(typeof(Converter))]
            [JsonProperty("use_message_database")]
            public bool UseMessageDatabase { get; set; }

            /// <summary>
            /// Pass true to enable support for secret chats
            /// </summary>
            [JsonConverter(typeof(Converter))]
            [JsonProperty("use_secret_chats")]
            public bool UseSecretChats { get; set; }

            /// <summary>
            /// Application identifier for Telegram API access, which can be obtained at https://my.telegram.org
            /// </summary>
            [JsonConverter(typeof(Converter))]
            [JsonProperty("api_id")]
            public int ApiId { get; set; }

            /// <summary>
            /// Application identifier hash for Telegram API access, which can be obtained at https://my.telegram.org
            /// </summary>
            [JsonConverter(typeof(Converter))]
            [JsonProperty("api_hash")]
            public string ApiHash { get; set; }

            /// <summary>
            /// IETF language tag of the user's operating system language; must be non-empty
            /// </summary>
            [JsonConverter(typeof(Converter))]
            [JsonProperty("system_language_code")]
            public string SystemLanguageCode { get; set; }

            /// <summary>
            /// Model of the device the application is being run on; must be non-empty
            /// </summary>
            [JsonConverter(typeof(Converter))]
            [JsonProperty("device_model")]
            public string DeviceModel { get; set; }

            /// <summary>
            /// Version of the operating system the application is being run on. If empty, the version is automatically detected by TDLib
            /// </summary>
            [JsonConverter(typeof(Converter))]
            [JsonProperty("system_version")]
            public string SystemVersion { get; set; }

            /// <summary>
            /// Application version; must be non-empty
            /// </summary>
            [JsonConverter(typeof(Converter))]
            [JsonProperty("application_version")]
            public string ApplicationVersion { get; set; }

            /// <summary>
            /// Pass true to automatically delete old files in background
            /// </summary>
            [JsonConverter(typeof(Converter))]
            [JsonProperty("enable_storage_optimizer")]
            public bool EnableStorageOptimizer { get; set; }

            /// <summary>
            /// Pass true to ignore original file names for downloaded files. Otherwise, downloaded files are saved under names as close as possible to the original name
            /// </summary>
            [JsonConverter(typeof(Converter))]
            [JsonProperty("ignore_file_names")]
            public bool IgnoreFileNames { get; set; }
        }

        /// <summary>
        /// Sets the parameters for TDLib initialization. Works only when the current authorization state is authorizationStateWaitTdlibParameters
        /// </summary>
        public static Task<Ok> SetTdlibParametersAsync(
            this Client client, bool useTestDc = default, string databaseDirectory = default, string filesDirectory = default, byte[] databaseEncryptionKey = default, bool useFileDatabase = default, bool useChatInfoDatabase = default, bool useMessageDatabase = default, bool useSecretChats = default, int apiId = default, string apiHash = default, string systemLanguageCode = default, string deviceModel = default, string systemVersion = default, string applicationVersion = default, bool enableStorageOptimizer = default, bool ignoreFileNames = default)
        {
            return client.ExecuteAsync(new SetTdlibParameters
            {
                UseTestDc = useTestDc, DatabaseDirectory = databaseDirectory, FilesDirectory = filesDirectory, DatabaseEncryptionKey = databaseEncryptionKey, UseFileDatabase = useFileDatabase, UseChatInfoDatabase = useChatInfoDatabase, UseMessageDatabase = useMessageDatabase, UseSecretChats = useSecretChats, ApiId = apiId, ApiHash = apiHash, SystemLanguageCode = systemLanguageCode, DeviceModel = deviceModel, SystemVersion = systemVersion, ApplicationVersion = applicationVersion, EnableStorageOptimizer = enableStorageOptimizer, IgnoreFileNames = ignoreFileNames
            });
        }
    }
}