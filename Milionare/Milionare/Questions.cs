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

        private void populate(string table_from)
        {
            questions_datagrid.Rows.Clear();
            questions_datagrid.Refresh();

            //users_datagrid.Rows.Add(id, question, answer, author, topic, price);
            string query = "SELECT q.Id, q.question, q.correct_ans,  u.Name, t.topic, q.price FROM "+table_from+" q JOIN topics t ON q.topic_id = t.Id JOIN users u ON q.author = u.Id;";
            
            MySqlDataAdapter adapter = new MySqlDataAdapter(query, con_string);
            adapter.Fill(table);
            foreach (DataRow row in table.Rows)
            {
                questions_datagrid.Rows.Add(row[0].ToString(), row[1].ToString(), row[2].ToString(), row[3].ToString(), row[4].ToString(), row[5].ToString());
            }

            questions_datagrid.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            questions_datagrid.MultiSelect = false;
        }


        private void Questions_Load(object sender, EventArgs e)
        {
            questions_datagrid.RowHeadersVisible = false;
            label1.Text="Validating Questions";
            populate("validating_questions");
        }


        private void questions_datagrid_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            //if (e.ColumnIndex == 3) {
            //   .Visible = true;
            //    questions_tab.Visible = false;
            //}
            //MessageBox.Show(e.ColumnIndex.ToString());
        }


    }
}
