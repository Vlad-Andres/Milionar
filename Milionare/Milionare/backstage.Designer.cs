namespace Milionare
{
    partial class backstage
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
            this.add_question_btn = new System.Windows.Forms.Button();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.question_txt = new WindowsFormsControlLibrary1.BunifuCustomTextbox();
            this.A_variant_txt = new WindowsFormsControlLibrary1.BunifuCustomTextbox();
            this.C_variant_txt = new WindowsFormsControlLibrary1.BunifuCustomTextbox();
            this.label9 = new System.Windows.Forms.Label();
            this.D_variant_txt = new WindowsFormsControlLibrary1.BunifuCustomTextbox();
            this.label7 = new System.Windows.Forms.Label();
            this.B_variant_txt = new WindowsFormsControlLibrary1.BunifuCustomTextbox();
            this.label8 = new System.Windows.Forms.Label();
            this.label10 = new System.Windows.Forms.Label();
            this.back_btn = new System.Windows.Forms.Button();
            this.label11 = new System.Windows.Forms.Label();
            this.topic_txt = new System.Windows.Forms.ComboBox();
            this.right_asnwer_txt = new System.Windows.Forms.ComboBox();
            this.label12 = new System.Windows.Forms.Label();
            this.question_value_txt = new System.Windows.Forms.ComboBox();
            this.author_txt = new System.Windows.Forms.Label();
            this.green_dot = new System.Windows.Forms.Label();
            this.dot_timer = new System.Windows.Forms.Timer(this.components);
            this.add_valid_btn = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.Transparent;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 16.25F);
            this.label1.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.label1.Location = new System.Drawing.Point(207, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(130, 26);
            this.label1.TabIndex = 0;
            this.label1.Text = "Back Stage ";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.BackColor = System.Drawing.Color.Transparent;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F);
            this.label2.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.label2.Location = new System.Drawing.Point(160, 35);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(225, 24);
            this.label2.TabIndex = 1;
            this.label2.Text = "Create your own question";
            // 
            // add_question_btn
            // 
            this.add_question_btn.BackColor = System.Drawing.Color.Transparent;
            this.add_question_btn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.add_question_btn.Font = new System.Drawing.Font("Microsoft Sans Serif", 18.25F);
            this.add_question_btn.ForeColor = System.Drawing.Color.Silver;
            this.add_question_btn.Location = new System.Drawing.Point(407, 411);
            this.add_question_btn.Name = "add_question_btn";
            this.add_question_btn.Size = new System.Drawing.Size(107, 42);
            this.add_question_btn.TabIndex = 8;
            this.add_question_btn.Text = "Add";
            this.add_question_btn.UseVisualStyleBackColor = false;
            this.add_question_btn.Click += new System.EventHandler(this.add_question_btn_Click);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.BackColor = System.Drawing.Color.Transparent;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F);
            this.label3.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.label3.Location = new System.Drawing.Point(12, 105);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(100, 24);
            this.label3.TabIndex = 5;
            this.label3.Text = "Nickname:";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.BackColor = System.Drawing.Color.Transparent;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F);
            this.label4.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.label4.Location = new System.Drawing.Point(12, 140);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(63, 24);
            this.label4.TabIndex = 6;
            this.label4.Text = "Topic:";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.BackColor = System.Drawing.Color.Transparent;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F);
            this.label5.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.label5.Location = new System.Drawing.Point(7, 175);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(136, 24);
            this.label5.TabIndex = 7;
            this.label5.Text = "Your Question:";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.BackColor = System.Drawing.Color.Transparent;
            this.label6.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F);
            this.label6.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.label6.Location = new System.Drawing.Point(12, 269);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(28, 24);
            this.label6.TabIndex = 8;
            this.label6.Text = "A:";
            // 
            // question_txt
            // 
            this.question_txt.BorderColor = System.Drawing.Color.SeaGreen;
            this.question_txt.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Bold);
            this.question_txt.ForeColor = System.Drawing.Color.Blue;
            this.question_txt.Location = new System.Drawing.Point(149, 175);
            this.question_txt.Multiline = true;
            this.question_txt.Name = "question_txt";
            this.question_txt.Size = new System.Drawing.Size(365, 74);
            this.question_txt.TabIndex = 1;
            // 
            // A_variant_txt
            // 
            this.A_variant_txt.BorderColor = System.Drawing.Color.SeaGreen;
            this.A_variant_txt.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Bold);
            this.A_variant_txt.ForeColor = System.Drawing.Color.Blue;
            this.A_variant_txt.Location = new System.Drawing.Point(43, 272);
            this.A_variant_txt.Name = "A_variant_txt";
            this.A_variant_txt.Size = new System.Drawing.Size(205, 24);
            this.A_variant_txt.TabIndex = 2;
            // 
            // C_variant_txt
            // 
            this.C_variant_txt.BorderColor = System.Drawing.Color.SeaGreen;
            this.C_variant_txt.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Bold);
            this.C_variant_txt.ForeColor = System.Drawing.Color.Blue;
            this.C_variant_txt.Location = new System.Drawing.Point(43, 298);
            this.C_variant_txt.Name = "C_variant_txt";
            this.C_variant_txt.Size = new System.Drawing.Size(205, 24);
            this.C_variant_txt.TabIndex = 4;
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.BackColor = System.Drawing.Color.Transparent;
            this.label9.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F);
            this.label9.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.label9.Location = new System.Drawing.Point(12, 295);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(28, 24);
            this.label9.TabIndex = 16;
            this.label9.Text = "C:";
            // 
            // D_variant_txt
            // 
            this.D_variant_txt.BorderColor = System.Drawing.Color.SeaGreen;
            this.D_variant_txt.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Bold);
            this.D_variant_txt.ForeColor = System.Drawing.Color.Blue;
            this.D_variant_txt.Location = new System.Drawing.Point(291, 298);
            this.D_variant_txt.Name = "D_variant_txt";
            this.D_variant_txt.Size = new System.Drawing.Size(205, 24);
            this.D_variant_txt.TabIndex = 5;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.BackColor = System.Drawing.Color.Transparent;
            this.label7.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F);
            this.label7.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.label7.Location = new System.Drawing.Point(260, 295);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(28, 24);
            this.label7.TabIndex = 20;
            this.label7.Text = "D:";
            // 
            // B_variant_txt
            // 
            this.B_variant_txt.BorderColor = System.Drawing.Color.SeaGreen;
            this.B_variant_txt.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Bold);
            this.B_variant_txt.ForeColor = System.Drawing.Color.Blue;
            this.B_variant_txt.Location = new System.Drawing.Point(291, 272);
            this.B_variant_txt.Name = "B_variant_txt";
            this.B_variant_txt.Size = new System.Drawing.Size(205, 24);
            this.B_variant_txt.TabIndex = 3;
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.BackColor = System.Drawing.Color.Transparent;
            this.label8.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F);
            this.label8.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.label8.Location = new System.Drawing.Point(260, 269);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(27, 24);
            this.label8.TabIndex = 18;
            this.label8.Text = "B:";
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.BackColor = System.Drawing.Color.Transparent;
            this.label10.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F);
            this.label10.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.label10.Location = new System.Drawing.Point(12, 339);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(127, 24);
            this.label10.TabIndex = 22;
            this.label10.Text = "Right Answer:";
            // 
            // back_btn
            // 
            this.back_btn.BackColor = System.Drawing.Color.Transparent;
            this.back_btn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.back_btn.Font = new System.Drawing.Font("Microsoft Sans Serif", 18.25F);
            this.back_btn.ForeColor = System.Drawing.Color.Silver;
            this.back_btn.Location = new System.Drawing.Point(16, 411);
            this.back_btn.Name = "back_btn";
            this.back_btn.Size = new System.Drawing.Size(107, 42);
            this.back_btn.TabIndex = 9;
            this.back_btn.Text = "Back";
            this.back_btn.UseVisualStyleBackColor = false;
            this.back_btn.Click += new System.EventHandler(this.back_btn_Click);
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.BackColor = System.Drawing.Color.Transparent;
            this.label11.Font = new System.Drawing.Font("Microsoft Sans Serif", 12.25F);
            this.label11.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.label11.Location = new System.Drawing.Point(316, 79);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(198, 20);
            this.label11.TabIndex = 25;
            this.label11.Text = "Show others that you can";
            // 
            // topic_txt
            // 
            this.topic_txt.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Bold);
            this.topic_txt.ForeColor = System.Drawing.Color.Blue;
            this.topic_txt.FormattingEnabled = true;
            this.topic_txt.Items.AddRange(new object[] {
            "Science",
            "Sport",
            "Arts",
            "History"});
            this.topic_txt.Location = new System.Drawing.Point(81, 140);
            this.topic_txt.Name = "topic_txt";
            this.topic_txt.Size = new System.Drawing.Size(121, 26);
            this.topic_txt.TabIndex = 0;
            // 
            // right_asnwer_txt
            // 
            this.right_asnwer_txt.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Bold);
            this.right_asnwer_txt.ForeColor = System.Drawing.Color.Blue;
            this.right_asnwer_txt.FormattingEnabled = true;
            this.right_asnwer_txt.Items.AddRange(new object[] {
            "A",
            "B",
            "C",
            "D"});
            this.right_asnwer_txt.Location = new System.Drawing.Point(145, 339);
            this.right_asnwer_txt.Name = "right_asnwer_txt";
            this.right_asnwer_txt.Size = new System.Drawing.Size(42, 26);
            this.right_asnwer_txt.TabIndex = 6;
            // 
            // label12
            // 
            this.label12.AutoSize = true;
            this.label12.BackColor = System.Drawing.Color.Transparent;
            this.label12.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F);
            this.label12.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.label12.Location = new System.Drawing.Point(260, 339);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(58, 24);
            this.label12.TabIndex = 28;
            this.label12.Text = "Price:";
            // 
            // question_value_txt
            // 
            this.question_value_txt.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Bold);
            this.question_value_txt.ForeColor = System.Drawing.Color.Blue;
            this.question_value_txt.FormattingEnabled = true;
            this.question_value_txt.Items.AddRange(new object[] {
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
            this.question_value_txt.Location = new System.Drawing.Point(324, 340);
            this.question_value_txt.Name = "question_value_txt";
            this.question_value_txt.Size = new System.Drawing.Size(172, 26);
            this.question_value_txt.TabIndex = 7;
            // 
            // author_txt
            // 
            this.author_txt.AutoSize = true;
            this.author_txt.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Bold);
            this.author_txt.ForeColor = System.Drawing.Color.Blue;
            this.author_txt.Location = new System.Drawing.Point(118, 109);
            this.author_txt.Name = "author_txt";
            this.author_txt.Size = new System.Drawing.Size(61, 18);
            this.author_txt.TabIndex = 30;
            this.author_txt.Text = "label13";
            // 
            // green_dot
            // 
            this.green_dot.AutoSize = true;
            this.green_dot.BackColor = System.Drawing.Color.Transparent;
            this.green_dot.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F);
            this.green_dot.ForeColor = System.Drawing.Color.Green;
            this.green_dot.Location = new System.Drawing.Point(378, 422);
            this.green_dot.Name = "green_dot";
            this.green_dot.Size = new System.Drawing.Size(23, 24);
            this.green_dot.TabIndex = 31;
            this.green_dot.Text = "⚫";
            this.green_dot.Visible = false;
            // 
            // dot_timer
            // 
            this.dot_timer.Interval = 2000;
            this.dot_timer.Tick += new System.EventHandler(this.dot_timer_Tick);
            // 
            // add_valid_btn
            // 
            this.add_valid_btn.BackColor = System.Drawing.Color.Olive;
            this.add_valid_btn.Enabled = false;
            this.add_valid_btn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.add_valid_btn.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F);
            this.add_valid_btn.ForeColor = System.Drawing.Color.White;
            this.add_valid_btn.Location = new System.Drawing.Point(164, 411);
            this.add_valid_btn.Name = "add_valid_btn";
            this.add_valid_btn.Size = new System.Drawing.Size(124, 42);
            this.add_valid_btn.TabIndex = 32;
            this.add_valid_btn.Text = "Add as valid";
            this.add_valid_btn.UseVisualStyleBackColor = false;
            this.add_valid_btn.Visible = false;
            this.add_valid_btn.Click += new System.EventHandler(this.add_valid_btn_Click);
            // 
            // backstage
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = global::Milionare.Properties.Resources.dark_blue_wallpaper_10;
            this.ClientSize = new System.Drawing.Size(536, 465);
            this.ControlBox = false;
            this.Controls.Add(this.add_valid_btn);
            this.Controls.Add(this.green_dot);
            this.Controls.Add(this.author_txt);
            this.Controls.Add(this.question_value_txt);
            this.Controls.Add(this.label12);
            this.Controls.Add(this.right_asnwer_txt);
            this.Controls.Add(this.topic_txt);
            this.Controls.Add(this.label11);
            this.Controls.Add(this.back_btn);
            this.Controls.Add(this.label10);
            this.Controls.Add(this.D_variant_txt);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.B_variant_txt);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.C_variant_txt);
            this.Controls.Add(this.label9);
            this.Controls.Add(this.A_variant_txt);
            this.Controls.Add(this.question_txt);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.add_question_btn);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Name = "backstage";
            this.Load += new System.EventHandler(this.backstage_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button add_question_btn;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;
        private WindowsFormsControlLibrary1.BunifuCustomTextbox question_txt;
        private WindowsFormsControlLibrary1.BunifuCustomTextbox A_variant_txt;
        private WindowsFormsControlLibrary1.BunifuCustomTextbox C_variant_txt;
        private System.Windows.Forms.Label label9;
        private WindowsFormsControlLibrary1.BunifuCustomTextbox D_variant_txt;
        private System.Windows.Forms.Label label7;
        private WindowsFormsControlLibrary1.BunifuCustomTextbox B_variant_txt;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.Button back_btn;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.ComboBox topic_txt;
        private System.Windows.Forms.ComboBox right_asnwer_txt;
        private System.Windows.Forms.Label label12;
        private System.Windows.Forms.ComboBox question_value_txt;
        private System.Windows.Forms.Label author_txt;
        private System.Windows.Forms.Label green_dot;
        private System.Windows.Forms.Timer dot_timer;
        private System.Windows.Forms.Button add_valid_btn;
    }
}