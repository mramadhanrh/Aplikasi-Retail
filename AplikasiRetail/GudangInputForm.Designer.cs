namespace AplikasiRetail
{
    partial class GudangInputForm
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
            this.cmbKodeBarang = new System.Windows.Forms.ComboBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.numBarangMasuk = new System.Windows.Forms.NumericUpDown();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.tbNamaBarang = new PlaceholderTextBox.PlaceholderTextBox();
            this.tbHargaSatuan = new PlaceholderTextBox.PlaceholderTextBox();
            this.cmbSupplier = new System.Windows.Forms.ComboBox();
            this.label6 = new System.Windows.Forms.Label();
            this.tbKeterangan = new PlaceholderTextBox.PlaceholderTextBox();
            this.btn_submit = new MaterialSkin.Controls.MaterialRaisedButton();
            this.btn_cancel = new MaterialSkin.Controls.MaterialFlatButton();
            ((System.ComponentModel.ISupportInitialize)(this.numBarangMasuk)).BeginInit();
            this.SuspendLayout();
            // 
            // cmbKodeBarang
            // 
            this.cmbKodeBarang.FormattingEnabled = true;
            this.cmbKodeBarang.Location = new System.Drawing.Point(12, 101);
            this.cmbKodeBarang.Name = "cmbKodeBarang";
            this.cmbKodeBarang.Size = new System.Drawing.Size(121, 21);
            this.cmbKodeBarang.TabIndex = 0;
            this.cmbKodeBarang.Text = "[Kode Barang]";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Roboto", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(12, 76);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(100, 20);
            this.label1.TabIndex = 1;
            this.label1.Text = "Kode Barang";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Roboto", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(152, 76);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(107, 20);
            this.label2.TabIndex = 2;
            this.label2.Text = "Nama Barang";
            // 
            // numBarangMasuk
            // 
            this.numBarangMasuk.Location = new System.Drawing.Point(12, 153);
            this.numBarangMasuk.Name = "numBarangMasuk";
            this.numBarangMasuk.Size = new System.Drawing.Size(120, 20);
            this.numBarangMasuk.TabIndex = 4;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Roboto", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(12, 130);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(112, 20);
            this.label3.TabIndex = 5;
            this.label3.Text = "Barang Masuk";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Roboto", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(152, 130);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(106, 20);
            this.label4.TabIndex = 7;
            this.label4.Text = "Harga Satuan";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Roboto", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(357, 130);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(66, 20);
            this.label5.TabIndex = 8;
            this.label5.Text = "Supplier";
            // 
            // tbNamaBarang
            // 
            this.tbNamaBarang.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tbNamaBarang.Location = new System.Drawing.Point(153, 102);
            this.tbNamaBarang.Name = "tbNamaBarang";
            this.tbNamaBarang.PlaceholderText = "Nama Barang : Baju Raglan";
            this.tbNamaBarang.Size = new System.Drawing.Size(380, 20);
            this.tbNamaBarang.TabIndex = 10;
            // 
            // tbHargaSatuan
            // 
            this.tbHargaSatuan.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tbHargaSatuan.Location = new System.Drawing.Point(153, 154);
            this.tbHargaSatuan.Name = "tbHargaSatuan";
            this.tbHargaSatuan.PlaceholderText = "Harga Satuan : 5000";
            this.tbHargaSatuan.Size = new System.Drawing.Size(181, 20);
            this.tbHargaSatuan.TabIndex = 11;
            // 
            // cmbSupplier
            // 
            this.cmbSupplier.FormattingEnabled = true;
            this.cmbSupplier.Location = new System.Drawing.Point(356, 154);
            this.cmbSupplier.Name = "cmbSupplier";
            this.cmbSupplier.Size = new System.Drawing.Size(177, 21);
            this.cmbSupplier.TabIndex = 12;
            this.cmbSupplier.Text = "[Supplier : CV.Sentosa]";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Roboto", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.Location = new System.Drawing.Point(12, 179);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(90, 20);
            this.label6.TabIndex = 14;
            this.label6.Text = "Keterangan";
            // 
            // tbKeterangan
            // 
            this.tbKeterangan.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tbKeterangan.Location = new System.Drawing.Point(12, 202);
            this.tbKeterangan.Multiline = true;
            this.tbKeterangan.Name = "tbKeterangan";
            this.tbKeterangan.PlaceholderText = "Keterangan";
            this.tbKeterangan.Size = new System.Drawing.Size(521, 104);
            this.tbKeterangan.TabIndex = 15;
            // 
            // btn_submit
            // 
            this.btn_submit.AutoSize = true;
            this.btn_submit.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.btn_submit.Depth = 0;
            this.btn_submit.Icon = null;
            this.btn_submit.Location = new System.Drawing.Point(462, 312);
            this.btn_submit.MouseState = MaterialSkin.MouseState.HOVER;
            this.btn_submit.Name = "btn_submit";
            this.btn_submit.Primary = true;
            this.btn_submit.Size = new System.Drawing.Size(71, 36);
            this.btn_submit.TabIndex = 16;
            this.btn_submit.Text = "Submit";
            this.btn_submit.UseVisualStyleBackColor = true;
            this.btn_submit.Click += new System.EventHandler(this.btn_submit_Click);
            // 
            // btn_cancel
            // 
            this.btn_cancel.AutoSize = true;
            this.btn_cancel.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.btn_cancel.Depth = 0;
            this.btn_cancel.Icon = null;
            this.btn_cancel.Location = new System.Drawing.Point(13, 311);
            this.btn_cancel.Margin = new System.Windows.Forms.Padding(4, 6, 4, 6);
            this.btn_cancel.MouseState = MaterialSkin.MouseState.HOVER;
            this.btn_cancel.Name = "btn_cancel";
            this.btn_cancel.Primary = false;
            this.btn_cancel.Size = new System.Drawing.Size(73, 36);
            this.btn_cancel.TabIndex = 17;
            this.btn_cancel.Text = "Cancel";
            this.btn_cancel.UseVisualStyleBackColor = true;
            this.btn_cancel.Click += new System.EventHandler(this.btn_cancel_Click);
            // 
            // GudangInputForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(548, 362);
            this.Controls.Add(this.btn_cancel);
            this.Controls.Add(this.btn_submit);
            this.Controls.Add(this.tbKeterangan);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.cmbSupplier);
            this.Controls.Add(this.tbHargaSatuan);
            this.Controls.Add(this.tbNamaBarang);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.numBarangMasuk);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.cmbKodeBarang);
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "GudangInputForm";
            this.Sizable = false;
            this.Text = "Tambah Barang Gudang";
            ((System.ComponentModel.ISupportInitialize)(this.numBarangMasuk)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ComboBox cmbKodeBarang;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.NumericUpDown numBarangMasuk;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private PlaceholderTextBox.PlaceholderTextBox tbNamaBarang;
        private PlaceholderTextBox.PlaceholderTextBox tbHargaSatuan;
        private System.Windows.Forms.ComboBox cmbSupplier;
        private System.Windows.Forms.Label label6;
        private PlaceholderTextBox.PlaceholderTextBox tbKeterangan;
        private MaterialSkin.Controls.MaterialRaisedButton btn_submit;
        private MaterialSkin.Controls.MaterialFlatButton btn_cancel;
    }
}