namespace Milionare
{
    partial class register
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(register));
            this.nickname_txt = new MaterialSkin.Controls.MaterialSingleLineTextField();
            this.mail_txt = new MaterialSkin.Controls.MaterialSingleLineTextField();
            this.name_txt = new MaterialSkin.Controls.MaterialSingleLineTextField();
            this.pass_txt = new MaterialSkin.Controls.MaterialSingleLineTextField();
            this.reg_btn = new MaterialSkin.Controls.MaterialRaisedButton();
            this.materialDivider1 = new MaterialSkin.Controls.MaterialDivider();
            this.re_pass_txt = new MaterialSkin.Controls.MaterialSingleLineTextField();
            this.errorProvider1 = new System.Windows.Forms.ErrorProvider(this.components);
            ((System.ComponentModel.ISupportInitialize)(this.errorProvider1)).BeginInit();
            this.SuspendLayout();
            // 
            // nickname_txt
            // 
            this.nickname_txt.Depth = 0;
            this.nickname_txt.Hint = "Username";
            this.nickname_txt.Location = new System.Drawing.Point(28, 111);
            this.nickname_txt.MouseState = MaterialSkin.MouseState.HOVER;
            this.nickname_txt.Name = "nickname_txt";
            this.nickname_txt.PasswordChar = '\0';
            this.nickname_txt.SelectedText = "";
            this.nickname_txt.SelectionLength = 0;
            this.nickname_txt.SelectionStart = 0;
            this.nickname_txt.Size = new System.Drawing.Size(254, 23);
            this.nickname_txt.TabIndex = 1;
            this.nickname_txt.UseSystemPasswordChar = false;
            this.nickname_txt.Leave += new System.EventHandler(this.nickname_txt_Leave);
            // 
            // mail_txt
            // 
            this.mail_txt.Depth = 0;
            this.mail_txt.Hint = "E-mail";
            this.mail_txt.Location = new System.Drawing.Point(28, 146);
            this.mail_txt.MouseState = MaterialSkin.MouseState.HOVER;
            this.mail_txt.Name = "mail_txt";
            this.mail_txt.PasswordChar = '\0';
            this.mail_txt.SelectedText = "";
            this.mail_txt.SelectionLength = 0;
            this.mail_txt.SelectionStart = 0;
            this.mail_txt.Size = new System.Drawing.Size(254, 23);
            this.mail_txt.TabIndex = 2;
            this.mail_txt.UseSystemPasswordChar = false;
            this.mail_txt.Leave += new System.EventHandler(this.mail_txt_Leave);
            // 
            // name_txt
            // 
            this.name_txt.Depth = 0;
            this.name_txt.Hint = "Name";
            this.name_txt.Location = new System.Drawing.Point(28, 78);
            this.name_txt.MouseState = MaterialSkin.MouseState.HOVER;
            this.name_txt.Name = "name_txt";
            this.name_txt.PasswordChar = '\0';
            this.name_txt.SelectedText = "";
            this.name_txt.SelectionLength = 0;
            this.name_txt.SelectionStart = 0;
            this.name_txt.Size = new System.Drawing.Size(254, 23);
            this.name_txt.TabIndex = 0;
            this.name_txt.UseSystemPasswordChar = false;
            this.name_txt.Leave += new System.EventHandler(this.name_txt_Leave);
            // 
            // pass_txt
            // 
            this.pass_txt.Depth = 0;
            this.pass_txt.Hint = "Password";
            this.pass_txt.Location = new System.Drawing.Point(28, 178);
            this.pass_txt.MouseState = MaterialSkin.MouseState.HOVER;
            this.pass_txt.Name = "pass_txt";
            this.pass_txt.PasswordChar = '\0';
            this.pass_txt.SelectedText = "";
            this.pass_txt.SelectionLength = 0;
            this.pass_txt.SelectionStart = 0;
            this.pass_txt.Size = new System.Drawing.Size(254, 23);
            this.pass_txt.TabIndex = 3;
            this.pass_txt.UseSystemPasswordChar = true;
            this.pass_txt.Leave += new System.EventHandler(this.pass_txt_Leave);
            // 
            // reg_btn
            // 
            this.reg_btn.Depth = 0;
            this.reg_btn.Location = new System.Drawing.Point(207, 257);
            this.reg_btn.MouseState = MaterialSkin.MouseState.HOVER;
            this.reg_btn.Name = "reg_btn";
            this.reg_btn.Primary = true;
            this.reg_btn.Size = new System.Drawing.Size(75, 23);
            this.reg_btn.TabIndex = 5;
            this.reg_btn.Text = "Register";
            this.reg_btn.UseVisualStyleBackColor = true;
            this.reg_btn.Click += new System.EventHandler(this.reg_btn_Click);
            // 
            // materialDivider1
            // 
            this.materialDivider1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(31)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.materialDivider1.Depth = 0;
            this.materialDivider1.Location = new System.Drawing.Point(28, 286);
            this.materialDivider1.MouseState = MaterialSkin.MouseState.HOVER;
            this.materialDivider1.Name = "materialDivider1";
            this.materialDivider1.Size = new System.Drawing.Size(254, 1);
            this.materialDivider1.TabIndex = 5;
            this.materialDivider1.Text = "materialDivider1";
            // 
            // re_pass_txt
            // 
            this.re_pass_txt.Depth = 0;
            this.re_pass_txt.Hint = "Re-type password";
            this.re_pass_txt.Location = new System.Drawing.Point(28, 210);
            this.re_pass_txt.MouseState = MaterialSkin.MouseState.HOVER;
            this.re_pass_txt.Name = "re_pass_txt";
            this.re_pass_txt.PasswordChar = '\0';
            this.re_pass_txt.SelectedText = "";
            this.re_pass_txt.SelectionLength = 0;
            this.re_pass_txt.SelectionStart = 0;
            this.re_pass_txt.Size = new System.Drawing.Size(254, 23);
            this.re_pass_txt.TabIndex = 4;
            this.re_pass_txt.UseSystemPasswordChar = true;
            this.re_pass_txt.Leave += new System.EventHandler(this.re_pass_txt_Leave);
            // 
            // errorProvider1
            // 
            this.errorProvider1.ContainerControl = this;
            this.errorProvider1.Icon = ((System.Drawing.Icon)(resources.GetObject("errorProvider1.Icon")));
            // 
            // register
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(314, 292);
            this.Controls.Add(this.re_pass_txt);
            this.Controls.Add(this.materialDivider1);
            this.Controls.Add(this.reg_btn);
            this.Controls.Add(this.pass_txt);
            this.Controls.Add(this.name_txt);
            this.Controls.Add(this.mail_txt);
            this.Controls.Add(this.nickname_txt);
            this.Name = "register";
            this.Sizable = false;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Register";
            this.FormClosed += new System.Windows.Forms.FormClosedEventHandler(this.register_FormClosed);
            this.Load += new System.EventHandler(this.register_Load);
            ((System.ComponentModel.ISupportInitialize)(this.errorProvider1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private MaterialSkin.Controls.MaterialSingleLineTextField nickname_txt;
        private MaterialSkin.Controls.MaterialSingleLineTextField mail_txt;
        private MaterialSkin.Controls.MaterialSingleLineTextField name_txt;
        private MaterialSkin.Controls.MaterialSingleLineTextField pass_txt;
        private MaterialSkin.Controls.MaterialRaisedButton reg_btn;
        private MaterialSkin.Controls.MaterialDivider materialDivider1;
        private MaterialSkin.Controls.MaterialSingleLineTextField re_pass_txt;
        private System.Windows.Forms.ErrorProvider errorProvider1;
    }
}