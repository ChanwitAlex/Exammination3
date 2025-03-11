namespace Exammination3
{
    partial class Form1
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
            btnAddstudent = new Button();
            btnShowStuent = new Button();
            btnShowAll = new Button();
            label1 = new Label();
            tbGrade = new TextBox();
            tbMajor = new TextBox();
            tbName = new TextBox();
            tbID = new TextBox();
            label2 = new Label();
            label3 = new Label();
            label4 = new Label();
            label5 = new Label();
            cmbAdvisor = new ComboBox();
            groupBox1 = new GroupBox();
            label15 = new Label();
            label6 = new Label();
            lbAdvisor = new Label();
            label7 = new Label();
            lbMajor = new Label();
            label8 = new Label();
            lbGrade = new Label();
            label9 = new Label();
            lbName = new Label();
            lbID = new Label();
            lstStudent = new ListBox();
            groupBox1.SuspendLayout();
            SuspendLayout();
            // 
            // btnAddstudent
            // 
            btnAddstudent.Location = new Point(40, 226);
            btnAddstudent.Name = "btnAddstudent";
            btnAddstudent.Size = new Size(104, 23);
            btnAddstudent.TabIndex = 0;
            btnAddstudent.Text = "AddStudent";
            btnAddstudent.UseVisualStyleBackColor = true;
            btnAddstudent.Click += btnAddstudent_Click;
            // 
            // btnShowStuent
            // 
            btnShowStuent.Location = new Point(506, 210);
            btnShowStuent.Name = "btnShowStuent";
            btnShowStuent.Size = new Size(101, 23);
            btnShowStuent.TabIndex = 1;
            btnShowStuent.Text = "ShowStudent";
            btnShowStuent.UseVisualStyleBackColor = true;
            btnShowStuent.Click += btnShowStuent_Click;
            // 
            // btnShowAll
            // 
            btnShowAll.Location = new Point(477, 277);
            btnShowAll.Name = "btnShowAll";
            btnShowAll.Size = new Size(130, 135);
            btnShowAll.TabIndex = 2;
            btnShowAll.Text = "ShoeAll";
            btnShowAll.UseVisualStyleBackColor = true;
            btnShowAll.Click += btnShowAll_Click;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(12, 39);
            label1.Name = "label1";
            label1.Size = new Size(18, 15);
            label1.TabIndex = 3;
            label1.Text = "ID";
            // 
            // tbGrade
            // 
            tbGrade.Location = new Point(66, 135);
            tbGrade.Name = "tbGrade";
            tbGrade.Size = new Size(121, 23);
            tbGrade.TabIndex = 5;
            // 
            // tbMajor
            // 
            tbMajor.Location = new Point(66, 106);
            tbMajor.Name = "tbMajor";
            tbMajor.Size = new Size(121, 23);
            tbMajor.TabIndex = 6;
            // 
            // tbName
            // 
            tbName.Location = new Point(66, 69);
            tbName.Name = "tbName";
            tbName.Size = new Size(121, 23);
            tbName.TabIndex = 7;
            // 
            // tbID
            // 
            tbID.Location = new Point(66, 40);
            tbID.Name = "tbID";
            tbID.Size = new Size(121, 23);
            tbID.TabIndex = 8;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(12, 69);
            label2.Name = "label2";
            label2.Size = new Size(39, 15);
            label2.TabIndex = 9;
            label2.Text = "Name";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(12, 106);
            label3.Name = "label3";
            label3.Size = new Size(38, 15);
            label3.TabIndex = 10;
            label3.Text = "Major";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(12, 143);
            label4.Name = "label4";
            label4.Size = new Size(38, 15);
            label4.TabIndex = 11;
            label4.Text = "Grade";
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Location = new Point(4, 192);
            label5.Name = "label5";
            label5.Size = new Size(47, 15);
            label5.TabIndex = 12;
            label5.Text = "Advisor";
            label5.Click += label5_Click;
            // 
            // cmbAdvisor
            // 
            cmbAdvisor.FormattingEnabled = true;
            cmbAdvisor.Location = new Point(66, 184);
            cmbAdvisor.Name = "cmbAdvisor";
            cmbAdvisor.Size = new Size(121, 23);
            cmbAdvisor.TabIndex = 13;
            // 
            // groupBox1
            // 
            groupBox1.Controls.Add(label15);
            groupBox1.Controls.Add(label6);
            groupBox1.Controls.Add(lbAdvisor);
            groupBox1.Controls.Add(label7);
            groupBox1.Controls.Add(lbMajor);
            groupBox1.Controls.Add(label8);
            groupBox1.Controls.Add(lbGrade);
            groupBox1.Controls.Add(label9);
            groupBox1.Controls.Add(lbName);
            groupBox1.Controls.Add(lbID);
            groupBox1.Location = new Point(458, 23);
            groupBox1.Name = "groupBox1";
            groupBox1.Size = new Size(233, 171);
            groupBox1.TabIndex = 14;
            groupBox1.TabStop = false;
            // 
            // label15
            // 
            label15.AutoSize = true;
            label15.Location = new Point(47, 24);
            label15.Name = "label15";
            label15.Size = new Size(18, 15);
            label15.TabIndex = 25;
            label15.Text = "ID";
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Location = new Point(47, 53);
            label6.Name = "label6";
            label6.Size = new Size(39, 15);
            label6.TabIndex = 16;
            label6.Text = "Name";
            // 
            // lbAdvisor
            // 
            lbAdvisor.AutoSize = true;
            lbAdvisor.Location = new Point(159, 142);
            lbAdvisor.Name = "lbAdvisor";
            lbAdvisor.Size = new Size(18, 15);
            lbAdvisor.TabIndex = 24;
            lbAdvisor.Text = "ID";
            // 
            // label7
            // 
            label7.AutoSize = true;
            label7.Location = new Point(47, 82);
            label7.Name = "label7";
            label7.Size = new Size(38, 15);
            label7.TabIndex = 17;
            label7.Text = "Major";
            // 
            // lbMajor
            // 
            lbMajor.AutoSize = true;
            lbMajor.Location = new Point(159, 85);
            lbMajor.Name = "lbMajor";
            lbMajor.Size = new Size(18, 15);
            lbMajor.TabIndex = 23;
            lbMajor.Text = "ID";
            // 
            // label8
            // 
            label8.AutoSize = true;
            label8.Location = new Point(47, 114);
            label8.Name = "label8";
            label8.Size = new Size(38, 15);
            label8.TabIndex = 18;
            label8.Text = "Grade";
            // 
            // lbGrade
            // 
            lbGrade.AutoSize = true;
            lbGrade.Location = new Point(159, 119);
            lbGrade.Name = "lbGrade";
            lbGrade.Size = new Size(18, 15);
            lbGrade.TabIndex = 22;
            lbGrade.Text = "ID";
            // 
            // label9
            // 
            label9.AutoSize = true;
            label9.Location = new Point(47, 142);
            label9.Name = "label9";
            label9.Size = new Size(47, 15);
            label9.TabIndex = 19;
            label9.Text = "Advisor";
            // 
            // lbName
            // 
            lbName.AutoSize = true;
            lbName.Location = new Point(159, 53);
            lbName.Name = "lbName";
            lbName.Size = new Size(18, 15);
            lbName.TabIndex = 21;
            lbName.Text = "ID";
            // 
            // lbID
            // 
            lbID.AutoSize = true;
            lbID.Location = new Point(159, 24);
            lbID.Name = "lbID";
            lbID.Size = new Size(18, 15);
            lbID.TabIndex = 20;
            lbID.Text = "ID";
            // 
            // lstStudent
            // 
            lstStudent.FormattingEnabled = true;
            lstStudent.ItemHeight = 15;
            lstStudent.Location = new Point(12, 269);
            lstStudent.Name = "lstStudent";
            lstStudent.Size = new Size(339, 169);
            lstStudent.TabIndex = 15;
            lstStudent.SelectedIndexChanged += lstStudent_SelectedIndexChanged;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(lstStudent);
            Controls.Add(groupBox1);
            Controls.Add(cmbAdvisor);
            Controls.Add(label5);
            Controls.Add(label4);
            Controls.Add(label3);
            Controls.Add(label2);
            Controls.Add(tbID);
            Controls.Add(tbName);
            Controls.Add(tbMajor);
            Controls.Add(tbGrade);
            Controls.Add(label1);
            Controls.Add(btnShowAll);
            Controls.Add(btnShowStuent);
            Controls.Add(btnAddstudent);
            Name = "Form1";
            Text = "Form1";
            groupBox1.ResumeLayout(false);
            groupBox1.PerformLayout();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Button btnAddstudent;
        private Button btnShowStuent;
        private Button btnShowAll;
        private Label label1;
        private TextBox tbGrade;
        private TextBox tbMajor;
        private TextBox tbName;
        private TextBox tbID;
        private Label label2;
        private Label label3;
        private Label label4;
        private Label label5;
        private ComboBox cmbAdvisor;
        private GroupBox groupBox1;
        private ListBox lstStudent;
        private Label label6;
        private Label label7;
        private Label label8;
        private Label label9;
        private Label lbID;
        private Label lbName;
        private Label lbGrade;
        private Label lbMajor;
        private Label lbAdvisor;
        private Label label15;
    }
}
