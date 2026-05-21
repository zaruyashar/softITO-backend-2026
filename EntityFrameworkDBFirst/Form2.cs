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
    public partial class Form2 : Form
    {
        public Form2()
        {
            InitializeComponent();
        }
        //veritabanına baglantı cümlesi
        SoftTicaretEntities con = new SoftTicaretEntities();



        public void Listele()//listele methodu
        {
            dataGridView1.DataSource = con.TicariBilgilers.ToList();
        }




        private void Form2_Load(object sender, EventArgs e)
        {

        }

        private void button4_Click(object sender, EventArgs e)
        {
            Listele();
        }

        private void button1_Click(object sender, EventArgs e)//kaydetme
        {
            TicariBilgiler ticariBilgiler = new TicariBilgiler();
            ticariBilgiler.TicariAdi = textBox1.Text;
            ticariBilgiler.TicariTip = textBox2.Text;
            ticariBilgiler.Ciro = Convert.ToInt32(textBox3.Text);
            ticariBilgiler.Durum = textBox4.Text;

            con.TicariBilgilers.Add(ticariBilgiler);
            con.SaveChanges();
            Listele();


        }

        private void dataGridView1_CellClick(object sender, DataGridViewCellEventArgs e)//gridview seçi,m
        {
            DataGridViewRow row = dataGridView1.CurrentRow;
            textBox5.Tag = row.Cells["TicariNo"].Value.ToString();
            textBox1.Text = row.Cells["TicariAdi"].Value.ToString();
            textBox2.Text = row.Cells["TicariTip"].Value.ToString();
            textBox3.Text = row.Cells["Ciro"].Value.ToString();
            textBox4.Text = row.Cells["Durum"].Value.ToString();
        }

        private void button2_Click(object sender, EventArgs e)//güncelle
        {
            int TicariNo = Convert.ToInt32(textBox5.Tag);

            var guncelle = con.TicariBilgilers.Where(M => M.TicariNo == TicariNo).FirstOrDefault();

            guncelle.TicariAdi = textBox2.Text;
            guncelle.TicariTip = textBox3.Text;
            guncelle.Ciro = Convert.ToInt32(textBox4.Text);
            guncelle.Durum = textBox5.Text;
            con.SaveChanges();
            Listele();

        }

        private void button3_Click(object sender, EventArgs e)//silme işlemi
        {
            int TicariNo = Convert.ToInt32(textBox5.Tag);

            var delete = con.TicariBilgilers.Where(M => M.TicariNo == TicariNo).FirstOrDefault();

            con.TicariBilgilers.Remove(delete);
            con.SaveChanges();
            Listele();

        }

        private void button5_Click(object sender, EventArgs e) // search
        {
            dataGridView1.DataSource = con.TicariBilgilers.Where(x => x.TicariAdi.ToLower().Contains(textBox1.Text)).ToList();
        }
    }
}
