namespace studentreg2
{
    partial class student_form
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
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.save = new System.Windows.Forms.Button();
            this.city1 = new System.Windows.Forms.TextBox();
            this.Female = new System.Windows.Forms.RadioButton();
            this.Male = new System.Windows.Forms.RadioButton();
            this.label3 = new System.Windows.Forms.Label();
            this.address1 = new System.Windows.Forms.RichTextBox();
            this.registerdate = new System.Windows.Forms.DateTimePicker();
            this.birthdate = new System.Windows.Forms.DateTimePicker();
            this.eadd = new System.Windows.Forms.TextBox();
            this.Class3 = new System.Windows.Forms.ComboBox();
            this.std = new System.Windows.Forms.ComboBox();
            this.mo = new System.Windows.Forms.TextBox();
            this.faname = new System.Windows.Forms.TextBox();
            this.lname = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.Fname = new System.Windows.Forms.TextBox();
            this.city = new System.Windows.Forms.Label();
            this.standrad = new System.Windows.Forms.Label();
            this.Gender = new System.Windows.Forms.Label();
            this.class1 = new System.Windows.Forms.Label();
            this.DOB = new System.Windows.Forms.Label();
            this.DOR = new System.Windows.Forms.Label();
            this.Email = new System.Windows.Forms.Label();
            this.Mobile = new System.Windows.Forms.Label();
            this.Father_name = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // groupBox1
            // 
            this.groupBox1.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.groupBox1.Controls.Add(this.save);
            this.groupBox1.Controls.Add(this.city1);
            this.groupBox1.Controls.Add(this.Female);
            this.groupBox1.Controls.Add(this.Male);
            this.groupBox1.Controls.Add(this.label3);
            this.groupBox1.Controls.Add(this.address1);
            this.groupBox1.Controls.Add(this.registerdate);
            this.groupBox1.Controls.Add(this.birthdate);
            this.groupBox1.Controls.Add(this.eadd);
            this.groupBox1.Controls.Add(this.Class3);
            this.groupBox1.Controls.Add(this.std);
            this.groupBox1.Controls.Add(this.mo);
            this.groupBox1.Controls.Add(this.faname);
            this.groupBox1.Controls.Add(this.lname);
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Controls.Add(this.Fname);
            this.groupBox1.Controls.Add(this.city);
            this.groupBox1.Controls.Add(this.standrad);
            this.groupBox1.Controls.Add(this.Gender);
            this.groupBox1.Controls.Add(this.class1);
            this.groupBox1.Controls.Add(this.DOB);
            this.groupBox1.Controls.Add(this.DOR);
            this.groupBox1.Controls.Add(this.Email);
            this.groupBox1.Controls.Add(this.Mobile);
            this.groupBox1.Controls.Add(this.Father_name);
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Location = new System.Drawing.Point(191, 118);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(618, 404);
            this.groupBox1.TabIndex = 1;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Student bio";
            // 
            // save
            // 
            this.save.Location = new System.Drawing.Point(193, 353);
            this.save.Name = "save";
            this.save.Size = new System.Drawing.Size(190, 34);
            this.save.TabIndex = 30;
            this.save.Text = "save";
            this.save.UseVisualStyleBackColor = true;
            this.save.Click += new System.EventHandler(this.save_Click);
            // 
            // city1
            // 
            this.city1.Location = new System.Drawing.Point(93, 313);
            this.city1.Name = "city1";
            this.city1.Size = new System.Drawing.Size(150, 20);
            this.city1.TabIndex = 29;
            // 
            // Female
            // 
            this.Female.AutoSize = true;
            this.Female.Location = new System.Drawing.Point(371, 278);
            this.Female.Name = "Female";
            this.Female.Size = new System.Drawing.Size(59, 17);
            this.Female.TabIndex = 28;
            this.Female.TabStop = true;
            this.Female.Text = "Female";
            this.Female.UseVisualStyleBackColor = true;
            // 
            // Male
            // 
            this.Male.AutoSize = true;
            this.Male.Location = new System.Drawing.Point(93, 280);
            this.Male.Name = "Male";
            this.Male.Size = new System.Drawing.Size(48, 17);
            this.Male.TabIndex = 27;
            this.Male.TabStop = true;
            this.Male.Text = "Male";
            this.Male.UseVisualStyleBackColor = true;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(303, 196);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(39, 13);
            this.label3.TabIndex = 26;
            this.label3.Text = "Adress";
            // 
            // address1
            // 
            this.address1.Location = new System.Drawing.Point(371, 194);
            this.address1.Name = "address1";
            this.address1.Size = new System.Drawing.Size(150, 15);
            this.address1.TabIndex = 25;
            this.address1.Text = "";
            // 
            // registerdate
            // 
            this.registerdate.Location = new System.Drawing.Point(371, 233);
            this.registerdate.Name = "registerdate";
            this.registerdate.Size = new System.Drawing.Size(150, 20);
            this.registerdate.TabIndex = 24;
            // 
            // birthdate
            // 
            this.birthdate.Location = new System.Drawing.Point(93, 233);
            this.birthdate.Name = "birthdate";
            this.birthdate.Size = new System.Drawing.Size(150, 20);
            this.birthdate.TabIndex = 23;
            // 
            // eadd
            // 
            this.eadd.Location = new System.Drawing.Point(93, 189);
            this.eadd.Name = "eadd";
            this.eadd.Size = new System.Drawing.Size(150, 20);
            this.eadd.TabIndex = 22;
            // 
            // Class3
            // 
            this.Class3.FormattingEnabled = true;
            this.Class3.Items.AddRange(new object[] {
            "A",
            "B",
            "C"});
            this.Class3.Location = new System.Drawing.Point(371, 143);
            this.Class3.Name = "Class3";
            this.Class3.Size = new System.Drawing.Size(150, 21);
            this.Class3.TabIndex = 21;
            // 
            // std
            // 
            this.std.Cursor = System.Windows.Forms.Cursors.AppStarting;
            this.std.FormattingEnabled = true;
            this.std.Items.AddRange(new object[] {
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
            this.std.Location = new System.Drawing.Point(93, 143);
            this.std.Name = "std";
            this.std.Size = new System.Drawing.Size(150, 21);
            this.std.TabIndex = 20;
            this.std.SelectedIndexChanged += new System.EventHandler(this.std_SelectedIndexChanged);
            // 
            // mo
            // 
            this.mo.Location = new System.Drawing.Point(371, 94);
            this.mo.Name = "mo";
            this.mo.Size = new System.Drawing.Size(150, 20);
            this.mo.TabIndex = 19;
            // 
            // faname
            // 
            this.faname.Location = new System.Drawing.Point(93, 94);
            this.faname.Name = "faname";
            this.faname.Size = new System.Drawing.Size(150, 20);
            this.faname.TabIndex = 18;
            // 
            // lname
            // 
            this.lname.Location = new System.Drawing.Point(371, 55);
            this.lname.Name = "lname";
            this.lname.Size = new System.Drawing.Size(150, 20);
            this.lname.TabIndex = 17;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(303, 55);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(58, 13);
            this.label2.TabIndex = 16;
            this.label2.Text = "Last Name";
            // 
            // Fname
            // 
            this.Fname.Location = new System.Drawing.Point(93, 48);
            this.Fname.Name = "Fname";
            this.Fname.Size = new System.Drawing.Size(150, 20);
            this.Fname.TabIndex = 15;
            // 
            // city
            // 
            this.city.AutoSize = true;
            this.city.Location = new System.Drawing.Point(30, 320);
            this.city.Name = "city";
            this.city.Size = new System.Drawing.Size(23, 13);
            this.city.TabIndex = 14;
            this.city.Text = "city";
            // 
            // standrad
            // 
            this.standrad.AutoSize = true;
            this.standrad.Location = new System.Drawing.Point(22, 143);
            this.standrad.Name = "standrad";
            this.standrad.Size = new System.Drawing.Size(48, 13);
            this.standrad.TabIndex = 12;
            this.standrad.Text = "standrad";
            // 
            // Gender
            // 
            this.Gender.AutoSize = true;
            this.Gender.Location = new System.Drawing.Point(30, 280);
            this.Gender.Name = "Gender";
            this.Gender.Size = new System.Drawing.Size(42, 13);
            this.Gender.TabIndex = 9;
            this.Gender.Text = "Gender";
            // 
            // class1
            // 
            this.class1.AutoSize = true;
            this.class1.Location = new System.Drawing.Point(303, 151);
            this.class1.Name = "class1";
            this.class1.Size = new System.Drawing.Size(31, 13);
            this.class1.TabIndex = 7;
            this.class1.Text = "class";
            // 
            // DOB
            // 
            this.DOB.AutoSize = true;
            this.DOB.Location = new System.Drawing.Point(30, 240);
            this.DOB.Name = "DOB";
            this.DOB.Size = new System.Drawing.Size(30, 13);
            this.DOB.TabIndex = 6;
            this.DOB.Text = "DOB";
            // 
            // DOR
            // 
            this.DOR.AutoSize = true;
            this.DOR.Location = new System.Drawing.Point(303, 240);
            this.DOR.Name = "DOR";
            this.DOR.Size = new System.Drawing.Size(31, 13);
            this.DOR.TabIndex = 5;
            this.DOR.Text = "DOR";
            // 
            // Email
            // 
            this.Email.AutoSize = true;
            this.Email.Location = new System.Drawing.Point(30, 185);
            this.Email.Name = "Email";
            this.Email.Size = new System.Drawing.Size(32, 13);
            this.Email.TabIndex = 4;
            this.Email.Text = "Email";
            // 
            // Mobile
            // 
            this.Mobile.AutoSize = true;
            this.Mobile.Location = new System.Drawing.Point(303, 101);
            this.Mobile.Name = "Mobile";
            this.Mobile.Size = new System.Drawing.Size(38, 13);
            this.Mobile.TabIndex = 3;
            this.Mobile.Text = "Mobile";
            // 
            // Father_name
            // 
            this.Father_name.AutoSize = true;
            this.Father_name.Location = new System.Drawing.Point(22, 94);
            this.Father_name.Name = "Father_name";
            this.Father_name.Size = new System.Drawing.Size(65, 13);
            this.Father_name.TabIndex = 2;
            this.Father_name.Text = "FatherName";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(30, 48);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(57, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "First Name";
            // 
            // student_form
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1002, 572);
            this.Controls.Add(this.groupBox1);
            this.Name = "student_form";
            this.Text = "student_form";
            this.Load += new System.EventHandler(this.student_form_Load);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.TextBox city1;
        private System.Windows.Forms.RadioButton Female;
        private System.Windows.Forms.RadioButton Male;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.RichTextBox address1;
        private System.Windows.Forms.DateTimePicker registerdate;
        private System.Windows.Forms.DateTimePicker birthdate;
        private System.Windows.Forms.TextBox eadd;
        private System.Windows.Forms.ComboBox Class3;
        private System.Windows.Forms.ComboBox std;
        private System.Windows.Forms.TextBox mo;
        private System.Windows.Forms.TextBox faname;
        private System.Windows.Forms.TextBox lname;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox Fname;
        private System.Windows.Forms.Label city;
        private System.Windows.Forms.Label standrad;
        private System.Windows.Forms.Label Gender;
        private System.Windows.Forms.Label class1;
        private System.Windows.Forms.Label DOB;
        private System.Windows.Forms.Label DOR;
        private System.Windows.Forms.Label Email;
        private System.Windows.Forms.Label Mobile;
        private System.Windows.Forms.Label Father_name;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button save;
    }
}