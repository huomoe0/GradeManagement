namespace GradeManagement
{
    partial class MainForm
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            components = new System.ComponentModel.Container();
            mnusStudentGrade = new MenuStrip();
            SToolStripMenuItem = new ToolStripMenuItem();
            TJXSToolStripMenuItem = new ToolStripMenuItem();
            BJXSToolStripMenuItem = new ToolStripMenuItem();
            CXToolStripMenuItem = new ToolStripMenuItem();
            DToolStripMenuItem = new ToolStripMenuItem();
            TJYXToolStripMenuItem = new ToolStripMenuItem();
            YXLBToolStripMenuItem = new ToolStripMenuItem();
            toolStripSeparator1 = new ToolStripSeparator();
            TJBJToolStripMenuItem = new ToolStripMenuItem();
            BJLBToolStripMenuItem = new ToolStripMenuItem();
            CToolStripMenuItem = new ToolStripMenuItem();
            TJKCToolStripMenuItem = new ToolStripMenuItem();
            KCLBToolStripMenuItem = new ToolStripMenuItem();
            CXKCToolStripMenuItem = new ToolStripMenuItem();
            GToolStripMenuItem = new ToolStripMenuItem();
            TJCJToolStripMenuItem = new ToolStripMenuItem();
            CJLBToolStripMenuItem = new ToolStripMenuItem();
            CJCXToolStripMenuItem = new ToolStripMenuItem();
            RToolStripMenuItem = new ToolStripMenuItem();
            XGMMToolStripMenuItem = new ToolStripMenuItem();
            toolStripSeparator2 = new ToolStripSeparator();
            SJBFToolStripMenuItem = new ToolStripMenuItem();
            SJHFToolStripMenuItem = new ToolStripMenuItem();
            toolStripSeparator3 = new ToolStripSeparator();
            TCXTXToolStripMenuItem = new ToolStripMenuItem();
            HToolStripMenuItem = new ToolStripMenuItem();
            GYToolStripMenuItem = new ToolStripMenuItem();
            tlsStudentGrade = new ToolStrip();
            toolStripButton1 = new ToolStripButton();
            toolStripButton4 = new ToolStripButton();
            toolStripSeparator4 = new ToolStripSeparator();
            toolStripButton2 = new ToolStripButton();
            toolStripSeparator5 = new ToolStripSeparator();
            toolStripButton3 = new ToolStripButton();
            stsStudentGrade = new StatusStrip();
            tsslInfo = new ToolStripStatusLabel();
            tsslTime = new ToolStripStatusLabel();
            tmrStudentGrade = new System.Windows.Forms.Timer(components);
            mnusStudentGrade.SuspendLayout();
            tlsStudentGrade.SuspendLayout();
            stsStudentGrade.SuspendLayout();
            SuspendLayout();
            // 
            // mnusStudentGrade
            // 
            mnusStudentGrade.ImageScalingSize = new Size(20, 20);
            mnusStudentGrade.Items.AddRange(new ToolStripItem[] { SToolStripMenuItem, DToolStripMenuItem, CToolStripMenuItem, GToolStripMenuItem, RToolStripMenuItem, HToolStripMenuItem });
            mnusStudentGrade.Location = new Point(0, 0);
            mnusStudentGrade.Name = "mnusStudentGrade";
            mnusStudentGrade.Padding = new Padding(8, 2, 0, 2);
            mnusStudentGrade.Size = new Size(1029, 28);
            mnusStudentGrade.TabIndex = 0;
            mnusStudentGrade.Text = "menuStrip1";
            // 
            // SToolStripMenuItem
            // 
            SToolStripMenuItem.DropDownItems.AddRange(new ToolStripItem[] { TJXSToolStripMenuItem, BJXSToolStripMenuItem, CXToolStripMenuItem });
            SToolStripMenuItem.Name = "SToolStripMenuItem";
            SToolStripMenuItem.Size = new Size(102, 24);
            SToolStripMenuItem.Text = "学生管理(&S)";
            // 
            // TJXSToolStripMenuItem
            // 
            TJXSToolStripMenuItem.Name = "TJXSToolStripMenuItem";
            TJXSToolStripMenuItem.Size = new Size(224, 26);
            TJXSToolStripMenuItem.Text = "添加学生";
            TJXSToolStripMenuItem.Click += TJXSToolStripMenuItem_Click;
            // 
            // BJXSToolStripMenuItem
            // 
            BJXSToolStripMenuItem.Name = "BJXSToolStripMenuItem";
            BJXSToolStripMenuItem.Size = new Size(224, 26);
            BJXSToolStripMenuItem.Text = "编辑学生";
            BJXSToolStripMenuItem.Click += BJXSToolStripMenuItem_Click;
            // 
            // CXToolStripMenuItem
            // 
            CXToolStripMenuItem.Name = "CXToolStripMenuItem";
            CXToolStripMenuItem.Size = new Size(224, 26);
            CXToolStripMenuItem.Text = "查询学生";
            CXToolStripMenuItem.Click += CXToolStripMenuItem_Click;
            // 
            // DToolStripMenuItem
            // 
            DToolStripMenuItem.DropDownItems.AddRange(new ToolStripItem[] { TJYXToolStripMenuItem, YXLBToolStripMenuItem, toolStripSeparator1, TJBJToolStripMenuItem, BJLBToolStripMenuItem });
            DToolStripMenuItem.Name = "DToolStripMenuItem";
            DToolStripMenuItem.Size = new Size(104, 24);
            DToolStripMenuItem.Text = "基础数据(&D)";
            // 
            // TJYXToolStripMenuItem
            // 
            TJYXToolStripMenuItem.Name = "TJYXToolStripMenuItem";
            TJYXToolStripMenuItem.Size = new Size(224, 26);
            TJYXToolStripMenuItem.Text = "添加院系";
            // 
            // YXLBToolStripMenuItem
            // 
            YXLBToolStripMenuItem.Name = "YXLBToolStripMenuItem";
            YXLBToolStripMenuItem.Size = new Size(224, 26);
            YXLBToolStripMenuItem.Text = "院系列表";
            // 
            // toolStripSeparator1
            // 
            toolStripSeparator1.Name = "toolStripSeparator1";
            toolStripSeparator1.Size = new Size(221, 6);
            // 
            // TJBJToolStripMenuItem
            // 
            TJBJToolStripMenuItem.Name = "TJBJToolStripMenuItem";
            TJBJToolStripMenuItem.Size = new Size(224, 26);
            TJBJToolStripMenuItem.Text = "添加班级";
            // 
            // BJLBToolStripMenuItem
            // 
            BJLBToolStripMenuItem.Name = "BJLBToolStripMenuItem";
            BJLBToolStripMenuItem.Size = new Size(224, 26);
            BJLBToolStripMenuItem.Text = "班级列表";
            // 
            // CToolStripMenuItem
            // 
            CToolStripMenuItem.DropDownItems.AddRange(new ToolStripItem[] { TJKCToolStripMenuItem, KCLBToolStripMenuItem, CXKCToolStripMenuItem });
            CToolStripMenuItem.Name = "CToolStripMenuItem";
            CToolStripMenuItem.Size = new Size(103, 24);
            CToolStripMenuItem.Text = "课程管理(&C)";
            // 
            // TJKCToolStripMenuItem
            // 
            TJKCToolStripMenuItem.Name = "TJKCToolStripMenuItem";
            TJKCToolStripMenuItem.Size = new Size(152, 26);
            TJKCToolStripMenuItem.Text = "添加课程";
            // 
            // KCLBToolStripMenuItem
            // 
            KCLBToolStripMenuItem.Name = "KCLBToolStripMenuItem";
            KCLBToolStripMenuItem.Size = new Size(152, 26);
            KCLBToolStripMenuItem.Text = "课程列表";
            // 
            // CXKCToolStripMenuItem
            // 
            CXKCToolStripMenuItem.Name = "CXKCToolStripMenuItem";
            CXKCToolStripMenuItem.Size = new Size(152, 26);
            CXKCToolStripMenuItem.Text = "查询课程";
            // 
            // GToolStripMenuItem
            // 
            GToolStripMenuItem.DropDownItems.AddRange(new ToolStripItem[] { TJCJToolStripMenuItem, CJLBToolStripMenuItem, CJCXToolStripMenuItem });
            GToolStripMenuItem.Name = "GToolStripMenuItem";
            GToolStripMenuItem.Size = new Size(104, 24);
            GToolStripMenuItem.Text = "成绩管理(&G)";
            // 
            // TJCJToolStripMenuItem
            // 
            TJCJToolStripMenuItem.Name = "TJCJToolStripMenuItem";
            TJCJToolStripMenuItem.Size = new Size(152, 26);
            TJCJToolStripMenuItem.Text = "添加成绩";
            // 
            // CJLBToolStripMenuItem
            // 
            CJLBToolStripMenuItem.Name = "CJLBToolStripMenuItem";
            CJLBToolStripMenuItem.Size = new Size(152, 26);
            CJLBToolStripMenuItem.Text = "成绩列表";
            // 
            // CJCXToolStripMenuItem
            // 
            CJCXToolStripMenuItem.Name = "CJCXToolStripMenuItem";
            CJCXToolStripMenuItem.Size = new Size(152, 26);
            CJCXToolStripMenuItem.Text = "成绩查询";
            // 
            // RToolStripMenuItem
            // 
            RToolStripMenuItem.DropDownItems.AddRange(new ToolStripItem[] { XGMMToolStripMenuItem, toolStripSeparator2, SJBFToolStripMenuItem, SJHFToolStripMenuItem, toolStripSeparator3, TCXTXToolStripMenuItem });
            RToolStripMenuItem.Name = "RToolStripMenuItem";
            RToolStripMenuItem.Size = new Size(73, 24);
            RToolStripMenuItem.Text = "系统(&R)";
            // 
            // XGMMToolStripMenuItem
            // 
            XGMMToolStripMenuItem.Name = "XGMMToolStripMenuItem";
            XGMMToolStripMenuItem.Size = new Size(172, 26);
            XGMMToolStripMenuItem.Text = "修改密码";
            // 
            // toolStripSeparator2
            // 
            toolStripSeparator2.Name = "toolStripSeparator2";
            toolStripSeparator2.Size = new Size(169, 6);
            // 
            // SJBFToolStripMenuItem
            // 
            SJBFToolStripMenuItem.Name = "SJBFToolStripMenuItem";
            SJBFToolStripMenuItem.Size = new Size(172, 26);
            SJBFToolStripMenuItem.Text = "数据备份";
            SJBFToolStripMenuItem.Click += SJBFToolStripMenuItem_Click;
            // 
            // SJHFToolStripMenuItem
            // 
            SJHFToolStripMenuItem.Name = "SJHFToolStripMenuItem";
            SJHFToolStripMenuItem.Size = new Size(172, 26);
            SJHFToolStripMenuItem.Text = "数据恢复";
            // 
            // toolStripSeparator3
            // 
            toolStripSeparator3.Name = "toolStripSeparator3";
            toolStripSeparator3.Size = new Size(169, 6);
            // 
            // TCXTXToolStripMenuItem
            // 
            TCXTXToolStripMenuItem.Name = "TCXTXToolStripMenuItem";
            TCXTXToolStripMenuItem.Size = new Size(172, 26);
            TCXTXToolStripMenuItem.Text = "退出系统(&X)";
            TCXTXToolStripMenuItem.Click += TCXTXToolStripMenuItem_Click;
            // 
            // HToolStripMenuItem
            // 
            HToolStripMenuItem.DropDownItems.AddRange(new ToolStripItem[] { GYToolStripMenuItem });
            HToolStripMenuItem.Name = "HToolStripMenuItem";
            HToolStripMenuItem.Size = new Size(75, 24);
            HToolStripMenuItem.Text = "帮助(&H)";
            // 
            // GYToolStripMenuItem
            // 
            GYToolStripMenuItem.Name = "GYToolStripMenuItem";
            GYToolStripMenuItem.Size = new Size(122, 26);
            GYToolStripMenuItem.Text = "关于";
            // 
            // tlsStudentGrade
            // 
            tlsStudentGrade.ImageScalingSize = new Size(20, 20);
            tlsStudentGrade.Items.AddRange(new ToolStripItem[] { toolStripButton1, toolStripButton4, toolStripSeparator4, toolStripButton2, toolStripSeparator5, toolStripButton3 });
            tlsStudentGrade.Location = new Point(0, 28);
            tlsStudentGrade.Name = "tlsStudentGrade";
            tlsStudentGrade.Size = new Size(1029, 27);
            tlsStudentGrade.TabIndex = 1;
            tlsStudentGrade.Text = "toolStrip1";
            // 
            // toolStripButton1
            // 
            toolStripButton1.DisplayStyle = ToolStripItemDisplayStyle.Image;
            toolStripButton1.Image = Properties.Resources.添加;
            toolStripButton1.ImageTransparentColor = Color.Magenta;
            toolStripButton1.Name = "toolStripButton1";
            toolStripButton1.Size = new Size(29, 24);
            toolStripButton1.Text = "toolStripButton1";
            toolStripButton1.ToolTipText = "添加学生";
            toolStripButton1.Click += TJXSToolStripMenuItem_Click;
            // 
            // toolStripButton4
            // 
            toolStripButton4.DisplayStyle = ToolStripItemDisplayStyle.Image;
            toolStripButton4.Image = Properties.Resources.编辑;
            toolStripButton4.ImageTransparentColor = Color.Magenta;
            toolStripButton4.Name = "toolStripButton4";
            toolStripButton4.Size = new Size(29, 24);
            toolStripButton4.Text = "toolStripButton4";
            toolStripButton4.ToolTipText = "编辑学生";
            // 
            // toolStripSeparator4
            // 
            toolStripSeparator4.Name = "toolStripSeparator4";
            toolStripSeparator4.Size = new Size(6, 27);
            // 
            // toolStripButton2
            // 
            toolStripButton2.DisplayStyle = ToolStripItemDisplayStyle.Image;
            toolStripButton2.Image = Properties.Resources.添加;
            toolStripButton2.ImageTransparentColor = Color.Magenta;
            toolStripButton2.Name = "toolStripButton2";
            toolStripButton2.Size = new Size(29, 24);
            toolStripButton2.Text = "toolStripButton2";
            toolStripButton2.ToolTipText = "添加院系";
            // 
            // toolStripSeparator5
            // 
            toolStripSeparator5.Name = "toolStripSeparator5";
            toolStripSeparator5.Size = new Size(6, 27);
            // 
            // toolStripButton3
            // 
            toolStripButton3.DisplayStyle = ToolStripItemDisplayStyle.Image;
            toolStripButton3.Image = Properties.Resources.关于;
            toolStripButton3.ImageTransparentColor = Color.Magenta;
            toolStripButton3.Name = "toolStripButton3";
            toolStripButton3.Size = new Size(29, 24);
            toolStripButton3.Text = "toolStripButton3";
            toolStripButton3.ToolTipText = "关于";
            // 
            // stsStudentGrade
            // 
            stsStudentGrade.ImageScalingSize = new Size(20, 20);
            stsStudentGrade.Items.AddRange(new ToolStripItem[] { tsslInfo, tsslTime });
            stsStudentGrade.Location = new Point(0, 503);
            stsStudentGrade.Name = "stsStudentGrade";
            stsStudentGrade.Padding = new Padding(1, 0, 18, 0);
            stsStudentGrade.Size = new Size(1029, 26);
            stsStudentGrade.TabIndex = 2;
            stsStudentGrade.Text = "statusStrip1";
            // 
            // tsslInfo
            // 
            tsslInfo.Name = "tsslInfo";
            tsslInfo.Size = new Size(37, 20);
            tsslInfo.Text = "info";
            // 
            // tsslTime
            // 
            tsslTime.Name = "tsslTime";
            tsslTime.Size = new Size(973, 20);
            tsslTime.Spring = true;
            tsslTime.Text = "time";
            tsslTime.TextAlign = ContentAlignment.MiddleRight;
            // 
            // tmrStudentGrade
            // 
            tmrStudentGrade.Enabled = true;
            tmrStudentGrade.Interval = 1000;
            tmrStudentGrade.Tick += tmrStudentGrade_Tick;
            // 
            // MainForm
            // 
            AutoScaleDimensions = new SizeF(9F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1029, 529);
            Controls.Add(stsStudentGrade);
            Controls.Add(tlsStudentGrade);
            Controls.Add(mnusStudentGrade);
            MainMenuStrip = mnusStudentGrade;
            Margin = new Padding(4);
            Name = "MainForm";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "学生成绩管理系统";
            FormClosed += MainForm_FormClosed;
            Load += MainForm_Load;
            mnusStudentGrade.ResumeLayout(false);
            mnusStudentGrade.PerformLayout();
            tlsStudentGrade.ResumeLayout(false);
            tlsStudentGrade.PerformLayout();
            stsStudentGrade.ResumeLayout(false);
            stsStudentGrade.PerformLayout();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private MenuStrip mnusStudentGrade;
        private ToolStripMenuItem SToolStripMenuItem;
        private ToolStrip tlsStudentGrade;
        private StatusStrip stsStudentGrade;
        private ToolStripStatusLabel tsslInfo;
        private ToolStripMenuItem DToolStripMenuItem;
        private ToolStripMenuItem CToolStripMenuItem;
        private ToolStripMenuItem GToolStripMenuItem;
        private ToolStripMenuItem RToolStripMenuItem;
        private ToolStripMenuItem HToolStripMenuItem;
        private ToolStripMenuItem TJXSToolStripMenuItem;
        private ToolStripMenuItem BJXSToolStripMenuItem;
        private ToolStripMenuItem CXToolStripMenuItem;
        private ToolStripMenuItem TJYXToolStripMenuItem;
        private ToolStripMenuItem YXLBToolStripMenuItem;
        private ToolStripSeparator toolStripSeparator1;
        private ToolStripMenuItem TJBJToolStripMenuItem;
        private ToolStripMenuItem BJLBToolStripMenuItem;
        private ToolStripMenuItem TJKCToolStripMenuItem;
        private ToolStripMenuItem KCLBToolStripMenuItem;
        private ToolStripMenuItem XGMMToolStripMenuItem;
        private ToolStripMenuItem GYToolStripMenuItem;
        private ToolStripMenuItem CXKCToolStripMenuItem;
        private ToolStripMenuItem TJCJToolStripMenuItem;
        private ToolStripMenuItem CJLBToolStripMenuItem;
        private ToolStripMenuItem CJCXToolStripMenuItem;
        private ToolStripSeparator toolStripSeparator2;
        private ToolStripMenuItem SJBFToolStripMenuItem;
        private ToolStripMenuItem SJHFToolStripMenuItem;
        private ToolStripSeparator toolStripSeparator3;
        private ToolStripMenuItem TCXTXToolStripMenuItem;
        private ToolStripButton toolStripButton1;
        private ToolStripSeparator toolStripSeparator4;
        private ToolStripButton toolStripButton4;
        private ToolStripButton toolStripButton2;
        private ToolStripSeparator toolStripSeparator5;
        private ToolStripButton toolStripButton3;
        private ToolStripStatusLabel tsslTime;
        private System.Windows.Forms.Timer tmrStudentGrade;
    }
}
