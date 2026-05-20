using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.SqlClient;

namespace DbAppADONET
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        // SQL Connection
        SqlConnection conn = new SqlConnection("Data Source=localhost;Database=SoftFaaliyet;Integrated Security=true;");

        public void Listele(string listele)
        {
            SqlDataAdapter sda = new SqlDataAdapter(listele, conn);
            DataSet ds = new DataSet();

            sda.Fill(ds);
            dataGridView1.DataSource = ds.Tables[0];
        }

        // List
        private void button1_Click(object sender, EventArgs e)
        {
            Listele("SELECT * FROM Malzemeler");
        }

        // Save
        private void button2_Click(object sender, EventArgs e)
        {
            conn.Open();

            // Texbox'tan alınan verileri parametrelere taşı @ ile
            SqlCommand command = new SqlCommand("INSERT INTO Malzemeler(MalzemeAdi, Fiyat, Adet, Durum) VALUES(@MalzemeAdi, @Fiyat, @Adet, @Durum)", conn);

            command.Parameters.AddWithValue("@MalzemeAdi", textBox2.Text);
            command.Parameters.AddWithValue("@Fiyat", textBox3.Text);
            command.Parameters.AddWithValue("@Adet", textBox4.Text);
            command.Parameters.AddWithValue("@Durum", textBox5.Text);

            command.ExecuteNonQuery(); // Sorgu başarıyla çalıştırıldıysa 1, başarısız ise 0 döner.


            conn.Close();
        }

        // Update
        private void button3_Click(object sender, EventArgs e)
        {
            conn.Open();

            SqlCommand command = new SqlCommand("UPDATE Malzemeler SET MalzemeAdi = '"+textBox2.Text.ToString()+ "', Fiyat = '" + textBox3.Text.ToString() + "', Adet = '"+ textBox4.Text.ToString()+ "', Durum = '"+ textBox5.Text.ToString()+ "' WHERE MalzemeNo = '"+ textBox1.Text.ToString()+ "'", conn);

            command.ExecuteNonQuery();
            Listele("SELECT * FROM Malzemeler");

            conn.Close();
        }

        // Delete
        private void button4_Click(object sender, EventArgs e)
        {
            conn.Open();

            SqlCommand command = new SqlCommand("DELETE FROM Malzemeler WHERE MalzemeNo = @MalzemeNo", conn);
            command.Parameters.AddWithValue("@MalzemeNo", textBox1.Text);

            command.ExecuteNonQuery();
            Listele("SELECT * FROM Malzemeler");

            conn.Close();
        }

        // Search
        private void button5_Click(object sender, EventArgs e)
        {
            conn.Open();

            SqlCommand command = new SqlCommand("SELECT * FROM Malzemeler WHERE MalzemeAdi LIKE '%"+textBox2.Text+"%'", conn);

            SqlDataAdapter dr = new SqlDataAdapter(command);
            DataSet ds = new DataSet();
            dr.Fill(ds);
            dataGridView1.DataSource = ds.Tables[0];

            conn.Close();
        }




        // DatagridView
        private void dataGridView1_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            int satir = dataGridView1.SelectedCells[0].RowIndex;
            textBox2.Text = dataGridView1.Rows[satir].Cells[1].Value.ToString();
            textBox3.Text = dataGridView1.Rows[satir].Cells[2].Value.ToString();
            textBox4.Text = dataGridView1.Rows[satir].Cells[3].Value.ToString();
            textBox5.Text = dataGridView1.Rows[satir].Cells[4].Value.ToString();
        }



        // Yanlış tıklamalar
        private void Form1_Load(object sender, EventArgs e)
        {

        }
    }
}
