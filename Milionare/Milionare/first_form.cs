using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Configuration;
using MySql.Data.MySqlClient;
using System.Threading;
using System.IO;

/*
SELECT* FROM topics WHERE Id IN
  (SELECT topic_id FROM games)
  
 */


namespace Milionare
{
    public partial class first_form : Form
    {
        
        public first_form()
        {

            InitializeComponent();
            if (Global.User.nickname != null)
            {
                username_txt.Text = Global.User.nickname;
                username_txt.Visible = true;
                login_lbl.Text =  "";
                login_lbl.Enabled = false;
                slash_lbl.Visible = false;
                reg_lbl.Text = " Log out..";
                avatar_pic.Image = Global.User.avatar_img;    
            }
            if (Global.User.rank=="admin" || Global.User.rank == "moder") { label1.Text = "Back Stage +"; };
           // Application.Run(new first_form());
            

        }
        
        private void first_form_Load(object sender, EventArgs e)
        {
            this.Left = (Screen.PrimaryScreen.WorkingArea.Width - this.Width) / 2;
            this.Top = (Screen.PrimaryScreen.WorkingArea.Height - this.Height) / 2;
        }

        private void science_btn_Click(object sender, EventArgs e)
        {
            if (Global.User.nickname == null)
            {
                if (MetroFramework.MetroMessageBox.Show(this, "Do you want to Log in to be able for stats?", "", MessageBoxButtons.YesNo, MessageBoxIcon.Hand) == DialogResult.Yes)
                {
                    login l = new login();
                    this.Hide();
                    l.ShowDialog();
                }
                else
                {

                    Global.topic_write(1);
                    if (Global.passed)
                    {
                        main_form f = new main_form();
                        this.Hide();
                        f.ShowDialog();
                    }
                }
            }
            else
            {
                Global.topic_write(1);
                if (Global.passed)
                {
                    main_form f = new main_form();
                    this.Hide();
                    f.ShowDialog();
                }
            }
        }


        private void sport_Click(object sender, EventArgs e)
        {
            // Database -> session -> topic -> 
            if (Global.User.nickname == null)
            {
                if (MetroFramework.MetroMessageBox.Show(this, "Do you want to Log in to be able for stats?", "", MessageBoxButtons.YesNo, MessageBoxIcon.Hand) == DialogResult.Yes)
                {
                    login l = new login();
                    this.Hide();
                    l.ShowDialog();
                }
                else
                {

                    Global.topic_write(2);
                    if (Global.passed)
                    {
                        main_form f = new main_form();
                        this.Hide();
                        f.ShowDialog();
                    }
                }
            }
            else
            {

                Global.topic_write(2);
                if (Global.passed)
                {
                    main_form f = new main_form();
                    this.Hide();
                    f.ShowDialog();
                }
            }
        }

        private void arts_btn_Click(object sender, EventArgs e)
        {
            // Database -> session -> topic -> 
            if (Global.User.nickname == null)
            {
                if (MetroFramework.MetroMessageBox.Show(this, "Do you want to Log in to be able for stats?", "", MessageBoxButtons.YesNo, MessageBoxIcon.Hand) == DialogResult.Yes)
                {
                    login l = new login();
                    this.Hide();
                    l.ShowDialog();
                }
                else
                {

                    Global.topic_write(3);
                    if (Global.passed)
                    {
                        main_form f = new main_form();
                        this.Hide();
                        f.ShowDialog();
                    }
                }
            }
            else
            {

                Global.topic_write(3);
                if (Global.passed)
                {
                    main_form f = new main_form();
                    this.Hide();
                    f.ShowDialog();
                }
            }
        }

        private void history_btn_Click(object sender, EventArgs e)
        {
            // Database -> session -> topic ->
            // Database -> session -> topic -> science
            if (Global.User.nickname == null)
            {
                if (MetroFramework.MetroMessageBox.Show(this, "Do you want to Log in to be able for stats?", "", MessageBoxButtons.YesNo, MessageBoxIcon.Hand) == DialogResult.Yes)
                {
                    login l = new login();
                    this.Hide();
                    l.ShowDialog();
                }
                else
                {

                    Global.topic_write(4);
                    if (Global.passed)
                    {
                        main_form f = new main_form();
                        this.Hide();
                        f.ShowDialog();
                    }
                }
            }
            else
            {

                Global.topic_write(4);
                if (Global.passed)
                {
                    main_form f = new main_form();
                    this.Hide();
                    f.ShowDialog();
                }
            }
        }
        private void pictureBox1_Click(object sender, EventArgs e)
        {

            // Database -> session -> topic ->
            // Database -> session -> topic -> science
            if (Global.User.nickname == null)
            {
                if (MetroFramework.MetroMessageBox.Show(this, "Do you want to Log in to be able for stats?", "", MessageBoxButtons.YesNo, MessageBoxIcon.Hand) == DialogResult.Yes)
                {
                    login l = new login();
                    this.Hide();
                    l.ShowDialog();
                }
                else
                {

                    Global.topic_write(5);
                    if (Global.passed)
                    {
                        main_form f = new main_form();
                        this.Hide();
                        f.ShowDialog();
                    }
                }
            }
            else
            {

                Global.topic_write(5);
                if (Global.passed)
                {
                    main_form f = new main_form();
                    this.Hide();
                    f.ShowDialog();
                }
            }
        }
        private void exit_button_Click(object sender, EventArgs e)
        {
            this.Dispose();
            Application.Exit();
        }

        private void label1_MouseHover(object sender, EventArgs e)
        {
            label1.ForeColor = Color.Red;
        }

        private void label1_MouseLeave(object sender, EventArgs e)
        {
            label1.ForeColor = Color.White;
        }
        private void login_lbl_MouseEnter(object sender, EventArgs e)
        {
            login_lbl.ForeColor = Color.Red;
        }

        private void login_lbl_MouseLeave(object sender, EventArgs e)
        {
            login_lbl.ForeColor = Color.White;
        }

        private void reg_lbl_MouseEnter(object sender, EventArgs e)
        {
            reg_lbl.ForeColor = Color.Red;
        }

        private void reg_lbl_MouseLeave(object sender, EventArgs e)
        {
            reg_lbl.ForeColor = Color.White;
        }

        private void label1_Click(object sender, EventArgs e)
        {
            if (Global.User.nickname != null)
            { if (Global.User.rank == "admin" || Global.User.rank == "moder")
                {
                    Admin_panel a = new Admin_panel();
                    this.Dispose();
                    a.ShowDialog();
                }
                else
                {
                    backstage f = new backstage();
                    this.Hide();
                    f.ShowDialog();
                }
            }
            else MetroFramework.MetroMessageBox.Show(this, "Please Log In to be able to post questions", "", MessageBoxButtons.OK, MessageBoxIcon.Stop);
        }

        private void login_lbl_Click(object sender, EventArgs e)
        {
            login l = new login();
            this.Hide();
            l.ShowDialog();
        }

        private void reg_lbl_Click(object sender, EventArgs e)
        {
            if(reg_lbl.Text== " Log out..")
            {
                Global.User.nickname = null;
                first_form f = new first_form();
                this.Dispose();
                f.Show();

            }
            else
            { 
                Register r = new Register();
                this.Hide();
                r.ShowDialog();
            }
        }

        private void pictureBox1_MouseEnter(object sender, EventArgs e)
        {
            pictureBox1.BackColor = Color.Azure;
        }

        private void pictureBox1_MouseLeave(object sender, EventArgs e)
        {
            pictureBox1.BackColor = Color.Transparent;
        }

    }
}
