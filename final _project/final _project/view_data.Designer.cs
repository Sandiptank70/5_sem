namespace final__project
{
    partial class view_data
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
            this.view_std = new System.Windows.Forms.Label();
            this.view_class = new System.Windows.Forms.Label();
            this.view_standrad = new System.Windows.Forms.ComboBox();
            this.view_class1 = new System.Windows.Forms.ComboBox();
            this.view_submit = new System.Windows.Forms.Button();
            this.dgvl1 = new System.Windows.Forms.DataGridView();
            ((System.ComponentModel.ISupportInitialize)(this.dgvl1)).BeginInit();
            this.SuspendLayout();
            // 
            // view_std
            // 
            this.view_std.AutoSize = true;
            this.view_std.Location = new System.Drawing.Point(137, 137);
            this.view_std.Name = "view_std";
            this.view_std.Size = new System.Drawing.Size(48, 13);
            this.view_std.TabIndex = 0;
            this.view_std.Text = "standrad";
            // 
            // view_class
            // 
            this.view_class.AutoSize = true;
            this.view_class.Location = new System.Drawing.Point(459, 133);
            this.view_class.Name = "view_class";
            this.view_class.Size = new System.Drawing.Size(31, 13);
            this.view_class.TabIndex = 1;
            this.view_class.Text = "class";
            // 
            // view_standrad
            // 
            this.view_standrad.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.view_standrad.FormattingEnabled = true;
            this.view_standrad.Items.AddRange(new object[] {
            "1",
            "2",
            "3",
            "4",
            "5",
            "6",
            "7",
            "8",
            "9",
            "10",
            "11",
            "12"});
            this.view_standrad.Location = new System.Drawing.Point(220, 129);
            this.view_standrad.Name = "view_standrad";
            this.view_standrad.Size = new System.Drawing.Size(121, 21);
            this.view_standrad.TabIndex = 2;
            this.view_standrad.SelectedIndexChanged += new System.EventHandler(this.view_standrad_SelectedIndexChanged);
            // 
            // view_class1
            // 
            this.view_class1.FormattingEnabled = true;
            this.view_class1.Items.AddRange(new object[] {
            "A",
            "B",
            "C"});
            this.view_class1.Location = new System.Drawing.Point(586, 130);
            this.view_class1.Name = "view_class1";
            this.view_class1.Size = new System.Drawing.Size(121, 21);
            this.view_class1.TabIndex = 3;
            this.view_class1.SelectedIndexChanged += new System.EventHandler(this.comboBox2_SelectedIndexChanged);
            // 
            // view_submit
            // 
            this.view_submit.Location = new System.Drawing.Point(386, 166);
            this.view_submit.Name = "view_submit";
            this.view_submit.Size = new System.Drawing.Size(75, 23);
            this.view_submit.TabIndex = 4;
            this.view_submit.Text = "submit";
            this.view_submit.UseVisualStyleBackColor = true;
            this.view_submit.Click += new System.EventHandler(this.view_submit_Click);
            // 
            // dgvl1
            // 
            this.dgvl1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvl1.Location = new System.Drawing.Point(12, 210);
            this.dgvl1.Name = "dgvl1";
            this.dgvl1.Size = new System.Drawing.Size(950, 267);
            this.dgvl1.TabIndex = 5;
            // 
            // view_data
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(974, 489);
            this.Controls.Add(this.dgvl1);
            this.Controls.Add(this.view_submit);
            this.Controls.Add(this.view_class1);
            this.Controls.Add(this.view_standrad);
            this.Controls.Add(this.view_class);
            this.Controls.Add(this.view_std);
            this.Name = "view_data";
            this.Text = "view_data";
            this.Load += new System.EventHandler(this.view_data_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgvl1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label view_std;
        private System.Windows.Forms.Label view_class;
        private System.Windows.Forms.ComboBox view_standrad;
        private System.Windows.Forms.ComboBox view_class1;
        private System.Windows.Forms.Button view_submit;
        private System.Windows.Forms.DataGridView dgvl1;
    }
}