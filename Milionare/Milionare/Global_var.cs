using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using MySql.Data.MySqlClient;
using System.Windows.Forms;
using System.IO;
using System.Drawing;
using System.Text.RegularExpressions;
namespace Milionare
{
    static class Global
    {
        public static int global_int = 0;
        public static int game_id = 0, topic;
        public static bool passed = true;

        //public static string db_connect_prop = "server=localhost; database=milionaire; user=root; password=toor";

        public static string db_connect_prop;// = secured_db_connection.db_connect_prop;
        public static string schema;// = secured_db_connection.db_schema;

        public static int GlobalVar
        {
            get { return global_int; }
            set { global_int = value; }
        }

        public static void topic_write(int s)
        {
            topic = s;
            MySqlConnection connection = new MySqlConnection();
            string con_string = db_connect_prop;
            string timestamp = DateTime.Now.ToString("yyyy-MM-dd HH:mm:ss");
            string q_verify_number = "SELECT COUNT(DISTINCT(price)) FROM questions WHERE topic_id=" + s + "";
            string query = "INSERT INTO games (topic_id,user_id,begin_at) VALUES(" + s + ","+User.id+",'"+timestamp+"')";
            string save_id = "SELECT Id FROM games WHERE begin_at='"+timestamp+"'";
            try
            {
                using (connection = new MySqlConnection(con_string))

                using (MySqlCommand q_ver = new MySqlCommand(q_verify_number, connection))
                {
                    connection.Open();
                    MySqlDataReader qv = q_ver.ExecuteReader(); qv.Read();
                    if (Convert.ToInt32(qv["COUNT(DISTINCT(price))"]) < 15 && topic!=5)
                    {
                        connection.Close();
                        MessageBox.Show("Unfortunately there is no enough questions for this topic , please try another", "Error", MessageBoxButtons.OK, MessageBoxIcon.Asterisk);
                        passed = false;
                    }
                    else passed = true;
                }
                if (passed)
                {
                    using (MySqlCommand write = new MySqlCommand(query, connection))
                    {
                        connection.Open();
                        write.ExecuteNonQuery();
                        connection.Close();
                    }

                    using (MySqlCommand save_id_com = new MySqlCommand(save_id, connection))
                    {
                        connection.Open();
                        MySqlDataReader dr = save_id_com.ExecuteReader(); dr.Read();
                        game_id = Convert.ToInt32(dr["Id"]);
                        connection.Close();
                    }
                }
                
            }
            catch (MySqlException ex)
            {
                mysql_err_msg(ex);

            }

        }
        public static void apply_placeholder(String text,object sender,String regexp,int min_len,int max_len,object btn_to_enable, ErrorProvider err_provider,String err_text)
        {
            try
            {
                TextBox current_txt = ((TextBox)sender);
                apply_placeholder(text, sender);
                if (btn_to_enable != null)
                {
                    if (regexp != null) {
                        if (Regex.IsMatch(current_txt.Text, regexp))
                        {
                            err_provider.Clear();
                            //((Button)btn_to_enable).Enabled = true;
                        }
                        else
                        {
                            err_provider.SetError(current_txt, err_text);
                            ((Button)btn_to_enable).Enabled = false;
                        }
                    }
                    if (min_len!=0 && max_len != 0)
                    {
                        if(current_txt.Text.Length>min_len && current_txt.Text.Length < max_len){
                            err_provider.Clear();
                            //((Button)btn_to_enable).Enabled = true;
                        }
                        else
                        {
                            err_provider.SetError(current_txt, err_text);
                            ((Button)btn_to_enable).Enabled = false;
                        }
                    }
                }
                
            }
            catch (Exception e)
            {
                MessageBox.Show(e.StackTrace.ToString());
            }
        }
        public static void apply_placeholder(String text, object sender)
        {
            try
            {
                TextBox current_txt = ((TextBox)sender);
                if (current_txt.Text == "") { current_txt.Text = text; current_txt.ForeColor = Color.MediumAquamarine; }
            }
            catch (Exception e)
            {
                MessageBox.Show(e.StackTrace.ToString());
            }
        }
        public static void question_ifenough(int s)
        {
           /* MySqlConnection connection = new MySqlConnection();
            string con_string = db_connect_prop;
            string q_verify_number = "SELECT COUNT(*) FROM questions WHERE topic_id=" + s + "";
            using (MySqlCommand q_ver = new MySqlCommand(q_verify_number, connection))
            {
                connection.Open();
                MySqlDataReader qv = q_ver.ExecuteReader(); qv.Read();
                if (Convert.ToInt32(qv["COUNT(*)"]) < 16)
                {
                    connection.Close();
                    MessageBox.Show("Unfortunately there is no enough questions for this topic , please try another", "Error", MessageBoxButtons.OK, MessageBoxIcon.Asterisk);
                }
                else*/
                    topic_write(s);
           // }
        }

