using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Milionare
{
    public partial class backstage : Form
    {
        public backstage()
        {

            InitializeComponent();
            if (Global.User.rank == "moder" || Global.User.rank == "admin") { add_valid_btn.Visible = true; add_valid_btn.Enabled = true; }
            topic_txt.SelectedIndex = 0;
            question_value_txt.SelectedIndex = 0;
            right_asnwer_txt.SelectedIndex = 0;
            author_txt.Text = Global.User.nickname;
            
            
            
            
            
            topic_txt.DropDownStyle = ComboBoxStyle.DropDownList;
            right_asnwer_txt.DropDownStyle = ComboBoxStyle.DropDownList;
            question_value_txt.DropDownStyle = ComboBoxStyle.DropDownList;
        }


        private void back_btn_Click(object sender, EventArgs e)
        {
            if (Global.User.rank == "admin" || Global.User.rank == "moder")
            {
                Admin_panel f = new Admin_panel();
                this.Hide();
                f.ShowDialog();
            }
            else
            {
                first_form f = new first_form();
                this.Hide();
                f.ShowDialog();
            }
            
        }

        private void add_question_btn_Click(object sender, EventArgs e)
        {
            int question_price = question_value_txt.SelectedIndex;
            string auth_low=author_txt.Text.ToLower();
            if (auth_low.Contains("flymengo"))
            {
                MetroFramework.MetroMessageBox.Show(this, "Warrning", "That's mine !", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                
            }
            else if (question_txt.Text.Length<20)
            {
                MetroFramework.MetroMessageBox.Show(this, "Warrning", "Your question seem to dubious to be a true!", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
            else
            {
                Global.question_write("validating_questions", topic_txt.Text, question_txt.Text, A_variant_txt.Text, B_variant_txt.Text, C_variant_txt.Text, D_variant_txt.Text, right_asnwer_txt.Text, question_price);
            }
            green_dot.Visible = true;
            dot_timer.Enabled = true;
                
        }

        private void backstage_Load(object sender, EventArgs e)
        {

        }

        private void dot_timer_Tick(object sender, EventArgs e)
        {
            green_dot.Visible = false;
        }

        private void add_valid_btn_Click(object sender, EventArgs e)
        {
            int question_price = question_value_txt.SelectedIndex;
            string auth_low = author_txt.Text.ToLower();
            if (auth_low.Contains("vladSDSDSDD"))
            {
                MetroFramework.MetroMessageBox.Show(this, "Warrning", "That's mine !", MessageBoxButtons.OK, MessageBoxIcon.Warning);

            }
            else if (question_txt.Text.Length < 20)
            {
                MetroFramework.MetroMessageBox.Show(this, "Warrning", "Your question seem to dubious to be a true!", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
            else
            {
                Global.question_write("questions", topic_txt.Text, question_txt.Text, A_variant_txt.Text, B_variant_txt.Text, C_variant_txt.Text, D_variant_txt.Text, right_asnwer_txt.Text, question_price);
            }
            green_dot.Visible = true;
            dot_timer.Enabled = true;
        }
    }
}
