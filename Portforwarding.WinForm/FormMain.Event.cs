using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using System.Net;
using System.Net.Sockets;
using System.Collections;
using System.ComponentModel;

namespace Portforwarding.WinForm
{
    partial class FormMain
    {
        /// <summary>
        /// 窗体加载事件
        /// </summary>
        private void FormMain_Load(object sender, EventArgs e)
        {

        }

        /// <summary>
        /// 开始/停止按钮被点击事件
        /// </summary>
        private void btnOk_Click(object sender, EventArgs e)
        {
            if (isRunning)
            {
                Stop();
            }
            else
            {
                Run();
            }

        }

        /// <summary>
        /// 显示记录计时器事件
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void tmShowRecord_Tick(object sender, EventArgs e)
        {
            lock (dataPackageQueue)
            {
                if (dataPackageQueue.Count <= 0)
                    return;

                DataPackage dataPackage = dataPackageQueue.Dequeue();

                StringBuilder record = new StringBuilder();

                record.Append("\r\n");

                if (isShowDateTime)
                    record.Append(dataPackage.Datetime.ToString("yyyy-MM-dd HH:mm:ss.fff"));

                record.Append(" # ");

                if (dataPackage.Type == DataPackageType.Recieved)
                    record.Append("Recived");
                else
                    record.Append("Sended ");

                record.Append(" # ");

                if (isShowSource)
                    record.Append(string.Format("{0}", dataPackage.FromAddress));

                if (isShowSource && isShowDestination)
                    record.Append(" -> ");

                if (isShowDestination)
                    record.Append(string.Format("{0}", dataPackage.ToAddress));
                if (!isShowSource && !isShowDestination)
                    record.Append("Data");

                record.Append(" # ");

                record.Append(string.Format("Size {0} Byte :", dataPackage.Data.Length));
                record.Append("\r\n");

                string content = FormatToShowString(dataPackage);

                if (isShowSplit)
                    content = StringHelper.InsertSplitSymbol(content, showSplitSymbol, showSplitLength);

                record.Append(content);
                record.Append("\r\n");
                txtRecordConetnt.AppendText(record.ToString());
            }
        }

        /// <summary>
        /// 掉线检测复选款选中状态改变事件
        /// </summary>
        private void cbIsCheckBreak_CheckedChanged(object sender, EventArgs e)
        {
            isCheckBreak = ((CheckBox)sender).Checked;
        }

        /// <summary>
        /// 刷新接受列表
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void tmShowRefreshAcceptList_Tick(object sender, EventArgs e)
        {
            lock (PortforwardTable)
            {
                lock (cbListHostAccept)
                {
                    IPortforward[] list = new IPortforward[PortforwardTable.Keys.Count];
                    PortforwardTable.Keys.CopyTo(list, 0);
                    foreach (IPortforward p in list)
                    {
                        if (p.IsDispose)
                        {
                            cbListHostAccept.Items.Remove(p.FromAddress);
                            PortforwardTable.Remove(p);
                            continue;
                        }

                        if (!cbListHostAccept.Items.Contains(p.FromAddress))
                        {
                            cbListHostAccept.Items.Add(p.FromAddress);
                        }
                    }
                }
            }
        }

        /// <summary>
        /// 检测断线时钟事件
        /// </summary>
        private void tmCheckBreak_Tick(object sender, EventArgs e)
        {
            if (!isCheckBreak)
                return;

            lock (PortforwardTable)
            {
                foreach (IPortforward p in PortforwardTable.Keys)
                {
                    try
                    {
                        if (!IsSocketConnected(p.FromSocket))
                            p.Dispose();

                    }
                    catch { }

                    try
                    {
                        if (!IsSocketConnected(p.ToSocket))
                            p.Dispose();
                    }
                    catch { }
                }
            }
        }

        /// <summary>
        /// 
        /// </summary>
        private void btnRecordContentExport_Click(object sender, EventArgs e)
        {

        }

        /// <summary>
        /// 清空按钮被点击事件
        /// </summary>
        private void btnRecordContentClear_Click(object sender, EventArgs e)
        {
            txtRecordConetnt.Clear();
        }

        /// <summary>
        /// 
        /// </summary>
        private void cbListHostAccept_ItemCheck(object sender, ItemCheckEventArgs e)
        {

        }

        /// <summary>
        /// 拒绝主机列表项被选中事件
        /// </summary>
        private void cbListHostDeny_ItemCheck(object sender, ItemCheckEventArgs e)
        {
            IPAddress ip = (IPAddress)(((CheckedListBox)sender).Items[e.Index]);

            lock (listHostDeny)
            {
                if (e.NewValue == CheckState.Checked)
                {
                    if (!listHostDeny.Contains(ip))
                        listHostDeny.Add(ip);
                }
                else
                {
                    if (listHostDeny.Contains(ip))
                        listHostDeny.Remove(ip);
                }
            }
        }

