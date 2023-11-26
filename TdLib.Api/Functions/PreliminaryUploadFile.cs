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
        /// Preliminary uploads a file to the cloud before sending it in a message, which can be useful for uploading of being recorded voice and video notes. Updates updateFile will be used
        /// to notify about upload progress and successful completion of the upload. The file will not have a persistent remote identifier until it is sent in a message
        /// </summary>
        public class PreliminaryUploadFile : Function<File>
        {
            /// <summary>
            /// Data type for serialization
            /// </summary>
            [JsonProperty("@type")]
            public override string DataType { get; set; } = "preliminaryUploadFile";

            /// <summary>
            /// Extra data attached to the function
            /// </summary>
            [JsonProperty("@extra")]
            public override string Extra { get; set; }

            /// <summary>
            /// File to upload
            /// </summary>
            [JsonConverter(typeof(Converter))]
            [JsonProperty("file")]
            public InputFile File { get; set; }

            /// <summary>
            /// File type; pass null if unknown
            /// </summary>
            [JsonConverter(typeof(Converter))]
            [JsonProperty("file_type")]
            public FileType FileType { get; set; }

            /// <summary>
            /// Priority of the upload (1-32). The higher the priority, the earlier the file will be uploaded. If the priorities of two files are equal, then the first one for which preliminaryUploadFile was called will be uploaded first
            /// </summary>
            [JsonConverter(typeof(Converter))]
            [JsonProperty("priority")]
            public int Priority { get; set; }
        }

        /// <summary>
        /// Preliminary uploads a file to the cloud before sending it in a message, which can be useful for uploading of being recorded voice and video notes. Updates updateFile will be used
        /// to notify about upload progress and successful completion of the upload. The file will not have a persistent remote identifier until it is sent in a message
        /// </summary>
        public static Task<File> PreliminaryUploadFileAsync(
            this Client client, InputFile file = default, FileType fileType = default, int priority = default)
        {
            return client.ExecuteAsync(new PreliminaryUploadFile
            {
                File = file, FileType = fileType, Priority = priority
            });
        }
    }
}