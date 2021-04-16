namespace UniversityDatabaseApp
{
    partial class Instructor_Page
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
            this.updateRegister = new System.Windows.Forms.GroupBox();
            this.registerStd = new System.Windows.Forms.Button();
            this.updatePerDetails = new System.Windows.Forms.Button();
            this.showDatas = new System.Windows.Forms.GroupBox();
            this.courseDetails = new System.Windows.Forms.Button();
            this.courseAssigned = new System.Windows.Forms.Button();
            this.updateRegister.SuspendLayout();
            this.showDatas.SuspendLayout();
            this.SuspendLayout();
            // 
            // updateRegister
            // 
            this.updateRegister.BackColor = System.Drawing.Color.Transparent;
            this.updateRegister.Controls.Add(this.registerStd);
            this.updateRegister.Controls.Add(this.updatePerDetails);
            this.updateRegister.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.updateRegister.Location = new System.Drawing.Point(460, 146);
            this.updateRegister.Name = "updateRegister";
            this.updateRegister.Size = new System.Drawing.Size(268, 215);
            this.updateRegister.TabIndex = 3;
            this.updateRegister.TabStop = false;
            this.updateRegister.Text = "Update-Register";
            // 
            // registerStd
            // 
            this.registerStd.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.registerStd.Location = new System.Drawing.Point(34, 126);
            this.registerStd.Name = "registerStd";
            this.registerStd.Size = new System.Drawing.Size(202, 34);
            this.registerStd.TabIndex = 1;
            this.registerStd.Text = "Register Students";
            this.registerStd.UseVisualStyleBackColor = true;
            this.registerStd.Click += new System.EventHandler(this.registerStd_Click);
            // 
            // updatePerDetails
            // 
            this.updatePerDetails.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.updatePerDetails.Location = new System.Drawing.Point(34, 61);
            this.updatePerDetails.Name = "updatePerDetails";
            this.updatePerDetails.Size = new System.Drawing.Size(202, 34);
            this.updatePerDetails.TabIndex = 0;
            this.updatePerDetails.Text = "Update Personal Details";
            this.updatePerDetails.UseVisualStyleBackColor = true;
            this.updatePerDetails.Click += new System.EventHandler(this.updatePerDetails_Click);
            // 
            // showDatas
            // 
            this.showDatas.BackColor = System.Drawing.Color.Transparent;
            this.showDatas.Controls.Add(this.courseDetails);
            this.showDatas.Controls.Add(this.courseAssigned);
            this.showDatas.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.showDatas.Location = new System.Drawing.Point(71, 146);
            this.showDatas.Name = "showDatas";
            this.showDatas.Size = new System.Drawing.Size(268, 215);
            this.showDatas.TabIndex = 2;
            this.showDatas.TabStop = false;
            this.showDatas.Text = "Show Informations";
            // 
            // courseDetails
            // 
            this.courseDetails.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.courseDetails.Location = new System.Drawing.Point(42, 126);
            this.courseDetails.Name = "courseDetails";
            this.courseDetails.Size = new System.Drawing.Size(202, 34);
            this.courseDetails.TabIndex = 1;
            this.courseDetails.Text = "See Course Details";
            this.courseDetails.UseVisualStyleBackColor = true;
            this.courseDetails.Click += new System.EventHandler(this.courseDetails_Click);
            // 
            // courseAssigned
            // 
            this.courseAssigned.BackColor = System.Drawing.Color.Transparent;
            this.courseAssigned.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.courseAssigned.Location = new System.Drawing.Point(42, 61);
            this.courseAssigned.Name = "courseAssigned";
            this.courseAssigned.Size = new System.Drawing.Size(202, 34);
            this.courseAssigned.TabIndex = 0;
            this.courseAssigned.Text = "See Courses Assigned";
            this.courseAssigned.UseVisualStyleBackColor = false;
            this.courseAssigned.Click += new System.EventHandler(this.courseAssigned_Click);
            // 
            // Instructor_Page
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.GradientActiveCaption;
            this.BackgroundImage = global::UniversityDatabaseApp.Properties.Resources._2;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(798, 506);
            this.Controls.Add(this.updateRegister);
            this.Controls.Add(this.showDatas);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.SizableToolWindow;
            this.Name = "Instructor_Page";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Instructor Page";
            this.updateRegister.ResumeLayout(false);
            this.showDatas.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox updateRegister;
        private System.Windows.Forms.Button registerStd;
        private System.Windows.Forms.Button updatePerDetails;
        private System.Windows.Forms.GroupBox showDatas;
        private System.Windows.Forms.Button courseDetails;
        private System.Windows.Forms.Button courseAssigned;
    }
}