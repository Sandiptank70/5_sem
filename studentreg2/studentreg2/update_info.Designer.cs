namespace studentreg2
{
    partial class update_info
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
            this.up_first = new System.Windows.Forms.Label();
            this.up_last = new System.Windows.Forms.Label();
            this.up_firstt = new System.Windows.Forms.TextBox();
            this.up_lestt = new System.Windows.Forms.TextBox();
            this.search = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // up_first
            // 
            this.up_first.AutoSize = true;
            this.up_first.Location = new System.Drawing.Point(69, 110);
            this.up_first.Name = "up_first";
            this.up_first.Size = new System.Drawing.Size(57, 13);
            this.up_first.TabIndex = 0;
            this.up_first.Text = "First Name";
            this.up_first.Click += new System.EventHandler(this.up_first_Click);
            // 
            // up_last
            // 
            this.up_last.AutoSize = true;
            this.up_last.Location = new System.Drawing.Point(517, 110);
            this.up_last.Name = "up_last";
            this.up_last.Size = new System.Drawing.Size(58, 13);
            this.up_last.TabIndex = 1;
            this.up_last.Text = "Lest Name";
            // 
            // up_firstt
            // 
            this.up_firstt.Location = new System.Drawing.Point(156, 103);
            this.up_firstt.Name = "up_firstt";
            this.up_firstt.Size = new System.Drawing.Size(226, 20);
            this.up_firstt.TabIndex = 2;
            this.up_firstt.TextChanged += new System.EventHandler(this.up_firstt_TextChanged);
            // 
            // up_lestt
            // 
            this.up_lestt.Location = new System.Drawing.Point(610, 103);
            this.up_lestt.Name = "up_lestt";
            this.up_lestt.Size = new System.Drawing.Size(226, 20);
            this.up_lestt.TabIndex = 3;
            // 
            // search
            // 
            this.search.Location = new System.Drawing.Point(360, 201);
            this.search.Name = "search";
            this.search.Size = new System.Drawing.Size(172, 33);
            this.search.TabIndex = 4;
            this.search.Text = "search";
            this.search.UseVisualStyleBackColor = true;
            this.search.Click += new System.EventHandler(this.search_Click);
            // 
            // update_info
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1088, 507);
            this.Controls.Add(this.search);
            this.Controls.Add(this.up_lestt);
            this.Controls.Add(this.up_firstt);
            this.Controls.Add(this.up_last);
            this.Controls.Add(this.up_first);
            this.Name = "update_info";
            this.Text = "update_info";
            this.Load += new System.EventHandler(this.update_info_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label up_first;
        private System.Windows.Forms.Label up_last;
        private System.Windows.Forms.TextBox up_firstt;
        private System.Windows.Forms.TextBox up_lestt;
        private System.Windows.Forms.Button search;
    }
}