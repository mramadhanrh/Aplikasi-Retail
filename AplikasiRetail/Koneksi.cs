using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using MySql.Data.MySqlClient;
using System.Windows.Forms;
using MaterialSkin.Controls;
using System.Data;

namespace AplikasiRetail
{
    class Koneksi
    {
        public static string server;
        public static string database;
        public static string uid;
        public static string password;
        public static MySqlConnection connection;

        public static MySqlConnection connectDatabase()
        {
            server = "localhost";
            database = "db_retail";
            uid = "root";
            password = "";
            string connectionString;
            connectionString = "SERVER=" + server + ";" + "DATABASE=" + database + ";" + "UID=" + uid + ";" + "PASSWORD=" + password + ";";
            connection = new MySqlConnection(connectionString);
            return connection;
        }

        public static bool OpenConnection()
        {
            try
            {
                connectDatabase().Open();
                return true;
                MessageBox.Show("OPENED");
            }
            catch (MySqlException ex)
            {
                //When handling errors, you can your application's response based on the error number.
                //The two most common error numbers when connecting are as follows:
                //0: Cannot connect to server.
                //1045: Invalid user name and/or password.
                switch (ex.Number)
                {
                    case 0:
                        MessageBox.Show("Cannot connect to server. Contact administrator");
                        break;
                    case 1045:
                        MessageBox.Show("Invalid username/password, please try again");
                        break;
                    default:
                        MessageBox.Show(ex.Message);
                        break;
                }
                return false;
            }
        }

        public static bool CloseConnection()
        {
            try
            {
                connectDatabase().Close();
                return true;
            }
            catch (MySqlException ex)
            {
                MessageBox.Show(ex.Message);
                return false;
            }
        }

        public static void ExecuteCommand(string Query)
        {
            try
            {
                connectDatabase();
                MySqlCommand MyCommand = new MySqlCommand(Query, connection);
                MySqlDataReader MyReader;
                connection.Open();
                MyReader = MyCommand.ExecuteReader();
                while (MyReader.Read())
                {
                }
                connection.Close();
            }
            catch (Exception ex) 
            {
                MessageBox.Show(ex.Message);
            }
        }

        public static MySqlDataAdapter ExecuteRead(string Query)
        {
            return new MySqlDataAdapter(Query, connectDatabase());
        }

        public static void SetListUtama(string Query, string tanggal, MaterialListView listView)
        {
            MessageBox.Show(Query);
            MySqlDataAdapter mda = ExecuteRead(Query);
            DataTable dt = new DataTable();
            mda.Fill(dt);
            int i = 1;
            foreach (DataRow dr in dt.Rows)
            {
                listitem = new ListViewItem(i.ToString());
                string kode_brg = dr["kode_barang"].ToString();
                string nama_brg = getNamaBarang(kode_brg);
                string jumlah_brg_klr = getJumlahBarangKeluar(kode_brg, tanggal);
                
                if (jumlah_brg_klr == "")
                    jumlah_brg_klr = "0";

                int jumlah_brg = Convert.ToInt32(getJumlahBarang(kode_brg,tanggal));
                string barang_klr = getBarangKeluar(kode_brg, tanggal);
                string barang_msk = getBarangMasuk(kode_brg, tanggal);
                MessageBox.Show("asd " + barang_msk);
                if (barang_msk == "")
                    barang_msk = "0";

                if (barang_klr == "")
                    barang_klr = "0";

                int sisa_brg = Convert.ToInt32(jumlah_brg) - Convert.ToInt32(jumlah_brg_klr);
                string harga_satuan = getHargaSatuan(kode_brg);
                int jumlah_harga = Convert.ToInt32(harga_satuan) * Convert.ToInt32(jumlah_brg);
                int uang_masuk = Convert.ToInt32(harga_satuan) * Convert.ToInt32(barang_klr);
                int selisih = jumlah_harga - uang_masuk;
                string supplier = getSupplier(kode_brg);
                string keterangan = getKeterangan(kode_brg);

                MessageBox.Show(Query, kode_brg);

                listitem.SubItems.Add(tanggal);
                listitem.SubItems.Add(kode_brg);
                listitem.SubItems.Add(nama_brg);//Nama Barang
                listitem.SubItems.Add(jumlah_brg.ToString());//Jumlah Barang
                listitem.SubItems.Add(barang_msk);//Barang Masuk
                listitem.SubItems.Add(barang_klr);//Barang Keluar
                listitem.SubItems.Add(sisa_brg.ToString());//Sisa Barang
                listitem.SubItems.Add(harga_satuan.ToString());//Harga Satuan
                listitem.SubItems.Add(jumlah_harga.ToString());//Jumlah Harga
                listitem.SubItems.Add(uang_masuk.ToString());//Uang Masuk
                listitem.SubItems.Add(selisih.ToString());//Selisih
                listitem.SubItems.Add(supplier);
                listitem.SubItems.Add(keterangan);

                listView.Items.Add(listitem);
                i++;
            }
        }

