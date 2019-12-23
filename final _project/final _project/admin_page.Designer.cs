namespace final__project
{
    partial class admin_page
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
            this.student = new System.Windows.Forms.Button();
            this.faculty = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // student
            // 
            this.student.Location = new System.Drawing.Point(167, 112);
            this.student.Name = "student";
            this.student.Size = new System.Drawing.Size(75, 23);
            this.student.TabIndex = 0;
            this.student.Text = "student";
            this.student.UseVisualStyleBackColor = true;
            this.student.Click += new System.EventHandler(this.student_Click);
            // 
            // faculty
            // 
            this.faculty.Location = new System.Drawing.Point(335, 112);
            this.faculty.Name = "faculty";
            this.faculty.Size = new System.Drawing.Size(75, 23);
            this.faculty.TabIndex = 1;
            this.faculty.Text = "faculty";
            this.faculty.UseVisualStyleBackColor = true;
            // 
            // admin_page
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(750, 261);
            this.Controls.Add(this.faculty);
            this.Controls.Add(this.student);
            this.Name = "admin_page";
            this.Text = "admin_page";
            this.Load += new System.EventHandler(this.admin_page_Load);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button student;
        private System.Windows.Forms.Button faculty;
    }
}