using System;
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
        /// Contains properties of a message and describes actions that can be done with the message right now
        /// </summary>
        public partial class MessageProperties : Object
        {
            /// <summary>
            /// Data type for serialization
            /// </summary>
            [JsonProperty("@type")]
            public override string DataType { get; set; } = "messageProperties";

            /// <summary>
            /// Extra data attached to the object
            /// </summary>
            [JsonProperty("@extra")]
            public override string Extra { get; set; }

            /// <summary>
            /// True, if content of the message can be copied to a secret chat using inputMessageForwarded or forwardMessages with copy options
            /// </summary>
            [JsonConverter(typeof(Converter))]
            [JsonProperty("can_be_copied_to_secret_chat")]
            public bool CanBeCopiedToSecretChat { get; set; }

            /// <summary>
            /// True, if the message can be deleted only for the current user while other users will continue to see it using the method deleteMessages with revoke == false
            /// </summary>
            [JsonConverter(typeof(Converter))]
            [JsonProperty("can_be_deleted_only_for_self")]
            public bool CanBeDeletedOnlyForSelf { get; set; }

            /// <summary>
            /// True, if the message can be deleted for all users using the method deleteMessages with revoke == true
            /// </summary>
            [JsonConverter(typeof(Converter))]
            [JsonProperty("can_be_deleted_for_all_users")]
            public bool CanBeDeletedForAllUsers { get; set; }

            /// <summary>
            /// True, if the message can be edited using the methods editMessageText, editMessageMedia, editMessageCaption, or editMessageReplyMarkup.
            /// For live location and poll messages this fields shows whether editMessageLiveLocation or stopPoll can be used with this message
            /// </summary>
            [JsonConverter(typeof(Converter))]
            [JsonProperty("can_be_edited")]
            public bool CanBeEdited { get; set; }

            /// <summary>
            /// True, if the message can be forwarded using inputMessageForwarded or forwardMessages
            /// </summary>
            [JsonConverter(typeof(Converter))]
            [JsonProperty("can_be_forwarded")]
            public bool CanBeForwarded { get; set; }

            /// <summary>
            /// True, if the message can be paid using inputInvoiceMessage
            /// </summary>
            [JsonConverter(typeof(Converter))]
            [JsonProperty("can_be_paid")]
            public bool CanBePaid { get; set; }

            /// <summary>
            /// True, if the message can be pinned or unpinned in the chat using pinChatMessage or unpinChatMessage
            /// </summary>
            [JsonConverter(typeof(Converter))]
            [JsonProperty("can_be_pinned")]
            public bool CanBePinned { get; set; }

            /// <summary>
            /// True, if the message can be replied in the same chat and forum topic using inputMessageReplyToMessage
            /// </summary>
            [JsonConverter(typeof(Converter))]
            [JsonProperty("can_be_replied")]
            public bool CanBeReplied { get; set; }

            /// <summary>
            /// True, if the message can be replied in another chat or forum topic using inputMessageReplyToExternalMessage
            /// </summary>
            [JsonConverter(typeof(Converter))]
            [JsonProperty("can_be_replied_in_another_chat")]
            public bool CanBeRepliedInAnotherChat { get; set; }

            /// <summary>
            /// True, if content of the message can be saved locally or copied using inputMessageForwarded or forwardMessages with copy options
            /// </summary>
            [JsonConverter(typeof(Converter))]
            [JsonProperty("can_be_saved")]
            public bool CanBeSaved { get; set; }

            /// <summary>
            /// True, if the message can be shared in a story using inputStoryAreaTypeMessage
            /// </summary>
            [JsonConverter(typeof(Converter))]
            [JsonProperty("can_be_shared_in_story")]
            public bool CanBeSharedInStory { get; set; }

            /// <summary>
            /// True, if scheduling state of the message can be edited
            /// </summary>
            [JsonConverter(typeof(Converter))]
            [JsonProperty("can_edit_scheduling_state")]
            public bool CanEditSchedulingState { get; set; }

            /// <summary>
            /// True, if code for message embedding can be received using getMessageEmbeddingCode
            /// </summary>
            [JsonConverter(typeof(Converter))]
            [JsonProperty("can_get_embedding_code")]
            public bool CanGetEmbeddingCode { get; set; }

            /// <summary>
            /// True, if a link can be generated for the message using getMessageLink
            /// </summary>
            [JsonConverter(typeof(Converter))]
            [JsonProperty("can_get_link")]
            public bool CanGetLink { get; set; }

            /// <summary>
            /// True, if media timestamp links can be generated for media timestamp entities in the message text, caption or link preview description using getMessageLink
            /// </summary>
            [JsonConverter(typeof(Converter))]
            [JsonProperty("can_get_media_timestamp_links")]
            public bool CanGetMediaTimestampLinks { get; set; }

            /// <summary>
            /// True, if information about the message thread is available through getMessageThread and getMessageThreadHistory
            /// </summary>
            [JsonConverter(typeof(Converter))]
            [JsonProperty("can_get_message_thread")]
            public bool CanGetMessageThread { get; set; }

            /// <summary>
            /// True, if read date of the message can be received through getMessageReadDate
            /// </summary>
            [JsonConverter(typeof(Converter))]
            [JsonProperty("can_get_read_date")]
            public bool CanGetReadDate { get; set; }

            /// <summary>
            /// True, if message statistics are available through getMessageStatistics and message forwards can be received using getMessagePublicForwards
            /// </summary>
            [JsonConverter(typeof(Converter))]
            [JsonProperty("can_get_statistics")]
            public bool CanGetStatistics { get; set; }

            /// <summary>
            /// True, if chat members already viewed the message can be received through getMessageViewers
            /// </summary>
            [JsonConverter(typeof(Converter))]
            [JsonProperty("can_get_viewers")]
            public bool CanGetViewers { get; set; }

            /// <summary>
            /// True, if speech can be recognized for the message through recognizeSpeech
            /// </summary>
            [JsonConverter(typeof(Converter))]
            [JsonProperty("can_recognize_speech")]
            public bool CanRecognizeSpeech { get; set; }

            /// <summary>
            /// True, if the message can be reported using reportChat
            /// </summary>
            [JsonConverter(typeof(Converter))]
            [JsonProperty("can_report_chat")]
            public bool CanReportChat { get; set; }

            /// <summary>
            /// True, if reactions on the message can be reported through reportMessageReactions
            /// </summary>
            [JsonConverter(typeof(Converter))]
            [JsonProperty("can_report_reactions")]
            public bool CanReportReactions { get; set; }

            /// <summary>
            /// True, if the message can be reported using reportSupergroupSpam
            /// </summary>
            [JsonConverter(typeof(Converter))]
            [JsonProperty("can_report_supergroup_spam")]
            public bool CanReportSupergroupSpam { get; set; }

            /// <summary>
            /// True, if fact check for the message can be changed through setMessageFactCheck
            /// </summary>
            [JsonConverter(typeof(Converter))]
            [JsonProperty("can_set_fact_check")]
            public bool CanSetFactCheck { get; set; }

            /// <summary>
            /// True, if message statistics must be available from context menu of the message
            /// </summary>
            [JsonConverter(typeof(Converter))]
            [JsonProperty("need_show_statistics")]
            public bool NeedShowStatistics { get; set; }
        }
    }
}
// REUSE-IgnoreEnd