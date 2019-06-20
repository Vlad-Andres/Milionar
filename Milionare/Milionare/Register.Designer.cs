namespace Milionare
{
    partial class Register
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
            this.reg_avatar_pic = new System.Windows.Forms.PictureBox();
            this.panel2 = new System.Windows.Forms.Panel();
            this.pictureBox3 = new System.Windows.Forms.PictureBox();
            this.username_txt = new System.Windows.Forms.TextBox();
            this.password_txt = new System.Windows.Forms.TextBox();
            this.panel1 = new System.Windows.Forms.Panel();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.name_txt = new System.Windows.Forms.TextBox();
            this.panel3 = new System.Windows.Forms.Panel();
            this.pictureBox2 = new System.Windows.Forms.PictureBox();
            this.mail_txt = new System.Windows.Forms.TextBox();
            this.panel4 = new System.Windows.Forms.Panel();
            this.pictureBox4 = new System.Windows.Forms.PictureBox();
            this.avatar_btn = new System.Windows.Forms.Button();
            this.reg_btn = new System.Windows.Forms.Button();
            this.exit_button = new System.Windows.Forms.Button();
            this.errorProvider1 = new System.Windows.Forms.ErrorProvider(this.components);
            this.panel5 = new System.Windows.Forms.Panel();
            this.pictureBox5 = new System.Windows.Forms.PictureBox();
            this.re_pass_txt = new System.Windows.Forms.TextBox();
            this.bunifuDragControl1 = new Bunifu.Framework.UI.BunifuDragControl(this.components);
            ((System.ComponentModel.ISupportInitialize)(this.reg_avatar_pic)).BeginInit();
            this.panel2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox3)).BeginInit();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.panel3.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).BeginInit();
            this.panel4.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox4)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.errorProvider1)).BeginInit();
            this.panel5.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox5)).BeginInit();
            this.SuspendLayout();
            // 
            // reg_avatar_pic
            // 
            this.reg_avatar_pic.BackColor = System.Drawing.Color.Transparent;
            this.reg_avatar_pic.Image = global::Milionare.Properties.Resources.register_lbl_icon;
            this.reg_avatar_pic.Location = new System.Drawing.Point(150, 12);
            this.reg_avatar_pic.Name = "reg_avatar_pic";
            this.reg_avatar_pic.Size = new System.Drawing.Size(150, 120);
            this.reg_avatar_pic.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.reg_avatar_pic.TabIndex = 1;
            this.reg_avatar_pic.TabStop = false;
            // 
            // panel2
            // 
            this.panel2.BackColor = System.Drawing.Color.Transparent;
            this.panel2.Controls.Add(this.pictureBox3);
            this.panel2.Controls.Add(this.username_txt);
            this.panel2.Location = new System.Drawing.Point(53, 224);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(368, 54);
            this.panel2.TabIndex = 2;
            // 
            // pictureBox3
            // 
            this.pictureBox3.Image = global::Milionare.Properties.Resources.username_icon;
            this.pictureBox3.Location = new System.Drawing.Point(0, 0);
            this.pictureBox3.Name = "pictureBox3";
            this.pictureBox3.Size = new System.Drawing.Size(64, 54);
            this.pictureBox3.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox3.TabIndex = 1;
            this.pictureBox3.TabStop = false;
            // 
            // username_txt
            // 
            this.username_txt.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(29)))), ((int)(((byte)(132)))), ((int)(((byte)(255)))));
            this.username_txt.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.username_txt.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F);
            this.username_txt.ForeColor = System.Drawing.Color.MediumAquamarine;
            this.username_txt.Location = new System.Drawing.Point(70, 13);
            this.username_txt.Name = "username_txt";
            this.username_txt.Size = new System.Drawing.Size(278, 29);
            this.username_txt.TabIndex = 0;
            this.username_txt.Text = "Username";
            this.username_txt.Enter += new System.EventHandler(this.username_txt_Enter);
            this.username_txt.Leave += new System.EventHandler(this.username_txt_Leave);
            // 
            // password_txt
            // 
            this.password_txt.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(29)))), ((int)(((byte)(132)))), ((int)(((byte)(255)))));
            this.password_txt.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.password_txt.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F);
            this.password_txt.ForeColor = System.Drawing.Color.MediumAquamarine;
            this.password_txt.Location = new System.Drawing.Point(67, 12);
            this.password_txt.Name = "password_txt";
            this.password_txt.Size = new System.Drawing.Size(278, 29);
            this.password_txt.TabIndex = 0;
            this.password_txt.Text = "Password";
            this.password_txt.Enter += new System.EventHandler(this.password_txt_Enter);
            this.password_txt.Leave += new System.EventHandler(this.password_txt_Leave);
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.Transparent;
            this.panel1.Controls.Add(this.pictureBox1);
            this.panel1.Controls.Add(this.name_txt);
            this.panel1.Location = new System.Drawing.Point(53, 164);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(368, 54);
            this.panel1.TabIndex = 1;
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = global::Milionare.Properties.Resources.name_icon;
            this.pictureBox1.Location = new System.Drawing.Point(0, 0);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(64, 54);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox1.TabIndex = 1;
            this.pictureBox1.TabStop = false;
            // 
            // name_txt
            // 
            this.name_txt.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(29)))), ((int)(((byte)(132)))), ((int)(((byte)(255)))));
            this.name_txt.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.name_txt.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F);
            this.name_txt.ForeColor = System.Drawing.Color.MediumAquamarine;
            this.name_txt.Location = new System.Drawing.Point(67, 13);
            this.name_txt.Name = "name_txt";
            this.name_txt.Size = new System.Drawing.Size(278, 29);
            this.name_txt.TabIndex = 0;
            this.name_txt.Text = "Name";
            this.name_txt.Enter += new System.EventHandler(this.name_txt_Enter);
            this.name_txt.Leave += new System.EventHandler(this.name_txt_Leave);
            // 
            // panel3
            // 
            this.panel3.BackColor = System.Drawing.Color.Transparent;
            this.panel3.Controls.Add(this.pictureBox2);
            this.panel3.Controls.Add(this.mail_txt);
            this.panel3.Location = new System.Drawing.Point(53, 284);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(368, 54);
            this.panel3.TabIndex = 3;
            // 
            // pictureBox2
            // 
            this.pictureBox2.Image = global::Milionare.Properties.Resources.email_icon;
            this.pictureBox2.Location = new System.Drawing.Point(0, 0);
            this.pictureBox2.Name = "pictureBox2";
            this.pictureBox2.Size = new System.Drawing.Size(64, 54);
            this.pictureBox2.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox2.TabIndex = 1;
            this.pictureBox2.TabStop = false;
            // 
            // mail_txt
            // 
            this.mail_txt.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(29)))), ((int)(((byte)(132)))), ((int)(((byte)(255)))));
            this.mail_txt.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.mail_txt.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F);
            this.mail_txt.ForeColor = System.Drawing.Color.MediumAquamarine;
            this.mail_txt.Location = new System.Drawing.Point(67, 13);
            this.mail_txt.Name = "mail_txt";
            this.mail_txt.Size = new System.Drawing.Size(278, 29);
            this.mail_txt.TabIndex = 0;
            this.mail_txt.Text = "abc@example.com";
            this.mail_txt.Enter += new System.EventHandler(this.mail_txt_Enter);
            this.mail_txt.Leave += new System.EventHandler(this.mail_txt_Leave);
            // 
            // panel4
            // 
            this.panel4.BackColor = System.Drawing.Color.Transparent;
            this.panel4.Controls.Add(this.pictureBox4);
            this.panel4.Controls.Add(this.password_txt);
            this.panel4.Location = new System.Drawing.Point(53, 344);
            this.panel4.Name = "panel4";
            this.panel4.Size = new System.Drawing.Size(368, 54);
            this.panel4.TabIndex = 4;
            // 
            // pictureBox4
            // 
            this.pictureBox4.Image = global::Milionare.Properties.Resources.pass_icon1;
            this.pictureBox4.Location = new System.Drawing.Point(0, 0);
            this.pictureBox4.Name = "pictureBox4";
            this.pictureBox4.Size = new System.Drawing.Size(64, 54);
            this.pictureBox4.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox4.TabIndex = 1;
            this.pictureBox4.TabStop = false;
            // 
            // avatar_btn
            // 
            this.avatar_btn.BackColor = System.Drawing.Color.Transparent;
            this.avatar_btn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.avatar_btn.ForeColor = System.Drawing.Color.White;
            this.avatar_btn.Location = new System.Drawing.Point(166, 135);
            this.avatar_btn.Name = "avatar_btn";
            this.avatar_btn.Size = new System.Drawing.Size(119, 23);
            this.avatar_btn.TabIndex = 6;
            this.avatar_btn.Text = "Choose avatar";
            this.avatar_btn.UseVisualStyleBackColor = false;
            this.avatar_btn.Click += new System.EventHandler(this.avatar_btn_Click);
            this.avatar_btn.MouseEnter += new System.EventHandler(this.avatar_btn_MouseEnter);
            this.avatar_btn.MouseLeave += new System.EventHandler(this.avatar_btn_MouseLeave);
            // 
            // reg_btn
            // 
            this.reg_btn.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(128)))), ((int)(((byte)(255)))));
            this.reg_btn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.reg_btn.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F);
            this.reg_btn.Location = new System.Drawing.Point(279, 482);
            this.reg_btn.Name = "reg_btn";
            this.reg_btn.Size = new System.Drawing.Size(142, 42);
            this.reg_btn.TabIndex = 7;
            this.reg_btn.Text = "Sign Up";
            this.reg_btn.UseVisualStyleBackColor = false;
            this.reg_btn.Click += new System.EventHandler(this.reg_btn_Click);
            this.reg_btn.MouseHover += new System.EventHandler(this.reg_btn_MouseHover);
            // 
            // exit_button
            // 
            this.exit_button.BackColor = System.Drawing.Color.Transparent;
            this.exit_button.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.exit_button.ForeColor = System.Drawing.Color.DimGray;
            this.exit_button.Location = new System.Drawing.Point(413, 12);
            this.exit_button.Name = "exit_button";
            this.exit_button.Size = new System.Drawing.Size(25, 26);
            this.exit_button.TabIndex = 0;
            this.exit_button.Text = "X";
            this.exit_button.UseVisualStyleBackColor = false;
            this.exit_button.Click += new System.EventHandler(this.exit_button_Click);
            // 
            // errorProvider1
            // 
            this.errorProvider1.ContainerControl = this;
            // 
            // panel5
            // 
            this.panel5.BackColor = System.Drawing.Color.Transparent;
            this.panel5.Controls.Add(this.pictureBox5);
            this.panel5.Controls.Add(this.re_pass_txt);
            this.panel5.Location = new System.Drawing.Point(53, 404);
            this.panel5.Name = "panel5";
            this.panel5.Size = new System.Drawing.Size(368, 54);
            this.panel5.TabIndex = 5;
            // 
            // pictureBox5
            // 
            this.pictureBox5.Image = global::Milionare.Properties.Resources.pass_icon1;
            this.pictureBox5.Location = new System.Drawing.Point(0, 0);
            this.pictureBox5.Name = "pictureBox5";
            this.pictureBox5.Size = new System.Drawing.Size(64, 54);
            this.pictureBox5.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox5.TabIndex = 1;
            this.pictureBox5.TabStop = false;
            // 
            // re_pass_txt
            // 
            this.re_pass_txt.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(29)))), ((int)(((byte)(132)))), ((int)(((byte)(255)))));
            this.re_pass_txt.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.re_pass_txt.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F);
            this.re_pass_txt.ForeColor = System.Drawing.Color.MediumAquamarine;
            this.re_pass_txt.Location = new System.Drawing.Point(67, 12);
            this.re_pass_txt.Name = "re_pass_txt";
            this.re_pass_txt.Size = new System.Drawing.Size(278, 29);
            this.re_pass_txt.TabIndex = 0;
            this.re_pass_txt.Text = "Retype password";
            this.re_pass_txt.Enter += new System.EventHandler(this.re_pass_txt_Enter);
            this.re_pass_txt.Leave += new System.EventHandler(this.re_pass_txt_Leave);
            this.re_pass_txt.MouseLeave += new System.EventHandler(this.re_pass_txt_MouseLeave);
            // 
            // bunifuDragControl1
            // 
            this.bunifuDragControl1.Fixed = true;
            this.bunifuDragControl1.Horizontal = true;
            this.bunifuDragControl1.TargetControl = this;
            this.bunifuDragControl1.Vertical = true;
            // 
            // Register
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ActiveBorder;
            this.BackgroundImage = global::Milionare.Properties.Resources.gradient_bkg;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(450, 545);
            this.ControlBox = false;
            this.Controls.Add(this.panel5);
            this.Controls.Add(this.exit_button);
            this.Controls.Add(this.reg_btn);
            this.Controls.Add(this.avatar_btn);
            this.Controls.Add(this.panel4);
            this.Controls.Add(this.panel3);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.reg_avatar_pic);
            this.DoubleBuffered = true;
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "Register";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            ((System.ComponentModel.ISupportInitialize)(this.reg_avatar_pic)).EndInit();
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox3)).EndInit();
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.panel3.ResumeLayout(false);
            this.panel3.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).EndInit();
            this.panel4.ResumeLayout(false);
            this.panel4.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox4)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.errorProvider1)).EndInit();
            this.panel5.ResumeLayout(false);
            this.panel5.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox5)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.PictureBox reg_avatar_pic;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.PictureBox pictureBox3;
        private System.Windows.Forms.TextBox password_txt;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.TextBox name_txt;
        private System.Windows.Forms.Panel panel3;
        private System.Windows.Forms.PictureBox pictureBox2;
        private System.Windows.Forms.TextBox mail_txt;
        private System.Windows.Forms.Panel panel4;
        private System.Windows.Forms.PictureBox pictureBox4;
        private System.Windows.Forms.TextBox username_txt;
        private System.Windows.Forms.Button avatar_btn;
        private System.Windows.Forms.Button reg_btn;
        private System.Windows.Forms.Button exit_button;
        private System.Windows.Forms.ErrorProvider errorProvider1;
        private System.Windows.Forms.Panel panel5;
        private System.Windows.Forms.PictureBox pictureBox5;
        private System.Windows.Forms.TextBox re_pass_txt;
        private Bunifu.Framework.UI.BunifuDragControl bunifuDragControl1;
    }
}