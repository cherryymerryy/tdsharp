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
        /// Downloads a file from the cloud. Download progress and completion of the download will be notified through updateFile updates
        /// </summary>
        public class DownloadFile : Function<File>
        {
            /// <summary>
            /// Data type for serialization
            /// </summary>
            [JsonProperty("@type")]
            public override string DataType { get; set; } = "downloadFile";

            /// <summary>
            /// Extra data attached to the function
            /// </summary>
            [JsonProperty("@extra")]
            public override string Extra { get; set; }

            /// <summary>
            /// Identifier of the file to download
            /// </summary>
            [JsonConverter(typeof(Converter))]
            [JsonProperty("file_id")]
            public int FileId { get; set; }

            /// <summary>
            /// Priority of the download (1-32). The higher the priority, the earlier the file will be downloaded. If the priorities of two files are equal, then the last one for which downloadFile/addFileToDownloads was called will be downloaded first
            /// </summary>
            [JsonConverter(typeof(Converter))]
            [JsonProperty("priority")]
            public int Priority { get; set; }

            /// <summary>
            /// The starting position from which the file needs to be downloaded
            /// </summary>
            [JsonConverter(typeof(Converter))]
            [JsonProperty("offset")]
            public long Offset { get; set; }

            /// <summary>
            /// Number of bytes which need to be downloaded starting from the "offset" position before the download will automatically be canceled; use 0 to download without a limit
            /// </summary>
            [JsonConverter(typeof(Converter))]
            [JsonProperty("limit")]
            public long Limit { get; set; }

            /// <summary>
            /// Pass true to return response only after the file download has succeeded, has failed, has been canceled, or a new downloadFile request with different offset/limit parameters was sent; pass false to return file state immediately, just after the download has been started
            /// </summary>
            [JsonConverter(typeof(Converter))]
            [JsonProperty("synchronous")]
            public bool Synchronous { get; set; }
        }

        /// <summary>
        /// Downloads a file from the cloud. Download progress and completion of the download will be notified through updateFile updates
        /// </summary>
        public static Task<File> DownloadFileAsync(
            this Client client, int fileId = default, int priority = default, long offset = default, long limit = default, bool synchronous = default)
        {
            return client.ExecuteAsync(new DownloadFile
            {
                FileId = fileId, Priority = priority, Offset = offset, Limit = limit, Synchronous = synchronous
            });
        }
    }
}