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
    public partial class Form4 : Form
    {
        public Form4()
        {
            InitializeComponent();
            LoadCustomers();
            LoadServices();
        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
            // musteri sec
        }

        private void comboBox2_SelectedIndexChanged(object sender, EventArgs e)
        {
            // hizmet sec
        }

        private void dateTimePicker1_ValueChanged(object sender, EventArgs e)
        {
            // randevu tarihi
        }

        private void textBox5_TextChanged(object sender, EventArgs e)
        {
            // notmlar
        }

        private void button2_Click(object sender, EventArgs e)
        {
            // randevu ekle butonu

            if (comboBox1.SelectedItem is ComboBoxItem selectedCustomerItem && comboBox2.SelectedItem is ComboBoxItem selectedServiceItem)
            {
                int customerId = (int)selectedCustomerItem.Value;
                int serviceId = (int)selectedServiceItem.Value;
                DateTime appointmentDate = dateTimePicker1.Value;

                AddAppointment(customerId, serviceId, appointmentDate, textBox5.Text);
            }
            else
            {
                MessageBox.Show("Lütfen geçerli bir müşteri ve servis seçin.");
            }
        }



        // Musteri tablosunu goruntuler
        private void LoadCustomers()
        {
            using (SqlConnection baglanti = new SqlConnection("Data Source=Cansu\\SQLEXPRESS04;Initial Catalog=PersonelVeriTabani;Integrated Security=True"))
            {
                string query = "SELECT MusteriID, Isim + ' ' + SoyIsim AS Isim FROM Musteriler";
                SqlCommand cmd = new SqlCommand(query, baglanti);
                baglanti.Open();
                SqlDataReader reader = cmd.ExecuteReader();

                while (reader.Read())
                {
                    int customerId = Convert.ToInt32(reader["MusteriID"]);
                    string customerName = reader["Isim"].ToString();

                    ComboBoxItem item = new ComboBoxItem
                    {
                        Value = customerId,
                        Text = $"{customerId} - {customerName}" // Hem ID hem de ismi birleştirerek göstermek için
                    };
                    comboBox1.Items.Add(item);
                }
            }
        }


        // Servis tablosunu goruntular
        private void LoadServices()
        {
            using (SqlConnection baglanti = new SqlConnection("Data Source=Cansu\\SQLEXPRESS04;Initial Catalog=PersonelVeriTabani;Integrated Security=True"))
            {
                string query = "SELECT ServisID, ServisAdi FROM Servisler";
                SqlCommand cmd = new SqlCommand(query, baglanti);
                baglanti.Open();
                SqlDataReader reader = cmd.ExecuteReader();

                while (reader.Read())
                {
                    ComboBoxItem item = new ComboBoxItem
                    {
                        Value = (int)reader["ServisID"],/// int
                        Text = reader["ServisAdi"].ToString()
                    };
                    comboBox2.Items.Add(item);
                }
            }
        }

        private void AddAppointment(int customerId, int serviceId, DateTime appointmentDate, string notes)
        {
            using (SqlConnection baglanti = new SqlConnection("Data Source=Cansu\\SQLEXPRESS04;Initial Catalog=PersonelVeriTabani;Integrated Security=True"))
            {
                string query = "INSERT INTO Randevular (MusteriID, ServisID, RandevuTarihi, Notlar) VALUES (@MusteriID, @ServisID, @RandevuTarihi, @Notlar)";
                SqlCommand cmd = new SqlCommand(query, baglanti);
                cmd.Parameters.AddWithValue("@MusteriID", customerId);
                cmd.Parameters.AddWithValue("@ServisID", serviceId);
                cmd.Parameters.AddWithValue("@RandevuTarihi", appointmentDate);
                cmd.Parameters.AddWithValue("@Notlar", notes);

                try
                {
                    baglanti.Open();
                    cmd.ExecuteNonQuery();
                    MessageBox.Show("Randevu başarıyla eklendi.");
                }
                catch (Exception ex)
                {
                    MessageBox.Show($"Randevu eklenirken bir hata oluştu: {ex.Message}");
                }
            }
        }

    }
}
