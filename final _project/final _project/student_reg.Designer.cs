namespace final__project
{
    partial class student_reg
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
            this.registion = new System.Windows.Forms.Button();
            this.view = new System.Windows.Forms.Button();
            this.update = new System.Windows.Forms.Button();
            this.remove = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // registion
            // 
            this.registion.Location = new System.Drawing.Point(131, 95);
            this.registion.Name = "registion";
            this.registion.Size = new System.Drawing.Size(75, 23);
            this.registion.TabIndex = 0;
            this.registion.Text = "registion";
            this.registion.UseVisualStyleBackColor = true;
            this.registion.Click += new System.EventHandler(this.registion_Click);
            // 
            // view
            // 
            this.view.AllowDrop = true;
            this.view.Location = new System.Drawing.Point(253, 95);
            this.view.Name = "view";
            this.view.Size = new System.Drawing.Size(75, 23);
            this.view.TabIndex = 1;
            this.view.Text = "view";
            this.view.UseVisualStyleBackColor = true;
            this.view.Click += new System.EventHandler(this.view_Click);
            // 
            // update
            // 
            this.update.Location = new System.Drawing.Point(393, 95);
            this.update.Name = "update";
            this.update.Size = new System.Drawing.Size(75, 23);
            this.update.TabIndex = 2;
            this.update.Text = "update";
            this.update.UseVisualStyleBackColor = true;
            this.update.Click += new System.EventHandler(this.update_Click);
            // 
            // remove
            // 
            this.remove.Location = new System.Drawing.Point(533, 95);
            this.remove.Name = "remove";
            this.remove.Size = new System.Drawing.Size(75, 23);
            this.remove.TabIndex = 3;
            this.remove.Text = "remove";
            this.remove.UseVisualStyleBackColor = true;
            this.remove.Click += new System.EventHandler(this.remove_Click);
            // 
            // student_reg
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(882, 335);
            this.Controls.Add(this.remove);
            this.Controls.Add(this.update);
            this.Controls.Add(this.view);
            this.Controls.Add(this.registion);
            this.Name = "student_reg";
            this.Text = "student_reg";
            this.Load += new System.EventHandler(this.student_reg_Load);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button registion;
        private System.Windows.Forms.Button view;
        private System.Windows.Forms.Button update;
        private System.Windows.Forms.Button remove;
    }
}