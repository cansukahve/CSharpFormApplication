using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace gppp
{
    public partial class Form5 : Form
    {
        public Form5()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            ////müşteri ekle
            //
            Form2 MusEkleForm = new Form2();
            MusEkleForm.Show();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            // Servis ekle butonu
            Form3 SerEkleForm = new Form3();
            SerEkleForm.Show();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            ////randevu ekle
            ///
            Form4 RanEkleForm = new Form4();
            RanEkleForm.Show();
        }
    }
}
