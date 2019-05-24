using System;
using System.Collections;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Aplikasi_Pembelian_Tiket_KA
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }
        string jam, kelas, banyaknya;
        int harga, total;
        Queue antrian = new Queue();
        Stack tumpukan = new Stack();

        private void dateTimePicker1_ValueChanged(object sender, EventArgs e)
        {

        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void textBox2_TextChanged(object sender, EventArgs e)
        {

        }

        private void textBox8_TextChanged(object sender, EventArgs e)
        {

        }

        private void textBox5_TextChanged(object sender, EventArgs e)
        {
            antrian.Enqueue(textBox5.Text);
        }

        private void textBox6_TextChanged(object sender, EventArgs e)
        {
            tumpukan.Push(textBox6.Text);
        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
            int pilihan;
            pilihan = comboBox1.SelectedIndex;
            if (comboBox1.SelectedIndex == 2)
            {
                jam = "pukul 16.00";
            }
            else if (comboBox1.SelectedIndex == 1)
            {
                jam = "pukul 12.00";
            }
            else if (comboBox1.SelectedIndex == 0)
            {
                jam = "pukul 06.00";
            }
        }

        private void comboBox2_SelectedIndexChanged(object sender, EventArgs e)
        {
            int pilihan;
            pilihan = comboBox2.SelectedIndex;
            if (comboBox2.SelectedIndex == 1)
            {
                harga = 350000;
                textBox1.Text = Convert.ToString(harga);
                kelas = "Kelas VIP";
            }
            else
            {
                harga = 225000;
                textBox1.Text = Convert.ToString(harga);
                kelas = "Kelas Reguler";
            }
        }

        private void comboBox3_SelectedIndexChanged(object sender, EventArgs e)
        {
            int pilihan;
            pilihan = comboBox3.SelectedIndex;
            if (comboBox3.SelectedIndex == 0)
            {
                banyaknya = "1 Tiket";
                total = harga * 1;
                textBox2.Text = Convert.ToString(total);
            }
            else if (comboBox3.SelectedIndex == 1)
            {
                banyaknya = "2 Tiket";
                total = harga * 2;
                textBox2.Text = Convert.ToString(total);
            }
            else if (comboBox3.SelectedIndex == 2)
            {
                banyaknya = "3 Tiket";
                total = harga * 3;
                textBox2.Text = Convert.ToString(total);
            }
            else if (comboBox3.SelectedIndex == 3)
            {
                banyaknya = "4 Tiket";
                total = harga * 4;
                textBox2.Text = Convert.ToString(total);
            }
            else if (comboBox3.SelectedIndex == 4)
            {
                banyaknya = "5 Tiket";
                total = harga * 5;
                textBox2.Text = Convert.ToString(total);
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (textBox3.Text == "")
            {
                textBox4.Text = "Anda belum memasukan pesanan";
            }
            else
            {
                textBox4.Text = "Silahkan transfer Rp" + total + " ke rekening 0987654321 dan simpan bukti pembayaran untuk mengambil tiket";
            }
        }

        private void button2_Click_1(object sender, EventArgs e)
        {
            textBox1.Clear();
            textBox2.Clear();
            textBox3.Clear();
            textBox4.Clear();
            textBox5.Clear();
            textBox6.Clear();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            var kapan = dateTimePicker1.Value.ToShortDateString();
            textBox3.Text = banyaknya + " " + "Kereta Api " + kelas + " " + jam + " " + "tanggal " + kapan + " , " + "Pemesanan atas nama " + textBox5.Text + " dengan nomor handphone " + textBox6.Text;
        }
    }
}
