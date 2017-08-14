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
    public partial class KasirForm : MaterialForm
    {
        public static ListViewItem lvi;

        public KasirForm()
        {
            InitializeComponent();
        }

        private void btnManual_Click(object sender, EventArgs e)
        {
            KasirInputForm kif = new KasirInputForm();
            kif.ShowDialog();
            KasirInputForm.InsertData(listKasir);
            SortNumber();
        }

        void SortNumber()
        {
            int i = 1;
            foreach (ListViewItem lvi in listKasir.Items)
            {
                lvi.SubItems[0].Text = i.ToString();
                i++;
            }
        }

        private void btnCancel_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void txtbarcode_Leave(object sender, EventArgs e)
        {
            txtbarcode.Focus();
        }

        private void KasirForm_Load(object sender, EventArgs e)
        {
            txtbarcode.Focus();
        }

        private void txtbarcode_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                if (txtbarcode != null)
                {
                    Koneksi.FillListViewBarcode(listKasir, txtbarcode.Text);
                    //Koneksi.FillListViewBarcode(listKasir, "BAJ102");
                    txtbarcode.Clear();
                    SortNumber();
                }
            }
        }

        private void deleteToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (listKasir.SelectedItems.Count > 0)
            {
                foreach (ListViewItem lvi in listKasir.SelectedItems)
                {
                    lvi.Remove();
                }
            }
            else
            {
                MessageBox.Show("Pilihan Kosong");
            }
        }
    }
}
