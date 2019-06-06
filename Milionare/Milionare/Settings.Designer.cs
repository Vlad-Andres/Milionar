namespace Milionare
{
    partial class Settings
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
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.global_db_cbx = new System.Windows.Forms.CheckBox();
            this.label5 = new System.Windows.Forms.Label();
            this.db_name_lbl = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.server_lbl = new System.Windows.Forms.TextBox();
            this.pass_lbl = new System.Windows.Forms.TextBox();
            this.label7 = new System.Windows.Forms.Label();
            this.user_lbl = new System.Windows.Forms.TextBox();
            this.label8 = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
            this.Db_panel = new System.Windows.Forms.Panel();
            this.create_db_btn = new System.Windows.Forms.Button();
            this.connect_btn = new System.Windows.Forms.Button();
            this.bunifuDragControl1 = new Bunifu.Framework.UI.BunifuDragControl(this.components);
            this.exit_button = new System.Windows.Forms.Button();
            this.Db_panel.SuspendLayout();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft YaHei", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.White;
            this.label1.Location = new System.Drawing.Point(127, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(99, 28);
            this.label1.TabIndex = 0;
            this.label1.Text = "Settings";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft YaHei", 11.75F, System.Drawing.FontStyle.Bold);
            this.label2.ForeColor = System.Drawing.Color.White;
            this.label2.Location = new System.Drawing.Point(3, 72);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(353, 22);
            this.label2.TabIndex = 1;
            this.label2.Text = "_________________________________________________";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft YaHei", 12.75F, System.Drawing.FontStyle.Bold);
            this.label3.ForeColor = System.Drawing.Color.White;
            this.label3.Location = new System.Drawing.Point(128, 61);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(89, 24);
            this.label3.TabIndex = 2;
            this.label3.Text = "Database";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft YaHei", 10.75F, System.Drawing.FontStyle.Bold);
            this.label4.ForeColor = System.Drawing.Color.White;
            this.label4.Location = new System.Drawing.Point(12, 94);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(114, 19);
            this.label4.TabIndex = 3;
            this.label4.Text = "Use global DB";
            // 
            // global_db_cbx
            // 
            this.global_db_cbx.AutoSize = true;
            this.global_db_cbx.Checked = true;
            this.global_db_cbx.CheckState = System.Windows.Forms.CheckState.Checked;
            this.global_db_cbx.Font = new System.Drawing.Font("Microsoft Sans Serif", 12.25F);
            this.global_db_cbx.Location = new System.Drawing.Point(132, 97);
            this.global_db_cbx.Name = "global_db_cbx";
            this.global_db_cbx.Size = new System.Drawing.Size(15, 14);
            this.global_db_cbx.TabIndex = 4;
            this.global_db_cbx.UseVisualStyleBackColor = true;
            this.global_db_cbx.CheckedChanged += new System.EventHandler(this.global_db_cbx_CheckedChanged);
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Microsoft YaHei", 10.75F, System.Drawing.FontStyle.Bold);
            this.label5.ForeColor = System.Drawing.Color.White;
            this.label5.Location = new System.Drawing.Point(47, 11);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(84, 19);
            this.label5.TabIndex = 5;
            this.label5.Text = "Database:";
            // 
            // db_name_lbl
            // 
            this.db_name_lbl.BackColor = System.Drawing.SystemColors.Control;
            this.db_name_lbl.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.25F, System.Drawing.FontStyle.Bold);
            this.db_name_lbl.ForeColor = System.Drawing.Color.DarkSlateGray;
            this.db_name_lbl.Location = new System.Drawing.Point(137, 9);
            this.db_name_lbl.Name = "db_name_lbl";
            this.db_name_lbl.Size = new System.Drawing.Size(147, 23);
            this.db_name_lbl.TabIndex = 6;
            this.db_name_lbl.Text = "IRL_local_DB";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Microsoft YaHei", 10.75F, System.Drawing.FontStyle.Bold);
            this.label6.ForeColor = System.Drawing.Color.White;
            this.label6.Location = new System.Drawing.Point(47, 41);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(61, 19);
            this.label6.TabIndex = 7;
            this.label6.Text = "Server:";
            // 
            // server_lbl
            // 
            this.server_lbl.BackColor = System.Drawing.SystemColors.Control;
            this.server_lbl.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.25F, System.Drawing.FontStyle.Bold);
            this.server_lbl.ForeColor = System.Drawing.Color.DarkSlateGray;
            this.server_lbl.Location = new System.Drawing.Point(137, 39);
            this.server_lbl.Name = "server_lbl";
            this.server_lbl.Size = new System.Drawing.Size(147, 23);
            this.server_lbl.TabIndex = 8;
            this.server_lbl.Text = "localhost";
            // 
            // pass_lbl
            // 
            this.pass_lbl.BackColor = System.Drawing.SystemColors.Control;
            this.pass_lbl.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.25F, System.Drawing.FontStyle.Bold);
            this.pass_lbl.ForeColor = System.Drawing.Color.DarkSlateGray;
            this.pass_lbl.Location = new System.Drawing.Point(137, 97);
            this.pass_lbl.Name = "pass_lbl";
            this.pass_lbl.Size = new System.Drawing.Size(147, 23);
            this.pass_lbl.TabIndex = 12;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Microsoft YaHei", 10.75F, System.Drawing.FontStyle.Bold);
            this.label7.ForeColor = System.Drawing.Color.White;
            this.label7.Location = new System.Drawing.Point(46, 99);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(85, 19);
            this.label7.TabIndex = 11;
            this.label7.Text = "Password:";
            // 
            // user_lbl
            // 
            this.user_lbl.BackColor = System.Drawing.SystemColors.Control;
            this.user_lbl.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.25F, System.Drawing.FontStyle.Bold);
            this.user_lbl.ForeColor = System.Drawing.Color.DarkSlateGray;
            this.user_lbl.Location = new System.Drawing.Point(137, 68);
            this.user_lbl.Name = "user_lbl";
            this.user_lbl.Size = new System.Drawing.Size(147, 23);
            this.user_lbl.TabIndex = 10;
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Font = new System.Drawing.Font("Microsoft YaHei", 10.75F, System.Drawing.FontStyle.Bold);
            this.label8.ForeColor = System.Drawing.Color.White;
            this.label8.Location = new System.Drawing.Point(47, 70);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(47, 19);
            this.label8.TabIndex = 9;
            this.label8.Text = "User:";
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Font = new System.Drawing.Font("Microsoft YaHei", 11.75F, System.Drawing.FontStyle.Bold);
            this.label9.ForeColor = System.Drawing.Color.White;
            this.label9.Location = new System.Drawing.Point(3, 297);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(353, 22);
            this.label9.TabIndex = 13;
            this.label9.Text = "_________________________________________________";
            // 
            // Db_panel
            // 
            this.Db_panel.BackColor = System.Drawing.SystemColors.InactiveCaption;
            this.Db_panel.Controls.Add(this.connect_btn);
            this.Db_panel.Controls.Add(this.create_db_btn);
            this.Db_panel.Controls.Add(this.label5);
            this.Db_panel.Controls.Add(this.db_name_lbl);
            this.Db_panel.Controls.Add(this.pass_lbl);
            this.Db_panel.Controls.Add(this.label6);
            this.Db_panel.Controls.Add(this.label7);
            this.Db_panel.Controls.Add(this.server_lbl);
            this.Db_panel.Controls.Add(this.user_lbl);
            this.Db_panel.Controls.Add(this.label8);
            this.Db_panel.Enabled = false;
            this.Db_panel.Location = new System.Drawing.Point(12, 116);
            this.Db_panel.Name = "Db_panel";
            this.Db_panel.Size = new System.Drawing.Size(328, 184);
            this.Db_panel.TabIndex = 14;
            // 
            // create_db_btn
            // 
            this.create_db_btn.BackColor = System.Drawing.SystemColors.InactiveCaption;
            this.create_db_btn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.create_db_btn.Font = new System.Drawing.Font("Microsoft YaHei", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.create_db_btn.ForeColor = System.Drawing.Color.White;
            this.create_db_btn.Location = new System.Drawing.Point(25, 137);
            this.create_db_btn.Name = "create_db_btn";
            this.create_db_btn.Size = new System.Drawing.Size(112, 35);
            this.create_db_btn.TabIndex = 13;
            this.create_db_btn.Text = "Create local DB";
            this.create_db_btn.UseVisualStyleBackColor = false;
            this.create_db_btn.Click += new System.EventHandler(this.create_db_btn_Click);
            // 
            // connect_btn
            // 
            this.connect_btn.BackColor = System.Drawing.SystemColors.InactiveCaption;
            this.connect_btn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.connect_btn.Font = new System.Drawing.Font("Microsoft YaHei", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.connect_btn.ForeColor = System.Drawing.Color.White;
            this.connect_btn.Location = new System.Drawing.Point(172, 137);
            this.connect_btn.Name = "connect_btn";
            this.connect_btn.Size = new System.Drawing.Size(112, 35);
            this.connect_btn.TabIndex = 14;
            this.connect_btn.Text = "Connect";
            this.connect_btn.UseVisualStyleBackColor = false;
            this.connect_btn.Click += new System.EventHandler(this.connect_btn_Click);
            // 
            // bunifuDragControl1
            // 
            this.bunifuDragControl1.Fixed = true;
            this.bunifuDragControl1.Horizontal = true;
            this.bunifuDragControl1.TargetControl = this;
            this.bunifuDragControl1.Vertical = true;
            // 
            // exit_button
            // 
            this.exit_button.BackColor = System.Drawing.Color.Transparent;
            this.exit_button.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.exit_button.ForeColor = System.Drawing.Color.DimGray;
            this.exit_button.Location = new System.Drawing.Point(322, 9);
            this.exit_button.Name = "exit_button";
            this.exit_button.Size = new System.Drawing.Size(25, 26);
            this.exit_button.TabIndex = 15;
            this.exit_button.Text = "X";
            this.exit_button.UseVisualStyleBackColor = false;
            this.exit_button.Click += new System.EventHandler(this.exit_button_Click);
            // 
            // Settings
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(35)))), ((int)(((byte)(62)))), ((int)(((byte)(107)))));
            this.ClientSize = new System.Drawing.Size(359, 339);
            this.ControlBox = false;
            this.Controls.Add(this.exit_button);
            this.Controls.Add(this.label9);
            this.Controls.Add(this.Db_panel);
            this.Controls.Add(this.global_db_cbx);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Name = "Settings";
            this.Db_panel.ResumeLayout(false);
            this.Db_panel.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.CheckBox global_db_cbx;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox db_name_lbl;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.TextBox server_lbl;
        private System.Windows.Forms.TextBox pass_lbl;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.TextBox user_lbl;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Panel Db_panel;
        private System.Windows.Forms.Button connect_btn;
        private System.Windows.Forms.Button create_db_btn;
        private Bunifu.Framework.UI.BunifuDragControl bunifuDragControl1;
        private System.Windows.Forms.Button exit_button;
    }
}