using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Threading;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using MySql.Data.MySqlClient;

// https://www.youtube.com/watch?v=pd-S6UoQHh8
namespace Milionare
{

    public partial class main_form : Form
    {
        Label[] labels_nr = new Label[15];
        Label[] labels_txt = new Label[15];
        //------------------side panel-----------------
        public void side_panel_change(bool opened)
        {
            if (opened)
            {
                side_panel.Width = 220;
                side_panel_gradient.Width = 220;
                panel_off_lbl.Visible = false;
            }
            else
            {
                side_panel.Width = 28;
                side_panel_gradient.Width = 28;
                panel_off_lbl.Visible = true;
            }
        }
        public void side_labels(string[] s)
        {
            int loc = 577;



            for (int i = 0; i < 15; i++)
            {
                labels_nr[i] = new Label();
                labels_txt[i] = new Label();
            }
            for (int i = 0; i < 15; i++)
            {
                labels_nr[i].Top = loc;
                labels_txt[i].Top = loc;
                loc -= 40;
                labels_nr[i].Left = 30;
                labels_txt[i].Left = 65;
                labels_nr[i].Text = (i + 1).ToString();
                labels_nr[i].Width = 35;
                labels_nr[i].BackColor = Color.Transparent;
                labels_txt[i].Text = s[i];
                labels_txt[i].BackColor = Color.Transparent;
                //Colors - fonts 
                labels_txt[i].Font = new Font("Century Gothic", 14, FontStyle.Bold);
                labels_txt[i].ForeColor = Color.FromArgb(255, 175, 171, 153);
                labels_nr[i].Font = new Font("Century Gothic", 14, FontStyle.Bold);
                labels_nr[i].ForeColor = Color.FromArgb(255, 175, 171, 153);

                side_panel_gradient.Controls.Add(labels_nr[i]);
                side_panel_gradient.Controls.Add(labels_txt[i]);

                panel_off_lbl.Width = 28;
                panel_off_lbl.Left = 0;
                panel_off_lbl.Text = "       ";
                panel_off_lbl.BackColor = Color.FromArgb(255, 175, 171, 153);
                panel_off_lbl.Top = 617;

            }
        }
        int side_panel_level = 0, panel_off_colorG = 171, panel_off_colorB = 153;
        public void side_panel_move()
        {
            if (side_panel_level < 15)
            {
                labels_txt[side_panel_level].ForeColor = Color.FromArgb(255, 234, 203, 63);
                labels_nr[side_panel_level].ForeColor = Color.FromArgb(255, 234, 203, 63);
                panel_off_lbl.Top -= 40;
                panel_off_lbl.BackColor = Color.FromArgb(255, 234, panel_off_colorG += 5, panel_off_colorB -= 10);
                if (side_panel_level > 0)
                {
                    labels_txt[side_panel_level - 1].ForeColor = Color.Green;
                    labels_nr[side_panel_level - 1].ForeColor = Color.Green;
                }
                side_panel_level++;
            }

        }
        //--------------------------------------
        public class Question
        {
            public string question_text, variant_a_text, variant_b_text, variant_c_text, variant_d_text, answer;
            public int question_id,q_price;
            public Question(int quest_id, string quest_txt, string var_a, string var_b, string var_c, string var_d,  string answ, int prc )
            {
                question_id = quest_id;
                question_text = quest_txt;
                answer = answ;
                variant_a_text = var_a;
                variant_b_text = var_b;
                variant_c_text = var_c;
                variant_d_text = var_d;
                q_price = prc;
            }
        }
        
        List<Question> questions_list = new List<Question>();
        
        /*SqlConnection connection;*/
        string[] sums = new string[] {"100 $","200 $","300 $","500 $","1 000 $","2 000 $","4 000 $","8 000 $",
            "16 000 $","32 000 $","64 000 $","125 000 $","250 000 $","500 000 $","1 Milion"};

