using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.Windows.Forms.VisualStyles.VisualStyleElement.Button;

namespace NewFormProject
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            groupBox1.Visible = false;
            groupBox2.Visible = false;
            label2.Visible = false;
            listBox1.Visible = false;
        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (comboBox1.SelectedItem == "VIP")
            {
                groupBox1.Visible = true;
                groupBox2.Visible = false;
            }
            else
            {
                groupBox1.Visible = false;
                groupBox2.Visible = true;
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            label2.Visible = true;
            listBox1.Visible = true;

            if (radioButton1.Checked)
            {
                listBox1.Items.Add("Seçim : " + radioButton1.Text);
            }
            else
            {
                listBox1.Items.Add("Seçim : " + radioButton2.Text);
            }

            listBox1.Items.Add("Üyelik Adet : " + numericUpDown1.Value);
        }

        private void button2_Click(object sender, EventArgs e)
        {
            label2.Visible = true;
            listBox1.Visible = true;

            if (radioButton2.Checked)
            {
                listBox1.Items.Add("Seçim : " + radioButton1.Text);
            }
            else
            {
                listBox1.Items.Add("Seçim : " + radioButton2.Text);
            }
            listBox1.Items.Add("Tarih : " + dateTimePicker1.Text);
        }


        private void listBox1_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void dateTimePicker1_ValueChanged(object sender, EventArgs e)
        {

        }

        private void button3_Click(object sender, EventArgs e)
        {
            Form2 go = new Form2();
            go.Show();
        }
    }
}
