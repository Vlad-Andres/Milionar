using MySql.Data.MySqlClient;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Milionare
{
    public partial class Settings : Form
    {
        
        public Settings()
        {
            InitializeComponent();
            if (secured_db_connection.db_schema != secured_db_connection.revert_schema) { global_db_cbx.Checked = false; }
        }

        private void global_db_cbx_CheckedChanged(object sender, EventArgs e)
        {
            if (global_db_cbx.Checked)
            {
                Db_panel.Enabled = false;
                connect_btn.BackColor = SystemColors.InactiveCaption;
                create_db_btn.BackColor = SystemColors.InactiveCaption;
                Db_panel.BackColor = SystemColors.InactiveCaption;
                if (secured_db_connection.db_schema != secured_db_connection.revert_schema)
                {
                    secured_db_connection.db_connect_prop= secured_db_connection.revert_prop;
                    secured_db_connection.db_schema = secured_db_connection.revert_schema;
                    MessageBox.Show("Reverted to Global Repository!");
                }
            }
            else
            {
                Db_panel.Enabled = true;
                connect_btn.BackColor = Color.FromArgb(35, 82, 120);
                create_db_btn.BackColor = Color.FromArgb(35, 82, 120);
                Db_panel.BackColor = Color.Transparent;
            }
        }

        private void create_db_btn_Click(object sender, EventArgs e)
        {
            if(MessageBox.Show("To create Local database you must have mysql engine installed. Are you sure you want to proceed?", "Warning", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
            {
                string connStr = "server="+server_lbl.Text+";user="+user_lbl.Text+";password="+pass_lbl.Text+";";
                try
                {
                    string script = File.ReadAllText(@"resources/database/local_template.sql");

                    string full_query = "CREATE DATABASE IF NOT EXISTS `" + db_name_lbl.Text + "`; USE `" + db_name_lbl.Text + "`; " + script;
                    MySqlConnection conn = new MySqlConnection(connStr);
                    MySqlCommand cmd;
                    conn.Open();
                    cmd = new MySqlCommand(full_query, conn);
                    cmd.ExecuteNonQuery();
                    conn.Close();
                    MessageBox.Show("Now you can connect to this database from each PC within your server \n ----------------------------------------------------------------- \nPlease remember this information for further connection \n Database: "+db_name_lbl.Text+" \n Server: "+server_lbl.Text+" \n User: "+user_lbl.Text+" \n Password: "+pass_lbl.Text+ " \n -----------------------------------------------------------------", "Done!", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.Message);
                }
                
            }
        }

        private void exit_button_Click(object sender, EventArgs e)
        {
            this.Dispose();
        }

        private void connect_btn_Click(object sender, EventArgs e)
        {
            MySqlConnection connection = new MySqlConnection();
            string connStr = "server=" + server_lbl.Text + ";user=" + user_lbl.Text + ";password=" + pass_lbl.Text + ";";
            string testingDb_query = "SELECT COUNT(*) FROM information_schema.tables WHERE table_schema = '" + db_name_lbl.Text + "';";

            try
            {
                using (connection = new MySqlConnection(connStr))
                using (MySqlCommand query_print = new MySqlCommand(testingDb_query, connection))
                {
                    connection.Open();
                    MySqlDataReader dr = query_print.ExecuteReader(); dr.Read();
                    if (dr["COUNT(*)"].ToString() == "11")
                    {
                        MessageBox.Show("Your database is VALID for this application.", "SWITCHED");

                        secured_db_connection.db_connect_prop = 
                            "server="+server_lbl.Text+"; database="+db_name_lbl.Text+"; user="+user_lbl.Text+"; password="+pass_lbl.Text+"";
                        secured_db_connection.db_schema = db_name_lbl.Text;
                    }
                    else
                    {
                        MessageBox.Show("Unfortunately your database does not satisfy our conditions to be elegible, please retry.", "ERROR");
                    }

                    connection.Close();
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }
    }
}
