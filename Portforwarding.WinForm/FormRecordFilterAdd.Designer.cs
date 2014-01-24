namespace Portforwarding.WinForm
{
    partial class FormRecordFilterAdd
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.cbbSource = new System.Windows.Forms.ComboBox();
            this.cbbDestination = new System.Windows.Forms.ComboBox();
            this.txtContent = new System.Windows.Forms.TextBox();
            this.lblSource = new System.Windows.Forms.Label();
            this.lblDestination = new System.Windows.Forms.Label();
            this.btnOk = new System.Windows.Forms.Button();
            this.nudSplitLength = new System.Windows.Forms.NumericUpDown();
            this.lblSplitLength = new System.Windows.Forms.Label();
            this.lblSplitSymbol = new System.Windows.Forms.Label();
            this.txtSplitSymbol = new System.Windows.Forms.TextBox();
            this.cbSplit = new System.Windows.Forms.CheckBox();
            this.radEndodingBase64 = new System.Windows.Forms.RadioButton();
            this.radEndodingUnicode = new System.Windows.Forms.RadioButton();
            this.radEndodingUTF8 = new System.Windows.Forms.RadioButton();
            this.radEndodingASCII = new System.Windows.Forms.RadioButton();
            this.radEndodingHex = new System.Windows.Forms.RadioButton();
            this.radEndodingDec = new System.Windows.Forms.RadioButton();
            this.radEndodingOtc = new System.Windows.Forms.RadioButton();
            this.radEndodingBin = new System.Windows.Forms.RadioButton();
            this.lblContent = new System.Windows.Forms.Label();
            this.lblEncoding = new System.Windows.Forms.Label();
            this.radNotInclude = new System.Windows.Forms.RadioButton();
            this.radInclude = new System.Windows.Forms.RadioButton();
            this.radNone = new System.Windows.Forms.RadioButton();
            this.cbbMethod = new System.Windows.Forms.ComboBox();
            this.lblMethod = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.nudSplitLength)).BeginInit();
            this.SuspendLayout();
            // 
            // cbbSource
            // 
            this.cbbSource.FormattingEnabled = true;
            this.cbbSource.Location = new System.Drawing.Point(62, 15);
            this.cbbSource.Name = "cbbSource";
            this.cbbSource.Size = new System.Drawing.Size(115, 20);
            this.cbbSource.TabIndex = 0;
            // 
            // cbbDestination
            // 
            this.cbbDestination.FormattingEnabled = true;
            this.cbbDestination.Location = new System.Drawing.Point(234, 15);
            this.cbbDestination.Name = "cbbDestination";
            this.cbbDestination.Size = new System.Drawing.Size(115, 20);
            this.cbbDestination.TabIndex = 1;
            // 
            // txtContent
            // 
            this.txtContent.Location = new System.Drawing.Point(25, 73);
            this.txtContent.Multiline = true;
            this.txtContent.Name = "txtContent";
            this.txtContent.Size = new System.Drawing.Size(812, 70);
            this.txtContent.TabIndex = 2;
            // 
            // lblSource
            // 
            this.lblSource.AutoSize = true;
            this.lblSource.Location = new System.Drawing.Point(25, 19);
            this.lblSource.Name = "lblSource";
            this.lblSource.Size = new System.Drawing.Size(29, 12);
            this.lblSource.TabIndex = 3;
            this.lblSource.Text = "源：";
            // 
            // lblDestination
            // 
            this.lblDestination.AutoSize = true;
            this.lblDestination.Location = new System.Drawing.Point(185, 19);
            this.lblDestination.Name = "lblDestination";
            this.lblDestination.Size = new System.Drawing.Size(41, 12);
            this.lblDestination.TabIndex = 4;
            this.lblDestination.Text = "目标：";
            // 
            // btnOk
            // 
            this.btnOk.Location = new System.Drawing.Point(762, 14);
            this.btnOk.Name = "btnOk";
            this.btnOk.Size = new System.Drawing.Size(75, 23);
            this.btnOk.TabIndex = 5;
            this.btnOk.Text = "添加";
            this.btnOk.UseVisualStyleBackColor = true;
            // 
            // nudSplitLength
            // 
            this.nudSplitLength.Enabled = false;
            this.nudSplitLength.Location = new System.Drawing.Point(686, 15);
            this.nudSplitLength.Maximum = new decimal(new int[] {
            9999,
            0,
            0,
            0});
            this.nudSplitLength.Name = "nudSplitLength";
            this.nudSplitLength.Size = new System.Drawing.Size(68, 21);
            this.nudSplitLength.TabIndex = 31;
            this.nudSplitLength.Value = new decimal(new int[] {
            8,
            0,
            0,
            0});
            // 
            // lblSplitLength
            // 
            this.lblSplitLength.AutoSize = true;
            this.lblSplitLength.Location = new System.Drawing.Point(637, 19);
            this.lblSplitLength.Name = "lblSplitLength";
            this.lblSplitLength.Size = new System.Drawing.Size(41, 12);
            this.lblSplitLength.TabIndex = 30;
            this.lblSplitLength.Text = "位数：";
            // 
            // lblSplitSymbol
            // 
            this.lblSplitSymbol.AutoSize = true;
            this.lblSplitSymbol.Location = new System.Drawing.Point(520, 19);
            this.lblSplitSymbol.Name = "lblSplitSymbol";
            this.lblSplitSymbol.Size = new System.Drawing.Size(41, 12);
            this.lblSplitSymbol.TabIndex = 29;
            this.lblSplitSymbol.Text = "符号：";
            // 
            // txtSplitSymbol
            // 
            this.txtSplitSymbol.Enabled = false;
            this.txtSplitSymbol.Location = new System.Drawing.Point(569, 15);
            this.txtSplitSymbol.Name = "txtSplitSymbol";
            this.txtSplitSymbol.Size = new System.Drawing.Size(60, 21);
            this.txtSplitSymbol.TabIndex = 28;
            this.txtSplitSymbol.Text = " ";
            // 
            // cbSplit
            // 
            this.cbSplit.AutoSize = true;
            this.cbSplit.Cursor = System.Windows.Forms.Cursors.Hand;
            this.cbSplit.Location = new System.Drawing.Point(464, 17);
            this.cbSplit.Name = "cbSplit";
            this.cbSplit.Size = new System.Drawing.Size(48, 16);
            this.cbSplit.TabIndex = 27;
            this.cbSplit.Text = "分隔";
            this.cbSplit.UseVisualStyleBackColor = true;
            // 
            // radEndodingBase64
            // 
            this.radEndodingBase64.AutoSize = true;
            this.radEndodingBase64.Cursor = System.Windows.Forms.Cursors.Hand;
            this.radEndodingBase64.Location = new System.Drawing.Point(769, 47);
            this.radEndodingBase64.Name = "radEndodingBase64";
            this.radEndodingBase64.Size = new System.Drawing.Size(59, 16);
            this.radEndodingBase64.TabIndex = 26;
            this.radEndodingBase64.Text = "Base64";
            this.radEndodingBase64.UseVisualStyleBackColor = true;
            // 
            // radEndodingUnicode
            // 
            this.radEndodingUnicode.AutoSize = true;
            this.radEndodingUnicode.Cursor = System.Windows.Forms.Cursors.Hand;
            this.radEndodingUnicode.Location = new System.Drawing.Point(688, 47);
            this.radEndodingUnicode.Name = "radEndodingUnicode";
            this.radEndodingUnicode.Size = new System.Drawing.Size(65, 16);
            this.radEndodingUnicode.TabIndex = 25;
            this.radEndodingUnicode.Text = "Unicode";
            this.radEndodingUnicode.UseVisualStyleBackColor = true;
            // 
            // radEndodingUTF8
            // 
            this.radEndodingUTF8.AutoSize = true;
            this.radEndodingUTF8.Cursor = System.Windows.Forms.Cursors.Hand;
            this.radEndodingUTF8.Location = new System.Drawing.Point(625, 47);
            this.radEndodingUTF8.Name = "radEndodingUTF8";
            this.radEndodingUTF8.Size = new System.Drawing.Size(47, 16);
            this.radEndodingUTF8.TabIndex = 24;
            this.radEndodingUTF8.Text = "UTF8";
            this.radEndodingUTF8.UseVisualStyleBackColor = true;
            // 
            // radEndodingASCII
            // 
            this.radEndodingASCII.AutoSize = true;
            this.radEndodingASCII.Checked = true;
            this.radEndodingASCII.Cursor = System.Windows.Forms.Cursors.Hand;
            this.radEndodingASCII.Location = new System.Drawing.Point(556, 47);
            this.radEndodingASCII.Name = "radEndodingASCII";
            this.radEndodingASCII.Size = new System.Drawing.Size(53, 16);
            this.radEndodingASCII.TabIndex = 23;
            this.radEndodingASCII.TabStop = true;
            this.radEndodingASCII.Text = "ASCII";
            this.radEndodingASCII.UseVisualStyleBackColor = true;
            // 
            // radEndodingHex
            // 
            this.radEndodingHex.AutoSize = true;
            this.radEndodingHex.Cursor = System.Windows.Forms.Cursors.Hand;
            this.radEndodingHex.Location = new System.Drawing.Point(499, 47);
            this.radEndodingHex.Name = "radEndodingHex";
            this.radEndodingHex.Size = new System.Drawing.Size(41, 16);
            this.radEndodingHex.TabIndex = 22;
            this.radEndodingHex.Text = "Hex";
            this.radEndodingHex.UseVisualStyleBackColor = true;
            // 
            // radEndodingDec
            // 
            this.radEndodingDec.AutoSize = true;
            this.radEndodingDec.Cursor = System.Windows.Forms.Cursors.Hand;
            this.radEndodingDec.Location = new System.Drawing.Point(442, 47);
            this.radEndodingDec.Name = "radEndodingDec";
            this.radEndodingDec.Size = new System.Drawing.Size(41, 16);
            this.radEndodingDec.TabIndex = 21;
            this.radEndodingDec.Text = "Dec";
            this.radEndodingDec.UseVisualStyleBackColor = true;
            // 
            // radEndodingOtc
            // 
            this.radEndodingOtc.AutoSize = true;
            this.radEndodingOtc.Cursor = System.Windows.Forms.Cursors.Hand;
            this.radEndodingOtc.Location = new System.Drawing.Point(385, 47);
            this.radEndodingOtc.Name = "radEndodingOtc";
            this.radEndodingOtc.Size = new System.Drawing.Size(41, 16);
            this.radEndodingOtc.TabIndex = 20;
            this.radEndodingOtc.Text = "Oct";
            this.radEndodingOtc.UseVisualStyleBackColor = true;
            // 
            // radEndodingBin
            // 
            this.radEndodingBin.AutoSize = true;
            this.radEndodingBin.Cursor = System.Windows.Forms.Cursors.Hand;
            this.radEndodingBin.Location = new System.Drawing.Point(328, 47);
            this.radEndodingBin.Name = "radEndodingBin";
            this.radEndodingBin.Size = new System.Drawing.Size(41, 16);
            this.radEndodingBin.TabIndex = 19;
            this.radEndodingBin.Text = "Bin";
            this.radEndodingBin.UseVisualStyleBackColor = true;
            // 
            // lblContent
            // 
            this.lblContent.AutoSize = true;
            this.lblContent.Location = new System.Drawing.Point(25, 49);
            this.lblContent.Name = "lblContent";
            this.lblContent.Size = new System.Drawing.Size(41, 12);
            this.lblContent.TabIndex = 32;
            this.lblContent.Text = "内容：";
            // 
            // lblEncoding
            // 
            this.lblEncoding.AutoSize = true;
            this.lblEncoding.Location = new System.Drawing.Point(271, 49);
            this.lblEncoding.Name = "lblEncoding";
            this.lblEncoding.Size = new System.Drawing.Size(41, 12);
            this.lblEncoding.TabIndex = 33;
            this.lblEncoding.Text = "编码：";
            // 
            // radNotInclude
            // 
            this.radNotInclude.AutoSize = true;
            this.radNotInclude.Cursor = System.Windows.Forms.Cursors.Hand;
            this.radNotInclude.Location = new System.Drawing.Point(196, 47);
            this.radNotInclude.Name = "radNotInclude";
            this.radNotInclude.Size = new System.Drawing.Size(59, 16);
            this.radNotInclude.TabIndex = 35;
            this.radNotInclude.Text = "不包含";
            this.radNotInclude.UseVisualStyleBackColor = true;
            // 
            // radInclude
            // 
            this.radInclude.AutoSize = true;
            this.radInclude.Cursor = System.Windows.Forms.Cursors.Hand;
            this.radInclude.Location = new System.Drawing.Point(133, 47);
            this.radInclude.Name = "radInclude";
            this.radInclude.Size = new System.Drawing.Size(47, 16);
            this.radInclude.TabIndex = 34;
            this.radInclude.Text = "包含";
            this.radInclude.UseVisualStyleBackColor = true;
            // 
            // radNone
            // 
            this.radNone.AutoSize = true;
            this.radNone.Cursor = System.Windows.Forms.Cursors.Hand;
            this.radNone.Location = new System.Drawing.Point(82, 47);
            this.radNone.Name = "radNone";
            this.radNone.Size = new System.Drawing.Size(35, 16);
            this.radNone.TabIndex = 36;
            this.radNone.Text = "无";
            this.radNone.UseVisualStyleBackColor = true;
            // 
            // cbbMethod
            // 
            this.cbbMethod.FormattingEnabled = true;
            this.cbbMethod.Location = new System.Drawing.Point(406, 15);
            this.cbbMethod.Name = "cbbMethod";
            this.cbbMethod.Size = new System.Drawing.Size(50, 20);
            this.cbbMethod.TabIndex = 37;
            // 
            // lblMethod
            // 
            this.lblMethod.AutoSize = true;
            this.lblMethod.Location = new System.Drawing.Point(357, 19);
            this.lblMethod.Name = "lblMethod";
            this.lblMethod.Size = new System.Drawing.Size(41, 12);
            this.lblMethod.TabIndex = 38;
            this.lblMethod.Text = "方式：";
            // 
            // FormRecordFilterAdd
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(854, 160);
            this.Controls.Add(this.lblMethod);
            this.Controls.Add(this.cbbMethod);
            this.Controls.Add(this.radNone);
            this.Controls.Add(this.radNotInclude);
            this.Controls.Add(this.radInclude);
            this.Controls.Add(this.lblEncoding);
            this.Controls.Add(this.lblContent);
            this.Controls.Add(this.nudSplitLength);
            this.Controls.Add(this.lblSplitLength);
            this.Controls.Add(this.lblSplitSymbol);
            this.Controls.Add(this.txtSplitSymbol);
            this.Controls.Add(this.cbSplit);
            this.Controls.Add(this.radEndodingBase64);
            this.Controls.Add(this.radEndodingUnicode);
            this.Controls.Add(this.radEndodingUTF8);
            this.Controls.Add(this.radEndodingASCII);
            this.Controls.Add(this.radEndodingHex);
            this.Controls.Add(this.radEndodingDec);
            this.Controls.Add(this.radEndodingOtc);
            this.Controls.Add(this.radEndodingBin);
            this.Controls.Add(this.btnOk);
            this.Controls.Add(this.lblDestination);
            this.Controls.Add(this.lblSource);
            this.Controls.Add(this.txtContent);
            this.Controls.Add(this.cbbDestination);
            this.Controls.Add(this.cbbSource);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow;
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "FormRecordFilterAdd";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "  过滤规则 - 添加";
            this.Load += new System.EventHandler(this.FormRecordFilterAdd_Load);
            ((System.ComponentModel.ISupportInitialize)(this.nudSplitLength)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ComboBox cbbSource;
        private System.Windows.Forms.ComboBox cbbDestination;
        private System.Windows.Forms.TextBox txtContent;
        private System.Windows.Forms.Label lblSource;
        private System.Windows.Forms.Label lblDestination;
        private System.Windows.Forms.Button btnOk;
        private System.Windows.Forms.NumericUpDown nudSplitLength;
        private System.Windows.Forms.Label lblSplitLength;
        private System.Windows.Forms.Label lblSplitSymbol;
        private System.Windows.Forms.TextBox txtSplitSymbol;
        private System.Windows.Forms.CheckBox cbSplit;
        private System.Windows.Forms.RadioButton radEndodingBase64;
        private System.Windows.Forms.RadioButton radEndodingUnicode;
        private System.Windows.Forms.RadioButton radEndodingUTF8;
        private System.Windows.Forms.RadioButton radEndodingASCII;
        private System.Windows.Forms.RadioButton radEndodingHex;
        private System.Windows.Forms.RadioButton radEndodingDec;
        private System.Windows.Forms.RadioButton radEndodingOtc;
        private System.Windows.Forms.RadioButton radEndodingBin;
        private System.Windows.Forms.Label lblContent;
        private System.Windows.Forms.Label lblEncoding;
        private System.Windows.Forms.RadioButton radNotInclude;
        private System.Windows.Forms.RadioButton radInclude;
        private System.Windows.Forms.RadioButton radNone;
        private System.Windows.Forms.ComboBox cbbMethod;
        private System.Windows.Forms.Label lblMethod;
    }
}