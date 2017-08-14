using System.Drawing;
using System.Windows.Forms;
using MaterialSkin;
using MaterialSkin.Controls;

namespace AplikasiRetail
{
    partial class GudangForm
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
            this.listGudang = new MaterialSkin.Controls.MaterialListView();
            this.Nomor = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.Tanggal = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.KodeBarang = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.NamaBarang = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.BarangMasuk = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.HargaSatuan = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.Supplier = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.Keterangan = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.cmsGudang = new MaterialSkin.Controls.MaterialContextMenuStrip();
            this.editToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.deleteToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.byKodeBarangToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.byDateToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.justThisOneToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.btn_tambah = new MaterialSkin.Controls.MaterialRaisedButton();
            this.materialFlatButton1 = new MaterialSkin.Controls.MaterialFlatButton();
            this.cmsGudang.SuspendLayout();
            this.SuspendLayout();
            // 
            // listGudang
            // 
            this.listGudang.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.listGudang.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.listGudang.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.Nomor,
            this.Tanggal,
            this.KodeBarang,
            this.NamaBarang,
            this.BarangMasuk,
            this.HargaSatuan,
            this.Supplier,
            this.Keterangan});
            this.listGudang.ContextMenuStrip = this.cmsGudang;
            this.listGudang.Depth = 0;
            this.listGudang.Font = new System.Drawing.Font("Roboto", 32F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.World);
            this.listGudang.FullRowSelect = true;
            this.listGudang.HeaderStyle = System.Windows.Forms.ColumnHeaderStyle.Nonclickable;
            this.listGudang.Location = new System.Drawing.Point(12, 122);
            this.listGudang.MouseLocation = new System.Drawing.Point(-1, -1);
            this.listGudang.MouseState = MaterialSkin.MouseState.OUT;
            this.listGudang.Name = "listGudang";
            this.listGudang.OwnerDraw = true;
            this.listGudang.Size = new System.Drawing.Size(733, 354);
            this.listGudang.TabIndex = 0;
            this.listGudang.UseCompatibleStateImageBehavior = false;
            this.listGudang.View = System.Windows.Forms.View.Details;
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
            // KodeBarang
            // 
            this.KodeBarang.Text = "Kode Barang";
            this.KodeBarang.Width = 140;
            // 
            // NamaBarang
            // 
            this.NamaBarang.Text = "Nama Barang";
            this.NamaBarang.Width = 220;
            // 
            // BarangMasuk
            // 
            this.BarangMasuk.Text = "Barang Masuk";
            this.BarangMasuk.Width = 140;
            // 
            // HargaSatuan
            // 
            this.HargaSatuan.Text = "Harga Satuan Barang";
            this.HargaSatuan.Width = 180;
            // 
            // Supplier
            // 
            this.Supplier.Text = "Supplier";
            this.Supplier.Width = 140;
            // 
            // Keterangan
            // 
            this.Keterangan.Text = "Keterangan";
            this.Keterangan.Width = 200;
            // 
            // cmsGudang
            // 
            this.cmsGudang.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.cmsGudang.Depth = 0;
            this.cmsGudang.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.editToolStripMenuItem,
            this.deleteToolStripMenuItem});
            this.cmsGudang.MouseState = MaterialSkin.MouseState.HOVER;
            this.cmsGudang.Name = "cmsGudang";
            this.cmsGudang.Size = new System.Drawing.Size(108, 48);
            // 
            // editToolStripMenuItem
            // 
            this.editToolStripMenuItem.Name = "editToolStripMenuItem";
            this.editToolStripMenuItem.Size = new System.Drawing.Size(107, 22);
            this.editToolStripMenuItem.Text = "Edit";
            this.editToolStripMenuItem.Click += new System.EventHandler(this.editToolStripMenuItem_Click);
            // 
            // deleteToolStripMenuItem
            // 
            this.deleteToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.byKodeBarangToolStripMenuItem,
            this.byDateToolStripMenuItem,
            this.justThisOneToolStripMenuItem});
            this.deleteToolStripMenuItem.Name = "deleteToolStripMenuItem";
            this.deleteToolStripMenuItem.Size = new System.Drawing.Size(107, 22);
            this.deleteToolStripMenuItem.Text = "Delete";
            this.deleteToolStripMenuItem.Click += new System.EventHandler(this.deleteToolStripMenuItem_Click);
            // 
            // byKodeBarangToolStripMenuItem
            // 
            this.byKodeBarangToolStripMenuItem.Name = "byKodeBarangToolStripMenuItem";
            this.byKodeBarangToolStripMenuItem.Size = new System.Drawing.Size(180, 22);
            this.byKodeBarangToolStripMenuItem.Text = "Hanya Yang Ini";
            this.byKodeBarangToolStripMenuItem.Click += new System.EventHandler(this.byKodeBarangToolStripMenuItem_Click);
            // 
            // byDateToolStripMenuItem
            // 
            this.byDateToolStripMenuItem.Name = "byDateToolStripMenuItem";
            this.byDateToolStripMenuItem.Size = new System.Drawing.Size(180, 22);
            this.byDateToolStripMenuItem.Text = "Semua Tanggal";
            this.byDateToolStripMenuItem.Click += new System.EventHandler(this.byDateToolStripMenuItem_Click);
            // 
            // justThisOneToolStripMenuItem
            // 
            this.justThisOneToolStripMenuItem.Name = "justThisOneToolStripMenuItem";
            this.justThisOneToolStripMenuItem.Size = new System.Drawing.Size(180, 22);
            this.justThisOneToolStripMenuItem.Text = "Semua Kode Barang";
            this.justThisOneToolStripMenuItem.Click += new System.EventHandler(this.justThisOneToolStripMenuItem_Click);
            // 
            // btn_tambah
            // 
            this.btn_tambah.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btn_tambah.AutoSize = true;
            this.btn_tambah.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.btn_tambah.Depth = 0;
            this.btn_tambah.Icon = null;
            this.btn_tambah.Location = new System.Drawing.Point(628, 80);
            this.btn_tambah.MouseState = MaterialSkin.MouseState.HOVER;
            this.btn_tambah.Name = "btn_tambah";
            this.btn_tambah.Primary = true;
            this.btn_tambah.Size = new System.Drawing.Size(117, 36);
            this.btn_tambah.TabIndex = 1;
            this.btn_tambah.Text = "Tambah Data";
            this.btn_tambah.UseVisualStyleBackColor = true;
            this.btn_tambah.Click += new System.EventHandler(this.btn_tambah_Click);
            // 
            // materialFlatButton1
            // 
            this.materialFlatButton1.AutoSize = true;
            this.materialFlatButton1.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.materialFlatButton1.Depth = 0;
            this.materialFlatButton1.Icon = null;
            this.materialFlatButton1.Location = new System.Drawing.Point(13, 80);
            this.materialFlatButton1.Margin = new System.Windows.Forms.Padding(4, 6, 4, 6);
            this.materialFlatButton1.MouseState = MaterialSkin.MouseState.HOVER;
            this.materialFlatButton1.Name = "materialFlatButton1";
            this.materialFlatButton1.Primary = false;
            this.materialFlatButton1.Size = new System.Drawing.Size(177, 36);
            this.materialFlatButton1.TabIndex = 2;
            this.materialFlatButton1.Text = "Tambah Jenis Barang";
            this.materialFlatButton1.UseVisualStyleBackColor = true;
            this.materialFlatButton1.Click += new System.EventHandler(this.materialFlatButton1_Click);
            // 
            // GudangForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(757, 488);
            this.Controls.Add(this.materialFlatButton1);
            this.Controls.Add(this.btn_tambah);
            this.Controls.Add(this.listGudang);
            this.Name = "GudangForm";
            this.Text = "Form Gudang";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.cmsGudang.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private MaterialListView listGudang;
        private ColumnHeader Nomor;
        private ColumnHeader Tanggal;
        private ColumnHeader KodeBarang;
        private ColumnHeader NamaBarang;
        private ColumnHeader BarangMasuk;
        private ColumnHeader HargaSatuan;
        private ColumnHeader Supplier;
        private ColumnHeader Keterangan;
        private MaterialRaisedButton btn_tambah;
        private MaterialContextMenuStrip cmsGudang;
        private ToolStripMenuItem editToolStripMenuItem;
        private ToolStripMenuItem deleteToolStripMenuItem;
        private ToolStripMenuItem byKodeBarangToolStripMenuItem;
        private ToolStripMenuItem byDateToolStripMenuItem;
        private ToolStripMenuItem justThisOneToolStripMenuItem;
        private MaterialFlatButton materialFlatButton1;









    }
}