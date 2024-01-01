namespace GradeManagement
{
    partial class EditStudent
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
            btnCancel = new Button();
            btnEdit = new Button();
            groupBox2 = new GroupBox();
            rbtFemal = new RadioButton();
            rbtMale = new RadioButton();
            txtLocation = new TextBox();
            label8 = new Label();
            comClass = new ComboBox();
            label7 = new Label();
            comDepart = new ComboBox();
            label6 = new Label();
            numAge = new NumericUpDown();
            label5 = new Label();
            comPolitics = new ComboBox();
            label4 = new Label();
            label3 = new Label();
            txtName = new TextBox();
            label2 = new Label();
            txtStuID = new TextBox();
            label1 = new Label();
            btnDelete = new Button();
            groupBox1 = new GroupBox();
            btnSearch = new Button();
            txtSearch = new TextBox();
            label18 = new Label();
            groupBox2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)numAge).BeginInit();
            groupBox1.SuspendLayout();
            SuspendLayout();
            // 
            // btnCancel
            // 
            btnCancel.Location = new Point(652, 267);
            btnCancel.Name = "btnCancel";
            btnCancel.Size = new Size(75, 23);
            btnCancel.TabIndex = 40;
            btnCancel.Text = "关闭";
            btnCancel.UseVisualStyleBackColor = true;
            btnCancel.Click += btnCancel_Click;
            // 
            // btnEdit
            // 
            btnEdit.Location = new Point(46, 267);
            btnEdit.Name = "btnEdit";
            btnEdit.Size = new Size(75, 23);
            btnEdit.TabIndex = 39;
            btnEdit.Text = "修改";
            btnEdit.UseVisualStyleBackColor = true;
            btnEdit.Click += btnEdit_Click;
            // 
            // groupBox2
            // 
            groupBox2.Controls.Add(rbtFemal);
            groupBox2.Controls.Add(rbtMale);
            groupBox2.Controls.Add(txtLocation);
            groupBox2.Controls.Add(label8);
            groupBox2.Controls.Add(comClass);
            groupBox2.Controls.Add(label7);
            groupBox2.Controls.Add(comDepart);
            groupBox2.Controls.Add(label6);
            groupBox2.Controls.Add(numAge);
            groupBox2.Controls.Add(label5);
            groupBox2.Controls.Add(comPolitics);
            groupBox2.Controls.Add(label4);
            groupBox2.Controls.Add(label3);
            groupBox2.Controls.Add(txtName);
            groupBox2.Controls.Add(label2);
            groupBox2.Controls.Add(txtStuID);
            groupBox2.Controls.Add(label1);
            groupBox2.Location = new Point(23, 80);
            groupBox2.Name = "groupBox2";
            groupBox2.Size = new Size(715, 171);
            groupBox2.TabIndex = 38;
            groupBox2.TabStop = false;
            // 
            // rbtFemal
            // 
            rbtFemal.AutoSize = true;
            rbtFemal.Location = new Point(448, 20);
            rbtFemal.Name = "rbtFemal";
            rbtFemal.Size = new Size(38, 21);
            rbtFemal.TabIndex = 39;
            rbtFemal.TabStop = true;
            rbtFemal.Text = "女";
            rbtFemal.UseVisualStyleBackColor = true;
            // 
            // rbtMale
            // 
            rbtMale.AutoSize = true;
            rbtMale.Location = new Point(404, 20);
            rbtMale.Name = "rbtMale";
            rbtMale.Size = new Size(38, 21);
            rbtMale.TabIndex = 38;
            rbtMale.TabStop = true;
            rbtMale.Text = "男";
            rbtMale.UseVisualStyleBackColor = true;
            // 
            // txtLocation
            // 
            txtLocation.Location = new Point(69, 122);
            txtLocation.Name = "txtLocation";
            txtLocation.Size = new Size(629, 23);
            txtLocation.TabIndex = 54;
            // 
            // label8
            // 
            label8.AutoSize = true;
            label8.Location = new Point(17, 125);
            label8.Name = "label8";
            label8.Size = new Size(32, 17);
            label8.TabIndex = 53;
            label8.Text = "籍贯";
            // 
            // comClass
            // 
            comClass.DropDownStyle = ComboBoxStyle.DropDownList;
            comClass.FormattingEnabled = true;
            comClass.Location = new Point(520, 66);
            comClass.Name = "comClass";
            comClass.Size = new Size(178, 25);
            comClass.TabIndex = 52;
            // 
            // label7
            // 
            label7.AutoSize = true;
            label7.Location = new Point(482, 72);
            label7.Name = "label7";
            label7.Size = new Size(32, 17);
            label7.TabIndex = 51;
            label7.Text = "班级";
            // 
            // comDepart
            // 
            comDepart.DropDownStyle = ComboBoxStyle.DropDownList;
            comDepart.FormattingEnabled = true;
            comDepart.Location = new Point(280, 66);
            comDepart.Name = "comDepart";
            comDepart.Size = new Size(196, 25);
            comDepart.TabIndex = 50;
            comDepart.SelectedValueChanged += comDepart_SelectedValueChanged;
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Location = new Point(242, 69);
            label6.Name = "label6";
            label6.Size = new Size(32, 17);
            label6.TabIndex = 49;
            label6.Text = "院系";
            // 
            // numAge
            // 
            numAge.Location = new Point(563, 22);
            numAge.Maximum = new decimal(new int[] { 30, 0, 0, 0 });
            numAge.Minimum = new decimal(new int[] { 14, 0, 0, 0 });
            numAge.Name = "numAge";
            numAge.Size = new Size(120, 23);
            numAge.TabIndex = 48;
            numAge.Value = new decimal(new int[] { 14, 0, 0, 0 });
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Location = new Point(514, 22);
            label5.Name = "label5";
            label5.Size = new Size(32, 17);
            label5.TabIndex = 47;
            label5.Text = "年龄";
            // 
            // comPolitics
            // 
            comPolitics.DropDownStyle = ComboBoxStyle.DropDownList;
            comPolitics.FormattingEnabled = true;
            comPolitics.Items.AddRange(new object[] { "中共党员", "共青团员", "学生", "其他" });
            comPolitics.Location = new Point(83, 66);
            comPolitics.Name = "comPolitics";
            comPolitics.Size = new Size(153, 25);
            comPolitics.TabIndex = 46;
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(17, 69);
            label4.Name = "label4";
            label4.Size = new Size(56, 17);
            label4.TabIndex = 45;
            label4.Text = "政治面貌";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(366, 22);
            label3.Name = "label3";
            label3.Size = new Size(32, 17);
            label3.TabIndex = 44;
            label3.Text = "性别";
            // 
            // txtName
            // 
            txtName.Location = new Point(242, 19);
            txtName.Name = "txtName";
            txtName.Size = new Size(100, 23);
            txtName.TabIndex = 43;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(204, 22);
            label2.Name = "label2";
            label2.Size = new Size(32, 17);
            label2.TabIndex = 42;
            label2.Text = "姓名";
            // 
            // txtStuID
            // 
            txtStuID.ImeMode = ImeMode.NoControl;
            txtStuID.Location = new Point(55, 16);
            txtStuID.Name = "txtStuID";
            txtStuID.ReadOnly = true;
            txtStuID.Size = new Size(121, 23);
            txtStuID.TabIndex = 41;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(17, 19);
            label1.Name = "label1";
            label1.Size = new Size(32, 17);
            label1.TabIndex = 40;
            label1.Text = "学号";
            // 
            // btnDelete
            // 
            btnDelete.Location = new Point(346, 267);
            btnDelete.Name = "btnDelete";
            btnDelete.Size = new Size(75, 23);
            btnDelete.TabIndex = 41;
            btnDelete.Text = "删除";
            btnDelete.UseVisualStyleBackColor = true;
            btnDelete.Click += btnDelete_Click;
            // 
            // groupBox1
            // 
            groupBox1.Controls.Add(btnSearch);
            groupBox1.Controls.Add(txtSearch);
            groupBox1.Controls.Add(label18);
            groupBox1.Location = new Point(23, 12);
            groupBox1.Name = "groupBox1";
            groupBox1.Size = new Size(715, 62);
            groupBox1.TabIndex = 56;
            groupBox1.TabStop = false;
            // 
            // btnSearch
            // 
            btnSearch.Location = new Point(520, 22);
            btnSearch.Name = "btnSearch";
            btnSearch.Size = new Size(75, 23);
            btnSearch.TabIndex = 57;
            btnSearch.Text = "查找";
            btnSearch.UseVisualStyleBackColor = true;
            btnSearch.Click += btnSearch_Click;
            // 
            // txtSearch
            // 
            txtSearch.Location = new Point(161, 22);
            txtSearch.Name = "txtSearch";
            txtSearch.Size = new Size(282, 23);
            txtSearch.TabIndex = 41;
            // 
            // label18
            // 
            label18.AutoSize = true;
            label18.Location = new Point(42, 25);
            label18.Name = "label18";
            label18.Size = new Size(104, 17);
            label18.TabIndex = 40;
            label18.Text = "请输入学生学号：";
            // 
            // EditStudent
            // 
            AutoScaleDimensions = new SizeF(7F, 17F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(759, 312);
            Controls.Add(groupBox1);
            Controls.Add(btnDelete);
            Controls.Add(btnCancel);
            Controls.Add(btnEdit);
            Controls.Add(groupBox2);
            Name = "EditStudent";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "编辑学生信息";
            Load += EditStudent_Load;
            Shown += EditStudent_Shown;
            groupBox2.ResumeLayout(false);
            groupBox2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)numAge).EndInit();
            groupBox1.ResumeLayout(false);
            groupBox1.PerformLayout();
            ResumeLayout(false);
        }

        #endregion
        private Button btnCancel;
        private Button btnEdit;
        private GroupBox groupBox2;
        private RadioButton rbtFemal;
        private RadioButton rbtMale;
        private TextBox txtLocation;
        private Label label8;
        private ComboBox comClass;
        private Label label7;
        private ComboBox comDepart;
        private Label label6;
        private NumericUpDown numAge;
        private Label label5;
        private ComboBox comPolitics;
        private Label label4;
        private Label label3;
        private TextBox txtName;
        private Label label2;
        private TextBox txtStuID;
        private Label label1;
        private Button btnDelete;
        private GroupBox groupBox1;
        private Button btnSearch;
        private TextBox txtSearch;
        private Label label18;
    }
}