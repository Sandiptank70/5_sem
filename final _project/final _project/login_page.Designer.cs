namespace final__project
{
    partial class login_page
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
            this.comboBoxlogin = new System.Windows.Forms.ComboBox();
            this.submitadmin = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.adminuser = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.adminpass = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // comboBoxlogin
            // 
            this.comboBoxlogin.FormattingEnabled = true;
            this.comboBoxlogin.Items.AddRange(new object[] {
            "Admin",
            "Teacher"});
            this.comboBoxlogin.Location = new System.Drawing.Point(291, 202);
            this.comboBoxlogin.Name = "comboBoxlogin";
            this.comboBoxlogin.Size = new System.Drawing.Size(121, 21);
            this.comboBoxlogin.TabIndex = 0;
            // 
            // submitadmin
            // 
            this.submitadmin.Location = new System.Drawing.Point(291, 343);
            this.submitadmin.Name = "submitadmin";
            this.submitadmin.Size = new System.Drawing.Size(150, 59);
            this.submitadmin.TabIndex = 1;
            this.submitadmin.Text = "submit";
            this.submitadmin.UseVisualStyleBackColor = true;
            this.submitadmin.Click += new System.EventHandler(this.submitadmin_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(194, 257);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(53, 13);
            this.label1.TabIndex = 2;
            this.label1.Text = "username";
            // 
            // adminuser
            // 
            this.adminuser.Location = new System.Drawing.Point(291, 257);
            this.adminuser.Name = "adminuser";
            this.adminuser.Size = new System.Drawing.Size(100, 20);
            this.adminuser.TabIndex = 3;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(194, 299);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(52, 13);
            this.label2.TabIndex = 4;
            this.label2.Text = "password";
            // 
            // adminpass
            // 
            this.adminpass.Location = new System.Drawing.Point(291, 299);
            this.adminpass.Name = "adminpass";
            this.adminpass.Size = new System.Drawing.Size(100, 20);
            this.adminpass.TabIndex = 5;
            // 
            // login_page
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(963, 535);
            this.Controls.Add(this.adminpass);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.adminuser);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.submitadmin);
            this.Controls.Add(this.comboBoxlogin);
            this.Name = "login_page";
            this.Text = "login_page";
            this.Load += new System.EventHandler(this.login_page_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ComboBox comboBoxlogin;
        private System.Windows.Forms.Button submitadmin;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox adminuser;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox adminpass;
    }
}