        string con_string = Global.db_connect_prop;
        // funtia cu adaugare informatie din db--------------------------------------------------------------------
        private void fill_quest_list()
        {
            try { 
            MySqlConnection connection = new MySqlConnection();
            DataTable table = new DataTable();
            string select_querry = "SELECT Id, question, var_a, var_b, var_c, var_d, correct_ans, price FROM milionaire.questions; ";
            MySqlDataAdapter adapter = new MySqlDataAdapter(select_querry, con_string);
            adapter.Fill(table);
            foreach (DataRow row in table.Rows)
            {
                Question q = new Question(Convert.ToInt32(row[0]), row[1].ToString(), row[2].ToString(), row[3].ToString(), row[4].ToString(), row[5].ToString(), row[6].ToString(), Convert.ToInt32(row[7]));
                questions_list.Add(q);
                connection.Close();
            }
            }catch (MySqlException e)
            {
              Global.mysql_err_msg(e);
            }


        }
        List<int> price_equal = new List<int>();
        int current_id;
        private void populate_main(int price)
        {

           // Cursor.Position = new Point(author_img.Location.X, author_img.Location.Y);
            price_equal.Clear();
            validating = false;
            A_btn.BackgroundImage = null; A_btn.Visible = true;
            B_btn.BackgroundImage = null; B_btn.Visible = true;
            C_btn.BackgroundImage = null; C_btn.Visible = true;
            D_btn.BackgroundImage = null; D_btn.Visible = true;
            for (int i=0; i<questions_list.Count; i++)
            {
                if (questions_list[i].q_price == price) { price_equal.Add(i);}
            }
            Random random = new Random();
            current_id = random.Next(0,price_equal.Count);

            label1.Text = questions_list[price_equal[current_id]].question_text;
            A_btn.Text = questions_list[price_equal[current_id]].variant_a_text;
            B_btn.Text = questions_list[price_equal[current_id]].variant_b_text;
            C_btn.Text = questions_list[price_equal[current_id]].variant_c_text;
            D_btn.Text = questions_list[price_equal[current_id]].variant_d_text;
            
        }
        //---------------------------------------------------------------------------------------------- Cazuri de castig si pierdere
        private void result(int id)
        {
            validation_timer.Stop();
            MySqlConnection connection = new MySqlConnection();
            string con_string = Global.db_connect_prop;
            
            //UPDATE `milionaire`.`users` SET `wallet`= '1000' WHERE `Id`= '2';
            

            if (id >= 5 && id < 10)
            { 
                Global.wallet += 1000;
                if (MetroFramework.MetroMessageBox.Show(this, "Results", "You earned 1 thousand dollars", MessageBoxButtons.RetryCancel, MessageBoxIcon.Information) == DialogResult.Retry)
                {
                    if (Global.Nickname != "undef") { 
                        string query = "UPDATE users SET wallet=" + Global.wallet + " WHERE Nickname='" + Global.Nickname + "' ";
                        using (connection = new MySqlConnection(con_string))
                        using (MySqlCommand write = new MySqlCommand(query, connection))
                        {  connection.Open(); write.ExecuteNonQuery(); connection.Close(); }
                    }
                    first_form f = new first_form();
                    this.Dispose();
                    f.ShowDialog();
                }
                else {
                    if (Global.Nickname != "undef")
                    {
                        string query = "UPDATE users SET wallet=" + Global.wallet + " WHERE Nickname='" + Global.Nickname + "' ";
                        using (connection = new MySqlConnection(con_string))
                        using (MySqlCommand write = new MySqlCommand(query, connection))
                        { connection.Open(); write.ExecuteNonQuery(); connection.Close(); }
                    }
                    Application.Exit(); }
            }
            else if (id >= 10 && id < 15)
            {
                Global.wallet += 32000;
                if (MetroFramework.MetroMessageBox.Show(this, "Results", "You earned 32 thousands dollars", MessageBoxButtons.RetryCancel, MessageBoxIcon.Information) == DialogResult.Retry)
                {
                    if (Global.Nickname != "undef")
                    {
                        string query = "UPDATE users SET wallet=" + Global.wallet + " WHERE Nickname='" + Global.Nickname + "' ";
                        using (connection = new MySqlConnection(con_string))
                        using (MySqlCommand write = new MySqlCommand(query, connection))
                        { connection.Open(); write.ExecuteNonQuery(); connection.Close(); }
                    }
                    first_form f = new first_form();
                    this.Dispose();
                    f.ShowDialog();
                }
                else {
                    if (Global.Nickname != "undef")
                    {
                        string query = "UPDATE users SET wallet=" + Global.wallet + " WHERE Nickname='" + Global.Nickname + "' ";
                        using (connection = new MySqlConnection(con_string))
                        using (MySqlCommand write = new MySqlCommand(query, connection))
                        { connection.Open(); write.ExecuteNonQuery(); connection.Close(); }
                    }
                    Application.Exit(); }
            }
            else if (id == 15)
            {
                Global.wallet += 1000000;

                if (MetroFramework.MetroMessageBox.Show(this, "Congratulations", "You won 1 million dollars", MessageBoxButtons.RetryCancel, MessageBoxIcon.Information) == DialogResult.Retry)
                {
                    if (Global.Nickname != "undef")
                    {
                        string query = "UPDATE users SET wallet=" + Global.wallet + " WHERE Nickname='" + Global.Nickname + "' ";
                        using (connection = new MySqlConnection(con_string))
                        using (MySqlCommand write = new MySqlCommand(query, connection))
                        { connection.Open(); write.ExecuteNonQuery(); connection.Close(); }
                    }
                    first_form f = new first_form();
                    this.Dispose();
                    f.ShowDialog();
                }
                else {
                    if (Global.Nickname != "undef")
                    {
                        string query = "UPDATE users SET wallet=" + Global.wallet + " WHERE Nickname='" + Global.Nickname + "' ";
                        using (connection = new MySqlConnection(con_string))
                        using (MySqlCommand write = new MySqlCommand(query, connection))
                        { connection.Open(); write.ExecuteNonQuery(); connection.Close(); }
                    }
                    Application.Exit(); }
            }
            else if (id < 5)
            {
                if (MetroFramework.MetroMessageBox.Show(this, "Results", "You didn't earned anything :(", MessageBoxButtons.RetryCancel, MessageBoxIcon.Error) == DialogResult.Retry)
                {
                    first_form f = new first_form();
                    this.Dispose();
                    f.ShowDialog();
                }
                else { Application.Exit(); }
            }

        }
        private void btn_click_verify(object sender, EventArgs e, string letter)
        {
            //cast de cautat
            // A_btn.BackColor = Color.Yellow;
            ((Button)sender).BackgroundImage = Image.FromFile("resources/variants_btns/" + letter + "_yellow.png");
            if (questions_list[price_equal[current_id]].answer == letter)
            {
                Thread.Sleep(2000);
                validating = true;
                ((Button)sender).BackgroundImage = Image.FromFile("resources/variants_btns/" + letter + "_green.png");
                if_correct = true;
            }
            else
            {
                ((Button)sender).BackgroundImage = Image.FromFile("resources/variants_btns/" + letter + "_red.png");
                if_correct = false;
            }
            validation_timer.Start();
        }
        private bool if_correct;
        //-----------------------------------------------------------------------------------------------

