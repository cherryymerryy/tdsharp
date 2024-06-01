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
        /// Process new chats added to a shareable chat folder by its owner
        /// </summary>
        public class ProcessChatFolderNewChats : Function<Ok>
        {
            /// <summary>
            /// Data type for serialization
            /// </summary>
            [JsonProperty("@type")]
            public override string DataType { get; set; } = "processChatFolderNewChats";

            /// <summary>
            /// Extra data attached to the function
            /// </summary>
            [JsonProperty("@extra")]
            public override string Extra { get; set; }

            /// <summary>
            /// Chat folder identifier
            /// </summary>
            [JsonConverter(typeof(Converter))]
            [JsonProperty("chat_folder_id")]
            public int ChatFolderId { get; set; }

            /// <summary>
            /// Identifiers of the new chats, which are added to the chat folder. The chats are automatically joined if they aren't joined yet
            /// </summary>
            [JsonProperty("added_chat_ids", ItemConverterType = typeof(Converter))]
            public long[] AddedChatIds { get; set; }
        }

        /// <summary>
        /// Process new chats added to a shareable chat folder by its owner
        /// </summary>
        public static Task<Ok> ProcessChatFolderNewChatsAsync(
            this Client client, int chatFolderId = default, long[] addedChatIds = default)
        {
            return client.ExecuteAsync(new ProcessChatFolderNewChats
            {
                ChatFolderId = chatFolderId, AddedChatIds = addedChatIds
            });
        }
    }
}
// REUSE-IgnoreEnd