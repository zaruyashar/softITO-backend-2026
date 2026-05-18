using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Reflection.Emit;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ComboBox
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void label3_Click(object sender, EventArgs e)
        {

        }

        private void comboBox2_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void comboBox3_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (comboBox1.SelectedItem == "Toplama")
            {
                int sayi1 = Convert.ToInt32(this.sayi1.Text);
                int sayi2 = Convert.ToInt32(this.sayi2.Text);

                int toplam = sayi1 + sayi2;
                label4.Text = toplam.ToString();
            }
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (comboBox1.SelectedItem == "Çarpma")
            {
                int sayi1 = Convert.ToInt32(this.sayi1.Text);
                int sayi2 = Convert.ToInt32(this.sayi2.Text);

                int toplam = sayi1 * sayi2;
                label4.Text = toplam.ToString();
            }

            else if (comboBox1.SelectedItem == "Bölme")
            {
                int sayi1 = Convert.ToInt32(this.sayi1.Text);
                int sayi2 = Convert.ToInt32(this.sayi2.Text);

                int toplam = sayi1 / sayi2;
                label4.Text = toplam.ToString();
            }
            else
            {
                int sayi1 = Convert.ToInt32(this.sayi1.Text);
                int sayi2 = Convert.ToInt32(this.sayi2.Text);

                int toplam = sayi1 - sayi2;
                label4.Text = toplam.ToString();
            }
        }

        private void contextMenuStrip1_Opening(object sender, CancelEventArgs e)
        {

        }
    }
}
