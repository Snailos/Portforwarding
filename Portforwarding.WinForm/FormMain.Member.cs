using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Net.Sockets;
using System.Collections;
using System.Net;
using System.Threading;
using System.Windows.Forms;

namespace Portforwarding.WinForm
{
    partial class FormMain
    {
        IPAddress localIPAddress;
        int localPort;
        IPAddress remoteIPAddress;
        int remotePort;
        ProtocolType protocolType;
        TcpListener listener;
        Hashtable PortforwardTable;
        bool isRunning;
        int bufferSize;
        Thread acceptThread;
        Queue<DataPackage> dataPackageQueue;
        bool isCheckBreak;
        bool isShowSource;
        bool isShowDestination;
        bool isShowDateTime;
        bool isShowRevieved;
        bool isShowSended;
        bool isShowPause;
        bool isShowSplit;
        string showSplitSymbol;
        int showSplitLength;
        StringType showType;

        List<IPAddress> listHostDeny;

        public List<IPAddress> ListHostDeny
        {
            get { return listHostDeny; }
            //set { listHostDeny = value; }
        }

        FormHostDenyAdd formHostDenyAdd;
        FormHostDenyEdit formHostDenyEdit;


        internal CheckedListBox CheckedListBoxHostAccept
        {
            get { return this.cbListHostAccept; }
        }
        internal CheckedListBox CheckedListBoxHostDeny
        {
            get { return this.cbListHostDeny; }
        }
        internal CheckedListBox CheckedListBoxRecordFilter
        {
            get { return this.cbListRecordFilter; }
        }
        internal CheckedListBox CheckedListBoxRecordReplace
        {
            get { return this.cbListRecordReplace; }
        }

        internal ContextMenuStrip ContextMenuStripHostAccept
        {
            get { return cmsHostAccept; }
        }
        internal ContextMenuStrip ContextMenuStripHostDeny
        {
            get { return cmsHostDeny; }
        }

        internal ContextMenuStrip ContextMenuStripRecordFilter
        {
            get { return cmsRecordFilter; }
        }

        internal ContextMenuStrip ContextMenuStripRecordReplace
        {
            get { return cmsRecordReplace; }
        }
    }
}
