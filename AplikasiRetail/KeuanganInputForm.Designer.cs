namespace AplikasiRetail
{
    partial class KeuanganInputForm
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
            this.tb_Rekening = new PlaceholderTextBox.PlaceholderTextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.materialRaisedButton1 = new MaterialSkin.Controls.MaterialRaisedButton();
            this.numUangMasuk = new PlaceholderTextBox.PlaceholderTextBox();
            this.numUangKeluar = new PlaceholderTextBox.PlaceholderTextBox();
            this.SuspendLayout();
            // 
            // tb_Rekening
            // 
            this.tb_Rekening.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.tb_Rekening.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tb_Rekening.Location = new System.Drawing.Point(12, 107);
            this.tb_Rekening.Name = "tb_Rekening";
            this.tb_Rekening.PlaceholderText = "No Rekening";
            this.tb_Rekening.Size = new System.Drawing.Size(406, 20);
            this.tb_Rekening.TabIndex = 0;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Roboto", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(12, 84);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(98, 20);
            this.label1.TabIndex = 1;
            this.label1.Text = "No Rekening";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Roboto", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(12, 149);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(98, 20);
            this.label2.TabIndex = 5;
            this.label2.Text = "Uang Masuk";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Roboto", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(218, 149);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(95, 20);
            this.label3.TabIndex = 6;
            this.label3.Text = "Uang Keluar";
            // 
            // materialRaisedButton1
            // 
            this.materialRaisedButton1.AutoSize = true;
            this.materialRaisedButton1.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.materialRaisedButton1.Depth = 0;
            this.materialRaisedButton1.Icon = null;
            this.materialRaisedButton1.Location = new System.Drawing.Point(347, 217);
            this.materialRaisedButton1.MouseState = MaterialSkin.MouseState.HOVER;
            this.materialRaisedButton1.Name = "materialRaisedButton1";
            this.materialRaisedButton1.Primary = true;
            this.materialRaisedButton1.Size = new System.Drawing.Size(71, 36);
            this.materialRaisedButton1.TabIndex = 7;
            this.materialRaisedButton1.Text = "Submit";
            this.materialRaisedButton1.UseVisualStyleBackColor = true;
            this.materialRaisedButton1.Click += new System.EventHandler(this.materialRaisedButton1_Click);
            // 
            // numUangMasuk
            // 
            this.numUangMasuk.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.numUangMasuk.Location = new System.Drawing.Point(12, 172);
            this.numUangMasuk.Name = "numUangMasuk";
            this.numUangMasuk.PlaceholderText = "Uang Masuk";
            this.numUangMasuk.Size = new System.Drawing.Size(194, 20);
            this.numUangMasuk.TabIndex = 8;
            this.numUangMasuk.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.numUangMasuk_KeyPress);
            // 
            // numUangKeluar
            // 
            this.numUangKeluar.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.numUangKeluar.Location = new System.Drawing.Point(217, 172);
            this.numUangKeluar.Name = "numUangKeluar";
            this.numUangKeluar.PlaceholderText = "Uang Masuk";
            this.numUangKeluar.Size = new System.Drawing.Size(201, 20);
            this.numUangKeluar.TabIndex = 9;
            this.numUangKeluar.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.numUangKeluar_KeyPress);
            // 
            // KeuanganInputForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(430, 275);
            this.Controls.Add(this.numUangKeluar);
            this.Controls.Add(this.numUangMasuk);
            this.Controls.Add(this.materialRaisedButton1);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.tb_Rekening);
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "KeuanganInputForm";
            this.Sizable = false;
            this.Text = "Masukan Data Baru";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private PlaceholderTextBox.PlaceholderTextBox tb_Rekening;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private MaterialSkin.Controls.MaterialRaisedButton materialRaisedButton1;
        private PlaceholderTextBox.PlaceholderTextBox numUangMasuk;
        private PlaceholderTextBox.PlaceholderTextBox numUangKeluar;
    }
}