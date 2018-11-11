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
    public partial class pass_recovery : MaterialSkin.Controls.MaterialForm
    {
        public pass_recovery()
        {
            InitializeComponent();
            MaterialSkin.MaterialSkinManager skinManager = MaterialSkin.MaterialSkinManager.Instance;
            skinManager.AddFormToManage(this);
            skinManager.Theme = MaterialSkin.MaterialSkinManager.Themes.DARK;
            skinManager.ColorScheme = new MaterialSkin.ColorScheme(MaterialSkin.Primary.Blue900, MaterialSkin.Primary.BlueGrey900, MaterialSkin.Primary.BlueGrey500, MaterialSkin.Accent.Orange700, MaterialSkin.TextShade.WHITE);
            this.MaximizeBox = false;
            Code_lbl.Visible = false;
            // Welcome dear user , please send us the code we've sended you at your email (email)

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

        private void materialRaisedButton2_Click(object sender, EventArgs e)
        {
            login l = new login();
            this.Dispose();
            l.ShowDialog();
        }
        string temp_mail;
        private void materialRaisedButton1_Click(object sender, EventArgs e)
        {
            
            wrong_code_lbl.Visible = false;
            MySqlConnection connection = new MySqlConnection();
            string con_string = Global.db_connect_prop;
            if (materialRaisedButton1.Text != "SUBMIT" && materialRaisedButton1.Text != "CHANGE")
            {
                temp_mail = recovery_email_txt.Text;
                string query = "SELECT COUNT(*) FROM users WHERE email='" + temp_mail + "'";
                try
                {
                    using (connection = new MySqlConnection(con_string))
                    using (MySqlCommand query_print = new MySqlCommand(query, connection))
                    {

                        connection.Open();
                        MySqlDataReader dr = query_print.ExecuteReader(); dr.Read();
                        if (dr["COUNT(*)"].ToString() == "1")
                        {
                            acc_recovery.send_recovery(recovery_email_txt.Text);
                            recovery_email_txt.Text = "Please insert your verification code";
                            user_welcome_lbl.Visible = false;
                            materialRaisedButton1.Text = "SUBMIT";
                            Code_lbl.Visible = true;


                        }
                        else
                        {
                            MetroFramework.MetroMessageBox.Show(this, "Such email wasn't registered", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                        }

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
            }
            else if (materialRaisedButton1.Text == "SUBMIT")
            {
                if (Code_lbl.Text == acc_recovery.temp_code)
                {
                    
                    materialRaisedButton1.Text = "CHANGE";
                    Code_lbl.Visible = false;
                    new_pass_lbl.Visible = true;
                    re_pass_txt.Visible = true;
                    recovery_email_txt.Visible = false;
                    user_welcome_lbl.Text = "Change your password:";
                }
                else
                {
                    wrong_code_lbl.Visible = true;
                }
            }
            else if (materialRaisedButton1.Text == "CHANGE")
            {
                string query = "UPDATE users SET password = '"+pass_encrypt(new_pass_lbl.Text)+"' WHERE email='" + temp_mail + "'";
                try
                {
                    using (connection = new MySqlConnection(con_string))
                    using (MySqlCommand query_print = new MySqlCommand(query, connection))
                    {
                        connection.Open(); query_print.ExecuteNonQuery(); connection.Close();
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

            }
            //            acc_recovery.sned_recovery();
        }

        private void pass_recovery_FormClosed(object sender, FormClosedEventArgs e)
        {
            Application.Exit();
        }
    }
}
