namespace AT_Command_Script_Processor
{
    partial class frmATScriptProcessor
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
        this.cmbSerial = new System.Windows.Forms.ComboBox();
        this.btnOpenFile = new System.Windows.Forms.Button();
        this.txtResult = new System.Windows.Forms.TextBox();
        this.ofdScriptFile = new System.Windows.Forms.OpenFileDialog();
        this.statusStrip1 = new System.Windows.Forms.StatusStrip();
        this.tssMainStatusBar = new System.Windows.Forms.ToolStripStatusLabel();
        this.tssStatusScrFile = new System.Windows.Forms.ToolStripStatusLabel();
        this.btnRun = new System.Windows.Forms.Button();
        this.btnCopyToClipBoard = new System.Windows.Forms.Button();
        this.cmbBaud = new System.Windows.Forms.ComboBox();
        this.chkShowEndHex = new System.Windows.Forms.CheckBox();
        this.label1 = new System.Windows.Forms.Label();
        this.groupBox1 = new System.Windows.Forms.GroupBox();
        this.groupBox2 = new System.Windows.Forms.GroupBox();
        this.numRXBuffSize = new System.Windows.Forms.NumericUpDown();
        this.label5 = new System.Windows.Forms.Label();
        this.cmbHandShaking = new System.Windows.Forms.ComboBox();
        this.label4 = new System.Windows.Forms.Label();
        this.label3 = new System.Windows.Forms.Label();
        this.label2 = new System.Windows.Forms.Label();
        this.chkBinMode = new System.Windows.Forms.CheckBox();
        this.statusStrip1.SuspendLayout();
        this.groupBox1.SuspendLayout();
        this.groupBox2.SuspendLayout();
        ((System.ComponentModel.ISupportInitialize)(this.numRXBuffSize)).BeginInit();
        this.SuspendLayout();
        // 
        // cmbSerial
        // 
        this.cmbSerial.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
        this.cmbSerial.FormattingEnabled = true;
        this.cmbSerial.Location = new System.Drawing.Point(87, 19);
        this.cmbSerial.Name = "cmbSerial";
        this.cmbSerial.Size = new System.Drawing.Size(101, 21);
        this.cmbSerial.TabIndex = 0;
        // 
        // btnOpenFile
        // 
        this.btnOpenFile.Location = new System.Drawing.Point(6, 10);
        this.btnOpenFile.Name = "btnOpenFile";
        this.btnOpenFile.Size = new System.Drawing.Size(93, 44);
        this.btnOpenFile.TabIndex = 1;
        this.btnOpenFile.Text = "Open AT Script File";
        this.btnOpenFile.UseVisualStyleBackColor = true;
        this.btnOpenFile.Click += new System.EventHandler(this.btnOpenFile_Click);
        // 
        // txtResult
        // 
        this.txtResult.Location = new System.Drawing.Point(215, 12);
        this.txtResult.Multiline = true;
        this.txtResult.Name = "txtResult";
        this.txtResult.ReadOnly = true;
        this.txtResult.ScrollBars = System.Windows.Forms.ScrollBars.Both;
        this.txtResult.Size = new System.Drawing.Size(571, 252);
        this.txtResult.TabIndex = 3;
        this.txtResult.WordWrap = false;
        // 
        // ofdScriptFile
        // 
        this.ofdScriptFile.Filter = "AT Script File|*.atscr";
        this.ofdScriptFile.Title = "Open Script File";
        // 
        // statusStrip1
        // 
        this.statusStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.tssMainStatusBar,
            this.tssStatusScrFile});
        this.statusStrip1.Location = new System.Drawing.Point(0, 273);
        this.statusStrip1.Name = "statusStrip1";
        this.statusStrip1.Size = new System.Drawing.Size(798, 22);
        this.statusStrip1.TabIndex = 4;
        this.statusStrip1.Text = "statusStrip1";
        // 
        // tssMainStatusBar
        // 
        this.tssMainStatusBar.Name = "tssMainStatusBar";
        this.tssMainStatusBar.Size = new System.Drawing.Size(163, 17);
        this.tssMainStatusBar.Text = "Welcome to AT Script Processor!";
        // 
        // tssStatusScrFile
        // 
        this.tssStatusScrFile.BorderSides = System.Windows.Forms.ToolStripStatusLabelBorderSides.Left;
        this.tssStatusScrFile.Name = "tssStatusScrFile";
        this.tssStatusScrFile.Size = new System.Drawing.Size(113, 17);
        this.tssStatusScrFile.Text = "toolStripStatusLabel1";
        // 
        // btnRun
        // 
        this.btnRun.BackColor = System.Drawing.Color.Lime;
        this.btnRun.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
        this.btnRun.Location = new System.Drawing.Point(105, 11);
        this.btnRun.Name = "btnRun";
        this.btnRun.Size = new System.Drawing.Size(86, 43);
        this.btnRun.TabIndex = 5;
        this.btnRun.Text = "Run Script File!";
        this.btnRun.UseVisualStyleBackColor = false;
        this.btnRun.Click += new System.EventHandler(this.btnRun_Click);
        // 
        // btnCopyToClipBoard
        // 
        this.btnCopyToClipBoard.Location = new System.Drawing.Point(6, 59);
        this.btnCopyToClipBoard.Name = "btnCopyToClipBoard";
        this.btnCopyToClipBoard.Size = new System.Drawing.Size(93, 38);
        this.btnCopyToClipBoard.TabIndex = 6;
        this.btnCopyToClipBoard.Text = "Copy Result to ClipBoard";
        this.btnCopyToClipBoard.UseVisualStyleBackColor = true;
        this.btnCopyToClipBoard.Click += new System.EventHandler(this.btnCopyToClipBoard_Click);
        // 
        // cmbBaud
        // 
        this.cmbBaud.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
        this.cmbBaud.FormattingEnabled = true;
        this.cmbBaud.Location = new System.Drawing.Point(87, 46);
        this.cmbBaud.Name = "cmbBaud";
        this.cmbBaud.Size = new System.Drawing.Size(101, 21);
        this.cmbBaud.TabIndex = 7;
        // 
        // chkShowEndHex
        // 
        this.chkShowEndHex.AutoSize = true;
        this.chkShowEndHex.Location = new System.Drawing.Point(105, 59);
        this.chkShowEndHex.Name = "chkShowEndHex";
        this.chkShowEndHex.Size = new System.Drawing.Size(86, 30);
        this.chkShowEndHex.TabIndex = 8;
        this.chkShowEndHex.Text = "Show ASCII \r\nHex";
        this.chkShowEndHex.UseVisualStyleBackColor = true;
        // 
        // label1
        // 
        this.label1.AutoSize = true;
        this.label1.Location = new System.Drawing.Point(785, 260);
        this.label1.Name = "label1";
        this.label1.Size = new System.Drawing.Size(13, 13);
        this.label1.TabIndex = 9;
        this.label1.Text = "7";
        // 
        // groupBox1
        // 
        this.groupBox1.Controls.Add(this.chkBinMode);
        this.groupBox1.Controls.Add(this.btnOpenFile);
        this.groupBox1.Controls.Add(this.btnRun);
        this.groupBox1.Controls.Add(this.chkShowEndHex);
        this.groupBox1.Controls.Add(this.btnCopyToClipBoard);
        this.groupBox1.Location = new System.Drawing.Point(12, 153);
        this.groupBox1.Name = "groupBox1";
        this.groupBox1.Size = new System.Drawing.Size(197, 111);
        this.groupBox1.TabIndex = 10;
        this.groupBox1.TabStop = false;
        // 
        // groupBox2
        // 
        this.groupBox2.Controls.Add(this.numRXBuffSize);
        this.groupBox2.Controls.Add(this.label5);
        this.groupBox2.Controls.Add(this.cmbHandShaking);
        this.groupBox2.Controls.Add(this.label4);
        this.groupBox2.Controls.Add(this.label3);
        this.groupBox2.Controls.Add(this.label2);
        this.groupBox2.Controls.Add(this.cmbSerial);
        this.groupBox2.Controls.Add(this.cmbBaud);
        this.groupBox2.Location = new System.Drawing.Point(12, 12);
        this.groupBox2.Name = "groupBox2";
        this.groupBox2.Size = new System.Drawing.Size(197, 135);
        this.groupBox2.TabIndex = 11;
        this.groupBox2.TabStop = false;
        this.groupBox2.Text = "COM Settings";
        // 
        // numRXBuffSize
        // 
        this.numRXBuffSize.Location = new System.Drawing.Point(87, 100);
        this.numRXBuffSize.Maximum = new decimal(new int[] {
            100000,
            0,
            0,
            0});
        this.numRXBuffSize.Minimum = new decimal(new int[] {
            500,
            0,
            0,
            0});
        this.numRXBuffSize.Name = "numRXBuffSize";
        this.numRXBuffSize.Size = new System.Drawing.Size(101, 20);
        this.numRXBuffSize.TabIndex = 13;
        this.numRXBuffSize.Value = new decimal(new int[] {
            1000,
            0,
            0,
            0});
        // 
        // label5
        // 
        this.label5.AutoSize = true;
        this.label5.Location = new System.Drawing.Point(6, 100);
        this.label5.Name = "label5";
        this.label5.Size = new System.Drawing.Size(78, 26);
        this.label5.TabIndex = 12;
        this.label5.Text = "Receive Buffer\r\nSize";
        // 
        // cmbHandShaking
        // 
        this.cmbHandShaking.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
        this.cmbHandShaking.FormattingEnabled = true;
        this.cmbHandShaking.Location = new System.Drawing.Point(87, 73);
        this.cmbHandShaking.Name = "cmbHandShaking";
        this.cmbHandShaking.Size = new System.Drawing.Size(101, 21);
        this.cmbHandShaking.TabIndex = 11;
        // 
        // label4
        // 
        this.label4.AutoSize = true;
        this.label4.Location = new System.Drawing.Point(8, 76);
        this.label4.Name = "label4";
        this.label4.Size = new System.Drawing.Size(73, 13);
        this.label4.TabIndex = 10;
        this.label4.Text = "Handshaking:";
        // 
        // label3
        // 
        this.label3.AutoSize = true;
        this.label3.Location = new System.Drawing.Point(23, 49);
        this.label3.Name = "label3";
        this.label3.Size = new System.Drawing.Size(58, 13);
        this.label3.TabIndex = 9;
        this.label3.Text = "BaudRate:";
        // 
        // label2
        // 
        this.label2.AutoSize = true;
        this.label2.Location = new System.Drawing.Point(37, 22);
        this.label2.Name = "label2";
        this.label2.Size = new System.Drawing.Size(44, 13);
        this.label2.TabIndex = 8;
        this.label2.Text = "COM #:";
        // 
        // chkBinMode
        // 
        this.chkBinMode.AutoSize = true;
        this.chkBinMode.Location = new System.Drawing.Point(105, 88);
        this.chkBinMode.Name = "chkBinMode";
        this.chkBinMode.Size = new System.Drawing.Size(85, 17);
        this.chkBinMode.TabIndex = 9;
        this.chkBinMode.Text = "Binary Mode";
        this.chkBinMode.UseVisualStyleBackColor = true;
        // 
        // frmATScriptProcessor
        // 
        this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
        this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
        this.ClientSize = new System.Drawing.Size(798, 295);
        this.Controls.Add(this.groupBox2);
        this.Controls.Add(this.groupBox1);
        this.Controls.Add(this.label1);
        this.Controls.Add(this.statusStrip1);
        this.Controls.Add(this.txtResult);
        this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
        this.MaximizeBox = false;
        this.Name = "frmATScriptProcessor";
        this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
        this.Text = "Form1";
        this.Load += new System.EventHandler(this.frmATScriptProcessor_Load);
        this.statusStrip1.ResumeLayout(false);
        this.statusStrip1.PerformLayout();
        this.groupBox1.ResumeLayout(false);
        this.groupBox1.PerformLayout();
        this.groupBox2.ResumeLayout(false);
        this.groupBox2.PerformLayout();
        ((System.ComponentModel.ISupportInitialize)(this.numRXBuffSize)).EndInit();
        this.ResumeLayout(false);
        this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ComboBox cmbSerial;
        private System.Windows.Forms.Button btnOpenFile;
        private System.Windows.Forms.TextBox txtResult;
        private System.Windows.Forms.OpenFileDialog ofdScriptFile;
        private System.Windows.Forms.StatusStrip statusStrip1;
        private System.Windows.Forms.ToolStripStatusLabel tssMainStatusBar;
        private System.Windows.Forms.ToolStripStatusLabel tssStatusScrFile;
        private System.Windows.Forms.Button btnRun;
        private System.Windows.Forms.Button btnCopyToClipBoard;
        private System.Windows.Forms.ComboBox cmbBaud;
        private System.Windows.Forms.CheckBox chkShowEndHex;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.ComboBox cmbHandShaking;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.NumericUpDown numRXBuffSize;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.CheckBox chkBinMode;
    }
}

