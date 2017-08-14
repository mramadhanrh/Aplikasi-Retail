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
    public partial class FormUtama : MaterialForm
    {
        public FormUtama()
        {
            InitializeComponent();
            MakeKodeList();
        }
 
        void MakeKodeList()
        {
            MessageBox.Show(FormUtamaListTaggal.tgl);
            Koneksi.SetListUtama("SELECT tb_gudang.`kode_barang` FROM tb_gudang WHERE tb_gudang.`tanggal` = '" + FormUtamaListTaggal.tgl + "' UNION SELECT tb_kasir.`kode_barang` FROM tb_kasir WHERE tb_kasir.`tanggal` = '" + FormUtamaListTaggal.tgl + "'", FormUtamaListTaggal.tgl, list_utama);
        }


        public MaterialListView getListView()
        {
            return list_utama;
        }
    }
}