        //-----------------------------------------------------------------------------------------------
        public main_form()
        {

            

            InitializeComponent();
            // cand se incepe intrebarea

            question_timer.Start();
            side_labels(sums);
            side_panel_change(false);
            fill_quest_list();
            

            populate_main(0);
            side_panel_move();


        }


        //Butoaneel -------------------------------------------------------------------------------------
        
        int validate, id = 1, price = 0;
        bool validating = false;
        private void A_btn_Click(object sender, EventArgs e)
        {
            btn_click_verify(sender, e, "A");
        }
        private void B_btn_Click(object sender, EventArgs e)
        {
            btn_click_verify(sender, e, "B");

        }
        private void C_btn_Click(object sender, EventArgs e)
        {
            btn_click_verify(sender, e, "C");
        }
        private void D_btn_Click(object sender, EventArgs e)
        {
            btn_click_verify(sender, e, "D");

        }
        //-----------------------------------------------------------------------------------------------
        //Timere
        private void question_timer_Tick(object sender, EventArgs e)
        {

            if (question_timebar.Value == 0)
            {
                question_timer.Stop(); //caz cand timerul a expirat 

                result(id);
            }
            else
            if (question_timebar.Value == 10) { question_timebar.ProgressColor = Color.Red;  }
            if (id == 16)
            {
                question_timer.Stop(); //caz de castig 
            }
            question_timebar.Value--;
            quetion_timer_lbl.Text = question_timebar.Value.ToString();



        }
        
