using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Net.Mail;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using MaterialSkin;
using MaterialSkin.Controls;
using System.Text.RegularExpressions;
using MySql.Data.MySqlClient;
using System.Security.Cryptography;

namespace Milionare
{
    public partial class register_old : MaterialSkin.Controls.MaterialForm
    {
        public register_old()
        {
            InitializeComponent();
            reg_btn.Enabled = false;
            MaterialSkin.MaterialSkinManager skinManager = MaterialSkin.MaterialSkinManager.Instance;
            skinManager.AddFormToManage(this);
            skinManager.Theme = MaterialSkin.MaterialSkinManager.Themes.DARK;
            skinManager.ColorScheme = new MaterialSkin.ColorScheme(MaterialSkin.Primary.Blue900, MaterialSkin.Primary.BlueGrey900, MaterialSkin.Primary.BlueGrey500, MaterialSkin.Accent.Orange700, MaterialSkin.TextShade.WHITE);
            this.MaximizeBox = false;
           
            
        }
        private string pass_encrypt(string password)
        {
            string hash = "Vl0ad";
            byte[] data = UTF8Encoding.UTF8.GetBytes(password);
            using(MD5CryptoServiceProvider md5=new MD5CryptoServiceProvider())
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

        private void register_Load(object sender, EventArgs e)
        {

        }


        private void mail_txt_Leave(object sender, EventArgs e)
        {
            string pattern = "^([0-9a-zA-Z]([-\\.\\w]*[0-9a-zA-Z])*@([0-9a-zA-Z][-\\w]*[0-9a-zA-Z]\\.)+[a-zA-Z]{2,9})$";


            if (Regex.IsMatch(mail_txt.Text,pattern))
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
            if (name_txt.Text.Length>2 && name_txt.Text.Length < 10)
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

        private void nickname_txt_Leave(object sender, EventArgs e)
        {
            if (nickname_txt.Text.Length > 2 && nickname_txt.Text.Length < 25)
            {
                errorProvider1.Clear();
                reg_btn.Enabled = true;
            }
            else
            {
                errorProvider1.SetError(this.nickname_txt, "Please enter a valid username");
                reg_btn.Enabled = false;
                reg_btn.Cursor = Cursors.No;
                return;
            }
        }

        private void pass_txt_Leave(object sender, EventArgs e)
        {
            if (pass_txt.Text.Length > 2 && pass_txt.Text.Length < 25)
            {
                errorProvider1.Clear();
                reg_btn.Enabled = true;
            }
            else
            {
                errorProvider1.SetError(this.pass_txt, "Please enter a valid password");
                reg_btn.Enabled = false;
                return;
            }

        }

        private void re_pass_txt_Leave(object sender, EventArgs e)
        {
            if (re_pass_txt.Text==pass_txt.Text)
            {
                errorProvider1.Clear();
                reg_btn.Enabled = true;
            }
            else
            {
                errorProvider1.SetError(this.re_pass_txt, "Password is different");
                reg_btn.Enabled = false;
                return;
            }
        }

        private void reg_btn_Click(object sender, EventArgs e)
        {
            MySqlConnection connection = new MySqlConnection();
            string con_string = Global.db_connect_prop;
            string query = "INSERT INTO users (Name,Nickname,email,password,wallet,rank) VALUES ('"+name_txt.Text+"','"+nickname_txt.Text+"','"+mail_txt.Text+"','"+pass_encrypt(pass_txt.Text)+"',0,'user')";
            using (connection = new MySqlConnection(con_string))
            using (MySqlCommand write = new MySqlCommand(query, connection))
            {
                connection.Open();
                write.ExecuteNonQuery();
                connection.Close();
            }
            this.Hide();
            login_old l = new login_old();
            l.ShowDialog();
        }

        private void register_FormClosed(object sender, FormClosedEventArgs e)
        {
            Application.Exit();
        }
    }
}
