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
    public partial class FormTopla : Form
    {
        public FormTopla()
        {
            InitializeComponent();
        }
        void LogYaz(string mesaj)
        {
            listView1.Items.Add(mesaj);
        }
        void EkranHazırla()
        {
            txtBirinciSayi.Text = "0";
            txtİkinciSayi.Text = "0";
            txtBirinciSayi.Focus();
        }
        int Topla(int sayi1, int sayi2)
        {
            return sayi1 + sayi2;
        }
        Boolean Dogrula()
        {
            try
            {
                Convert.ToInt32(txtBirinciSayi.Text);
                Convert.ToInt32(txtİkinciSayi.Text);
            }
            catch (Exception)
            {

                return false;
            }
            return true;
        }

        private void BtnTopla_Click(object sender, EventArgs e)
        {
            if (Dogrula())
            {
                int toplam;

                toplam = Topla(Convert.ToInt32(txtBirinciSayi.Text),
                               Convert.ToInt32(txtİkinciSayi.Text));

                txtSonuc.Text = toplam.ToString();
                LogYaz("işlem başarılı. Sonuç: " + toplam);
            }
            else
            {
                MessageBox.Show("Değerlerde bir hata var.");
                LogYaz("işlem başarısız");
            }
           
        }

        private void FormTopla_Shown(object sender, EventArgs e)
        {
            EkranHazırla();
        }

        private void TxtBirinciSayi_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (
                char.IsLetter(e.KeyChar) ||
                char.IsSymbol(e.KeyChar) ||
                char.IsWhiteSpace(e.KeyChar) ||
                char.IsPunctuation(e.KeyChar)
                )
                e.Handled = true;
        }

        private void TxtİkinciSayi_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (
               char.IsLetter(e.KeyChar) ||
               char.IsSymbol(e.KeyChar) ||
               char.IsWhiteSpace(e.KeyChar) ||
               char.IsPunctuation(e.KeyChar)
               )
                e.Handled = true;
        }
    }
}
