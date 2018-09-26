using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using MySql.Data.MySqlClient;
using System.Windows.Forms;

namespace Milionare
{
    static class Global
    {
        public static int global_int = 0;
        public static int game_id = 0, topic;
        public static bool passed = true;
        public static string db_connect_prop = "server=localhost; database=milionaire; user=root; password=toor";

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
            string q_verify_number = "SELECT COUNT(*) FROM questions WHERE topic_id=" + s + "";
            string query = "INSERT INTO games (topic_id,user_id,begin_at) VALUES(" + s + ",(SELECT Id From users WHERE Nickname = '" + Nickname + "'),'"+timestamp+"')";
            string save_id = "SELECT Id FROM games WHERE begin_at='"+timestamp+"'";
            try
            {
                using (connection = new MySqlConnection(con_string))

                using (MySqlCommand q_ver = new MySqlCommand(q_verify_number, connection))
                {
                    connection.Open();
                    MySqlDataReader qv = q_ver.ExecuteReader(); qv.Read();
                    if (Convert.ToInt32(qv["COUNT(*)"]) < 16)
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
                if (MessageBox.Show("Error number: " + ex.Number.ToString() + " \n Do you want to read more?", "Error", MessageBoxButtons.YesNo, MessageBoxIcon.Asterisk) == DialogResult.Yes)
                {
                    System.Diagnostics.Process.Start("https://dev.mysql.com/doc/refman/5.6/en/error-messages-server.html");
                    System.Windows.Forms.Clipboard.SetText(ex.Number.ToString());
                    
                }

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

        public static void question_write( string topic, string question, string variant_A, string variant_B, string variant_C, string variant_D, string right_answer, int question_value)
        {
            MySqlConnection connection = new MySqlConnection();
            string con_string = db_connect_prop;

            string write_in_questions = "INSERT INTO questions (question,author,price) VALUES('" + question + "','" + Nickname + "'," + question_value + ")";
            string write_answer_A = "INSERT INTO answers(answer,letter,question_id) values ('" + variant_A + "','A',(SELECT Id FROM questions WHERE question='" + question + "'))";
            string write_answer_B = "INSERT INTO answers(answer,letter,question_id) values ('" + variant_B + "','B',(SELECT Id FROM questions WHERE question='" + question + "'))";
            string write_answer_C = "INSERT INTO answers(answer,letter,question_id) values ('" + variant_C + "','C',(SELECT Id FROM questions WHERE question='" + question + "'))";
            string write_answer_D = "INSERT INTO answers(answer,letter,question_id) values ('" + variant_D + "','D',(SELECT Id FROM questions WHERE question='" + question + "'))";

            string right_answer_write = "UPDATE questions SET answer_id = (SELECT Id FROM answers WHERE letter = '" + right_answer + "' AND question_id = questions.Id )  WHERE question='" + question + "';";
            string topic_write = "UPDATE questions SET topic_id = (SELECT Id FROM topics WHERE topic = '" + topic + "' )  WHERE question='" + question + "';";
            //(SELECT Id FROM answers WHERE letter = '"+ right_answer + "')

            try { 
                using (connection = new MySqlConnection(con_string))
                using (MySqlCommand write = new MySqlCommand(write_in_questions, connection))
                using (MySqlCommand write_A = new MySqlCommand(write_answer_A, connection))
                using (MySqlCommand write_B = new MySqlCommand(write_answer_B, connection))
                using (MySqlCommand write_C = new MySqlCommand(write_answer_C, connection))
                using (MySqlCommand write_D = new MySqlCommand(write_answer_D, connection))


                using (MySqlCommand write_ans = new MySqlCommand(right_answer_write, connection))

                using (MySqlCommand write_topic = new MySqlCommand(topic_write, connection))
                {
                    connection.Open();
                    write.ExecuteNonQuery();
                    write_A.ExecuteNonQuery();
                    write_B.ExecuteNonQuery();
                    write_C.ExecuteNonQuery();
                    write_D.ExecuteNonQuery();
                    write_ans.ExecuteNonQuery();
                    write_topic.ExecuteNonQuery();
                    connection.Close();
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




            /*
            SELECT* FROM topics WHERE Id IN
              (SELECT topic_id FROM games)*/

        }

        //----------------------------------------Users-----------------------------------------------------------------------
        public static string Nickname="undef", rank, name;
        public static int wallet;

    }
}
