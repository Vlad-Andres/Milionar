namespace Milionare
{
    partial class Users
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

        #region Component Designer generated code

        /// <summary> 
        /// Required method for Designer support - do not modify 
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle2 = new System.Windows.Forms.DataGridViewCellStyle();
            this.label1 = new System.Windows.Forms.Label();
            this.users_datagrid = new Bunifu.Framework.UI.BunifuCustomDataGrid();
            this.set_admin_btn = new System.Windows.Forms.Button();
            this.set_user_btn = new System.Windows.Forms.Button();
            this.button1 = new System.Windows.Forms.Button();
            this.add_user_btn = new System.Windows.Forms.Button();
            this.msg_to_admin = new System.Windows.Forms.Label();
            this.Id_col = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.name_col = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.nick_col = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.email_col = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.wallet_col = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.rank_id = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.last_login = new System.Windows.Forms.DataGridViewTextBoxColumn();
            ((System.ComponentModel.ISupportInitialize)(this.users_datagrid)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Segoe UI Emoji", 21.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.DimGray;
            this.label1.Location = new System.Drawing.Point(335, 20);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(91, 38);
            this.label1.TabIndex = 0;
            this.label1.Text = "Users";
            // 
            // users_datagrid
            // 
            this.users_datagrid.AllowUserToAddRows = false;
            this.users_datagrid.AllowUserToDeleteRows = false;
            dataGridViewCellStyle1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.users_datagrid.AlternatingRowsDefaultCellStyle = dataGridViewCellStyle1;
            this.users_datagrid.BackgroundColor = System.Drawing.Color.Gainsboro;
            this.users_datagrid.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.users_datagrid.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle2.BackColor = System.Drawing.Color.DimGray;
            dataGridViewCellStyle2.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle2.ForeColor = System.Drawing.Color.DarkBlue;
            dataGridViewCellStyle2.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle2.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.users_datagrid.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle2;
            this.users_datagrid.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.users_datagrid.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.Id_col,
            this.name_col,
            this.nick_col,
            this.email_col,
            this.wallet_col,
            this.rank_id,
            this.last_login});
            this.users_datagrid.DoubleBuffered = true;
            this.users_datagrid.EditMode = System.Windows.Forms.DataGridViewEditMode.EditProgrammatically;
            this.users_datagrid.EnableHeadersVisualStyles = false;
            this.users_datagrid.HeaderBgColor = System.Drawing.Color.DimGray;
            this.users_datagrid.HeaderForeColor = System.Drawing.Color.DarkBlue;
            this.users_datagrid.Location = new System.Drawing.Point(0, 61);
            this.users_datagrid.Name = "users_datagrid";
            this.users_datagrid.ReadOnly = true;
            this.users_datagrid.RowHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            this.users_datagrid.Size = new System.Drawing.Size(768, 368);
            this.users_datagrid.TabIndex = 1;
            // 
            // set_admin_btn
            // 
            this.set_admin_btn.Location = new System.Drawing.Point(388, 435);
            this.set_admin_btn.Name = "set_admin_btn";
            this.set_admin_btn.Size = new System.Drawing.Size(144, 24);
            this.set_admin_btn.TabIndex = 2;
            this.set_admin_btn.Text = "Set Moder";
            this.set_admin_btn.UseVisualStyleBackColor = true;
            this.set_admin_btn.Click += new System.EventHandler(this.set_admin_btn_Click);
            // 
            // set_user_btn
            // 
            this.set_user_btn.Location = new System.Drawing.Point(238, 435);
            this.set_user_btn.Name = "set_user_btn";
            this.set_user_btn.Size = new System.Drawing.Size(144, 24);
            this.set_user_btn.TabIndex = 3;
            this.set_user_btn.Text = "Set User";
            this.set_user_btn.UseVisualStyleBackColor = true;
            this.set_user_btn.Click += new System.EventHandler(this.set_user_btn_Click);
            // 
            // button1
            // 
            this.button1.BackColor = System.Drawing.Color.Firebrick;
            this.button1.ForeColor = System.Drawing.SystemColors.Control;
            this.button1.Location = new System.Drawing.Point(538, 435);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(144, 24);
            this.button1.TabIndex = 4;
            this.button1.Text = "Delete User";
            this.button1.UseVisualStyleBackColor = false;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // add_user_btn
            // 
            this.add_user_btn.BackColor = System.Drawing.Color.YellowGreen;
            this.add_user_btn.ForeColor = System.Drawing.SystemColors.ControlText;
            this.add_user_btn.Location = new System.Drawing.Point(88, 435);
            this.add_user_btn.Name = "add_user_btn";
            this.add_user_btn.Size = new System.Drawing.Size(144, 24);
            this.add_user_btn.TabIndex = 5;
            this.add_user_btn.Text = "Register new";
            this.add_user_btn.UseVisualStyleBackColor = false;
            this.add_user_btn.Visible = false;
            this.add_user_btn.Click += new System.EventHandler(this.add_user_btn_Click);
            // 
            // msg_to_admin
            // 
            this.msg_to_admin.AutoSize = true;
            this.msg_to_admin.Font = new System.Drawing.Font("Myriad Hebrew", 26.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.msg_to_admin.Location = new System.Drawing.Point(13, 187);
            this.msg_to_admin.Name = "msg_to_admin";
            this.msg_to_admin.Size = new System.Drawing.Size(743, 43);
            this.msg_to_admin.TabIndex = 7;
            this.msg_to_admin.Text = "This tab is available only for the administrator!\r\n";
            this.msg_to_admin.Visible = false;
            // 
            // Id_col
            // 
            this.Id_col.Frozen = true;
            this.Id_col.HeaderText = "ID";
            this.Id_col.Name = "Id_col";
            this.Id_col.ReadOnly = true;
            this.Id_col.Visible = false;
            this.Id_col.Width = 50;
            // 
            // name_col
            // 
            this.name_col.Frozen = true;
            this.name_col.HeaderText = "Name";
            this.name_col.Name = "name_col";
            this.name_col.ReadOnly = true;
            // 
            // nick_col
            // 
            this.nick_col.Frozen = true;
            this.nick_col.HeaderText = "Nickname";
            this.nick_col.Name = "nick_col";
            this.nick_col.ReadOnly = true;
            // 
            // email_col
            // 
            this.email_col.Frozen = true;
            this.email_col.HeaderText = "Email";
            this.email_col.Name = "email_col";
            this.email_col.ReadOnly = true;
            this.email_col.Width = 200;
            // 
            // wallet_col
            // 
            this.wallet_col.Frozen = true;
            this.wallet_col.HeaderText = "Wallet";
            this.wallet_col.Name = "wallet_col";
            this.wallet_col.ReadOnly = true;
            // 
            // rank_id
            // 
            this.rank_id.Frozen = true;
            this.rank_id.HeaderText = "Rank";
            this.rank_id.Name = "rank_id";
            this.rank_id.ReadOnly = true;
            this.rank_id.Width = 70;
            // 
            // last_login
            // 
            this.last_login.Frozen = true;
            this.last_login.HeaderText = "Last Login";
            this.last_login.Name = "last_login";
            this.last_login.ReadOnly = true;
            this.last_login.Width = 150;
            // 
            // Users
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ActiveBorder;
            this.Controls.Add(this.msg_to_admin);
            this.Controls.Add(this.add_user_btn);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.set_user_btn);
            this.Controls.Add(this.set_admin_btn);
            this.Controls.Add(this.users_datagrid);
            this.Controls.Add(this.label1);
            this.Name = "Users";
            this.Size = new System.Drawing.Size(768, 491);
            this.Load += new System.EventHandler(this.Users_Load);
            ((System.ComponentModel.ISupportInitialize)(this.users_datagrid)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private Bunifu.Framework.UI.BunifuCustomDataGrid users_datagrid;
        private System.Windows.Forms.Button set_admin_btn;
        private System.Windows.Forms.Button set_user_btn;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Button add_user_btn;
        private System.Windows.Forms.Label msg_to_admin;
        private System.Windows.Forms.DataGridViewTextBoxColumn Id_col;
        private System.Windows.Forms.DataGridViewTextBoxColumn name_col;
        private System.Windows.Forms.DataGridViewTextBoxColumn nick_col;
        private System.Windows.Forms.DataGridViewTextBoxColumn email_col;
        private System.Windows.Forms.DataGridViewTextBoxColumn wallet_col;
        private System.Windows.Forms.DataGridViewTextBoxColumn rank_id;
        private System.Windows.Forms.DataGridViewTextBoxColumn last_login;
    }
}
