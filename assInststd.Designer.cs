namespace UniversityDatabaseApp
{
    partial class assInststd
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
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.stdIdBox = new System.Windows.Forms.TextBox();
            this.instIdBox = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // CnclBtn
            // 
            this.CnclBtn.Location = new System.Drawing.Point(425, 346);
            this.CnclBtn.Name = "CnclBtn";
            this.CnclBtn.Size = new System.Drawing.Size(82, 34);
            this.CnclBtn.TabIndex = 41;
            this.CnclBtn.Text = "Cancel";
            this.CnclBtn.UseVisualStyleBackColor = true;
            this.CnclBtn.Click += new System.EventHandler(this.CnclBtn_Click);
            // 
            // AdBtn
            // 
            this.AdBtn.Location = new System.Drawing.Point(297, 346);
            this.AdBtn.Name = "AdBtn";
            this.AdBtn.Size = new System.Drawing.Size(82, 34);
            this.AdBtn.TabIndex = 40;
            this.AdBtn.Text = "Assign";
            this.AdBtn.UseVisualStyleBackColor = true;
            this.AdBtn.Click += new System.EventHandler(this.AdBtn_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label2.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.label2.Location = new System.Drawing.Point(219, 222);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(73, 18);
            this.label2.TabIndex = 37;
            this.label2.Text = "Student Id";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label1.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.label1.Location = new System.Drawing.Point(206, 122);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(85, 18);
            this.label1.TabIndex = 36;
            this.label1.Text = "Instructor Id";
            // 
            // stdIdBox
            // 
            this.stdIdBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.stdIdBox.Location = new System.Drawing.Point(297, 222);
            this.stdIdBox.Name = "stdIdBox";
            this.stdIdBox.Size = new System.Drawing.Size(210, 27);
            this.stdIdBox.TabIndex = 33;
            // 
            // instIdBox
            // 
            this.instIdBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.instIdBox.Location = new System.Drawing.Point(297, 122);
            this.instIdBox.Name = "instIdBox";
            this.instIdBox.Size = new System.Drawing.Size(210, 27);
            this.instIdBox.TabIndex = 32;
            // 
            // assInststd
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.DarkSlateGray;
            this.ClientSize = new System.Drawing.Size(770, 506);
            this.Controls.Add(this.CnclBtn);
            this.Controls.Add(this.AdBtn);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.stdIdBox);
            this.Controls.Add(this.instIdBox);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.SizableToolWindow;
            this.Name = "assInststd";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Assign Advisor to Students";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button CnclBtn;
        private System.Windows.Forms.Button AdBtn;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox stdIdBox;
        private System.Windows.Forms.TextBox instIdBox;
    }
}