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
    public partial class PedingQuestions : UserControl
    {
        MySqlConnection connection = new MySqlConnection();
        string con_string = Global.db_connect_prop;
        DataTable table = new DataTable();

        public PedingQuestions()
        {
            InitializeComponent();
        }

        private void populate(string table_from)
        {
            questions_datagrid.Rows.Clear();
            questions_datagrid.Refresh();

            //users_datagrid.Rows.Add(id, question, answer, author, topic, price);
            string query = "SELECT q.question, q.correct_ans, t.topic, q.price, q.var_a, q.var_b, q.var_c, q.var_d, q.Id FROM " + table_from + " q JOIN topics t ON q.topic_id = t.Id JOIN users u ON q.author = u.Id;";

            MySqlDataAdapter adapter = new MySqlDataAdapter(query, con_string);
            adapter.Fill(table);
            foreach (DataRow row in table.Rows)
            {
                questions_datagrid.Rows.Add(row[0].ToString(), row[1].ToString(), row[2].ToString(), row[3].ToString(), row[4].ToString(), row[5].ToString(), row[6].ToString(), row[7].ToString(),row[8].ToString());
            }

            questions_datagrid.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            questions_datagrid.MultiSelect = false;
        }

        private void PedingQuestions_Load(object sender, EventArgs e)
        {
            questions_datagrid.RowHeadersVisible = false;
            
            populate("validating_questions");
        }

        private void questions_datagrid_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            verdict_adapter(e);
        }

        private void verdict_adapter(DataGridViewCellEventArgs e)
        {
            

            switch (e.ColumnIndex.ToString())
            {
                case "9":
                    {

                        try{
                            Global.question_write(
                                "questions",
                                questions_datagrid.Rows[e.RowIndex].Cells[2].Value.ToString(),
                                questions_datagrid.Rows[e.RowIndex].Cells[0].Value.ToString(),
                                questions_datagrid.Rows[e.RowIndex].Cells[4].Value.ToString(),
                                questions_datagrid.Rows[e.RowIndex].Cells[5].Value.ToString(),
                                questions_datagrid.Rows[e.RowIndex].Cells[6].Value.ToString(),
                                questions_datagrid.Rows[e.RowIndex].Cells[7].Value.ToString(),
                                questions_datagrid.Rows[e.RowIndex].Cells[1].Value.ToString(),
                                Convert.ToInt32(questions_datagrid.Rows[e.RowIndex].Cells[3].Value)
                                );

                            string query = "DELETE FROM `validating_questions` WHERE (`Id`= " + Convert.ToInt32(questions_datagrid.Rows[e.RowIndex].Cells[8].Value) + ")";

                            try
                            {
                                using (connection = new MySqlConnection(con_string))
                                using (MySqlCommand query_print = new MySqlCommand(query, connection))
                                {
                                    connection.Open(); query_print.ExecuteNonQuery(); connection.Close();
                                }
                                questions_datagrid.Rows.RemoveAt(e.RowIndex);
                            }
                            catch (MySqlException ex)
                            {
                                Global.mysql_err_msg(ex);
                            }

                        }
                        catch(Exception exception)
                        {
                            MessageBox.Show(exception.Message);
                        }

                        

                       

                        break;
                    }
                case "10":
                    {
                        MessageBox.Show(questions_datagrid.Rows[e.RowIndex].Cells[8].Value.ToString());
                        string query = "DELETE FROM `validating_questions` WHERE (`Id`= "+ Convert.ToInt32(questions_datagrid.Rows[e.RowIndex].Cells[8].Value) + ")";
                        try
                        {
                            using (connection = new MySqlConnection(con_string))
                            using (MySqlCommand query_print = new MySqlCommand(query, connection))
                            {
                                connection.Open(); query_print.ExecuteNonQuery(); connection.Close();
                            }
                            questions_datagrid.Rows.RemoveAt(e.RowIndex);
                        }
                        catch (MySqlException ex)
                        {
                            Global.mysql_err_msg(ex);
                        }

                        

                        break;
                    }
                default: break;
            }
        }
    }
}
