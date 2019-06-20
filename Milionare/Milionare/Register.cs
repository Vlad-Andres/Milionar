using MySql.Data.MySqlClient;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Drawing.Imaging;
using System.IO;
using System.Linq;
using System.Net.Mail;
using System.Security.Cryptography;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Milionare
{
    public partial class Register : Form
    {
        MySqlConnection connection = new MySqlConnection();
        string con_string = Global.db_connect_prop;
        public Register()
        {
            InitializeComponent();
            reg_btn.Enabled = false;
        }

        private void avatar_btn_MouseEnter(object sender, EventArgs e)
        {
            avatar_btn.BackColor = Color.FromArgb(0, 101, 153);
        }

        private void avatar_btn_MouseLeave(object sender, EventArgs e)
        {
            avatar_btn.BackColor = Color.Transparent;
        }

        private void exit_button_Click(object sender, EventArgs e)
        {
            first_form f = new first_form();
            this.Dispose();
            f.ShowDialog();
        }
        public bool IsValid(string emailaddress)
        {
            try
            {
                MailAddress m = new MailAddress(emailaddress);

                return true;
            }
            catch (FormatException)
            {
                return false;
            }
        }
        private void mail_txt_Leave(object sender, EventArgs e)
        {
            
            string pattern = "^([0-9a-zA-Z]([-\\.\\w]*[0-9a-zA-Z])*@([0-9a-zA-Z][-\\w]*[0-9a-zA-Z]\\.)+[a-zA-Z]{2,9})$";
            Global.apply_placeholder("Email", sender,pattern,0,0,reg_btn,errorProvider1,"Please enter a valid email");

            //if (Regex.IsMatch(mail_txt.Text, pattern))
            //{
            //    errorProvider1.Clear();
            //    reg_btn.Enabled = true;
            //}
            //else
            //{
            //    errorProvider1.SetError(this.mail_txt, "Please enter a valid mail");
            //    reg_btn.Enabled = false;

            //    return;
            //}
        }


        private void name_txt_Leave(object sender, EventArgs e)
        {
            Global.apply_placeholder("Name", sender,null,2,15,reg_btn,errorProvider1,"Please enter a valid name");

        }

        private void password_txt_Leave(object sender, EventArgs e)
        {
            if (password_txt.UseSystemPasswordChar == true)
            {
                Global.apply_placeholder("Password", sender, null, 2, 25, reg_btn, errorProvider1, "Password must be between 2 and 25 characters lenght");
            }
            else
                Global.apply_placeholder("Password", sender,null,2,25,reg_btn,errorProvider1,"Please enter a valid password");
            //re_pass_txt_Leave(re_pass_txt,e);

            //if (password_txt.Text.Length > 2 && password_txt.Text.Length < 25)
            //{
            //    errorProvider1.Clear();
            //    reg_btn.Enabled = true;
            //}
            //else
            //{
            //    errorProvider1.SetError(this.password_txt, "Please enter a valid password");
            //    reg_btn.Enabled = false;
            //    return;
            //}
            
        }

        private void username_txt_Leave(object sender, EventArgs e)
        {
            Global.apply_placeholder("Username", sender,null,2,25,reg_btn,errorProvider1,"Please enter a valid username");
            //if (username_txt.Text.Length > 2 && username_txt.Text.Length < 25)
            //{
            //    errorProvider1.Clear();
            //    reg_btn.Enabled = true;
            //}
            //else
            //{
            //    errorProvider1.SetError(this.username_txt, "Please enter a valid username");
            //    reg_btn.Enabled = false;
            //    reg_btn.Cursor = Cursors.No;
            //    return;
            //}
        }

        private void reg_btn_Click(object sender, EventArgs e)
        {

            //validation --
            if (!field_unique_validation(username_txt,"Nickname")) { MessageBox.Show("Username already taken, please choose another"); return; };
            if (!field_unique_validation(mail_txt,"email")) { MessageBox.Show("Email already registered, please choose another"); return; };
            //image to byte  convert --
            byte[] imageBt = null;
            if (img != null)
            {
                MemoryStream memoryStream = new MemoryStream();
                img.Save(memoryStream, ImageFormat.Png);
                imageBt = memoryStream.ToArray();
            } 



            string query = "INSERT INTO users (`Name`,`Nickname`,`email`,`password`,`wallet`,`rank`,`avatar`,`energy`,`login_streak`) VALUES ('" + name_txt.Text + "','" + username_txt.Text + "','" + mail_txt.Text + "',SHA2('" + password_txt.Text + "',224) ,0,'user',@IMG,5,0)";
            try
            {

                using (connection = new MySqlConnection(con_string))
                using (MySqlCommand write = new MySqlCommand(query, connection))
                {
                    write.Parameters.Add(new MySqlParameter("@IMG", imageBt));
                    connection.Open();
                    write.ExecuteNonQuery();
                    connection.Close();
                }
            } catch (MySqlException ex)
            {
                Global.mysql_err_msg(ex);
            }

            this.Hide();
            login l = new login();
            l.ShowDialog();
        }

        private void name_txt_Enter(object sender, EventArgs e)
        {
            name_txt.Text = "";
            name_txt.ForeColor = Color.MediumSpringGreen;
        }

        private void username_txt_Enter(object sender, EventArgs e)
        {
            username_txt.Text = "";
            username_txt.ForeColor = Color.MediumSpringGreen;
        }

        private void mail_txt_Enter(object sender, EventArgs e)
        {
            mail_txt.Text = "";
            mail_txt.ForeColor = Color.MediumSpringGreen;
        }

        private void password_txt_Enter(object sender, EventArgs e)
        {
            password_txt.Text = "";
            password_txt.UseSystemPasswordChar = true;
            password_txt.ForeColor = Color.MediumSpringGreen;
        }

        private void re_pass_txt_Enter(object sender, EventArgs e)
        {
            re_pass_txt.Text = "";
            re_pass_txt.UseSystemPasswordChar = true;
            re_pass_txt.ForeColor = Color.MediumSpringGreen;
        }

        private void re_pass_txt_Leave(object sender, EventArgs e)
        {
            //Global.apply_placeholder("Retype Password", sender);
            //if (re_pass_txt.Text == password_txt.Text && re_pass_txt.Text!="Password")
            //{
            //    errorProvider1.Clear();
            //    reg_btn.Enabled = true;
            //}
            //else
            //{
            //    errorProvider1.SetError(this.re_pass_txt, "Password don't match");
            //    reg_btn.Enabled = false;
            //    return;
            //}
        }
        Image img;
        Image img_Resize(Image image, int w, int h)
        {
            Bitmap bmp = new Bitmap(w, h);
            Graphics graphic = Graphics.FromImage(bmp);
            graphic.DrawImage(image, 0, 0, w, h);
            graphic.Dispose();

            return bmp;
        }
        private void avatar_btn_Click(object sender, EventArgs e)
        {


            string[] exten = { ".PNG", ".JPG" };
            OpenFileDialog ofd = new OpenFileDialog();
            ofd.Filter = "images | *.png; *.jpg";
            if (ofd.ShowDialog() == DialogResult.OK)
            {
                img = Image.FromFile(ofd.FileName);
                img = img_Resize(img, 200, 200);
                reg_avatar_pic.Image = img;
                img = img_Resize(img, 100, 100);
            }
        }
        private bool field_unique_validation(object sender,string field_name)
        {
            string query = "SELECT COUNT(*) FROM users WHERE `"+field_name+"`='"+ ((TextBox)sender).Text + "'";
            try
            {
                using (connection = new MySqlConnection(con_string))
                using (MySqlCommand count = new MySqlCommand(query, connection))
                {
                    connection.Open();
                    MySqlDataReader dr = count.ExecuteReader(); dr.Read();
                    if (dr["COUNT(*)"].ToString() == "0")
                    {
                        connection.Close();  return true;
                    }
                    else return false;
                }
            }
            catch (MySqlException ex)
            {
                Global.mysql_err_msg(ex);
                return false;
            }
        }

        private void re_pass_txt_MouseLeave(object sender, EventArgs e)
        {
            Global.apply_placeholder("Retype Password", sender);
            if (re_pass_txt.Text == password_txt.Text && re_pass_txt.Text != "Password")
            {
                errorProvider1.Clear();
                reg_btn.Enabled = true;
            }
            else
            {
                errorProvider1.SetError(this.re_pass_txt, "Password don't match");
                reg_btn.Enabled = false;
                return;
            }
        }

        private void reg_btn_MouseHover(object sender, EventArgs e)
        {
            //Global.apply_placeholder("Retype Password", sender);
            //if (re_pass_txt.Text == password_txt.Text && re_pass_txt.Text != "Password")
            //{
            //    errorProvider1.Clear();
            //    reg_btn.Enabled = true;
            //}
            //else
            //{
            //    errorProvider1.SetError(this.re_pass_txt, "Password don't match");
            //    reg_btn.Enabled = false;
            //    return;
            //}
        }
    }
}
