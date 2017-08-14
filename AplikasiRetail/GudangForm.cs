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
    public partial class GudangForm : MaterialForm
    {
        public static bool isEdit;
        public static string[] strGudang = new string[7];
        int[] idGudang;
        public GudangForm()
        {
            InitializeComponent();
            ShowData();
        }

        private void btn_tambah_Click(object sender, EventArgs e)
        {
            GudangInputForm gif = new GudangInputForm();
            gif.ShowDialog();
            ShowData();
        }

        void ShowData()
        {
            listGudang.Items.Clear();
            Koneksi.FillListItem("Select * From tb_gudang", listGudang, 1);
            idGudang = Koneksi.GetSkippedID("Select * From tb_gudang", 0, listGudang.Items.Count);
        }

        private void deleteToolStripMenuItem_Click(object sender, EventArgs e)
        {
            
        }

        private void justThisOneToolStripMenuItem_Click(object sender, EventArgs e)
        {
            foreach (ListViewItem lvi in listGudang.SelectedItems)
            {
                Koneksi.ExecuteCommand("Delete From tb_gudang Where kode_barang = '" + lvi.SubItems[2].Text + "'");
            }
            ShowData();
        }

        private void byDateToolStripMenuItem_Click(object sender, EventArgs e)
        {
            foreach (ListViewItem lvi in listGudang.SelectedItems)
            {
                Koneksi.ExecuteCommand("Delete From tb_gudang Where tanggal = '" + lvi.SubItems[1].Text + "'");
            }
            ShowData();
        }

        private void byKodeBarangToolStripMenuItem_Click(object sender, EventArgs e)
        {
            foreach (ListViewItem lvi in listGudang.SelectedItems)
            {
                Koneksi.ExecuteCommand("Delete From tb_gudang Where id_gudang = '" + idGudang[Convert.ToInt32(lvi.SubItems[0].Text) - 1].ToString() + "'");
            }
            ShowData();
        }

        private void editToolStripMenuItem_Click(object sender, EventArgs e)
        {
            ListViewItem lvi = listGudang.SelectedItems[0];
            for (int i = 0; i <= strGudang.Length - 1; i++)
            {
                if (i == 6)
                    strGudang[6] = idGudang[Convert.ToInt32(lvi.SubItems[0].Text) - 1].ToString();
                else
                    strGudang[i] = lvi.SubItems[i + 2].Text;
            }

            //strGudang[0] = lvi.SubItems[2].Text;
            //strGudang[1] = lvi.SubItems[3].Text;
            //strGudang[2] = lvi.SubItems[4].Text;
            //strGudang[3] = lvi.SubItems[5].Text;
            //strGudang[4] = lvi.SubItems[6].Text;
            //strGudang[5] = lvi.SubItems[7].Text;
            //strGudang[6] = lvi.SubItems[8].Text;
            isEdit = true;
            GudangInputForm gif = new GudangInputForm();
            gif.ShowDialog();
            ShowData();
            isEdit = false;
        }

        private void materialFlatButton1_Click(object sender, EventArgs e)
        {
            BarangForm bf = new BarangForm();
            bf.ShowDialog();
        }
    }
}
