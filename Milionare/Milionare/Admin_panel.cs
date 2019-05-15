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
    public partial class Admin_panel : Form
    {
        public Admin_panel()
        {
            InitializeComponent();
            admin_name.Text = Global.User.name;


        }
        void select(object sender)
        {
            users_btn.selected = false;
            quest_btn.selected = false;
            quest_add_btn.selected = false;
            validating_btn.selected = false;
         //   text2_btn.selected = false;
            ((Bunifu.Framework.UI.BunifuFlatButton)sender).selected = true;
        }

        private void users_btn_MouseClick(object sender, MouseEventArgs e)
        {

        }

        private void pictureBox2_Click(object sender, EventArgs e)
        {
            first_form f = new first_form();
            this.Hide();
            f.ShowDialog();
        }

        private void quest_btn_Click(object sender, EventArgs e)
        {
            makeTabVisible("questions");
        }

        private void users_btn_Click(object sender, EventArgs e)
        {
            makeTabVisible("users");
        }

        private void quest_add_btn_Click(object sender, EventArgs e)
        {
            makeTabVisible("add_question");
        }

        private void validating_btn_Click(object sender, EventArgs e)
        {
            makeTabVisible("validating");
        }
        private void makeTabVisible(string tab)
        {
            switch (tab){
                case "users":
                    {
                        users_tab.Visible = true;
                        questions_tab.Visible = false;
                        pedingQuestions_tab.Visible = false;
                        break;
                    }
                case "questions":
                    {
                        users_tab.Visible = false;
                        questions_tab.Visible = true;
                        pedingQuestions_tab.Visible = false;
                        break;
                    }
                case "validating":
                    {
                        users_tab.Visible = false;
                        questions_tab.Visible = false;
                        pedingQuestions_tab.Visible = true;
                        break;
                    }
                case "add_question":
                    {
                        backstage f = new backstage();
                        this.Hide();
                        f.ShowDialog();
                        break;
                    }
                default: break;
            }
        }
    }

}
