namespace UniversityDatabaseApp
{
    partial class Admin_Page
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
            this.assignBox = new System.Windows.Forms.GroupBox();
            this.assignAdvisor = new System.Windows.Forms.Button();
            this.assignTeaching = new System.Windows.Forms.Button();
            this.addBox = new System.Windows.Forms.GroupBox();
            this.newStudent = new System.Windows.Forms.Button();
            this.newTeacher = new System.Windows.Forms.Button();
            this.newCourse = new System.Windows.Forms.Button();
            this.assignBox.SuspendLayout();
            this.addBox.SuspendLayout();
            this.SuspendLayout();
            // 
            // assignBox
            // 
            this.assignBox.BackColor = System.Drawing.Color.Transparent;
            this.assignBox.Controls.Add(this.assignAdvisor);
            this.assignBox.Controls.Add(this.assignTeaching);
            this.assignBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F);
            this.assignBox.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.assignBox.Location = new System.Drawing.Point(447, 128);
            this.assignBox.Name = "assignBox";
            this.assignBox.Size = new System.Drawing.Size(251, 233);
            this.assignBox.TabIndex = 3;
            this.assignBox.TabStop = false;
            this.assignBox.Text = "Assign";
            // 
            // assignAdvisor
            // 
            this.assignAdvisor.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.assignAdvisor.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.assignAdvisor.Location = new System.Drawing.Point(21, 155);
            this.assignAdvisor.Name = "assignAdvisor";
            this.assignAdvisor.Size = new System.Drawing.Size(203, 35);
            this.assignAdvisor.TabIndex = 1;
            this.assignAdvisor.Text = "Advisor to Students";
            this.assignAdvisor.UseVisualStyleBackColor = true;
            this.assignAdvisor.Click += new System.EventHandler(this.assignAdvisor_Click);
            // 
            // assignTeaching
            // 
            this.assignTeaching.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.assignTeaching.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.assignTeaching.Location = new System.Drawing.Point(21, 81);
            this.assignTeaching.Name = "assignTeaching";
            this.assignTeaching.Size = new System.Drawing.Size(203, 35);
            this.assignTeaching.TabIndex = 0;
            this.assignTeaching.Text = "Course to Instructors";
            this.assignTeaching.UseVisualStyleBackColor = true;
            this.assignTeaching.Click += new System.EventHandler(this.assignTeaching_Click);
            // 
            // addBox
            // 
            this.addBox.BackColor = System.Drawing.Color.Transparent;
            this.addBox.Controls.Add(this.newStudent);
            this.addBox.Controls.Add(this.newTeacher);
            this.addBox.Controls.Add(this.newCourse);
            this.addBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F);
            this.addBox.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.addBox.Location = new System.Drawing.Point(51, 128);
            this.addBox.Name = "addBox";
            this.addBox.Size = new System.Drawing.Size(251, 233);
            this.addBox.TabIndex = 2;
            this.addBox.TabStop = false;
            this.addBox.Text = "Add";
            // 
            // newStudent
            // 
            this.newStudent.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.newStudent.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.newStudent.Location = new System.Drawing.Point(27, 176);
            this.newStudent.Name = "newStudent";
            this.newStudent.Size = new System.Drawing.Size(193, 35);
            this.newStudent.TabIndex = 2;
            this.newStudent.Text = "New Student";
            this.newStudent.UseVisualStyleBackColor = true;
            this.newStudent.Click += new System.EventHandler(this.newStudent_Click);
            // 
            // newTeacher
            // 
            this.newTeacher.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.newTeacher.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.newTeacher.Location = new System.Drawing.Point(27, 112);
            this.newTeacher.Name = "newTeacher";
            this.newTeacher.Size = new System.Drawing.Size(193, 35);
            this.newTeacher.TabIndex = 1;
            this.newTeacher.Text = "New Teacher";
            this.newTeacher.UseVisualStyleBackColor = true;
            this.newTeacher.Click += new System.EventHandler(this.newTeacher_Click);
            // 
            // newCourse
            // 
            this.newCourse.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.newCourse.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.newCourse.Location = new System.Drawing.Point(27, 54);
            this.newCourse.Name = "newCourse";
            this.newCourse.Size = new System.Drawing.Size(193, 35);
            this.newCourse.TabIndex = 0;
            this.newCourse.Text = "New Course";
            this.newCourse.UseVisualStyleBackColor = true;
            this.newCourse.Click += new System.EventHandler(this.newCourse_Click);
            // 
            // Admin_Page
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.GradientActiveCaption;
            this.BackgroundImage = global::UniversityDatabaseApp.Properties.Resources._2;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(770, 506);
            this.Controls.Add(this.assignBox);
            this.Controls.Add(this.addBox);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.SizableToolWindow;
            this.Name = "Admin_Page";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Admin Page";
            this.assignBox.ResumeLayout(false);
            this.addBox.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox assignBox;
        private System.Windows.Forms.Button assignAdvisor;
        private System.Windows.Forms.Button assignTeaching;
        private System.Windows.Forms.GroupBox addBox;
        private System.Windows.Forms.Button newStudent;
        private System.Windows.Forms.Button newTeacher;
        private System.Windows.Forms.Button newCourse;
    }
}