        /// <summary>
        /// 
        /// </summary>
        private void cbListRecordFilter_ItemCheck(object sender, ItemCheckEventArgs e)
        {

        }

        /// <summary>
        /// 
        /// </summary>
        private void cbListRecordReplace_ItemCheck(object sender, ItemCheckEventArgs e)
        {

        }

        /// <summary>
        /// 
        /// </summary>
        private void cbShowSource_CheckedChanged(object sender, EventArgs e)
        {
            isShowSource = ((CheckBox)sender).Checked;
        }

        /// <summary>
        /// 
        /// </summary>
        private void cbShowDestination_CheckedChanged(object sender, EventArgs e)
        {
            isShowDestination = ((CheckBox)sender).Checked;
        }

        /// <summary>
        /// 
        /// </summary>
        private void cbShowDateTime_CheckedChanged(object sender, EventArgs e)
        {
            isShowDateTime = ((CheckBox)sender).Checked;
        }

        /// <summary>
        /// 
        /// </summary>
        private void cbShowPause_CheckedChanged(object sender, EventArgs e)
        {
            isShowPause = ((CheckBox)sender).Checked;
        }

        /// <summary>
        /// 
        /// </summary>
        private void cbShowRecieved_CheckedChanged(object sender, EventArgs e)
        {
            isShowRevieved = ((CheckBox)sender).Checked;
        }

        /// <summary>
        /// 
        /// </summary>
        private void cbShowSended_CheckedChanged(object sender, EventArgs e)
        {
            isShowSended = ((CheckBox)sender).Checked;
        }

        /// <summary>
        /// 
        /// </summary>
        private void cbShowSplit_CheckedChanged(object sender, EventArgs e)
        {
            isShowSplit = ((CheckBox)sender).Checked;
            if (isShowSplit)
            {
                txtShowSplitSymbol.Enabled = true;
                nudShowSplitLength.Enabled = true;
            }
            else
            {
                txtShowSplitSymbol.Enabled = false;
                nudShowSplitLength.Enabled = false;
            }
        }

        /// <summary>
        /// 分隔符文本框内容改变事件
        /// </summary>
        private void txtShowSplitSymbol_TextChanged(object sender, EventArgs e)
        {
            showSplitSymbol = ((TextBox)sender).Text;
        }

        /// <summary>
        /// 分隔长度框内容改变事件
        /// </summary>
        private void nudShowSplitLength_ValueChanged(object sender, EventArgs e)
        {
            showSplitLength = (int)((NumericUpDown)sender).Value;
        }

        /// <summary>
        /// 
        /// </summary>
        private void radShowEndodingBin_CheckedChanged(object sender, EventArgs e)
        {
            if (((RadioButton)sender).Checked)
            {
                showType = StringType.Bin;
                txtShowSplitSymbol.Text = " ";
                nudShowSplitLength.Value = 8;
            }
        }

        /// <summary>
        /// 
        /// </summary>
        private void radShowEndodingOtc_CheckedChanged(object sender, EventArgs e)
        {
            if (((RadioButton)sender).Checked)
            {
                showType = StringType.Oct;
                txtShowSplitSymbol.Text = " ";
                nudShowSplitLength.Value = 3;
            }
        }

        /// <summary>
        /// 
        /// </summary>
        private void radShowEndodingDec_CheckedChanged(object sender, EventArgs e)
        {
            if (((RadioButton)sender).Checked)
            {
                showType = StringType.Dec;
                txtShowSplitSymbol.Text = " ";
                nudShowSplitLength.Value = 3;
            }
        }

        /// <summary>
        /// 
        /// </summary>
        private void radShowEndodingHex_CheckedChanged(object sender, EventArgs e)
        {
            if (((RadioButton)sender).Checked)
            {
                showType = StringType.Hex;
                txtShowSplitSymbol.Text = " ";
                nudShowSplitLength.Value = 2;
            }
        }

        /// <summary>
        /// 
        /// </summary>
        private void radShowEndodingASCII_CheckedChanged(object sender, EventArgs e)
        {
            if (((RadioButton)sender).Checked)
            {
                showType = StringType.ASCII;
                txtShowSplitSymbol.Text = "";
                nudShowSplitLength.Value = 0;
            }
        }

        /// <summary>
        /// 
        /// </summary>
        private void radShowEndodingUTF8_CheckedChanged(object sender, EventArgs e)
        {
            if (((RadioButton)sender).Checked)
            {
                showType = StringType.UTF8;
                txtShowSplitSymbol.Text = "";
                nudShowSplitLength.Value = 0;
            }
        }

        /// <summary>
        /// 
        /// </summary>
        private void radShowEndodingUnicode_CheckedChanged(object sender, EventArgs e)
        {
            if (((RadioButton)sender).Checked)
            {
                showType = StringType.Unicode;
                txtShowSplitSymbol.Text = "";
                nudShowSplitLength.Value = 0;
            }
        }

