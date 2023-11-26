using System;
using Newtonsoft.Json;

namespace TdLib
{
    /// <summary>
    /// Autogenerated TDLib APIs
    /// </summary>
    public static partial class TdApi
    {
        public partial class ChatStatistics : Object
        {
            /// <summary>
            /// A detailed statistics about a channel chat
            /// </summary>
            public class ChatStatisticsChannel : ChatStatistics
            {
                /// <summary>
                /// Data type for serialization
                /// </summary>
                [JsonProperty("@type")]
                public override string DataType { get; set; } = "chatStatisticsChannel";

                /// <summary>
                /// Extra data attached to the message
                /// </summary>
                [JsonProperty("@extra")]
                public override string Extra { get; set; }

                /// <summary>
                /// A period to which the statistics applies
                /// </summary>
                [JsonConverter(typeof(Converter))]
                [JsonProperty("period")]
                public DateRange Period { get; set; }

                /// <summary>
                /// Number of members in the chat
                /// </summary>
                [JsonConverter(typeof(Converter))]
                [JsonProperty("member_count")]
                public StatisticalValue MemberCount { get; set; }

                /// <summary>
                /// Mean number of times the recently sent messages was viewed
                /// </summary>
                [JsonConverter(typeof(Converter))]
                [JsonProperty("mean_view_count")]
                public StatisticalValue MeanViewCount { get; set; }

                /// <summary>
                /// Mean number of times the recently sent messages was shared
                /// </summary>
                [JsonConverter(typeof(Converter))]
                [JsonProperty("mean_share_count")]
                public StatisticalValue MeanShareCount { get; set; }

                /// <summary>
                /// A percentage of users with enabled notifications for the chat; 0-100
                /// </summary>
                [JsonConverter(typeof(Converter))]
                [JsonProperty("enabled_notifications_percentage")]
                public double? EnabledNotificationsPercentage { get; set; }

                /// <summary>
                /// A graph containing number of members in the chat
                /// </summary>
                [JsonConverter(typeof(Converter))]
                [JsonProperty("member_count_graph")]
                public StatisticalGraph MemberCountGraph { get; set; }

                /// <summary>
                /// A graph containing number of members joined and left the chat
                /// </summary>
                [JsonConverter(typeof(Converter))]
                [JsonProperty("join_graph")]
                public StatisticalGraph JoinGraph { get; set; }

                /// <summary>
                /// A graph containing number of members muted and unmuted the chat
                /// </summary>
                [JsonConverter(typeof(Converter))]
                [JsonProperty("mute_graph")]
                public StatisticalGraph MuteGraph { get; set; }

                /// <summary>
                /// A graph containing number of message views in a given hour in the last two weeks
                /// </summary>
                [JsonConverter(typeof(Converter))]
                [JsonProperty("view_count_by_hour_graph")]
                public StatisticalGraph ViewCountByHourGraph { get; set; }

                /// <summary>
                /// A graph containing number of message views per source
                /// </summary>
                [JsonConverter(typeof(Converter))]
                [JsonProperty("view_count_by_source_graph")]
                public StatisticalGraph ViewCountBySourceGraph { get; set; }

                /// <summary>
                /// A graph containing number of new member joins per source
                /// </summary>
                [JsonConverter(typeof(Converter))]
                [JsonProperty("join_by_source_graph")]
                public StatisticalGraph JoinBySourceGraph { get; set; }

                /// <summary>
                /// A graph containing number of users viewed chat messages per language
                /// </summary>
                [JsonConverter(typeof(Converter))]
                [JsonProperty("language_graph")]
                public StatisticalGraph LanguageGraph { get; set; }

                /// <summary>
                /// A graph containing number of chat message views and shares
                /// </summary>
                [JsonConverter(typeof(Converter))]
                [JsonProperty("message_interaction_graph")]
                public StatisticalGraph MessageInteractionGraph { get; set; }

                /// <summary>
                /// A graph containing number of views of associated with the chat instant views
                /// </summary>
                [JsonConverter(typeof(Converter))]
                [JsonProperty("instant_view_interaction_graph")]
                public StatisticalGraph InstantViewInteractionGraph { get; set; }

                /// <summary>
                /// Detailed statistics about number of views and shares of recently sent messages
                /// </summary>
                [JsonProperty("recent_message_interactions", ItemConverterType = typeof(Converter))]
                public ChatStatisticsMessageInteractionInfo[] RecentMessageInteractions { get; set; }
            }
        }
    }
}