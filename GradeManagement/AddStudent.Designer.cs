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
            comPolitics = new ComboBox();
            label5 = new Label();
            numAge = new NumericUpDown();
            label6 = new Label();
            comDepart = new ComboBox();
            label7 = new Label();
            comClass = new ComboBox();
            label8 = new Label();
            txtLocation = new TextBox();
            btnConfirm = new Button();
            btnCancel = new Button();
            groupBox2 = new GroupBox();
            ((System.ComponentModel.ISupportInitialize)numAge).BeginInit();
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
            // comPolitics
            // 
            comPolitics.DropDownStyle = ComboBoxStyle.DropDownList;
            comPolitics.FormattingEnabled = true;
            comPolitics.Items.AddRange(new object[] { "中共党员", "共青团员", "学生", "其他" });
            comPolitics.Location = new Point(100, 91);
            comPolitics.Name = "comPolitics";
            comPolitics.Size = new Size(153, 25);
            comPolitics.TabIndex = 8;
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
            // btnConfirm
            // 
            btnConfirm.Location = new Point(38, 274);
            btnConfirm.Name = "btnConfirm";
            btnConfirm.Size = new Size(75, 23);
            btnConfirm.TabIndex = 19;
            btnConfirm.Text = "确定";
            btnConfirm.UseVisualStyleBackColor = true;
            btnConfirm.Click += btnConfirm_Click;
            // 
            // btnCancel
            // 
            btnCancel.Location = new Point(405, 274);
            btnCancel.Name = "btnCancel";
            btnCancel.Size = new Size(75, 23);
            btnCancel.TabIndex = 20;
            btnCancel.Text = "取消";
            btnCancel.UseVisualStyleBackColor = true;
            btnCancel.Click += btnCancel_Click;
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
            ClientSize = new Size(526, 321);
            Controls.Add(groupBox2);
            Controls.Add(btnCancel);
            Controls.Add(btnConfirm);
            Controls.Add(txtLocation);
            Controls.Add(label8);
            Controls.Add(comClass);
            Controls.Add(label7);
            Controls.Add(comDepart);
            Controls.Add(label6);
            Controls.Add(numAge);
            Controls.Add(label5);
            Controls.Add(comPolitics);
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
        private ComboBox comPolitics;
        private Label label5;
        private NumericUpDown numAge;
        private Label label6;
        private ComboBox comDepart;
        private Label label7;
        private ComboBox comClass;
        private Label label8;
        private TextBox txtLocation;
        private Button btnConfirm;
        private Button btnCancel;
        private GroupBox groupBox2;
    }
}