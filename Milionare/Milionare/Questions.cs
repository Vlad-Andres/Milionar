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
    public partial class Questions : UserControl
    {
        MySqlConnection connection = new MySqlConnection();
        string con_string = Global.db_connect_prop;
        DataTable table = new DataTable();
        public Questions()
        {
            InitializeComponent();
        }
        private void populate()
        {
            //users_datagrid.Rows.Add(id, question, answer, author, topic, price);
            string query = "SELECT questions.Id, questions.question, questions.var_a, questions.var_b, questions.var_c, questions.var_d, questions.author, questions.correct_ans, topics.topic, questions.price FROM questions,topics WHERE topics.Id= questions.topic_id";
            
            MySqlDataAdapter adapter = new MySqlDataAdapter(query, con_string);
            adapter.Fill(table);
            foreach (DataRow row in table.Rows)
            {
                questions_datagrid.Rows.Add(row[0].ToString(), row[1].ToString(), row[2].ToString(), row[3].ToString(), row[4].ToString(), row[5].ToString(), row[6].ToString(), row[7].ToString(), row[8].ToString(), row[9].ToString());
            }
            //users_datagrid.DataSource = table;
            //SELECT PROPRIETIES
            questions_datagrid.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            questions_datagrid.MultiSelect = false;
        }
        private void set_filter()
        {
            
            foreach (DataRow row in table.Rows)
            {
                // questions_datagrid.Rows.Add(row[0].ToString(), row[1].ToString(), row[2].ToString(), row[3].ToString(), row[4].ToString(), row[5].ToString());
                if (row[3].ToString() == "Bruno")
                {
                    questions_datagrid.Rows[3].Visible = false;
                }
            }

        }

        private void Questions_Load(object sender, EventArgs e)
        {
            questions_datagrid.RowHeadersVisible = false;
            populate();
        }

        private void set_filter_btn_Click(object sender, EventArgs e)
        {

            set_filter();
        }
    }
}
