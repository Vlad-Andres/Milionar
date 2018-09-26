namespace Milionare
{
    partial class Questions
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
            this.questions_datagrid = new Bunifu.Framework.UI.BunifuCustomDataGrid();
            this.label1 = new System.Windows.Forms.Label();
            this.Id_col = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.name_col = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.nick_col = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.email_col = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.wallet_col = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.rank_id = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.set_filter_btn = new System.Windows.Forms.Button();
            this.answ_filter_txt = new MaterialSkin.Controls.MaterialSingleLineTextField();
            this.auth_filter_txt = new MaterialSkin.Controls.MaterialSingleLineTextField();
            this.topic_filter_txt = new MaterialSkin.Controls.MaterialSingleLineTextField();
            ((System.ComponentModel.ISupportInitialize)(this.questions_datagrid)).BeginInit();
            this.SuspendLayout();
            // 
            // questions_datagrid
            // 
            this.questions_datagrid.AllowUserToAddRows = false;
            this.questions_datagrid.AllowUserToDeleteRows = false;
            dataGridViewCellStyle1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.questions_datagrid.AlternatingRowsDefaultCellStyle = dataGridViewCellStyle1;
            this.questions_datagrid.BackgroundColor = System.Drawing.Color.Gainsboro;
            this.questions_datagrid.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.questions_datagrid.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle2.BackColor = System.Drawing.Color.DimGray;
            dataGridViewCellStyle2.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle2.ForeColor = System.Drawing.Color.DarkBlue;
            dataGridViewCellStyle2.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle2.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.questions_datagrid.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle2;
            this.questions_datagrid.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.questions_datagrid.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.Id_col,
            this.name_col,
            this.nick_col,
            this.email_col,
            this.wallet_col,
            this.rank_id});
            this.questions_datagrid.DoubleBuffered = true;
            this.questions_datagrid.EditMode = System.Windows.Forms.DataGridViewEditMode.EditProgrammatically;
            this.questions_datagrid.EnableHeadersVisualStyles = false;
            this.questions_datagrid.HeaderBgColor = System.Drawing.Color.DimGray;
            this.questions_datagrid.HeaderForeColor = System.Drawing.Color.DarkBlue;
            this.questions_datagrid.Location = new System.Drawing.Point(0, 61);
            this.questions_datagrid.Name = "questions_datagrid";
            this.questions_datagrid.ReadOnly = true;
            this.questions_datagrid.RowHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            this.questions_datagrid.Size = new System.Drawing.Size(689, 368);
            this.questions_datagrid.TabIndex = 2;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Segoe UI Emoji", 21.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.DimGray;
            this.label1.Location = new System.Drawing.Point(267, 20);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(153, 38);
            this.label1.TabIndex = 3;
            this.label1.Text = "Questions";
            // 
            // Id_col
            // 
            this.Id_col.Frozen = true;
            this.Id_col.HeaderText = "ID";
            this.Id_col.Name = "Id_col";
            this.Id_col.ReadOnly = true;
            this.Id_col.Width = 50;
            // 
            // name_col
            // 
            this.name_col.Frozen = true;
            this.name_col.HeaderText = "Question";
            this.name_col.Name = "name_col";
            this.name_col.ReadOnly = true;
            this.name_col.Width = 300;
            // 
            // nick_col
            // 
            this.nick_col.Frozen = true;
            this.nick_col.HeaderText = "Right Answer";
            this.nick_col.Name = "nick_col";
            this.nick_col.ReadOnly = true;
            // 
            // email_col
            // 
            this.email_col.Frozen = true;
            this.email_col.HeaderText = "Author";
            this.email_col.Name = "email_col";
            this.email_col.ReadOnly = true;
            this.email_col.Width = 75;
            // 
            // wallet_col
            // 
            this.wallet_col.Frozen = true;
            this.wallet_col.HeaderText = "Topic";
            this.wallet_col.Name = "wallet_col";
            this.wallet_col.ReadOnly = true;
            // 
            // rank_id
            // 
            this.rank_id.Frozen = true;
            this.rank_id.HeaderText = "$";
            this.rank_id.Name = "rank_id";
            this.rank_id.ReadOnly = true;
            this.rank_id.Width = 40;
            // 
            // set_filter_btn
            // 
            this.set_filter_btn.Location = new System.Drawing.Point(427, 435);
            this.set_filter_btn.Name = "set_filter_btn";
            this.set_filter_btn.Size = new System.Drawing.Size(144, 24);
            this.set_filter_btn.TabIndex = 4;
            this.set_filter_btn.Text = "Set Filter";
            this.set_filter_btn.UseVisualStyleBackColor = true;
            this.set_filter_btn.Click += new System.EventHandler(this.set_filter_btn_Click);
            // 
            // answ_filter_txt
            // 
            this.answ_filter_txt.BackColor = System.Drawing.SystemColors.ActiveBorder;
            this.answ_filter_txt.Depth = 0;
            this.answ_filter_txt.Hint = "Answer";
            this.answ_filter_txt.Location = new System.Drawing.Point(5, 435);
            this.answ_filter_txt.MouseState = MaterialSkin.MouseState.HOVER;
            this.answ_filter_txt.Name = "answ_filter_txt";
            this.answ_filter_txt.PasswordChar = '\0';
            this.answ_filter_txt.SelectedText = "";
            this.answ_filter_txt.SelectionLength = 0;
            this.answ_filter_txt.SelectionStart = 0;
            this.answ_filter_txt.Size = new System.Drawing.Size(132, 23);
            this.answ_filter_txt.TabIndex = 6;
            this.answ_filter_txt.UseSystemPasswordChar = false;
            // 
            // auth_filter_txt
            // 
            this.auth_filter_txt.BackColor = System.Drawing.Color.White;
            this.auth_filter_txt.Depth = 0;
            this.auth_filter_txt.Hint = "Author";
            this.auth_filter_txt.Location = new System.Drawing.Point(145, 435);
            this.auth_filter_txt.MouseState = MaterialSkin.MouseState.HOVER;
            this.auth_filter_txt.Name = "auth_filter_txt";
            this.auth_filter_txt.PasswordChar = '\0';
            this.auth_filter_txt.SelectedText = "";
            this.auth_filter_txt.SelectionLength = 0;
            this.auth_filter_txt.SelectionStart = 0;
            this.auth_filter_txt.Size = new System.Drawing.Size(132, 23);
            this.auth_filter_txt.TabIndex = 7;
            this.auth_filter_txt.UseSystemPasswordChar = false;
            // 
            // topic_filter_txt
            // 
            this.topic_filter_txt.BackColor = System.Drawing.Color.White;
            this.topic_filter_txt.Depth = 0;
            this.topic_filter_txt.Hint = "Topic";
            this.topic_filter_txt.Location = new System.Drawing.Point(285, 435);
            this.topic_filter_txt.MouseState = MaterialSkin.MouseState.HOVER;
            this.topic_filter_txt.Name = "topic_filter_txt";
            this.topic_filter_txt.PasswordChar = '\0';
            this.topic_filter_txt.SelectedText = "";
            this.topic_filter_txt.SelectionLength = 0;
            this.topic_filter_txt.SelectionStart = 0;
            this.topic_filter_txt.Size = new System.Drawing.Size(132, 23);
            this.topic_filter_txt.TabIndex = 8;
            this.topic_filter_txt.UseSystemPasswordChar = false;
            // 
            // Questions
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ActiveBorder;
            this.Controls.Add(this.topic_filter_txt);
            this.Controls.Add(this.auth_filter_txt);
            this.Controls.Add(this.answ_filter_txt);
            this.Controls.Add(this.set_filter_btn);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.questions_datagrid);
            this.Name = "Questions";
            this.Size = new System.Drawing.Size(689, 466);
            this.Load += new System.EventHandler(this.Questions_Load);
            ((System.ComponentModel.ISupportInitialize)(this.questions_datagrid)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private Bunifu.Framework.UI.BunifuCustomDataGrid questions_datagrid;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.DataGridViewTextBoxColumn Id_col;
        private System.Windows.Forms.DataGridViewTextBoxColumn name_col;
        private System.Windows.Forms.DataGridViewTextBoxColumn nick_col;
        private System.Windows.Forms.DataGridViewTextBoxColumn email_col;
        private System.Windows.Forms.DataGridViewTextBoxColumn wallet_col;
        private System.Windows.Forms.DataGridViewTextBoxColumn rank_id;
        private System.Windows.Forms.Button set_filter_btn;
        private MaterialSkin.Controls.MaterialSingleLineTextField answ_filter_txt;
        private MaterialSkin.Controls.MaterialSingleLineTextField auth_filter_txt;
        private MaterialSkin.Controls.MaterialSingleLineTextField topic_filter_txt;
    }
}
