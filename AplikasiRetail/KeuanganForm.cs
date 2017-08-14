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
    public partial class KeuanganForm : MaterialForm
    {
        int[] id_keuangan;

        public static string[] dataPass = new string[4];
        public static bool isEdit;
        public KeuanganForm()
        {
            InitializeComponent();
            PopulateData();
        }

        void PopulateData()
        {
            listKeuangan.Items.Clear();
            Koneksi.FillListItem("Select * From tb_keuangan", listKeuangan, 1);
            id_keuangan = Koneksi.GetSkippedID("Select * From tb_keuangan", 0, listKeuangan.Items.Count);
        }

        private void materialRaisedButton1_Click(object sender, EventArgs e)
        {
            KeuanganInputForm kif = new KeuanganInputForm();
            kif.ShowDialog();
            PopulateData();
        }

        private void deleteToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (listKeuangan.SelectedItems.Count == 0)
            {
                MessageBox.Show("Harap Pilih 1", "Warning !", MessageBoxButtons.OK, MessageBoxIcon.Warning) ;
            }
            else
            {
                foreach (ListViewItem lvi in listKeuangan.SelectedItems)
                {
                    Koneksi.ExecuteCommand("Delete From tb_keuangan where id_keuangan = " + id_keuangan[Convert.ToInt32(lvi.SubItems[0].Text) - 1].ToString());
                }
                PopulateData();
            }
        }

        private void editToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (listKeuangan.SelectedItems.Count > 1)
            {
                MessageBox.Show("Harap Pilih 1", "Warning !", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
            else
            {
                isEdit = true;
                dataPass[0] = listKeuangan.SelectedItems[0].SubItems[2].Text;
                dataPass[1] = listKeuangan.SelectedItems[0].SubItems[3].Text;
                dataPass[2] = listKeuangan.SelectedItems[0].SubItems[4].Text;
                dataPass[3] = id_keuangan[Convert.ToInt32(listKeuangan.SelectedItems[0].SubItems[0].Text) - 1].ToString();
                KeuanganInputForm kif = new KeuanganInputForm();
                kif.ShowDialog();
                isEdit = false;
                PopulateData();
            }
        }
    }
}
