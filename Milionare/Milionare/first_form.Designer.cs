namespace Milionare
{
    partial class first_form
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
            this.science_btn = new System.Windows.Forms.Button();
            this.exit_button = new System.Windows.Forms.Button();
            this.bunifuElipse1 = new Bunifu.Framework.UI.BunifuElipse(this.components);
            this.sport_btn = new System.Windows.Forms.Button();
            this.history_btn = new System.Windows.Forms.Button();
            this.arts_btn = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.login_lbl = new System.Windows.Forms.Label();
            this.reg_lbl = new System.Windows.Forms.Label();
            this.slash_lbl = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // science_btn
            // 
            this.science_btn.BackColor = System.Drawing.Color.Transparent;
            this.science_btn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.science_btn.Font = new System.Drawing.Font("Microsoft Sans Serif", 26.25F);
            this.science_btn.ForeColor = System.Drawing.Color.Silver;
            this.science_btn.Location = new System.Drawing.Point(179, 127);
            this.science_btn.Name = "science_btn";
            this.science_btn.Size = new System.Drawing.Size(181, 56);
            this.science_btn.TabIndex = 0;
            this.science_btn.Text = "Science";
            this.science_btn.UseVisualStyleBackColor = false;
            this.science_btn.Click += new System.EventHandler(this.science_btn_Click);
            // 
            // exit_button
            // 
            this.exit_button.BackColor = System.Drawing.Color.Transparent;
            this.exit_button.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.exit_button.ForeColor = System.Drawing.Color.DimGray;
            this.exit_button.Location = new System.Drawing.Point(790, 12);
            this.exit_button.Name = "exit_button";
            this.exit_button.Size = new System.Drawing.Size(25, 26);
            this.exit_button.TabIndex = 1;
            this.exit_button.Text = "X";
            this.exit_button.UseVisualStyleBackColor = false;
            this.exit_button.Click += new System.EventHandler(this.exit_button_Click);
            // 
            // bunifuElipse1
            // 
            this.bunifuElipse1.ElipseRadius = 5;
            this.bunifuElipse1.TargetControl = this;
            // 
            // sport_btn
            // 
            this.sport_btn.BackColor = System.Drawing.Color.Transparent;
            this.sport_btn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.sport_btn.Font = new System.Drawing.Font("Microsoft Sans Serif", 26.25F);
            this.sport_btn.ForeColor = System.Drawing.Color.Silver;
            this.sport_btn.Location = new System.Drawing.Point(468, 127);
            this.sport_btn.Name = "sport_btn";
            this.sport_btn.Size = new System.Drawing.Size(181, 56);
            this.sport_btn.TabIndex = 2;
            this.sport_btn.Text = "Sport";
            this.sport_btn.UseVisualStyleBackColor = false;
            this.sport_btn.Click += new System.EventHandler(this.sport_Click);
            // 
            // history_btn
            // 
            this.history_btn.BackColor = System.Drawing.Color.Transparent;
            this.history_btn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.history_btn.Font = new System.Drawing.Font("Microsoft Sans Serif", 26.25F);
            this.history_btn.ForeColor = System.Drawing.Color.Silver;
            this.history_btn.Location = new System.Drawing.Point(468, 303);
            this.history_btn.Name = "history_btn";
            this.history_btn.Size = new System.Drawing.Size(181, 56);
            this.history_btn.TabIndex = 4;
            this.history_btn.Text = "History";
            this.history_btn.UseVisualStyleBackColor = false;
            this.history_btn.Click += new System.EventHandler(this.history_btn_Click);
            // 
            // arts_btn
            // 
            this.arts_btn.BackColor = System.Drawing.Color.Transparent;
            this.arts_btn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.arts_btn.Font = new System.Drawing.Font("Microsoft Sans Serif", 26.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.arts_btn.ForeColor = System.Drawing.Color.Silver;
            this.arts_btn.Location = new System.Drawing.Point(179, 303);
            this.arts_btn.Name = "arts_btn";
            this.arts_btn.Size = new System.Drawing.Size(181, 56);
            this.arts_btn.TabIndex = 3;
            this.arts_btn.Text = "Arts";
            this.arts_btn.UseVisualStyleBackColor = false;
            this.arts_btn.Click += new System.EventHandler(this.arts_btn_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.Transparent;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 16.25F);
            this.label1.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.label1.Location = new System.Drawing.Point(12, 12);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(186, 26);
            this.label1.TabIndex = 5;
            this.label1.Text = "Back Stage (beta)";
            this.label1.Click += new System.EventHandler(this.label1_Click);
            this.label1.MouseLeave += new System.EventHandler(this.label1_MouseLeave);
            this.label1.MouseHover += new System.EventHandler(this.label1_MouseHover);
            // 
            // login_lbl
            // 
            this.login_lbl.AutoEllipsis = true;
            this.login_lbl.AutoSize = true;
            this.login_lbl.BackColor = System.Drawing.Color.Transparent;
            this.login_lbl.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            this.login_lbl.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.login_lbl.Location = new System.Drawing.Point(650, 21);
            this.login_lbl.Name = "login_lbl";
            this.login_lbl.Size = new System.Drawing.Size(43, 17);
            this.login_lbl.TabIndex = 6;
            this.login_lbl.Text = "Login";
            this.login_lbl.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.login_lbl.Click += new System.EventHandler(this.login_lbl_Click);
            this.login_lbl.MouseEnter += new System.EventHandler(this.login_lbl_MouseEnter);
            this.login_lbl.MouseLeave += new System.EventHandler(this.login_lbl_MouseLeave);
            // 
            // reg_lbl
            // 
            this.reg_lbl.AutoSize = true;
            this.reg_lbl.BackColor = System.Drawing.Color.Transparent;
            this.reg_lbl.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            this.reg_lbl.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.reg_lbl.Location = new System.Drawing.Point(699, 21);
            this.reg_lbl.Name = "reg_lbl";
            this.reg_lbl.Size = new System.Drawing.Size(61, 17);
            this.reg_lbl.TabIndex = 7;
            this.reg_lbl.Text = "Register";
            this.reg_lbl.Click += new System.EventHandler(this.reg_lbl_Click);
            this.reg_lbl.MouseEnter += new System.EventHandler(this.reg_lbl_MouseEnter);
            this.reg_lbl.MouseLeave += new System.EventHandler(this.reg_lbl_MouseLeave);
            // 
            // slash_lbl
            // 
            this.slash_lbl.AutoSize = true;
            this.slash_lbl.BackColor = System.Drawing.Color.Transparent;
            this.slash_lbl.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            this.slash_lbl.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.slash_lbl.Location = new System.Drawing.Point(690, 21);
            this.slash_lbl.Name = "slash_lbl";
            this.slash_lbl.Size = new System.Drawing.Size(12, 17);
            this.slash_lbl.TabIndex = 8;
            this.slash_lbl.Text = "/";
            // 
            // first_form
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = global::Milionare.Properties.Resources.dark_blue_wallpaper_10;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.ClientSize = new System.Drawing.Size(827, 517);
            this.ControlBox = false;
            this.Controls.Add(this.slash_lbl);
            this.Controls.Add(this.reg_lbl);
            this.Controls.Add(this.login_lbl);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.history_btn);
            this.Controls.Add(this.arts_btn);
            this.Controls.Add(this.sport_btn);
            this.Controls.Add(this.exit_button);
            this.Controls.Add(this.science_btn);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "first_form";
            this.Load += new System.EventHandler(this.first_form_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button science_btn;
        private System.Windows.Forms.Button exit_button;
        private Bunifu.Framework.UI.BunifuElipse bunifuElipse1;
        private System.Windows.Forms.Button history_btn;
        private System.Windows.Forms.Button arts_btn;
        private System.Windows.Forms.Button sport_btn;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label login_lbl;
        private System.Windows.Forms.Label reg_lbl;
        private System.Windows.Forms.Label slash_lbl;
    }
}