        public static void question_write(string table_in, string topic, string question, string variant_A, string variant_B, string variant_C, string variant_D, string right_answer, int question_value)
        {
            MySqlConnection connection = new MySqlConnection();
            string con_string = db_connect_prop;
            string question_insert = @"INSERT INTO "+Global.schema+"."+table_in+" (question,author,price,var_a,var_b,var_c,var_d,correct_ans,topic_id) VALUES('" + question + "', '"+User.id+"', "+question_value+", '" + variant_A + "', '" + variant_B + "', '" + variant_C + "', '" + variant_D + "', '"+right_answer+"', (SELECT Id FROM topics WHERE topic = '" + topic + "' )); ";

            try { 
                using (connection = new MySqlConnection(con_string))
                using (MySqlCommand write = new MySqlCommand(question_insert, connection))
                {
                    connection.Open();
                    write.ExecuteNonQuery();
                    connection.Close();
                }
            }
            catch (MySqlException ex)
            {
                mysql_err_msg(ex);

            }




            /*
            SELECT* FROM topics WHERE Id IN
              (SELECT topic_id FROM games)*/

        }
        public static void question_write(string table_in, string topic, string question, string variant_A, string variant_B, string variant_C, string variant_D, string right_answer, int question_value, string auth_name)
        {
            MySqlConnection connection = new MySqlConnection();
            string con_string = db_connect_prop;
            string question_insert = "INSERT INTO "+Global.schema+"." + table_in + " (question,author,price,var_a,var_b,var_c,var_d,correct_ans,topic_id) VALUES('" + question + "', (SELECT Id FROM users WHERE Nickname = '" + auth_name + "'), " + question_value + ", '" + variant_A + "', '" + variant_B + "', '" + variant_C + "', '" + variant_D + "', '" + right_answer + "', (SELECT Id FROM topics WHERE topic = '" + topic + "' )); ";

            try
            {
                using (connection = new MySqlConnection(con_string))
                using (MySqlCommand write = new MySqlCommand(question_insert, connection))
                {
                    connection.Open();
                    write.ExecuteNonQuery();
                    connection.Close();
                }
            }
            catch (MySqlException ex)
            {
                mysql_err_msg(ex);

            }




        }
        public static void mysql_err_msg(MySqlException ex)
        {
            if (MessageBox.Show("Error number: " + ex.Number.ToString() + " \n Do you want to read more?", "Error", MessageBoxButtons.YesNo, MessageBoxIcon.Asterisk) == DialogResult.Yes)
            {
                System.Diagnostics.Process.Start("https://dev.mysql.com/doc/refman/5.6/en/error-messages-server.html");
                System.Windows.Forms.Clipboard.SetText(ex.Number.ToString());

            }
        }

        //----------------------------------------Users-----------------------------------------------------------------------
        public class User
        {
            public static int wallet,id, score;
            public static string name,nickname,rank,email;
            //public static byte[] avatar;
            public static Image avatar_img;
            //public static  MemoryStream avatar_img = new MemoryStream();
            public User(int ident, string nm, string nk, string rnk,int wall,int scr, string mail, byte[] img)
            {
                id = ident;
                name = nm;
                nickname = nk;
                rank = rnk;
                wallet = wall;
                score = scr;
                email = mail;
                //avatar = img; 
                if (img != null)
                {
                    MemoryStream avatar_stream = new MemoryStream(img);
                    avatar_img = Image.FromStream(avatar_stream);
                }
                else avatar_img = null;
                
            }

        }
        


    }
}
