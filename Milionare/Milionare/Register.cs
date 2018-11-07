using MySql.Data.MySqlClient;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
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
        public Register()
        {
            InitializeComponent();
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
        private string pass_encrypt(string password)
        {
            string hash = "Vl0ad";
            byte[] data = UTF8Encoding.UTF8.GetBytes(password);
            using (MD5CryptoServiceProvider md5 = new MD5CryptoServiceProvider())
            {
                byte[] keys = md5.ComputeHash(UTF8Encoding.UTF8.GetBytes(hash));
                using (TripleDESCryptoServiceProvider tripleDes = new TripleDESCryptoServiceProvider() { Key = keys, Mode = CipherMode.ECB, Padding = PaddingMode.PKCS7 })
                {
                    ICryptoTransform transform = tripleDes.CreateEncryptor();
                    byte[] results = transform.TransformFinalBlock(data, 0, data.Length);
                    password = Convert.ToBase64String(results, 0, results.Length);
                    return password;
                }
            }
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


            if (Regex.IsMatch(mail_txt.Text, pattern))
            {
                errorProvider1.Clear();
                reg_btn.Enabled = true;
            }
            else
            {
                errorProvider1.SetError(this.mail_txt, "Please enter a valid mail");
                reg_btn.Enabled = false;

                return;
            }
        }

        private void name_txt_Leave(object sender, EventArgs e)
        {
            if (name_txt.Text.Length > 2 && name_txt.Text.Length < 10)
            {
                errorProvider1.Clear();
                reg_btn.Enabled = true;
            }
            else
            {
                errorProvider1.SetError(this.name_txt, "Please enter a valid name");
                reg_btn.Enabled = false;

                return;
            }
        }

        private void password_txt_Leave(object sender, EventArgs e)
        {
            if (password_txt.Text.Length > 2 && password_txt.Text.Length < 25)
            {
                errorProvider1.Clear();
                reg_btn.Enabled = true;
            }
            else
            {
                errorProvider1.SetError(this.password_txt, "Please enter a valid password");
                reg_btn.Enabled = false;
                return;
            }
            
        }

        private void username_txt_Leave(object sender, EventArgs e)
        {
            if (username_txt.Text.Length > 2 && username_txt.Text.Length < 25)
            {
                errorProvider1.Clear();
                reg_btn.Enabled = true;
            }
            else
            {
                errorProvider1.SetError(this.username_txt, "Please enter a valid username");
                reg_btn.Enabled = false;
                reg_btn.Cursor = Cursors.No;
                return;
            }
        }

        private void reg_btn_Click(object sender, EventArgs e)
        {
            MySqlConnection connection = new MySqlConnection();
            string con_string = Global.db_connect_prop;
            string query = "INSERT INTO users (`Name`,`Nickname`,`email`,`password`,`wallet`,`rank`) VALUES ('" + name_txt.Text + "','" + username_txt.Text + "','" + mail_txt.Text + "','" + pass_encrypt(username_txt.Text) + "',0,'user')";
            try
            {
                using (connection = new MySqlConnection(con_string))
                using (MySqlCommand write = new MySqlCommand(query, connection))
                {
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
    }
}
