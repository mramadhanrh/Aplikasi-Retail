using System;
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
    public partial class KeuanganInputForm : MaterialForm
    {
        public KeuanganInputForm()
        {
            InitializeComponent();
            CheckEdit();
        }

        void CheckEdit()
        {
            if (KeuanganForm.isEdit)
            {
                tb_Rekening.Text = KeuanganForm.dataPass[0];
                numUangMasuk.Text = KeuanganForm.dataPass[1];
                numUangKeluar.Text = KeuanganForm.dataPass[2];
            }
        }

        private void materialRaisedButton1_Click(object sender, EventArgs e)
        {
            int total = Convert.ToInt32(numUangMasuk.Text) - Convert.ToInt32(numUangKeluar.Text);
            MessageBox.Show(total.ToString());
            if (KeuanganForm.isEdit)
            {
                Koneksi.ExecuteCommand("UPDATE `db_retail`.`tb_keuangan` SET `kode_rekening` = '" + tb_Rekening.Text + "', `uang_masuk` = '" + numUangMasuk.Text + "', `uang_keluar` = '" + numUangKeluar.Text + "', `total` = '" + total.ToString() + "' WHERE `tb_keuangan`.`id_keuangan` = '" + KeuanganForm.dataPass[3] + "';");
            }
            else
            {
                Koneksi.ExecuteCommand("INSERT INTO `db_retail`.`tb_keuangan` (`id_keuangan`, `tanggal`, `kode_rekening`, `uang_masuk`, `uang_keluar`, `total`) VALUES (NULL, '" + DateTime.Now.ToString("yyyy-MM-dd") + "', '" + tb_Rekening.Text + "', '" + numUangMasuk.Text + "', '" + numUangKeluar.Text + "', '" + total + "');");
            }
            this.Close();
        }

        private void numUangKeluar_KeyPress(object sender, KeyPressEventArgs e)
        {
            e.Handled = !char.IsDigit(e.KeyChar) && !char.IsControl(e.KeyChar);
        }

        private void numUangMasuk_KeyPress(object sender, KeyPressEventArgs e)
        {
            e.Handled = !char.IsDigit(e.KeyChar) && !char.IsControl(e.KeyChar);
        }


    }
}
