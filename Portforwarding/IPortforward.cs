using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Net.Sockets;

namespace Portforwarding
{
    public delegate void Recieved(IPortforward sender, byte[] data);
    public delegate void Sended(IPortforward sender, byte[] data);

    public interface IPortforward : IDisposable
    {
        event Recieved OnRecieved;
        event Sended OnSended;
        string FromAddress { get; }
        string ToAddress { get; }
        Socket FromSocket { get; }
        Socket ToSocket { get; }
        bool IsRunning { get; }
        bool IsDispose { get; }
        void Run(int bufferSize);
        void Stop();
    }
}
