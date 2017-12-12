﻿using Telegram.Bot.Types;

namespace Telegram.Bot.Requests
{
    /// <summary>
    /// Delete a message, including service messages, with the following limitations:
    /// - A message can only be deleted if it was sent less than 48 hours ago.
    /// - Bots can delete outgoing messages in groups and supergroups.
    /// - Bots granted can_post_messages permissions can delete outgoing messages in channels.
    /// - If the bot is an administrator of a group, it can delete any message there.
    /// - If the bot has can_delete_messages permission in a supergroup or a channel, it can delete any message there.
    /// Returns True on success.
    /// </summary>
    public class DeleteMessageRequest : RequestBase<bool>
    {
        /// <summary>
        /// Unique identifier for the target chat or username of the target channel (in the format @channelusername)
        /// </summary>
        public ChatId ChatId { get; set; }

        /// <summary>
        /// Identifier of the sent message
        /// </summary>
        public int MessageId { get; set; }

        /// <summary>
        /// Initializes a new request
        /// </summary>
        public DeleteMessageRequest()
            : base("deleteMessage")
        { }

        /// <summary>
        /// Initializes a new request with chatId and messageId
        /// </summary>
        /// <param name="chatId">Unique identifier for the target chat or username of the target channel</param>
        /// <param name="messageId">Identifier of the sent message</param>
        public DeleteMessageRequest(ChatId chatId, int messageId)
            : this()
        {
            ChatId = chatId;
            MessageId = messageId;
        }
    }
}