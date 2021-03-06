﻿namespace USBCopyer
{
    partial class Setting
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
        /// 设计器支持所需的方法 - 不要修改
        /// 使用代码编辑器修改此方法的内容。
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Setting));
            this.saveButton = new System.Windows.Forms.Button();
            this.logButton = new System.Windows.Forms.Button();
            this.dir = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.dirDialogButton = new System.Windows.Forms.Button();
            this.folderBrowser = new System.Windows.Forms.FolderBrowserDialog();
            this.label2 = new System.Windows.Forms.Label();
            this.conflict = new System.Windows.Forms.ComboBox();
            this.fileButton = new System.Windows.Forms.Button();
            this.autorm = new System.Windows.Forms.CheckBox();
            this.linkLabel1 = new System.Windows.Forms.LinkLabel();
            this.label4 = new System.Windows.Forms.Label();
            this.hidemsg = new System.Windows.Forms.CheckBox();
            this.linkLabel2 = new System.Windows.Forms.LinkLabel();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.copynoext = new System.Windows.Forms.CheckBox();
            this.label10 = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.white = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.black = new System.Windows.Forms.TextBox();
            this.mode = new System.Windows.Forms.ComboBox();
            this.label5 = new System.Windows.Forms.Label();
            this.label11 = new System.Windows.Forms.Label();
            this.sleep = new System.Windows.Forms.TextBox();
            this.label12 = new System.Windows.Forms.Label();
            this.version = new System.Windows.Forms.Label();
            this.linkLabel3 = new System.Windows.Forms.LinkLabel();
            this.label3 = new System.Windows.Forms.Label();
            this.linkLabel4 = new System.Windows.Forms.LinkLabel();
            this.linkLabel5 = new System.Windows.Forms.LinkLabel();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.linkLabel6 = new System.Windows.Forms.LinkLabel();
            this.label16 = new System.Windows.Forms.Label();
            this.label15 = new System.Windows.Forms.Label();
            this.blackid = new System.Windows.Forms.TextBox();
            this.label14 = new System.Windows.Forms.Label();
            this.label13 = new System.Windows.Forms.Label();
            this.blackdisk = new System.Windows.Forms.TextBox();
            this.groupBox1.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.SuspendLayout();
            // 
            // saveButton
            // 
            this.saveButton.Location = new System.Drawing.Point(9, 545);
            this.saveButton.Name = "saveButton";
            this.saveButton.Size = new System.Drawing.Size(228, 40);
            this.saveButton.TabIndex = 0;
            this.saveButton.Text = "保存设置 (&S)";
            this.saveButton.UseVisualStyleBackColor = true;
            this.saveButton.Click += new System.EventHandler(this.saveButton_Click);
            // 
            // logButton
            // 
            this.logButton.Location = new System.Drawing.Point(389, 545);
            this.logButton.Name = "logButton";
            this.logButton.Size = new System.Drawing.Size(123, 40);
            this.logButton.TabIndex = 1;
            this.logButton.Text = "查看日志 (&L)";
            this.logButton.UseVisualStyleBackColor = true;
            this.logButton.Click += new System.EventHandler(this.logButton_Click);
            // 
            // dir
            // 
            this.dir.Location = new System.Drawing.Point(84, 17);
            this.dir.Name = "dir";
            this.dir.Size = new System.Drawing.Size(350, 21);
            this.dir.TabIndex = 2;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(13, 20);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(65, 12);
            this.label1.TabIndex = 3;
            this.label1.Text = "存储目录：";
            // 
            // dirDialogButton
            // 
            this.dirDialogButton.Location = new System.Drawing.Point(440, 15);
            this.dirDialogButton.Name = "dirDialogButton";
            this.dirDialogButton.Size = new System.Drawing.Size(75, 23);
            this.dirDialogButton.TabIndex = 4;
            this.dirDialogButton.Text = "浏览 ...";
            this.dirDialogButton.UseVisualStyleBackColor = true;
            this.dirDialogButton.Click += new System.EventHandler(this.dirDialogButton_Click);
            // 
            // folderBrowser
            // 
            this.folderBrowser.Description = "请选择一个文件夹用于存储从存储设备自动复制的文件";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(10, 79);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(113, 12);
            this.label2.TabIndex = 5;
            this.label2.Text = "文件冲突解决方案：";
            // 
            // conflict
            // 
            this.conflict.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.conflict.FormattingEnabled = true;
            this.conflict.Items.AddRange(new object[] {
            "若版本较新，则覆盖",
            "重命名新文件",
            "直接覆盖",
            "跳过"});
            this.conflict.Location = new System.Drawing.Point(129, 76);
            this.conflict.Name = "conflict";
            this.conflict.Size = new System.Drawing.Size(384, 20);
            this.conflict.TabIndex = 6;
            // 
            // fileButton
            // 
            this.fileButton.Location = new System.Drawing.Point(260, 545);
            this.fileButton.Name = "fileButton";
            this.fileButton.Size = new System.Drawing.Size(123, 40);
            this.fileButton.TabIndex = 7;
            this.fileButton.Text = "查看文件 (&F)";
            this.fileButton.UseVisualStyleBackColor = true;
            this.fileButton.Click += new System.EventHandler(this.fileButton_Click);
            // 
            // autorm
            // 
            this.autorm.AutoSize = true;
            this.autorm.Location = new System.Drawing.Point(12, 140);
            this.autorm.Name = "autorm";
            this.autorm.Size = new System.Drawing.Size(228, 16);
            this.autorm.TabIndex = 8;
            this.autorm.Text = "如果之前已经复制过，则先清空再复制";
            this.autorm.UseVisualStyleBackColor = true;
            // 
            // linkLabel1
            // 
            this.linkLabel1.AutoSize = true;
            this.linkLabel1.LinkColor = System.Drawing.Color.SteelBlue;
            this.linkLabel1.Location = new System.Drawing.Point(85, 599);
            this.linkLabel1.Name = "linkLabel1";
            this.linkLabel1.Size = new System.Drawing.Size(77, 12);
            this.linkLabel1.TabIndex = 10;
            this.linkLabel1.TabStop = true;
            this.linkLabel1.Text = "作者：Kenvix";
            this.linkLabel1.VisitedLinkColor = System.Drawing.Color.SteelBlue;
            this.linkLabel1.LinkClicked += new System.Windows.Forms.LinkLabelLinkClickedEventHandler(this.linkLabel1_LinkClicked);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(13, 48);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(491, 12);
            this.label4.TabIndex = 11;
            this.label4.Text = "留空表示存放到当前程序运行目录下面的 USBCopyerData 文件夹。文件夹内使用设备ID分类";
            // 
            // hidemsg
            // 
            this.hidemsg.AutoSize = true;
            this.hidemsg.Location = new System.Drawing.Point(414, 140);
            this.hidemsg.Name = "hidemsg";
            this.hidemsg.Size = new System.Drawing.Size(96, 16);
            this.hidemsg.TabIndex = 12;
            this.hidemsg.Text = "隐藏程序通知";
            this.hidemsg.UseVisualStyleBackColor = true;
            // 
            // linkLabel2
            // 
            this.linkLabel2.AutoSize = true;
            this.linkLabel2.LinkColor = System.Drawing.Color.SteelBlue;
            this.linkLabel2.Location = new System.Drawing.Point(444, 599);
            this.linkLabel2.Name = "linkLabel2";
            this.linkLabel2.Size = new System.Drawing.Size(65, 12);
            this.linkLabel2.TabIndex = 13;
            this.linkLabel2.TabStop = true;
            this.linkLabel2.Text = "命令行参数";
            this.linkLabel2.VisitedLinkColor = System.Drawing.Color.SteelBlue;
            this.linkLabel2.LinkClicked += new System.Windows.Forms.LinkLabelLinkClickedEventHandler(this.linkLabel2_LinkClicked);
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.copynoext);
            this.groupBox1.Controls.Add(this.label10);
            this.groupBox1.Controls.Add(this.label9);
            this.groupBox1.Controls.Add(this.label8);
            this.groupBox1.Controls.Add(this.label7);
            this.groupBox1.Controls.Add(this.white);
            this.groupBox1.Controls.Add(this.label6);
            this.groupBox1.Controls.Add(this.black);
            this.groupBox1.Controls.Add(this.mode);
            this.groupBox1.Controls.Add(this.label5);
            this.groupBox1.Location = new System.Drawing.Point(12, 168);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(498, 214);
            this.groupBox1.TabIndex = 14;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "按扩展名选择性复制";
            // 
            // copynoext
            // 
            this.copynoext.AutoSize = true;
            this.copynoext.Location = new System.Drawing.Point(357, 32);
            this.copynoext.Name = "copynoext";
            this.copynoext.Size = new System.Drawing.Size(132, 16);
            this.copynoext.TabIndex = 22;
            this.copynoext.Text = "复制无扩展名的文件";
            this.copynoext.UseVisualStyleBackColor = true;
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Location = new System.Drawing.Point(10, 182);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(281, 12);
            this.label10.TabIndex = 21;
            this.label10.Text = "每个扩展名用半角逗号 , 分割，前面不需要加点 . ";
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(10, 157);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(431, 12);
            this.label9.TabIndex = 20;
            this.label9.Text = "\"白名单模式\" 表示只复制该扩展名的文件  （先选择工作模式再填写黑白名单）";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(10, 133);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(443, 12);
            this.label8.TabIndex = 19;
            this.label8.Text = "你可以选择只复制特定扩展名的文件，\"黑名单模式\" 表示不复制这个扩展名的文件";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(10, 103);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(89, 12);
            this.label7.TabIndex = 18;
            this.label7.Text = "白名单扩展名：";
            // 
            // white
            // 
            this.white.Location = new System.Drawing.Point(105, 100);
            this.white.Name = "white";
            this.white.Size = new System.Drawing.Size(384, 21);
            this.white.TabIndex = 17;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(10, 68);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(89, 12);
            this.label6.TabIndex = 16;
            this.label6.Text = "黑名单扩展名：";
            // 
            // black
            // 
            this.black.Location = new System.Drawing.Point(105, 65);
            this.black.Name = "black";
            this.black.Size = new System.Drawing.Size(384, 21);
            this.black.TabIndex = 15;
            // 
            // mode
            // 
            this.mode.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.mode.FormattingEnabled = true;
            this.mode.Items.AddRange(new object[] {
            "复制所有文件",
            "黑名单模式",
            "白名单模式"});
            this.mode.Location = new System.Drawing.Point(105, 30);
            this.mode.Name = "mode";
            this.mode.Size = new System.Drawing.Size(230, 20);
            this.mode.TabIndex = 15;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(10, 33);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(65, 12);
            this.label5.TabIndex = 15;
            this.label5.Text = "工作模式：";
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Location = new System.Drawing.Point(10, 112);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(227, 12);
            this.label11.TabIndex = 15;
            this.label11.Text = "延迟复制：当插入 USB 存储设备后，延迟";
            // 
            // sleep
            // 
            this.sleep.Location = new System.Drawing.Point(243, 108);
            this.sleep.MaxLength = 9;
            this.sleep.Name = "sleep";
            this.sleep.Size = new System.Drawing.Size(135, 21);
            this.sleep.TabIndex = 16;
            // 
            // label12
            // 
            this.label12.AutoSize = true;
            this.label12.Location = new System.Drawing.Point(384, 113);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(53, 12);
            this.label12.TabIndex = 17;
            this.label12.Text = "秒再复制";
            // 
            // version
            // 
            this.version.AutoSize = true;
            this.version.Location = new System.Drawing.Point(184, 600);
            this.version.Name = "version";
            this.version.Size = new System.Drawing.Size(53, 12);
            this.version.TabIndex = 18;
            this.version.Text = "Version.";
            // 
            // linkLabel3
            // 
            this.linkLabel3.AutoSize = true;
            this.linkLabel3.LinkColor = System.Drawing.Color.SteelBlue;
            this.linkLabel3.Location = new System.Drawing.Point(361, 599);
            this.linkLabel3.Name = "linkLabel3";
            this.linkLabel3.Size = new System.Drawing.Size(77, 12);
            this.linkLabel3.TabIndex = 19;
            this.linkLabel3.TabStop = true;
            this.linkLabel3.Text = "开机启动帮助";
            this.linkLabel3.VisitedLinkColor = System.Drawing.Color.SteelBlue;
            this.linkLabel3.LinkClicked += new System.Windows.Forms.LinkLabelLinkClickedEventHandler(this.linkLabel3_LinkClicked);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(68, 600);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(17, 12);
            this.label3.TabIndex = 20;
            this.label3.Text = "//";
            // 
            // linkLabel4
            // 
            this.linkLabel4.AutoSize = true;
            this.linkLabel4.LinkColor = System.Drawing.Color.SteelBlue;
            this.linkLabel4.Location = new System.Drawing.Point(10, 599);
            this.linkLabel4.Name = "linkLabel4";
            this.linkLabel4.Size = new System.Drawing.Size(59, 12);
            this.linkLabel4.TabIndex = 21;
            this.linkLabel4.TabStop = true;
            this.linkLabel4.Text = "USBCopyer";
            this.linkLabel4.VisitedLinkColor = System.Drawing.Color.SteelBlue;
            this.linkLabel4.LinkClicked += new System.Windows.Forms.LinkLabelLinkClickedEventHandler(this.linkLabel4_LinkClicked);
            // 
            // linkLabel5
            // 
            this.linkLabel5.AutoSize = true;
            this.linkLabel5.LinkColor = System.Drawing.Color.SteelBlue;
            this.linkLabel5.Location = new System.Drawing.Point(294, 600);
            this.linkLabel5.Name = "linkLabel5";
            this.linkLabel5.Size = new System.Drawing.Size(53, 12);
            this.linkLabel5.TabIndex = 22;
            this.linkLabel5.TabStop = true;
            this.linkLabel5.Text = "检查更新";
            this.linkLabel5.VisitedLinkColor = System.Drawing.Color.SteelBlue;
            this.linkLabel5.LinkClicked += new System.Windows.Forms.LinkLabelLinkClickedEventHandler(this.linkLabel5_LinkClicked);
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.linkLabel6);
            this.groupBox2.Controls.Add(this.label16);
            this.groupBox2.Controls.Add(this.label15);
            this.groupBox2.Controls.Add(this.blackid);
            this.groupBox2.Controls.Add(this.label14);
            this.groupBox2.Controls.Add(this.label13);
            this.groupBox2.Controls.Add(this.blackdisk);
            this.groupBox2.Location = new System.Drawing.Point(12, 389);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(498, 150);
            this.groupBox2.TabIndex = 23;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "磁盘黑名单";
            // 
            // linkLabel6
            // 
            this.linkLabel6.AutoSize = true;
            this.linkLabel6.LinkColor = System.Drawing.Color.SteelBlue;
            this.linkLabel6.Location = new System.Drawing.Point(364, 117);
            this.linkLabel6.Name = "linkLabel6";
            this.linkLabel6.Size = new System.Drawing.Size(125, 12);
            this.linkLabel6.TabIndex = 24;
            this.linkLabel6.TabStop = true;
            this.linkLabel6.Text = "如何获取磁盘序列号？";
            this.linkLabel6.VisitedLinkColor = System.Drawing.Color.SteelBlue;
            this.linkLabel6.LinkClicked += new System.Windows.Forms.LinkLabelLinkClickedEventHandler(this.linkLabel6_LinkClicked);
            // 
            // label16
            // 
            this.label16.AutoSize = true;
            this.label16.Location = new System.Drawing.Point(4, 117);
            this.label16.Name = "label16";
            this.label16.Size = new System.Drawing.Size(311, 12);
            this.label16.TabIndex = 27;
            this.label16.Text = "不复制指定磁盘序列号的磁盘的数据，用半角逗号 , 分割";
            // 
            // label15
            // 
            this.label15.AutoSize = true;
            this.label15.Location = new System.Drawing.Point(10, 86);
            this.label15.Name = "label15";
            this.label15.Size = new System.Drawing.Size(89, 12);
            this.label15.TabIndex = 26;
            this.label15.Text = "黑名单序列号：";
            // 
            // blackid
            // 
            this.blackid.Location = new System.Drawing.Point(105, 83);
            this.blackid.Name = "blackid";
            this.blackid.Size = new System.Drawing.Size(384, 21);
            this.blackid.TabIndex = 25;
            // 
            // label14
            // 
            this.label14.AutoSize = true;
            this.label14.Location = new System.Drawing.Point(10, 52);
            this.label14.Name = "label14";
            this.label14.Size = new System.Drawing.Size(89, 12);
            this.label14.TabIndex = 24;
            this.label14.Text = "黑名单分区号：";
            // 
            // label13
            // 
            this.label13.AutoSize = true;
            this.label13.Location = new System.Drawing.Point(4, 25);
            this.label13.Name = "label13";
            this.label13.Size = new System.Drawing.Size(491, 12);
            this.label13.TabIndex = 23;
            this.label13.Text = "不复制某些分区号的数据，用半角逗号 , 分割，只写一个字母即可。如 H 表示不复制 H 盘";
            // 
            // blackdisk
            // 
            this.blackdisk.Location = new System.Drawing.Point(105, 49);
            this.blackdisk.MaxLength = 51;
            this.blackdisk.Name = "blackdisk";
            this.blackdisk.Size = new System.Drawing.Size(384, 21);
            this.blackdisk.TabIndex = 23;
            // 
            // Setting
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(524, 625);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.linkLabel5);
            this.Controls.Add(this.linkLabel4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.linkLabel3);
            this.Controls.Add(this.version);
            this.Controls.Add(this.label12);
            this.Controls.Add(this.sleep);
            this.Controls.Add(this.label11);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.linkLabel2);
            this.Controls.Add(this.hidemsg);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.linkLabel1);
            this.Controls.Add(this.autorm);
            this.Controls.Add(this.fileButton);
            this.Controls.Add(this.conflict);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.dirDialogButton);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.dir);
            this.Controls.Add(this.logButton);
            this.Controls.Add(this.saveButton);
            this.MaximizeBox = false;
            this.MaximumSize = new System.Drawing.Size(540, 664);
            this.MinimumSize = new System.Drawing.Size(540, 664);
            this.Name = "Setting";
            this.Text = "USBCopyer 设置";
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button saveButton;
        private System.Windows.Forms.Button logButton;
        private System.Windows.Forms.TextBox dir;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button dirDialogButton;
        private System.Windows.Forms.FolderBrowserDialog folderBrowser;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.ComboBox conflict;
        private System.Windows.Forms.Button fileButton;
        private System.Windows.Forms.CheckBox autorm;
        private System.Windows.Forms.LinkLabel linkLabel1;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.CheckBox hidemsg;
        private System.Windows.Forms.LinkLabel linkLabel2;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.TextBox white;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.TextBox black;
        private System.Windows.Forms.ComboBox mode;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.TextBox sleep;
        private System.Windows.Forms.Label label12;
        private System.Windows.Forms.Label version;
        private System.Windows.Forms.CheckBox copynoext;
        private System.Windows.Forms.LinkLabel linkLabel3;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.LinkLabel linkLabel4;
        private System.Windows.Forms.LinkLabel linkLabel5;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.Label label16;
        private System.Windows.Forms.Label label15;
        private System.Windows.Forms.TextBox blackid;
        private System.Windows.Forms.Label label14;
        private System.Windows.Forms.Label label13;
        private System.Windows.Forms.TextBox blackdisk;
        private System.Windows.Forms.LinkLabel linkLabel6;
    }
}

