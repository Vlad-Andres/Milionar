namespace Milionare
{
    partial class Admin_panel
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
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.label1 = new System.Windows.Forms.Label();
            this.admin_name = new System.Windows.Forms.Label();
            this.side_panel = new System.Windows.Forms.Panel();
            this.pictureBox2 = new System.Windows.Forms.PictureBox();
            this.validating_btn = new Bunifu.Framework.UI.BunifuFlatButton();
            this.quest_add_btn = new Bunifu.Framework.UI.BunifuFlatButton();
            this.quest_btn = new Bunifu.Framework.UI.BunifuFlatButton();
            this.users_btn = new Bunifu.Framework.UI.BunifuFlatButton();
            this.logo_panel = new System.Windows.Forms.Panel();
            this.top_panel = new System.Windows.Forms.Panel();
            this.container = new System.Windows.Forms.Panel();
            this.users_tab = new Milionare.Users();
            this.questions_tab = new Milionare.Questions();
            this.pedingQuestions_tab = new Milionare.PedingQuestions();
            this.bunifuDragControl1 = new Bunifu.Framework.UI.BunifuDragControl(this.components);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.side_panel.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).BeginInit();
            this.logo_panel.SuspendLayout();
            this.top_panel.SuspendLayout();
            this.container.SuspendLayout();
            this.SuspendLayout();
            // 
            // pictureBox1
            // 
            this.pictureBox1.BackColor = System.Drawing.Color.Transparent;
            this.pictureBox1.Image = global::Milionare.Properties.Resources.admin_panel;
            this.pictureBox1.Location = new System.Drawing.Point(29, 6);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(107, 76);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox1.TabIndex = 0;
            this.pictureBox1.TabStop = false;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.Transparent;
            this.label1.Font = new System.Drawing.Font("Trebuchet MS", 20.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.SystemColors.ActiveCaption;
            this.label1.Location = new System.Drawing.Point(102, 21);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(433, 35);
            this.label1.TabIndex = 1;
            this.label1.Text = "Thank you for your cooperation ,";
            // 
            // admin_name
            // 
            this.admin_name.AutoSize = true;
            this.admin_name.BackColor = System.Drawing.Color.Transparent;
            this.admin_name.Font = new System.Drawing.Font("Trebuchet MS", 20.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.admin_name.ForeColor = System.Drawing.SystemColors.ActiveCaption;
            this.admin_name.Location = new System.Drawing.Point(541, 21);
            this.admin_name.Name = "admin_name";
            this.admin_name.Size = new System.Drawing.Size(84, 35);
            this.admin_name.TabIndex = 2;
            this.admin_name.Text = "name";
            // 
            // side_panel
            // 
            this.side_panel.BackColor = System.Drawing.Color.Gray;
            this.side_panel.Controls.Add(this.pictureBox2);
            this.side_panel.Controls.Add(this.validating_btn);
            this.side_panel.Controls.Add(this.quest_add_btn);
            this.side_panel.Controls.Add(this.quest_btn);
            this.side_panel.Controls.Add(this.users_btn);
            this.side_panel.Controls.Add(this.logo_panel);
            this.side_panel.Dock = System.Windows.Forms.DockStyle.Left;
            this.side_panel.Location = new System.Drawing.Point(7, 7);
            this.side_panel.Name = "side_panel";
            this.side_panel.Size = new System.Drawing.Size(165, 568);
            this.side_panel.TabIndex = 3;
            // 
            // pictureBox2
            // 
            this.pictureBox2.Image = global::Milionare.Properties.Resources.exit;
            this.pictureBox2.Location = new System.Drawing.Point(57, 492);
            this.pictureBox2.Name = "pictureBox2";
            this.pictureBox2.Size = new System.Drawing.Size(48, 48);
            this.pictureBox2.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox2.TabIndex = 6;
            this.pictureBox2.TabStop = false;
            this.pictureBox2.Click += new System.EventHandler(this.pictureBox2_Click);
            // 
            // validating_btn
            // 
            this.validating_btn.Activecolor = System.Drawing.Color.FromArgb(((int)(((byte)(31)))), ((int)(((byte)(34)))), ((int)(((byte)(55)))));
            this.validating_btn.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(41)))), ((int)(((byte)(53)))), ((int)(((byte)(65)))));
            this.validating_btn.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.validating_btn.BorderRadius = 0;
            this.validating_btn.ButtonText = "Peding questions";
            this.validating_btn.Cursor = System.Windows.Forms.Cursors.Hand;
            this.validating_btn.DisabledColor = System.Drawing.Color.Gray;
            this.validating_btn.Dock = System.Windows.Forms.DockStyle.Top;
            this.validating_btn.Iconcolor = System.Drawing.Color.Transparent;
            this.validating_btn.Iconimage = null;
            this.validating_btn.Iconimage_right = null;
            this.validating_btn.Iconimage_right_Selected = null;
            this.validating_btn.Iconimage_Selected = null;
            this.validating_btn.IconMarginLeft = 0;
            this.validating_btn.IconMarginRight = 0;
            this.validating_btn.IconRightVisible = true;
            this.validating_btn.IconRightZoom = 0D;
            this.validating_btn.IconVisible = true;
            this.validating_btn.IconZoom = 90D;
            this.validating_btn.IsTab = false;
            this.validating_btn.Location = new System.Drawing.Point(0, 244);
            this.validating_btn.Name = "validating_btn";
            this.validating_btn.Normalcolor = System.Drawing.Color.FromArgb(((int)(((byte)(41)))), ((int)(((byte)(53)))), ((int)(((byte)(65)))));
            this.validating_btn.OnHovercolor = System.Drawing.Color.FromArgb(((int)(((byte)(31)))), ((int)(((byte)(34)))), ((int)(((byte)(55)))));
            this.validating_btn.OnHoverTextColor = System.Drawing.Color.White;
            this.validating_btn.selected = false;
            this.validating_btn.Size = new System.Drawing.Size(165, 48);
            this.validating_btn.TabIndex = 3;
            this.validating_btn.Text = "Peding questions";
            this.validating_btn.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.validating_btn.Textcolor = System.Drawing.Color.White;
            this.validating_btn.TextFont = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.validating_btn.Click += new System.EventHandler(this.validating_btn_Click);
            // 
            // quest_add_btn
            // 
            this.quest_add_btn.Activecolor = System.Drawing.Color.FromArgb(((int)(((byte)(31)))), ((int)(((byte)(34)))), ((int)(((byte)(55)))));
            this.quest_add_btn.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(41)))), ((int)(((byte)(53)))), ((int)(((byte)(65)))));
            this.quest_add_btn.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.quest_add_btn.BorderRadius = 0;
            this.quest_add_btn.ButtonText = "Add a question";
            this.quest_add_btn.Cursor = System.Windows.Forms.Cursors.Hand;
            this.quest_add_btn.DisabledColor = System.Drawing.Color.Gray;
            this.quest_add_btn.Dock = System.Windows.Forms.DockStyle.Top;
            this.quest_add_btn.Iconcolor = System.Drawing.Color.Transparent;
            this.quest_add_btn.Iconimage = null;
            this.quest_add_btn.Iconimage_right = null;
            this.quest_add_btn.Iconimage_right_Selected = null;
            this.quest_add_btn.Iconimage_Selected = null;
            this.quest_add_btn.IconMarginLeft = 0;
            this.quest_add_btn.IconMarginRight = 0;
            this.quest_add_btn.IconRightVisible = true;
            this.quest_add_btn.IconRightZoom = 0D;
            this.quest_add_btn.IconVisible = true;
            this.quest_add_btn.IconZoom = 90D;
            this.quest_add_btn.IsTab = false;
            this.quest_add_btn.Location = new System.Drawing.Point(0, 196);
            this.quest_add_btn.Name = "quest_add_btn";
            this.quest_add_btn.Normalcolor = System.Drawing.Color.FromArgb(((int)(((byte)(41)))), ((int)(((byte)(53)))), ((int)(((byte)(65)))));
            this.quest_add_btn.OnHovercolor = System.Drawing.Color.FromArgb(((int)(((byte)(31)))), ((int)(((byte)(34)))), ((int)(((byte)(55)))));
            this.quest_add_btn.OnHoverTextColor = System.Drawing.Color.White;
            this.quest_add_btn.selected = false;
            this.quest_add_btn.Size = new System.Drawing.Size(165, 48);
            this.quest_add_btn.TabIndex = 2;
            this.quest_add_btn.Text = "Add a question";
            this.quest_add_btn.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.quest_add_btn.Textcolor = System.Drawing.Color.White;
            this.quest_add_btn.TextFont = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.quest_add_btn.Click += new System.EventHandler(this.quest_add_btn_Click);
            // 
            // quest_btn
            // 
            this.quest_btn.Activecolor = System.Drawing.Color.FromArgb(((int)(((byte)(31)))), ((int)(((byte)(34)))), ((int)(((byte)(55)))));
            this.quest_btn.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(41)))), ((int)(((byte)(53)))), ((int)(((byte)(65)))));
            this.quest_btn.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.quest_btn.BorderRadius = 0;
            this.quest_btn.ButtonText = "Questions";
            this.quest_btn.Cursor = System.Windows.Forms.Cursors.Hand;
            this.quest_btn.DisabledColor = System.Drawing.Color.Gray;
            this.quest_btn.Dock = System.Windows.Forms.DockStyle.Top;
            this.quest_btn.Iconcolor = System.Drawing.Color.Transparent;
            this.quest_btn.Iconimage = null;
            this.quest_btn.Iconimage_right = null;
            this.quest_btn.Iconimage_right_Selected = null;
            this.quest_btn.Iconimage_Selected = null;
            this.quest_btn.IconMarginLeft = 0;
            this.quest_btn.IconMarginRight = 0;
            this.quest_btn.IconRightVisible = true;
            this.quest_btn.IconRightZoom = 0D;
            this.quest_btn.IconVisible = true;
            this.quest_btn.IconZoom = 90D;
            this.quest_btn.IsTab = false;
            this.quest_btn.Location = new System.Drawing.Point(0, 148);
            this.quest_btn.Name = "quest_btn";
            this.quest_btn.Normalcolor = System.Drawing.Color.FromArgb(((int)(((byte)(41)))), ((int)(((byte)(53)))), ((int)(((byte)(65)))));
            this.quest_btn.OnHovercolor = System.Drawing.Color.FromArgb(((int)(((byte)(31)))), ((int)(((byte)(34)))), ((int)(((byte)(55)))));
            this.quest_btn.OnHoverTextColor = System.Drawing.Color.White;
            this.quest_btn.selected = false;
            this.quest_btn.Size = new System.Drawing.Size(165, 48);
            this.quest_btn.TabIndex = 1;
            this.quest_btn.Text = "Questions";
            this.quest_btn.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.quest_btn.Textcolor = System.Drawing.Color.White;
            this.quest_btn.TextFont = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.quest_btn.Click += new System.EventHandler(this.quest_btn_Click);
            // 
            // users_btn
            // 
            this.users_btn.Activecolor = System.Drawing.Color.FromArgb(((int)(((byte)(31)))), ((int)(((byte)(34)))), ((int)(((byte)(55)))));
            this.users_btn.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(41)))), ((int)(((byte)(53)))), ((int)(((byte)(65)))));
            this.users_btn.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.users_btn.BorderRadius = 0;
            this.users_btn.ButtonText = "Users";
            this.users_btn.Cursor = System.Windows.Forms.Cursors.Hand;
            this.users_btn.DisabledColor = System.Drawing.Color.Gray;
            this.users_btn.Dock = System.Windows.Forms.DockStyle.Top;
            this.users_btn.Iconcolor = System.Drawing.Color.Transparent;
            this.users_btn.Iconimage = null;
            this.users_btn.Iconimage_right = null;
            this.users_btn.Iconimage_right_Selected = null;
            this.users_btn.Iconimage_Selected = null;
            this.users_btn.IconMarginLeft = 0;
            this.users_btn.IconMarginRight = 0;
            this.users_btn.IconRightVisible = true;
            this.users_btn.IconRightZoom = 0D;
            this.users_btn.IconVisible = true;
            this.users_btn.IconZoom = 90D;
            this.users_btn.IsTab = false;
            this.users_btn.Location = new System.Drawing.Point(0, 100);
            this.users_btn.Name = "users_btn";
            this.users_btn.Normalcolor = System.Drawing.Color.FromArgb(((int)(((byte)(41)))), ((int)(((byte)(53)))), ((int)(((byte)(65)))));
            this.users_btn.OnHovercolor = System.Drawing.Color.FromArgb(((int)(((byte)(31)))), ((int)(((byte)(34)))), ((int)(((byte)(55)))));
            this.users_btn.OnHoverTextColor = System.Drawing.Color.White;
            this.users_btn.selected = false;
            this.users_btn.Size = new System.Drawing.Size(165, 48);
            this.users_btn.TabIndex = 0;
            this.users_btn.Text = "Users";
            this.users_btn.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.users_btn.Textcolor = System.Drawing.Color.White;
            this.users_btn.TextFont = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.users_btn.Click += new System.EventHandler(this.users_btn_Click);
            this.users_btn.MouseClick += new System.Windows.Forms.MouseEventHandler(this.users_btn_MouseClick);
            // 
            // logo_panel
            // 
            this.logo_panel.BackColor = System.Drawing.Color.Transparent;
            this.logo_panel.Controls.Add(this.pictureBox1);
            this.logo_panel.Dock = System.Windows.Forms.DockStyle.Top;
            this.logo_panel.ForeColor = System.Drawing.Color.Transparent;
            this.logo_panel.Location = new System.Drawing.Point(0, 0);
            this.logo_panel.Name = "logo_panel";
            this.logo_panel.Size = new System.Drawing.Size(165, 100);
            this.logo_panel.TabIndex = 5;
            // 
            // top_panel
            // 
            this.top_panel.BackColor = System.Drawing.Color.Transparent;
            this.top_panel.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.top_panel.Controls.Add(this.label1);
            this.top_panel.Controls.Add(this.admin_name);
            this.top_panel.Dock = System.Windows.Forms.DockStyle.Top;
            this.top_panel.Location = new System.Drawing.Point(172, 7);
            this.top_panel.Name = "top_panel";
            this.top_panel.Size = new System.Drawing.Size(768, 77);
            this.top_panel.TabIndex = 4;
            // 
            // container
            // 
            this.container.BackColor = System.Drawing.Color.Transparent;
            this.container.Controls.Add(this.users_tab);
            this.container.Controls.Add(this.questions_tab);
            this.container.Controls.Add(this.pedingQuestions_tab);
            this.container.Dock = System.Windows.Forms.DockStyle.Right;
            this.container.Location = new System.Drawing.Point(172, 84);
            this.container.Name = "container";
            this.container.Size = new System.Drawing.Size(768, 491);
            this.container.TabIndex = 5;
            // 
            // users_tab
            // 
            this.users_tab.BackColor = System.Drawing.SystemColors.ActiveBorder;
            this.users_tab.Dock = System.Windows.Forms.DockStyle.Fill;
            this.users_tab.Location = new System.Drawing.Point(0, 0);
            this.users_tab.Name = "users_tab";
            this.users_tab.Size = new System.Drawing.Size(768, 491);
            this.users_tab.TabIndex = 1;
            // 
            // questions_tab
            // 
            this.questions_tab.BackColor = System.Drawing.SystemColors.ActiveBorder;
            this.questions_tab.Dock = System.Windows.Forms.DockStyle.Fill;
            this.questions_tab.Location = new System.Drawing.Point(0, 0);
            this.questions_tab.Name = "questions_tab";
            this.questions_tab.Size = new System.Drawing.Size(768, 491);
            this.questions_tab.TabIndex = 0;
            // 
            // pedingQuestions_tab
            // 
            this.pedingQuestions_tab.AutoSize = true;
            this.pedingQuestions_tab.BackColor = System.Drawing.SystemColors.ActiveBorder;
            this.pedingQuestions_tab.Dock = System.Windows.Forms.DockStyle.Fill;
            this.pedingQuestions_tab.Location = new System.Drawing.Point(0, 0);
            this.pedingQuestions_tab.Name = "pedingQuestions_tab";
            this.pedingQuestions_tab.Size = new System.Drawing.Size(768, 491);
            this.pedingQuestions_tab.TabIndex = 2;
            // 
            // bunifuDragControl1
            // 
            this.bunifuDragControl1.Fixed = true;
            this.bunifuDragControl1.Horizontal = true;
            this.bunifuDragControl1.TargetControl = this;
            this.bunifuDragControl1.Vertical = true;
            // 
            // Admin_panel
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.BackgroundImage = global::Milionare.Properties.Resources.dark_blue_wallpaper_10;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.ClientSize = new System.Drawing.Size(947, 582);
            this.Controls.Add(this.container);
            this.Controls.Add(this.top_panel);
            this.Controls.Add(this.side_panel);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.MaximizeBox = false;
            this.Name = "Admin_panel";
            this.Padding = new System.Windows.Forms.Padding(7);
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.side_panel.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).EndInit();
            this.logo_panel.ResumeLayout(false);
            this.top_panel.ResumeLayout(false);
            this.top_panel.PerformLayout();
            this.container.ResumeLayout(false);
            this.container.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label admin_name;
        private System.Windows.Forms.Panel side_panel;
        private System.Windows.Forms.Panel logo_panel;
        private System.Windows.Forms.Panel top_panel;
        private Bunifu.Framework.UI.BunifuFlatButton validating_btn;
        private Bunifu.Framework.UI.BunifuFlatButton quest_add_btn;
        private Bunifu.Framework.UI.BunifuFlatButton quest_btn;
        private Bunifu.Framework.UI.BunifuFlatButton users_btn;
        private System.Windows.Forms.Panel container;
        private System.Windows.Forms.PictureBox pictureBox2;
        private Users users_tab;
        private Questions questions_tab;
        private PedingQuestions pedingQuestions_tab;
        public Bunifu.Framework.UI.BunifuDragControl bunifuDragControl1;
    }
}