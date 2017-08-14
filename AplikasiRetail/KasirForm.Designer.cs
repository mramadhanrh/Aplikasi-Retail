namespace AplikasiRetail
{
    partial class KasirForm
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
            this.btnManual = new MaterialSkin.Controls.MaterialRaisedButton();
            this.listKasir = new MaterialSkin.Controls.MaterialListView();
            this.Nomor = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.Tanggal = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.KodeBarang = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.NamaBarang = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.Volume = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.HargaSatuan = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.Total = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.materialContextMenuStrip1 = new MaterialSkin.Controls.MaterialContextMenuStrip();
            this.deleteToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.label1 = new System.Windows.Forms.Label();
            this.lblTotal = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.lblTanggal = new System.Windows.Forms.Label();
            this.materialRaisedButton1 = new MaterialSkin.Controls.MaterialRaisedButton();
            this.btnCancel = new MaterialSkin.Controls.MaterialFlatButton();
            this.txtbarcode = new System.Windows.Forms.TextBox();
            this.materialContextMenuStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // btnManual
            // 
            this.btnManual.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btnManual.AutoSize = true;
            this.btnManual.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.btnManual.Depth = 0;
            this.btnManual.Icon = null;
            this.btnManual.Location = new System.Drawing.Point(656, 87);
            this.btnManual.MouseState = MaterialSkin.MouseState.HOVER;
            this.btnManual.Name = "btnManual";
            this.btnManual.Primary = true;
            this.btnManual.Size = new System.Drawing.Size(147, 36);
            this.btnManual.TabIndex = 0;
            this.btnManual.Text = "Masukan Manual";
            this.btnManual.UseVisualStyleBackColor = true;
            this.btnManual.Click += new System.EventHandler(this.btnManual_Click);
            // 
            // listKasir
            // 
            this.listKasir.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.listKasir.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.listKasir.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.Nomor,
            this.Tanggal,
            this.KodeBarang,
            this.NamaBarang,
            this.Volume,
            this.HargaSatuan,
            this.Total});
            this.listKasir.ContextMenuStrip = this.materialContextMenuStrip1;
            this.listKasir.Depth = 0;
            this.listKasir.Font = new System.Drawing.Font("Roboto", 32F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.World);
            this.listKasir.FullRowSelect = true;
            this.listKasir.HeaderStyle = System.Windows.Forms.ColumnHeaderStyle.Nonclickable;
            this.listKasir.Location = new System.Drawing.Point(12, 154);
            this.listKasir.MouseLocation = new System.Drawing.Point(-1, -1);
            this.listKasir.MouseState = MaterialSkin.MouseState.OUT;
            this.listKasir.Name = "listKasir";
            this.listKasir.OwnerDraw = true;
            this.listKasir.Size = new System.Drawing.Size(791, 302);
            this.listKasir.TabIndex = 1;
            this.listKasir.UseCompatibleStateImageBehavior = false;
            this.listKasir.View = System.Windows.Forms.View.Details;
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
            this.KodeBarang.Width = 120;
            // 
            // NamaBarang
            // 
            this.NamaBarang.Text = "Nama Barang";
            this.NamaBarang.Width = 220;
            // 
            // Volume
            // 
            this.Volume.Text = "Volume";
            this.Volume.Width = 160;
            // 
            // HargaSatuan
            // 
            this.HargaSatuan.Text = "Harga Satuan";
            this.HargaSatuan.Width = 170;
            // 
            // Total
            // 
            this.Total.Text = "Total";
            this.Total.Width = 120;
            // 
            // materialContextMenuStrip1
            // 
            this.materialContextMenuStrip1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.materialContextMenuStrip1.Depth = 0;
            this.materialContextMenuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.deleteToolStripMenuItem});
            this.materialContextMenuStrip1.MouseState = MaterialSkin.MouseState.HOVER;
            this.materialContextMenuStrip1.Name = "materialContextMenuStrip1";
            this.materialContextMenuStrip1.Size = new System.Drawing.Size(153, 48);
            // 
            // deleteToolStripMenuItem
            // 
            this.deleteToolStripMenuItem.Name = "deleteToolStripMenuItem";
            this.deleteToolStripMenuItem.Size = new System.Drawing.Size(107, 22);
            this.deleteToolStripMenuItem.Text = "Delete";
            this.deleteToolStripMenuItem.Click += new System.EventHandler(this.deleteToolStripMenuItem_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Roboto", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(12, 122);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(58, 20);
            this.label1.TabIndex = 2;
            this.label1.Text = "Total : ";
            // 
            // lblTotal
            // 
            this.lblTotal.AutoSize = true;
            this.lblTotal.Font = new System.Drawing.Font("Roboto", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTotal.Location = new System.Drawing.Point(76, 122);
            this.lblTotal.Name = "lblTotal";
            this.lblTotal.Size = new System.Drawing.Size(93, 20);
            this.lblTotal.TabIndex = 3;
            this.lblTotal.Text = "Rp. 200,000";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Roboto", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(12, 87);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(76, 20);
            this.label2.TabIndex = 4;
            this.label2.Text = "Tanggal :";
            // 
            // lblTanggal
            // 
            this.lblTanggal.AutoSize = true;
            this.lblTanggal.Font = new System.Drawing.Font("Roboto", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTanggal.Location = new System.Drawing.Point(94, 87);
            this.lblTanggal.Name = "lblTanggal";
            this.lblTanggal.Size = new System.Drawing.Size(80, 20);
            this.lblTanggal.TabIndex = 5;
            this.lblTanggal.Text = "8-10-2017";
            // 
            // materialRaisedButton1
            // 
            this.materialRaisedButton1.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.materialRaisedButton1.AutoSize = true;
            this.materialRaisedButton1.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.materialRaisedButton1.Depth = 0;
            this.materialRaisedButton1.Icon = null;
            this.materialRaisedButton1.Location = new System.Drawing.Point(732, 464);
            this.materialRaisedButton1.MouseState = MaterialSkin.MouseState.HOVER;
            this.materialRaisedButton1.Name = "materialRaisedButton1";
            this.materialRaisedButton1.Primary = true;
            this.materialRaisedButton1.Size = new System.Drawing.Size(71, 36);
            this.materialRaisedButton1.TabIndex = 6;
            this.materialRaisedButton1.Text = "Submit";
            this.materialRaisedButton1.UseVisualStyleBackColor = true;
            // 
            // btnCancel
            // 
            this.btnCancel.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.btnCancel.AutoSize = true;
            this.btnCancel.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.btnCancel.Depth = 0;
            this.btnCancel.Icon = null;
            this.btnCancel.Location = new System.Drawing.Point(12, 465);
            this.btnCancel.Margin = new System.Windows.Forms.Padding(4, 6, 4, 6);
            this.btnCancel.MouseState = MaterialSkin.MouseState.HOVER;
            this.btnCancel.Name = "btnCancel";
            this.btnCancel.Primary = false;
            this.btnCancel.Size = new System.Drawing.Size(73, 36);
            this.btnCancel.TabIndex = 7;
            this.btnCancel.Text = "Cancel";
            this.btnCancel.UseVisualStyleBackColor = true;
            this.btnCancel.Click += new System.EventHandler(this.btnCancel_Click);
            // 
            // txtbarcode
            // 
            this.txtbarcode.Location = new System.Drawing.Point(400, 100);
            this.txtbarcode.Name = "txtbarcode";
            this.txtbarcode.Size = new System.Drawing.Size(0, 20);
            this.txtbarcode.TabIndex = 8;
            this.txtbarcode.KeyDown += new System.Windows.Forms.KeyEventHandler(this.txtbarcode_KeyDown);
            this.txtbarcode.Leave += new System.EventHandler(this.txtbarcode_Leave);
            // 
            // KasirForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(815, 512);
            this.Controls.Add(this.txtbarcode);
            this.Controls.Add(this.btnCancel);
            this.Controls.Add(this.materialRaisedButton1);
            this.Controls.Add(this.lblTanggal);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.lblTotal);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.listKasir);
            this.Controls.Add(this.btnManual);
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "KasirForm";
            this.Sizable = false;
            this.Text = "Kasir";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.Load += new System.EventHandler(this.KasirForm_Load);
            this.materialContextMenuStrip1.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private MaterialSkin.Controls.MaterialRaisedButton btnManual;
        private MaterialSkin.Controls.MaterialListView listKasir;
        private System.Windows.Forms.ColumnHeader Nomor;
        private System.Windows.Forms.ColumnHeader Tanggal;
        private System.Windows.Forms.ColumnHeader NamaBarang;
        private System.Windows.Forms.ColumnHeader Volume;
        private System.Windows.Forms.ColumnHeader HargaSatuan;
        private System.Windows.Forms.ColumnHeader Total;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label lblTotal;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label lblTanggal;
        private MaterialSkin.Controls.MaterialRaisedButton materialRaisedButton1;
        private MaterialSkin.Controls.MaterialFlatButton btnCancel;
        private System.Windows.Forms.ColumnHeader KodeBarang;
        private System.Windows.Forms.TextBox txtbarcode;
        private MaterialSkin.Controls.MaterialContextMenuStrip materialContextMenuStrip1;
        private System.Windows.Forms.ToolStripMenuItem deleteToolStripMenuItem;

    }
}