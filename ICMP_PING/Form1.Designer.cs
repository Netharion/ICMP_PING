namespace ICMP_PING
{
    partial class Form1
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
            this.connectButton = new System.Windows.Forms.Button();
            this.domainTextBox = new System.Windows.Forms.TextBox();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.canceAsyncPingButton = new System.Windows.Forms.Button();
            this.batchPingGroupBox = new System.Windows.Forms.GroupBox();
            this.batchPingLabel = new System.Windows.Forms.Label();
            this.batchButton = new System.Windows.Forms.Button();
            this.numOfDomainsTxtBox = new System.Windows.Forms.TextBox();
            this.singlePingGroupBox = new System.Windows.Forms.GroupBox();
            this.singleDomainLabel = new System.Windows.Forms.Label();
            this.dataViewList = new System.Windows.Forms.ListView();
            this.domainHeader = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.resolvedIP = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.pingHeader = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.ttlHeader = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.fragmentHeader = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.bufferlengthHeader = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.batchProgressBar = new System.Windows.Forms.ProgressBar();
            this.tabControl1 = new System.Windows.Forms.TabControl();
            this.tabPage1 = new System.Windows.Forms.TabPage();
            this.tabPage2 = new System.Windows.Forms.TabPage();
            this.button1 = new System.Windows.Forms.Button();
            this.lanDataViewList = new System.Windows.Forms.ListView();
            this.columnHeader1 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader2 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader3 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader4 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.lanStartScan = new System.Windows.Forms.Button();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.FROMiptextbox1 = new System.Windows.Forms.TextBox();
            this.FROMiptextbox2 = new System.Windows.Forms.TextBox();
            this.FROMiptextbox3 = new System.Windows.Forms.TextBox();
            this.FROMiptextbox4 = new System.Windows.Forms.TextBox();
            this.groupBox3 = new System.Windows.Forms.GroupBox();
            this.TOiptextbox4 = new System.Windows.Forms.TextBox();
            this.TOiptextbox1 = new System.Windows.Forms.TextBox();
            this.TOiptextbox3 = new System.Windows.Forms.TextBox();
            this.TOiptextbox2 = new System.Windows.Forms.TextBox();
            this.groupBox1.SuspendLayout();
            this.batchPingGroupBox.SuspendLayout();
            this.singlePingGroupBox.SuspendLayout();
            this.tabControl1.SuspendLayout();
            this.tabPage1.SuspendLayout();
            this.tabPage2.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.groupBox3.SuspendLayout();
            this.SuspendLayout();
            // 
            // connectButton
            // 
            this.connectButton.Location = new System.Drawing.Point(36, 64);
            this.connectButton.Name = "connectButton";
            this.connectButton.Size = new System.Drawing.Size(75, 23);
            this.connectButton.TabIndex = 0;
            this.connectButton.Text = "Single Ping";
            this.connectButton.UseVisualStyleBackColor = true;
            this.connectButton.Click += new System.EventHandler(this.connectButton_Click);
            // 
            // domainTextBox
            // 
            this.domainTextBox.Location = new System.Drawing.Point(6, 38);
            this.domainTextBox.Name = "domainTextBox";
            this.domainTextBox.Size = new System.Drawing.Size(157, 20);
            this.domainTextBox.TabIndex = 1;
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.canceAsyncPingButton);
            this.groupBox1.Controls.Add(this.batchPingGroupBox);
            this.groupBox1.Controls.Add(this.singlePingGroupBox);
            this.groupBox1.Location = new System.Drawing.Point(3, 3);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(181, 434);
            this.groupBox1.TabIndex = 2;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Ping ";
            // 
            // canceAsyncPingButton
            // 
            this.canceAsyncPingButton.Location = new System.Drawing.Point(55, 294);
            this.canceAsyncPingButton.Name = "canceAsyncPingButton";
            this.canceAsyncPingButton.Size = new System.Drawing.Size(75, 23);
            this.canceAsyncPingButton.TabIndex = 8;
            this.canceAsyncPingButton.Text = "Cancel Ping";
            this.canceAsyncPingButton.UseVisualStyleBackColor = true;
            this.canceAsyncPingButton.Click += new System.EventHandler(this.canceAsyncPingButton_Click);
            // 
            // batchPingGroupBox
            // 
            this.batchPingGroupBox.Controls.Add(this.batchPingLabel);
            this.batchPingGroupBox.Controls.Add(this.batchButton);
            this.batchPingGroupBox.Controls.Add(this.numOfDomainsTxtBox);
            this.batchPingGroupBox.Location = new System.Drawing.Point(7, 126);
            this.batchPingGroupBox.Name = "batchPingGroupBox";
            this.batchPingGroupBox.Size = new System.Drawing.Size(162, 126);
            this.batchPingGroupBox.TabIndex = 7;
            this.batchPingGroupBox.TabStop = false;
            // 
            // batchPingLabel
            // 
            this.batchPingLabel.Location = new System.Drawing.Point(6, 16);
            this.batchPingLabel.Name = "batchPingLabel";
            this.batchPingLabel.Size = new System.Drawing.Size(135, 39);
            this.batchPingLabel.TabIndex = 5;
            this.batchPingLabel.Text = "How many domains would you like to ping in batch:";
            // 
            // batchButton
            // 
            this.batchButton.Location = new System.Drawing.Point(35, 84);
            this.batchButton.Name = "batchButton";
            this.batchButton.Size = new System.Drawing.Size(75, 23);
            this.batchButton.TabIndex = 4;
            this.batchButton.Text = "Batch Ping";
            this.batchButton.UseVisualStyleBackColor = true;
            this.batchButton.Click += new System.EventHandler(this.batchButton_Click);
            // 
            // numOfDomainsTxtBox
            // 
            this.numOfDomainsTxtBox.Location = new System.Drawing.Point(9, 58);
            this.numOfDomainsTxtBox.Name = "numOfDomainsTxtBox";
            this.numOfDomainsTxtBox.Size = new System.Drawing.Size(147, 20);
            this.numOfDomainsTxtBox.TabIndex = 4;
            // 
            // singlePingGroupBox
            // 
            this.singlePingGroupBox.Controls.Add(this.singleDomainLabel);
            this.singlePingGroupBox.Controls.Add(this.domainTextBox);
            this.singlePingGroupBox.Controls.Add(this.connectButton);
            this.singlePingGroupBox.Location = new System.Drawing.Point(6, 19);
            this.singlePingGroupBox.Name = "singlePingGroupBox";
            this.singlePingGroupBox.Size = new System.Drawing.Size(169, 100);
            this.singlePingGroupBox.TabIndex = 6;
            this.singlePingGroupBox.TabStop = false;
            // 
            // singleDomainLabel
            // 
            this.singleDomainLabel.AutoSize = true;
            this.singleDomainLabel.Location = new System.Drawing.Point(7, 16);
            this.singleDomainLabel.Name = "singleDomainLabel";
            this.singleDomainLabel.Size = new System.Drawing.Size(118, 13);
            this.singleDomainLabel.TabIndex = 2;
            this.singleDomainLabel.Text = "Enter a Domain to ping:";
            // 
            // dataViewList
            // 
            this.dataViewList.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.domainHeader,
            this.resolvedIP,
            this.pingHeader,
            this.ttlHeader,
            this.fragmentHeader,
            this.bufferlengthHeader});
            this.dataViewList.Location = new System.Drawing.Point(190, 3);
            this.dataViewList.Name = "dataViewList";
            this.dataViewList.Size = new System.Drawing.Size(595, 405);
            this.dataViewList.TabIndex = 3;
            this.dataViewList.UseCompatibleStateImageBehavior = false;
            this.dataViewList.View = System.Windows.Forms.View.Details;
            // 
            // domainHeader
            // 
            this.domainHeader.Tag = "Domain";
            this.domainHeader.Text = "Domain";
            this.domainHeader.Width = 152;
            // 
            // resolvedIP
            // 
            this.resolvedIP.Text = "Resolved IP:";
            this.resolvedIP.Width = 101;
            // 
            // pingHeader
            // 
            this.pingHeader.Text = "Ping";
            this.pingHeader.Width = 50;
            // 
            // ttlHeader
            // 
            this.ttlHeader.Text = "TTL";
            // 
            // fragmentHeader
            // 
            this.fragmentHeader.DisplayIndex = 5;
            this.fragmentHeader.Text = "Dont Fragment?";
            this.fragmentHeader.Width = 93;
            // 
            // bufferlengthHeader
            // 
            this.bufferlengthHeader.DisplayIndex = 4;
            this.bufferlengthHeader.Text = "Buffer Length";
            this.bufferlengthHeader.Width = 79;
            // 
            // batchProgressBar
            // 
            this.batchProgressBar.Location = new System.Drawing.Point(190, 414);
            this.batchProgressBar.Name = "batchProgressBar";
            this.batchProgressBar.Size = new System.Drawing.Size(595, 23);
            this.batchProgressBar.TabIndex = 5;
            // 
            // tabControl1
            // 
            this.tabControl1.Controls.Add(this.tabPage1);
            this.tabControl1.Controls.Add(this.tabPage2);
            this.tabControl1.Location = new System.Drawing.Point(3, 3);
            this.tabControl1.Name = "tabControl1";
            this.tabControl1.SelectedIndex = 0;
            this.tabControl1.Size = new System.Drawing.Size(799, 470);
            this.tabControl1.TabIndex = 6;
            // 
            // tabPage1
            // 
            this.tabPage1.Controls.Add(this.groupBox1);
            this.tabPage1.Controls.Add(this.batchProgressBar);
            this.tabPage1.Controls.Add(this.dataViewList);
            this.tabPage1.Location = new System.Drawing.Point(4, 22);
            this.tabPage1.Name = "tabPage1";
            this.tabPage1.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage1.Size = new System.Drawing.Size(791, 444);
            this.tabPage1.TabIndex = 0;
            this.tabPage1.Text = "Batch Ping";
            this.tabPage1.UseVisualStyleBackColor = true;
            this.tabPage1.Click += new System.EventHandler(this.tabPage1_Click);
            // 
            // tabPage2
            // 
            this.tabPage2.Controls.Add(this.groupBox3);
            this.tabPage2.Controls.Add(this.groupBox2);
            this.tabPage2.Controls.Add(this.lanStartScan);
            this.tabPage2.Controls.Add(this.lanDataViewList);
            this.tabPage2.Controls.Add(this.button1);
            this.tabPage2.Location = new System.Drawing.Point(4, 22);
            this.tabPage2.Name = "tabPage2";
            this.tabPage2.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage2.Size = new System.Drawing.Size(791, 444);
            this.tabPage2.TabIndex = 1;
            this.tabPage2.Text = "LAN Scanner";
            this.tabPage2.UseVisualStyleBackColor = true;
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(574, 24);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(75, 23);
            this.button1.TabIndex = 0;
            this.button1.Text = "button1";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // lanDataViewList
            // 
            this.lanDataViewList.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.columnHeader1,
            this.columnHeader2,
            this.columnHeader3,
            this.columnHeader4});
            this.lanDataViewList.Location = new System.Drawing.Point(95, 124);
            this.lanDataViewList.Name = "lanDataViewList";
            this.lanDataViewList.Size = new System.Drawing.Size(660, 304);
            this.lanDataViewList.TabIndex = 4;
            this.lanDataViewList.UseCompatibleStateImageBehavior = false;
            this.lanDataViewList.View = System.Windows.Forms.View.Details;
            // 
            // columnHeader1
            // 
            this.columnHeader1.Tag = "Domain";
            this.columnHeader1.Text = "IP Address";
            this.columnHeader1.Width = 67;
            // 
            // columnHeader2
            // 
            this.columnHeader2.Text = "MAC Address";
            this.columnHeader2.Width = 102;
            // 
            // columnHeader3
            // 
            this.columnHeader3.Text = "Response Time";
            this.columnHeader3.Width = 104;
            // 
            // columnHeader4
            // 
            this.columnHeader4.Text = "Host Name";
            this.columnHeader4.Width = 161;
            // 
            // lanStartScan
            // 
            this.lanStartScan.Location = new System.Drawing.Point(451, 24);
            this.lanStartScan.Name = "lanStartScan";
            this.lanStartScan.Size = new System.Drawing.Size(75, 23);
            this.lanStartScan.TabIndex = 5;
            this.lanStartScan.Text = "Start Scanning";
            this.lanStartScan.UseVisualStyleBackColor = true;
            this.lanStartScan.Click += new System.EventHandler(this.lanStartScan_Click);
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.FROMiptextbox4);
            this.groupBox2.Controls.Add(this.FROMiptextbox1);
            this.groupBox2.Controls.Add(this.FROMiptextbox3);
            this.groupBox2.Controls.Add(this.FROMiptextbox2);
            this.groupBox2.Location = new System.Drawing.Point(105, 70);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(137, 48);
            this.groupBox2.TabIndex = 8;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "From";
            // 
            // FROMiptextbox1
            // 
            this.FROMiptextbox1.Location = new System.Drawing.Point(6, 22);
            this.FROMiptextbox1.Name = "FROMiptextbox1";
            this.FROMiptextbox1.Size = new System.Drawing.Size(26, 20);
            this.FROMiptextbox1.TabIndex = 9;
            // 
            // FROMiptextbox2
            // 
            this.FROMiptextbox2.Location = new System.Drawing.Point(38, 22);
            this.FROMiptextbox2.Name = "FROMiptextbox2";
            this.FROMiptextbox2.Size = new System.Drawing.Size(26, 20);
            this.FROMiptextbox2.TabIndex = 10;
            // 
            // FROMiptextbox3
            // 
            this.FROMiptextbox3.Location = new System.Drawing.Point(70, 22);
            this.FROMiptextbox3.Name = "FROMiptextbox3";
            this.FROMiptextbox3.Size = new System.Drawing.Size(26, 20);
            this.FROMiptextbox3.TabIndex = 11;
            // 
            // FROMiptextbox4
            // 
            this.FROMiptextbox4.Location = new System.Drawing.Point(102, 22);
            this.FROMiptextbox4.Name = "FROMiptextbox4";
            this.FROMiptextbox4.Size = new System.Drawing.Size(26, 20);
            this.FROMiptextbox4.TabIndex = 12;
            // 
            // groupBox3
            // 
            this.groupBox3.Controls.Add(this.TOiptextbox4);
            this.groupBox3.Controls.Add(this.TOiptextbox1);
            this.groupBox3.Controls.Add(this.TOiptextbox3);
            this.groupBox3.Controls.Add(this.TOiptextbox2);
            this.groupBox3.Location = new System.Drawing.Point(248, 70);
            this.groupBox3.Name = "groupBox3";
            this.groupBox3.Size = new System.Drawing.Size(137, 48);
            this.groupBox3.TabIndex = 13;
            this.groupBox3.TabStop = false;
            this.groupBox3.Text = "To";
            // 
            // TOiptextbox4
            // 
            this.TOiptextbox4.Location = new System.Drawing.Point(102, 22);
            this.TOiptextbox4.Name = "TOiptextbox4";
            this.TOiptextbox4.Size = new System.Drawing.Size(26, 20);
            this.TOiptextbox4.TabIndex = 12;
            // 
            // TOiptextbox1
            // 
            this.TOiptextbox1.Location = new System.Drawing.Point(6, 22);
            this.TOiptextbox1.Name = "TOiptextbox1";
            this.TOiptextbox1.Size = new System.Drawing.Size(26, 20);
            this.TOiptextbox1.TabIndex = 9;
            // 
            // TOiptextbox3
            // 
            this.TOiptextbox3.Location = new System.Drawing.Point(70, 22);
            this.TOiptextbox3.Name = "TOiptextbox3";
            this.TOiptextbox3.Size = new System.Drawing.Size(26, 20);
            this.TOiptextbox3.TabIndex = 11;
            // 
            // TOiptextbox2
            // 
            this.TOiptextbox2.Location = new System.Drawing.Point(38, 22);
            this.TOiptextbox2.Name = "TOiptextbox2";
            this.TOiptextbox2.Size = new System.Drawing.Size(26, 20);
            this.TOiptextbox2.TabIndex = 10;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(808, 475);
            this.Controls.Add(this.tabControl1);
            this.Name = "Form1";
            this.Text = "Form1";
            this.groupBox1.ResumeLayout(false);
            this.batchPingGroupBox.ResumeLayout(false);
            this.batchPingGroupBox.PerformLayout();
            this.singlePingGroupBox.ResumeLayout(false);
            this.singlePingGroupBox.PerformLayout();
            this.tabControl1.ResumeLayout(false);
            this.tabPage1.ResumeLayout(false);
            this.tabPage2.ResumeLayout(false);
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            this.groupBox3.ResumeLayout(false);
            this.groupBox3.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button connectButton;
        private System.Windows.Forms.TextBox domainTextBox;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.ListView dataViewList;
        private System.Windows.Forms.ColumnHeader domainHeader;
        private System.Windows.Forms.ColumnHeader resolvedIP;
        private System.Windows.Forms.ColumnHeader pingHeader;
        private System.Windows.Forms.ColumnHeader ttlHeader;
        private System.Windows.Forms.ColumnHeader fragmentHeader;
        private System.Windows.Forms.ColumnHeader bufferlengthHeader;
        private System.Windows.Forms.Button batchButton;
        private System.Windows.Forms.TextBox numOfDomainsTxtBox;
        private System.Windows.Forms.ProgressBar batchProgressBar;
        private System.Windows.Forms.GroupBox batchPingGroupBox;
        private System.Windows.Forms.Label batchPingLabel;
        private System.Windows.Forms.GroupBox singlePingGroupBox;
        private System.Windows.Forms.Label singleDomainLabel;
        private System.Windows.Forms.Button canceAsyncPingButton;
        private System.Windows.Forms.TabControl tabControl1;
        private System.Windows.Forms.TabPage tabPage1;
        private System.Windows.Forms.TabPage tabPage2;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.ListView lanDataViewList;
        private System.Windows.Forms.ColumnHeader columnHeader1;
        private System.Windows.Forms.ColumnHeader columnHeader2;
        private System.Windows.Forms.ColumnHeader columnHeader3;
        private System.Windows.Forms.ColumnHeader columnHeader4;
        private System.Windows.Forms.Button lanStartScan;
        private System.Windows.Forms.TextBox FROMiptextbox1;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.TextBox FROMiptextbox4;
        private System.Windows.Forms.TextBox FROMiptextbox3;
        private System.Windows.Forms.TextBox FROMiptextbox2;
        private System.Windows.Forms.GroupBox groupBox3;
        private System.Windows.Forms.TextBox TOiptextbox4;
        private System.Windows.Forms.TextBox TOiptextbox1;
        private System.Windows.Forms.TextBox TOiptextbox3;
        private System.Windows.Forms.TextBox TOiptextbox2;
    }
}

