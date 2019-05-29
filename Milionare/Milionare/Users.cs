using System;
using System.Data;
using System.Windows.Forms;
using MySql.Data.MySqlClient;
namespace Milionare
{
    public partial class Users : UserControl
    {
        MySqlConnection connection = new MySqlConnection();
        string con_string = Global.db_connect_prop;
        public Users()
        {
            
            InitializeComponent();
            if (Global.User.rank != "admin") {
                button1.Enabled = false;
                button1.Visible = false;//button1.Cursor = Cursors.No;
                add_user_btn.Visible = false;
                add_user_btn.Enabled = false;
                set_user_btn.Enabled = false;
                set_user_btn.Visible = false;
                set_admin_btn.Visible = false;
                set_admin_btn.Enabled = false;
                users_datagrid.Visible = false;
                users_datagrid.Enabled = false;
            }
        }
        private void populate()
        {
            users_datagrid.Rows.Clear();
            //users_datagrid.Rows.Add(id, name, nick, email, wallet, rank);
            string query = "SELECT `Id`,`Name`,`Nickname`,`email`,`wallet`,`rank`,`last_login` FROM users;";
            DataTable table = new DataTable();
            MySqlDataAdapter adapter = new MySqlDataAdapter(query, con_string);
            adapter.Fill(table);
            foreach (DataRow row in table.Rows)
            {
                users_datagrid.Rows.Add(row[0].ToString(), row[1].ToString(), row[2].ToString(), row[3].ToString(), row[4].ToString(), row[5].ToString(),row[6].ToString());
            }
            //users_datagrid.DataSource = table;
            //SELECT PROPRIETIES
            users_datagrid.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            users_datagrid.MultiSelect = false;
        }

        private void Users_Load(object sender, EventArgs e)
        {
            users_datagrid.RowHeadersVisible = false;
            populate();
        }
        private void add_rank(string rank,int ID)
        {
            string querry = "UPDATE `users` SET `rank` = '" + rank + "' WHERE (`Id` = " + ID + ")";
            try
            {
                using (connection = new MySqlConnection(con_string))
                using (MySqlCommand querry_print = new MySqlCommand(querry, connection))
                {
                    connection.Open(); querry_print.ExecuteNonQuery(); connection.Close();
                }
            }
            catch (MySqlException ex)
            {
                Global.mysql_err_msg(ex);
            }
        }
        private void delete_user(int ID)
        {
            string querry = "DELETE FROM `users` WHERE (`Id`= " + ID + ")";
            try
            {
                using (connection = new MySqlConnection(con_string))
                using (MySqlCommand querry_print = new MySqlCommand(querry, connection))
                {
                    connection.Open(); querry_print.ExecuteNonQuery(); connection.Close();
                }
            }
            catch (MySqlException ex)
            {
                Global.mysql_err_msg(ex);
            }
        }
        private void set_admin_btn_Click(object sender, EventArgs e)
        {
            int rows = users_datagrid.RowCount;
            for (int i=rows-1; i >= 0; i--)
            {
                if (users_datagrid.Rows[i].Selected)
                {
                    add_rank("moder",Convert.ToInt32(users_datagrid.Rows[i].Cells[0].Value));
                }
            }

            populate();
        }

        private void set_user_btn_Click(object sender, EventArgs e)
        {
            int rows = users_datagrid.RowCount;
            for (int i = rows - 1; i >= 0; i--)
            {
                if (users_datagrid.Rows[i].Selected)
                {
                    add_rank("user", Convert.ToInt32(users_datagrid.Rows[i].Cells[0].Value));
                }
            }
            users_datagrid.Rows.Clear();
            populate();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            int rows = users_datagrid.RowCount;
            for (int i = rows - 1; i >= 0; i--)
            {
                if (users_datagrid.Rows[i].Selected)
                {
                    delete_user(Convert.ToInt32(users_datagrid.Rows[i].Cells[0].Value));
                }
            }
            populate();
        }

        private void add_user_btn_Click(object sender, EventArgs e)
        {
            Register r = new Register();
            r.Show();
            
        }
    }

}
