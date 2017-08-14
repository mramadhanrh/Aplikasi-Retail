using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using MaterialSkin;
using MaterialSkin.Controls;
using MySql.Data.MySqlClient;

namespace AplikasiRetail
{
    public partial class KasirInputValue : MaterialForm
    {
        int volume;
        public bool isFromKasir;
        public KasirInputValue()
        {
            InitializeComponent();
        }

        private void btnCancel_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btnSubmit_Click(object sender, EventArgs e)
        {
            if (numBanyak.Value <= 0)
            {
                MessageBox.Show("Harap Masukan Lebih Banyak Dari 0", "Warning !", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
            else if (isFromKasir)
            {
                volume = (int)numBanyak.Value;
                isFromKasir = false;
                this.Close();
            }
            else
            {
                KasirInputForm.SetArray3(numBanyak.Value.ToString());
                KasirInputForm.isInputing = true;
                this.Close();
            }
        }

        public int getVolume()
        {
            return volume;
        }
    }
}