        private void validation_timer_Tick(object sender, EventArgs e)
        {

            validation_timer.Stop();
            if (if_correct)
            {
                if (id == 15)
                {
                    question_timer.Stop();
                    result(15);
                }
                id++; lvl_change();
                question_timebar.Value = 60;
            }
            else
            {
                result(id);
                question_timer.Stop();
            }
            
        }
        public void lvl_change()
        {
            validating = false;
            if (price < 14) {
                price++;
                populate_main(price);
            }
            side_panel_move();
        }
        //-----------------------------------------------------------------------------------------------
        /*
         * 
         * 100  -1
         * 200 -2
         * 300 -3
         * 500 -4
         * 1000 -5
         * 2000 -6
         * 4000 -7
         * 8000 -8
         * 16 000 -9
         * 32 000 -10
         * 64 000 -11
         * 125 000 -12
         * 250 000 -13
         * 500 000 -14
         * 1 000 000 -15
         */

        private void main_form_Load(object sender, EventArgs e)
        {
            this.Left = (Screen.PrimaryScreen.WorkingArea.Width - this.Width) / 2;
            this.Top = (Screen.PrimaryScreen.WorkingArea.Height - this.Height) / 2;
        }


        private void circle_btn_slide_Click(object sender, EventArgs e)
        {
            side_panel_change(true);
        }

        private void button1_Click(object sender, EventArgs e)
        {
            side_panel_change(false);

        }


        private void circle_btn_leave_Click(object sender, EventArgs e)
        {
            string query = "UPDATE games SET canceled = 'YES' WHERE Id = "+Global.game_id;
            MySqlConnection connetion = new MySqlConnection();
            using (connetion = new MySqlConnection(con_string))
            using (MySqlCommand write = new MySqlCommand(query, connetion))
            {
                connetion.Open();
                write.ExecuteNonQuery();
                
            }
            first_form f = new first_form();
            this.Hide();
            f.ShowDialog();
            // Database -> Delete session row
        }

         bool clicked=false;
        
        //------------------------------------Buttons--------------------------------------------------------------------------
        private void circle_btn_half_Click(object sender, EventArgs e)
        {
            if (!clicked)
            { 
                Random r = new Random();
                int r1 = r.Next(1, 3);
                switch (r1)
                {
                    case 1:{ if (questions_list[price_equal[current_id]].answer != "A") { A_btn.Visible = false; } else B_btn.Visible = false; break; }
                    case 2:{ if (questions_list[price_equal[current_id]].answer != "B") { B_btn.Visible = false; } else A_btn.Visible = false; break; }
                }
                int r2 = r.Next(3, 5);
                switch (r2)
                {
                    case 3: { if (questions_list[price_equal[current_id]].answer != "C") { C_btn.Visible = false; } else D_btn.Visible = false; break; }
                    case 4: { if (questions_list[price_equal[current_id]].answer != "D") { D_btn.Visible = false; } else C_btn.Visible = false; break; }
                }
                circle_btn_half.BackgroundImage = Image.FromFile("resources/circle_btns_hover/half_option.png");
                // circle_btn_half.Enabled = false;
                clicked = true;
                circle_btn_half.BackgroundImageLayout = ImageLayout.Stretch;
            }

        }
        private void circle_btn_call_Click(object sender, EventArgs e)
        {

        }

        private void circle_btn_public_Click(object sender, EventArgs e)
        {

        }
        //------------------------------------Buttons--------------------------------------------------------------------------
        //circle buttnos hover -----------------------------------------------------------------------


        private void circle_btn_slide_MouseEnter(object sender, EventArgs e)
        {
            circle_btn_slide.BackgroundImage = Image.FromFile("resources/circle_btns_hover/circle_slide_hover.png");
            circle_btn_slide.BackgroundImageLayout = ImageLayout.Stretch;
        }

        private void circle_btn_slide_MouseLeave(object sender, EventArgs e)
        {
            circle_btn_slide.BackgroundImage = null;
        }

