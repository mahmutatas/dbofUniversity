namespace UniversityDatabaseApp
{
    partial class addnwstudent
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
            this.totcredBox = new System.Windows.Forms.TextBox();
            this.deptBox = new System.Windows.Forms.TextBox();
            this.nmBox = new System.Windows.Forms.TextBox();
            this.idBox = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // CnclBtn
            // 
            this.CnclBtn.Location = new System.Drawing.Point(436, 351);
            this.CnclBtn.Name = "CnclBtn";
            this.CnclBtn.Size = new System.Drawing.Size(82, 34);
            this.CnclBtn.TabIndex = 29;
            this.CnclBtn.Text = "Cancel";
            this.CnclBtn.UseVisualStyleBackColor = true;
            this.CnclBtn.Click += new System.EventHandler(this.CnclBtn_Click);
            // 
            // AdBtn
            // 
            this.AdBtn.Location = new System.Drawing.Point(308, 351);
            this.AdBtn.Name = "AdBtn";
            this.AdBtn.Size = new System.Drawing.Size(82, 34);
            this.AdBtn.TabIndex = 28;
            this.AdBtn.Text = "Add";
            this.AdBtn.UseVisualStyleBackColor = true;
            this.AdBtn.Click += new System.EventHandler(this.AdBtn_Click);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label4.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.label4.Location = new System.Drawing.Point(210, 288);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(92, 18);
            this.label4.TabIndex = 27;
            this.label4.Text = "Total Credits";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label3.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.label3.Location = new System.Drawing.Point(217, 226);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(85, 18);
            this.label3.TabIndex = 26;
            this.label3.Text = "Department";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label2.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.label2.Location = new System.Drawing.Point(250, 157);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(52, 18);
            this.label2.TabIndex = 25;
            this.label2.Text = "Name ";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label1.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.label1.Location = new System.Drawing.Point(283, 91);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(19, 18);
            this.label1.TabIndex = 24;
            this.label1.Text = "Id";
            // 
            // totcredBox
            // 
            this.totcredBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.totcredBox.Location = new System.Drawing.Point(308, 288);
            this.totcredBox.Name = "totcredBox";
            this.totcredBox.Size = new System.Drawing.Size(210, 27);
            this.totcredBox.TabIndex = 23;
            // 
            // deptBox
            // 
            this.deptBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.deptBox.Location = new System.Drawing.Point(308, 226);
            this.deptBox.Name = "deptBox";
            this.deptBox.Size = new System.Drawing.Size(210, 27);
            this.deptBox.TabIndex = 22;
            // 
            // nmBox
            // 
            this.nmBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.nmBox.Location = new System.Drawing.Point(308, 157);
            this.nmBox.Name = "nmBox";
            this.nmBox.Size = new System.Drawing.Size(210, 27);
            this.nmBox.TabIndex = 21;
            // 
            // idBox
            // 
            this.idBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.idBox.Location = new System.Drawing.Point(308, 91);
            this.idBox.Name = "idBox";
            this.idBox.Size = new System.Drawing.Size(210, 27);
            this.idBox.TabIndex = 20;
            // 
            // addnwstudent
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.DarkSlateGray;
            this.ClientSize = new System.Drawing.Size(728, 477);
            this.Controls.Add(this.CnclBtn);
            this.Controls.Add(this.AdBtn);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.totcredBox);
            this.Controls.Add(this.deptBox);
            this.Controls.Add(this.nmBox);
            this.Controls.Add(this.idBox);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.SizableToolWindow;
            this.Name = "addnwstudent";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Add New Student";
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
        private System.Windows.Forms.TextBox totcredBox;
        private System.Windows.Forms.TextBox deptBox;
        private System.Windows.Forms.TextBox nmBox;
        private System.Windows.Forms.TextBox idBox;
    }
}