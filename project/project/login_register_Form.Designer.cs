namespace project
{
    partial class login_register_Form
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
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(login_register_Form));
            this.panel1 = new System.Windows.Forms.Panel();
            this.panel3 = new System.Windows.Forms.Panel();
            this.buttonclose = new System.Windows.Forms.Button();
            this.buttonminize = new System.Windows.Forms.Button();
            this.panel2 = new System.Windows.Forms.Panel();
            this.alreadyaccount = new System.Windows.Forms.Label();
            this.gotoregister = new System.Windows.Forms.Label();
            this.rigister = new System.Windows.Forms.Button();
            this.browse = new System.Windows.Forms.Button();
            this.profile = new System.Windows.Forms.PictureBox();
            this.label10 = new System.Windows.Forms.Label();
            this.newfirstname = new System.Windows.Forms.TextBox();
            this.newlestname = new System.Windows.Forms.TextBox();
            this.newusername = new System.Windows.Forms.TextBox();
            this.newpassword = new System.Windows.Forms.TextBox();
            this.label8 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.login = new System.Windows.Forms.Button();
            this.oldusername = new System.Windows.Forms.TextBox();
            this.oldpassword = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.timer1 = new System.Windows.Forms.Timer(this.components);
            this.timer2 = new System.Windows.Forms.Timer(this.components);
            this.panel1.SuspendLayout();
            this.panel3.SuspendLayout();
            this.panel2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.profile)).BeginInit();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.SystemColors.ButtonShadow;
            this.panel1.Controls.Add(this.panel3);
            this.panel1.Controls.Add(this.panel2);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(945, 561);
            this.panel1.TabIndex = 0;
            this.panel1.Paint += new System.Windows.Forms.PaintEventHandler(this.panel1_Paint);
            // 
            // panel3
            // 
            this.panel3.Controls.Add(this.buttonclose);
            this.panel3.Controls.Add(this.buttonminize);
            this.panel3.Location = new System.Drawing.Point(0, 0);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(425, 46);
            this.panel3.TabIndex = 3;
            // 
            // buttonclose
            // 
            this.buttonclose.Image = ((System.Drawing.Image)(resources.GetObject("buttonclose.Image")));
            this.buttonclose.Location = new System.Drawing.Point(335, 3);
            this.buttonclose.Name = "buttonclose";
            this.buttonclose.Size = new System.Drawing.Size(90, 43);
            this.buttonclose.TabIndex = 1;
            this.buttonclose.UseVisualStyleBackColor = true;
            this.buttonclose.Click += new System.EventHandler(this.buttonclose_Click_1);
            // 
            // buttonminize
            // 
            this.buttonminize.Image = ((System.Drawing.Image)(resources.GetObject("buttonminize.Image")));
            this.buttonminize.Location = new System.Drawing.Point(251, 3);
            this.buttonminize.Name = "buttonminize";
            this.buttonminize.Size = new System.Drawing.Size(90, 43);
            this.buttonminize.TabIndex = 2;
            this.buttonminize.UseVisualStyleBackColor = true;
            this.buttonminize.Click += new System.EventHandler(this.buttonminize_Click);
            // 
            // panel2
            // 
            this.panel2.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.panel2.Controls.Add(this.alreadyaccount);
            this.panel2.Controls.Add(this.gotoregister);
            this.panel2.Controls.Add(this.rigister);
            this.panel2.Controls.Add(this.browse);
            this.panel2.Controls.Add(this.profile);
            this.panel2.Controls.Add(this.label10);
            this.panel2.Controls.Add(this.newfirstname);
            this.panel2.Controls.Add(this.newlestname);
            this.panel2.Controls.Add(this.newusername);
            this.panel2.Controls.Add(this.newpassword);
            this.panel2.Controls.Add(this.label8);
            this.panel2.Controls.Add(this.label7);
            this.panel2.Controls.Add(this.label6);
            this.panel2.Controls.Add(this.label5);
            this.panel2.Controls.Add(this.label4);
            this.panel2.Controls.Add(this.login);
            this.panel2.Controls.Add(this.oldusername);
            this.panel2.Controls.Add(this.oldpassword);
            this.panel2.Controls.Add(this.label3);
            this.panel2.Controls.Add(this.label2);
            this.panel2.Controls.Add(this.label1);
            this.panel2.Location = new System.Drawing.Point(0, 44);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(945, 517);
            this.panel2.TabIndex = 0;
            this.panel2.Paint += new System.Windows.Forms.PaintEventHandler(this.panel2_Paint);
            // 
            // alreadyaccount
            // 
            this.alreadyaccount.AutoSize = true;
            this.alreadyaccount.Font = new System.Drawing.Font("Modern No. 20", 21.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.alreadyaccount.Location = new System.Drawing.Point(566, 461);
            this.alreadyaccount.Name = "alreadyaccount";
            this.alreadyaccount.Size = new System.Drawing.Size(210, 31);
            this.alreadyaccount.TabIndex = 20;
            this.alreadyaccount.Text = "already account";
            this.alreadyaccount.Click += new System.EventHandler(this.label9_Click);
            // 
            // gotoregister
            // 
            this.gotoregister.AutoSize = true;
            this.gotoregister.Font = new System.Drawing.Font("Modern No. 20", 21.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.gotoregister.Location = new System.Drawing.Point(5, 429);
            this.gotoregister.Name = "gotoregister";
            this.gotoregister.Size = new System.Drawing.Size(255, 31);
            this.gotoregister.TabIndex = 4;
            this.gotoregister.Text = "Don\'t have account";
            this.gotoregister.Click += new System.EventHandler(this.gotoregister_Click);
            // 
            // rigister
            // 
            this.rigister.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(192)))), ((int)(((byte)(192)))));
            this.rigister.Font = new System.Drawing.Font("Lucida Sans Unicode", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.rigister.Location = new System.Drawing.Point(572, 423);
            this.rigister.Name = "rigister";
            this.rigister.Size = new System.Drawing.Size(222, 38);
            this.rigister.TabIndex = 19;
            this.rigister.Text = "Rigister";
            this.rigister.UseVisualStyleBackColor = false;
            this.rigister.Click += new System.EventHandler(this.rigister_Click);
            // 
            // browse
            // 
            this.browse.Location = new System.Drawing.Point(648, 377);
            this.browse.Name = "browse";
            this.browse.Size = new System.Drawing.Size(146, 23);
            this.browse.TabIndex = 18;
            this.browse.Text = "Browse";
            this.browse.UseVisualStyleBackColor = true;
            this.browse.Click += new System.EventHandler(this.browse_Click);
            // 
            // profile
            // 
            this.profile.Location = new System.Drawing.Point(648, 278);
            this.profile.Name = "profile";
            this.profile.Size = new System.Drawing.Size(146, 93);
            this.profile.TabIndex = 17;
            this.profile.TabStop = false;
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Font = new System.Drawing.Font("Shruti", 20.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label10.Location = new System.Drawing.Point(497, 278);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(98, 45);
            this.label10.TabIndex = 16;
            this.label10.Text = "Image:";
            // 
            // newfirstname
            // 
            this.newfirstname.BackColor = System.Drawing.SystemColors.ScrollBar;
            this.newfirstname.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.newfirstname.Cursor = System.Windows.Forms.Cursors.Default;
            this.newfirstname.Location = new System.Drawing.Point(648, 125);
            this.newfirstname.Name = "newfirstname";
            this.newfirstname.Size = new System.Drawing.Size(146, 20);
            this.newfirstname.TabIndex = 14;
            // 
            // newlestname
            // 
            this.newlestname.BackColor = System.Drawing.SystemColors.ScrollBar;
            this.newlestname.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.newlestname.Cursor = System.Windows.Forms.Cursors.Default;
            this.newlestname.Location = new System.Drawing.Point(648, 158);
            this.newlestname.Name = "newlestname";
            this.newlestname.Size = new System.Drawing.Size(146, 20);
            this.newlestname.TabIndex = 13;
            // 
            // newusername
            // 
            this.newusername.BackColor = System.Drawing.SystemColors.ScrollBar;
            this.newusername.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.newusername.Cursor = System.Windows.Forms.Cursors.Default;
            this.newusername.Location = new System.Drawing.Point(648, 203);
            this.newusername.Name = "newusername";
            this.newusername.Size = new System.Drawing.Size(146, 20);
            this.newusername.TabIndex = 12;
            // 
            // newpassword
            // 
            this.newpassword.BackColor = System.Drawing.SystemColors.ScrollBar;
            this.newpassword.Location = new System.Drawing.Point(648, 239);
            this.newpassword.Name = "newpassword";
            this.newpassword.Size = new System.Drawing.Size(146, 20);
            this.newpassword.TabIndex = 11;
            this.newpassword.UseSystemPasswordChar = true;
            this.newpassword.TextChanged += new System.EventHandler(this.newpassword_TextChanged);
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Font = new System.Drawing.Font("Shruti", 20.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label8.Location = new System.Drawing.Point(497, 110);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(156, 45);
            this.label8.TabIndex = 10;
            this.label8.Text = "First Name:";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Shruti", 20.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label7.Location = new System.Drawing.Point(497, 146);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(154, 45);
            this.label7.TabIndex = 9;
            this.label7.Text = "Lest Name:";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Shruti", 20.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.Location = new System.Drawing.Point(497, 191);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(160, 45);
            this.label6.TabIndex = 8;
            this.label6.Text = "User Name:";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Shruti", 20.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(497, 227);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(140, 45);
            this.label5.TabIndex = 7;
            this.label5.Text = "Password:";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.BackColor = System.Drawing.Color.Transparent;
            this.label4.Font = new System.Drawing.Font("Monotype Corsiva", 36F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.ForeColor = System.Drawing.Color.White;
            this.label4.Location = new System.Drawing.Point(495, 40);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(385, 57);
            this.label4.TabIndex = 6;
            this.label4.Text = "create New Account";
            // 
            // login
            // 
            this.login.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(192)))), ((int)(((byte)(192)))));
            this.login.Font = new System.Drawing.Font("Lucida Sans Unicode", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.login.Location = new System.Drawing.Point(116, 278);
            this.login.Name = "login";
            this.login.Size = new System.Drawing.Size(131, 38);
            this.login.TabIndex = 3;
            this.login.Text = "Login";
            this.login.UseVisualStyleBackColor = false;
            // 
            // oldusername
            // 
            this.oldusername.BackColor = System.Drawing.SystemColors.ScrollBar;
            this.oldusername.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.oldusername.Cursor = System.Windows.Forms.Cursors.Default;
            this.oldusername.Location = new System.Drawing.Point(177, 152);
            this.oldusername.Name = "oldusername";
            this.oldusername.Size = new System.Drawing.Size(146, 20);
            this.oldusername.TabIndex = 1;
            this.oldusername.TextChanged += new System.EventHandler(this.oldusername_TextChanged);
            // 
            // oldpassword
            // 
            this.oldpassword.BackColor = System.Drawing.SystemColors.ScrollBar;
            this.oldpassword.Location = new System.Drawing.Point(177, 227);
            this.oldpassword.Name = "oldpassword";
            this.oldpassword.Size = new System.Drawing.Size(146, 20);
            this.oldpassword.TabIndex = 2;
            this.oldpassword.UseSystemPasswordChar = true;
            this.oldpassword.TextChanged += new System.EventHandler(this.oldpassword_TextChanged);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Shruti", 20.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(38, 212);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(140, 45);
            this.label3.TabIndex = 2;
            this.label3.Text = "Password:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Shruti", 20.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(32, 137);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(160, 45);
            this.label2.TabIndex = 1;
            this.label2.Text = "User Name:";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.Transparent;
            this.label1.Font = new System.Drawing.Font("Monotype Corsiva", 48F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.White;
            this.label1.Location = new System.Drawing.Point(43, 40);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(382, 79);
            this.label1.TabIndex = 0;
            this.label1.Text = "Account Login";
            this.label1.Click += new System.EventHandler(this.label1_Click);
            // 
            // timer1
            // 
            this.timer1.Tick += new System.EventHandler(this.timer1_Tick);
            // 
            // timer2
            // 
            this.timer2.Tick += new System.EventHandler(this.timer2_Tick);
            // 
            // login_register_Form
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(945, 561);
            this.Controls.Add(this.panel1);
            this.Name = "login_register_Form";
            this.Text = "login_register_Form";
            this.Load += new System.EventHandler(this.login_register_Form_Load);
            this.panel1.ResumeLayout(false);
            this.panel3.ResumeLayout(false);
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.profile)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Button login;
        private System.Windows.Forms.TextBox oldusername;
        private System.Windows.Forms.TextBox oldpassword;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox newfirstname;
        private System.Windows.Forms.TextBox newlestname;
        private System.Windows.Forms.TextBox newusername;
        private System.Windows.Forms.TextBox newpassword;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.PictureBox profile;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.Button rigister;
        private System.Windows.Forms.Button browse;
        private System.Windows.Forms.Label gotoregister;
        private System.Windows.Forms.Label alreadyaccount;
        private System.Windows.Forms.Button buttonminize;
        private System.Windows.Forms.Button buttonclose;
        private System.Windows.Forms.Panel panel3;
        private System.Windows.Forms.Timer timer1;
        private System.Windows.Forms.Timer timer2;
    }
}