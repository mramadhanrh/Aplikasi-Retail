namespace AplikasiRetail
{
    partial class Login
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
            this.materialRaisedButton1 = new MaterialSkin.Controls.MaterialRaisedButton();
            this.tb_username = new MaterialSkin.Controls.MaterialSingleLineTextField();
            this.tb_password = new MaterialSkin.Controls.MaterialSingleLineTextField();
            this.SuspendLayout();
            // 
            // materialRaisedButton1
            // 
            this.materialRaisedButton1.AutoSize = true;
            this.materialRaisedButton1.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.materialRaisedButton1.Depth = 0;
            this.materialRaisedButton1.Icon = null;
            this.materialRaisedButton1.Location = new System.Drawing.Point(241, 277);
            this.materialRaisedButton1.MouseState = MaterialSkin.MouseState.HOVER;
            this.materialRaisedButton1.Name = "materialRaisedButton1";
            this.materialRaisedButton1.Primary = true;
            this.materialRaisedButton1.Size = new System.Drawing.Size(61, 36);
            this.materialRaisedButton1.TabIndex = 0;
            this.materialRaisedButton1.Text = "Login";
            this.materialRaisedButton1.UseVisualStyleBackColor = true;
            this.materialRaisedButton1.Click += new System.EventHandler(this.materialRaisedButton1_Click);
            // 
            // tb_username
            // 
            this.tb_username.Depth = 0;
            this.tb_username.Hint = "Username";
            this.tb_username.Location = new System.Drawing.Point(12, 209);
            this.tb_username.MaxLength = 32767;
            this.tb_username.MouseState = MaterialSkin.MouseState.HOVER;
            this.tb_username.Name = "tb_username";
            this.tb_username.PasswordChar = '\0';
            this.tb_username.SelectedText = "";
            this.tb_username.SelectionLength = 0;
            this.tb_username.SelectionStart = 0;
            this.tb_username.Size = new System.Drawing.Size(290, 23);
            this.tb_username.TabIndex = 1;
            this.tb_username.TabStop = false;
            this.tb_username.UseSystemPasswordChar = false;
            // 
            // tb_password
            // 
            this.tb_password.Depth = 0;
            this.tb_password.Hint = "Password";
            this.tb_password.Location = new System.Drawing.Point(12, 248);
            this.tb_password.MaxLength = 32767;
            this.tb_password.MouseState = MaterialSkin.MouseState.HOVER;
            this.tb_password.Name = "tb_password";
            this.tb_password.PasswordChar = '●';
            this.tb_password.SelectedText = "";
            this.tb_password.SelectionLength = 0;
            this.tb_password.SelectionStart = 0;
            this.tb_password.Size = new System.Drawing.Size(290, 23);
            this.tb_password.TabIndex = 2;
            this.tb_password.TabStop = false;
            this.tb_password.UseSystemPasswordChar = false;
            // 
            // Login
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(314, 334);
            this.Controls.Add(this.tb_password);
            this.Controls.Add(this.tb_username);
            this.Controls.Add(this.materialRaisedButton1);
            this.Name = "Login";
            this.Text = "Welcome And Please Log In";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private MaterialSkin.Controls.MaterialRaisedButton materialRaisedButton1;
        private MaterialSkin.Controls.MaterialSingleLineTextField tb_username;
        private MaterialSkin.Controls.MaterialSingleLineTextField tb_password;
    }
}

