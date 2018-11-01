namespace Milionare
{
    partial class login
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
            this.username_txt = new System.Windows.Forms.TextBox();
            this.panel1 = new System.Windows.Forms.Panel();
            this.pictureBox2 = new System.Windows.Forms.PictureBox();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.panel2 = new System.Windows.Forms.Panel();
            this.pictureBox3 = new System.Windows.Forms.PictureBox();
            this.password_txt = new System.Windows.Forms.TextBox();
            this.login_btn = new System.Windows.Forms.Button();
            this.bunifuDragControl1 = new Bunifu.Framework.UI.BunifuDragControl(this.components);
            this.remember_checkbx = new System.Windows.Forms.CheckBox();
            this.pass_lost = new MaterialSkin.Controls.MaterialLabel();
            this.register_lbl = new MaterialSkin.Controls.MaterialLabel();
            this.exit_button = new System.Windows.Forms.Button();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.panel2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox3)).BeginInit();
            this.SuspendLayout();
            // 
            // username_txt
            // 
            this.username_txt.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(29)))), ((int)(((byte)(132)))), ((int)(((byte)(255)))));
            this.username_txt.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.username_txt.Font = new System.Drawing.Font("Century Gothic", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.username_txt.ForeColor = System.Drawing.Color.White;
            this.username_txt.Location = new System.Drawing.Point(67, 19);
            this.username_txt.Name = "username_txt";
            this.username_txt.Size = new System.Drawing.Size(278, 33);
            this.username_txt.TabIndex = 0;
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.Transparent;
            this.panel1.Controls.Add(this.pictureBox2);
            this.panel1.Controls.Add(this.username_txt);
            this.panel1.Location = new System.Drawing.Point(47, 213);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(353, 60);
            this.panel1.TabIndex = 1;
            // 
            // pictureBox2
            // 
            this.pictureBox2.Image = global::Milionare.Properties.Resources.login_icon;
            this.pictureBox2.Location = new System.Drawing.Point(0, 0);
            this.pictureBox2.Name = "pictureBox2";
            this.pictureBox2.Size = new System.Drawing.Size(64, 60);
            this.pictureBox2.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox2.TabIndex = 1;
            this.pictureBox2.TabStop = false;
            // 
            // pictureBox1
            // 
            this.pictureBox1.BackColor = System.Drawing.Color.Transparent;
            this.pictureBox1.Image = global::Milionare.Properties.Resources.power2;
            this.pictureBox1.Location = new System.Drawing.Point(147, 21);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(147, 147);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox1.TabIndex = 2;
            this.pictureBox1.TabStop = false;
            // 
            // panel2
            // 
            this.panel2.BackColor = System.Drawing.Color.Transparent;
            this.panel2.Controls.Add(this.pictureBox3);
            this.panel2.Controls.Add(this.password_txt);
            this.panel2.Location = new System.Drawing.Point(47, 293);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(353, 60);
            this.panel2.TabIndex = 3;
            // 
            // pictureBox3
            // 
            this.pictureBox3.Image = global::Milionare.Properties.Resources.pass_icon;
            this.pictureBox3.Location = new System.Drawing.Point(0, 0);
            this.pictureBox3.Name = "pictureBox3";
            this.pictureBox3.Size = new System.Drawing.Size(64, 60);
            this.pictureBox3.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox3.TabIndex = 1;
            this.pictureBox3.TabStop = false;
            // 
            // password_txt
            // 
            this.password_txt.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(29)))), ((int)(((byte)(132)))), ((int)(((byte)(255)))));
            this.password_txt.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.password_txt.Font = new System.Drawing.Font("Microsoft Sans Serif", 16F);
            this.password_txt.ForeColor = System.Drawing.Color.White;
            this.password_txt.Location = new System.Drawing.Point(67, 19);
            this.password_txt.Name = "password_txt";
            this.password_txt.Size = new System.Drawing.Size(278, 32);
            this.password_txt.TabIndex = 0;
            this.password_txt.UseSystemPasswordChar = true;
            // 
            // login_btn
            // 
            this.login_btn.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(128)))), ((int)(((byte)(255)))));
            this.login_btn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.login_btn.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F);
            this.login_btn.Location = new System.Drawing.Point(152, 401);
            this.login_btn.Name = "login_btn";
            this.login_btn.Size = new System.Drawing.Size(142, 42);
            this.login_btn.TabIndex = 4;
            this.login_btn.Text = "Log In";
            this.login_btn.UseVisualStyleBackColor = false;
            this.login_btn.Click += new System.EventHandler(this.login_btn_Click);
            // 
            // bunifuDragControl1
            // 
            this.bunifuDragControl1.Fixed = true;
            this.bunifuDragControl1.Horizontal = true;
            this.bunifuDragControl1.TargetControl = this;
            this.bunifuDragControl1.Vertical = true;
            // 
            // remember_checkbx
            // 
            this.remember_checkbx.AutoSize = true;
            this.remember_checkbx.BackColor = System.Drawing.Color.Transparent;
            this.remember_checkbx.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            this.remember_checkbx.ForeColor = System.Drawing.Color.White;
            this.remember_checkbx.Location = new System.Drawing.Point(47, 359);
            this.remember_checkbx.Name = "remember_checkbx";
            this.remember_checkbx.Size = new System.Drawing.Size(123, 21);
            this.remember_checkbx.TabIndex = 6;
            this.remember_checkbx.Text = "Remember me ";
            this.remember_checkbx.UseVisualStyleBackColor = false;
            this.remember_checkbx.CheckedChanged += new System.EventHandler(this.remember_checkbx_CheckedChanged);
            // 
            // pass_lost
            // 
            this.pass_lost.AutoSize = true;
            this.pass_lost.BackColor = System.Drawing.Color.Transparent;
            this.pass_lost.Depth = 0;
            this.pass_lost.Font = new System.Drawing.Font("Roboto", 11F);
            this.pass_lost.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(222)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.pass_lost.Location = new System.Drawing.Point(43, 460);
            this.pass_lost.MouseState = MaterialSkin.MouseState.HOVER;
            this.pass_lost.Name = "pass_lost";
            this.pass_lost.Size = new System.Drawing.Size(152, 19);
            this.pass_lost.TabIndex = 7;
            this.pass_lost.Text = "Lost yout password ?";
            this.pass_lost.Click += new System.EventHandler(this.pass_lost_Click);
            // 
            // register_lbl
            // 
            this.register_lbl.AutoSize = true;
            this.register_lbl.BackColor = System.Drawing.Color.Transparent;
            this.register_lbl.Depth = 0;
            this.register_lbl.Font = new System.Drawing.Font("Roboto", 11F);
            this.register_lbl.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(222)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.register_lbl.Location = new System.Drawing.Point(336, 460);
            this.register_lbl.MouseState = MaterialSkin.MouseState.HOVER;
            this.register_lbl.Name = "register_lbl";
            this.register_lbl.Size = new System.Drawing.Size(64, 19);
            this.register_lbl.TabIndex = 8;
            this.register_lbl.Text = "Register";
            this.register_lbl.Click += new System.EventHandler(this.register_lbl_Click);
            // 
            // exit_button
            // 
            this.exit_button.BackColor = System.Drawing.Color.Transparent;
            this.exit_button.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.exit_button.ForeColor = System.Drawing.Color.DimGray;
            this.exit_button.Location = new System.Drawing.Point(413, 12);
            this.exit_button.Name = "exit_button";
            this.exit_button.Size = new System.Drawing.Size(25, 26);
            this.exit_button.TabIndex = 9;
            this.exit_button.Text = "X";
            this.exit_button.UseVisualStyleBackColor = false;
            this.exit_button.Click += new System.EventHandler(this.exit_button_Click);
            // 
            // login
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = global::Milionare.Properties.Resources.gradient_bkg;
            this.ClientSize = new System.Drawing.Size(450, 500);
            this.ControlBox = false;
            this.Controls.Add(this.exit_button);
            this.Controls.Add(this.register_lbl);
            this.Controls.Add(this.pass_lost);
            this.Controls.Add(this.remember_checkbx);
            this.Controls.Add(this.login_btn);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.panel1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "login";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.FormClosed += new System.Windows.Forms.FormClosedEventHandler(this.login_FormClosed);
            this.Load += new System.EventHandler(this.login_Load);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox3)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox username_txt;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.PictureBox pictureBox2;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.PictureBox pictureBox3;
        private System.Windows.Forms.TextBox password_txt;
        private System.Windows.Forms.Button login_btn;
        private Bunifu.Framework.UI.BunifuDragControl bunifuDragControl1;
        private System.Windows.Forms.CheckBox remember_checkbx;
        private MaterialSkin.Controls.MaterialLabel pass_lost;
        private MaterialSkin.Controls.MaterialLabel register_lbl;
        private System.Windows.Forms.Button exit_button;
    }
}