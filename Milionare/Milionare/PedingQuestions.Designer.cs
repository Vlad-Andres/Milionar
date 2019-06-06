namespace Milionare
{
    partial class PedingQuestions
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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle3 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle4 = new System.Windows.Forms.DataGridViewCellStyle();
            this.label1 = new System.Windows.Forms.Label();
            this.questions_datagrid = new Bunifu.Framework.UI.BunifuCustomDataGrid();
            this.Id = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Author = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.name_col = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.nick_col = new System.Windows.Forms.DataGridViewComboBoxColumn();
            this.wallet_col = new System.Windows.Forms.DataGridViewComboBoxColumn();
            this.rank_id = new System.Windows.Forms.DataGridViewComboBoxColumn();
            this.var_a = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.var_b = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.var_C = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.var_D = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.validate = new System.Windows.Forms.DataGridViewButtonColumn();
            this.delete = new System.Windows.Forms.DataGridViewButtonColumn();
            this.val_all_btn = new System.Windows.Forms.Button();
            this.dell_all_btn = new System.Windows.Forms.Button();
            this.dataGridViewImageColumn1 = new System.Windows.Forms.DataGridViewImageColumn();
            this.dataGridViewImageColumn2 = new System.Windows.Forms.DataGridViewImageColumn();
            ((System.ComponentModel.ISupportInitialize)(this.questions_datagrid)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Segoe UI Emoji", 21.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.DimGray;
            this.label1.Location = new System.Drawing.Point(201, 21);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(308, 38);
            this.label1.TabIndex = 4;
            this.label1.Text = "Questions in pending";
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
            this.Id,
            this.Author,
            this.name_col,
            this.nick_col,
            this.wallet_col,
            this.rank_id,
            this.var_a,
            this.var_b,
            this.var_C,
            this.var_D,
            this.validate,
            this.delete});
            this.questions_datagrid.DoubleBuffered = true;
            this.questions_datagrid.EditMode = System.Windows.Forms.DataGridViewEditMode.EditOnEnter;
            this.questions_datagrid.EnableHeadersVisualStyles = false;
            this.questions_datagrid.HeaderBgColor = System.Drawing.Color.DimGray;
            this.questions_datagrid.HeaderForeColor = System.Drawing.Color.DarkBlue;
            this.questions_datagrid.Location = new System.Drawing.Point(0, 62);
            this.questions_datagrid.Name = "questions_datagrid";
            this.questions_datagrid.RowHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            this.questions_datagrid.Size = new System.Drawing.Size(768, 368);
            this.questions_datagrid.TabIndex = 5;
            this.questions_datagrid.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.questions_datagrid_CellContentClick);
            // 
            // Id
            // 
            this.Id.Frozen = true;
            this.Id.HeaderText = "Id";
            this.Id.Name = "Id";
            this.Id.Visible = false;
            // 
            // Author
            // 
            this.Author.Frozen = true;
            this.Author.HeaderText = "Author";
            this.Author.Name = "Author";
            this.Author.ReadOnly = true;
            // 
            // name_col
            // 
            this.name_col.Frozen = true;
            this.name_col.HeaderText = "Question";
            this.name_col.Name = "name_col";
            this.name_col.Width = 79;
            // 
            // nick_col
            // 
            this.nick_col.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.AllCellsExceptHeader;
            this.nick_col.Frozen = true;
            this.nick_col.HeaderText = "Right Answer";
            this.nick_col.Items.AddRange(new object[] {
            "A",
            "B",
            "C",
            "D"});
            this.nick_col.Name = "nick_col";
            this.nick_col.Resizable = System.Windows.Forms.DataGridViewTriState.True;
            this.nick_col.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.Automatic;
            this.nick_col.Width = 5;
            // 
            // wallet_col
            // 
            this.wallet_col.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.AllCells;
            this.wallet_col.Frozen = true;
            this.wallet_col.HeaderText = "Topic";
            this.wallet_col.Items.AddRange(new object[] {
            "Science",
            "Sport",
            "Arts",
            "History"});
            this.wallet_col.Name = "wallet_col";
            this.wallet_col.Resizable = System.Windows.Forms.DataGridViewTriState.True;
            this.wallet_col.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.Automatic;
            this.wallet_col.Width = 60;
            // 
            // rank_id
            // 
            this.rank_id.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.AllCells;
            this.rank_id.Frozen = true;
            this.rank_id.HeaderText = "Value";
            this.rank_id.Items.AddRange(new object[] {
            "100 $",
            "200 $",
            "300 $",
            "500 $",
            "1000 $",
            "2000 $",
            "4000 $",
            "8000 $",
            "16 000 $",
            "32 000 $",
            "64 000 $",
            "125 000 $",
            "250 000 $",
            "500 000 $",
            "1 000 000 $"});
            this.rank_id.Name = "rank_id";
            this.rank_id.Resizable = System.Windows.Forms.DataGridViewTriState.True;
            this.rank_id.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.Automatic;
            this.rank_id.Width = 61;
            // 
            // var_a
            // 
            this.var_a.Frozen = true;
            this.var_a.HeaderText = "A";
            this.var_a.Name = "var_a";
            this.var_a.Width = 37;
            // 
            // var_b
            // 
            this.var_b.Frozen = true;
            this.var_b.HeaderText = "B";
            this.var_b.Name = "var_b";
            this.var_b.Width = 38;
            // 
            // var_C
            // 
            this.var_C.Frozen = true;
            this.var_C.HeaderText = "C";
            this.var_C.Name = "var_C";
            this.var_C.Width = 38;
            // 
            // var_D
            // 
            this.var_D.Frozen = true;
            this.var_D.HeaderText = "D";
            this.var_D.Name = "var_D";
            this.var_D.Width = 39;
            // 
            // validate
            // 
            this.validate.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.AllCells;
            dataGridViewCellStyle3.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle3.BackColor = System.Drawing.Color.Lime;
            this.validate.DefaultCellStyle = dataGridViewCellStyle3;
            this.validate.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.validate.Frozen = true;
            this.validate.HeaderText = "Approve";
            this.validate.Name = "validate";
            this.validate.Resizable = System.Windows.Forms.DataGridViewTriState.True;
            this.validate.Width = 55;
            // 
            // delete
            // 
            this.delete.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.AllCells;
            dataGridViewCellStyle4.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle4.BackColor = System.Drawing.Color.Red;
            this.delete.DefaultCellStyle = dataGridViewCellStyle4;
            this.delete.Frozen = true;
            this.delete.HeaderText = "Reject";
            this.delete.Name = "delete";
            this.delete.Resizable = System.Windows.Forms.DataGridViewTriState.True;
            this.delete.Width = 46;
            // 
            // val_all_btn
            // 
            this.val_all_btn.BackColor = System.Drawing.Color.YellowGreen;
            this.val_all_btn.ForeColor = System.Drawing.SystemColors.ControlText;
            this.val_all_btn.Location = new System.Drawing.Point(542, 436);
            this.val_all_btn.Name = "val_all_btn";
            this.val_all_btn.Size = new System.Drawing.Size(144, 24);
            this.val_all_btn.TabIndex = 6;
            this.val_all_btn.Text = "Validate All";
            this.val_all_btn.UseVisualStyleBackColor = false;
            this.val_all_btn.Visible = false;
            // 
            // dell_all_btn
            // 
            this.dell_all_btn.BackColor = System.Drawing.Color.Firebrick;
            this.dell_all_btn.ForeColor = System.Drawing.SystemColors.Control;
            this.dell_all_btn.Location = new System.Drawing.Point(392, 436);
            this.dell_all_btn.Name = "dell_all_btn";
            this.dell_all_btn.Size = new System.Drawing.Size(144, 24);
            this.dell_all_btn.TabIndex = 7;
            this.dell_all_btn.Text = "Delete All";
            this.dell_all_btn.UseVisualStyleBackColor = false;
            this.dell_all_btn.Visible = false;
            // 
            // dataGridViewImageColumn1
            // 
            this.dataGridViewImageColumn1.Frozen = true;
            this.dataGridViewImageColumn1.HeaderText = "validate";
            this.dataGridViewImageColumn1.Image = global::Milionare.Properties.Resources.approve;
            this.dataGridViewImageColumn1.Name = "dataGridViewImageColumn1";
            // 
            // dataGridViewImageColumn2
            // 
            this.dataGridViewImageColumn2.Frozen = true;
            this.dataGridViewImageColumn2.HeaderText = "delete";
            this.dataGridViewImageColumn2.Image = global::Milionare.Properties.Resources.delete;
            this.dataGridViewImageColumn2.Name = "dataGridViewImageColumn2";
            // 
            // PedingQuestions
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ActiveBorder;
            this.Controls.Add(this.dell_all_btn);
            this.Controls.Add(this.val_all_btn);
            this.Controls.Add(this.questions_datagrid);
            this.Controls.Add(this.label1);
            this.Name = "PedingQuestions";
            this.Size = new System.Drawing.Size(768, 491);
            this.Load += new System.EventHandler(this.PedingQuestions_Load);
            ((System.ComponentModel.ISupportInitialize)(this.questions_datagrid)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private Bunifu.Framework.UI.BunifuCustomDataGrid questions_datagrid;
        private System.Windows.Forms.Button val_all_btn;
        private System.Windows.Forms.Button dell_all_btn;
        private System.Windows.Forms.DataGridViewImageColumn dataGridViewImageColumn1;
        private System.Windows.Forms.DataGridViewImageColumn dataGridViewImageColumn2;
        private System.Windows.Forms.DataGridViewTextBoxColumn Id;
        private System.Windows.Forms.DataGridViewTextBoxColumn Author;
        private System.Windows.Forms.DataGridViewTextBoxColumn name_col;
        private System.Windows.Forms.DataGridViewComboBoxColumn nick_col;
        private System.Windows.Forms.DataGridViewComboBoxColumn wallet_col;
        private System.Windows.Forms.DataGridViewComboBoxColumn rank_id;
        private System.Windows.Forms.DataGridViewTextBoxColumn var_a;
        private System.Windows.Forms.DataGridViewTextBoxColumn var_b;
        private System.Windows.Forms.DataGridViewTextBoxColumn var_C;
        private System.Windows.Forms.DataGridViewTextBoxColumn var_D;
        private System.Windows.Forms.DataGridViewButtonColumn validate;
        private System.Windows.Forms.DataGridViewButtonColumn delete;
    }
}
