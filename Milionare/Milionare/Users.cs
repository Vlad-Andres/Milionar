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
        }
        private void populate()
        {
            //users_datagrid.Rows.Add(id, name, nick, email, wallet, rank);
            string query = "SELECT * FROM users";
            DataTable table = new DataTable();
            MySqlDataAdapter adapter = new MySqlDataAdapter(query, con_string);
            adapter.Fill(table);
            foreach (DataRow row in table.Rows)
            {
                users_datagrid.Rows.Add(row[0].ToString(), row[1].ToString(), row[2].ToString(), row[3].ToString(), row[5].ToString(), row[6].ToString());
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
            string query = "UPDATE `users` SET `rank` = '" + rank + "' WHERE (`Id` = " + ID + ")";
            try
            {
                using (connection = new MySqlConnection(con_string))
                using (MySqlCommand query_print = new MySqlCommand(query, connection))
                {
                    connection.Open(); query_print.ExecuteNonQuery(); connection.Close();
                }
            }
            catch (MySqlException ex)
            {
                if (MessageBox.Show("Error number: " + ex.Number.ToString() + " \n ,Do you want to read more?", "Error", MessageBoxButtons.YesNo, MessageBoxIcon.Asterisk) == DialogResult.Yes)
                {
                    System.Diagnostics.Process.Start("https://dev.mysql.com/doc/refman/5.6/en/error-messages-server.html");
                    System.Windows.Forms.Clipboard.SetText(ex.Number.ToString());
                }

            }
        }
        private void set_admin_btn_Click(object sender, EventArgs e)
        {
            int rows = users_datagrid.RowCount;
            for (int i=rows-1; i >= 0; i--)
            {
                if (users_datagrid.Rows[i].Selected)
                {
                    add_rank("admin",Convert.ToInt32(users_datagrid.Rows[i].Cells[0].Value));
                }
            }
            users_datagrid.Rows.Clear();
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
    }

}
