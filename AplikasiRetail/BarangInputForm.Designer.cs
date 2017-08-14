namespace AplikasiRetail
{
    partial class BarangInputForm
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
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.btnSubmit = new MaterialSkin.Controls.MaterialRaisedButton();
            this.btnCancel = new MaterialSkin.Controls.MaterialFlatButton();
            this.btnPrint = new MaterialSkin.Controls.MaterialRaisedButton();
            this.tbKodeBarang = new MaterialSkin.Controls.MaterialSingleLineTextField();
            this.tbNamaBarang = new MaterialSkin.Controls.MaterialSingleLineTextField();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Roboto", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(12, 80);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(100, 20);
            this.label1.TabIndex = 1;
            this.label1.Text = "Kode Barang";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Roboto", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(12, 131);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(107, 20);
            this.label2.TabIndex = 3;
            this.label2.Text = "Nama Barang";
            // 
            // btnSubmit
            // 
            this.btnSubmit.AutoSize = true;
            this.btnSubmit.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.btnSubmit.Depth = 0;
            this.btnSubmit.Icon = null;
            this.btnSubmit.Location = new System.Drawing.Point(201, 183);
            this.btnSubmit.MouseState = MaterialSkin.MouseState.HOVER;
            this.btnSubmit.Name = "btnSubmit";
            this.btnSubmit.Primary = true;
            this.btnSubmit.Size = new System.Drawing.Size(71, 36);
            this.btnSubmit.TabIndex = 5;
            this.btnSubmit.Text = "Submit";
            this.btnSubmit.UseVisualStyleBackColor = true;
            this.btnSubmit.Click += new System.EventHandler(this.btnSubmit_Click);
            // 
            // btnCancel
            // 
            this.btnCancel.AutoSize = true;
            this.btnCancel.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.btnCancel.Depth = 0;
            this.btnCancel.Icon = null;
            this.btnCancel.Location = new System.Drawing.Point(12, 183);
            this.btnCancel.Margin = new System.Windows.Forms.Padding(4, 6, 4, 6);
            this.btnCancel.MouseState = MaterialSkin.MouseState.HOVER;
            this.btnCancel.Name = "btnCancel";
            this.btnCancel.Primary = false;
            this.btnCancel.Size = new System.Drawing.Size(73, 36);
            this.btnCancel.TabIndex = 6;
            this.btnCancel.Text = "Cancel";
            this.btnCancel.UseVisualStyleBackColor = true;
            this.btnCancel.Click += new System.EventHandler(this.btnCancel_Click);
            // 
            // btnPrint
            // 
            this.btnPrint.AutoSize = true;
            this.btnPrint.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.btnPrint.Depth = 0;
            this.btnPrint.Icon = null;
            this.btnPrint.Location = new System.Drawing.Point(135, 183);
            this.btnPrint.MouseState = MaterialSkin.MouseState.HOVER;
            this.btnPrint.Name = "btnPrint";
            this.btnPrint.Primary = true;
            this.btnPrint.Size = new System.Drawing.Size(60, 36);
            this.btnPrint.TabIndex = 7;
            this.btnPrint.Text = "Print";
            this.btnPrint.UseVisualStyleBackColor = true;
            this.btnPrint.Click += new System.EventHandler(this.btnPrint_Click);
            // 
            // tbKodeBarang
            // 
            this.tbKodeBarang.Depth = 0;
            this.tbKodeBarang.Hint = "Kode Barang";
            this.tbKodeBarang.Location = new System.Drawing.Point(12, 103);
            this.tbKodeBarang.MaxLength = 6;
            this.tbKodeBarang.MouseState = MaterialSkin.MouseState.HOVER;
            this.tbKodeBarang.Name = "tbKodeBarang";
            this.tbKodeBarang.PasswordChar = '\0';
            this.tbKodeBarang.SelectedText = "";
            this.tbKodeBarang.SelectionLength = 0;
            this.tbKodeBarang.SelectionStart = 0;
            this.tbKodeBarang.Size = new System.Drawing.Size(260, 23);
            this.tbKodeBarang.TabIndex = 8;
            this.tbKodeBarang.TabStop = false;
            this.tbKodeBarang.UseSystemPasswordChar = false;
            this.tbKodeBarang.TextChanged += new System.EventHandler(this.tbKodeBarang_TextChanged);
            // 
            // tbNamaBarang
            // 
            this.tbNamaBarang.Depth = 0;
            this.tbNamaBarang.Hint = "Nama Barang";
            this.tbNamaBarang.Location = new System.Drawing.Point(12, 154);
            this.tbNamaBarang.MaxLength = 32767;
            this.tbNamaBarang.MouseState = MaterialSkin.MouseState.HOVER;
            this.tbNamaBarang.Name = "tbNamaBarang";
            this.tbNamaBarang.PasswordChar = '\0';
            this.tbNamaBarang.SelectedText = "";
            this.tbNamaBarang.SelectionLength = 0;
            this.tbNamaBarang.SelectionStart = 0;
            this.tbNamaBarang.Size = new System.Drawing.Size(260, 23);
            this.tbNamaBarang.TabIndex = 9;
            this.tbNamaBarang.TabStop = false;
            this.tbNamaBarang.UseSystemPasswordChar = false;
            // 
            // pictureBox1
            // 
            this.pictureBox1.BackColor = System.Drawing.Color.Transparent;
            this.pictureBox1.Location = new System.Drawing.Point(334, 89);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(340, 130);
            this.pictureBox1.TabIndex = 10;
            this.pictureBox1.TabStop = false;
            // 
            // BarangInputForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(686, 256);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.tbNamaBarang);
            this.Controls.Add(this.tbKodeBarang);
            this.Controls.Add(this.btnPrint);
            this.Controls.Add(this.btnCancel);
            this.Controls.Add(this.btnSubmit);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Name = "BarangInputForm";
            this.Text = "Masuk Barang";
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private MaterialSkin.Controls.MaterialRaisedButton btnSubmit;
        private MaterialSkin.Controls.MaterialFlatButton btnCancel;
        private MaterialSkin.Controls.MaterialRaisedButton btnPrint;
        private MaterialSkin.Controls.MaterialSingleLineTextField tbKodeBarang;
        private MaterialSkin.Controls.MaterialSingleLineTextField tbNamaBarang;
        private System.Windows.Forms.PictureBox pictureBox1;

    }
}