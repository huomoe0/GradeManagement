namespace GradeManagement
{
    partial class AddStudent
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
            txtStuID = new TextBox();
            label2 = new Label();
            txtName = new TextBox();
            label3 = new Label();
            rbtMale = new RadioButton();
            rbtFemal = new RadioButton();
            label4 = new Label();
            comNation = new ComboBox();
            label5 = new Label();
            numAge = new NumericUpDown();
            label6 = new Label();
            comDepart = new ComboBox();
            label7 = new Label();
            comClass = new ComboBox();
            label8 = new Label();
            txtLocation = new TextBox();
            checkBox1 = new CheckBox();
            groupBox1 = new GroupBox();
            checkBox5 = new CheckBox();
            checkBox4 = new CheckBox();
            checkBox3 = new CheckBox();
            checkBox2 = new CheckBox();
            btnConfirm = new Button();
            btnCancel = new Button();
            btnClose = new Button();
            groupBox2 = new GroupBox();
            ((System.ComponentModel.ISupportInitialize)numAge).BeginInit();
            groupBox1.SuspendLayout();
            groupBox2.SuspendLayout();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(38, 35);
            label1.Name = "label1";
            label1.Size = new Size(32, 17);
            label1.TabIndex = 0;
            label1.Text = "学号";
            // 
            // txtStuID
            // 
            txtStuID.Location = new Point(76, 32);
            txtStuID.Name = "txtStuID";
            txtStuID.Size = new Size(121, 23);
            txtStuID.TabIndex = 1;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(221, 35);
            label2.Name = "label2";
            label2.Size = new Size(32, 17);
            label2.TabIndex = 2;
            label2.Text = "姓名";
            // 
            // txtName
            // 
            txtName.Location = new Point(259, 32);
            txtName.Name = "txtName";
            txtName.Size = new Size(100, 23);
            txtName.TabIndex = 3;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(365, 35);
            label3.Name = "label3";
            label3.Size = new Size(32, 17);
            label3.TabIndex = 4;
            label3.Text = "性别";
            // 
            // rbtMale
            // 
            rbtMale.AutoSize = true;
            rbtMale.Location = new Point(2, 16);
            rbtMale.Name = "rbtMale";
            rbtMale.Size = new Size(38, 21);
            rbtMale.TabIndex = 5;
            rbtMale.TabStop = true;
            rbtMale.Text = "男";
            rbtMale.UseVisualStyleBackColor = true;
            // 
            // rbtFemal
            // 
            rbtFemal.AutoSize = true;
            rbtFemal.Location = new Point(46, 16);
            rbtFemal.Name = "rbtFemal";
            rbtFemal.Size = new Size(38, 21);
            rbtFemal.TabIndex = 6;
            rbtFemal.TabStop = true;
            rbtFemal.Text = "女";
            rbtFemal.UseVisualStyleBackColor = true;
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(38, 94);
            label4.Name = "label4";
            label4.Size = new Size(56, 17);
            label4.TabIndex = 7;
            label4.Text = "政治面貌";
            // 
            // comNation
            // 
            comNation.DropDownStyle = ComboBoxStyle.DropDownList;
            comNation.FormattingEnabled = true;
            comNation.Items.AddRange(new object[] { "中共党员", "共青团员", "学生", "其他" });
            comNation.Location = new Point(100, 91);
            comNation.Name = "comNation";
            comNation.Size = new Size(153, 25);
            comNation.TabIndex = 8;
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Location = new Point(296, 95);
            label5.Name = "label5";
            label5.Size = new Size(32, 17);
            label5.TabIndex = 9;
            label5.Text = "年龄";
            // 
            // numAge
            // 
            numAge.Location = new Point(374, 93);
            numAge.Maximum = new decimal(new int[] { 30, 0, 0, 0 });
            numAge.Minimum = new decimal(new int[] { 14, 0, 0, 0 });
            numAge.Name = "numAge";
            numAge.Size = new Size(120, 23);
            numAge.TabIndex = 10;
            numAge.Value = new decimal(new int[] { 14, 0, 0, 0 });
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Location = new Point(38, 163);
            label6.Name = "label6";
            label6.Size = new Size(32, 17);
            label6.TabIndex = 11;
            label6.Text = "院系";
            // 
            // comDepart
            // 
            comDepart.DropDownStyle = ComboBoxStyle.DropDownList;
            comDepart.FormattingEnabled = true;
            comDepart.Location = new Point(76, 160);
            comDepart.Name = "comDepart";
            comDepart.Size = new Size(196, 25);
            comDepart.TabIndex = 12;
            comDepart.SelectedValueChanged += comDepart_SelectedValueChanged;
            // 
            // label7
            // 
            label7.AutoSize = true;
            label7.Location = new Point(278, 166);
            label7.Name = "label7";
            label7.Size = new Size(32, 17);
            label7.TabIndex = 13;
            label7.Text = "班级";
            // 
            // comClass
            // 
            comClass.DropDownStyle = ComboBoxStyle.DropDownList;
            comClass.FormattingEnabled = true;
            comClass.Location = new Point(316, 163);
            comClass.Name = "comClass";
            comClass.Size = new Size(178, 25);
            comClass.TabIndex = 14;
            // 
            // label8
            // 
            label8.AutoSize = true;
            label8.Location = new Point(38, 222);
            label8.Name = "label8";
            label8.Size = new Size(32, 17);
            label8.TabIndex = 15;
            label8.Text = "籍贯";
            // 
            // txtLocation
            // 
            txtLocation.Location = new Point(76, 219);
            txtLocation.Name = "txtLocation";
            txtLocation.Size = new Size(418, 23);
            txtLocation.TabIndex = 16;
            // 
            // checkBox1
            // 
            checkBox1.AutoSize = true;
            checkBox1.Location = new Point(16, 44);
            checkBox1.Name = "checkBox1";
            checkBox1.Size = new Size(51, 21);
            checkBox1.TabIndex = 17;
            checkBox1.Text = "看书";
            checkBox1.UseVisualStyleBackColor = true;
            // 
            // groupBox1
            // 
            groupBox1.Controls.Add(checkBox5);
            groupBox1.Controls.Add(checkBox4);
            groupBox1.Controls.Add(checkBox3);
            groupBox1.Controls.Add(checkBox2);
            groupBox1.Controls.Add(checkBox1);
            groupBox1.Location = new Point(38, 267);
            groupBox1.Name = "groupBox1";
            groupBox1.Size = new Size(456, 100);
            groupBox1.TabIndex = 18;
            groupBox1.TabStop = false;
            groupBox1.Text = "兴趣和爱好";
            // 
            // checkBox5
            // 
            checkBox5.AutoSize = true;
            checkBox5.Location = new Point(398, 44);
            checkBox5.Name = "checkBox5";
            checkBox5.Size = new Size(51, 21);
            checkBox5.TabIndex = 21;
            checkBox5.Text = "其他";
            checkBox5.UseVisualStyleBackColor = true;
            // 
            // checkBox4
            // 
            checkBox4.AutoSize = true;
            checkBox4.Location = new Point(308, 44);
            checkBox4.Name = "checkBox4";
            checkBox4.Size = new Size(51, 21);
            checkBox4.TabIndex = 20;
            checkBox4.Text = "游戏";
            checkBox4.UseVisualStyleBackColor = true;
            // 
            // checkBox3
            // 
            checkBox3.AutoSize = true;
            checkBox3.Location = new Point(221, 44);
            checkBox3.Name = "checkBox3";
            checkBox3.Size = new Size(51, 21);
            checkBox3.TabIndex = 19;
            checkBox3.Text = "旅游";
            checkBox3.UseVisualStyleBackColor = true;
            // 
            // checkBox2
            // 
            checkBox2.AutoSize = true;
            checkBox2.Location = new Point(108, 44);
            checkBox2.Name = "checkBox2";
            checkBox2.Size = new Size(51, 21);
            checkBox2.TabIndex = 18;
            checkBox2.Text = "运动";
            checkBox2.UseVisualStyleBackColor = true;
            // 
            // btnConfirm
            // 
            btnConfirm.Location = new Point(54, 397);
            btnConfirm.Name = "btnConfirm";
            btnConfirm.Size = new Size(75, 23);
            btnConfirm.TabIndex = 19;
            btnConfirm.Text = "确定";
            btnConfirm.UseVisualStyleBackColor = true;
            btnConfirm.Click += btnConfirm_Click;
            // 
            // btnCancel
            // 
            btnCancel.Location = new Point(235, 397);
            btnCancel.Name = "btnCancel";
            btnCancel.Size = new Size(75, 23);
            btnCancel.TabIndex = 20;
            btnCancel.Text = "取消";
            btnCancel.UseVisualStyleBackColor = true;
            // 
            // btnClose
            // 
            btnClose.Location = new Point(403, 397);
            btnClose.Name = "btnClose";
            btnClose.Size = new Size(75, 23);
            btnClose.TabIndex = 21;
            btnClose.Text = "退出";
            btnClose.UseVisualStyleBackColor = true;
            // 
            // groupBox2
            // 
            groupBox2.Controls.Add(rbtMale);
            groupBox2.Controls.Add(rbtFemal);
            groupBox2.Location = new Point(403, 22);
            groupBox2.Name = "groupBox2";
            groupBox2.Size = new Size(91, 43);
            groupBox2.TabIndex = 22;
            groupBox2.TabStop = false;
            // 
            // AddStudent
            // 
            AutoScaleDimensions = new SizeF(7F, 17F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(526, 431);
            Controls.Add(groupBox2);
            Controls.Add(btnClose);
            Controls.Add(btnCancel);
            Controls.Add(btnConfirm);
            Controls.Add(groupBox1);
            Controls.Add(txtLocation);
            Controls.Add(label8);
            Controls.Add(comClass);
            Controls.Add(label7);
            Controls.Add(comDepart);
            Controls.Add(label6);
            Controls.Add(numAge);
            Controls.Add(label5);
            Controls.Add(comNation);
            Controls.Add(label4);
            Controls.Add(label3);
            Controls.Add(txtName);
            Controls.Add(label2);
            Controls.Add(txtStuID);
            Controls.Add(label1);
            MaximizeBox = false;
            Name = "AddStudent";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "添加学生信息";
            Load += AddStudent_Load;
            ((System.ComponentModel.ISupportInitialize)numAge).EndInit();
            groupBox1.ResumeLayout(false);
            groupBox1.PerformLayout();
            groupBox2.ResumeLayout(false);
            groupBox2.PerformLayout();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label1;
        private TextBox txtStuID;
        private Label label2;
        private TextBox txtName;
        private Label label3;
        private RadioButton rbtMale;
        private RadioButton rbtFemal;
        private Label label4;
        private ComboBox comNation;
        private Label label5;
        private NumericUpDown numAge;
        private Label label6;
        private ComboBox comDepart;
        private Label label7;
        private ComboBox comClass;
        private Label label8;
        private TextBox txtLocation;
        private CheckBox checkBox1;
        private GroupBox groupBox1;
        private CheckBox checkBox5;
        private CheckBox checkBox4;
        private CheckBox checkBox3;
        private CheckBox checkBox2;
        private Button btnConfirm;
        private Button btnCancel;
        private Button btnClose;
        private GroupBox groupBox2;
    }
}