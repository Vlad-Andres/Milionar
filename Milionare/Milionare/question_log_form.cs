using MySql.Data.MySqlClient;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Milionare
{
    public partial class question_log_form : Form
    {
        MySqlConnection connection = new MySqlConnection();
        string con_string = Global.db_connect_prop;
        DataTable table = new DataTable();

        //If refused
        string topic, a, b, c, d,correct,text;

        bool isApproved;

        int question_id;
        string author;
        public question_log_form(int question_id, string author)
        {
            
            InitializeComponent();
            isApproved = true;
            this.question_id = question_id;
            this.author = author;
            
        }
        public question_log_form(string text,string author, string topic, string a,string b,string c,string d,string correct)
        {
            InitializeComponent();
            isApproved = false;
            MessageBox.Show(text);
            this.text = text;
            this.author = author;
            this.topic = topic;
            this.a = a;
            this.b = b;
            this.c = c;
            this.d = d;
            this.correct = correct;

        }

        private void show_question()
        {
            try
            {
                MySqlConnection connection = new MySqlConnection();
                DataTable table = new DataTable();

                // MessageBox.Show(Global.topic.ToString());
                string select_querry = "SELECT question, var_a, var_b,var_c,var_d,correct_ans,(SELECT topic FROM topics WHERE Id=topic_id ) FROM questions WHERE Id ="+question_id+"";
                MySqlDataAdapter adapter = new MySqlDataAdapter(select_querry, con_string);
                adapter.Fill(table);

                

                foreach (DataRow row in table.Rows)
                {
                    this.text = row[0].ToString();
                    this.a = row[1].ToString();
                    this.b = row[2].ToString();
                    this.c = row[3].ToString();
                    this.d = row[4].ToString();
                    this.correct = row[5].ToString();
                    this.topic = row[6].ToString();
                    connection.Close();
                }
            }
            catch (MySqlException e)
            {
                Global.mysql_err_msg(e);
            }
        }


        private void save_btn_Click(object sender, EventArgs e)
        {
            update_question(question_id, question_lbl.Text, topic_cmb.Text, var_A_lbl.Text, var_B_lbl.Text, var_C_lbl.Text, var_D_lbl.Text);
        }

        private void exit_btn_Click(object sender, EventArgs e)
        {
            this.Dispose();
        }

        private void question_log_form_Load(object sender, EventArgs e)
        {
            if (isApproved)
            {
                show_question();
            }
            else
            {
                delete_btn.Visible = false;
                delete_btn.Enabled = false;
                save_btn.Enabled = false;
                save_btn.Visible = false;
            }

                author_lbl.Text=author;
                topic_cmb.Text = topic;
                question_lbl.Text = text;
                var_A_lbl.Text = a;
                var_B_lbl.Text = b;
                var_C_lbl.Text = c;
                var_D_lbl.Text = d;
                
            
        }
        private void update_question(int id, string question, string topic, string var_a, string var_b,string var_c,string var_d)
        {
            string query = "UPDATE questions SET question = '"+question+"',topic=(SELECT Id from topics WHERE topic='"+topic+"'),var_a='"+var_a+ "',var_b='" + var_b + "',var_c='" + var_c + "',var_d='" + var_d + "' WHERE Id = "+id+"";
            MySqlConnection connetion = new MySqlConnection();
            using (connetion = new MySqlConnection(con_string))
            using (MySqlCommand write = new MySqlCommand(query, connetion))
            {
                connetion.Open();
                write.ExecuteNonQuery();
                connection.Close();

            }
        }
    }
}
