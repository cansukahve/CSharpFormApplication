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

namespace gppp
{
    public partial class Form2 : Form
    {
        public Form2()
        {
            InitializeComponent();
        }

        //müşteri ekleme fonksiyonu
        private void AddCustomer(string firstName, string lastName, string phoneNumber, string email)
        {
            using (SqlConnection baglanti = new SqlConnection("Data Source=Cansu\\SQLEXPRESS04;Initial Catalog=PersonelVeriTabani;Integrated Security=True"))
            {
                string query = "INSERT INTO Musteriler (Isim, SoyIsim, TelNo, Email) VALUES (@Isim, @SoyIsim, @TelNo, @Email)";
                SqlCommand cmd = new SqlCommand(query, baglanti);
                cmd.Parameters.AddWithValue("@Isim", firstName);
                cmd.Parameters.AddWithValue("@SoyIsim", lastName);
                cmd.Parameters.AddWithValue("@TelNo", phoneNumber);
                cmd.Parameters.AddWithValue("@Email", email);
                baglanti.Open();
                cmd.ExecuteNonQuery();
            }
        }


        private void button1_Click(object sender, EventArgs e)
        {
            //////////////// ekle butonu
            ///
            AddCustomer(textBox1.Text, textBox2.Text, textBox3.Text, textBox4.Text);
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {
            ////////////////////  ad
        }

        private void textBox2_TextChanged(object sender, EventArgs e)
        {
            // soyad
        }

        private void textBox3_TextChanged(object sender, EventArgs e)
        {
            // telefon
        }

        private void textBox4_TextChanged(object sender, EventArgs e)
        {
            // eposta
        }

        private void label3_Click(object sender, EventArgs e)
        {

        }

        private void label5_Click(object sender, EventArgs e)
        {

        }
    }
}
