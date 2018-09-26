namespace Milionare
{
    partial class pass_recovery
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
            this.recovery_email_txt = new MaterialSkin.Controls.MaterialSingleLineTextField();
            this.user_welcome_lbl = new MaterialSkin.Controls.MaterialLabel();
            this.materialRaisedButton1 = new MaterialSkin.Controls.MaterialRaisedButton();
            this.materialRaisedButton2 = new MaterialSkin.Controls.MaterialRaisedButton();
            this.Code_lbl = new MaterialSkin.Controls.MaterialSingleLineTextField();
            this.wrong_code_lbl = new MaterialSkin.Controls.MaterialLabel();
            this.new_pass_lbl = new MaterialSkin.Controls.MaterialSingleLineTextField();
            this.re_pass_txt = new MaterialSkin.Controls.MaterialSingleLineTextField();
            this.SuspendLayout();
            // 
            // recovery_email_txt
            // 
            this.recovery_email_txt.Depth = 0;
            this.recovery_email_txt.Hint = "Registered e-mail";
            this.recovery_email_txt.Location = new System.Drawing.Point(16, 189);
            this.recovery_email_txt.MouseState = MaterialSkin.MouseState.HOVER;
            this.recovery_email_txt.Name = "recovery_email_txt";
            this.recovery_email_txt.PasswordChar = '\0';
            this.recovery_email_txt.SelectedText = "";
            this.recovery_email_txt.SelectionLength = 0;
            this.recovery_email_txt.SelectionStart = 0;
            this.recovery_email_txt.Size = new System.Drawing.Size(272, 23);
            this.recovery_email_txt.TabIndex = 0;
            this.recovery_email_txt.UseSystemPasswordChar = false;
            // 
            // user_welcome_lbl
            // 
            this.user_welcome_lbl.BackColor = System.Drawing.Color.Transparent;
            this.user_welcome_lbl.Depth = 0;
            this.user_welcome_lbl.Font = new System.Drawing.Font("Roboto", 11F);
            this.user_welcome_lbl.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(222)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.user_welcome_lbl.Location = new System.Drawing.Point(12, 70);
            this.user_welcome_lbl.MouseState = MaterialSkin.MouseState.HOVER;
            this.user_welcome_lbl.Name = "user_welcome_lbl";
            this.user_welcome_lbl.Size = new System.Drawing.Size(276, 90);
            this.user_welcome_lbl.TabIndex = 1;
            this.user_welcome_lbl.Text = "Dear user, please specify your email address and we will send you the verificatio" +
    "n code to be able to change your password";
            // 
            // materialRaisedButton1
            // 
            this.materialRaisedButton1.Depth = 0;
            this.materialRaisedButton1.Location = new System.Drawing.Point(178, 239);
            this.materialRaisedButton1.MouseState = MaterialSkin.MouseState.HOVER;
            this.materialRaisedButton1.Name = "materialRaisedButton1";
            this.materialRaisedButton1.Primary = true;
            this.materialRaisedButton1.Size = new System.Drawing.Size(98, 35);
            this.materialRaisedButton1.TabIndex = 2;
            this.materialRaisedButton1.Text = "Send code";
            this.materialRaisedButton1.UseVisualStyleBackColor = true;
            this.materialRaisedButton1.Click += new System.EventHandler(this.materialRaisedButton1_Click);
            // 
            // materialRaisedButton2
            // 
            this.materialRaisedButton2.Depth = 0;
            this.materialRaisedButton2.Location = new System.Drawing.Point(16, 239);
            this.materialRaisedButton2.MouseState = MaterialSkin.MouseState.HOVER;
            this.materialRaisedButton2.Name = "materialRaisedButton2";
            this.materialRaisedButton2.Primary = true;
            this.materialRaisedButton2.Size = new System.Drawing.Size(98, 35);
            this.materialRaisedButton2.TabIndex = 3;
            this.materialRaisedButton2.Text = "Back";
            this.materialRaisedButton2.UseVisualStyleBackColor = true;
            this.materialRaisedButton2.Click += new System.EventHandler(this.materialRaisedButton2_Click);
            // 
            // Code_lbl
            // 
            this.Code_lbl.Depth = 0;
            this.Code_lbl.Font = new System.Drawing.Font("Consolas", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Code_lbl.Hint = "1234";
            this.Code_lbl.Location = new System.Drawing.Point(123, 160);
            this.Code_lbl.MouseState = MaterialSkin.MouseState.HOVER;
            this.Code_lbl.Name = "Code_lbl";
            this.Code_lbl.PasswordChar = '\0';
            this.Code_lbl.SelectedText = "";
            this.Code_lbl.SelectionLength = 0;
            this.Code_lbl.SelectionStart = 0;
            this.Code_lbl.Size = new System.Drawing.Size(36, 23);
            this.Code_lbl.TabIndex = 4;
            this.Code_lbl.UseSystemPasswordChar = false;
            // 
            // wrong_code_lbl
            // 
            this.wrong_code_lbl.AutoSize = true;
            this.wrong_code_lbl.Depth = 0;
            this.wrong_code_lbl.Font = new System.Drawing.Font("Roboto", 11F);
            this.wrong_code_lbl.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(222)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.wrong_code_lbl.Location = new System.Drawing.Point(41, 215);
            this.wrong_code_lbl.MouseState = MaterialSkin.MouseState.HOVER;
            this.wrong_code_lbl.Name = "wrong_code_lbl";
            this.wrong_code_lbl.Size = new System.Drawing.Size(207, 19);
            this.wrong_code_lbl.TabIndex = 5;
            this.wrong_code_lbl.Text = "Wrong code! Please try again ";
            this.wrong_code_lbl.Visible = false;
            // 
            // new_pass_lbl
            // 
            this.new_pass_lbl.Depth = 0;
            this.new_pass_lbl.Hint = "New Password";
            this.new_pass_lbl.Location = new System.Drawing.Point(16, 131);
            this.new_pass_lbl.MouseState = MaterialSkin.MouseState.HOVER;
            this.new_pass_lbl.Name = "new_pass_lbl";
            this.new_pass_lbl.PasswordChar = '*';
            this.new_pass_lbl.SelectedText = "";
            this.new_pass_lbl.SelectionLength = 0;
            this.new_pass_lbl.SelectionStart = 0;
            this.new_pass_lbl.Size = new System.Drawing.Size(272, 23);
            this.new_pass_lbl.TabIndex = 6;
            this.new_pass_lbl.UseSystemPasswordChar = false;
            this.new_pass_lbl.Visible = false;
            // 
            // re_pass_txt
            // 
            this.re_pass_txt.Depth = 0;
            this.re_pass_txt.Hint = "Retype password";
            this.re_pass_txt.Location = new System.Drawing.Point(16, 177);
            this.re_pass_txt.MouseState = MaterialSkin.MouseState.HOVER;
            this.re_pass_txt.Name = "re_pass_txt";
            this.re_pass_txt.PasswordChar = '*';
            this.re_pass_txt.SelectedText = "";
            this.re_pass_txt.SelectionLength = 0;
            this.re_pass_txt.SelectionStart = 0;
            this.re_pass_txt.Size = new System.Drawing.Size(272, 23);
            this.re_pass_txt.TabIndex = 7;
            this.re_pass_txt.UseSystemPasswordChar = false;
            this.re_pass_txt.Visible = false;
            // 
            // pass_recovery
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(300, 300);
            this.Controls.Add(this.re_pass_txt);
            this.Controls.Add(this.new_pass_lbl);
            this.Controls.Add(this.wrong_code_lbl);
            this.Controls.Add(this.Code_lbl);
            this.Controls.Add(this.materialRaisedButton2);
            this.Controls.Add(this.materialRaisedButton1);
            this.Controls.Add(this.user_welcome_lbl);
            this.Controls.Add(this.recovery_email_txt);
            this.Name = "pass_recovery";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Password Recovery";
            this.FormClosed += new System.Windows.Forms.FormClosedEventHandler(this.pass_recovery_FormClosed);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private MaterialSkin.Controls.MaterialSingleLineTextField recovery_email_txt;
        private MaterialSkin.Controls.MaterialLabel user_welcome_lbl;
        private MaterialSkin.Controls.MaterialRaisedButton materialRaisedButton1;
        private MaterialSkin.Controls.MaterialRaisedButton materialRaisedButton2;
        private MaterialSkin.Controls.MaterialSingleLineTextField Code_lbl;
        private MaterialSkin.Controls.MaterialLabel wrong_code_lbl;
        private MaterialSkin.Controls.MaterialSingleLineTextField new_pass_lbl;
        private MaterialSkin.Controls.MaterialSingleLineTextField re_pass_txt;
    }
}