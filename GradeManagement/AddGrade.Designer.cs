namespace GradeManagement
{
    partial class AddGrade
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
            groupBox1 = new GroupBox();
            btnSearch = new Button();
            cboClass = new ComboBox();
            cboCourse = new ComboBox();
            txtTerm = new TextBox();
            label3 = new Label();
            label2 = new Label();
            label1 = new Label();
            groupBox2 = new GroupBox();
            btnExit = new Button();
            btnAddStudent = new Button();
            panel1 = new Panel();
            dataGridView1 = new DataGridView();
            Column1 = new DataGridViewTextBoxColumn();
            Column2 = new DataGridViewTextBoxColumn();
            Column3 = new DataGridViewTextBoxColumn();
            groupBox1.SuspendLayout();
            groupBox2.SuspendLayout();
            panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)dataGridView1).BeginInit();
            SuspendLayout();
            // 
            // groupBox1
            // 
            groupBox1.Controls.Add(btnSearch);
            groupBox1.Controls.Add(cboClass);
            groupBox1.Controls.Add(cboCourse);
            groupBox1.Controls.Add(txtTerm);
            groupBox1.Controls.Add(label3);
            groupBox1.Controls.Add(label2);
            groupBox1.Controls.Add(label1);
            groupBox1.Location = new Point(12, 12);
            groupBox1.Name = "groupBox1";
            groupBox1.Size = new Size(776, 48);
            groupBox1.TabIndex = 9;
            groupBox1.TabStop = false;
            // 
            // btnSearch
            // 
            btnSearch.Location = new Point(624, 16);
            btnSearch.Name = "btnSearch";
            btnSearch.Size = new Size(75, 23);
            btnSearch.TabIndex = 13;
            btnSearch.Text = "查询";
            btnSearch.UseVisualStyleBackColor = true;
            btnSearch.Click += btnSearch_Click;
            // 
            // cboClass
            // 
            cboClass.FormattingEnabled = true;
            cboClass.Location = new Point(422, 11);
            cboClass.Name = "cboClass";
            cboClass.Size = new Size(156, 25);
            cboClass.TabIndex = 12;
            // 
            // cboCourse
            // 
            cboCourse.DropDownStyle = ComboBoxStyle.DropDownList;
            cboCourse.FormattingEnabled = true;
            cboCourse.Location = new Point(217, 14);
            cboCourse.Name = "cboCourse";
            cboCourse.Size = new Size(161, 25);
            cboCourse.TabIndex = 11;
            // 
            // txtTerm
            // 
            txtTerm.Location = new Point(44, 16);
            txtTerm.Name = "txtTerm";
            txtTerm.Size = new Size(100, 23);
            txtTerm.TabIndex = 10;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(384, 19);
            label3.Name = "label3";
            label3.Size = new Size(32, 17);
            label3.TabIndex = 9;
            label3.Text = "班级";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(179, 19);
            label2.Name = "label2";
            label2.Size = new Size(32, 17);
            label2.TabIndex = 8;
            label2.Text = "课程";
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(6, 19);
            label1.Name = "label1";
            label1.Size = new Size(32, 17);
            label1.TabIndex = 7;
            label1.Text = "学期";
            // 
            // groupBox2
            // 
            groupBox2.Controls.Add(btnExit);
            groupBox2.Controls.Add(btnAddStudent);
            groupBox2.Location = new Point(18, 396);
            groupBox2.Name = "groupBox2";
            groupBox2.Size = new Size(770, 42);
            groupBox2.TabIndex = 10;
            groupBox2.TabStop = false;
            // 
            // btnExit
            // 
            btnExit.Location = new Point(550, 10);
            btnExit.Name = "btnExit";
            btnExit.Size = new Size(75, 23);
            btnExit.TabIndex = 10;
            btnExit.Text = "退出";
            btnExit.UseVisualStyleBackColor = true;
            btnExit.Click += btnExit_Click;
            // 
            // btnAddStudent
            // 
            btnAddStudent.Location = new Point(130, 10);
            btnAddStudent.Name = "btnAddStudent";
            btnAddStudent.Size = new Size(75, 23);
            btnAddStudent.TabIndex = 9;
            btnAddStudent.Text = "添加";
            btnAddStudent.UseVisualStyleBackColor = true;
            btnAddStudent.Click += btnAddStudent_Click;
            // 
            // panel1
            // 
            panel1.Controls.Add(dataGridView1);
            panel1.Location = new Point(18, 57);
            panel1.Name = "panel1";
            panel1.Size = new Size(770, 343);
            panel1.TabIndex = 11;
            // 
            // dataGridView1
            // 
            dataGridView1.AllowUserToAddRows = false;
            dataGridView1.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            dataGridView1.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridView1.Columns.AddRange(new DataGridViewColumn[] { Column1, Column2, Column3 });
            dataGridView1.Dock = DockStyle.Fill;
            dataGridView1.Location = new Point(0, 0);
            dataGridView1.Name = "dataGridView1";
            dataGridView1.RowHeadersVisible = false;
            dataGridView1.Size = new Size(770, 343);
            dataGridView1.TabIndex = 0;
            // 
            // Column1
            // 
            Column1.DataPropertyName = "stuid";
            Column1.HeaderText = "学号";
            Column1.Name = "Column1";
            Column1.ReadOnly = true;
            // 
            // Column2
            // 
            Column2.DataPropertyName = "name";
            Column2.HeaderText = "姓名";
            Column2.Name = "Column2";
            Column2.ReadOnly = true;
            // 
            // Column3
            // 
            Column3.DataPropertyName = "grade";
            Column3.HeaderText = "成绩";
            Column3.Name = "Column3";
            // 
            // AddGrade
            // 
            AutoScaleDimensions = new SizeF(7F, 17F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(panel1);
            Controls.Add(groupBox2);
            Controls.Add(groupBox1);
            Name = "AddGrade";
            Text = "学生成绩录入";
            Load += AddGrade_Load;
            groupBox1.ResumeLayout(false);
            groupBox1.PerformLayout();
            groupBox2.ResumeLayout(false);
            panel1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)dataGridView1).EndInit();
            ResumeLayout(false);
        }

        #endregion

        private Button btnSearch;
        private GroupBox groupBox1;
        private Button button1;
        private ComboBox cboClass;
        private ComboBox cboCourse;
        private TextBox txtTerm;
        private Label label3;
        private Label label2;
        private Label label1;
        private GroupBox groupBox2;
        private Button btnExit;
        private Button btnAddStudent;
        private Panel panel1;
        private DataGridView dataGridView1;
        private DataGridViewTextBoxColumn Column1;
        private DataGridViewTextBoxColumn Column2;
        private DataGridViewTextBoxColumn Column3;
    }
}