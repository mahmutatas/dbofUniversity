namespace UniversityDatabaseApp
{
    partial class Student_Page
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
            this.getInformation = new System.Windows.Forms.GroupBox();
            this.otherStudents = new System.Windows.Forms.Button();
            this.coursesRegistered = new System.Windows.Forms.Button();
            this.updateStudenDet = new System.Windows.Forms.Button();
            this.getInformation.SuspendLayout();
            this.SuspendLayout();
            // 
            // getInformation
            // 
            this.getInformation.BackColor = System.Drawing.Color.Transparent;
            this.getInformation.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.getInformation.Controls.Add(this.otherStudents);
            this.getInformation.Controls.Add(this.coursesRegistered);
            this.getInformation.Controls.Add(this.updateStudenDet);
            this.getInformation.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.getInformation.Location = new System.Drawing.Point(94, 108);
            this.getInformation.Name = "getInformation";
            this.getInformation.Size = new System.Drawing.Size(583, 290);
            this.getInformation.TabIndex = 1;
            this.getInformation.TabStop = false;
            this.getInformation.Text = "Get Information";
            // 
            // otherStudents
            // 
            this.otherStudents.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.otherStudents.Location = new System.Drawing.Point(137, 206);
            this.otherStudents.Name = "otherStudents";
            this.otherStudents.Size = new System.Drawing.Size(298, 36);
            this.otherStudents.TabIndex = 2;
            this.otherStudents.Text = "List of Students in the Class";
            this.otherStudents.UseVisualStyleBackColor = true;
            this.otherStudents.Click += new System.EventHandler(this.otherStudents_Click);
            // 
            // coursesRegistered
            // 
            this.coursesRegistered.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.coursesRegistered.Location = new System.Drawing.Point(137, 132);
            this.coursesRegistered.Name = "coursesRegistered";
            this.coursesRegistered.Size = new System.Drawing.Size(298, 36);
            this.coursesRegistered.TabIndex = 1;
            this.coursesRegistered.Text = "Courses Registered";
            this.coursesRegistered.UseVisualStyleBackColor = true;
            this.coursesRegistered.Click += new System.EventHandler(this.coursesRegistered_Click);
            // 
            // updateStudenDet
            // 
            this.updateStudenDet.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.updateStudenDet.Location = new System.Drawing.Point(137, 59);
            this.updateStudenDet.Name = "updateStudenDet";
            this.updateStudenDet.Size = new System.Drawing.Size(298, 36);
            this.updateStudenDet.TabIndex = 0;
            this.updateStudenDet.Text = "See and Update Details ";
            this.updateStudenDet.UseVisualStyleBackColor = true;
            this.updateStudenDet.Click += new System.EventHandler(this.updateStudenDet_Click);
            // 
            // Student_Page
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ButtonFace;
            this.BackgroundImage = global::UniversityDatabaseApp.Properties.Resources._2;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(770, 506);
            this.Controls.Add(this.getInformation);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.SizableToolWindow;
            this.Name = "Student_Page";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Student Page";
            this.getInformation.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox getInformation;
        private System.Windows.Forms.Button otherStudents;
        private System.Windows.Forms.Button coursesRegistered;
        private System.Windows.Forms.Button updateStudenDet;
    }
}