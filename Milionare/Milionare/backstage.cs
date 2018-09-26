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
            topic_txt.SelectedIndex = 0;
            question_value_txt.SelectedIndex = 0;
            right_asnwer_txt.SelectedIndex = 0;
            author_txt.Text = Global.Nickname;


        }


        private void back_btn_Click(object sender, EventArgs e)
        {
            first_form f = new first_form();
            this.Hide();
            f.ShowDialog();
        }

        private void add_question_btn_Click(object sender, EventArgs e)
        {
            int question_price = question_value_txt.SelectedIndex;
            string auth_low=author_txt.Text.ToLower();
            if (auth_low.Contains("vladSDSDSDD"))
            {
                MetroFramework.MetroMessageBox.Show(this, "Warrning", "That's mine !", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                
            }
            else if (question_txt.Text.Length<20)
            {
                MetroFramework.MetroMessageBox.Show(this, "Warrning", "Your question seem to dubious to be a true!", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
            else
            {
                Global.question_write( topic_txt.Text, question_txt.Text, A_variant_txt.Text, B_variant_txt.Text, C_variant_txt.Text, D_variant_txt.Text, right_asnwer_txt.Text, question_price);
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
    }
}
