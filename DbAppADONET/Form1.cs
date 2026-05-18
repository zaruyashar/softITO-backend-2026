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


        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            Listele("SELECT * FROM Malzemeler");
        }

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

        private void dataGridView1_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            int satir = dataGridView1.SelectedCells[0].RowIndex;
            textBox1.Text = dataGridView1.Rows[satir].Cells[0].Value.ToString();
            textBox2.Text = dataGridView1.Rows[satir].Cells[1].Value.ToString();
            textBox3.Text = dataGridView1.Rows[satir].Cells[2].Value.ToString();
            textBox4.Text = dataGridView1.Rows[satir].Cells[3].Value.ToString();
            textBox5.Text = dataGridView1.Rows[satir].Cells[4].Value.ToString();
        }
    }
}
