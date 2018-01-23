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
            this.groupBox1.SuspendLayout();
            this.batchPingGroupBox.SuspendLayout();
            this.singlePingGroupBox.SuspendLayout();
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
            this.groupBox1.Location = new System.Drawing.Point(13, 13);
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
            this.dataViewList.Location = new System.Drawing.Point(200, 13);
            this.dataViewList.Name = "dataViewList";
            this.dataViewList.Size = new System.Drawing.Size(561, 405);
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
            this.batchProgressBar.Location = new System.Drawing.Point(200, 424);
            this.batchProgressBar.Name = "batchProgressBar";
            this.batchProgressBar.Size = new System.Drawing.Size(555, 23);
            this.batchProgressBar.TabIndex = 5;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(773, 454);
            this.Controls.Add(this.batchProgressBar);
            this.Controls.Add(this.dataViewList);
            this.Controls.Add(this.groupBox1);
            this.Name = "Form1";
            this.Text = "Form1";
            this.groupBox1.ResumeLayout(false);
            this.batchPingGroupBox.ResumeLayout(false);
            this.batchPingGroupBox.PerformLayout();
            this.singlePingGroupBox.ResumeLayout(false);
            this.singlePingGroupBox.PerformLayout();
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
    }
}

