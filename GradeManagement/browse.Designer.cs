namespace GradeManagement
{
    partial class BrowseStudent
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
            components = new System.ComponentModel.Container();
            panel1 = new Panel();
            tvwDpart = new TreeView();
            contextMenuStrip1 = new ContextMenuStrip(components);
            全部展开ToolStripMenuItem = new ToolStripMenuItem();
            全部折叠ToolStripMenuItem = new ToolStripMenuItem();
            panel2 = new Panel();
            dgvStudent = new DataGridView();
            Column1 = new DataGridViewTextBoxColumn();
            Column2 = new DataGridViewTextBoxColumn();
            Column3 = new DataGridViewTextBoxColumn();
            Column4 = new DataGridViewTextBoxColumn();
            Column5 = new DataGridViewTextBoxColumn();
            Column6 = new DataGridViewTextBoxColumn();
            ClassName = new DataGridViewTextBoxColumn();
            panel1.SuspendLayout();
            contextMenuStrip1.SuspendLayout();
            panel2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)dgvStudent).BeginInit();
            SuspendLayout();
            // 
            // panel1
            // 
            panel1.Controls.Add(tvwDpart);
            panel1.Dock = DockStyle.Left;
            panel1.Location = new Point(0, 0);
            panel1.Name = "panel1";
            panel1.Size = new Size(174, 450);
            panel1.TabIndex = 0;
            // 
            // tvwDpart
            // 
            tvwDpart.ContextMenuStrip = contextMenuStrip1;
            tvwDpart.Dock = DockStyle.Fill;
            tvwDpart.Location = new Point(0, 0);
            tvwDpart.Name = "tvwDpart";
            tvwDpart.Size = new Size(174, 450);
            tvwDpart.TabIndex = 0;
            tvwDpart.AfterSelect += tvwDpart_AfterSelect;
            // 
            // contextMenuStrip1
            // 
            contextMenuStrip1.Items.AddRange(new ToolStripItem[] { 全部展开ToolStripMenuItem, 全部折叠ToolStripMenuItem });
            contextMenuStrip1.Name = "contextMenuStrip1";
            contextMenuStrip1.Size = new Size(125, 48);
            // 
            // 全部展开ToolStripMenuItem
            // 
            全部展开ToolStripMenuItem.Name = "全部展开ToolStripMenuItem";
            全部展开ToolStripMenuItem.Size = new Size(124, 22);
            全部展开ToolStripMenuItem.Text = "全部展开";
            全部展开ToolStripMenuItem.Click += 全部展开ToolStripMenuItem_Click;
            // 
            // 全部折叠ToolStripMenuItem
            // 
            全部折叠ToolStripMenuItem.Name = "全部折叠ToolStripMenuItem";
            全部折叠ToolStripMenuItem.Size = new Size(124, 22);
            全部折叠ToolStripMenuItem.Text = "全部折叠";
            全部折叠ToolStripMenuItem.Click += 全部折叠ToolStripMenuItem_Click;
            // 
            // panel2
            // 
            panel2.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            panel2.Controls.Add(dgvStudent);
            panel2.Location = new Point(174, 0);
            panel2.Name = "panel2";
            panel2.Size = new Size(900, 450);
            panel2.TabIndex = 1;
            // 
            // dgvStudent
            // 
            dgvStudent.AllowUserToAddRows = false;
            dgvStudent.AllowUserToDeleteRows = false;
            dgvStudent.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            dgvStudent.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dgvStudent.Columns.AddRange(new DataGridViewColumn[] { Column1, Column2, Column3, Column4, Column5, Column6, ClassName });
            dgvStudent.Dock = DockStyle.Fill;
            dgvStudent.Location = new Point(0, 0);
            dgvStudent.Name = "dgvStudent";
            dgvStudent.RowHeadersVisible = false;
            dgvStudent.RowHeadersWidthSizeMode = DataGridViewRowHeadersWidthSizeMode.AutoSizeToAllHeaders;
            dgvStudent.Size = new Size(900, 450);
            dgvStudent.TabIndex = 0;
            // 
            // Column1
            // 
            Column1.DataPropertyName = "Stuid";
            Column1.HeaderText = "学号";
            Column1.Name = "Column1";
            // 
            // Column2
            // 
            Column2.DataPropertyName = "Name";
            Column2.HeaderText = "姓名";
            Column2.Name = "Column2";
            // 
            // Column3
            // 
            Column3.DataPropertyName = "Gender";
            Column3.HeaderText = "性别";
            Column3.Name = "Column3";
            // 
            // Column4
            // 
            Column4.DataPropertyName = "Politics";
            Column4.HeaderText = "政治面貌";
            Column4.Name = "Column4";
            // 
            // Column5
            // 
            Column5.DataPropertyName = "Age";
            Column5.HeaderText = "年龄";
            Column5.Name = "Column5";
            // 
            // Column6
            // 
            Column6.DataPropertyName = "Location";
            Column6.HeaderText = "籍贯";
            Column6.Name = "Column6";
            // 
            // ClassName
            // 
            ClassName.DataPropertyName = "ClassName";
            ClassName.HeaderText = "班级";
            ClassName.Name = "ClassName";
            // 
            // BrowseStudent
            // 
            AutoScaleDimensions = new SizeF(7F, 17F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1094, 450);
            Controls.Add(panel2);
            Controls.Add(panel1);
            Name = "BrowseStudent";
            Text = "学生信息浏览";
            Load += BrowseStudent_Load;
            panel1.ResumeLayout(false);
            contextMenuStrip1.ResumeLayout(false);
            panel2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)dgvStudent).EndInit();
            ResumeLayout(false);
        }

        #endregion

        private Panel panel1;
        private Panel panel2;
        private TreeView tvwDpart;
        private DataGridView dgvStudent;
        private ContextMenuStrip contextMenuStrip1;
        private ToolStripMenuItem 全部展开ToolStripMenuItem;
        private ToolStripMenuItem 全部折叠ToolStripMenuItem;
        private DataGridViewTextBoxColumn Column1;
        private DataGridViewTextBoxColumn Column2;
        private DataGridViewTextBoxColumn Column3;
        private DataGridViewTextBoxColumn Column4;
        private DataGridViewTextBoxColumn Column5;
        private DataGridViewTextBoxColumn Column6;
        private DataGridViewTextBoxColumn ClassName;
    }
}