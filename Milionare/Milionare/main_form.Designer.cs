namespace Milionare
{
    partial class main_form
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(main_form));
            this.bunifuElipse1 = new Bunifu.Framework.UI.BunifuElipse(this.components);
            this.side_panel_gradient = new Bunifu.Framework.UI.BunifuGradientPanel();
            this.button1 = new System.Windows.Forms.Button();
            this.side_panel = new System.Windows.Forms.Panel();
            this.question_timebar = new Bunifu.Framework.UI.BunifuCircleProgressbar();
            this.question_timer = new System.Windows.Forms.Timer(this.components);
            this.panel_off_lbl = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.A_btn = new System.Windows.Forms.Button();
            this.C_btn = new System.Windows.Forms.Button();
            this.D_btn = new System.Windows.Forms.Button();
            this.B_btn = new System.Windows.Forms.Button();
            this.validation_timer = new System.Windows.Forms.Timer(this.components);
            this.level_up_timer = new System.Windows.Forms.Timer(this.components);
            this.quetion_timer_lbl = new System.Windows.Forms.Label();
            this.circle_btn_public = new Milionare.circle_button();
            this.circle_btn_call = new Milionare.circle_button();
            this.circle_btn_half = new Milionare.circle_button();
            this.circle_btn_slide = new Milionare.circle_button();
            this.circle_btn_leave = new Milionare.circle_button();
            this.side_panel_gradient.SuspendLayout();
            this.side_panel.SuspendLayout();
            this.SuspendLayout();
            // 
            // bunifuElipse1
            // 
            this.bunifuElipse1.ElipseRadius = 5;
            this.bunifuElipse1.TargetControl = this;
            // 
            // side_panel_gradient
            // 
            this.side_panel_gradient.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("side_panel_gradient.BackgroundImage")));
            this.side_panel_gradient.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.side_panel_gradient.Controls.Add(this.button1);
            this.side_panel_gradient.Dock = System.Windows.Forms.DockStyle.Left;
            this.side_panel_gradient.GradientBottomLeft = System.Drawing.Color.HotPink;
            this.side_panel_gradient.GradientBottomRight = System.Drawing.Color.Blue;
            this.side_panel_gradient.GradientTopLeft = System.Drawing.Color.BlueViolet;
            this.side_panel_gradient.GradientTopRight = System.Drawing.Color.DarkOliveGreen;
            this.side_panel_gradient.Location = new System.Drawing.Point(0, 0);
            this.side_panel_gradient.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.side_panel_gradient.Name = "side_panel_gradient";
            this.side_panel_gradient.Quality = 10;
            this.side_panel_gradient.Size = new System.Drawing.Size(37, 761);
            this.side_panel_gradient.TabIndex = 0;
            this.side_panel_gradient.Paint += new System.Windows.Forms.PaintEventHandler(this.side_panel_gradient_Paint);
            // 
            // button1
            // 
            this.button1.BackColor = System.Drawing.Color.Transparent;
            this.button1.BackgroundImage = global::Milionare.Properties.Resources.minimize_box_blue;
            this.button1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.button1.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button1.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(192)))), ((int)(((byte)(255)))));
            this.button1.Location = new System.Drawing.Point(257, 0);
            this.button1.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(36, 32);
            this.button1.TabIndex = 0;
            this.button1.UseVisualStyleBackColor = false;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // side_panel
            // 
            this.side_panel.Controls.Add(this.side_panel_gradient);
            this.side_panel.Dock = System.Windows.Forms.DockStyle.Left;
            this.side_panel.Location = new System.Drawing.Point(0, 0);
            this.side_panel.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.side_panel.Name = "side_panel";
            this.side_panel.Size = new System.Drawing.Size(37, 761);
            this.side_panel.TabIndex = 5;
            this.side_panel.Paint += new System.Windows.Forms.PaintEventHandler(this.side_panel_Paint);
            // 
            // question_timebar
            // 
            this.question_timebar.animated = false;
            this.question_timebar.animationIterval = 5;
            this.question_timebar.animationSpeed = 10;
            this.question_timebar.BackColor = System.Drawing.Color.Transparent;
            this.question_timebar.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("question_timebar.BackgroundImage")));
            this.question_timebar.Font = new System.Drawing.Font("Microsoft Sans Serif", 26.25F);
            this.question_timebar.ForeColor = System.Drawing.Color.RoyalBlue;
            this.question_timebar.LabelVisible = false;
            this.question_timebar.LineProgressThickness = 8;
            this.question_timebar.LineThickness = 5;
            this.question_timebar.Location = new System.Drawing.Point(539, 27);
            this.question_timebar.Margin = new System.Windows.Forms.Padding(13, 11, 13, 11);
            this.question_timebar.MaxValue = 61;
            this.question_timebar.Name = "question_timebar";
            this.question_timebar.ProgressBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(35)))), ((int)(((byte)(60)))), ((int)(((byte)(151)))));
            this.question_timebar.ProgressColor = System.Drawing.Color.Yellow;
            this.question_timebar.Size = new System.Drawing.Size(352, 352);
            this.question_timebar.TabIndex = 6;
            this.question_timebar.Value = 60;
            // 
            // question_timer
            // 
            this.question_timer.Enabled = true;
            this.question_timer.Interval = 1000;
            this.question_timer.Tick += new System.EventHandler(this.question_timer_Tick);
            // 
            // panel_off_lbl
            // 
            this.panel_off_lbl.AutoSize = true;
            this.panel_off_lbl.Location = new System.Drawing.Point(16, 437);
            this.panel_off_lbl.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.panel_off_lbl.Name = "panel_off_lbl";
            this.panel_off_lbl.Size = new System.Drawing.Size(0, 17);
            this.panel_off_lbl.TabIndex = 7;
            // 
            // label1
            // 
            this.label1.BackColor = System.Drawing.Color.Transparent;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 26.25F);
            this.label1.Location = new System.Drawing.Point(225, 423);
            this.label1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(1044, 110);
            this.label1.TabIndex = 8;
            this.label1.Text = "label1";
            // 
            // A_btn
            // 
            this.A_btn.BackColor = System.Drawing.Color.Transparent;
            this.A_btn.BackgroundImage = global::Milionare.Properties.Resources.A_yellow;
            this.A_btn.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.A_btn.FlatAppearance.BorderSize = 0;
            this.A_btn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.A_btn.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.A_btn.ForeColor = System.Drawing.SystemColors.GrayText;
            this.A_btn.Location = new System.Drawing.Point(148, 559);
            this.A_btn.Margin = new System.Windows.Forms.Padding(0);
            this.A_btn.Name = "A_btn";
            this.A_btn.Size = new System.Drawing.Size(569, 71);
            this.A_btn.TabIndex = 10;
            this.A_btn.Text = "buttonA";
            this.A_btn.UseVisualStyleBackColor = false;
            this.A_btn.Click += new System.EventHandler(this.A_btn_Click);
            this.A_btn.MouseEnter += new System.EventHandler(this.A_btn_MouseEnter);
            this.A_btn.MouseLeave += new System.EventHandler(this.A_btn_MouseLeave);
            // 
            // C_btn
            // 
            this.C_btn.BackColor = System.Drawing.Color.Transparent;
            this.C_btn.BackgroundImage = global::Milionare.Properties.Resources.C_yellow;
            this.C_btn.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.C_btn.FlatAppearance.BorderSize = 0;
            this.C_btn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.C_btn.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.C_btn.ForeColor = System.Drawing.SystemColors.GrayText;
            this.C_btn.Location = new System.Drawing.Point(152, 647);
            this.C_btn.Margin = new System.Windows.Forms.Padding(0);
            this.C_btn.Name = "C_btn";
            this.C_btn.Size = new System.Drawing.Size(569, 74);
            this.C_btn.TabIndex = 11;
            this.C_btn.Text = "buttonC";
            this.C_btn.UseVisualStyleBackColor = false;
            this.C_btn.Click += new System.EventHandler(this.C_btn_Click);
            this.C_btn.MouseEnter += new System.EventHandler(this.C_btn_MouseEnter);
            this.C_btn.MouseLeave += new System.EventHandler(this.C_btn_MouseLeave);
            // 
            // D_btn
            // 
            this.D_btn.BackColor = System.Drawing.Color.Transparent;
            this.D_btn.BackgroundImage = global::Milionare.Properties.Resources.D_yellow;
            this.D_btn.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.D_btn.FlatAppearance.BorderSize = 0;
            this.D_btn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.D_btn.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.D_btn.ForeColor = System.Drawing.SystemColors.GrayText;
            this.D_btn.Location = new System.Drawing.Point(741, 647);
            this.D_btn.Margin = new System.Windows.Forms.Padding(0);
            this.D_btn.Name = "D_btn";
            this.D_btn.Size = new System.Drawing.Size(571, 74);
            this.D_btn.TabIndex = 13;
            this.D_btn.Text = "buttonD";
            this.D_btn.UseVisualStyleBackColor = false;
            this.D_btn.Click += new System.EventHandler(this.D_btn_Click);
            this.D_btn.MouseEnter += new System.EventHandler(this.D_btn_MouseEnter);
            this.D_btn.MouseLeave += new System.EventHandler(this.D_btn_MouseLeave);
            // 
            // B_btn
            // 
            this.B_btn.BackColor = System.Drawing.Color.Transparent;
            this.B_btn.BackgroundImage = global::Milionare.Properties.Resources.B_yellow;
            this.B_btn.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.B_btn.FlatAppearance.BorderSize = 0;
            this.B_btn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.B_btn.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.B_btn.ForeColor = System.Drawing.SystemColors.GrayText;
            this.B_btn.Location = new System.Drawing.Point(740, 559);
            this.B_btn.Margin = new System.Windows.Forms.Padding(0);
            this.B_btn.Name = "B_btn";
            this.B_btn.Size = new System.Drawing.Size(571, 71);
            this.B_btn.TabIndex = 12;
            this.B_btn.Text = "buttonB";
            this.B_btn.UseVisualStyleBackColor = false;
            this.B_btn.Click += new System.EventHandler(this.B_btn_Click);
            this.B_btn.MouseEnter += new System.EventHandler(this.B_btn_MouseEnter);
            this.B_btn.MouseLeave += new System.EventHandler(this.B_btn_MouseLeave);
            // 
            // validation_timer
            // 
            this.validation_timer.Interval = 1000;
            this.validation_timer.Tick += new System.EventHandler(this.validation_timer_Tick);
            // 
            // level_up_timer
            // 
            this.level_up_timer.Tick += new System.EventHandler(this.level_up_timer_Tick);
            // 
            // quetion_timer_lbl
            // 
            this.quetion_timer_lbl.AutoSize = true;
            this.quetion_timer_lbl.BackColor = System.Drawing.Color.Transparent;
            this.quetion_timer_lbl.Font = new System.Drawing.Font("Nirmala UI", 29.75F);
            this.quetion_timer_lbl.Location = new System.Drawing.Point(688, 175);
            this.quetion_timer_lbl.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.quetion_timer_lbl.Name = "quetion_timer_lbl";
            this.quetion_timer_lbl.Size = new System.Drawing.Size(83, 67);
            this.quetion_timer_lbl.TabIndex = 14;
            this.quetion_timer_lbl.Text = "60";
            // 
            // circle_btn_public
            // 
            this.circle_btn_public.BackColor = System.Drawing.Color.Transparent;
            this.circle_btn_public.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.circle_btn_public.Location = new System.Drawing.Point(1337, 23);
            this.circle_btn_public.Margin = new System.Windows.Forms.Padding(4);
            this.circle_btn_public.Name = "circle_btn_public";
            this.circle_btn_public.Size = new System.Drawing.Size(77, 66);
            this.circle_btn_public.TabIndex = 4;
            this.circle_btn_public.UseVisualStyleBackColor = false;
            this.circle_btn_public.Click += new System.EventHandler(this.circle_btn_public_Click);
            this.circle_btn_public.MouseEnter += new System.EventHandler(this.circle_btn_public_MouseEnter);
            this.circle_btn_public.MouseLeave += new System.EventHandler(this.circle_btn_public_MouseLeave);
            // 
            // circle_btn_call
            // 
            this.circle_btn_call.BackColor = System.Drawing.Color.Transparent;
            this.circle_btn_call.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.circle_btn_call.Location = new System.Drawing.Point(1192, 23);
            this.circle_btn_call.Margin = new System.Windows.Forms.Padding(4);
            this.circle_btn_call.Name = "circle_btn_call";
            this.circle_btn_call.Size = new System.Drawing.Size(77, 66);
            this.circle_btn_call.TabIndex = 3;
            this.circle_btn_call.UseVisualStyleBackColor = false;
            this.circle_btn_call.Click += new System.EventHandler(this.circle_btn_call_Click);
            this.circle_btn_call.MouseEnter += new System.EventHandler(this.circle_btn_call_MouseEnter);
            this.circle_btn_call.MouseLeave += new System.EventHandler(this.circle_btn_call_MouseLeave);
            // 
            // circle_btn_half
            // 
            this.circle_btn_half.BackColor = System.Drawing.Color.Transparent;
            this.circle_btn_half.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.circle_btn_half.Location = new System.Drawing.Point(1047, 23);
            this.circle_btn_half.Margin = new System.Windows.Forms.Padding(4);
            this.circle_btn_half.Name = "circle_btn_half";
            this.circle_btn_half.Size = new System.Drawing.Size(77, 66);
            this.circle_btn_half.TabIndex = 2;
            this.circle_btn_half.UseVisualStyleBackColor = false;
            this.circle_btn_half.Click += new System.EventHandler(this.circle_btn_half_Click);
            this.circle_btn_half.MouseEnter += new System.EventHandler(this.circle_btn_half_MouseEnter);
            this.circle_btn_half.MouseLeave += new System.EventHandler(this.circle_btn_half_MouseLeave);
            // 
            // circle_btn_slide
            // 
            this.circle_btn_slide.BackColor = System.Drawing.Color.Transparent;
            this.circle_btn_slide.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.circle_btn_slide.Location = new System.Drawing.Point(45, 23);
            this.circle_btn_slide.Margin = new System.Windows.Forms.Padding(4);
            this.circle_btn_slide.Name = "circle_btn_slide";
            this.circle_btn_slide.Size = new System.Drawing.Size(77, 66);
            this.circle_btn_slide.TabIndex = 0;
            this.circle_btn_slide.UseVisualStyleBackColor = false;
            this.circle_btn_slide.Click += new System.EventHandler(this.circle_btn_slide_Click);
            this.circle_btn_slide.MouseEnter += new System.EventHandler(this.circle_btn_slide_MouseEnter);
            this.circle_btn_slide.MouseLeave += new System.EventHandler(this.circle_btn_slide_MouseLeave);
            // 
            // circle_btn_leave
            // 
            this.circle_btn_leave.BackColor = System.Drawing.Color.Transparent;
            this.circle_btn_leave.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.circle_btn_leave.Location = new System.Drawing.Point(191, 25);
            this.circle_btn_leave.Margin = new System.Windows.Forms.Padding(4);
            this.circle_btn_leave.Name = "circle_btn_leave";
            this.circle_btn_leave.Size = new System.Drawing.Size(77, 66);
            this.circle_btn_leave.TabIndex = 1;
            this.circle_btn_leave.UseVisualStyleBackColor = false;
            this.circle_btn_leave.Click += new System.EventHandler(this.circle_btn_leave_Click);
            this.circle_btn_leave.MouseEnter += new System.EventHandler(this.circle_btn_leave_MouseEnter);
            this.circle_btn_leave.MouseLeave += new System.EventHandler(this.circle_btn_leave_MouseLeave);
            // 
            // main_form
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = global::Milionare.Properties.Resources.main;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.ClientSize = new System.Drawing.Size(1461, 761);
            this.ControlBox = false;
            this.Controls.Add(this.quetion_timer_lbl);
            this.Controls.Add(this.D_btn);
            this.Controls.Add(this.B_btn);
            this.Controls.Add(this.panel_off_lbl);
            this.Controls.Add(this.question_timebar);
            this.Controls.Add(this.side_panel);
            this.Controls.Add(this.circle_btn_public);
            this.Controls.Add(this.circle_btn_call);
            this.Controls.Add(this.circle_btn_half);
            this.Controls.Add(this.circle_btn_slide);
            this.Controls.Add(this.circle_btn_leave);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.A_btn);
            this.Controls.Add(this.C_btn);
            this.DoubleBuffered = true;
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.MaximizeBox = false;
            this.Name = "main_form";
            this.Load += new System.EventHandler(this.main_form_Load);
            this.side_panel_gradient.ResumeLayout(false);
            this.side_panel.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private circle_button circle_btn_slide;
        private circle_button circle_btn_leave;
        private circle_button circle_btn_half;
        private circle_button circle_btn_call;
        private circle_button circle_btn_public;
        private Bunifu.Framework.UI.BunifuElipse bunifuElipse1;
        private System.Windows.Forms.Panel side_panel;
        private Bunifu.Framework.UI.BunifuGradientPanel side_panel_gradient;
        private System.Windows.Forms.Button button1;
        private Bunifu.Framework.UI.BunifuCircleProgressbar question_timebar;
        private System.Windows.Forms.Timer question_timer;
        private System.Windows.Forms.Label panel_off_lbl;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button D_btn;
        private System.Windows.Forms.Button B_btn;
        private System.Windows.Forms.Button C_btn;
        private System.Windows.Forms.Button A_btn;
        private System.Windows.Forms.Timer validation_timer;
        private System.Windows.Forms.Timer level_up_timer;
        private System.Windows.Forms.Label quetion_timer_lbl;
    }
}