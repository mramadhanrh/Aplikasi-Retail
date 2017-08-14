using System;
using System.Configuration;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using MaterialSkin;
using MaterialSkin.Controls;
using MySql.Data.MySqlClient;

namespace AplikasiRetail
{
    public partial class Login : MaterialForm
    {
        public Login()
        {
            InitializeComponent();
            //untuk check langsung masuk form
            //string value = ConfigurationManager.AppSettings["rememberUser"];
        }

        void CheckLogin()
        {
            MySqlDataAdapter mySqlDataAdapter = new MySqlDataAdapter("select * from tb_user where username='" + tb_username.Text + "' AND password=md5('" + tb_password.Text + "')", Koneksi.connectDatabase());
            DataTable dt = new DataTable();
            mySqlDataAdapter.Fill(dt);

            if (dt.Rows.Count != 0)
            {
                //MessageBox.Show("Login Berhasil");
                DataRow dr = dt.Rows[0];
                RememberLogin(dr["level"].ToString());
                //MessageBox.Show(dr["level"].ToString());
                OpenFormsByLevel(dr["level"].ToString());
            }
            else
            {
                MessageBox.Show("Username/Password Salah !", "", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
        }

        void OpenFormsByLevel(string level)
        {
            if (level == "0")
            {
                FormUtamaListTaggal fult = new FormUtamaListTaggal();
                fult.ShowDialog();
                this.Close();
            }
            else if (level == "1")
            {
                GudangForm gf = new GudangForm();
                gf.ShowDialog();
                this.Close();
            }
            else if (level == "2")
            {
                KasirForm kf = new KasirForm();
                kf.ShowDialog();
                this.Close();
            }
            else if (level == "3")
            {
                KeuanganForm kf = new KeuanganForm();
                kf.ShowDialog();
                this.Close();
            }
            this.Hide();
        }

        private void RememberLogin(string level)
        {
            Configuration conf = ConfigurationManager.OpenExeConfiguration(Application.ExecutablePath);
            conf.AppSettings.Settings["rememberUser"].Value = level;
            conf.Save(ConfigurationSaveMode.Modified);
            ConfigurationManager.RefreshSection(ConfigurationUserLevel.None.ToString());

            //MessageBox.Show(conf.AppSettings.Settings["rememberUser"].Value.ToString());
        }
        
        private void materialRaisedButton1_Click(object sender, EventArgs e)
        {
            CheckLogin();
        }
    }
}
