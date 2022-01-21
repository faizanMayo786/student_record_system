namespace Menu.PAL
{
    partial class DeleteRecord
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
            this.btnDeleteRecord = new System.Windows.Forms.Button();
            this.txtFinalMarks = new System.Windows.Forms.TextBox();
            this.txtMidMarks = new System.Windows.Forms.TextBox();
            this.lblFinalMarks = new System.Windows.Forms.Label();
            this.txtQuizzes = new System.Windows.Forms.TextBox();
            this.lblMidsMarks = new System.Windows.Forms.Label();
            this.txtStudentName = new System.Windows.Forms.TextBox();
            this.lblRegNo = new System.Windows.Forms.Label();
            this.lblQuizzes = new System.Windows.Forms.Label();
            this.lblAddRecord = new System.Windows.Forms.Label();
            this.lblStudentName = new System.Windows.Forms.Label();
            this.cmbRegNo = new System.Windows.Forms.ComboBox();
            this.SuspendLayout();
            // 
            // btnDeleteRecord
            // 
            this.btnDeleteRecord.Font = new System.Drawing.Font("Microsoft Tai Le", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnDeleteRecord.ForeColor = System.Drawing.Color.Red;
            this.btnDeleteRecord.Location = new System.Drawing.Point(39, 291);
            this.btnDeleteRecord.Name = "btnDeleteRecord";
            this.btnDeleteRecord.Size = new System.Drawing.Size(324, 47);
            this.btnDeleteRecord.TabIndex = 5;
            this.btnDeleteRecord.Text = "DELETE NOW";
            this.btnDeleteRecord.UseVisualStyleBackColor = true;
            this.btnDeleteRecord.Click += new System.EventHandler(this.btnDeleteRecord_Click);
            // 
            // txtFinalMarks
            // 
            this.txtFinalMarks.Location = new System.Drawing.Point(193, 240);
            this.txtFinalMarks.Name = "txtFinalMarks";
            this.txtFinalMarks.Size = new System.Drawing.Size(170, 20);
            this.txtFinalMarks.TabIndex = 4;
            // 
            // txtMidMarks
            // 
            this.txtMidMarks.Location = new System.Drawing.Point(193, 205);
            this.txtMidMarks.Name = "txtMidMarks";
            this.txtMidMarks.Size = new System.Drawing.Size(170, 20);
            this.txtMidMarks.TabIndex = 3;
            // 
            // lblFinalMarks
            // 
            this.lblFinalMarks.AutoSize = true;
            this.lblFinalMarks.Font = new System.Drawing.Font("Microsoft Tai Le", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblFinalMarks.ForeColor = System.Drawing.Color.Red;
            this.lblFinalMarks.Location = new System.Drawing.Point(35, 240);
            this.lblFinalMarks.Name = "lblFinalMarks";
            this.lblFinalMarks.Size = new System.Drawing.Size(104, 21);
            this.lblFinalMarks.TabIndex = 3;
            this.lblFinalMarks.Text = "Finals Marks";
            // 
            // txtQuizzes
            // 
            this.txtQuizzes.Location = new System.Drawing.Point(193, 169);
            this.txtQuizzes.Name = "txtQuizzes";
            this.txtQuizzes.Size = new System.Drawing.Size(170, 20);
            this.txtQuizzes.TabIndex = 2;
            // 
            // lblMidsMarks
            // 
            this.lblMidsMarks.AutoSize = true;
            this.lblMidsMarks.Font = new System.Drawing.Font("Microsoft Tai Le", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblMidsMarks.ForeColor = System.Drawing.Color.Red;
            this.lblMidsMarks.Location = new System.Drawing.Point(35, 205);
            this.lblMidsMarks.Name = "lblMidsMarks";
            this.lblMidsMarks.Size = new System.Drawing.Size(97, 21);
            this.lblMidsMarks.TabIndex = 4;
            this.lblMidsMarks.Text = "Mids Marks";
            // 
            // txtStudentName
            // 
            this.txtStudentName.Location = new System.Drawing.Point(193, 130);
            this.txtStudentName.Name = "txtStudentName";
            this.txtStudentName.Size = new System.Drawing.Size(170, 20);
            this.txtStudentName.TabIndex = 1;
            // 
            // lblRegNo
            // 
            this.lblRegNo.AutoSize = true;
            this.lblRegNo.Font = new System.Drawing.Font("Microsoft Tai Le", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblRegNo.ForeColor = System.Drawing.Color.Red;
            this.lblRegNo.Location = new System.Drawing.Point(35, 94);
            this.lblRegNo.Name = "lblRegNo";
            this.lblRegNo.Size = new System.Drawing.Size(70, 21);
            this.lblRegNo.TabIndex = 5;
            this.lblRegNo.Text = "Reg No.";
            // 
            // lblQuizzes
            // 
            this.lblQuizzes.AutoSize = true;
            this.lblQuizzes.Font = new System.Drawing.Font("Microsoft Tai Le", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblQuizzes.ForeColor = System.Drawing.Color.Red;
            this.lblQuizzes.Location = new System.Drawing.Point(35, 169);
            this.lblQuizzes.Name = "lblQuizzes";
            this.lblQuizzes.Size = new System.Drawing.Size(145, 21);
            this.lblQuizzes.TabIndex = 6;
            this.lblQuizzes.Text = "Total of 5 Quizzes";
            // 
            // lblAddRecord
            // 
            this.lblAddRecord.AutoSize = true;
            this.lblAddRecord.Font = new System.Drawing.Font("Microsoft Tai Le", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblAddRecord.ForeColor = System.Drawing.Color.Red;
            this.lblAddRecord.Location = new System.Drawing.Point(70, 35);
            this.lblAddRecord.Name = "lblAddRecord";
            this.lblAddRecord.Size = new System.Drawing.Size(272, 27);
            this.lblAddRecord.TabIndex = 7;
            this.lblAddRecord.Text = "DELETE STUDENT RECORD";
            // 
            // lblStudentName
            // 
            this.lblStudentName.AutoSize = true;
            this.lblStudentName.Font = new System.Drawing.Font("Microsoft Tai Le", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblStudentName.ForeColor = System.Drawing.Color.Red;
            this.lblStudentName.Location = new System.Drawing.Point(35, 130);
            this.lblStudentName.Name = "lblStudentName";
            this.lblStudentName.Size = new System.Drawing.Size(120, 21);
            this.lblStudentName.TabIndex = 8;
            this.lblStudentName.Text = "Student Name";
            // 
            // cmbRegNo
            // 
            this.cmbRegNo.FormattingEnabled = true;
            this.cmbRegNo.Location = new System.Drawing.Point(193, 94);
            this.cmbRegNo.Name = "cmbRegNo";
            this.cmbRegNo.Size = new System.Drawing.Size(170, 21);
            this.cmbRegNo.TabIndex = 0;
            this.cmbRegNo.SelectedIndexChanged += new System.EventHandler(this.cmbRegNo_SelectedIndexChanged);
            this.cmbRegNo.SelectedValueChanged += new System.EventHandler(this.cmbRegNo_SelectedValueChanged);
            // 
            // DeleteRecord
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(401, 368);
            this.Controls.Add(this.cmbRegNo);
            this.Controls.Add(this.btnDeleteRecord);
            this.Controls.Add(this.txtFinalMarks);
            this.Controls.Add(this.txtMidMarks);
            this.Controls.Add(this.lblFinalMarks);
            this.Controls.Add(this.txtQuizzes);
            this.Controls.Add(this.lblMidsMarks);
            this.Controls.Add(this.txtStudentName);
            this.Controls.Add(this.lblRegNo);
            this.Controls.Add(this.lblQuizzes);
            this.Controls.Add(this.lblAddRecord);
            this.Controls.Add(this.lblStudentName);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "DeleteRecord";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "DeleteRecord";
            this.Load += new System.EventHandler(this.DeleteRecord_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnDeleteRecord;
        private System.Windows.Forms.TextBox txtFinalMarks;
        private System.Windows.Forms.TextBox txtMidMarks;
        private System.Windows.Forms.Label lblFinalMarks;
        private System.Windows.Forms.TextBox txtQuizzes;
        private System.Windows.Forms.Label lblMidsMarks;
        private System.Windows.Forms.TextBox txtStudentName;
        private System.Windows.Forms.Label lblRegNo;
        private System.Windows.Forms.Label lblQuizzes;
        private System.Windows.Forms.Label lblAddRecord;
        private System.Windows.Forms.Label lblStudentName;
        private System.Windows.Forms.ComboBox cmbRegNo;
    }
}