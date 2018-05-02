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
            this.tabControl1 = new System.Windows.Forms.TabControl();
            this.tabPage1 = new System.Windows.Forms.TabPage();
            this.tabPage2 = new System.Windows.Forms.TabPage();
            this.groupBox4 = new System.Windows.Forms.GroupBox();
            this.checkBox1 = new System.Windows.Forms.CheckBox();
            this.LanScannerIPV4Textbox = new System.Windows.Forms.Label();
            this.scan_button = new System.Windows.Forms.Button();
            this.groupBox3 = new System.Windows.Forms.GroupBox();
            this.TOiptextbox4 = new System.Windows.Forms.TextBox();
            this.TOiptextbox1 = new System.Windows.Forms.TextBox();
            this.TOiptextbox3 = new System.Windows.Forms.TextBox();
            this.TOiptextbox2 = new System.Windows.Forms.TextBox();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.FROMiptextbox4 = new System.Windows.Forms.TextBox();
            this.FROMiptextbox1 = new System.Windows.Forms.TextBox();
            this.FROMiptextbox3 = new System.Windows.Forms.TextBox();
            this.FROMiptextbox2 = new System.Windows.Forms.TextBox();
            this.lanStartScan = new System.Windows.Forms.Button();
            this.lanDataViewList = new System.Windows.Forms.ListView();
            this.columnHeader1 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader2 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader3 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader4 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.tabPage3 = new System.Windows.Forms.TabPage();
            this.groupBox6 = new System.Windows.Forms.GroupBox();
            this.groupBox8 = new System.Windows.Forms.GroupBox();
            this.comboBox1 = new System.Windows.Forms.ComboBox();
            this.groupBox7 = new System.Windows.Forms.GroupBox();
            this.button3 = new System.Windows.Forms.Button();
            this.button1 = new System.Windows.Forms.Button();
            this.groupBox5 = new System.Windows.Forms.GroupBox();
            this.traceroute_button = new System.Windows.Forms.Button();
            this.tracert_Textbox = new System.Windows.Forms.TextBox();
            this.gmapcontrol = new GMap.NET.WindowsForms.GMapControl();
            this.tabPage4 = new System.Windows.Forms.TabPage();
            this.statusStrip1 = new System.Windows.Forms.StatusStrip();
            this.toolStripStatusLabel1 = new System.Windows.Forms.ToolStripStatusLabel();
            this.toolStripStatusLabel2 = new System.Windows.Forms.ToolStripStatusLabel();
            this.toolStripStatusLabel3 = new System.Windows.Forms.ToolStripStatusLabel();
            this.toolStripStatusLabel4 = new System.Windows.Forms.ToolStripStatusLabel();
            this.batchProgressBar = new System.Windows.Forms.ToolStripProgressBar();
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.mToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripMenuItem2 = new System.Windows.Forms.ToolStripMenuItem();
            this.viewToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.actionsToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.optionsToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.helpToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.sourceLabel = new System.Windows.Forms.Label();
            this.source_combobox = new System.Windows.Forms.ComboBox();
            this.button2 = new System.Windows.Forms.Button();
            this.groupBox1.SuspendLayout();
            this.batchPingGroupBox.SuspendLayout();
            this.singlePingGroupBox.SuspendLayout();
            this.tabControl1.SuspendLayout();
            this.tabPage1.SuspendLayout();
            this.tabPage2.SuspendLayout();
            this.groupBox4.SuspendLayout();
            this.groupBox3.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.tabPage3.SuspendLayout();
            this.groupBox6.SuspendLayout();
            this.groupBox8.SuspendLayout();
            this.groupBox7.SuspendLayout();
            this.groupBox5.SuspendLayout();
            this.statusStrip1.SuspendLayout();
            this.menuStrip1.SuspendLayout();
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
            this.groupBox1.Controls.Add(this.batchPingGroupBox);
            this.groupBox1.Controls.Add(this.singlePingGroupBox);
            this.groupBox1.Location = new System.Drawing.Point(3, 3);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(181, 399);
            this.groupBox1.TabIndex = 2;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Ping ";
            // 
            // batchPingGroupBox
            // 
            this.batchPingGroupBox.Controls.Add(this.button2);
            this.batchPingGroupBox.Controls.Add(this.source_combobox);
            this.batchPingGroupBox.Controls.Add(this.sourceLabel);
            this.batchPingGroupBox.Controls.Add(this.batchPingLabel);
            this.batchPingGroupBox.Controls.Add(this.batchButton);
            this.batchPingGroupBox.Controls.Add(this.numOfDomainsTxtBox);
            this.batchPingGroupBox.Location = new System.Drawing.Point(7, 126);
            this.batchPingGroupBox.Name = "batchPingGroupBox";
            this.batchPingGroupBox.Size = new System.Drawing.Size(162, 220);
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
            this.batchButton.Location = new System.Drawing.Point(6, 113);
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
            this.dataViewList.Size = new System.Drawing.Size(595, 398);
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
            // tabControl1
            // 
            this.tabControl1.Controls.Add(this.tabPage1);
            this.tabControl1.Controls.Add(this.tabPage2);
            this.tabControl1.Controls.Add(this.tabPage3);
            this.tabControl1.Controls.Add(this.tabPage4);
            this.tabControl1.Location = new System.Drawing.Point(0, 27);
            this.tabControl1.Name = "tabControl1";
            this.tabControl1.SelectedIndex = 0;
            this.tabControl1.Size = new System.Drawing.Size(799, 433);
            this.tabControl1.TabIndex = 6;
            // 
            // tabPage1
            // 
            this.tabPage1.Controls.Add(this.groupBox1);
            this.tabPage1.Controls.Add(this.dataViewList);
            this.tabPage1.Location = new System.Drawing.Point(4, 22);
            this.tabPage1.Name = "tabPage1";
            this.tabPage1.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage1.Size = new System.Drawing.Size(791, 407);
            this.tabPage1.TabIndex = 0;
            this.tabPage1.Text = "Batch Ping";
            this.tabPage1.UseVisualStyleBackColor = true;
            this.tabPage1.Click += new System.EventHandler(this.tabPage1_Click);
            // 
            // tabPage2
            // 
            this.tabPage2.Controls.Add(this.groupBox4);
            this.tabPage2.Controls.Add(this.LanScannerIPV4Textbox);
            this.tabPage2.Controls.Add(this.scan_button);
            this.tabPage2.Controls.Add(this.groupBox3);
            this.tabPage2.Controls.Add(this.groupBox2);
            this.tabPage2.Controls.Add(this.lanStartScan);
            this.tabPage2.Controls.Add(this.lanDataViewList);
            this.tabPage2.Location = new System.Drawing.Point(4, 22);
            this.tabPage2.Name = "tabPage2";
            this.tabPage2.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage2.Size = new System.Drawing.Size(791, 407);
            this.tabPage2.TabIndex = 1;
            this.tabPage2.Text = "LAN Scanner";
            this.tabPage2.UseVisualStyleBackColor = true;
            // 
            // groupBox4
            // 
            this.groupBox4.Controls.Add(this.checkBox1);
            this.groupBox4.Location = new System.Drawing.Point(330, 7);
            this.groupBox4.Name = "groupBox4";
            this.groupBox4.Size = new System.Drawing.Size(76, 47);
            this.groupBox4.TabIndex = 18;
            this.groupBox4.TabStop = false;
            this.groupBox4.Text = "Auto Scan:";
            // 
            // checkBox1
            // 
            this.checkBox1.AutoSize = true;
            this.checkBox1.Location = new System.Drawing.Point(6, 23);
            this.checkBox1.Name = "checkBox1";
            this.checkBox1.Size = new System.Drawing.Size(60, 17);
            this.checkBox1.TabIndex = 0;
            this.checkBox1.Text = "Subnet";
            this.checkBox1.UseVisualStyleBackColor = true;
            // 
            // LanScannerIPV4Textbox
            // 
            this.LanScannerIPV4Textbox.AutoSize = true;
            this.LanScannerIPV4Textbox.Location = new System.Drawing.Point(9, 4);
            this.LanScannerIPV4Textbox.Name = "LanScannerIPV4Textbox";
            this.LanScannerIPV4Textbox.Size = new System.Drawing.Size(29, 13);
            this.LanScannerIPV4Textbox.TabIndex = 17;
            this.LanScannerIPV4Textbox.Text = "IPv4";
            // 
            // scan_button
            // 
            this.scan_button.Location = new System.Drawing.Point(412, 35);
            this.scan_button.Name = "scan_button";
            this.scan_button.Size = new System.Drawing.Size(75, 23);
            this.scan_button.TabIndex = 16;
            this.scan_button.Text = "Cancel";
            this.scan_button.UseVisualStyleBackColor = true;
            this.scan_button.Click += new System.EventHandler(this.scan_button_Click);
            // 
            // groupBox3
            // 
            this.groupBox3.Controls.Add(this.TOiptextbox4);
            this.groupBox3.Controls.Add(this.TOiptextbox1);
            this.groupBox3.Controls.Add(this.TOiptextbox3);
            this.groupBox3.Controls.Add(this.TOiptextbox2);
            this.groupBox3.Location = new System.Drawing.Point(187, 6);
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
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.FROMiptextbox4);
            this.groupBox2.Controls.Add(this.FROMiptextbox1);
            this.groupBox2.Controls.Add(this.FROMiptextbox3);
            this.groupBox2.Controls.Add(this.FROMiptextbox2);
            this.groupBox2.Location = new System.Drawing.Point(44, 6);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(137, 48);
            this.groupBox2.TabIndex = 8;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "From";
            // 
            // FROMiptextbox4
            // 
            this.FROMiptextbox4.Location = new System.Drawing.Point(102, 22);
            this.FROMiptextbox4.Name = "FROMiptextbox4";
            this.FROMiptextbox4.Size = new System.Drawing.Size(26, 20);
            this.FROMiptextbox4.TabIndex = 12;
            // 
            // FROMiptextbox1
            // 
            this.FROMiptextbox1.Location = new System.Drawing.Point(6, 22);
            this.FROMiptextbox1.Name = "FROMiptextbox1";
            this.FROMiptextbox1.Size = new System.Drawing.Size(26, 20);
            this.FROMiptextbox1.TabIndex = 9;
            // 
            // FROMiptextbox3
            // 
            this.FROMiptextbox3.Location = new System.Drawing.Point(70, 22);
            this.FROMiptextbox3.Name = "FROMiptextbox3";
            this.FROMiptextbox3.Size = new System.Drawing.Size(26, 20);
            this.FROMiptextbox3.TabIndex = 11;
            // 
            // FROMiptextbox2
            // 
            this.FROMiptextbox2.Location = new System.Drawing.Point(38, 22);
            this.FROMiptextbox2.Name = "FROMiptextbox2";
            this.FROMiptextbox2.Size = new System.Drawing.Size(26, 20);
            this.FROMiptextbox2.TabIndex = 10;
            // 
            // lanStartScan
            // 
            this.lanStartScan.Location = new System.Drawing.Point(412, 6);
            this.lanStartScan.Name = "lanStartScan";
            this.lanStartScan.Size = new System.Drawing.Size(75, 23);
            this.lanStartScan.TabIndex = 5;
            this.lanStartScan.Text = "Start Scanning";
            this.lanStartScan.UseVisualStyleBackColor = true;
            this.lanStartScan.Click += new System.EventHandler(this.lanStartScan_Click);
            // 
            // lanDataViewList
            // 
            this.lanDataViewList.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.columnHeader1,
            this.columnHeader2,
            this.columnHeader3,
            this.columnHeader4});
            this.lanDataViewList.Location = new System.Drawing.Point(12, 60);
            this.lanDataViewList.Name = "lanDataViewList";
            this.lanDataViewList.Size = new System.Drawing.Size(773, 341);
            this.lanDataViewList.Sorting = System.Windows.Forms.SortOrder.Descending;
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
            // tabPage3
            // 
            this.tabPage3.Controls.Add(this.groupBox6);
            this.tabPage3.Controls.Add(this.groupBox5);
            this.tabPage3.Controls.Add(this.gmapcontrol);
            this.tabPage3.Location = new System.Drawing.Point(4, 22);
            this.tabPage3.Name = "tabPage3";
            this.tabPage3.Size = new System.Drawing.Size(791, 407);
            this.tabPage3.TabIndex = 2;
            this.tabPage3.Text = "Visual Tracert";
            this.tabPage3.UseVisualStyleBackColor = true;
            // 
            // groupBox6
            // 
            this.groupBox6.Controls.Add(this.groupBox8);
            this.groupBox6.Controls.Add(this.groupBox7);
            this.groupBox6.Location = new System.Drawing.Point(598, 84);
            this.groupBox6.Name = "groupBox6";
            this.groupBox6.Size = new System.Drawing.Size(190, 146);
            this.groupBox6.TabIndex = 4;
            this.groupBox6.TabStop = false;
            this.groupBox6.Text = "Map Controls";
            // 
            // groupBox8
            // 
            this.groupBox8.Controls.Add(this.comboBox1);
            this.groupBox8.Location = new System.Drawing.Point(7, 75);
            this.groupBox8.Name = "groupBox8";
            this.groupBox8.Size = new System.Drawing.Size(177, 53);
            this.groupBox8.TabIndex = 1;
            this.groupBox8.TabStop = false;
            this.groupBox8.Text = "Map provider";
            // 
            // comboBox1
            // 
            this.comboBox1.AllowDrop = true;
            this.comboBox1.FormattingEnabled = true;
            this.comboBox1.Location = new System.Drawing.Point(7, 20);
            this.comboBox1.Name = "comboBox1";
            this.comboBox1.Size = new System.Drawing.Size(155, 21);
            this.comboBox1.TabIndex = 0;
            this.comboBox1.Text = "Google Maps";
            // 
            // groupBox7
            // 
            this.groupBox7.Controls.Add(this.button3);
            this.groupBox7.Controls.Add(this.button1);
            this.groupBox7.Location = new System.Drawing.Point(7, 20);
            this.groupBox7.Name = "groupBox7";
            this.groupBox7.Size = new System.Drawing.Size(177, 48);
            this.groupBox7.TabIndex = 0;
            this.groupBox7.TabStop = false;
            this.groupBox7.Text = "Zoom";
            // 
            // button3
            // 
            this.button3.Location = new System.Drawing.Point(87, 19);
            this.button3.Name = "button3";
            this.button3.Size = new System.Drawing.Size(75, 23);
            this.button3.TabIndex = 1;
            this.button3.Text = "+";
            this.button3.UseVisualStyleBackColor = true;
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(6, 19);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(75, 23);
            this.button1.TabIndex = 0;
            this.button1.Text = "-";
            this.button1.UseVisualStyleBackColor = true;
            // 
            // groupBox5
            // 
            this.groupBox5.Controls.Add(this.traceroute_button);
            this.groupBox5.Controls.Add(this.tracert_Textbox);
            this.groupBox5.Location = new System.Drawing.Point(598, 4);
            this.groupBox5.Name = "groupBox5";
            this.groupBox5.Size = new System.Drawing.Size(190, 74);
            this.groupBox5.TabIndex = 3;
            this.groupBox5.TabStop = false;
            this.groupBox5.Text = "Trace Route";
            // 
            // traceroute_button
            // 
            this.traceroute_button.Location = new System.Drawing.Point(7, 45);
            this.traceroute_button.Name = "traceroute_button";
            this.traceroute_button.Size = new System.Drawing.Size(75, 23);
            this.traceroute_button.TabIndex = 5;
            this.traceroute_button.Text = "Trace Route";
            this.traceroute_button.UseVisualStyleBackColor = true;
            this.traceroute_button.Click += new System.EventHandler(this.traceroute_button_Click);
            // 
            // tracert_Textbox
            // 
            this.tracert_Textbox.Location = new System.Drawing.Point(13, 20);
            this.tracert_Textbox.Name = "tracert_Textbox";
            this.tracert_Textbox.Size = new System.Drawing.Size(165, 20);
            this.tracert_Textbox.TabIndex = 0;
            // 
            // gmapcontrol
            // 
            this.gmapcontrol.Bearing = 0F;
            this.gmapcontrol.CanDragMap = true;
            this.gmapcontrol.EmptyTileColor = System.Drawing.Color.Navy;
            this.gmapcontrol.GrayScaleMode = false;
            this.gmapcontrol.HelperLineOption = GMap.NET.WindowsForms.HelperLineOptions.DontShow;
            this.gmapcontrol.LevelsKeepInMemmory = 5;
            this.gmapcontrol.Location = new System.Drawing.Point(3, 3);
            this.gmapcontrol.MarkersEnabled = true;
            this.gmapcontrol.MaxZoom = 18;
            this.gmapcontrol.MinZoom = 2;
            this.gmapcontrol.MouseWheelZoomEnabled = true;
            this.gmapcontrol.MouseWheelZoomType = GMap.NET.MouseWheelZoomType.MousePositionAndCenter;
            this.gmapcontrol.Name = "gmapcontrol";
            this.gmapcontrol.NegativeMode = false;
            this.gmapcontrol.PolygonsEnabled = true;
            this.gmapcontrol.RetryLoadTile = 0;
            this.gmapcontrol.RoutesEnabled = true;
            this.gmapcontrol.ScaleMode = GMap.NET.WindowsForms.ScaleModes.Integer;
            this.gmapcontrol.SelectedAreaFillColor = System.Drawing.Color.FromArgb(((int)(((byte)(33)))), ((int)(((byte)(65)))), ((int)(((byte)(105)))), ((int)(((byte)(225)))));
            this.gmapcontrol.ShowTileGridLines = false;
            this.gmapcontrol.Size = new System.Drawing.Size(588, 401);
            this.gmapcontrol.TabIndex = 1;
            this.gmapcontrol.Zoom = 2D;
            // 
            // tabPage4
            // 
            this.tabPage4.Location = new System.Drawing.Point(4, 22);
            this.tabPage4.Name = "tabPage4";
            this.tabPage4.Size = new System.Drawing.Size(791, 407);
            this.tabPage4.TabIndex = 3;
            this.tabPage4.Text = "WoL Manager";
            this.tabPage4.UseVisualStyleBackColor = true;
            // 
            // statusStrip1
            // 
            this.statusStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.toolStripStatusLabel1,
            this.toolStripStatusLabel2,
            this.toolStripStatusLabel3,
            this.toolStripStatusLabel4,
            this.batchProgressBar});
            this.statusStrip1.Location = new System.Drawing.Point(0, 467);
            this.statusStrip1.Name = "statusStrip1";
            this.statusStrip1.Size = new System.Drawing.Size(802, 22);
            this.statusStrip1.TabIndex = 7;
            this.statusStrip1.Text = "statusStrip1";
            // 
            // toolStripStatusLabel1
            // 
            this.toolStripStatusLabel1.Name = "toolStripStatusLabel1";
            this.toolStripStatusLabel1.Size = new System.Drawing.Size(114, 17);
            this.toolStripStatusLabel1.Text = "ICMP_PING Ver: 0.15";
            // 
            // toolStripStatusLabel2
            // 
            this.toolStripStatusLabel2.Name = "toolStripStatusLabel2";
            this.toolStripStatusLabel2.Size = new System.Drawing.Size(110, 17);
            this.toolStripStatusLabel2.Text = "| Anthony Murphy |";
            // 
            // toolStripStatusLabel3
            // 
            this.toolStripStatusLabel3.Name = "toolStripStatusLabel3";
            this.toolStripStatusLabel3.Size = new System.Drawing.Size(165, 17);
            this.toolStripStatusLabel3.Text = "https://github.com/netharion";
            // 
            // toolStripStatusLabel4
            // 
            this.toolStripStatusLabel4.Name = "toolStripStatusLabel4";
            this.toolStripStatusLabel4.Size = new System.Drawing.Size(91, 17);
            this.toolStripStatusLabel4.Text = "|                          |";
            // 
            // batchProgressBar
            // 
            this.batchProgressBar.Name = "batchProgressBar";
            this.batchProgressBar.Size = new System.Drawing.Size(300, 16);
            // 
            // menuStrip1
            // 
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.mToolStripMenuItem,
            this.viewToolStripMenuItem,
            this.actionsToolStripMenuItem,
            this.optionsToolStripMenuItem,
            this.helpToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(802, 24);
            this.menuStrip1.TabIndex = 8;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // mToolStripMenuItem
            // 
            this.mToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.toolStripMenuItem2});
            this.mToolStripMenuItem.Name = "mToolStripMenuItem";
            this.mToolStripMenuItem.Size = new System.Drawing.Size(37, 20);
            this.mToolStripMenuItem.Text = "File";
            // 
            // toolStripMenuItem2
            // 
            this.toolStripMenuItem2.Name = "toolStripMenuItem2";
            this.toolStripMenuItem2.Size = new System.Drawing.Size(92, 22);
            this.toolStripMenuItem2.Text = "123";
            // 
            // viewToolStripMenuItem
            // 
            this.viewToolStripMenuItem.Name = "viewToolStripMenuItem";
            this.viewToolStripMenuItem.Size = new System.Drawing.Size(44, 20);
            this.viewToolStripMenuItem.Text = "View";
            // 
            // actionsToolStripMenuItem
            // 
            this.actionsToolStripMenuItem.Name = "actionsToolStripMenuItem";
            this.actionsToolStripMenuItem.Size = new System.Drawing.Size(59, 20);
            this.actionsToolStripMenuItem.Text = "Actions";
            // 
            // optionsToolStripMenuItem
            // 
            this.optionsToolStripMenuItem.Name = "optionsToolStripMenuItem";
            this.optionsToolStripMenuItem.Size = new System.Drawing.Size(61, 20);
            this.optionsToolStripMenuItem.Text = "Options";
            // 
            // helpToolStripMenuItem
            // 
            this.helpToolStripMenuItem.Name = "helpToolStripMenuItem";
            this.helpToolStripMenuItem.Size = new System.Drawing.Size(44, 20);
            this.helpToolStripMenuItem.Text = "Help";
            // 
            // sourceLabel
            // 
            this.sourceLabel.AutoSize = true;
            this.sourceLabel.Location = new System.Drawing.Point(6, 89);
            this.sourceLabel.Name = "sourceLabel";
            this.sourceLabel.Size = new System.Drawing.Size(44, 13);
            this.sourceLabel.TabIndex = 6;
            this.sourceLabel.Text = "Source:";
            // 
            // source_combobox
            // 
            this.source_combobox.FormattingEnabled = true;
            this.source_combobox.Items.AddRange(new object[] {
            "Moz.com - Top 500"});
            this.source_combobox.Location = new System.Drawing.Point(56, 86);
            this.source_combobox.Name = "source_combobox";
            this.source_combobox.Size = new System.Drawing.Size(99, 21);
            this.source_combobox.TabIndex = 7;
            // 
            // button2
            // 
            this.button2.Location = new System.Drawing.Point(35, 183);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(75, 23);
            this.button2.TabIndex = 8;
            this.button2.Text = "button2";
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(802, 489);
            this.Controls.Add(this.statusStrip1);
            this.Controls.Add(this.menuStrip1);
            this.Controls.Add(this.tabControl1);
            this.MainMenuStrip = this.menuStrip1;
            this.Name = "Form1";
            this.Text = "Netscan";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.groupBox1.ResumeLayout(false);
            this.batchPingGroupBox.ResumeLayout(false);
            this.batchPingGroupBox.PerformLayout();
            this.singlePingGroupBox.ResumeLayout(false);
            this.singlePingGroupBox.PerformLayout();
            this.tabControl1.ResumeLayout(false);
            this.tabPage1.ResumeLayout(false);
            this.tabPage2.ResumeLayout(false);
            this.tabPage2.PerformLayout();
            this.groupBox4.ResumeLayout(false);
            this.groupBox4.PerformLayout();
            this.groupBox3.ResumeLayout(false);
            this.groupBox3.PerformLayout();
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            this.tabPage3.ResumeLayout(false);
            this.groupBox6.ResumeLayout(false);
            this.groupBox8.ResumeLayout(false);
            this.groupBox7.ResumeLayout(false);
            this.groupBox5.ResumeLayout(false);
            this.groupBox5.PerformLayout();
            this.statusStrip1.ResumeLayout(false);
            this.statusStrip1.PerformLayout();
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

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
        private System.Windows.Forms.GroupBox batchPingGroupBox;
        private System.Windows.Forms.Label batchPingLabel;
        private System.Windows.Forms.GroupBox singlePingGroupBox;
        private System.Windows.Forms.Label singleDomainLabel;
        private System.Windows.Forms.TabControl tabControl1;
        private System.Windows.Forms.TabPage tabPage1;
        private System.Windows.Forms.TabPage tabPage2;
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
        private System.Windows.Forms.StatusStrip statusStrip1;
        private System.Windows.Forms.ToolStripStatusLabel toolStripStatusLabel1;
        private System.Windows.Forms.ToolStripStatusLabel toolStripStatusLabel2;
        private System.Windows.Forms.ToolStripStatusLabel toolStripStatusLabel3;
        private System.Windows.Forms.ToolStripStatusLabel toolStripStatusLabel4;
        private System.Windows.Forms.ToolStripProgressBar batchProgressBar;
        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem mToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem toolStripMenuItem2;
        private System.Windows.Forms.ToolStripMenuItem viewToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem actionsToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem optionsToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem helpToolStripMenuItem;
        public System.Windows.Forms.ListView lanDataViewList;
        private System.Windows.Forms.Button scan_button;
        private System.Windows.Forms.Label LanScannerIPV4Textbox;
        private System.Windows.Forms.GroupBox groupBox4;
        private System.Windows.Forms.CheckBox checkBox1;
        private System.Windows.Forms.TabPage tabPage3;
        private System.Windows.Forms.TabPage tabPage4;
        private GMap.NET.WindowsForms.GMapControl gmapcontrol;
        private System.Windows.Forms.GroupBox groupBox5;
        private System.Windows.Forms.TextBox tracert_Textbox;
        private System.Windows.Forms.GroupBox groupBox6;
        private System.Windows.Forms.GroupBox groupBox8;
        private System.Windows.Forms.ComboBox comboBox1;
        private System.Windows.Forms.GroupBox groupBox7;
        private System.Windows.Forms.Button button3;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Button traceroute_button;
        private System.Windows.Forms.ComboBox source_combobox;
        private System.Windows.Forms.Label sourceLabel;
        private System.Windows.Forms.Button button2;
    }
}