        /// <summary>
        /// 
        /// </summary>
        private void radShowEndodingBase64_CheckedChanged(object sender, EventArgs e)
        {
            if (((RadioButton)sender).Checked)
            {
                showType = StringType.Base64;
                txtShowSplitSymbol.Text = "";
                nudShowSplitLength.Value = 0;
            }
        }

        /// <summary>
        /// 收到客户端发向服务端数据事件
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="data"></param>
        private void Positive_OnRecieved(IPortforward sender, byte[] data)
        {
            if (isShowPause || !isShowRevieved)
                return;

            lock (dataPackageQueue)
            {
                dataPackageQueue.Enqueue(new DataPackage(sender.FromSocket.RemoteEndPoint.ToString(), sender.ToSocket.RemoteEndPoint.ToString(), data, DataPackageType.Recieved, DateTime.Now));
            }
        }

        /// <summary>
        /// 收到服务发向客户端端数据事件
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="data"></param>
        private void Negative_OnRecieved(IPortforward sender, byte[] data)
        {
            if (isShowPause || !isShowRevieved)
                return;

            lock (dataPackageQueue)
            {
                dataPackageQueue.Enqueue(new DataPackage(sender.FromSocket.RemoteEndPoint.ToString(), sender.ToSocket.RemoteEndPoint.ToString(), data, DataPackageType.Recieved, DateTime.Now));
            }
        }

        /// <summary>
        /// 客户端向服务端发送数据完成事件
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="data"></param>
        private void Positive_OnSended(IPortforward sender, byte[] data)
        {
            if (isShowPause || !isShowSended)
                return;

            lock (dataPackageQueue)
            {
                dataPackageQueue.Enqueue(new DataPackage(sender.FromSocket.RemoteEndPoint.ToString(), sender.ToSocket.RemoteEndPoint.ToString(), data, DataPackageType.Sended, DateTime.Now));
            }
        }

        /// <summary>
        /// 服务端向客户端发送数据完成事件
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="data"></param>
        private void Negative_OnSended(IPortforward sender, byte[] data)
        {
            if (isShowPause || !isShowSended)
                return;

            lock (dataPackageQueue)
            {
                dataPackageQueue.Enqueue(new DataPackage(sender.FromSocket.RemoteEndPoint.ToString(), sender.ToSocket.RemoteEndPoint.ToString(), data, DataPackageType.Sended, DateTime.Now));
            }
        }

        private void tsmiHostDenyAdd_Click(object sender, EventArgs e)
        {
            if (!IsFromExist(formHostDenyAdd))
                formHostDenyAdd = new FormHostDenyAdd();

            ShowSingleForm(formHostDenyAdd);


        }

        private void cmsHostDeny_Opening(object sender, CancelEventArgs e)
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
                        item.Enabled = cbListHostDeny.SelectedItem == null ? false : true;
                        break;
                    case "Delete":
                        item.Enabled = cbListHostDeny.SelectedItem == null ? false : true;
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

        private void tsmiHostDenyInvert_Click(object sender, EventArgs e)
        {
            lock (cbListHostDeny)
            {
                for (int i = 0; i < cbListHostDeny.Items.Count; i++)
                {
                    cbListHostDeny.SetItemChecked(i, !cbListHostDeny.GetItemChecked(i));
                }
            }
        }

        private void tsmiHostDenyAll_Click(object sender, EventArgs e)
        {
            lock (cbListHostDeny)
            {
                for (int i = 0; i < cbListHostDeny.Items.Count; i++)
                {
                    cbListHostDeny.SetItemChecked(i, true);
                }
            }
        }

        private void tsmiHostDenyClear_Click(object sender, EventArgs e)
        {
            lock (cbListHostDeny)
            {
                lock (listHostDeny)
                {
                    foreach (IPAddress ip in cbListHostDeny.Items)
                    {
                        if (listHostDeny.Contains(ip))
                            listHostDeny.Remove(ip);
                    }
                }
                cbListHostDeny.Items.Clear();
            }
        }

        private void tsmiHostDenyDelete_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("确定要删除该记录吗？", "删除确认", MessageBoxButtons.OKCancel) != DialogResult.OK)
                return;

            IPAddress ip = (IPAddress)cbListHostDeny.SelectedItem;
            lock (cbListHostDeny)
            {
                lock (listHostDeny)
                {
                    if (listHostDeny.Contains(ip))
                        listHostDeny.Remove(ip);
                }
                cbListHostDeny.Items.Remove(ip);
            }
        }

        private void tsmiHostDenyEdit_Click(object sender, EventArgs e)
        {
            if (!IsFromExist(formHostDenyEdit))
                formHostDenyEdit = new FormHostDenyEdit();

            ShowSingleForm(formHostDenyEdit);
        }
    }
}
