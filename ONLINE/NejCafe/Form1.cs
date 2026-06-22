using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;

namespace NejCafe
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Müşteri bilgileri başarıyla alındı. Şimdi sipariş seçiminizi yapabilirsiniz.", "Bilgi", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            lahmacun.Visible = false;
            pizza.Visible = false;
            kebap.Visible = false;
            icecek.Visible = false;
        }

        private void comboBox2_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (comboBox2.Text == "Lahmacun")
            {
                lahmacun.Visible = true;
            }
            else if (comboBox2.Text == "Pizza")
            {
                pizza.Visible = true;
            }
            else if (comboBox2.Text == "Kebap")
            {
                kebap.Visible = true;
            }
            else if (comboBox2.Text == "İçecek")
            {
                icecek.Visible = true;
            }
        }

        // Sipariş ver düğmesi
        private void button2_Click(object sender, EventArgs e)
        {
            siparisozetkutusu.Items.Clear();

            siparisozetkutusu.Items.Add("Müşteri adı : " + musteriadi.Text);
            siparisozetkutusu.Items.Add("Müşteri Soyadı : " + musterisoyadi.Text);
            siparisozetkutusu.Items.Add("Ödeme Şekli : " + odemesekli.Text);
            siparisozetkutusu.Items.Add("Sipariş No : " + siparisno.Text);
            siparisozetkutusu.Items.Add("Telefon : " + telefon.Text);
            siparisozetkutusu.Items.Add("Adres : " + adres.Text);

            if (acili.Checked)
            {
                siparisozetkutusu.Items.Add("Yiyecek : Lahmacun");
                siparisozetkutusu.Items.Add("Acılı");
                siparisozetkutusu.Items.Add("Adet : " + numlahmacun.Value.ToString());
            }
            if (acisiz.Checked)
            {
                siparisozetkutusu.Items.Add("Yiyecek : Lahmacun");
                siparisozetkutusu.Items.Add("Acısız");
                siparisozetkutusu.Items.Add("Adet : " + numlahmacun.Value.ToString());
            }

            if (vejetaryen.Checked)
            {
                siparisozetkutusu.Items.Add("Yiyecek : Pizza");
                siparisozetkutusu.Items.Add("Vejetaryen");
                siparisozetkutusu.Items.Add("Adet : " + numpizza.Value.ToString());
            }
            if (karisik.Checked)
            {
                siparisozetkutusu.Items.Add("Yiyecek : Pizza");
                siparisozetkutusu.Items.Add("Karışık");
                siparisozetkutusu.Items.Add("Adet : " + numpizza.Value.ToString());
            }
            if (turkusulu.Checked)
            {
                siparisozetkutusu.Items.Add("Yiyecek : Pizza");
                siparisozetkutusu.Items.Add("Türk usulü");
                siparisozetkutusu.Items.Add("Adet : " + numpizza.Value.ToString());
            }

            if (adana.Checked)
            {
                siparisozetkutusu.Items.Add("Yiyecek : Kebap");
                siparisozetkutusu.Items.Add("Adana");
                siparisozetkutusu.Items.Add("Adet : " + numkebap.Value.ToString());
            }
            if (urfa.Checked)
            {
                siparisozetkutusu.Items.Add("Yiyecek : Kebap");
                siparisozetkutusu.Items.Add("Urfa");
                siparisozetkutusu.Items.Add("Adet : " + numkebap.Value.ToString());
            }

            if (ayran.Checked)
            {
                siparisozetkutusu.Items.Add("İçecek : Ayran");
                siparisozetkutusu.Items.Add("Adet : " + numicecek.Value.ToString());
            }
            if (kola.Checked)
            {
                siparisozetkutusu.Items.Add("İçecek : Kola");
                siparisozetkutusu.Items.Add("Adet : " + numicecek.Value.ToString());
            }
            if (salgam.Checked)
            {
                siparisozetkutusu.Items.Add("İçecek : Şalgam");
                siparisozetkutusu.Items.Add("Adet : " + numicecek.Value.ToString());
            }
            if (meyvesuyu.Checked)
            {
                siparisozetkutusu.Items.Add("İçecek : Meyve suyu");
                siparisozetkutusu.Items.Add("Adet : " + numicecek.Value.ToString());
            }
        }








        // Yanlışlıkla açılanlar :(
        private void groupBox3_Enter(object sender, EventArgs e)
        {

        }

        private void label8_Click(object sender, EventArgs e)
        {

        }

        private void groupBox1_Enter(object sender, EventArgs e)
        {

        }

        private void label9_Click(object sender, EventArgs e)
        {

        }

        private void siparisozetkutusu_SelectedIndexChanged(object sender, EventArgs e)
        {

        }
    }
}