        static string getKeterangan(string kode_barang)
        {
            MySqlDataAdapter mda = ExecuteRead("SELECT tb_gudang.`keterangan` FROM tb_gudang WHERE kode_barang = '" + kode_barang + "' GROUP BY kode_barang");
            DataTable dt = new DataTable();
            mda.Fill(dt);
            DataRow dr = dt.Rows[0];
            return dr["keterangan"].ToString();
        }
        static string getSupplier(string kode_barang)
        {
            MySqlDataAdapter mda = ExecuteRead("SELECT tb_gudang.`suplier` FROM tb_gudang WHERE kode_barang = '" + kode_barang + "' GROUP BY kode_barang");
            DataTable dt = new DataTable();
            mda.Fill(dt);
            DataRow dr = dt.Rows[0];
            return dr["suplier"].ToString();
        }

        static string getHargaSatuan(string kode_barang)
        {
            MySqlDataAdapter mda = ExecuteRead("SELECT tb_gudang.`harga_satuan` FROM tb_gudang WHERE tb_gudang.`kode_barang` = '" + kode_barang + "' GROUP BY kode_barang");
            DataTable dt = new DataTable();
            mda.Fill(dt);
            DataRow dr = dt.Rows[0];
            return dr["harga_satuan"].ToString();
        }

        static string getBarangKeluar(string kode_barang, string tanggal)
        {
            MySqlDataAdapter mda = ExecuteRead("SELECT SUM(`tb_kasir`.`volume`) AS Barang_Keluar FROM tb_kasir WHERE tb_kasir.`kode_barang` = '"+kode_barang+"' AND tb_kasir.`tanggal` = '"+tanggal+"'");
            DataTable dt = new DataTable();
            mda.Fill(dt);
            DataRow dr = dt.Rows[0];
            return dr["Barang_Keluar"].ToString();
        }

        static string getBarangMasuk(string kode_barang, string tanggal)
        {
            MySqlDataAdapter mda = ExecuteRead("SELECT SUM(tb_gudang.`barang_masuk`) AS Barang_Masuk FROM tb_gudang WHERE tb_gudang.`kode_barang` = '" + kode_barang + "' AND tb_gudang.`tanggal` = '" + tanggal + "'");
            DataTable dt = new DataTable();
            mda.Fill(dt);
            DataRow dr = dt.Rows[0];
            MessageBox.Show(kode_barang + tanggal);
            MessageBox.Show("CEK : " + "SELECT SUM(tb_gudang.`barang_masuk`) AS Barang_Masuk FROM tb_gudang WHERE tb_gudang.`kode_barang` = '" + kode_barang + "' AND tb_gudang.`tanggal` = '" + tanggal + "'");
            return dr["Barang_Masuk"].ToString();
        }

