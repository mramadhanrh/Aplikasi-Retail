namespace AplikasiRetail
{
    partial class KasirInputForm
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
            this.placeholderTextBox1 = new PlaceholderTextBox.PlaceholderTextBox();
            this.listItemBarang = new MaterialSkin.Controls.MaterialListView();
            this.Nomor = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.KodeBarang = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.NamaBarang = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.HargaSatuan = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.Stok = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.btnSubmit = new MaterialSkin.Controls.MaterialRaisedButton();
            this.btnCancel = new MaterialSkin.Controls.MaterialFlatButton();
            this.SuspendLayout();
            // 
            // placeholderTextBox1
            // 
            this.placeholderTextBox1.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.placeholderTextBox1.Location = new System.Drawing.Point(12, 80);
            this.placeholderTextBox1.Name = "placeholderTextBox1";
            this.placeholderTextBox1.PlaceholderText = "Masukan Nama Barang : Baju Raglan";
            this.placeholderTextBox1.Size = new System.Drawing.Size(788, 20);
            this.placeholderTextBox1.TabIndex = 0;
            this.placeholderTextBox1.TextChanged += new System.EventHandler(this.placeholderTextBox1_TextChanged);
            // 
            // listItemBarang
            // 
            this.listItemBarang.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.listItemBarang.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.listItemBarang.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.Nomor,
            this.KodeBarang,
            this.NamaBarang,
            this.HargaSatuan,
            this.Stok});
            this.listItemBarang.Depth = 0;
            this.listItemBarang.Font = new System.Drawing.Font("Roboto", 32F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.World);
            this.listItemBarang.FullRowSelect = true;
            this.listItemBarang.HeaderStyle = System.Windows.Forms.ColumnHeaderStyle.Nonclickable;
            this.listItemBarang.Location = new System.Drawing.Point(12, 106);
            this.listItemBarang.MouseLocation = new System.Drawing.Point(-1, -1);
            this.listItemBarang.MouseState = MaterialSkin.MouseState.OUT;
            this.listItemBarang.Name = "listItemBarang";
            this.listItemBarang.OwnerDraw = true;
            this.listItemBarang.Size = new System.Drawing.Size(788, 300);
            this.listItemBarang.TabIndex = 1;
            this.listItemBarang.UseCompatibleStateImageBehavior = false;
            this.listItemBarang.View = System.Windows.Forms.View.Details;
            // 
            // Nomor
            // 
            this.Nomor.Text = "No.";
            // 
            // KodeBarang
            // 
            this.KodeBarang.Text = "Kode Barang";
            this.KodeBarang.Width = 180;
            // 
            // NamaBarang
            // 
            this.NamaBarang.Text = "Nama Barang";
            this.NamaBarang.Width = 220;
            // 
            // HargaSatuan
            // 
            this.HargaSatuan.Text = "Harga Satuan";
            this.HargaSatuan.Width = 180;
            // 
            // Stok
            // 
            this.Stok.Text = "Sisa Stok";
            this.Stok.Width = 120;
            // 
            // btnSubmit
            // 
            this.btnSubmit.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.btnSubmit.AutoSize = true;
            this.btnSubmit.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.btnSubmit.Depth = 0;
            this.btnSubmit.Icon = null;
            this.btnSubmit.Location = new System.Drawing.Point(729, 412);
            this.btnSubmit.MouseState = MaterialSkin.MouseState.HOVER;
            this.btnSubmit.Name = "btnSubmit";
            this.btnSubmit.Primary = true;
            this.btnSubmit.Size = new System.Drawing.Size(71, 36);
            this.btnSubmit.TabIndex = 2;
            this.btnSubmit.Text = "Submit";
            this.btnSubmit.UseVisualStyleBackColor = true;
            this.btnSubmit.Click += new System.EventHandler(this.btnSubmit_Click);
            // 
            // btnCancel
            // 
            this.btnCancel.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left)));
            this.btnCancel.AutoSize = true;
            this.btnCancel.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.btnCancel.Depth = 0;
            this.btnCancel.Icon = null;
            this.btnCancel.Location = new System.Drawing.Point(13, 415);
            this.btnCancel.Margin = new System.Windows.Forms.Padding(4, 6, 4, 6);
            this.btnCancel.MouseState = MaterialSkin.MouseState.HOVER;
            this.btnCancel.Name = "btnCancel";
            this.btnCancel.Primary = false;
            this.btnCancel.Size = new System.Drawing.Size(73, 36);
            this.btnCancel.TabIndex = 3;
            this.btnCancel.Text = "Cancel";
            this.btnCancel.UseVisualStyleBackColor = true;
            this.btnCancel.Click += new System.EventHandler(this.btnCancel_Click);
            // 
            // KasirInputForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(812, 460);
            this.Controls.Add(this.btnCancel);
            this.Controls.Add(this.btnSubmit);
            this.Controls.Add(this.listItemBarang);
            this.Controls.Add(this.placeholderTextBox1);
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "KasirInputForm";
            this.Sizable = false;
            this.Text = "KasirInputForm";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private PlaceholderTextBox.PlaceholderTextBox placeholderTextBox1;
        private MaterialSkin.Controls.MaterialListView listItemBarang;
        private System.Windows.Forms.ColumnHeader Nomor;
        private System.Windows.Forms.ColumnHeader NamaBarang;
        private System.Windows.Forms.ColumnHeader HargaSatuan;
        private System.Windows.Forms.ColumnHeader Stok;
        private MaterialSkin.Controls.MaterialRaisedButton btnSubmit;
        private MaterialSkin.Controls.MaterialFlatButton btnCancel;
        private System.Windows.Forms.ColumnHeader KodeBarang;
    }
}