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
    public partial class BarangForm : MaterialForm
    {
        public static bool isEdit;
        public static string[] barang = new string[2];
        public BarangForm()
        {
            InitializeComponent();
            ShowData();
        }

        void ShowData()
        {
            listBarang.Items.Clear();
            Koneksi.FillListItem("Select * From tb_barang", listBarang, 0);
        }

        private void btnTambah_Click(object sender, EventArgs e)
        {
            BarangInputForm bif = new BarangInputForm();
            bif.ShowDialog();
            ShowData();
        }

        private void editToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (listBarang.SelectedItems.Count > 1)
            {
                MessageBox.Show("Hanya Pilih 1 Untuk Edit");
            }
            else
            {
                barang[0] = listBarang.SelectedItems[0].SubItems[1].Text;
                barang[1] = listBarang.SelectedItems[0].SubItems[2].Text;
                isEdit = true;
                BarangInputForm bif = new BarangInputForm();
                bif.ShowDialog();
                isEdit = false;
                ShowData();
            }
        }

        private void deleteToolStripMenuItem_Click(object sender, EventArgs e)
        {
            foreach (ListViewItem lvi in listBarang.SelectedItems)
            {
                Koneksi.ExecuteCommand("Delete From tb_barang Where kode_barang = '" + lvi.SubItems[1].Text + "'");
            }
            ShowData();
        }
    }
}
