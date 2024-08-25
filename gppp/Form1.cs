using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Windows.Forms;

namespace gppp
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
            LoadCustomers();
            LoadServices();
        }

        private void Form1_Load(object sender, EventArgs e)
        {

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
                        Text = $"{customerId} - {customerName}" // Hem ID hem de ismi birleþtirerek göstermek için
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


        // Musteri Ekler
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

        // Servis Ekle Butonu
        private void button3_Click(object sender, EventArgs e)
        {
            ///////////////////
            ///
            int sure = int.Parse(textBox7.Text);
            int fiyat = int.Parse(textBox8.Text);


            AddServices(textBox6.Text, sure, fiyat);
        }



        /*
        // Randevu Ekler
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
                baglanti.Open();
                cmd.ExecuteNonQuery();
            }
        }
        */

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
                    MessageBox.Show("Randevu baþarýyla eklendi.");
                }
                catch (Exception ex)
                {
                    MessageBox.Show($"Randevu eklenirken bir hata oluþtu: {ex.Message}");
                }
            }
        }

        private void button2_Click(object sender, EventArgs e)
        {

            /*
            int customerId = int.Parse(comboBox1.Text);
            int serviceId = int.Parse(comboBox2.Text);
            DateTime appointmentDate = dateTimePicker1.Value;

            AddAppointment(customerId, serviceId, appointmentDate, textBox5.Text);
            */

            /*

            if (int.TryParse(comboBox1.Text, out int customerId) && int.TryParse(comboBox2.Text, out int serviceId))
            {
                DateTime appointmentDate = dateTimePicker1.Value;

                AddAppointment(customerId, serviceId, appointmentDate, textBox5.Text);
            }
            else
            {
                MessageBox.Show("Lütfen geçerli bir müþteri ID'si ve servis ID'si girin.");
            }
            */

            if (comboBox1.SelectedItem is ComboBoxItem selectedCustomerItem && comboBox2.SelectedItem is ComboBoxItem selectedServiceItem)
            {
                int customerId = (int)selectedCustomerItem.Value;
                int serviceId = (int)selectedServiceItem.Value;
                DateTime appointmentDate = dateTimePicker1.Value;

                AddAppointment(customerId, serviceId, appointmentDate, textBox5.Text);
            }
            else
            {
                MessageBox.Show("Lütfen geçerli bir müþteri ve servis seçin.");
            }

        }

        private void button1_Click(object sender, EventArgs e)
        {
            AddCustomer(textBox1.Text, textBox2.Text, textBox3.Text, textBox4.Text);
        }



        private void textBox1_TextChanged(object sender, EventArgs e)
        {
            ////////////////
        }
        private void textBox2_TextChanged(object sender, EventArgs e)
        {
            //////////////////////////
        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
            //////////////////////////////
        }



    }

    public class ComboBoxItem
    {
        public int Value { get; set; }
        public string Text { get; set; }

        public override string ToString()
        {
            return Text;
        }
    }
}
