using EntityFrameworkDBFirst;
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

namespace efdbfirstproje
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {


        }

        SoftTicaretEntities con = new SoftTicaretEntities();
        private bool GirisYap(string ad, string sifre)
        {
            //select * from kullanicilar where kullanıcıadi="nihal" and sifre="1234"
            var sorgu = from s in con.Kullanicilars
                        where s.KullaniciAdi == ad && s.Sifre == sifre
                        select s;
            if (sorgu.Any())
            {
                return true;
            }
            else
            {
                return false;
            }



        }


        private void button1_Click(object sender, EventArgs e)
        {
            if (GirisYap(textBox1.Text, textBox2.Text))
            {

                Form2 form2 = new Form2();
                form2.Show();
                this.Hide();
            }
            else
            {
                MessageBox.Show("Bir hata oluştu, tekrar deneyin.");

                textBox1.Text = "";
                textBox2.Clear();
            }





        }


    }
}
