using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ADONET_PROC
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        // SQL Connection
        SqlConnection con = new SqlConnection("Data Source=localhost;Database=SoftFaaliyet;Integrated Security=true;");

        public void Listele()
        {
            SqlCommand cmd = new SqlCommand();
            cmd.Connection = con;
            cmd.CommandType = CommandType.StoredProcedure;
            cmd.CommandText = "Mlistele";
            SqlDataAdapter adapter = new SqlDataAdapter(cmd);
            DataTable dr = new DataTable();
            adapter.Fill(dr);
            dataGridView1.DataSource = dr;

        }

        // List
        private void button4_Click(object sender, EventArgs e)
        {
            Listele();
        }


        // Save
        private void button1_Click(object sender, EventArgs e)
        {
            con.Open();
            SqlCommand cmd = new SqlCommand();
            cmd.Connection = con;
            cmd.CommandType = CommandType.StoredProcedure;
            cmd.CommandText = "MusteriEkle";

            cmd.Parameters.AddWithValue("AdSoyad", textBox1.Text);
            cmd.Parameters.AddWithValue("Yas", textBox2.Text);
            cmd.Parameters.AddWithValue("Maas", textBox3.Text);
            cmd.Parameters.AddWithValue("Ciro", textBox4.Text);
            cmd.Parameters.AddWithValue("Bakiye", textBox5.Text);

            cmd.ExecuteNonQuery();
            con.Close();
            Listele();
        }


        // Update ***
        private void button2_Click(object sender, EventArgs e)
        {
            con.Open();
            SqlCommand cmd = new SqlCommand();
            cmd.Connection = con;
            cmd.CommandType = CommandType.StoredProcedure;
            cmd.CommandText = "MusteriYenile";
            cmd.Parameters.AddWithValue("MusteriID", textBox1.Tag);
            cmd.Parameters.AddWithValue("AdSoyad", textBox1.Text);
            cmd.Parameters.AddWithValue("Yas", textBox2.Text);
            cmd.Parameters.AddWithValue("Maas", textBox3.Text);
            cmd.Parameters.AddWithValue("Ciro", textBox4.Text);
            cmd.Parameters.AddWithValue("Bakiye", textBox5.Text);

            cmd.ExecuteNonQuery();
            con.Close();
            Listele();
        }


        // Delete ***
        private void button3_Click(object sender, EventArgs e)
        {
            con.Open();
            SqlCommand cmd = new SqlCommand();
            cmd.Connection = con;
            cmd.CommandType = CommandType.StoredProcedure;
            cmd.CommandText = "MSil";
            cmd.Parameters.AddWithValue("MusteriID", textBox1.Tag);
            cmd.ExecuteNonQuery();
            con.Close();
            Listele();
        }

        // DataGridView ***
        private void dataGridView1_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            int satir = dataGridView1.SelectedCells[0].RowIndex;
            textBox1.Tag = dataGridView1.Rows[satir].Cells[0].Value.ToString();
            textBox1.Text = dataGridView1.Rows[satir].Cells[1].Value.ToString();
            textBox2.Text = dataGridView1.Rows[satir].Cells[2].Value.ToString();
            textBox3.Text = dataGridView1.Rows[satir].Cells[3].Value.ToString();
            textBox4.Text = dataGridView1.Rows[satir].Cells[4].Value.ToString();
            textBox5.Text = dataGridView1.Rows[satir].Cells[5].Value.ToString();
        }






        // Accidental click
        private void Form1_Load(object sender, EventArgs e)
        {

        }
    }
}
