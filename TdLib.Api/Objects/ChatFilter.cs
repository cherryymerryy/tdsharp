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
        /// Represents a filter of user chats
        /// </summary>
        public partial class ChatFilter : Object
        {
            /// <summary>
            /// Data type for serialization
            /// </summary>
            [JsonProperty("@type")]
            public override string DataType { get; set; } = "chatFilter";

            /// <summary>
            /// Extra data attached to the object
            /// </summary>
            [JsonProperty("@extra")]
            public override string Extra { get; set; }

            /// <summary>
            /// The title of the filter; 1-12 characters without line feeds
            /// </summary>
            [JsonConverter(typeof(Converter))]
            [JsonProperty("title")]
            public string Title { get; set; }

            /// <summary>
            /// The chosen icon name for short filter representation. If non-empty, must be one of "All", "Unread", "Unmuted", "Bots", "Channels", "Groups", "Private", "Custom", "Setup", "Cat", "Crown", "Favorite", "Flower", "Game", "Home", "Love", "Mask", "Party", "Sport", "Study", "Trade", "Travel", "Work".
            /// </summary>
            [JsonConverter(typeof(Converter))]
            [JsonProperty("icon_name")]
            public string IconName { get; set; }

            /// <summary>
            /// The chat identifiers of pinned chats in the filtered chat list
            /// </summary>
            [JsonProperty("pinned_chat_ids", ItemConverterType = typeof(Converter))]
            public long[] PinnedChatIds { get; set; }

            /// <summary>
            /// The chat identifiers of always included chats in the filtered chat list
            /// </summary>
            [JsonProperty("included_chat_ids", ItemConverterType = typeof(Converter))]
            public long[] IncludedChatIds { get; set; }

            /// <summary>
            /// The chat identifiers of always excluded chats in the filtered chat list
            /// </summary>
            [JsonProperty("excluded_chat_ids", ItemConverterType = typeof(Converter))]
            public long[] ExcludedChatIds { get; set; }

            /// <summary>
            /// True, if muted chats need to be excluded
            /// </summary>
            [JsonConverter(typeof(Converter))]
            [JsonProperty("exclude_muted")]
            public bool ExcludeMuted { get; set; }

            /// <summary>
            /// True, if read chats need to be excluded
            /// </summary>
            [JsonConverter(typeof(Converter))]
            [JsonProperty("exclude_read")]
            public bool ExcludeRead { get; set; }

            /// <summary>
            /// True, if archived chats need to be excluded
            /// </summary>
            [JsonConverter(typeof(Converter))]
            [JsonProperty("exclude_archived")]
            public bool ExcludeArchived { get; set; }

            /// <summary>
            /// True, if contacts need to be included
            /// </summary>
            [JsonConverter(typeof(Converter))]
            [JsonProperty("include_contacts")]
            public bool IncludeContacts { get; set; }

            /// <summary>
            /// True, if non-contact users need to be included
            /// </summary>
            [JsonConverter(typeof(Converter))]
            [JsonProperty("include_non_contacts")]
            public bool IncludeNonContacts { get; set; }

            /// <summary>
            /// True, if bots need to be included
            /// </summary>
            [JsonConverter(typeof(Converter))]
            [JsonProperty("include_bots")]
            public bool IncludeBots { get; set; }

            /// <summary>
            /// True, if basic groups and supergroups need to be included
            /// </summary>
            [JsonConverter(typeof(Converter))]
            [JsonProperty("include_groups")]
            public bool IncludeGroups { get; set; }

            /// <summary>
            /// True, if channels need to be included
            /// </summary>
            [JsonConverter(typeof(Converter))]
            [JsonProperty("include_channels")]
            public bool IncludeChannels { get; set; }
        }
    }
}