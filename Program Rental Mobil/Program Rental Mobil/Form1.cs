using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Program_Rental_Mobil
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

        private void label3_Click(object sender, EventArgs e)
        {

        }

        private void label4_Click(object sender, EventArgs e)
        {

        }
        long biaya_perhari;
        short durasi;
        string mobil;
        DateTime tanggal_pinjam;
        DateTime tanggal_kembali;
        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
            mobil = Convert.ToString(comboBox1.SelectedItem);

            if (mobil == "Toyota Grand New Avanza")
            {
                textbiaya.Text = Convert.ToString(400000);
            }
            else if (mobil == "Daihatsu Xenia")
            {
                textbiaya.Text = Convert.ToString(400000);
            }
            else if (mobil == "APV Luxury")
            {
                textbiaya.Text = Convert.ToString(450000);
            }
            else if (mobil == "New Kijang Innova")
            {
                textbiaya.Text = Convert.ToString(500000);
            }
            else if (mobil == "Toyota Alphard")
            {
                textbiaya.Text = Convert.ToString(1000000);
            }
        }
        private void button1_Click(object sender, EventArgs e)
        {
            if (Int64.TryParse(textbiaya.Text, out biaya_perhari) && Int16.TryParse(textDurasi.Text, out durasi))
            {
                textbayar.Text = "Rp. " + Convert.ToString(biaya_perhari * durasi) + ",-";
            }
        }
         private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void textBox3_TextChanged(object sender, EventArgs e)
        {

        }

        private void textBox2_TextChanged(object sender, EventArgs e)
        {

        }

        private void tmpinjam_ValueChanged(object sender, EventArgs e)
        {

        }

        private void tmkembali_ValueChanged(object sender, EventArgs e)
        {
            tanggal_pinjam = tmpinjam.Value.Date;
            tanggal_kembali = tmkembali.Value.Date;

            if (tanggal_kembali < tanggal_pinjam)
            {
                MessageBox.Show("Tanggal yang anda masukan salah");
            }
            else
            {
                TimeSpan temp = tanggal_kembali - tanggal_pinjam;
                textDurasi.Text = Convert.ToString(Math.Round(temp.TotalDays));
            }
        }

        private void textbiaya_perhari_TextChanged(object sender, EventArgs e)
        {

        }

        private void textBox1_TextChanged_1(object sender, EventArgs e)
        {
           
        }

        private void button2_Click(object sender, EventArgs e)
        {
            dipanggil baru = new dipanggil();
            int spek;
            spek = comboBox1.SelectedIndex;
            if (comboBox1.SelectedIndex == 0)
            {
                textBox1.Text = baru.mobil1();
            }
            else if ( comboBox1.SelectedIndex == 1)
            {
                textBox1.Text = baru.mobil2();
            }
            else if (comboBox1.SelectedIndex == 2)
            {
                textBox1.Text = baru.mobil3();
            }
            else if (comboBox1.SelectedIndex == 3)
            {
                textBox1.Text = baru.mobil4();
            }
            else if (comboBox1.SelectedIndex == 4)
            {
                textBox1.Text = baru.mobil5();
            }
        }
    }
}