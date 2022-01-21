namespace Menu.PAL
{
    partial class UpdateRecord
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
            this.cmbRegNo = new System.Windows.Forms.ComboBox();
            this.btnDeleteRecord = new System.Windows.Forms.Button();
            this.txtFinalMarks = new System.Windows.Forms.TextBox();
            this.txtMidMarks = new System.Windows.Forms.TextBox();
            this.lblFinalMarks = new System.Windows.Forms.Label();
            this.txtQuizzes = new System.Windows.Forms.TextBox();
            this.lblMidsMarks = new System.Windows.Forms.Label();
            this.txtStudentName = new System.Windows.Forms.TextBox();
            this.lblSeLectRegNo = new System.Windows.Forms.Label();
            this.lblQuizzes = new System.Windows.Forms.Label();
            this.lblAddRecord = new System.Windows.Forms.Label();
            this.lblStudentName = new System.Windows.Forms.Label();
            this.lblRegNo = new System.Windows.Forms.Label();
            this.txtRegNo = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // cmbRegNo
            // 
            this.cmbRegNo.FormattingEnabled = true;
            this.cmbRegNo.Location = new System.Drawing.Point(195, 70);
            this.cmbRegNo.Name = "cmbRegNo";
            this.cmbRegNo.Size = new System.Drawing.Size(170, 21);
            this.cmbRegNo.TabIndex = 9;
            this.cmbRegNo.SelectedIndexChanged += new System.EventHandler(this.cmbRegNo_SelectedIndexChanged);
            // 
            // btnDeleteRecord
            // 
            this.btnDeleteRecord.Font = new System.Drawing.Font("Microsoft Tai Le", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnDeleteRecord.ForeColor = System.Drawing.Color.Red;
            this.btnDeleteRecord.Location = new System.Drawing.Point(41, 294);
            this.btnDeleteRecord.Name = "btnDeleteRecord";
            this.btnDeleteRecord.Size = new System.Drawing.Size(324, 47);
            this.btnDeleteRecord.TabIndex = 16;
            this.btnDeleteRecord.Text = "UPDATE CHANGES";
            this.btnDeleteRecord.UseVisualStyleBackColor = true;
            this.btnDeleteRecord.Click += new System.EventHandler(this.btnDeleteRecord_Click);
            // 
            // txtFinalMarks
            // 
            this.txtFinalMarks.Location = new System.Drawing.Point(195, 256);
            this.txtFinalMarks.Name = "txtFinalMarks";
            this.txtFinalMarks.Size = new System.Drawing.Size(170, 20);
            this.txtFinalMarks.TabIndex = 14;
            // 
            // txtMidMarks
            // 
            this.txtMidMarks.Location = new System.Drawing.Point(195, 219);
            this.txtMidMarks.Name = "txtMidMarks";
            this.txtMidMarks.Size = new System.Drawing.Size(170, 20);
            this.txtMidMarks.TabIndex = 12;
            // 
            // lblFinalMarks
            // 
            this.lblFinalMarks.AutoSize = true;
            this.lblFinalMarks.Font = new System.Drawing.Font("Microsoft Tai Le", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblFinalMarks.ForeColor = System.Drawing.Color.Red;
            this.lblFinalMarks.Location = new System.Drawing.Point(37, 255);
            this.lblFinalMarks.Name = "lblFinalMarks";
            this.lblFinalMarks.Size = new System.Drawing.Size(104, 21);
            this.lblFinalMarks.TabIndex = 13;
            this.lblFinalMarks.Text = "Finals Marks";
            // 
            // txtQuizzes
            // 
            this.txtQuizzes.Location = new System.Drawing.Point(195, 182);
            this.txtQuizzes.Name = "txtQuizzes";
            this.txtQuizzes.Size = new System.Drawing.Size(170, 20);
            this.txtQuizzes.TabIndex = 11;
            // 
            // lblMidsMarks
            // 
            this.lblMidsMarks.AutoSize = true;
            this.lblMidsMarks.Font = new System.Drawing.Font("Microsoft Tai Le", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblMidsMarks.ForeColor = System.Drawing.Color.Red;
            this.lblMidsMarks.Location = new System.Drawing.Point(37, 218);
            this.lblMidsMarks.Name = "lblMidsMarks";
            this.lblMidsMarks.Size = new System.Drawing.Size(97, 21);
            this.lblMidsMarks.TabIndex = 15;
            this.lblMidsMarks.Text = "Mids Marks";
            // 
            // txtStudentName
            // 
            this.txtStudentName.Location = new System.Drawing.Point(195, 145);
            this.txtStudentName.Name = "txtStudentName";
            this.txtStudentName.Size = new System.Drawing.Size(170, 20);
            this.txtStudentName.TabIndex = 10;
            // 
            // lblSeLectRegNo
            // 
            this.lblSeLectRegNo.AutoSize = true;
            this.lblSeLectRegNo.Font = new System.Drawing.Font("Microsoft Tai Le", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblSeLectRegNo.ForeColor = System.Drawing.Color.Red;
            this.lblSeLectRegNo.Location = new System.Drawing.Point(37, 70);
            this.lblSeLectRegNo.Name = "lblSeLectRegNo";
            this.lblSeLectRegNo.Size = new System.Drawing.Size(143, 21);
            this.lblSeLectRegNo.TabIndex = 17;
            this.lblSeLectRegNo.Text = "Select By Reg No.";
            // 
            // lblQuizzes
            // 
            this.lblQuizzes.AutoSize = true;
            this.lblQuizzes.Font = new System.Drawing.Font("Microsoft Tai Le", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblQuizzes.ForeColor = System.Drawing.Color.Red;
            this.lblQuizzes.Location = new System.Drawing.Point(37, 181);
            this.lblQuizzes.Name = "lblQuizzes";
            this.lblQuizzes.Size = new System.Drawing.Size(145, 21);
            this.lblQuizzes.TabIndex = 18;
            this.lblQuizzes.Text = "Total of 5 Quizzes";
            // 
            // lblAddRecord
            // 
            this.lblAddRecord.AutoSize = true;
            this.lblAddRecord.Font = new System.Drawing.Font("Microsoft Tai Le", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblAddRecord.ForeColor = System.Drawing.Color.Red;
            this.lblAddRecord.Location = new System.Drawing.Point(58, 22);
            this.lblAddRecord.Name = "lblAddRecord";
            this.lblAddRecord.Size = new System.Drawing.Size(282, 27);
            this.lblAddRecord.TabIndex = 19;
            this.lblAddRecord.Text = "UPDATE STUDENT RECORD";
            // 
            // lblStudentName
            // 
            this.lblStudentName.AutoSize = true;
            this.lblStudentName.Font = new System.Drawing.Font("Microsoft Tai Le", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblStudentName.ForeColor = System.Drawing.Color.Red;
            this.lblStudentName.Location = new System.Drawing.Point(37, 144);
            this.lblStudentName.Name = "lblStudentName";
            this.lblStudentName.Size = new System.Drawing.Size(120, 21);
            this.lblStudentName.TabIndex = 20;
            this.lblStudentName.Text = "Student Name";
            // 
            // lblRegNo
            // 
            this.lblRegNo.AutoSize = true;
            this.lblRegNo.Font = new System.Drawing.Font("Microsoft Tai Le", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblRegNo.ForeColor = System.Drawing.Color.Red;
            this.lblRegNo.Location = new System.Drawing.Point(37, 107);
            this.lblRegNo.Name = "lblRegNo";
            this.lblRegNo.Size = new System.Drawing.Size(70, 21);
            this.lblRegNo.TabIndex = 17;
            this.lblRegNo.Text = "Reg No.";
            // 
            // txtRegNo
            // 
            this.txtRegNo.Location = new System.Drawing.Point(195, 108);
            this.txtRegNo.Name = "txtRegNo";
            this.txtRegNo.Size = new System.Drawing.Size(170, 20);
            this.txtRegNo.TabIndex = 10;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft YaHei", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.Red;
            this.label1.Location = new System.Drawing.Point(79, 356);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(261, 19);
            this.label1.TabIndex = 21;
            this.label1.Text = "Note: Changes Made Will Be Updated";
            // 
            // UpdateRecord
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(408, 395);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.cmbRegNo);
            this.Controls.Add(this.btnDeleteRecord);
            this.Controls.Add(this.txtFinalMarks);
            this.Controls.Add(this.txtMidMarks);
            this.Controls.Add(this.lblFinalMarks);
            this.Controls.Add(this.txtQuizzes);
            this.Controls.Add(this.lblMidsMarks);
            this.Controls.Add(this.txtRegNo);
            this.Controls.Add(this.txtStudentName);
            this.Controls.Add(this.lblRegNo);
            this.Controls.Add(this.lblSeLectRegNo);
            this.Controls.Add(this.lblQuizzes);
            this.Controls.Add(this.lblAddRecord);
            this.Controls.Add(this.lblStudentName);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "UpdateRecord";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "UpdateRecord";
            this.Load += new System.EventHandler(this.UpdateRecord_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ComboBox cmbRegNo;
        private System.Windows.Forms.Button btnDeleteRecord;
        private System.Windows.Forms.TextBox txtFinalMarks;
        private System.Windows.Forms.TextBox txtMidMarks;
        private System.Windows.Forms.Label lblFinalMarks;
        private System.Windows.Forms.TextBox txtQuizzes;
        private System.Windows.Forms.Label lblMidsMarks;
        private System.Windows.Forms.TextBox txtStudentName;
        private System.Windows.Forms.Label lblSeLectRegNo;
        private System.Windows.Forms.Label lblQuizzes;
        private System.Windows.Forms.Label lblAddRecord;
        private System.Windows.Forms.Label lblStudentName;
        private System.Windows.Forms.Label lblRegNo;
        private System.Windows.Forms.TextBox txtRegNo;
        private System.Windows.Forms.Label label1;
    }
}