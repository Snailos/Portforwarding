using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using System.Net.Sockets;
using System.Net;
using System.Diagnostics;
using System.Threading;
using System.Collections;

namespace Portforwarding.WinForm
{
    partial class FormMain
    {
        /// <summary>
        /// 监听
        /// </summary>
        void Run()
        {
            if (isRunning)
                return;

            try
            {
                protocolType = (ProtocolType)cbbProtocol.SelectedItem;

                localIPAddress = (IPAddress)cbbLocalIPAddress.SelectedItem;

                localPort = (int)nudLocalPort.Value;

                remoteIPAddress = IPAddress.Parse(txtRemoteIPAddress.Text);

                remotePort = (int)nudRemotePort.Value;
            }
            catch
            {
                MessageBox.Show("获取监听参数失败");
                return;
            }

            if (protocolType == ProtocolType.Udp)
            {
                MessageBox.Show("暂不支持Udp协议");
                return;
            }

            try
            {
                cbbLocalIPAddress.Enabled = false;
                nudLocalPort.Enabled = false;
                txtRemoteIPAddress.Enabled = false;
                nudRemotePort.Enabled = false;
                cbbProtocol.Enabled = false;
                btnOk.Enabled = false;
                btnOk.Text = "启动中";

                listener = new TcpListener(localIPAddress, localPort);
                listener.Start(int.MaxValue);

                isRunning = true;

                acceptThread = new Thread(Accept);
                acceptThread.Start();

                btnOk.Enabled = true;
                btnOk.Text = "停止";

                
            }
            catch
            {
                MessageBox.Show("启动本地监听失败");
                listener = null;
                cbbLocalIPAddress.Enabled = true;
                nudLocalPort.Enabled = true;
                txtRemoteIPAddress.Enabled = true;
                nudRemotePort.Enabled = true;
                cbbProtocol.Enabled = true;
                btnOk.Enabled = true;
                btnOk.Text = "启动";
            }


            
        }

        /// <summary>
        /// 停止
        /// </summary>
        void Stop()
        {
            if (!isRunning)
                return;

            try
            {
                btnOk.Enabled = false;
                btnOk.Text = "关闭中";

                listener.Stop();
                listener = null;
                cbbLocalIPAddress.Enabled = true;
                nudLocalPort.Enabled = true;
                txtRemoteIPAddress.Enabled = true;
                nudRemotePort.Enabled = true;
                cbbProtocol.Enabled = true;

                isRunning = false;

                btnOk.Enabled = true;
                btnOk.Text = "启动";
            }
            catch
            {
                cbbLocalIPAddress.Enabled = false;
                nudLocalPort.Enabled = false;
                txtRemoteIPAddress.Enabled = false;
                nudRemotePort.Enabled = false;
                cbbProtocol.Enabled = false;

                btnOk.Enabled = true;
                btnOk.Text = "停止";
            }
        }

        /// <summary>
        /// 接受主机
        /// </summary>
        void Accept()
        {
            Socket client = null, remote = null;

            while (isRunning)
            {
                try
                {
                    client = listener.AcceptSocket();

                    if (!IsAllowEndPoint(client.RemoteEndPoint))
                    {
                        client.Close();
                        continue;
                    }

                    remote = new Socket(AddressFamily.InterNetwork, SocketType.Stream, ProtocolType.Tcp);
                    remote.Connect(remoteIPAddress, remotePort);

                    IPortforward positive = new TcpPortForward(client, remote);

                    IPortforward negative = new TcpPortForward(remote, client);
                    positive.OnRecieved += new Recieved(Positive_OnRecieved);
                    positive.OnSended += new Sended(Positive_OnSended);
                    negative.OnRecieved += new Recieved(Negative_OnRecieved);
                    negative.OnSended += new Sended(Negative_OnSended);
                    ThreadPool.QueueUserWorkItem(new WaitCallback(PortForward), positive);
                    ThreadPool.QueueUserWorkItem(new WaitCallback(PortForward), negative);

                    lock (PortforwardTable)
                    {
                        PortforwardTable[positive] = negative;
                    }

                }
                catch (Exception ex)
                {
                    CloseSocket(client);
                    CloseSocket(remote);
                    Debug.WriteLine(ex.ToString());
                }
            }
        }

        void CloseSocket(Socket socket)
        {
            if (socket == null)
                return;

            try
            {
                socket.Shutdown(SocketShutdown.Both);
            }
            catch { }
            finally
            {
                try
                {
                    socket.Close();
                }
                catch { }
            }
        }

        /// <summary>
        /// 开始转发
        /// </summary>
        void PortForward(object args)
        {
            try
            {
                IPortforward portforward = args as IPortforward;

                if (portforward == null)
                    return;

                portforward.Run(bufferSize);
            }
            catch (Exception ex)
            {
                Debug.WriteLine(ex.ToString());
            }
        }
    }
}
