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
    public partial class FormUtamaListTaggal : MaterialForm
    {
        public static string tgl;

        public FormUtamaListTaggal()
        {
            InitializeComponent();
            PopulateData();
            PopulateComboBox();
        }

        void PopulateData()
        {
            cmbTahun.SelectedItem = null;
            cmbBulan.SelectedItem = null;
            cmbBulan.Text = "[Bulan]";
            cmbTahun.Text = "[Tahun]";
            ListUtamaTanggal.Items.Clear();
            Koneksi.FillListItemTanggal("SELECT `tb_gudang`.`tanggal` FROM `tb_gudang` UNION SELECT tb_kasir.`tanggal` FROM tb_kasir ORDER BY DATE(`tanggal`) DESC", ListUtamaTanggal, 0);
        }

        void PopulateComboBox()
        {
            MySqlDataAdapter tahun = Koneksi.ExecuteRead("SELECT EXTRACT(YEAR FROM `tb_gudang`.`tanggal`) AS Tahun FROM `tb_gudang` UNION SELECT EXTRACT(YEAR FROM tb_kasir.`tanggal`) FROM tb_kasir");
            DataTable dt = new DataTable();
            tahun.Fill(dt);
            foreach (DataRow dr in dt.Rows)
            {
                cmbTahun.Items.Add(dr["Tahun"].ToString());
            }
        }

        private void btnSearch_Click(object sender, EventArgs e)
        {
            if (cmbBulan.SelectedItem == null || cmbTahun.SelectedItem == null)
            {
                MessageBox.Show("Bulan Atau Tahun Kosong Harap Pilih", "Warning !", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
            else
            {
                int bulan = BulanToAngka(cmbBulan.SelectedItem.ToString());
                string tahun = cmbTahun.SelectedItem.ToString();
                ListUtamaTanggal.Items.Clear();
                Koneksi.FillListItemTanggal("SELECT `tb_gudang`.`tanggal` FROM `tb_gudang` WHERE YEAR(tb_gudang.`tanggal`) = " + tahun + " AND MONTH(tb_gudang.`tanggal`) = " + bulan.ToString() + " UNION SELECT tb_kasir.`tanggal` FROM tb_kasir WHERE YEAR(tb_kasir.`tanggal`) = " + tahun + " AND MONTH(tb_kasir.`tanggal`) = " + bulan.ToString() + " ORDER BY DATE(`tanggal`) DESC", ListUtamaTanggal, 0);
            }
        }

        int BulanToAngka(string bulan)
        {
            switch (bulan)
            {
                case "Januari": return 1;
                break;
                case "Febuari": return 2;
                break;
                case "Maret": return 3;
                break;
                case "April": return 4;
                break;
                case "Mei": return 5;
                break;
                case "Juni": return 6;
                break;
                case "Juli": return 7;
                break;
                case "Agustus": return 8;
                break;
                case "September": return 9;
                break;
                case "Oktober": return 10;
                break;
                case "November": return 11;
                break;
                case "Desember": return 12;
                break;
                default: return 0;
                break;
            }
        }

        private void btnReset_Click(object sender, EventArgs e)
        {
            PopulateData();
        }

        private void openToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (ListUtamaTanggal.SelectedItems.Count > 1)
            {
                MessageBox.Show("Harap Pilih Hanya 1", "Warning !", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
            else
            {
                tgl = ListUtamaTanggal.SelectedItems[0].SubItems[1].Text;
                FormUtama fu = new FormUtama();
                fu.ShowDialog();
            }
        }
    }
}
