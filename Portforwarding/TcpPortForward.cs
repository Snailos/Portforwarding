using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Net.Sockets;
using System.Diagnostics;

namespace Portforwarding
{
    public class TcpPortForward : IPortforward
    {
        public event Recieved OnRecieved;
        public event Sended OnSended;

        private string fromAddress;

        public string FromAddress
        {
            get { return fromAddress; }
            //set { fromAddress = value; }
        }

        private string toAddress;

        public string ToAddress
        {
            get { return toAddress; }
            //set { toAddress = value; }
        }

        Socket fromSocket;

        public Socket FromSocket
        {
            get { return fromSocket; }
            //set { fromSocket = value; }
        }
        Socket toSocket;

        public Socket ToSocket
        {
            get { return toSocket; }
            //set { toSocket = value; }
        }
        bool isRunning;

        public bool IsRunning
        {
            get { return isRunning; }
            //set { isRunning = value; }
        }

        private bool isDispose;

        public bool IsDispose
        {
            get { return isDispose; }
            //set { isDispose = value; }
        }

        public TcpPortForward(Socket fromSocket, Socket toSocket)
        {
            this.fromSocket = fromSocket;
            this.toSocket = toSocket;
            this.fromAddress = fromSocket.RemoteEndPoint.ToString();
            this.toAddress = toSocket.RemoteEndPoint.ToString();
        }

        public void Run(int bufferSize)
        {
            isRunning = true;
            byte[] buffer = new byte[bufferSize];
            byte[] tempData = null;

            while (isRunning)
            {
                try
                {
                    int count = fromSocket.Receive(buffer);

                    if (count <= 0)
                        continue;

                    tempData = new byte[count];

                    Array.Copy(buffer, tempData, count);

                    try
                    {
                        if (OnRecieved != null)
                            OnRecieved(this, tempData);
                    }
                    catch (Exception ex)
                    {
                        Debug.WriteLine(ex.ToString());
                        Array.Copy(buffer, tempData, count);
                    }

                    if (tempData == null || tempData.Length <= 0)
                        continue;

                    toSocket.Send(tempData);

                    if (OnSended != null)
                        OnSended(this, tempData);

                }
                catch (Exception ex)
                {
                    Debug.WriteLine(ex.ToString());
                    isRunning = false;
                    Dispose();
                }
            }
        }

        public void Stop()
        {
            isRunning = false;
        }

        public void Dispose()
        {
            Stop();

            try
            {
                fromSocket.Shutdown(SocketShutdown.Both);
            }
            catch (Exception ex)
            {
                Debug.WriteLine(ex.ToString());
            }
            finally
            {
                try
                {
                    fromSocket.Close();
                }
                catch (Exception ex)
                {
                    Debug.WriteLine(ex.ToString());
                }
            }

            try
            {
                toSocket.Shutdown(SocketShutdown.Both);
            }
            catch (Exception ex)
            {
                Debug.WriteLine(ex.ToString());
            }
            finally
            {
                try
                {
                    toSocket.Close();
                }
                catch (Exception ex)
                {
                    Debug.WriteLine(ex.ToString());
                }
            }

            isDispose = true;
        }
    }
}
