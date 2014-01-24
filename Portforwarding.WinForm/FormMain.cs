using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using System.Net.Sockets;
using System.Net;
using System.Collections;

namespace Portforwarding.WinForm
{
    public partial class FormMain : Form
    {
        public FormMain()
        {
            InitializeComponent();
            Init();
        }

        /// <summary>
        /// 初始化
        /// </summary>
        void Init()
        {
            //添加本地地址
            IPHostEntry hostEntry = Dns.GetHostEntry(Dns.GetHostName());
            cbbLocalIPAddress.Items.Add(IPAddress.Any);
            cbbLocalIPAddress.Items.Add(IPAddress.Loopback);
            foreach (var ip in hostEntry.AddressList)
            {
                if (ip.AddressFamily == AddressFamily.InterNetwork)
                {
                    cbbLocalIPAddress.Items.Add(ip);
                }
            }
            if (cbbLocalIPAddress.Items.Count > 0)
                cbbLocalIPAddress.SelectedIndex = 0;

            //添加协议
            cbbProtocol.Items.Add(ProtocolType.Tcp);
            //cbbProtocol.Items.Add(ProtocolType.Udp);
            if (cbbProtocol.Items.Count > 0)
                cbbProtocol.SelectedIndex = 0;

            PortforwardTable = new Hashtable();
            listHostDeny = new List<IPAddress>();

            bufferSize = 1024;

            dataPackageQueue = new Queue<DataPackage>();

            isShowSource = true;
            isShowDestination = true;
            isShowDateTime = true;
            isShowRevieved = true;
            isShowSended = false;
            isShowPause = false;
            isShowSplit = false;
            showSplitSymbol = " ";
            showSplitLength = 8;
            showType = StringType.ASCII;
        }

        private void cmsRecordFilter_Opening(object sender, CancelEventArgs e)
        {
            foreach (ToolStripItem item in ((ContextMenuStrip)sender).Items)
            {
                if (item.Tag == null)
                    continue;

                string tag = item.Tag.ToString();

                if (string.IsNullOrEmpty(tag))
                    continue;

                switch (tag)
                {
                    case "Add":
                        item.Visible = true;
                        break;
                    case "Edit":
                        item.Enabled = cbListRecordFilter.SelectedItem == null ? false : true;
                        break;
                    case "Delete":
                        item.Enabled = cbListRecordFilter.SelectedItem == null ? false : true;
                        break;
                    case "Clear":
                        item.Visible = true;
                        break;
                    case "All":
                        item.Visible = true;
                        break;
                    case "Invert":
                        item.Visible = true;
                        break;
                    default:
                        break;
                }
            }
        }

        private void cmsRecordReplace_Opening(object sender, CancelEventArgs e)
        {
            foreach (ToolStripItem item in ((ContextMenuStrip)sender).Items)
            {
                if (item.Tag == null)
                    continue;

                string tag = item.Tag.ToString();

                if (string.IsNullOrEmpty(tag))
                    continue;

                switch (tag)
                {
                    case "Add":
                        item.Visible = true;
                        break;
                    case "Edit":
                        item.Enabled = cbListRecordReplace.SelectedItem == null ? false : true;
                        break;
                    case "Delete":
                        item.Enabled = cbListRecordReplace.SelectedItem == null ? false : true;
                        break;
                    case "Clear":
                        item.Visible = true;
                        break;
                    case "All":
                        item.Visible = true;
                        break;
                    case "Invert":
                        item.Visible = true;
                        break;
                    default:
                        break;
                }
            }
        }

        private void cmsHostAccept_Opening(object sender, CancelEventArgs e)
        {
            ContextMenuStrip menu = ((ContextMenuStrip)sender);

            foreach (ToolStripItem item in menu.Items)
            {
                if (item.Tag == null)
                    continue;

                string tag = item.Tag.ToString();

                if (string.IsNullOrEmpty(tag))
                    continue;

                switch (tag)
                {
                    case "Break":
                        item.Enabled = cbListHostAccept.SelectedItem == null ? false : true;
                        break;
                    default:
                        break;
                }
            }
        }
    }
}
