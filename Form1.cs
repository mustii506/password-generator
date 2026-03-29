using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Şifre_Oluşturucu
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void btnOlustur_Click(object sender, EventArgs e)
        {
            string buyukHarfler = "ABCDEFGHIJKLMNOPQRSTUVWXYZ";
            string kucukHarfler = "abcdefghijklmnopqrstuvwxyz";
            string rakamlar = "0123456789";
            string ozelKarakterler = "!@#$%^&*()_+-=[]{}|;:,.<>?";
            string secilenKarakterler = "";
            if (chkBuyukHarf.Checked) secilenKarakterler += buyukHarfler;
            if (chkKucukHarf.Checked) secilenKarakterler += kucukHarfler;
            if (chkRakam.Checked) secilenKarakterler += rakamlar;
            if (chkOzelKarakter.Checked) secilenKarakterler += ozelKarakterler;
            if (secilenKarakterler.Length == 0)
            {
                MessageBox.Show("Lütfen en az bir karakter türü seçin!", "Hata", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }
            int sifreUzunlugu = (int)numUzunluk.Value;
            string olusturulanSifre = "";
            Random rastgele = new Random(); // Rastgele sayı üreteceğimiz aracı çağırıyoruz
            for (int i = 0; i < sifreUzunlugu; i++)
            {
                int rastgeleIndex = rastgele.Next(secilenKarakterler.Length);
                olusturulanSifre += secilenKarakterler[rastgeleIndex];

            }
            txtSifre.Text = olusturulanSifre;
        }

        private void btnKopyala_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrEmpty(txtSifre.Text))
            {
                MessageBox.Show("Kopyalanacak bir şifre yok. Lütfen önce şifre üretin!", "Uyarı", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return; 
            }
            Clipboard.SetText(txtSifre.Text);
            MessageBox.Show("Şifre başarıyla kopyalandı!", "Bilgi", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }
    }
}
