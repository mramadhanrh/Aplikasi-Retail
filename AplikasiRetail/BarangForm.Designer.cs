namespace AplikasiRetail
{
    partial class BarangForm
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
            this.listBarang = new MaterialSkin.Controls.MaterialListView();
            this.Nomor = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.KodeBarang = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.NamaBarang = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.btnTambah = new MaterialSkin.Controls.MaterialRaisedButton();
            this.cmsListBarang = new MaterialSkin.Controls.MaterialContextMenuStrip();
            this.editToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.deleteToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.cmsListBarang.SuspendLayout();
            this.SuspendLayout();
            // 
            // listBarang
            // 
            this.listBarang.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.listBarang.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.listBarang.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.Nomor,
            this.KodeBarang,
            this.NamaBarang});
            this.listBarang.ContextMenuStrip = this.cmsListBarang;
            this.listBarang.Depth = 0;
            this.listBarang.Font = new System.Drawing.Font("Roboto", 32F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.World);
            this.listBarang.FullRowSelect = true;
            this.listBarang.HeaderStyle = System.Windows.Forms.ColumnHeaderStyle.Nonclickable;
            this.listBarang.Location = new System.Drawing.Point(12, 123);
            this.listBarang.MouseLocation = new System.Drawing.Point(-1, -1);
            this.listBarang.MouseState = MaterialSkin.MouseState.OUT;
            this.listBarang.Name = "listBarang";
            this.listBarang.OwnerDraw = true;
            this.listBarang.Size = new System.Drawing.Size(575, 165);
            this.listBarang.TabIndex = 0;
            this.listBarang.UseCompatibleStateImageBehavior = false;
            this.listBarang.View = System.Windows.Forms.View.Details;
            // 
            // Nomor
            // 
            this.Nomor.Text = "No.";
            // 
            // KodeBarang
            // 
            this.KodeBarang.Text = "Kode Barang";
            this.KodeBarang.Width = 300;
            // 
            // NamaBarang
            // 
            this.NamaBarang.Text = "Nama Barang";
            this.NamaBarang.Width = 300;
            // 
            // btnTambah
            // 
            this.btnTambah.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btnTambah.AutoSize = true;
            this.btnTambah.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.btnTambah.Depth = 0;
            this.btnTambah.Icon = null;
            this.btnTambah.Location = new System.Drawing.Point(451, 81);
            this.btnTambah.MouseState = MaterialSkin.MouseState.HOVER;
            this.btnTambah.Name = "btnTambah";
            this.btnTambah.Primary = true;
            this.btnTambah.Size = new System.Drawing.Size(136, 36);
            this.btnTambah.TabIndex = 1;
            this.btnTambah.Text = "Tambah Barang";
            this.btnTambah.UseVisualStyleBackColor = true;
            this.btnTambah.Click += new System.EventHandler(this.btnTambah_Click);
            // 
            // cmsListBarang
            // 
            this.cmsListBarang.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.cmsListBarang.Depth = 0;
            this.cmsListBarang.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.editToolStripMenuItem,
            this.deleteToolStripMenuItem});
            this.cmsListBarang.MouseState = MaterialSkin.MouseState.HOVER;
            this.cmsListBarang.Name = "cmsListBarang";
            this.cmsListBarang.Size = new System.Drawing.Size(153, 70);
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
            // BarangForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(599, 300);
            this.Controls.Add(this.btnTambah);
            this.Controls.Add(this.listBarang);
            this.MaximizeBox = false;
            this.Name = "BarangForm";
            this.Sizable = false;
            this.Text = "LIst Barang";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.cmsListBarang.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private MaterialSkin.Controls.MaterialListView listBarang;
        private System.Windows.Forms.ColumnHeader Nomor;
        private System.Windows.Forms.ColumnHeader KodeBarang;
        private System.Windows.Forms.ColumnHeader NamaBarang;
        private MaterialSkin.Controls.MaterialRaisedButton btnTambah;
        private MaterialSkin.Controls.MaterialContextMenuStrip cmsListBarang;
        private System.Windows.Forms.ToolStripMenuItem editToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem deleteToolStripMenuItem;
    }
}