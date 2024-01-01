namespace GradeManagement
{
    partial class DBBackupForm
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
            label1 = new Label();
            txtBackup = new TextBox();
            btnBackupPath = new Button();
            btnBackup = new Button();
            btnClose = new Button();
            sfdlgBackup = new SaveFileDialog();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(15, 29);
            label1.Name = "label1";
            label1.Size = new Size(80, 17);
            label1.TabIndex = 0;
            label1.Text = "选择备份路径";
            // 
            // txtBackup
            // 
            txtBackup.Location = new Point(101, 26);
            txtBackup.Name = "txtBackup";
            txtBackup.Size = new Size(256, 23);
            txtBackup.TabIndex = 1;
            // 
            // btnBackupPath
            // 
            btnBackupPath.Location = new Point(369, 26);
            btnBackupPath.Name = "btnBackupPath";
            btnBackupPath.Size = new Size(60, 23);
            btnBackupPath.TabIndex = 2;
            btnBackupPath.Text = "选择";
            btnBackupPath.UseVisualStyleBackColor = true;
            btnBackupPath.Click += btnBackup_Click;
            // 
            // btnBackup
            // 
            btnBackup.Location = new Point(101, 85);
            btnBackup.Name = "btnBackup";
            btnBackup.Size = new Size(75, 23);
            btnBackup.TabIndex = 3;
            btnBackup.Text = "开始备份";
            btnBackup.UseVisualStyleBackColor = true;
            // 
            // btnClose
            // 
            btnClose.Location = new Point(282, 85);
            btnClose.Name = "btnClose";
            btnClose.Size = new Size(75, 23);
            btnClose.TabIndex = 4;
            btnClose.Text = "关闭";
            btnClose.UseVisualStyleBackColor = true;
            btnClose.Click += btnClose_Click;
            // 
            // DBBackupForm
            // 
            AutoScaleDimensions = new SizeF(7F, 17F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(440, 124);
            Controls.Add(btnClose);
            Controls.Add(btnBackup);
            Controls.Add(btnBackupPath);
            Controls.Add(txtBackup);
            Controls.Add(label1);
            Name = "DBBackupForm";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "数据备份";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label1;
        private TextBox txtBackup;
        private Button btnBackupPath;
        private Button btnBackup;
        private Button btnClose;
        private SaveFileDialog sfdlgBackup;
    }
}