        static string getJumlahBarang(string kode_barang, string tanggal)
        {
            MySqlDataAdapter mda = ExecuteRead("SELECT SUM(tb_gudang.`barang_masuk`) AS Jumlah FROM tb_gudang WHERE tb_gudang.`kode_barang` = '" + kode_barang + "' AND tb_gudang.`tanggal` <= '" + tanggal + "'");
            DataTable dt = new DataTable();
            mda.Fill(dt);
            DataRow dr = dt.Rows[0];
            return dr["Jumlah"].ToString();
        }

        static string getJumlahBarangKeluar(string kode_barang, string tanggal)
        {
            MySqlDataAdapter mda = ExecuteRead("SELECT SUM(tb_kasir.`volume`) AS Jumlah_Barang_Keluar FROM tb_kasir WHERE kode_barang = '"+kode_barang+"' AND tb_kasir.`tanggal` <= '" + tanggal + "'");
            DataTable dt = new DataTable();
            mda.Fill(dt);
            DataRow dr = dt.Rows[0];
            return dr["Jumlah_Barang_Keluar"].ToString();
        }

        static string getNamaBarang(string kode_barang)
        {
            MySqlDataAdapter mda = ExecuteRead("SELECT tb_barang.`nama_barang` FROM tb_barang WHERE tb_barang.`kode_barang` = '" + kode_barang + "'");
            DataTable dt = new DataTable();
            mda.Fill(dt);
            DataRow dr = dt.Rows[0];
            return dr["nama_barang"].ToString();
        }

        static ListViewItem listitem;
        public static void FillListItem(string query, MaterialListView list, int skip)
        {
            MySqlDataAdapter mysqlDataAdapter = ExecuteRead(query);
            DataTable dt = new DataTable();
            mysqlDataAdapter.Fill(dt);
            int i = 1;

            foreach (DataRow dr in dt.Rows)
            {
                listitem = new ListViewItem((i).ToString());
                foreach (var item in dr.ItemArray.Skip(skip))
                {
                    listitem.SubItems.Add(item.ToString());
                }
                list.Items.Add(listitem);
                i++;
            }
        }

        public static void FillListItemTanggal(string query, MaterialListView list, int skip)
        {
            MySqlDataAdapter mysqlDataAdapter = ExecuteRead(query);
            DataTable dt = new DataTable();
            mysqlDataAdapter.Fill(dt);
            int i = 1;

            foreach (DataRow dr in dt.Rows)
            {
                listitem = new ListViewItem((i).ToString());
                foreach (var item in dr.ItemArray.Skip(skip))
                {
                    DateTime date = DateTime.Parse(item.ToString());
                    listitem.SubItems.Add(date.ToString("yyyy-MM-dd"));
                }
                list.Items.Add(listitem);
                i++;
            }
        }

