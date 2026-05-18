using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Forms_Intro
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

        private void button1_Click(object sender, EventArgs e)
        {
            string ad = txt1.Text;
            string sifre = txt2.Text;
            if (ad == "admin" && sifre == "1234")
            {
                MessageBox.Show(ad + " Hoşgeldiniz");

                AnaEkran go = new AnaEkran();
                go.Show();
                this.Hide();
            }
            else
            {
                MessageBox.Show("Hatalı işlem");
                txt1.Clear();
                txt2.Text = "";
            }
        }
    }
}
