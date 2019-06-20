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
            avatar_pic.Visible = false;
            //Db save
            if (Properties.Settings.Default.current_shema == "")
            {
                Properties.Settings.Default.current_shema = secured_db_connection.revert_schema;
                Properties.Settings.Default.current_con_string = secured_db_connection.revert_schema;
            }
            Global.db_connect_prop = Properties.Settings.Default.current_con_string;
            Global.schema = Properties.Settings.Default.current_shema;

            if (Global.User.nickname != null)
            {
                main_btns_pnl.Location = new Point (26, 128);
                users_top_pnl.Visible = true;
                if (connection == null)
                {
                    setConnection();
                }
                populate_top_datagrid();

                //users_top_datagrid.Rows[0].Selected = false;

                username_txt.Text = Global.User.nickname;
                username_txt.Visible = true;
                user_score_txt.Text = "Score: "+Global.User.score.ToString();
                user_score_txt.Visible = true;
                user_wallet_txt.Text = "You have: " + Global.User.wallet.ToString()+" $";
                user_wallet_txt.Visible = true;
                login_lbl.Text =  "";
                login_lbl.Enabled = false;
                slash_lbl.Visible = false;
                reg_lbl.Text = " Log out..";
                if (Global.User.avatar_img != null)
                {
                    avatar_pic.Image = Global.User.avatar_img;
                }

                avatar_pic.Visible = true;
                
            }
            if (Global.User.rank=="admin" || Global.User.rank == "moder") { label1.Text = "Back Stage +"; };
           // Application.Run(new first_form());
            

        }
        
        private void first_form_Load(object sender, EventArgs e)
        {
            this.Left = (Screen.PrimaryScreen.WorkingArea.Width - this.Width) / 2;
            this.Top = (Screen.PrimaryScreen.WorkingArea.Height - this.Height) / 2;

            users_top_datagrid.ClearSelection();
            users_top_datagrid.Update();
            if (users_top_pnl.Visible) { select_user_row(); }
            

            //users_top_datagrid.RowsDefaultCellStyle.SelectionBackColor = System.Drawing.Color.Transparent;
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

        //TOP of Players section bellow 
        MySqlConnection connection = null;
        string con_string;
        private void setConnection()
        {
            connection = new MySqlConnection();
            con_string = Global.db_connect_prop;
        }
        private void populate_top_datagrid()
        {
            
            users_top_datagrid.Rows.Clear();
            //string query = "set @row_num = 0; SELECT @row_num := @row_num + 1 as order_num, Nickname FROM milionaire.users ORDER BY score desc;";
            string query = "SELECT Nickname,score FROM "+Global.schema+".users ORDER BY score desc;";
            DataTable table = new DataTable();
            MySqlDataAdapter adapter = new MySqlDataAdapter(query, con_string);

            adapter.Fill(table);
            int order = 0;
            bool isLeader = false;
            
            foreach (DataRow row in table.Rows)
            {
                order++;
                
                if (order <=10) {
                    if (row[0].ToString().Equals(Global.User.nickname)) { isLeader = true;   }
                    users_top_datagrid.Rows.Add(order.ToString(), row[0].ToString(), row[1].ToString());
                }else
                {
                    if (!isLeader) {
                        if (row[0].ToString().Equals(Global.User.nickname)){
                            users_top_datagrid.Rows.Add(order.ToString(), row[0].ToString(), row[1].ToString());
                            
                        }  
                    }
                }
            }
            
            users_top_datagrid.SelectionMode = DataGridViewSelectionMode.FullRowSelect;

        }

        private void select_user_row()
        {
            String searchValue = Global.User.nickname;
            int rowIndex = 1;
            foreach (DataGridViewRow row in users_top_datagrid.Rows)
            {
                if (row.Cells[1].Value.ToString().Equals(searchValue))
                {
                    rowIndex = row.Index;
                    break;
                }
            }
            users_top_datagrid.Rows[rowIndex].Selected = true;
        }

        private void pictureBox2_Click_1(object sender, EventArgs e)
        {
            users_top_datagrid.Rows.Clear();
            populate_top_datagrid();
            users_top_datagrid.ClearSelection();
            users_top_datagrid.Update();
            select_user_row();
        }

        private void settings_pic_MouseEnter(object sender, EventArgs e)
        {
            settings_pic.BackColor = Color.Red;


        }

        private void settings_pic_MouseLeave(object sender, EventArgs e)
        {
            //settings_pic.SizeMode = PictureBoxSizeMode.StretchImage;
            settings_pic.BackColor = Color.Transparent;
        }

        private void settings_pic_MouseHover(object sender, EventArgs e)
        {
            //settings_pic.SizeMode = PictureBoxSizeMode.StretchImage;
            //settings_pic.BackColor = Color.Transparent;
        }

        private void settings_pic_Click(object sender, EventArgs e)
        {
            //!TODO: De facut schimbarea DB 
            Settings s = new Settings();
            s.ShowDialog();
        }
    } 
}
