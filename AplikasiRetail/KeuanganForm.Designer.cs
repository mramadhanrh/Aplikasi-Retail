namespace AplikasiRetail
{
    partial class KeuanganForm
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
            this.listKeuangan = new MaterialSkin.Controls.MaterialListView();
            this.materialRaisedButton1 = new MaterialSkin.Controls.MaterialRaisedButton();
            this.Nomor = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.Tanggal = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.KodeRekening = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.UangMasuk = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.UangKeluar = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.Total = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.ctxKeuangan = new MaterialSkin.Controls.MaterialContextMenuStrip();
            this.editToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.deleteToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.ctxKeuangan.SuspendLayout();
            this.SuspendLayout();
            // 
            // listKeuangan
            // 
            this.listKeuangan.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.listKeuangan.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.listKeuangan.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.Nomor,
            this.Tanggal,
            this.KodeRekening,
            this.UangMasuk,
            this.UangKeluar,
            this.Total});
            this.listKeuangan.ContextMenuStrip = this.ctxKeuangan;
            this.listKeuangan.Depth = 0;
            this.listKeuangan.Font = new System.Drawing.Font("Roboto", 32F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.World);
            this.listKeuangan.FullRowSelect = true;
            this.listKeuangan.HeaderStyle = System.Windows.Forms.ColumnHeaderStyle.Nonclickable;
            this.listKeuangan.Location = new System.Drawing.Point(12, 119);
            this.listKeuangan.MouseLocation = new System.Drawing.Point(-1, -1);
            this.listKeuangan.MouseState = MaterialSkin.MouseState.OUT;
            this.listKeuangan.Name = "listKeuangan";
            this.listKeuangan.OwnerDraw = true;
            this.listKeuangan.Size = new System.Drawing.Size(631, 200);
            this.listKeuangan.TabIndex = 0;
            this.listKeuangan.UseCompatibleStateImageBehavior = false;
            this.listKeuangan.View = System.Windows.Forms.View.Details;
            // 
            // materialRaisedButton1
            // 
            this.materialRaisedButton1.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.materialRaisedButton1.AutoSize = true;
            this.materialRaisedButton1.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.materialRaisedButton1.Depth = 0;
            this.materialRaisedButton1.Icon = null;
            this.materialRaisedButton1.Location = new System.Drawing.Point(526, 77);
            this.materialRaisedButton1.MouseState = MaterialSkin.MouseState.HOVER;
            this.materialRaisedButton1.Name = "materialRaisedButton1";
            this.materialRaisedButton1.Primary = true;
            this.materialRaisedButton1.Size = new System.Drawing.Size(117, 36);
            this.materialRaisedButton1.TabIndex = 1;
            this.materialRaisedButton1.Text = "Tambah Data";
            this.materialRaisedButton1.UseVisualStyleBackColor = true;
            this.materialRaisedButton1.Click += new System.EventHandler(this.materialRaisedButton1_Click);
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
            // KodeRekening
            // 
            this.KodeRekening.Text = "Kode Rekening";
            this.KodeRekening.Width = 140;
            // 
            // UangMasuk
            // 
            this.UangMasuk.Text = "Uang Masuk";
            this.UangMasuk.Width = 120;
            // 
            // UangKeluar
            // 
            this.UangKeluar.Text = "Uang Keluar";
            this.UangKeluar.Width = 120;
            // 
            // Total
            // 
            this.Total.Text = "Total";
            this.Total.Width = 120;
            // 
            // ctxKeuangan
            // 
            this.ctxKeuangan.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.ctxKeuangan.Depth = 0;
            this.ctxKeuangan.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.editToolStripMenuItem,
            this.deleteToolStripMenuItem});
            this.ctxKeuangan.MouseState = MaterialSkin.MouseState.HOVER;
            this.ctxKeuangan.Name = "ctxKeuangan";
            this.ctxKeuangan.Size = new System.Drawing.Size(153, 70);
            // 
            // editToolStripMenuItem
            // 
            this.editToolStripMenuItem.Name = "editToolStripMenuItem";
            this.editToolStripMenuItem.Size = new System.Drawing.Size(152, 22);
            this.editToolStripMenuItem.Text = "Edit";
            this.editToolStripMenuItem.Click += new System.EventHandler(this.editToolStripMenuItem_Click);
            // 
            // deleteToolStripMenuItem
            // 
            this.deleteToolStripMenuItem.Name = "deleteToolStripMenuItem";
            this.deleteToolStripMenuItem.Size = new System.Drawing.Size(152, 22);
            this.deleteToolStripMenuItem.Text = "Delete";
            this.deleteToolStripMenuItem.Click += new System.EventHandler(this.deleteToolStripMenuItem_Click);
            // 
            // KeuanganForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(655, 331);
            this.Controls.Add(this.materialRaisedButton1);
            this.Controls.Add(this.listKeuangan);
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "KeuanganForm";
            this.Sizable = false;
            this.Text = "KeuanganForm";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.ctxKeuangan.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private MaterialSkin.Controls.MaterialListView listKeuangan;
        private System.Windows.Forms.ColumnHeader Nomor;
        private System.Windows.Forms.ColumnHeader Tanggal;
        private System.Windows.Forms.ColumnHeader KodeRekening;
        private System.Windows.Forms.ColumnHeader UangMasuk;
        private System.Windows.Forms.ColumnHeader UangKeluar;
        private System.Windows.Forms.ColumnHeader Total;
        private MaterialSkin.Controls.MaterialRaisedButton materialRaisedButton1;
        private MaterialSkin.Controls.MaterialContextMenuStrip ctxKeuangan;
        private System.Windows.Forms.ToolStripMenuItem editToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem deleteToolStripMenuItem;
    }
}