        public static void FillListViewBarcode(MaterialListView list, string barcodeValue)
        {
            MySqlDataAdapter mysqlDataAdapter;

            mysqlDataAdapter = ExecuteRead("SELECT kode_barang, nama_barang, harga_satuan FROM tb_gudang WHERE CONCAT(kode_barang) LIKE '%" + barcodeValue + "%' GROUP BY kode_barang;");
            DataTable dt = new DataTable();
            mysqlDataAdapter.Fill(dt);
            int i = 1;
            if (dt.Rows.Count > 0)
            {
                DataRow dr = dt.Rows[0];
                listitem = new ListViewItem((i).ToString());
                listitem.SubItems.Add(DateTime.Now.ToString("yyyy-MM-dd"));
                listitem.SubItems.Add(dr["kode_barang"].ToString());
                listitem.SubItems.Add(dr["nama_barang"].ToString());

                int volume = CheckDuplicates(list, dr["kode_barang"].ToString());
                int total = Convert.ToInt32(dr["harga_satuan"]) * volume;

                listitem.SubItems.Add(volume.ToString());
                listitem.SubItems.Add(dr["harga_satuan"].ToString());
                listitem.SubItems.Add(total.ToString());
                list.Items.Add(listitem);
            }
            else
            {
                MySqlDataAdapter mysqlDataAdapter2 = ExecuteRead("SELECT * FROM tb_barang WHERE kode_barang LIKE '" + barcodeValue + "'");
                DataTable dt2 = new DataTable();
                mysqlDataAdapter2.Fill(dt2);
                if (dt2.Rows.Count > 0)
                {
                    MessageBox.Show("Barang Dengan Barcode '"+barcodeValue+"' Terdaftar Tetapi Tak Ada Di Gudang");
                }
                else
                {
                    MessageBox.Show("Kode Barcode '"+barcodeValue+"' Tidak Terdaftar !", "Warning !", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                }
            }
        }

        static int CheckDuplicates(MaterialListView listView, string strkode)
        {
            foreach (ListViewItem lvi in listView.Items)
            {
                if (lvi.SubItems[2].Text == strkode)
                {
                    listView.Items.Remove(lvi);
                    return Convert.ToInt32(lvi.SubItems[4].Text) + 1;
                }
            }
            return 1;
        }

        public static void FillKasirListItem(MaterialListView list, bool isSearching)
        {
            MySqlDataAdapter mysqlDataAdapter;

            if (isSearching)
                mysqlDataAdapter = ExecuteRead("SELECT kode_barang, nama_barang, harga_satuan FROM tb_gudang WHERE CONCAT(kode_barang, ' ',nama_barang) LIKE '%"+KasirInputForm.strSearch+"%' GROUP BY kode_barang;");
            else
                mysqlDataAdapter = ExecuteRead("SELECT kode_barang, nama_barang, harga_satuan FROM tb_gudang GROUP BY kode_barang;");

            DataTable dt = new DataTable();
            mysqlDataAdapter.Fill(dt);
            int i = 1;

            foreach (DataRow dr in dt.Rows)
            {
                listitem = new ListViewItem((i).ToString());
                listitem.SubItems.Add(dr["kode_barang"].ToString());
                listitem.SubItems.Add(dr["nama_barang"].ToString());
                listitem.SubItems.Add(dr["harga_satuan"].ToString());
                listitem.SubItems.Add(getSisaStok(dr["kode_barang"].ToString()));
                list.Items.Add(listitem);
                i++;
            }
        }

        static string getSisaStok(string kode_barang)
        {
            MySqlDataAdapter stokGudang = ExecuteRead("SELECT SUM(`tb_gudang`.`barang_masuk`) AS sisaStok FROM tb_gudang WHERE tb_gudang.`kode_barang` = '" + kode_barang + "'");
            MySqlDataAdapter keluarKasir = ExecuteRead("SELECT SUM(`tb_kasir`.`volume`) AS sisaStok FROM tb_kasir WHERE tb_kasir.`kode_barang` = '" + kode_barang + "';");
            DataTable dtGudang = new DataTable();
            DataTable dtKasir = new DataTable();
            stokGudang.Fill(dtGudang);
            keluarKasir.Fill(dtKasir);
            int gudang, kasir;

            DataRow drGudang = dtGudang.Rows[0];
            if (drGudang["sisaStok"].ToString() == "")
                gudang = 0;
            else
                gudang = Convert.ToInt32(drGudang["sisaStok"].ToString());

            DataRow drKasir = dtKasir.Rows[0];
            if (drKasir["sisaStok"].ToString() == "")
                kasir = 0;
            else
                kasir = Convert.ToInt32(drKasir["sisaStok"].ToString());

            int sisaStok = gudang - kasir;

            return sisaStok.ToString();
        }

        static int[] val;
        public static int[] GetSkippedID(string query, int row, int limit)
        {
            MySqlDataAdapter mysqlDataAdapter = ExecuteRead(query);
            DataTable dt = new DataTable();
            mysqlDataAdapter.Fill(dt);
            int i = 0;
            val = new int[limit];
            foreach (DataRow dr in dt.Rows)
            {   
                val[i] = Convert.ToInt32(dr[row]);
                i++;
            }
            return val;
        }

    }
}
