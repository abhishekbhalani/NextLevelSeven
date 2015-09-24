﻿using System.Collections.Generic;
using NextLevelSeven.Core;

namespace NextLevelSeven.Streaming
{
    /// <summary>
    ///     HL7 message writer interface.
    /// </summary>
    public interface IMessageWriter
    {
        /// <summary>
        ///     Write one message.
        /// </summary>
        /// <param name="message">Message to write.</param>
        void Write(IMessage message);

        /// <summary>
        ///     Write a collection of messages.
        /// </summary>
        /// <param name="messages">Messages to write.</param>
        void WriteAll(IEnumerable<IMessage> messages);
    }
}