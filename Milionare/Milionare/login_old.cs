using MySql.Data.MySqlClient;
using System;
using System.Security.Cryptography;
using System.Text;
using System.Windows.Forms;

namespace Milionare
{
    public partial class login_old : MaterialSkin.Controls.MaterialForm
    {
        public login_old()
        {
            InitializeComponent();
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
                nick_txt.Text = Properties.Settings.Default.UserName;
                pass_txt.Text = Properties.Settings.Default.Password;
                materialCheckBox1.Checked = true;
            }
            else
                Properties.Settings.Default.remember = false;
        }

        private void login_btn_Click(object sender, EventArgs e)
        {

            if (nick_txt.Text.Length>0 && pass_txt.Text.Length>0)
            {
                MySqlConnection connection = new MySqlConnection();
                string con_string = Global.db_connect_prop;
                string query = "SELECT COUNT(*),`wallet`,`rank`,`name`,`email` FROM users WHERE Nickname='" + nick_txt.Text+"' AND password='"+pass_encrypt(pass_txt.Text)+"'";
                using (connection = new MySqlConnection(con_string))
                using (MySqlCommand query_print = new MySqlCommand(query, connection))
                {
                    connection.Open();
                    MySqlDataReader dr = query_print.ExecuteReader(); dr.Read();
                    if (dr["COUNT(*)"].ToString() == "1")
                    {
                        if (Properties.Settings.Default.remember)
                        {
                            Properties.Settings.Default.UserName = nick_txt.Text;
                            Properties.Settings.Default.Password = pass_txt.Text;
                            Properties.Settings.Default.Save();
                        }
                        Global.Nickname = nick_txt.Text;
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

        private void register_lbl_Click(object sender, EventArgs e)
        {
            register_old f = new register_old();
            this.Dispose();
            f.ShowDialog();
        }

        private void pass_lost_Click(object sender, EventArgs e)
        {
            pass_recovery pss = new pass_recovery();
            this.Dispose();
            pss.ShowDialog();
        }

        private void login_FormClosed(object sender, FormClosedEventArgs e)
        {
            Application.Exit();
        }

        private void materialCheckBox1_CheckedChanged(object sender, EventArgs e)
        {
            if (materialCheckBox1.Checked)
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
    }
}
