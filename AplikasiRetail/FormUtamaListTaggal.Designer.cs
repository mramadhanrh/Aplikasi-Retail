namespace AplikasiRetail
{
    partial class FormUtamaListTaggal
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
            this.ListUtamaTanggal = new MaterialSkin.Controls.MaterialListView();
            this.No = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.Tanggal = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.cmbBulan = new System.Windows.Forms.ComboBox();
            this.btnSearch = new MaterialSkin.Controls.MaterialFlatButton();
            this.cmbTahun = new System.Windows.Forms.ComboBox();
            this.btnReset = new MaterialSkin.Controls.MaterialRaisedButton();
            this.ctxListTgl = new MaterialSkin.Controls.MaterialContextMenuStrip();
            this.openToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.ctxListTgl.SuspendLayout();
            this.SuspendLayout();
            // 
            // ListUtamaTanggal
            // 
            this.ListUtamaTanggal.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.ListUtamaTanggal.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.ListUtamaTanggal.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.No,
            this.Tanggal});
            this.ListUtamaTanggal.ContextMenuStrip = this.ctxListTgl;
            this.ListUtamaTanggal.Depth = 0;
            this.ListUtamaTanggal.Font = new System.Drawing.Font("Roboto", 32F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.World);
            this.ListUtamaTanggal.FullRowSelect = true;
            this.ListUtamaTanggal.HeaderStyle = System.Windows.Forms.ColumnHeaderStyle.Nonclickable;
            this.ListUtamaTanggal.Location = new System.Drawing.Point(12, 125);
            this.ListUtamaTanggal.MouseLocation = new System.Drawing.Point(-1, -1);
            this.ListUtamaTanggal.MouseState = MaterialSkin.MouseState.OUT;
            this.ListUtamaTanggal.Name = "ListUtamaTanggal";
            this.ListUtamaTanggal.OwnerDraw = true;
            this.ListUtamaTanggal.Size = new System.Drawing.Size(676, 218);
            this.ListUtamaTanggal.TabIndex = 0;
            this.ListUtamaTanggal.UseCompatibleStateImageBehavior = false;
            this.ListUtamaTanggal.View = System.Windows.Forms.View.Details;
            // 
            // No
            // 
            this.No.Text = "No.";
            this.No.Width = 100;
            // 
            // Tanggal
            // 
            this.Tanggal.Text = "Tanggal";
            this.Tanggal.Width = 700;
            // 
            // cmbBulan
            // 
            this.cmbBulan.FormattingEnabled = true;
            this.cmbBulan.Items.AddRange(new object[] {
            "Januari",
            "Febuari",
            "Maret",
            "April",
            "Mei",
            "Juni",
            "Juli",
            "Agustus",
            "September",
            "Oktober",
            "November",
            "Desember"});
            this.cmbBulan.Location = new System.Drawing.Point(12, 70);
            this.cmbBulan.Name = "cmbBulan";
            this.cmbBulan.Size = new System.Drawing.Size(121, 21);
            this.cmbBulan.TabIndex = 2;
            this.cmbBulan.Text = "[Bulan]";
            // 
            // btnSearch
            // 
            this.btnSearch.AutoSize = true;
            this.btnSearch.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.btnSearch.Depth = 0;
            this.btnSearch.Icon = null;
            this.btnSearch.Location = new System.Drawing.Point(140, 77);
            this.btnSearch.Margin = new System.Windows.Forms.Padding(4, 6, 4, 6);
            this.btnSearch.MouseState = MaterialSkin.MouseState.HOVER;
            this.btnSearch.Name = "btnSearch";
            this.btnSearch.Primary = false;
            this.btnSearch.Size = new System.Drawing.Size(39, 36);
            this.btnSearch.TabIndex = 3;
            this.btnSearch.Text = "OK";
            this.btnSearch.UseVisualStyleBackColor = true;
            this.btnSearch.Click += new System.EventHandler(this.btnSearch_Click);
            // 
            // cmbTahun
            // 
            this.cmbTahun.FormattingEnabled = true;
            this.cmbTahun.Location = new System.Drawing.Point(12, 97);
            this.cmbTahun.Name = "cmbTahun";
            this.cmbTahun.Size = new System.Drawing.Size(121, 21);
            this.cmbTahun.TabIndex = 4;
            this.cmbTahun.Text = "[Tahun]";
            // 
            // btnReset
            // 
            this.btnReset.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btnReset.AutoSize = true;
            this.btnReset.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.btnReset.Depth = 0;
            this.btnReset.Icon = null;
            this.btnReset.Location = new System.Drawing.Point(540, 77);
            this.btnReset.MouseState = MaterialSkin.MouseState.HOVER;
            this.btnReset.Name = "btnReset";
            this.btnReset.Primary = true;
            this.btnReset.Size = new System.Drawing.Size(148, 36);
            this.btnReset.TabIndex = 5;
            this.btnReset.Text = "Tampilkan Semua";
            this.btnReset.UseVisualStyleBackColor = true;
            this.btnReset.Click += new System.EventHandler(this.btnReset_Click);
            // 
            // ctxListTgl
            // 
            this.ctxListTgl.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.ctxListTgl.Depth = 0;
            this.ctxListTgl.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.openToolStripMenuItem});
            this.ctxListTgl.MouseState = MaterialSkin.MouseState.HOVER;
            this.ctxListTgl.Name = "ctxListTgl";
            this.ctxListTgl.Size = new System.Drawing.Size(153, 48);
            // 
            // openToolStripMenuItem
            // 
            this.openToolStripMenuItem.Name = "openToolStripMenuItem";
            this.openToolStripMenuItem.Size = new System.Drawing.Size(152, 22);
            this.openToolStripMenuItem.Text = "Open";
            this.openToolStripMenuItem.Click += new System.EventHandler(this.openToolStripMenuItem_Click);
            // 
            // FormUtamaListTaggal
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(700, 355);
            this.Controls.Add(this.btnReset);
            this.Controls.Add(this.cmbTahun);
            this.Controls.Add(this.btnSearch);
            this.Controls.Add(this.cmbBulan);
            this.Controls.Add(this.ListUtamaTanggal);
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "FormUtamaListTaggal";
            this.Sizable = false;
            this.Text = "Form Utama Berdasarkan Tanggal";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.ctxListTgl.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private MaterialSkin.Controls.MaterialListView ListUtamaTanggal;
        private System.Windows.Forms.ColumnHeader No;
        private System.Windows.Forms.ColumnHeader Tanggal;
        private System.Windows.Forms.ComboBox cmbBulan;
        private MaterialSkin.Controls.MaterialFlatButton btnSearch;
        private System.Windows.Forms.ComboBox cmbTahun;
        private MaterialSkin.Controls.MaterialRaisedButton btnReset;
        private MaterialSkin.Controls.MaterialContextMenuStrip ctxListTgl;
        private System.Windows.Forms.ToolStripMenuItem openToolStripMenuItem;
    }
}