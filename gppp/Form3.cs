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
    public partial class Form3 : Form
    {
        public Form3()
        {
            InitializeComponent();
        }

        private void textBox6_TextChanged(object sender, EventArgs e)
        {
            // servis adi
        }

        private void textBox7_TextChanged(object sender, EventArgs e)
        {
            // fiyat
        }

        private void textBox8_TextChanged(object sender, EventArgs e)
        {
            // sure
        }

        private void button3_Click(object sender, EventArgs e)
        {
            // servis ekle butonu
            int sure = int.Parse(textBox7.Text);
            int fiyat = int.Parse(textBox8.Text);


            AddServices(textBox6.Text, sure, fiyat);
        }


        // Servis ekler
        private void AddServices(string servisAdi, int sure, decimal fiyat)
        {
            using (SqlConnection baglanti = new SqlConnection("Data Source=Cansu\\SQLEXPRESS04;Initial Catalog=PersonelVeriTabani;Integrated Security=True"))
            {
                string query = "INSERT INTO Servisler (servisAdi, sure, fiyat) VALUES (@servisAdi, @sure, @fiyat)";
                SqlCommand cmd = new SqlCommand(query, baglanti);
                cmd.Parameters.AddWithValue("@servisAdi", servisAdi);
                cmd.Parameters.AddWithValue("@sure", sure);
                cmd.Parameters.AddWithValue("@fiyat", fiyat);

                baglanti.Open();
                cmd.ExecuteNonQuery();
            }
        }

        private void label1_Click(object sender, EventArgs e)
        {
            // baslik servis ekle label
        }

        private void Form3_Load(object sender, EventArgs e)
        {

        }
    }
}
