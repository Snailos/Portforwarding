namespace Portforwarding.WinForm
{
    partial class FormMain
    {
        /// <summary>
        /// 必需的设计器变量。
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// 清理所有正在使用的资源。
        /// </summary>
        /// <param name="disposing">如果应释放托管资源，为 true；否则为 false。</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows 窗体设计器生成的代码

        /// <summary>
        /// 设计器支持所需的方法 - 不要
        /// 使用代码编辑器修改此方法的内容。
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            this.grpPortListening = new System.Windows.Forms.GroupBox();
            this.cbIsCheckBreak = new System.Windows.Forms.CheckBox();
            this.lblProtocol = new System.Windows.Forms.Label();
            this.lblRemotePort = new System.Windows.Forms.Label();
            this.lblRemoteIPAddress = new System.Windows.Forms.Label();
            this.lblLocalPort = new System.Windows.Forms.Label();
            this.lblLocalIPAddress = new System.Windows.Forms.Label();
            this.nudRemotePort = new System.Windows.Forms.NumericUpDown();
            this.nudLocalPort = new System.Windows.Forms.NumericUpDown();
            this.txtRemoteIPAddress = new System.Windows.Forms.TextBox();
            this.cbbLocalIPAddress = new System.Windows.Forms.ComboBox();
            this.cbbProtocol = new System.Windows.Forms.ComboBox();
            this.btnOk = new System.Windows.Forms.Button();
            this.grpHostAccept = new System.Windows.Forms.GroupBox();
            this.cbListHostAccept = new System.Windows.Forms.CheckedListBox();
            this.cmsHostAccept = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.tsmiBreak = new System.Windows.Forms.ToolStripMenuItem();
            this.grpHostDeny = new System.Windows.Forms.GroupBox();
            this.cbListHostDeny = new System.Windows.Forms.CheckedListBox();
            this.cmsHostDeny = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.tsmiHostDenyAdd = new System.Windows.Forms.ToolStripMenuItem();
            this.tsmiHostDenyEdit = new System.Windows.Forms.ToolStripMenuItem();
            this.tsmiHostDenyDelete = new System.Windows.Forms.ToolStripMenuItem();
            this.tsmiHostDenyClear = new System.Windows.Forms.ToolStripMenuItem();
            this.tsmiHostDenyAll = new System.Windows.Forms.ToolStripMenuItem();
            this.tsmiHostDenyInvert = new System.Windows.Forms.ToolStripMenuItem();
            this.grpRecordFilter = new System.Windows.Forms.GroupBox();
            this.cbListRecordFilter = new System.Windows.Forms.CheckedListBox();
            this.cmsRecordFilter = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.tsmiRecordFilterAdd = new System.Windows.Forms.ToolStripMenuItem();
            this.tsmiRecordFilterEdit = new System.Windows.Forms.ToolStripMenuItem();
            this.tsmiRecordFilterDelete = new System.Windows.Forms.ToolStripMenuItem();
            this.tsmiRecordFilterClear = new System.Windows.Forms.ToolStripMenuItem();
            this.tsmiRecordFilterAll = new System.Windows.Forms.ToolStripMenuItem();
            this.tsmiRecordFilterInvert = new System.Windows.Forms.ToolStripMenuItem();
            this.grpRecordReplace = new System.Windows.Forms.GroupBox();
            this.cbListRecordReplace = new System.Windows.Forms.CheckedListBox();
            this.cmsRecordReplace = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.tsmiRecordReplaceAdd = new System.Windows.Forms.ToolStripMenuItem();
            this.tsmiRecordReplaceEdit = new System.Windows.Forms.ToolStripMenuItem();
            this.tsmiRecordReplaceDelete = new System.Windows.Forms.ToolStripMenuItem();
            this.tsmiRecordReplaceClear = new System.Windows.Forms.ToolStripMenuItem();
            this.tsmiRecordReplaceAll = new System.Windows.Forms.ToolStripMenuItem();
            this.tsmiRecordReplaceInvert = new System.Windows.Forms.ToolStripMenuItem();
            this.grpRecordShow = new System.Windows.Forms.GroupBox();
            this.cbShowSended = new System.Windows.Forms.CheckBox();
            this.cbShowRecieved = new System.Windows.Forms.CheckBox();
            this.nudShowSplitLength = new System.Windows.Forms.NumericUpDown();
            this.lblShowSplitLength = new System.Windows.Forms.Label();
            this.lblShowSplitSymbol = new System.Windows.Forms.Label();
            this.cbShowPause = new System.Windows.Forms.CheckBox();
            this.txtShowSplitSymbol = new System.Windows.Forms.TextBox();
            this.cbShowSplit = new System.Windows.Forms.CheckBox();
            this.radShowEndodingBase64 = new System.Windows.Forms.RadioButton();
            this.radShowEndodingUnicode = new System.Windows.Forms.RadioButton();
            this.radShowEndodingUTF8 = new System.Windows.Forms.RadioButton();
            this.radShowEndodingASCII = new System.Windows.Forms.RadioButton();
            this.radShowEndodingHex = new System.Windows.Forms.RadioButton();
            this.radShowEndodingDec = new System.Windows.Forms.RadioButton();
            this.radShowEndodingOtc = new System.Windows.Forms.RadioButton();
            this.cbShowDateTime = new System.Windows.Forms.CheckBox();
            this.cbShowDestination = new System.Windows.Forms.CheckBox();
            this.radShowEndodingBin = new System.Windows.Forms.RadioButton();
            this.cbShowSource = new System.Windows.Forms.CheckBox();
            this.txtRecordConetnt = new System.Windows.Forms.TextBox();
            this.grpOperation = new System.Windows.Forms.GroupBox();
            this.btnRecordContentExport = new System.Windows.Forms.Button();
            this.btnRecordContentClear = new System.Windows.Forms.Button();
            this.tmShowRefreshAcceptList = new System.Windows.Forms.Timer(this.components);
            this.tmCheckBreak = new System.Windows.Forms.Timer(this.components);
            this.tmShowRecord = new System.Windows.Forms.Timer(this.components);
            this.grpPortListening.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.nudRemotePort)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.nudLocalPort)).BeginInit();
            this.grpHostAccept.SuspendLayout();
            this.cmsHostAccept.SuspendLayout();
            this.grpHostDeny.SuspendLayout();
            this.cmsHostDeny.SuspendLayout();
            this.grpRecordFilter.SuspendLayout();
            this.cmsRecordFilter.SuspendLayout();
            this.grpRecordReplace.SuspendLayout();
            this.cmsRecordReplace.SuspendLayout();
            this.grpRecordShow.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.nudShowSplitLength)).BeginInit();
            this.grpOperation.SuspendLayout();
            this.SuspendLayout();
            // 
            // grpPortListening
            // 
            this.grpPortListening.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left)
                        | System.Windows.Forms.AnchorStyles.Right)));
            this.grpPortListening.Controls.Add(this.cbIsCheckBreak);
            this.grpPortListening.Controls.Add(this.lblProtocol);
            this.grpPortListening.Controls.Add(this.lblRemotePort);
            this.grpPortListening.Controls.Add(this.lblRemoteIPAddress);
            this.grpPortListening.Controls.Add(this.lblLocalPort);
            this.grpPortListening.Controls.Add(this.lblLocalIPAddress);
            this.grpPortListening.Controls.Add(this.nudRemotePort);
            this.grpPortListening.Controls.Add(this.nudLocalPort);
            this.grpPortListening.Controls.Add(this.txtRemoteIPAddress);
            this.grpPortListening.Controls.Add(this.cbbLocalIPAddress);
            this.grpPortListening.Controls.Add(this.cbbProtocol);
            this.grpPortListening.Controls.Add(this.btnOk);
            this.grpPortListening.Location = new System.Drawing.Point(13, 12);
            this.grpPortListening.Name = "grpPortListening";
            this.grpPortListening.Size = new System.Drawing.Size(910, 57);
            this.grpPortListening.TabIndex = 0;
            this.grpPortListening.TabStop = false;
            this.grpPortListening.Text = "监听设置";
            // 
            // cbIsCheckBreak
            // 
            this.cbIsCheckBreak.AutoSize = true;
            this.cbIsCheckBreak.Location = new System.Drawing.Point(618, 24);
            this.cbIsCheckBreak.Name = "cbIsCheckBreak";
            this.cbIsCheckBreak.Size = new System.Drawing.Size(72, 16);
            this.cbIsCheckBreak.TabIndex = 11;
            this.cbIsCheckBreak.Text = "掉线检测";
            this.cbIsCheckBreak.UseVisualStyleBackColor = true;
            this.cbIsCheckBreak.CheckedChanged += new System.EventHandler(this.cbIsCheckBreak_CheckedChanged);
            // 
            // lblProtocol
            // 
            this.lblProtocol.AutoSize = true;
            this.lblProtocol.Location = new System.Drawing.Point(504, 26);
            this.lblProtocol.Name = "lblProtocol";
            this.lblProtocol.Size = new System.Drawing.Size(41, 12);
            this.lblProtocol.TabIndex = 10;
            this.lblProtocol.Text = "协议：";
            // 
            // lblRemotePort
            // 
            this.lblRemotePort.AutoSize = true;
            this.lblRemotePort.Location = new System.Drawing.Point(406, 26);
            this.lblRemotePort.Name = "lblRemotePort";
            this.lblRemotePort.Size = new System.Drawing.Size(41, 12);
            this.lblRemotePort.TabIndex = 9;
            this.lblRemotePort.Text = "端口：";
            // 
            // lblRemoteIPAddress
            // 
            this.lblRemoteIPAddress.AutoSize = true;
            this.lblRemoteIPAddress.Location = new System.Drawing.Point(263, 26);
            this.lblRemoteIPAddress.Name = "lblRemoteIPAddress";
            this.lblRemoteIPAddress.Size = new System.Drawing.Size(41, 12);
            this.lblRemoteIPAddress.TabIndex = 8;
            this.lblRemoteIPAddress.Text = "远程：";
            // 
            // lblLocalPort
            // 
            this.lblLocalPort.AutoSize = true;
            this.lblLocalPort.Location = new System.Drawing.Point(165, 26);
            this.lblLocalPort.Name = "lblLocalPort";
            this.lblLocalPort.Size = new System.Drawing.Size(41, 12);
            this.lblLocalPort.TabIndex = 7;
            this.lblLocalPort.Text = "端口：";
            // 
            // lblLocalIPAddress
            // 
            this.lblLocalIPAddress.AutoSize = true;
            this.lblLocalIPAddress.Location = new System.Drawing.Point(7, 26);
            this.lblLocalIPAddress.Name = "lblLocalIPAddress";
            this.lblLocalIPAddress.Size = new System.Drawing.Size(41, 12);
            this.lblLocalIPAddress.TabIndex = 6;
            this.lblLocalIPAddress.Text = "本地：";
            // 
            // nudRemotePort
            // 
            this.nudRemotePort.Location = new System.Drawing.Point(447, 22);
            this.nudRemotePort.Maximum = new decimal(new int[] {
            65535,
            0,
            0,
            0});
            this.nudRemotePort.Name = "nudRemotePort";
            this.nudRemotePort.Size = new System.Drawing.Size(55, 21);
            this.nudRemotePort.TabIndex = 5;
            this.nudRemotePort.Value = new decimal(new int[] {
            20000,
            0,
            0,
            0});
            // 
            // nudLocalPort
            // 
            this.nudLocalPort.Location = new System.Drawing.Point(206, 22);
            this.nudLocalPort.Maximum = new decimal(new int[] {
            65535,
            0,
            0,
            0});
            this.nudLocalPort.Name = "nudLocalPort";
            this.nudLocalPort.Size = new System.Drawing.Size(55, 21);
            this.nudLocalPort.TabIndex = 4;
            this.nudLocalPort.Value = new decimal(new int[] {
            10000,
            0,
            0,
            0});
            // 
            // txtRemoteIPAddress
            // 
            this.txtRemoteIPAddress.Location = new System.Drawing.Point(304, 22);
            this.txtRemoteIPAddress.Name = "txtRemoteIPAddress";
            this.txtRemoteIPAddress.Size = new System.Drawing.Size(100, 21);
            this.txtRemoteIPAddress.TabIndex = 3;
            this.txtRemoteIPAddress.Text = "127.0.0.1";
            // 
            // cbbLocalIPAddress
            // 
            this.cbbLocalIPAddress.Cursor = System.Windows.Forms.Cursors.Hand;
            this.cbbLocalIPAddress.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbbLocalIPAddress.FormattingEnabled = true;
            this.cbbLocalIPAddress.Location = new System.Drawing.Point(48, 22);
            this.cbbLocalIPAddress.Name = "cbbLocalIPAddress";
            this.cbbLocalIPAddress.Size = new System.Drawing.Size(115, 20);
            this.cbbLocalIPAddress.TabIndex = 2;
            // 
            // cbbProtocol
            // 
            this.cbbProtocol.Cursor = System.Windows.Forms.Cursors.Hand;
            this.cbbProtocol.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbbProtocol.FormattingEnabled = true;
            this.cbbProtocol.Location = new System.Drawing.Point(545, 22);
            this.cbbProtocol.Name = "cbbProtocol";
            this.cbbProtocol.Size = new System.Drawing.Size(65, 20);
            this.cbbProtocol.TabIndex = 1;
            // 
            // btnOk
            // 
            this.btnOk.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom)
                        | System.Windows.Forms.AnchorStyles.Right)));
            this.btnOk.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnOk.Location = new System.Drawing.Point(829, 21);
            this.btnOk.Name = "btnOk";
            this.btnOk.Size = new System.Drawing.Size(75, 23);
            this.btnOk.TabIndex = 0;
            this.btnOk.Text = "开始";
            this.btnOk.UseVisualStyleBackColor = true;
            this.btnOk.Click += new System.EventHandler(this.btnOk_Click);
            // 
            // grpHostAccept
            // 
            this.grpHostAccept.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom)
                        | System.Windows.Forms.AnchorStyles.Left)));
            this.grpHostAccept.Controls.Add(this.cbListHostAccept);
            this.grpHostAccept.Location = new System.Drawing.Point(12, 75);
            this.grpHostAccept.Name = "grpHostAccept";
            this.grpHostAccept.Size = new System.Drawing.Size(165, 280);
            this.grpHostAccept.TabIndex = 1;
            this.grpHostAccept.TabStop = false;
            this.grpHostAccept.Text = "接受主机列表";
            // 
            // cbListHostAccept
            // 
            this.cbListHostAccept.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom)
                        | System.Windows.Forms.AnchorStyles.Left)
                        | System.Windows.Forms.AnchorStyles.Right)));
            this.cbListHostAccept.ContextMenuStrip = this.cmsHostAccept;
            this.cbListHostAccept.FormattingEnabled = true;
            this.cbListHostAccept.Location = new System.Drawing.Point(8, 14);
            this.cbListHostAccept.Name = "cbListHostAccept";
            this.cbListHostAccept.Size = new System.Drawing.Size(150, 260);
            this.cbListHostAccept.TabIndex = 0;
            this.cbListHostAccept.ItemCheck += new System.Windows.Forms.ItemCheckEventHandler(this.cbListHostAccept_ItemCheck);
            // 
            // cmsHostAccept
            // 
            this.cmsHostAccept.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.tsmiBreak});
            this.cmsHostAccept.Name = "contextMenuStrip1";
            this.cmsHostAccept.Size = new System.Drawing.Size(153, 48);
            this.cmsHostAccept.Opening += new System.ComponentModel.CancelEventHandler(this.cmsHostAccept_Opening);
            // 
            // tsmiBreak
            // 
            this.tsmiBreak.Name = "tsmiBreak";
            this.tsmiBreak.Size = new System.Drawing.Size(152, 22);
            this.tsmiBreak.Tag = "Break";
            this.tsmiBreak.Text = "断开连接";
            // 
            // grpHostDeny
            // 
            this.grpHostDeny.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.grpHostDeny.Controls.Add(this.cbListHostDeny);
            this.grpHostDeny.Location = new System.Drawing.Point(12, 361);
            this.grpHostDeny.Name = "grpHostDeny";
            this.grpHostDeny.Size = new System.Drawing.Size(165, 140);
            this.grpHostDeny.TabIndex = 2;
            this.grpHostDeny.TabStop = false;
            this.grpHostDeny.Text = "拒绝主机列表";
            // 
            // cbListHostDeny
            // 
            this.cbListHostDeny.ContextMenuStrip = this.cmsHostDeny;
            this.cbListHostDeny.FormattingEnabled = true;
            this.cbListHostDeny.Location = new System.Drawing.Point(8, 20);
            this.cbListHostDeny.Name = "cbListHostDeny";
            this.cbListHostDeny.Size = new System.Drawing.Size(150, 116);
            this.cbListHostDeny.TabIndex = 1;
            this.cbListHostDeny.ItemCheck += new System.Windows.Forms.ItemCheckEventHandler(this.cbListHostDeny_ItemCheck);
            // 
            // cmsHostDeny
            // 
            this.cmsHostDeny.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.tsmiHostDenyAdd,
            this.tsmiHostDenyEdit,
            this.tsmiHostDenyDelete,
            this.tsmiHostDenyClear,
            this.tsmiHostDenyAll,
            this.tsmiHostDenyInvert});
            this.cmsHostDeny.Name = "cmsHostDeny";
            this.cmsHostDeny.Size = new System.Drawing.Size(101, 136);
            this.cmsHostDeny.Opening += new System.ComponentModel.CancelEventHandler(this.cmsHostDeny_Opening);
            // 
            // tsmiHostDenyAdd
            // 
            this.tsmiHostDenyAdd.Name = "tsmiHostDenyAdd";
            this.tsmiHostDenyAdd.Size = new System.Drawing.Size(100, 22);
            this.tsmiHostDenyAdd.Tag = "Add";
            this.tsmiHostDenyAdd.Text = "添加";
            this.tsmiHostDenyAdd.Click += new System.EventHandler(this.tsmiHostDenyAdd_Click);
            // 
            // tsmiHostDenyEdit
            // 
            this.tsmiHostDenyEdit.Name = "tsmiHostDenyEdit";
            this.tsmiHostDenyEdit.Size = new System.Drawing.Size(100, 22);
            this.tsmiHostDenyEdit.Tag = "Edit";
            this.tsmiHostDenyEdit.Text = "修改";
            this.tsmiHostDenyEdit.Click += new System.EventHandler(this.tsmiHostDenyEdit_Click);
            // 
            // tsmiHostDenyDelete
            // 
            this.tsmiHostDenyDelete.Name = "tsmiHostDenyDelete";
            this.tsmiHostDenyDelete.Size = new System.Drawing.Size(100, 22);
            this.tsmiHostDenyDelete.Tag = "Delete";
            this.tsmiHostDenyDelete.Text = "删除";
            this.tsmiHostDenyDelete.Click += new System.EventHandler(this.tsmiHostDenyDelete_Click);
            // 
            // tsmiHostDenyClear
            // 
            this.tsmiHostDenyClear.Name = "tsmiHostDenyClear";
            this.tsmiHostDenyClear.Size = new System.Drawing.Size(100, 22);
            this.tsmiHostDenyClear.Tag = "Clear";
            this.tsmiHostDenyClear.Text = "清空";
            this.tsmiHostDenyClear.Click += new System.EventHandler(this.tsmiHostDenyClear_Click);
            // 
            // tsmiHostDenyAll
            // 
            this.tsmiHostDenyAll.Name = "tsmiHostDenyAll";
            this.tsmiHostDenyAll.Size = new System.Drawing.Size(100, 22);
            this.tsmiHostDenyAll.Tag = "All";
            this.tsmiHostDenyAll.Text = "全选";
            this.tsmiHostDenyAll.Click += new System.EventHandler(this.tsmiHostDenyAll_Click);
            // 
            // tsmiHostDenyInvert
            // 
            this.tsmiHostDenyInvert.Name = "tsmiHostDenyInvert";
            this.tsmiHostDenyInvert.Size = new System.Drawing.Size(100, 22);
            this.tsmiHostDenyInvert.Tag = "Invert";
            this.tsmiHostDenyInvert.Text = "反选";
            this.tsmiHostDenyInvert.Click += new System.EventHandler(this.tsmiHostDenyInvert_Click);
            // 
            // grpRecordFilter
            // 
            this.grpRecordFilter.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left)
                        | System.Windows.Forms.AnchorStyles.Right)));
            this.grpRecordFilter.Controls.Add(this.cbListRecordFilter);
            this.grpRecordFilter.Location = new System.Drawing.Point(183, 75);
            this.grpRecordFilter.Name = "grpRecordFilter";
            this.grpRecordFilter.Size = new System.Drawing.Size(740, 95);
            this.grpRecordFilter.TabIndex = 3;
            this.grpRecordFilter.TabStop = false;
            this.grpRecordFilter.Text = "过滤规则";
            // 
            // cbListRecordFilter
            // 
            this.cbListRecordFilter.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom)
                        | System.Windows.Forms.AnchorStyles.Left)
                        | System.Windows.Forms.AnchorStyles.Right)));
            this.cbListRecordFilter.ContextMenuStrip = this.cmsRecordFilter;
            this.cbListRecordFilter.FormattingEnabled = true;
            this.cbListRecordFilter.Items.AddRange(new object[] {
            "Any"});
            this.cbListRecordFilter.Location = new System.Drawing.Point(6, 20);
            this.cbListRecordFilter.Name = "cbListRecordFilter";
            this.cbListRecordFilter.Size = new System.Drawing.Size(728, 68);
            this.cbListRecordFilter.TabIndex = 0;
            this.cbListRecordFilter.ItemCheck += new System.Windows.Forms.ItemCheckEventHandler(this.cbListRecordFilter_ItemCheck);
            // 
            // cmsRecordFilter
            // 
            this.cmsRecordFilter.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.tsmiRecordFilterAdd,
            this.tsmiRecordFilterEdit,
            this.tsmiRecordFilterDelete,
            this.tsmiRecordFilterClear,
            this.tsmiRecordFilterAll,
            this.tsmiRecordFilterInvert});
            this.cmsRecordFilter.Name = "contextMenuStrip1";
            this.cmsRecordFilter.Size = new System.Drawing.Size(101, 136);
            this.cmsRecordFilter.Opening += new System.ComponentModel.CancelEventHandler(this.cmsRecordFilter_Opening);
            // 
            // tsmiRecordFilterAdd
            // 
            this.tsmiRecordFilterAdd.Name = "tsmiRecordFilterAdd";
            this.tsmiRecordFilterAdd.Size = new System.Drawing.Size(152, 22);
            this.tsmiRecordFilterAdd.Tag = "Add";
            this.tsmiRecordFilterAdd.Text = "添加";
            // 
            // tsmiRecordFilterEdit
            // 
            this.tsmiRecordFilterEdit.Name = "tsmiRecordFilterEdit";
            this.tsmiRecordFilterEdit.Size = new System.Drawing.Size(152, 22);
            this.tsmiRecordFilterEdit.Tag = "Edit";
            this.tsmiRecordFilterEdit.Text = "修改";
            // 
            // tsmiRecordFilterDelete
            // 
            this.tsmiRecordFilterDelete.Name = "tsmiRecordFilterDelete";
            this.tsmiRecordFilterDelete.Size = new System.Drawing.Size(152, 22);
            this.tsmiRecordFilterDelete.Tag = "Delete";
            this.tsmiRecordFilterDelete.Text = "删除";
            // 
            // tsmiRecordFilterClear
            // 
            this.tsmiRecordFilterClear.Name = "tsmiRecordFilterClear";
            this.tsmiRecordFilterClear.Size = new System.Drawing.Size(152, 22);
            this.tsmiRecordFilterClear.Tag = "Clear";
            this.tsmiRecordFilterClear.Text = "清空";
            // 
            // tsmiRecordFilterAll
            // 
            this.tsmiRecordFilterAll.Name = "tsmiRecordFilterAll";
            this.tsmiRecordFilterAll.Size = new System.Drawing.Size(152, 22);
            this.tsmiRecordFilterAll.Tag = "All";
            this.tsmiRecordFilterAll.Text = "全选";
            // 
            // tsmiRecordFilterInvert
            // 
            this.tsmiRecordFilterInvert.Name = "tsmiRecordFilterInvert";
            this.tsmiRecordFilterInvert.Size = new System.Drawing.Size(152, 22);
            this.tsmiRecordFilterInvert.Tag = "Invert";
            this.tsmiRecordFilterInvert.Text = "反选";
            // 
            // grpRecordReplace
            // 
            this.grpRecordReplace.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left)
                        | System.Windows.Forms.AnchorStyles.Right)));
            this.grpRecordReplace.Controls.Add(this.cbListRecordReplace);
            this.grpRecordReplace.Location = new System.Drawing.Point(183, 176);
            this.grpRecordReplace.Name = "grpRecordReplace";
            this.grpRecordReplace.Size = new System.Drawing.Size(740, 95);
            this.grpRecordReplace.TabIndex = 4;
            this.grpRecordReplace.TabStop = false;
            this.grpRecordReplace.Text = "替换规则";
            // 
            // cbListRecordReplace
            // 
            this.cbListRecordReplace.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom)
                        | System.Windows.Forms.AnchorStyles.Left)
                        | System.Windows.Forms.AnchorStyles.Right)));
            this.cbListRecordReplace.ContextMenuStrip = this.cmsRecordReplace;
            this.cbListRecordReplace.FormattingEnabled = true;
            this.cbListRecordReplace.Location = new System.Drawing.Point(6, 20);
            this.cbListRecordReplace.Name = "cbListRecordReplace";
            this.cbListRecordReplace.Size = new System.Drawing.Size(728, 68);
            this.cbListRecordReplace.TabIndex = 1;
            this.cbListRecordReplace.ItemCheck += new System.Windows.Forms.ItemCheckEventHandler(this.cbListRecordReplace_ItemCheck);
            // 
            // cmsRecordReplace
            // 
            this.cmsRecordReplace.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.tsmiRecordReplaceAdd,
            this.tsmiRecordReplaceEdit,
            this.tsmiRecordReplaceDelete,
            this.tsmiRecordReplaceClear,
            this.tsmiRecordReplaceAll,
            this.tsmiRecordReplaceInvert});
            this.cmsRecordReplace.Name = "cmsRecordReplace";
            this.cmsRecordReplace.Size = new System.Drawing.Size(101, 136);
            this.cmsRecordReplace.Opening += new System.ComponentModel.CancelEventHandler(this.cmsRecordReplace_Opening);
            // 
            // tsmiRecordReplaceAdd
            // 
            this.tsmiRecordReplaceAdd.Name = "tsmiRecordReplaceAdd";
            this.tsmiRecordReplaceAdd.Size = new System.Drawing.Size(152, 22);
            this.tsmiRecordReplaceAdd.Tag = "Add";
            this.tsmiRecordReplaceAdd.Text = "添加";
            // 
            // tsmiRecordReplaceEdit
            // 
            this.tsmiRecordReplaceEdit.Name = "tsmiRecordReplaceEdit";
            this.tsmiRecordReplaceEdit.Size = new System.Drawing.Size(152, 22);
            this.tsmiRecordReplaceEdit.Tag = "Edit";
            this.tsmiRecordReplaceEdit.Text = "修改";
            // 
            // tsmiRecordReplaceDelete
            // 
            this.tsmiRecordReplaceDelete.Name = "tsmiRecordReplaceDelete";
            this.tsmiRecordReplaceDelete.Size = new System.Drawing.Size(152, 22);
            this.tsmiRecordReplaceDelete.Tag = "Delete";
            this.tsmiRecordReplaceDelete.Text = "删除";
            // 
            // tsmiRecordReplaceClear
            // 
            this.tsmiRecordReplaceClear.Name = "tsmiRecordReplaceClear";
            this.tsmiRecordReplaceClear.Size = new System.Drawing.Size(152, 22);
            this.tsmiRecordReplaceClear.Tag = "Clear";
            this.tsmiRecordReplaceClear.Text = "清空";
            // 
            // tsmiRecordReplaceAll
            // 
            this.tsmiRecordReplaceAll.Name = "tsmiRecordReplaceAll";
            this.tsmiRecordReplaceAll.Size = new System.Drawing.Size(152, 22);
            this.tsmiRecordReplaceAll.Tag = "All";
            this.tsmiRecordReplaceAll.Text = "全选";
            // 
            // tsmiRecordReplaceInvert
            // 
            this.tsmiRecordReplaceInvert.Name = "tsmiRecordReplaceInvert";
            this.tsmiRecordReplaceInvert.Size = new System.Drawing.Size(152, 22);
            this.tsmiRecordReplaceInvert.Tag = "Invert";
            this.tsmiRecordReplaceInvert.Text = "反选";
            // 
            // grpRecordShow
            // 
            this.grpRecordShow.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom)
                        | System.Windows.Forms.AnchorStyles.Left)
                        | System.Windows.Forms.AnchorStyles.Right)));
            this.grpRecordShow.Controls.Add(this.cbShowSended);
            this.grpRecordShow.Controls.Add(this.cbShowRecieved);
            this.grpRecordShow.Controls.Add(this.nudShowSplitLength);
            this.grpRecordShow.Controls.Add(this.lblShowSplitLength);
            this.grpRecordShow.Controls.Add(this.lblShowSplitSymbol);
            this.grpRecordShow.Controls.Add(this.cbShowPause);
            this.grpRecordShow.Controls.Add(this.txtShowSplitSymbol);
            this.grpRecordShow.Controls.Add(this.cbShowSplit);
            this.grpRecordShow.Controls.Add(this.radShowEndodingBase64);
            this.grpRecordShow.Controls.Add(this.radShowEndodingUnicode);
            this.grpRecordShow.Controls.Add(this.radShowEndodingUTF8);
            this.grpRecordShow.Controls.Add(this.radShowEndodingASCII);
            this.grpRecordShow.Controls.Add(this.radShowEndodingHex);
            this.grpRecordShow.Controls.Add(this.radShowEndodingDec);
            this.grpRecordShow.Controls.Add(this.radShowEndodingOtc);
            this.grpRecordShow.Controls.Add(this.cbShowDateTime);
            this.grpRecordShow.Controls.Add(this.cbShowDestination);
            this.grpRecordShow.Controls.Add(this.radShowEndodingBin);
            this.grpRecordShow.Controls.Add(this.cbShowSource);
            this.grpRecordShow.Controls.Add(this.txtRecordConetnt);
            this.grpRecordShow.Location = new System.Drawing.Point(183, 277);
            this.grpRecordShow.Name = "grpRecordShow";
            this.grpRecordShow.Size = new System.Drawing.Size(740, 174);
            this.grpRecordShow.TabIndex = 5;
            this.grpRecordShow.TabStop = false;
            this.grpRecordShow.Text = "显示记录";
            // 
            // cbShowSended
            // 
            this.cbShowSended.AutoSize = true;
            this.cbShowSended.Location = new System.Drawing.Point(231, 21);
            this.cbShowSended.Name = "cbShowSended";
            this.cbShowSended.Size = new System.Drawing.Size(48, 16);
            this.cbShowSended.TabIndex = 20;
            this.cbShowSended.Text = "发送";
            this.cbShowSended.UseVisualStyleBackColor = true;
            this.cbShowSended.CheckedChanged += new System.EventHandler(this.cbShowSended_CheckedChanged);
            // 
            // cbShowRecieved
            // 
            this.cbShowRecieved.AutoSize = true;
            this.cbShowRecieved.Checked = true;
            this.cbShowRecieved.CheckState = System.Windows.Forms.CheckState.Checked;
            this.cbShowRecieved.Location = new System.Drawing.Point(175, 21);
            this.cbShowRecieved.Name = "cbShowRecieved";
            this.cbShowRecieved.Size = new System.Drawing.Size(48, 16);
            this.cbShowRecieved.TabIndex = 19;
            this.cbShowRecieved.Text = "收到";
            this.cbShowRecieved.UseVisualStyleBackColor = true;
            this.cbShowRecieved.CheckedChanged += new System.EventHandler(this.cbShowRecieved_CheckedChanged);
            // 
            // nudShowSplitLength
            // 
            this.nudShowSplitLength.Enabled = false;
            this.nudShowSplitLength.Location = new System.Drawing.Point(565, 19);
            this.nudShowSplitLength.Maximum = new decimal(new int[] {
            9999,
            0,
            0,
            0});
            this.nudShowSplitLength.Name = "nudShowSplitLength";
            this.nudShowSplitLength.Size = new System.Drawing.Size(68, 21);
            this.nudShowSplitLength.TabIndex = 18;
            this.nudShowSplitLength.Value = new decimal(new int[] {
            8,
            0,
            0,
            0});
            this.nudShowSplitLength.ValueChanged += new System.EventHandler(this.nudShowSplitLength_ValueChanged);
            // 
            // lblShowSplitLength
            // 
            this.lblShowSplitLength.AutoSize = true;
            this.lblShowSplitLength.Location = new System.Drawing.Point(516, 23);
            this.lblShowSplitLength.Name = "lblShowSplitLength";
            this.lblShowSplitLength.Size = new System.Drawing.Size(41, 12);
            this.lblShowSplitLength.TabIndex = 17;
            this.lblShowSplitLength.Text = "位数：";
            // 
            // lblShowSplitSymbol
            // 
            this.lblShowSplitSymbol.AutoSize = true;
            this.lblShowSplitSymbol.Location = new System.Drawing.Point(399, 23);
            this.lblShowSplitSymbol.Name = "lblShowSplitSymbol";
            this.lblShowSplitSymbol.Size = new System.Drawing.Size(41, 12);
            this.lblShowSplitSymbol.TabIndex = 16;
            this.lblShowSplitSymbol.Text = "符号：";
            // 
            // cbShowPause
            // 
            this.cbShowPause.AutoSize = true;
            this.cbShowPause.Cursor = System.Windows.Forms.Cursors.Hand;
            this.cbShowPause.Location = new System.Drawing.Point(287, 21);
            this.cbShowPause.Name = "cbShowPause";
            this.cbShowPause.Size = new System.Drawing.Size(48, 16);
            this.cbShowPause.TabIndex = 15;
            this.cbShowPause.Text = "暂停";
            this.cbShowPause.UseVisualStyleBackColor = true;
            this.cbShowPause.CheckedChanged += new System.EventHandler(this.cbShowPause_CheckedChanged);
            // 
            // txtShowSplitSymbol
            // 
            this.txtShowSplitSymbol.Enabled = false;
            this.txtShowSplitSymbol.Location = new System.Drawing.Point(448, 19);
            this.txtShowSplitSymbol.Name = "txtShowSplitSymbol";
            this.txtShowSplitSymbol.Size = new System.Drawing.Size(60, 21);
            this.txtShowSplitSymbol.TabIndex = 13;
            this.txtShowSplitSymbol.Text = " ";
            this.txtShowSplitSymbol.TextChanged += new System.EventHandler(this.txtShowSplitSymbol_TextChanged);
            // 
            // cbShowSplit
            // 
            this.cbShowSplit.AutoSize = true;
            this.cbShowSplit.Cursor = System.Windows.Forms.Cursors.Hand;
            this.cbShowSplit.Location = new System.Drawing.Point(343, 21);
            this.cbShowSplit.Name = "cbShowSplit";
            this.cbShowSplit.Size = new System.Drawing.Size(48, 16);
            this.cbShowSplit.TabIndex = 12;
            this.cbShowSplit.Text = "分隔";
            this.cbShowSplit.UseVisualStyleBackColor = true;
            this.cbShowSplit.CheckedChanged += new System.EventHandler(this.cbShowSplit_CheckedChanged);
            // 
            // radShowEndodingBase64
            // 
            this.radShowEndodingBase64.AutoSize = true;
            this.radShowEndodingBase64.Cursor = System.Windows.Forms.Cursors.Hand;
            this.radShowEndodingBase64.Location = new System.Drawing.Point(448, 48);
            this.radShowEndodingBase64.Name = "radShowEndodingBase64";
            this.radShowEndodingBase64.Size = new System.Drawing.Size(59, 16);
            this.radShowEndodingBase64.TabIndex = 11;
            this.radShowEndodingBase64.Text = "Base64";
            this.radShowEndodingBase64.UseVisualStyleBackColor = true;
            this.radShowEndodingBase64.CheckedChanged += new System.EventHandler(this.radShowEndodingBase64_CheckedChanged);
            // 
            // radShowEndodingUnicode
            // 
            this.radShowEndodingUnicode.AutoSize = true;
            this.radShowEndodingUnicode.Cursor = System.Windows.Forms.Cursors.Hand;
            this.radShowEndodingUnicode.Location = new System.Drawing.Point(367, 48);
            this.radShowEndodingUnicode.Name = "radShowEndodingUnicode";
            this.radShowEndodingUnicode.Size = new System.Drawing.Size(65, 16);
            this.radShowEndodingUnicode.TabIndex = 10;
            this.radShowEndodingUnicode.Text = "Unicode";
            this.radShowEndodingUnicode.UseVisualStyleBackColor = true;
            this.radShowEndodingUnicode.CheckedChanged += new System.EventHandler(this.radShowEndodingUnicode_CheckedChanged);
            // 
            // radShowEndodingUTF8
            // 
            this.radShowEndodingUTF8.AutoSize = true;
            this.radShowEndodingUTF8.Cursor = System.Windows.Forms.Cursors.Hand;
            this.radShowEndodingUTF8.Location = new System.Drawing.Point(304, 48);
            this.radShowEndodingUTF8.Name = "radShowEndodingUTF8";
            this.radShowEndodingUTF8.Size = new System.Drawing.Size(47, 16);
            this.radShowEndodingUTF8.TabIndex = 9;
            this.radShowEndodingUTF8.Text = "UTF8";
            this.radShowEndodingUTF8.UseVisualStyleBackColor = true;
            this.radShowEndodingUTF8.CheckedChanged += new System.EventHandler(this.radShowEndodingUTF8_CheckedChanged);
            // 
            // radShowEndodingASCII
            // 
            this.radShowEndodingASCII.AutoSize = true;
            this.radShowEndodingASCII.Checked = true;
            this.radShowEndodingASCII.Cursor = System.Windows.Forms.Cursors.Hand;
            this.radShowEndodingASCII.Location = new System.Drawing.Point(235, 48);
            this.radShowEndodingASCII.Name = "radShowEndodingASCII";
            this.radShowEndodingASCII.Size = new System.Drawing.Size(53, 16);
            this.radShowEndodingASCII.TabIndex = 8;
            this.radShowEndodingASCII.TabStop = true;
            this.radShowEndodingASCII.Text = "ASCII";
            this.radShowEndodingASCII.UseVisualStyleBackColor = true;
            this.radShowEndodingASCII.CheckedChanged += new System.EventHandler(this.radShowEndodingASCII_CheckedChanged);
            // 
            // radShowEndodingHex
            // 
            this.radShowEndodingHex.AutoSize = true;
            this.radShowEndodingHex.Cursor = System.Windows.Forms.Cursors.Hand;
            this.radShowEndodingHex.Location = new System.Drawing.Point(178, 48);
            this.radShowEndodingHex.Name = "radShowEndodingHex";
            this.radShowEndodingHex.Size = new System.Drawing.Size(41, 16);
            this.radShowEndodingHex.TabIndex = 7;
            this.radShowEndodingHex.Text = "Hex";
            this.radShowEndodingHex.UseVisualStyleBackColor = true;
            this.radShowEndodingHex.CheckedChanged += new System.EventHandler(this.radShowEndodingHex_CheckedChanged);
            // 
            // radShowEndodingDec
            // 
            this.radShowEndodingDec.AutoSize = true;
            this.radShowEndodingDec.Cursor = System.Windows.Forms.Cursors.Hand;
            this.radShowEndodingDec.Location = new System.Drawing.Point(121, 48);
            this.radShowEndodingDec.Name = "radShowEndodingDec";
            this.radShowEndodingDec.Size = new System.Drawing.Size(41, 16);
            this.radShowEndodingDec.TabIndex = 6;
            this.radShowEndodingDec.Text = "Dec";
            this.radShowEndodingDec.UseVisualStyleBackColor = true;
            this.radShowEndodingDec.CheckedChanged += new System.EventHandler(this.radShowEndodingDec_CheckedChanged);
            // 
            // radShowEndodingOtc
            // 
            this.radShowEndodingOtc.AutoSize = true;
            this.radShowEndodingOtc.Cursor = System.Windows.Forms.Cursors.Hand;
            this.radShowEndodingOtc.Location = new System.Drawing.Point(64, 48);
            this.radShowEndodingOtc.Name = "radShowEndodingOtc";
            this.radShowEndodingOtc.Size = new System.Drawing.Size(41, 16);
            this.radShowEndodingOtc.TabIndex = 5;
            this.radShowEndodingOtc.Text = "Oct";
            this.radShowEndodingOtc.UseVisualStyleBackColor = true;
            this.radShowEndodingOtc.CheckedChanged += new System.EventHandler(this.radShowEndodingOtc_CheckedChanged);
            // 
            // cbShowDateTime
            // 
            this.cbShowDateTime.AutoSize = true;
            this.cbShowDateTime.Checked = true;
            this.cbShowDateTime.CheckState = System.Windows.Forms.CheckState.Checked;
            this.cbShowDateTime.Cursor = System.Windows.Forms.Cursors.Hand;
            this.cbShowDateTime.Location = new System.Drawing.Point(119, 21);
            this.cbShowDateTime.Name = "cbShowDateTime";
            this.cbShowDateTime.Size = new System.Drawing.Size(48, 16);
            this.cbShowDateTime.TabIndex = 4;
            this.cbShowDateTime.Text = "时间";
            this.cbShowDateTime.UseVisualStyleBackColor = true;
            this.cbShowDateTime.CheckedChanged += new System.EventHandler(this.cbShowDateTime_CheckedChanged);
            // 
            // cbShowDestination
            // 
            this.cbShowDestination.AutoSize = true;
            this.cbShowDestination.Checked = true;
            this.cbShowDestination.CheckState = System.Windows.Forms.CheckState.Checked;
            this.cbShowDestination.Cursor = System.Windows.Forms.Cursors.Hand;
            this.cbShowDestination.Location = new System.Drawing.Point(63, 21);
            this.cbShowDestination.Name = "cbShowDestination";
            this.cbShowDestination.Size = new System.Drawing.Size(48, 16);
            this.cbShowDestination.TabIndex = 3;
            this.cbShowDestination.Text = "目标";
            this.cbShowDestination.UseVisualStyleBackColor = true;
            this.cbShowDestination.CheckedChanged += new System.EventHandler(this.cbShowDestination_CheckedChanged);
            // 
            // radShowEndodingBin
            // 
            this.radShowEndodingBin.AutoSize = true;
            this.radShowEndodingBin.Cursor = System.Windows.Forms.Cursors.Hand;
            this.radShowEndodingBin.Location = new System.Drawing.Point(7, 48);
            this.radShowEndodingBin.Name = "radShowEndodingBin";
            this.radShowEndodingBin.Size = new System.Drawing.Size(41, 16);
            this.radShowEndodingBin.TabIndex = 2;
            this.radShowEndodingBin.Text = "Bin";
            this.radShowEndodingBin.UseVisualStyleBackColor = true;
            this.radShowEndodingBin.CheckedChanged += new System.EventHandler(this.radShowEndodingBin_CheckedChanged);
            // 
            // cbShowSource
            // 
            this.cbShowSource.AutoSize = true;
            this.cbShowSource.Checked = true;
            this.cbShowSource.CheckState = System.Windows.Forms.CheckState.Checked;
            this.cbShowSource.Cursor = System.Windows.Forms.Cursors.Hand;
            this.cbShowSource.Location = new System.Drawing.Point(7, 21);
            this.cbShowSource.Name = "cbShowSource";
            this.cbShowSource.Size = new System.Drawing.Size(48, 16);
            this.cbShowSource.TabIndex = 1;
            this.cbShowSource.Text = "来源";
            this.cbShowSource.UseVisualStyleBackColor = true;
            this.cbShowSource.CheckedChanged += new System.EventHandler(this.cbShowSource_CheckedChanged);
            // 
            // txtRecordConetnt
            // 
            this.txtRecordConetnt.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom)
                        | System.Windows.Forms.AnchorStyles.Left)
                        | System.Windows.Forms.AnchorStyles.Right)));
            this.txtRecordConetnt.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.txtRecordConetnt.Location = new System.Drawing.Point(6, 70);
            this.txtRecordConetnt.Multiline = true;
            this.txtRecordConetnt.Name = "txtRecordConetnt";
            this.txtRecordConetnt.ReadOnly = true;
            this.txtRecordConetnt.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
            this.txtRecordConetnt.Size = new System.Drawing.Size(728, 98);
            this.txtRecordConetnt.TabIndex = 0;
            // 
            // grpOperation
            // 
            this.grpOperation.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)
                        | System.Windows.Forms.AnchorStyles.Right)));
            this.grpOperation.Controls.Add(this.btnRecordContentExport);
            this.grpOperation.Controls.Add(this.btnRecordContentClear);
            this.grpOperation.Location = new System.Drawing.Point(183, 457);
            this.grpOperation.Name = "grpOperation";
            this.grpOperation.Size = new System.Drawing.Size(740, 40);
            this.grpOperation.TabIndex = 6;
            this.grpOperation.TabStop = false;
            this.grpOperation.Text = "常用操作";
            // 
            // btnRecordContentExport
            // 
            this.btnRecordContentExport.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom)
                        | System.Windows.Forms.AnchorStyles.Right)));
            this.btnRecordContentExport.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnRecordContentExport.Location = new System.Drawing.Point(578, 12);
            this.btnRecordContentExport.Name = "btnRecordContentExport";
            this.btnRecordContentExport.Size = new System.Drawing.Size(75, 23);
            this.btnRecordContentExport.TabIndex = 3;
            this.btnRecordContentExport.Text = "导出";
            this.btnRecordContentExport.UseVisualStyleBackColor = true;
            this.btnRecordContentExport.Click += new System.EventHandler(this.btnRecordContentExport_Click);
            // 
            // btnRecordContentClear
            // 
            this.btnRecordContentClear.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom)
                        | System.Windows.Forms.AnchorStyles.Right)));
            this.btnRecordContentClear.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnRecordContentClear.Location = new System.Drawing.Point(659, 12);
            this.btnRecordContentClear.Name = "btnRecordContentClear";
            this.btnRecordContentClear.Size = new System.Drawing.Size(75, 23);
            this.btnRecordContentClear.TabIndex = 1;
            this.btnRecordContentClear.Text = "清空";
            this.btnRecordContentClear.UseVisualStyleBackColor = true;
            this.btnRecordContentClear.Click += new System.EventHandler(this.btnRecordContentClear_Click);
            // 
            // tmShowRefreshAcceptList
            // 
            this.tmShowRefreshAcceptList.Enabled = true;
            this.tmShowRefreshAcceptList.Interval = 1000;
            this.tmShowRefreshAcceptList.Tick += new System.EventHandler(this.tmShowRefreshAcceptList_Tick);
            // 
            // tmCheckBreak
            // 
            this.tmCheckBreak.Enabled = true;
            this.tmCheckBreak.Interval = 1000;
            this.tmCheckBreak.Tick += new System.EventHandler(this.tmCheckBreak_Tick);
            // 
            // tmShowRecord
            // 
            this.tmShowRecord.Enabled = true;
            this.tmShowRecord.Interval = 10;
            this.tmShowRecord.Tick += new System.EventHandler(this.tmShowRecord_Tick);
            // 
            // FormMain
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(934, 512);
            this.Controls.Add(this.grpOperation);
            this.Controls.Add(this.grpRecordShow);
            this.Controls.Add(this.grpRecordReplace);
            this.Controls.Add(this.grpRecordFilter);
            this.Controls.Add(this.grpHostDeny);
            this.Controls.Add(this.grpHostAccept);
            this.Controls.Add(this.grpPortListening);
            this.MinimumSize = new System.Drawing.Size(950, 550);
            this.Name = "FormMain";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Portforwarding Debug 2.0";
            this.Load += new System.EventHandler(this.FormMain_Load);
            this.grpPortListening.ResumeLayout(false);
            this.grpPortListening.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.nudRemotePort)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.nudLocalPort)).EndInit();
            this.grpHostAccept.ResumeLayout(false);
            this.cmsHostAccept.ResumeLayout(false);
            this.grpHostDeny.ResumeLayout(false);
            this.cmsHostDeny.ResumeLayout(false);
            this.grpRecordFilter.ResumeLayout(false);
            this.cmsRecordFilter.ResumeLayout(false);
            this.grpRecordReplace.ResumeLayout(false);
            this.cmsRecordReplace.ResumeLayout(false);
            this.grpRecordShow.ResumeLayout(false);
            this.grpRecordShow.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.nudShowSplitLength)).EndInit();
            this.grpOperation.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox grpPortListening;
        private System.Windows.Forms.NumericUpDown nudRemotePort;
        private System.Windows.Forms.NumericUpDown nudLocalPort;
        private System.Windows.Forms.TextBox txtRemoteIPAddress;
        private System.Windows.Forms.ComboBox cbbLocalIPAddress;
        private System.Windows.Forms.ComboBox cbbProtocol;
        private System.Windows.Forms.Button btnOk;
        private System.Windows.Forms.GroupBox grpHostAccept;
        private System.Windows.Forms.CheckedListBox cbListHostAccept;
        private System.Windows.Forms.GroupBox grpHostDeny;
        private System.Windows.Forms.CheckedListBox cbListHostDeny;
        private System.Windows.Forms.GroupBox grpRecordFilter;
        private System.Windows.Forms.CheckedListBox cbListRecordFilter;
        private System.Windows.Forms.GroupBox grpRecordReplace;
        private System.Windows.Forms.CheckedListBox cbListRecordReplace;
        private System.Windows.Forms.GroupBox grpRecordShow;
        private System.Windows.Forms.GroupBox grpOperation;
        private System.Windows.Forms.TextBox txtRecordConetnt;
        private System.Windows.Forms.Button btnRecordContentClear;
        private System.Windows.Forms.RadioButton radShowEndodingHex;
        private System.Windows.Forms.RadioButton radShowEndodingDec;
        private System.Windows.Forms.RadioButton radShowEndodingOtc;
        private System.Windows.Forms.CheckBox cbShowDateTime;
        private System.Windows.Forms.CheckBox cbShowDestination;
        private System.Windows.Forms.RadioButton radShowEndodingBin;
        private System.Windows.Forms.CheckBox cbShowSource;
        private System.Windows.Forms.Label lblShowSplitLength;
        private System.Windows.Forms.Label lblShowSplitSymbol;
        private System.Windows.Forms.CheckBox cbShowPause;
        private System.Windows.Forms.TextBox txtShowSplitSymbol;
        private System.Windows.Forms.CheckBox cbShowSplit;
        private System.Windows.Forms.RadioButton radShowEndodingBase64;
        private System.Windows.Forms.RadioButton radShowEndodingUnicode;
        private System.Windows.Forms.RadioButton radShowEndodingUTF8;
        private System.Windows.Forms.RadioButton radShowEndodingASCII;
        private System.Windows.Forms.Label lblProtocol;
        private System.Windows.Forms.Label lblRemotePort;
        private System.Windows.Forms.Label lblRemoteIPAddress;
        private System.Windows.Forms.Label lblLocalPort;
        private System.Windows.Forms.Label lblLocalIPAddress;
        private System.Windows.Forms.NumericUpDown nudShowSplitLength;
        private System.Windows.Forms.Button btnRecordContentExport;
        private System.Windows.Forms.CheckBox cbShowSended;
        private System.Windows.Forms.CheckBox cbShowRecieved;
        private System.Windows.Forms.Timer tmShowRefreshAcceptList;
        private System.Windows.Forms.CheckBox cbIsCheckBreak;
        private System.Windows.Forms.Timer tmCheckBreak;
        private System.Windows.Forms.Timer tmShowRecord;
        private System.Windows.Forms.ContextMenuStrip cmsHostDeny;
        private System.Windows.Forms.ToolStripMenuItem tsmiHostDenyAll;
        private System.Windows.Forms.ToolStripMenuItem tsmiHostDenyInvert;
        private System.Windows.Forms.ToolStripMenuItem tsmiHostDenyClear;
        private System.Windows.Forms.ToolStripMenuItem tsmiHostDenyAdd;
        private System.Windows.Forms.ToolStripMenuItem tsmiHostDenyEdit;
        private System.Windows.Forms.ToolStripMenuItem tsmiHostDenyDelete;
        private System.Windows.Forms.ContextMenuStrip cmsRecordFilter;
        private System.Windows.Forms.ContextMenuStrip cmsRecordReplace;
        private System.Windows.Forms.ContextMenuStrip cmsHostAccept;
        private System.Windows.Forms.ToolStripMenuItem tsmiRecordFilterAdd;
        private System.Windows.Forms.ToolStripMenuItem tsmiRecordFilterEdit;
        private System.Windows.Forms.ToolStripMenuItem tsmiRecordFilterDelete;
        private System.Windows.Forms.ToolStripMenuItem tsmiRecordFilterClear;
        private System.Windows.Forms.ToolStripMenuItem tsmiRecordFilterAll;
        private System.Windows.Forms.ToolStripMenuItem tsmiRecordFilterInvert;
        private System.Windows.Forms.ToolStripMenuItem tsmiRecordReplaceAdd;
        private System.Windows.Forms.ToolStripMenuItem tsmiRecordReplaceEdit;
        private System.Windows.Forms.ToolStripMenuItem tsmiRecordReplaceDelete;
        private System.Windows.Forms.ToolStripMenuItem tsmiRecordReplaceClear;
        private System.Windows.Forms.ToolStripMenuItem tsmiRecordReplaceAll;
        private System.Windows.Forms.ToolStripMenuItem tsmiRecordReplaceInvert;
        private System.Windows.Forms.ToolStripMenuItem tsmiBreak;
    }
}

