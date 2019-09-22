using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ToplamaMakinesiV
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void BtnTopla_Click(object sender, EventArgs e)
        {
            int toplam, birinciSayi, ikinciSayi;

            birinciSayi = Convert.ToInt32(txtBirinciSayi.Text);
            ikinciSayi = Convert.ToInt32(txtİkinciSayi.Text);

            toplam = birinciSayi + ikinciSayi;

            MessageBox.Show("Toplam sonucu: " + toplam);
        }
    }
}
