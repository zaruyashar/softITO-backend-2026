using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace NewFormProject
{
    public partial class Form2 : Form
    {
        public Form2()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Form1 frm = new Form1();
            frm.Show();
            this.Hide();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            int fiyat = Convert.ToInt32(textBox1.Text);
            int adet = Convert.ToInt32(textBox2.Text);
            int sonuc = fiyat * adet;
            Form3 form3 = new Form3();
            form3.listBox1.Items.Add(sonuc);
            form3.Show();

        }
    }
}