        private void circle_btn_leave_MouseEnter(object sender, EventArgs e)
        {
            circle_btn_leave.BackgroundImage = Image.FromFile("resources/circle_btns_hover/circle_exit_hover.png");
            circle_btn_leave.BackgroundImageLayout = ImageLayout.Stretch;
        }

        private void circle_btn_leave_MouseLeave(object sender, EventArgs e)
        {
            circle_btn_leave.BackgroundImage = null;
        }
        
        private void circle_btn_half_MouseEnter(object sender, EventArgs e)
        {
            if (!clicked)
            { 
                circle_btn_half.BackgroundImage = Image.FromFile("resources/circle_btns_hover/circle_half_hover.png");
                circle_btn_half.BackgroundImageLayout = ImageLayout.Stretch;
            }
        }

        private void circle_btn_half_MouseLeave(object sender, EventArgs e)
        {
            if (!clicked)
            {
                circle_btn_half.BackgroundImage = null;
            }
        }

        private void label1_TextChanged(object sender, EventArgs e)
        {
            int x = 26;
            if (label1.Text.Length > 45) { label1.Font = new Font("Microsoft Sans Serif", x, FontStyle.Bold); x -= 3; }

        }

        private void circle_btn_call_MouseEnter(object sender, EventArgs e)
        {
            circle_btn_call.BackgroundImage = Image.FromFile("resources/circle_btns_hover/circle_call_hover.png");
            circle_btn_call.BackgroundImageLayout = ImageLayout.Stretch;
        }

        private void circle_btn_call_MouseLeave(object sender, EventArgs e)
        {
            circle_btn_call.BackgroundImage = null;
        }


        private void circle_btn_public_MouseEnter(object sender, EventArgs e)
        {
            circle_btn_public.BackgroundImage = Image.FromFile("resources/circle_btns_hover/circle_public_hover.png");
            circle_btn_public.BackgroundImageLayout = ImageLayout.Stretch;
        }

        private void circle_btn_public_MouseLeave(object sender, EventArgs e)
        {
            circle_btn_public.BackgroundImage = null;
        }
        //-------------------------------------
        private void A_btn_MouseEnter(object sender, EventArgs e)
        {
            A_btn.BackgroundImage = Image.FromFile("resources/variants_btns/A_grey.png");
        }

        private void A_btn_MouseLeave(object sender, EventArgs e)
        {
            if (!validating)
            {
                A_btn.BackgroundImage = null;
                A_btn.BackColor = Color.Transparent;
            }
        }

        private void B_btn_MouseEnter(object sender, EventArgs e)
        {
            B_btn.BackgroundImage = Image.FromFile("resources/variants_btns/B_grey.png");
        }

        private void B_btn_MouseLeave(object sender, EventArgs e)
        {
            if (!validating)
            {
                B_btn.BackgroundImage = null;
                B_btn.BackColor = Color.Transparent;
            }
        }

        private void C_btn_MouseEnter(object sender, EventArgs e)
        {
            C_btn.BackgroundImage = Image.FromFile("resources/variants_btns/C_grey.png");
        }

        private void C_btn_MouseLeave(object sender, EventArgs e)
        {
            if (!validating)
            {
                C_btn.BackgroundImage = null;
                C_btn.BackColor = Color.Transparent;
            }
        }



        private void D_btn_MouseEnter(object sender, EventArgs e)
        {
            D_btn.BackgroundImage = Image.FromFile("resources/variants_btns/D_grey.png");
        }

        private void D_btn_MouseLeave(object sender, EventArgs e)
        {
            if (!validating)
            {
                D_btn.BackgroundImage = null;
                D_btn.BackColor = Color.Transparent;
            }
        }
        private void side_panel_gradient_Paint(object sender, PaintEventArgs e)
        {
            
        }



        private void side_panel_Paint(object sender, PaintEventArgs e)
        {
         
        }


    }
}
/*
private void LogLastButton(Button button)
{
   Session["LastButtonId"] = button.ID;
}

protected void ButtonView_Click(object sender, EventArgs e)
{
   this.LogLastButton((Button)sender);
}

protected void ButtonViewDayWise_Click(object sender, EventArgs e)
{
   this.LogLastButton((Button)sender);
}
Button lastButton = Page.Controls.Find(Session["LastButtonId"].ToString());
*/
