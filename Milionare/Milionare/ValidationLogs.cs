using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using MySql.Data.MySqlClient;

namespace Milionare
{
    public partial class validation_logs : UserControl
    {

        MySqlConnection connection = new MySqlConnection();
        string con_string = Global.db_connect_prop;
        DataTable table = new DataTable();

        public validation_logs()
        {
            InitializeComponent();
            populate();
        }
        private void populate()
        {
            logs_datagrid.Rows.Clear();
            logs_datagrid.Refresh();

            //users_datagrid.Rows.Add(id, question, answer, author, topic, price);
            string query = "SELECT u.Nickname , v.verdict, v.question_id , (SELECT Nickname FROM users WHERE Id = v.author_id) , v.executed_on ,t.topic, v.question_text, v.var_a, v.var_b, v.var_c, v.var_d, v.correct_ans FROM validation_logs v JOIN users u ON v.user_id= u.Id left JOIN topics t ON v.topic_id = t.Id;";

            MySqlDataAdapter adapter = new MySqlDataAdapter(query, con_string);
            adapter.Fill(table);
            foreach (DataRow row in table.Rows)
            {
                logs_datagrid.Rows.Add(row[0].ToString(), row[1].ToString(), row[2].ToString(), row[3].ToString(), row[4].ToString(), row[5].ToString(), row[6].ToString(), row[7].ToString(), row[8].ToString(), row[9].ToString(), row[10].ToString(), row[11].ToString());
            }

            logs_datagrid.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            logs_datagrid.MultiSelect = false;
        }

        private void logs_datagrid_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            if (logs_datagrid.Rows[e.RowIndex].Cells[2].Value.ToString() != "")
            {
                MessageBox.Show("first");
                question_log_form log = new question_log_form(Convert.ToInt32(logs_datagrid.Rows[e.RowIndex].Cells[2].Value), logs_datagrid.Rows[e.RowIndex].Cells[3].Value.ToString());
                log.TopMost = true;
                log.Show();
            }
            else
            {
                MessageBox.Show("seccond");
                question_log_form log = new question_log_form(
                    logs_datagrid.Rows[e.RowIndex].Cells[6].Value.ToString(),
                    logs_datagrid.Rows[e.RowIndex].Cells[3].Value.ToString(),
                    logs_datagrid.Rows[e.RowIndex].Cells[5].Value.ToString(),
                    logs_datagrid.Rows[e.RowIndex].Cells[7].Value.ToString(),
                    logs_datagrid.Rows[e.RowIndex].Cells[8].Value.ToString(),
                    logs_datagrid.Rows[e.RowIndex].Cells[9].Value.ToString(),
                    logs_datagrid.Rows[e.RowIndex].Cells[10].Value.ToString(),
                    logs_datagrid.Rows[e.RowIndex].Cells[11].Value.ToString()
                    );
                log.TopMost = true;
                log.Show();
            }
            
        }
    }
}
