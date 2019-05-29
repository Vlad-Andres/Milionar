namespace Milionare
{
    partial class validation_logs
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
            this.label1 = new System.Windows.Forms.Label();
            this.logs_datagrid = new System.Windows.Forms.DataGridView();
            this.username = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.verdict = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.question_id = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.author = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.executed_on = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.topic_id = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.text = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.var_a = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.var_b = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.var_c = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.var_d = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.correct = new System.Windows.Forms.DataGridViewTextBoxColumn();
            ((System.ComponentModel.ISupportInitialize)(this.logs_datagrid)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Segoe UI Emoji", 21.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.DimGray;
            this.label1.Location = new System.Drawing.Point(258, 21);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(229, 38);
            this.label1.TabIndex = 5;
            this.label1.Text = "Validation Logs";
            // 
            // logs_datagrid
            // 
            this.logs_datagrid.AllowUserToAddRows = false;
            this.logs_datagrid.AllowUserToDeleteRows = false;
            this.logs_datagrid.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.logs_datagrid.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.username,
            this.verdict,
            this.question_id,
            this.author,
            this.executed_on,
            this.topic_id,
            this.text,
            this.var_a,
            this.var_b,
            this.var_c,
            this.var_d,
            this.correct});
            this.logs_datagrid.Location = new System.Drawing.Point(0, 62);
            this.logs_datagrid.Name = "logs_datagrid";
            this.logs_datagrid.ReadOnly = true;
            this.logs_datagrid.Size = new System.Drawing.Size(768, 429);
            this.logs_datagrid.TabIndex = 6;
            this.logs_datagrid.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.logs_datagrid_CellContentClick);
            // 
            // username
            // 
            this.username.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.AllCells;
            this.username.Frozen = true;
            this.username.HeaderText = "User";
            this.username.Name = "username";
            this.username.ReadOnly = true;
            this.username.Width = 54;
            // 
            // verdict
            // 
            this.verdict.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.AllCells;
            this.verdict.Frozen = true;
            this.verdict.HeaderText = "Verdict";
            this.verdict.Name = "verdict";
            this.verdict.ReadOnly = true;
            this.verdict.Width = 65;
            // 
            // question_id
            // 
            this.question_id.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.AllCells;
            this.question_id.Frozen = true;
            this.question_id.HeaderText = "Question ID";
            this.question_id.Name = "question_id";
            this.question_id.ReadOnly = true;
            this.question_id.Width = 88;
            // 
            // author
            // 
            this.author.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.AllCells;
            this.author.Frozen = true;
            this.author.HeaderText = "Question Author";
            this.author.Name = "author";
            this.author.ReadOnly = true;
            this.author.Width = 99;
            // 
            // executed_on
            // 
            this.executed_on.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.AllCells;
            this.executed_on.Frozen = true;
            this.executed_on.HeaderText = "Date";
            this.executed_on.Name = "executed_on";
            this.executed_on.ReadOnly = true;
            this.executed_on.Width = 55;
            // 
            // topic_id
            // 
            this.topic_id.Frozen = true;
            this.topic_id.HeaderText = "topic";
            this.topic_id.Name = "topic_id";
            this.topic_id.ReadOnly = true;
            this.topic_id.Visible = false;
            // 
            // text
            // 
            this.text.Frozen = true;
            this.text.HeaderText = "text";
            this.text.Name = "text";
            this.text.ReadOnly = true;
            this.text.Visible = false;
            // 
            // var_a
            // 
            this.var_a.Frozen = true;
            this.var_a.HeaderText = "var_a";
            this.var_a.Name = "var_a";
            this.var_a.ReadOnly = true;
            this.var_a.Visible = false;
            // 
            // var_b
            // 
            this.var_b.Frozen = true;
            this.var_b.HeaderText = "var_b";
            this.var_b.Name = "var_b";
            this.var_b.ReadOnly = true;
            this.var_b.Visible = false;
            // 
            // var_c
            // 
            this.var_c.Frozen = true;
            this.var_c.HeaderText = "var_c";
            this.var_c.Name = "var_c";
            this.var_c.ReadOnly = true;
            this.var_c.Visible = false;
            // 
            // var_d
            // 
            this.var_d.Frozen = true;
            this.var_d.HeaderText = "var_d";
            this.var_d.Name = "var_d";
            this.var_d.ReadOnly = true;
            this.var_d.Visible = false;
            // 
            // correct
            // 
            this.correct.Frozen = true;
            this.correct.HeaderText = "correct";
            this.correct.Name = "correct";
            this.correct.ReadOnly = true;
            this.correct.Visible = false;
            // 
            // validation_logs
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.logs_datagrid);
            this.Controls.Add(this.label1);
            this.Name = "validation_logs";
            this.Size = new System.Drawing.Size(768, 491);
            ((System.ComponentModel.ISupportInitialize)(this.logs_datagrid)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.DataGridView logs_datagrid;
        private System.Windows.Forms.DataGridViewTextBoxColumn username;
        private System.Windows.Forms.DataGridViewTextBoxColumn verdict;
        private System.Windows.Forms.DataGridViewTextBoxColumn question_id;
        private System.Windows.Forms.DataGridViewTextBoxColumn author;
        private System.Windows.Forms.DataGridViewTextBoxColumn executed_on;
        private System.Windows.Forms.DataGridViewTextBoxColumn topic_id;
        private System.Windows.Forms.DataGridViewTextBoxColumn text;
        private System.Windows.Forms.DataGridViewTextBoxColumn var_a;
        private System.Windows.Forms.DataGridViewTextBoxColumn var_b;
        private System.Windows.Forms.DataGridViewTextBoxColumn var_c;
        private System.Windows.Forms.DataGridViewTextBoxColumn var_d;
        private System.Windows.Forms.DataGridViewTextBoxColumn correct;
    }
}
