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
    public partial class KasirInputForm : MaterialForm
    {
        public static string strSearch;
        static string[] strValue = new string[5];
        public static ListView listKasir;
        public static bool isInputing;


        public KasirInputForm()
        {
            InitializeComponent();
            ShowData(false);
        }

        void ShowData(bool isSearching)
        {
            listItemBarang.Items.Clear();
            Koneksi.FillKasirListItem(listItemBarang, isSearching);
        }

        private void placeholderTextBox1_TextChanged(object sender, EventArgs e)
        {
            strSearch = placeholderTextBox1.Text;
            ShowData(true);
        }

        private void btnSubmit_Click(object sender, EventArgs e)
        {
            if (listItemBarang.SelectedItems.Count > 1 || listItemBarang.SelectedItems.Count == 0)
                MessageBox.Show("Pilih Hanya Satu !", "Warning !", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            else if (Convert.ToInt32(listItemBarang.SelectedItems[0].SubItems[4].Text) <= 0)
                MessageBox.Show("Barang yang dipilih Habis !", "Warning !",MessageBoxButtons.OK, MessageBoxIcon.Warning);
            else
            {
                ListViewItem lvi = listItemBarang.SelectedItems[0];
                strValue[0] = lvi.SubItems[1].Text;//kode Barang
                strValue[1] = lvi.SubItems[2].Text;//nama Barang
                strValue[3] = lvi.SubItems[3].Text;//Harga Satuan
                KasirInputValue kiv = new KasirInputValue();
                kiv.ShowDialog();
                if(isInputing)
                    this.Close();
            }

        }

        static int i = 1;
        public static void InsertData(MaterialListView listView)
        {
            if (isInputing)
            {
                CheckDuplicates(listView);
                ListViewItem lvi = new ListViewItem((i).ToString());
                lvi.SubItems.Add(DateTime.Now.ToString("yyyy-MM-dd"));
                lvi.SubItems.Add(strValue[0]);//kode Barang
                lvi.SubItems.Add(strValue[1]);//nama Barang
                lvi.SubItems.Add(strValue[2]);//Harga Satuan
                lvi.SubItems.Add(strValue[3]);//Volume
                int total = Convert.ToInt32(strValue[3]) * Convert.ToInt32(strValue[2]);
                lvi.SubItems.Add(total.ToString());
                listView.Items.Add(lvi);
                isInputing = false;
            }
        }

        static void CheckDuplicates(MaterialListView listView)
        {
            foreach (ListViewItem lvi in listView.Items)
            {
                if (lvi.SubItems[2].Text == strValue[0])
                {
                    strValue[2] = (Convert.ToInt32(lvi.SubItems[4].Text) + Convert.ToInt32(strValue[2])).ToString();
                    listView.Items.Remove(lvi);
                }
            }
        }

        public static void SetArray3(string value)
        {
            strValue[2] = value;
        }

        private void btnCancel_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
