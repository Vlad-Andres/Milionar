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
        //for refused
        private void write_log(string verdict, string author, string topic, string question_text, int price, string var_a, string var_b, string var_c, string var_d,string correct_ans)
        {
            string timestamp = DateTime.Now.ToString("yyyy-MM-dd HH:mm:ss");

            MySqlConnection connection = new MySqlConnection();

            string querry;
                querry = "INSERT INTO milionaire.validation_logs (user_id,verdict,executed_on,question_id,author_id,topic_id,question_text,price,var_a,var_b,var_c,var_d,correct_ans) values(" + Global.User.id + ", '" + verdict + "', '" + timestamp + "', null ,(SELECT Id FROM users WHERE Nickname = '"+author+"'),(SELECT Id from topics WHERE topic = '"+topic+"'),'"+question_text+"',"+price+",'"+var_a+ "','" + var_b + "','" + var_c + "','" + var_d + "','" + correct_ans + "' )";

            try
            {
                using (connection = new MySqlConnection(con_string))
                using (MySqlCommand write = new MySqlCommand(querry, connection))
                {
                    connection.Open();
                    write.ExecuteNonQuery();
                    connection.Close();
                }
            }
            catch (MySqlException ex)
            {
                Global.mysql_err_msg(ex);

            }
        }
        private void write_log(string verdict, string question)
        {
            string timestamp = DateTime.Now.ToString("yyyy-MM-dd HH:mm:ss");

            MySqlConnection connection = new MySqlConnection();

            string querry;

                querry = "INSERT INTO milionaire.validation_logs (user_id,verdict,executed_on,question_id) values(" + Global.User.id + ", '" + verdict + "', '" + timestamp + "', (SELECT Id from questions where question = '" + question + "') )";


            try
            {
                using (connection = new MySqlConnection(con_string))
                using (MySqlCommand write = new MySqlCommand(querry, connection))
                {
                    connection.Open();
                    write.ExecuteNonQuery();
                    connection.Close();
                }
            }
            catch (MySqlException ex)
            {
                Global.mysql_err_msg(ex);

            }
        }
        string[] values_array = {
            "100 $",
            "200 $",
            "300 $",
            "500 $",
            "1000 $",
            "2000 $",
            "4000 $",
            "8000 $",
            "16 000 $",
            "32 000 $",
            "64 000 $",
            "125 000 $",
            "250 000 $",
            "500 000 $",
            "1 000 000 $"
        };
        private void populate(string table_from)
        {
            questions_datagrid.Rows.Clear();
            questions_datagrid.Refresh();

            //users_datagrid.Rows.Add(id, question, answer, author, topic, price);
            string query = "SELECT q.Id, u.Nickname, q.question, q.correct_ans, t.topic, q.price, q.var_a, q.var_b, q.var_c, q.var_d FROM "+table_from+" q JOIN topics t ON q.topic_id = t.Id JOIN users u ON q.author = u.Id;";

            MySqlDataAdapter adapter = new MySqlDataAdapter(query, con_string);
            adapter.Fill(table);
            
            foreach (DataRow row in table.Rows)
            {
                
                questions_datagrid.Rows.Add(row[0].ToString(), row[1].ToString(), row[2].ToString(), row[3].ToString(), row[4].ToString(), values_array[Convert.ToInt32(row[5])], row[6].ToString(), row[7].ToString(),row[8].ToString(), row[9].ToString());
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

        private int priceString_to_Int(string price)
        {
            switch (price) {
                case "100 $" : return 0;
                case "200 $": return 1;
                case "300 $": return 2;
                case "500 $": return 3;
                case "1000 $": return 4;
                case "2000 $": return 5;
                case "4000 $": return 6;
                case "8000 $": return 7;
                case "16 000 $": return 8;
                case "32 000 $": return 9;
                case "64 000 $": return 10;
                case "125 000 $": return 11;
                case "250 000 $": return 12;
                case "500 000 $": return 13;
                case "1 000 000 $": return 14;
                default: return 0;
            }
        }

        private void verdict_adapter(DataGridViewCellEventArgs e)
        {
            

            switch (e.ColumnIndex.ToString())
            {
                case "10":
                    {

                        try{

                            Global.question_write(
                                "questions",
                                questions_datagrid.Rows[e.RowIndex].Cells[4].Value.ToString(),
                                questions_datagrid.Rows[e.RowIndex].Cells[2].Value.ToString(),
                                questions_datagrid.Rows[e.RowIndex].Cells[6].Value.ToString(),
                                questions_datagrid.Rows[e.RowIndex].Cells[7].Value.ToString(),
                                questions_datagrid.Rows[e.RowIndex].Cells[8].Value.ToString(),
                                questions_datagrid.Rows[e.RowIndex].Cells[9].Value.ToString(),
                                questions_datagrid.Rows[e.RowIndex].Cells[3].Value.ToString(),
                                priceString_to_Int(questions_datagrid.Rows[e.RowIndex].Cells[5].Value.ToString()),
                                questions_datagrid.Rows[e.RowIndex].Cells[1].Value.ToString()
                                );

                            string query = "DELETE FROM `validating_questions` WHERE (`Id`= " + Convert.ToInt32(questions_datagrid.Rows[e.RowIndex].Cells[0].Value) + ")";

                            try
                            {
                                using (connection = new MySqlConnection(con_string))
                                using (MySqlCommand query_print = new MySqlCommand(query, connection))
                                {
                                    connection.Open(); query_print.ExecuteNonQuery(); connection.Close();
                                }
                                
                                write_log("Approved", Convert.ToString(questions_datagrid.Rows[e.RowIndex].Cells[2].Value));
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
                case "11":
                    {
                        MessageBox.Show(questions_datagrid.Rows[e.RowIndex].Cells[8].Value.ToString());
                        string query = "DELETE FROM `validating_questions` WHERE (`Id`= "+ Convert.ToInt32(questions_datagrid.Rows[e.RowIndex].Cells[0].Value) + ")";
                        try
                        {
                            using (connection = new MySqlConnection(con_string))
                            using (MySqlCommand query_print = new MySqlCommand(query, connection))
                            {
                                connection.Open(); query_print.ExecuteNonQuery(); connection.Close();
                            }       
                            write_log(
                                    "Refused",
                                    questions_datagrid.Rows[e.RowIndex].Cells[1].Value.ToString(),
                                    questions_datagrid.Rows[e.RowIndex].Cells[4].Value.ToString(),
                                    questions_datagrid.Rows[e.RowIndex].Cells[2].Value.ToString(),
                                    priceString_to_Int(questions_datagrid.Rows[e.RowIndex].Cells[5].Value.ToString()),
                                    questions_datagrid.Rows[e.RowIndex].Cells[6].Value.ToString(),
                                    questions_datagrid.Rows[e.RowIndex].Cells[7].Value.ToString(),
                                    questions_datagrid.Rows[e.RowIndex].Cells[8].Value.ToString(),
                                    questions_datagrid.Rows[e.RowIndex].Cells[9].Value.ToString(),
                                    questions_datagrid.Rows[e.RowIndex].Cells[3].Value.ToString()
                                   );
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
