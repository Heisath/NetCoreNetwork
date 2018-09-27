﻿using System;
using System.Net.Sockets;

namespace GeneralPurposeNetworkLib.TCP
{
    public class TcpSocketStream : NetworkStream
    {
        public TcpSocketStream(Socket socket, bool ownsSocket) :
            base(socket, ownsSocket)
        {
        }


        // You can use the Socket method to examine the underlying Socket.
        public bool IsConnected
        {
            get
            {
                return this.Socket.Connected;
            }
        }
    }
}