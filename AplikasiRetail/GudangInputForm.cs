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
    public partial class GudangInputForm : MaterialForm
    {
        public GudangInputForm()
        {
            InitializeComponent();
            PopulateCmbSupplier();
            PopulateCmbKodeBarang();
            CekEdit();
        }

        void CekEdit()
        {
            if (GudangForm.isEdit)
            {
                cmbKodeBarang.Text = GudangForm.strGudang[0];
                tbNamaBarang.Text = GudangForm.strGudang[1];
                numBarangMasuk.Value = Convert.ToInt32(GudangForm.strGudang[2]);
                tbHargaSatuan.Text = GudangForm.strGudang[3];
                cmbSupplier.Text = GudangForm.strGudang[4];
                tbKeterangan.Text = GudangForm.strGudang[5];
            }
        }

        void UpdateBarang()
        {
            Koneksi.ExecuteCommand("Update tb_gudang SET kode_barang = '" + cmbKodeBarang.Text + "', nama_barang = '" + tbNamaBarang.Text + "', barang_masuk = '" + numBarangMasuk.Value.ToString() + "', harga_satuan = '" + tbHargaSatuan.Text + "', suplier = '" + cmbSupplier.Text + "', keterangan = '" + tbKeterangan.Text + "' Where id_gudang = '" + GudangForm.strGudang[6] + "'");
        }

        void InsertBarang()
        {
            Koneksi.ExecuteCommand("Insert INTO tb_gudang(id_gudang, tanggal, kode_barang, nama_barang, barang_masuk, harga_satuan, suplier, keterangan) VALUES (NULL, '" + DateTime.Now.ToString("yyyyMMddHHmmss") + "', '" + cmbKodeBarang.Text + "', '" + tbNamaBarang.Text + "', '" + numBarangMasuk.Value.ToString() + "','" + tbHargaSatuan.Text + "','" + cmbSupplier.Text + "', '" + tbKeterangan.Text + "');");
        }

        void PopulateCmbSupplier()
        {
            MySqlDataAdapter mda = Koneksi.ExecuteRead("Select DISTINCT suplier From tb_gudang");
            DataTable dt = new DataTable();
            mda.Fill(dt);
            foreach (DataRow dr in dt.Rows)
            {
                cmbSupplier.Items.Add(dr[0]);
            }
        }

        void PopulateCmbKodeBarang()
        {
            MySqlDataAdapter mda = Koneksi.ExecuteRead("Select kode_barang From tb_barang");
            DataTable dt = new DataTable();
            mda.Fill(dt);
            foreach (DataRow dr in dt.Rows)
            {
                cmbKodeBarang.Items.Add(dr[0]);
            }
        }

        private void btn_submit_Click(object sender, EventArgs e)
        {
            if (GudangForm.isEdit)
                UpdateBarang();
            else
                InsertBarang();
            this.Close();
        }

        private void btn_cancel_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
