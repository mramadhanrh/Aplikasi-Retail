using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Drawing.Printing;
using MaterialSkin;
using MaterialSkin.Controls;
using MySql.Data.MySqlClient;
using BarcodeLib;

namespace AplikasiRetail
{
    public partial class BarangInputForm : MaterialForm
    {
        public BarangInputForm()
        {
            InitializeComponent();
            CekEdit();
        }

        void barcodelibchange(string val)
        {
            BarcodeLib.Barcode b = new Barcode();
            Image img = b.Encode(BarcodeLib.TYPE.CODE128, val, Color.Black, Color.White, 300, 100);
            pictureBox1.Image = img;
        }

        void CekEdit()
        {
            if (BarangForm.isEdit)
            {
                tbKodeBarang.Text = BarangForm.barang[0];
                tbNamaBarang.Text = BarangForm.barang[1];
            }
        }

        private void btnCancel_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void tbKodeBarang_TextChanged(object sender, EventArgs e)
        {
            if (tbKodeBarang.Text.Length != 0)
                barcodelibchange(tbKodeBarang.Text);
            else
                barcodelibchange("0");
        }

        void InsertData()
        {
            Koneksi.ExecuteCommand("Insert INTO tb_barang(kode_barang, nama_barang) VALUES('" + tbKodeBarang.Text + "', '" + tbNamaBarang.Text + "');");
        }

        void UpdateData()
        {
            Koneksi.ExecuteCommand("Update tb_barang SET kode_barang = '" + tbKodeBarang.Text + "', nama_barang = '" + tbNamaBarang.Text + "' Where kode_barang = '"+BarangForm.barang[0].ToString()+"'");
        }

        private void btnPrint_Click(object sender, EventArgs e)
        {
            if (tbKodeBarang.Text.Length >= 6)
            {
                //PrintDialog pdi = new PrintDialog();
                //pdi.ShowDialog();
                PrintDocument printDocument1 = new PrintDocument();
                printDocument1.PrintPage += new PrintPageEventHandler(printDocument1_PrintPage);
                printDocument1.Print();
            }
            else
                MessageBox.Show("Harap Masukan Kode Barang", "Warning!", MessageBoxButtons.OK, MessageBoxIcon.Warning);
        }

        private void printDocument1_PrintPage(object sender, System.Drawing.Printing.PrintPageEventArgs e)
        {
            e.Graphics.DrawImage(pictureBox1.Image, 0, 0);
        }

        private void btnSubmit_Click(object sender, EventArgs e)
        {
            if (tbKodeBarang.Text.Length != 0 || tbNamaBarang.Text.Length != 0)
            {
                if (BarangForm.isEdit)
                    UpdateData();
                else
                    InsertData();

            }
            else
                MessageBox.Show("Salah Satu Field Kosong.", "Warning!", MessageBoxButtons.OK, MessageBoxIcon.Warning);

            this.Close();
        }
    }
}
