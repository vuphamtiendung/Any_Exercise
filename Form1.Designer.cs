namespace Any09
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
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.txtStudentRank = new System.Windows.Forms.TextBox();
            this.txtMediumScore = new System.Windows.Forms.TextBox();
            this.txtDepartmentName = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.txtClassCode = new System.Windows.Forms.TextBox();
            this.txtStudentName = new System.Windows.Forms.TextBox();
            this.txtStudentCode = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.btnScoreMin = new System.Windows.Forms.Button();
            this.btnScoreMax = new System.Windows.Forms.Button();
            this.btnOrderbyDescending = new System.Windows.Forms.Button();
            this.btnOrderby = new System.Windows.Forms.Button();
            this.btnScholarship = new System.Windows.Forms.Button();
            this.btnAdd = new System.Windows.Forms.Button();
            this.btnFindCode = new System.Windows.Forms.Button();
            this.txtFindCode = new System.Windows.Forms.TextBox();
            this.label7 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.dgvListStudent = new System.Windows.Forms.DataGridView();
            this.label9 = new System.Windows.Forms.Label();
            this.dgvListTask = new System.Windows.Forms.DataGridView();
            this.groupBox1.SuspendLayout();
            this.groupBox2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvListStudent)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvListTask)).BeginInit();
            this.SuspendLayout();
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.txtStudentRank);
            this.groupBox1.Controls.Add(this.txtMediumScore);
            this.groupBox1.Controls.Add(this.txtDepartmentName);
            this.groupBox1.Controls.Add(this.label6);
            this.groupBox1.Controls.Add(this.label5);
            this.groupBox1.Controls.Add(this.label4);
            this.groupBox1.Controls.Add(this.txtClassCode);
            this.groupBox1.Controls.Add(this.txtStudentName);
            this.groupBox1.Controls.Add(this.txtStudentCode);
            this.groupBox1.Controls.Add(this.label3);
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox1.Location = new System.Drawing.Point(12, 12);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(847, 113);
            this.groupBox1.TabIndex = 0;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Nhập thông tin sinh viên";
            // 
            // txtStudentRank
            // 
            this.txtStudentRank.Location = new System.Drawing.Point(607, 82);
            this.txtStudentRank.Name = "txtStudentRank";
            this.txtStudentRank.Size = new System.Drawing.Size(221, 22);
            this.txtStudentRank.TabIndex = 11;
            // 
            // txtMediumScore
            // 
            this.txtMediumScore.Location = new System.Drawing.Point(607, 51);
            this.txtMediumScore.Name = "txtMediumScore";
            this.txtMediumScore.Size = new System.Drawing.Size(221, 22);
            this.txtMediumScore.TabIndex = 10;
            // 
            // txtDepartmentName
            // 
            this.txtDepartmentName.Location = new System.Drawing.Point(607, 21);
            this.txtDepartmentName.Name = "txtDepartmentName";
            this.txtDepartmentName.Size = new System.Drawing.Size(221, 22);
            this.txtDepartmentName.TabIndex = 9;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(492, 85);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(56, 16);
            this.label6.TabIndex = 8;
            this.label6.Text = "Xếp loại";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(492, 54);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(98, 16);
            this.label5.TabIndex = 7;
            this.label5.Text = "Điểm trung bình";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(489, 24);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(93, 16);
            this.label4.TabIndex = 6;
            this.label4.Text = "Tên khoa/viện";
            // 
            // txtClassCode
            // 
            this.txtClassCode.Location = new System.Drawing.Point(125, 82);
            this.txtClassCode.Name = "txtClassCode";
            this.txtClassCode.Size = new System.Drawing.Size(221, 22);
            this.txtClassCode.TabIndex = 5;
            // 
            // txtStudentName
            // 
            this.txtStudentName.Location = new System.Drawing.Point(125, 51);
            this.txtStudentName.Name = "txtStudentName";
            this.txtStudentName.Size = new System.Drawing.Size(221, 22);
            this.txtStudentName.TabIndex = 4;
            // 
            // txtStudentCode
            // 
            this.txtStudentCode.Location = new System.Drawing.Point(125, 21);
            this.txtStudentCode.Name = "txtStudentCode";
            this.txtStudentCode.Size = new System.Drawing.Size(221, 22);
            this.txtStudentCode.TabIndex = 3;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(21, 85);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(48, 16);
            this.label3.TabIndex = 2;
            this.label3.Text = "Mã lớp";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.label2.Location = new System.Drawing.Point(21, 54);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(86, 16);
            this.label2.TabIndex = 1;
            this.label2.Text = "Tên sinh viên";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(21, 24);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(81, 16);
            this.label1.TabIndex = 0;
            this.label1.Text = "Mã sinh viên";
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.btnScoreMin);
            this.groupBox2.Controls.Add(this.btnScoreMax);
            this.groupBox2.Controls.Add(this.btnOrderbyDescending);
            this.groupBox2.Controls.Add(this.btnOrderby);
            this.groupBox2.Controls.Add(this.btnScholarship);
            this.groupBox2.Controls.Add(this.btnAdd);
            this.groupBox2.Controls.Add(this.btnFindCode);
            this.groupBox2.Controls.Add(this.txtFindCode);
            this.groupBox2.Controls.Add(this.label7);
            this.groupBox2.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox2.Location = new System.Drawing.Point(12, 131);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(847, 101);
            this.groupBox2.TabIndex = 1;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Tác vụ khác";
            // 
            // btnScoreMin
            // 
            this.btnScoreMin.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btnScoreMin.Location = new System.Drawing.Point(685, 59);
            this.btnScoreMin.Name = "btnScoreMin";
            this.btnScoreMin.Size = new System.Drawing.Size(143, 36);
            this.btnScoreMin.TabIndex = 2;
            this.btnScoreMin.Text = "Điểm thấp nhất";
            this.btnScoreMin.UseVisualStyleBackColor = true;
            this.btnScoreMin.Click += new System.EventHandler(this.btnScoreMin_Click);
            // 
            // btnScoreMax
            // 
            this.btnScoreMax.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btnScoreMax.Location = new System.Drawing.Point(520, 58);
            this.btnScoreMax.Name = "btnScoreMax";
            this.btnScoreMax.Size = new System.Drawing.Size(143, 36);
            this.btnScoreMax.TabIndex = 2;
            this.btnScoreMax.Text = "Điểm cao nhất";
            this.btnScoreMax.UseVisualStyleBackColor = true;
            this.btnScoreMax.Click += new System.EventHandler(this.btnScoreMax_Click);
            // 
            // btnOrderbyDescending
            // 
            this.btnOrderbyDescending.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btnOrderbyDescending.Location = new System.Drawing.Point(354, 59);
            this.btnOrderbyDescending.Name = "btnOrderbyDescending";
            this.btnOrderbyDescending.Size = new System.Drawing.Size(143, 34);
            this.btnOrderbyDescending.TabIndex = 2;
            this.btnOrderbyDescending.Text = "Sắp xếp giảm";
            this.btnOrderbyDescending.UseVisualStyleBackColor = true;
            this.btnOrderbyDescending.Click += new System.EventHandler(this.btnOrderbyDescending_Click);
            // 
            // btnOrderby
            // 
            this.btnOrderby.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btnOrderby.Location = new System.Drawing.Point(190, 59);
            this.btnOrderby.Name = "btnOrderby";
            this.btnOrderby.Size = new System.Drawing.Size(143, 34);
            this.btnOrderby.TabIndex = 5;
            this.btnOrderby.Text = "Sắp xếp tăng";
            this.btnOrderby.UseVisualStyleBackColor = true;
            this.btnOrderby.Click += new System.EventHandler(this.btnOrderby_Click);
            // 
            // btnScholarship
            // 
            this.btnScholarship.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btnScholarship.Location = new System.Drawing.Point(24, 59);
            this.btnScholarship.Name = "btnScholarship";
            this.btnScholarship.Size = new System.Drawing.Size(143, 34);
            this.btnScholarship.TabIndex = 4;
            this.btnScholarship.Text = "Học bổng";
            this.btnScholarship.UseVisualStyleBackColor = true;
            this.btnScholarship.Click += new System.EventHandler(this.btnScholarship_Click);
            // 
            // btnAdd
            // 
            this.btnAdd.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btnAdd.Location = new System.Drawing.Point(24, 19);
            this.btnAdd.Name = "btnAdd";
            this.btnAdd.Size = new System.Drawing.Size(143, 34);
            this.btnAdd.TabIndex = 3;
            this.btnAdd.Text = "Thêm sinh viên";
            this.btnAdd.UseVisualStyleBackColor = true;
            this.btnAdd.Click += new System.EventHandler(this.btnAdd_Click);
            // 
            // btnFindCode
            // 
            this.btnFindCode.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btnFindCode.Location = new System.Drawing.Point(685, 19);
            this.btnFindCode.Name = "btnFindCode";
            this.btnFindCode.Size = new System.Drawing.Size(143, 34);
            this.btnFindCode.TabIndex = 2;
            this.btnFindCode.Text = "Tìm";
            this.btnFindCode.UseVisualStyleBackColor = true;
            this.btnFindCode.Click += new System.EventHandler(this.btnFindCode_Click);
            // 
            // txtFindCode
            // 
            this.txtFindCode.Location = new System.Drawing.Point(410, 25);
            this.txtFindCode.Name = "txtFindCode";
            this.txtFindCode.Size = new System.Drawing.Size(257, 22);
            this.txtFindCode.TabIndex = 1;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(287, 28);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(107, 16);
            this.label7.TabIndex = 0;
            this.label7.Text = "Tìm mã sinh viên";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label8.Location = new System.Drawing.Point(12, 237);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(126, 16);
            this.label8.TabIndex = 2;
            this.label8.Text = "Danh sách sinh viên";
            // 
            // dgvListStudent
            // 
            this.dgvListStudent.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dgvListStudent.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvListStudent.Location = new System.Drawing.Point(15, 256);
            this.dgvListStudent.Name = "dgvListStudent";
            this.dgvListStudent.Size = new System.Drawing.Size(844, 227);
            this.dgvListStudent.TabIndex = 3;
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label9.Location = new System.Drawing.Point(12, 492);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(186, 16);
            this.label9.TabIndex = 4;
            this.label9.Text = "Dữ liệu sau khi thực hiện tác vụ";
            // 
            // dgvListTask
            // 
            this.dgvListTask.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dgvListTask.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvListTask.Location = new System.Drawing.Point(15, 511);
            this.dgvListTask.Name = "dgvListTask";
            this.dgvListTask.Size = new System.Drawing.Size(844, 212);
            this.dgvListTask.TabIndex = 5;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(871, 735);
            this.Controls.Add(this.dgvListTask);
            this.Controls.Add(this.label9);
            this.Controls.Add(this.dgvListStudent);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.groupBox1);
            this.Name = "Form1";
            this.Text = "Quản lý thông tin sinh viên";
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvListStudent)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvListTask)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.TextBox txtStudentRank;
        private System.Windows.Forms.TextBox txtMediumScore;
        private System.Windows.Forms.TextBox txtDepartmentName;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox txtClassCode;
        private System.Windows.Forms.TextBox txtStudentName;
        private System.Windows.Forms.TextBox txtStudentCode;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.Button btnScoreMin;
        private System.Windows.Forms.Button btnScoreMax;
        private System.Windows.Forms.Button btnOrderbyDescending;
        private System.Windows.Forms.Button btnOrderby;
        private System.Windows.Forms.Button btnScholarship;
        private System.Windows.Forms.Button btnAdd;
        private System.Windows.Forms.Button btnFindCode;
        private System.Windows.Forms.TextBox txtFindCode;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.DataGridView dgvListStudent;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.DataGridView dgvListTask;
    }
}

