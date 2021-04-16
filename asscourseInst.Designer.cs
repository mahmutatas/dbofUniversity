namespace UniversityDatabaseApp
{
    partial class asscourseInst
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
            this.CnclBtn = new System.Windows.Forms.Button();
            this.AdBtn = new System.Windows.Forms.Button();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.semesterBox = new System.Windows.Forms.TextBox();
            this.sec_idBox = new System.Windows.Forms.TextBox();
            this.courseIdBox = new System.Windows.Forms.TextBox();
            this.instIdBox = new System.Windows.Forms.TextBox();
            this.yearBox = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // CnclBtn
            // 
            this.CnclBtn.Location = new System.Drawing.Point(433, 399);
            this.CnclBtn.Name = "CnclBtn";
            this.CnclBtn.Size = new System.Drawing.Size(82, 34);
            this.CnclBtn.TabIndex = 29;
            this.CnclBtn.Text = "Cancel";
            this.CnclBtn.UseVisualStyleBackColor = true;
            this.CnclBtn.Click += new System.EventHandler(this.CnclBtn_Click);
            // 
            // AdBtn
            // 
            this.AdBtn.Location = new System.Drawing.Point(305, 399);
            this.AdBtn.Name = "AdBtn";
            this.AdBtn.Size = new System.Drawing.Size(82, 34);
            this.AdBtn.TabIndex = 28;
            this.AdBtn.Text = "Assign";
            this.AdBtn.UseVisualStyleBackColor = true;
            this.AdBtn.Click += new System.EventHandler(this.AdBtn_Click);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label4.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.label4.Location = new System.Drawing.Point(227, 243);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(72, 18);
            this.label4.TabIndex = 27;
            this.label4.Text = "Semester";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label3.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.label3.Location = new System.Drawing.Point(226, 173);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(73, 18);
            this.label3.TabIndex = 26;
            this.label3.Text = "Section Id";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label2.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.label2.Location = new System.Drawing.Point(227, 104);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(72, 18);
            this.label2.TabIndex = 25;
            this.label2.Text = "Course Id";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label1.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.label1.Location = new System.Drawing.Point(214, 38);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(85, 18);
            this.label1.TabIndex = 24;
            this.label1.Text = "Instructor Id";
            // 
            // semesterBox
            // 
            this.semesterBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.semesterBox.Location = new System.Drawing.Point(305, 243);
            this.semesterBox.Name = "semesterBox";
            this.semesterBox.Size = new System.Drawing.Size(210, 27);
            this.semesterBox.TabIndex = 23;
            // 
            // sec_idBox
            // 
            this.sec_idBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.sec_idBox.Location = new System.Drawing.Point(305, 173);
            this.sec_idBox.Name = "sec_idBox";
            this.sec_idBox.Size = new System.Drawing.Size(210, 27);
            this.sec_idBox.TabIndex = 22;
            // 
            // courseIdBox
            // 
            this.courseIdBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.courseIdBox.Location = new System.Drawing.Point(305, 104);
            this.courseIdBox.Name = "courseIdBox";
            this.courseIdBox.Size = new System.Drawing.Size(210, 27);
            this.courseIdBox.TabIndex = 21;
            // 
            // instIdBox
            // 
            this.instIdBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.instIdBox.Location = new System.Drawing.Point(305, 38);
            this.instIdBox.Name = "instIdBox";
            this.instIdBox.Size = new System.Drawing.Size(210, 27);
            this.instIdBox.TabIndex = 20;
            // 
            // yearBox
            // 
            this.yearBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.yearBox.Location = new System.Drawing.Point(305, 313);
            this.yearBox.Name = "yearBox";
            this.yearBox.Size = new System.Drawing.Size(210, 27);
            this.yearBox.TabIndex = 30;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label5.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.label5.Location = new System.Drawing.Point(261, 313);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(38, 18);
            this.label5.TabIndex = 31;
            this.label5.Text = "Year";
            // 
            // asscourseInst
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.DarkSlateGray;
            this.ClientSize = new System.Drawing.Size(805, 510);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.yearBox);
            this.Controls.Add(this.CnclBtn);
            this.Controls.Add(this.AdBtn);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.semesterBox);
            this.Controls.Add(this.sec_idBox);
            this.Controls.Add(this.courseIdBox);
            this.Controls.Add(this.instIdBox);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.SizableToolWindow;
            this.Name = "asscourseInst";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Assign Course to Instructors";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button CnclBtn;
        private System.Windows.Forms.Button AdBtn;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox semesterBox;
        private System.Windows.Forms.TextBox sec_idBox;
        private System.Windows.Forms.TextBox courseIdBox;
        private System.Windows.Forms.TextBox instIdBox;
        private System.Windows.Forms.TextBox yearBox;
        private System.Windows.Forms.Label label5;
    }
}