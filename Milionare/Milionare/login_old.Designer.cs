namespace Milionare
{
    partial class login_old
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
            this.nick_txt = new MaterialSkin.Controls.MaterialSingleLineTextField();
            this.pass_txt = new MaterialSkin.Controls.MaterialSingleLineTextField();
            this.materialCheckBox1 = new MaterialSkin.Controls.MaterialCheckBox();
            this.login_btn = new MaterialSkin.Controls.MaterialRaisedButton();
            this.materialDivider1 = new MaterialSkin.Controls.MaterialDivider();
            this.pass_lost = new MaterialSkin.Controls.MaterialLabel();
            this.register_lbl = new MaterialSkin.Controls.MaterialLabel();
            this.SuspendLayout();
            // 
            // nick_txt
            // 
            this.nick_txt.Depth = 0;
            this.nick_txt.Hint = "Username";
            this.nick_txt.Location = new System.Drawing.Point(34, 87);
            this.nick_txt.MouseState = MaterialSkin.MouseState.HOVER;
            this.nick_txt.Name = "nick_txt";
            this.nick_txt.PasswordChar = '\0';
            this.nick_txt.SelectedText = "";
            this.nick_txt.SelectionLength = 0;
            this.nick_txt.SelectionStart = 0;
            this.nick_txt.Size = new System.Drawing.Size(254, 23);
            this.nick_txt.TabIndex = 0;
            this.nick_txt.UseSystemPasswordChar = false;
            // 
            // pass_txt
            // 
            this.pass_txt.Depth = 0;
            this.pass_txt.Hint = "Password";
            this.pass_txt.Location = new System.Drawing.Point(34, 126);
            this.pass_txt.MouseState = MaterialSkin.MouseState.HOVER;
            this.pass_txt.Name = "pass_txt";
            this.pass_txt.PasswordChar = '*';
            this.pass_txt.SelectedText = "";
            this.pass_txt.SelectionLength = 0;
            this.pass_txt.SelectionStart = 0;
            this.pass_txt.Size = new System.Drawing.Size(254, 23);
            this.pass_txt.TabIndex = 1;
            this.pass_txt.UseSystemPasswordChar = true;
            // 
            // materialCheckBox1
            // 
            this.materialCheckBox1.AutoSize = true;
            this.materialCheckBox1.Depth = 0;
            this.materialCheckBox1.Font = new System.Drawing.Font("Roboto", 10F);
            this.materialCheckBox1.Location = new System.Drawing.Point(34, 174);
            this.materialCheckBox1.Margin = new System.Windows.Forms.Padding(0);
            this.materialCheckBox1.MouseLocation = new System.Drawing.Point(-1, -1);
            this.materialCheckBox1.MouseState = MaterialSkin.MouseState.HOVER;
            this.materialCheckBox1.Name = "materialCheckBox1";
            this.materialCheckBox1.Ripple = true;
            this.materialCheckBox1.Size = new System.Drawing.Size(120, 30);
            this.materialCheckBox1.TabIndex = 2;
            this.materialCheckBox1.Text = "Remember me ";
            this.materialCheckBox1.UseVisualStyleBackColor = true;
            this.materialCheckBox1.CheckedChanged += new System.EventHandler(this.materialCheckBox1_CheckedChanged);
            // 
            // login_btn
            // 
            this.login_btn.Depth = 0;
            this.login_btn.Location = new System.Drawing.Point(213, 221);
            this.login_btn.MouseState = MaterialSkin.MouseState.HOVER;
            this.login_btn.Name = "login_btn";
            this.login_btn.Primary = true;
            this.login_btn.Size = new System.Drawing.Size(75, 23);
            this.login_btn.TabIndex = 3;
            this.login_btn.Text = "Login";
            this.login_btn.UseVisualStyleBackColor = true;
            this.login_btn.Click += new System.EventHandler(this.login_btn_Click);
            // 
            // materialDivider1
            // 
            this.materialDivider1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(31)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.materialDivider1.Depth = 0;
            this.materialDivider1.Location = new System.Drawing.Point(34, 259);
            this.materialDivider1.MouseState = MaterialSkin.MouseState.HOVER;
            this.materialDivider1.Name = "materialDivider1";
            this.materialDivider1.Size = new System.Drawing.Size(254, 1);
            this.materialDivider1.TabIndex = 4;
            // 
            // pass_lost
            // 
            this.pass_lost.AutoSize = true;
            this.pass_lost.BackColor = System.Drawing.Color.Transparent;
            this.pass_lost.Depth = 0;
            this.pass_lost.Font = new System.Drawing.Font("Roboto", 11F);
            this.pass_lost.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(222)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.pass_lost.Location = new System.Drawing.Point(30, 276);
            this.pass_lost.MouseState = MaterialSkin.MouseState.HOVER;
            this.pass_lost.Name = "pass_lost";
            this.pass_lost.Size = new System.Drawing.Size(152, 19);
            this.pass_lost.TabIndex = 4;
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
            this.register_lbl.Location = new System.Drawing.Point(224, 276);
            this.register_lbl.MouseState = MaterialSkin.MouseState.HOVER;
            this.register_lbl.Name = "register_lbl";
            this.register_lbl.Size = new System.Drawing.Size(64, 19);
            this.register_lbl.TabIndex = 5;
            this.register_lbl.Text = "Register";
            this.register_lbl.Click += new System.EventHandler(this.register_lbl_Click);
            // 
            // login
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(331, 316);
            this.Controls.Add(this.register_lbl);
            this.Controls.Add(this.pass_lost);
            this.Controls.Add(this.materialDivider1);
            this.Controls.Add(this.login_btn);
            this.Controls.Add(this.materialCheckBox1);
            this.Controls.Add(this.pass_txt);
            this.Controls.Add(this.nick_txt);
            this.Name = "login";
            this.Sizable = false;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Login";
            this.FormClosed += new System.Windows.Forms.FormClosedEventHandler(this.login_FormClosed);
            this.Load += new System.EventHandler(this.login_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private MaterialSkin.Controls.MaterialSingleLineTextField nick_txt;
        private MaterialSkin.Controls.MaterialSingleLineTextField pass_txt;
        private MaterialSkin.Controls.MaterialCheckBox materialCheckBox1;
        private MaterialSkin.Controls.MaterialRaisedButton login_btn;
        private MaterialSkin.Controls.MaterialDivider materialDivider1;
        private MaterialSkin.Controls.MaterialLabel pass_lost;
        private MaterialSkin.Controls.MaterialLabel register_lbl;
    }
}