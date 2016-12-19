﻿using UnityEngine.Networking;

namespace Insthync.ChatSystem
{
    public class ChatChannelDataResult
    {
        public ChatChannelData channel;
        public string message;
        public bool isBroadcast;
        public ChatUser sender;
        public ChatUser receiver;

        public ChatChannelDataResult(ChatChannelData channel, string message, bool isBroadcast, ChatUser sender, ChatUser receiver = null)
        {
            this.channel = channel;
            this.message = message;
            this.isBroadcast = isBroadcast;
            this.sender = sender;
            this.receiver = receiver;
        }
    }
}
