namespace AplikasiRetail
{
    partial class FormUtama
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.list_utama = new MaterialSkin.Controls.MaterialListView();
            this.Nomor = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.Tanggal = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.Kode_Barang = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.Nama_Barang = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.Jumlah_Barang = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.Barang_Masuk = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.Barang_Keluar = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.Sisa_Barang = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.Harga_Satuan_Barang = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.Jumlah_Harga_Barang = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.Uang_Masuk = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.Selisih = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.Supplier = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.Keterangan = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.btnReset = new MaterialSkin.Controls.MaterialRaisedButton();
            this.SuspendLayout();
            // 
            // list_utama
            // 
            this.list_utama.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.list_utama.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.list_utama.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.Nomor,
            this.Tanggal,
            this.Kode_Barang,
            this.Nama_Barang,
            this.Jumlah_Barang,
            this.Barang_Masuk,
            this.Barang_Keluar,
            this.Sisa_Barang,
            this.Harga_Satuan_Barang,
            this.Jumlah_Harga_Barang,
            this.Uang_Masuk,
            this.Selisih,
            this.Supplier,
            this.Keterangan});
            this.list_utama.Depth = 0;
            this.list_utama.Font = new System.Drawing.Font("Roboto", 32F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.World);
            this.list_utama.FullRowSelect = true;
            this.list_utama.HeaderStyle = System.Windows.Forms.ColumnHeaderStyle.Nonclickable;
            this.list_utama.Location = new System.Drawing.Point(12, 132);
            this.list_utama.MouseLocation = new System.Drawing.Point(-1, -1);
            this.list_utama.MouseState = MaterialSkin.MouseState.OUT;
            this.list_utama.Name = "list_utama";
            this.list_utama.OwnerDraw = true;
            this.list_utama.Size = new System.Drawing.Size(716, 303);
            this.list_utama.TabIndex = 0;
            this.list_utama.UseCompatibleStateImageBehavior = false;
            this.list_utama.View = System.Windows.Forms.View.Details;
            // 
            // Nomor
            // 
            this.Nomor.Text = "No.";
            // 
            // Tanggal
            // 
            this.Tanggal.Text = "Tanggal";
            this.Tanggal.Width = 120;
            // 
            // Kode_Barang
            // 
            this.Kode_Barang.Text = "Kode Barang";
            this.Kode_Barang.Width = 120;
            // 
            // Nama_Barang
            // 
            this.Nama_Barang.Text = "Nama Barang";
            this.Nama_Barang.Width = 160;
            // 
            // Jumlah_Barang
            // 
            this.Jumlah_Barang.Text = "Jumlah Barang";
            // 
            // Barang_Masuk
            // 
            this.Barang_Masuk.Text = "Barang Masuk";
            // 
            // Barang_Keluar
            // 
            this.Barang_Keluar.Text = "Barang Keluar";
            // 
            // Sisa_Barang
            // 
            this.Sisa_Barang.Text = "Sisa Barang";
            // 
            // Harga_Satuan_Barang
            // 
            this.Harga_Satuan_Barang.Text = "Harga Satuan Barang";
            this.Harga_Satuan_Barang.Width = 120;
            // 
            // Jumlah_Harga_Barang
            // 
            this.Jumlah_Harga_Barang.Text = "Jumlah Harga Barang";
            this.Jumlah_Harga_Barang.Width = 120;
            // 
            // Uang_Masuk
            // 
            this.Uang_Masuk.Text = "Uang Masuk";
            this.Uang_Masuk.Width = 120;
            // 
            // Selisih
            // 
            this.Selisih.Text = "Selisih";
            this.Selisih.Width = 120;
            // 
            // Supplier
            // 
            this.Supplier.Text = "Supplier";
            this.Supplier.Width = 120;
            // 
            // Keterangan
            // 
            this.Keterangan.Text = "Keterangan";
            this.Keterangan.Width = 200;
            // 
            // btnReset
            // 
            this.btnReset.AutoSize = true;
            this.btnReset.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.btnReset.Depth = 0;
            this.btnReset.Icon = null;
            this.btnReset.Location = new System.Drawing.Point(580, 79);
            this.btnReset.MouseState = MaterialSkin.MouseState.HOVER;
            this.btnReset.Name = "btnReset";
            this.btnReset.Primary = true;
            this.btnReset.Size = new System.Drawing.Size(148, 36);
            this.btnReset.TabIndex = 4;
            this.btnReset.Text = "Tampilkan Semua";
            this.btnReset.UseVisualStyleBackColor = true;
            // 
            // FormUtama
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(740, 447);
            this.Controls.Add(this.btnReset);
            this.Controls.Add(this.list_utama);
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "FormUtama";
            this.Sizable = false;
            this.Text = "FormUtama";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ColumnHeader Nomor;
        private System.Windows.Forms.ColumnHeader Tanggal;
        private System.Windows.Forms.ColumnHeader Kode_Barang;
        private System.Windows.Forms.ColumnHeader Nama_Barang;
        private System.Windows.Forms.ColumnHeader Jumlah_Barang;
        private System.Windows.Forms.ColumnHeader Barang_Masuk;
        private System.Windows.Forms.ColumnHeader Barang_Keluar;
        private System.Windows.Forms.ColumnHeader Sisa_Barang;
        private System.Windows.Forms.ColumnHeader Harga_Satuan_Barang;
        private System.Windows.Forms.ColumnHeader Jumlah_Harga_Barang;
        private System.Windows.Forms.ColumnHeader Uang_Masuk;
        private System.Windows.Forms.ColumnHeader Selisih;
        private System.Windows.Forms.ColumnHeader Supplier;
        private System.Windows.Forms.ColumnHeader Keterangan;
        private MaterialSkin.Controls.MaterialRaisedButton btnReset;
        public MaterialSkin.Controls.MaterialListView list_utama;
    }
}