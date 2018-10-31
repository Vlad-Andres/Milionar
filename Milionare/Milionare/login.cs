using MySql.Data.MySqlClient;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Security.Cryptography;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Milionare
{
    public partial class login : Form
    {
        public login()
        {
            InitializeComponent();
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

        private void login_Load(object sender, EventArgs e)
        {
            if (Properties.Settings.Default.remember && Properties.Settings.Default.UserName != null && Properties.Settings.Default.Password != null)
            {
                username_txt.Text = Properties.Settings.Default.UserName;
                password_txt.Text = Properties.Settings.Default.Password;
                remember_checkbx.Checked = true;
            }
            else
                Properties.Settings.Default.remember = false;
        }

        private void login_btn_Click(object sender, EventArgs e)
        {
            if (username_txt.Text.Length > 0 && password_txt.Text.Length > 0)
            {
                MySqlConnection connection = new MySqlConnection();
                string con_string = Global.db_connect_prop;
                string query = "SELECT COUNT(*),`wallet`,`rank`,`name`,`email` FROM users WHERE Nickname='" + username_txt.Text + "' AND password='" + pass_encrypt(password_txt.Text) + "'";
                using (connection = new MySqlConnection(con_string))
                using (MySqlCommand query_print = new MySqlCommand(query, connection))
                {
                    connection.Open();
                    MySqlDataReader dr = query_print.ExecuteReader(); dr.Read();
                    if (dr["COUNT(*)"].ToString() == "1")
                    {
                        if (Properties.Settings.Default.remember)
                        {
                            Properties.Settings.Default.UserName = username_txt.Text;
                            Properties.Settings.Default.Password = password_txt.Text;
                            Properties.Settings.Default.Save();
                        }
                        Global.Nickname = username_txt.Text;
                        Global.name = dr["name"].ToString();
                        Global.rank = dr["rank"].ToString();
                        Global.wallet = Convert.ToInt32(dr["wallet"]);
                        acc_recovery.sender_mail = dr["email"].ToString();
                        first_form f = new first_form();
                        this.Hide();
                        f.ShowDialog();
                    }
                    else
                        if (MetroFramework.MetroMessageBox.Show(this, "Wrong Username or Password", "", MessageBoxButtons.RetryCancel, MessageBoxIcon.Hand) == DialogResult.Cancel)
                    {
                        first_form f = new first_form();
                        this.Dispose();
                        f.ShowDialog();
                    }
                    connection.Close();
                }
            }
            else
            {

            }
        }

        private void remember_checkbx_CheckedChanged(object sender, EventArgs e)
        {
            if (remember_checkbx.Checked)
            {
                Properties.Settings.Default.remember = true;
                Properties.Settings.Default.Save();
            }
            else
            {
                Properties.Settings.Default.remember = false;
                Properties.Settings.Default.Save();
            }
        }

        private void login_FormClosed(object sender, FormClosedEventArgs e)
        {
            first_form f = new first_form();
            this.Dispose();
            f.ShowDialog();
        }

        private void register_lbl_Click(object sender, EventArgs e)
        {
            Register f = new Register();
            this.Dispose();
            f.ShowDialog();
        }

        private void pass_lost_Click(object sender, EventArgs e)
        {
            pass_recovery pss = new pass_recovery();
            this.Dispose();
            pss.ShowDialog();
        }

        private void exit_button_Click(object sender, EventArgs e)
        {
            first_form f = new first_form();
            this.Dispose();
            f.ShowDialog();
        }
    }
}