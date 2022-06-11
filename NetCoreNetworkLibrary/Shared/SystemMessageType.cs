﻿namespace NetCoreNetwork.Shared
{
    public enum SystemMessageType : byte
    {
        Nothing,
        Connect,
        ConnectOk,
        Ping,
        PingOk,
        Disconnect,
        JsonMessage,
        RawMessage
    }
}