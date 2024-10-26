using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace yemeksepeti
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void label4_Click(object sender, EventArgs e)
        {

        }
        double toplam = 0;
        private void Hesapla_Click(object sender, EventArgs e)
        {
            string urunAdi;
            double urunFiyat;
            urunAdi = textBox1.Text;
            double toplam = 0;
            urunFiyat = Convert.ToDouble(textBox2.Text);
            if (radioButton1.Checked)
            {
                urunFiyat=urunFiyat - (urunFiyat * 3) / 100;
                toplam = toplam + urunFiyat;
            }
            else if (radioButton2.Checked)
            {
                urunFiyat = urunFiyat - (urunFiyat * 5) / 100;
                toplam = toplam + urunFiyat;
            }
            else if (radioButton3.Checked)
            {
                toplam = urunFiyat;
            }
            else
            {
                MessageBox.Show("Bir seçim yapınız");
            }
            listBox1.Items.Add($"Ürün Adı{urunAdi} Ürün Fiyatı{urunFiyat}");
            textBox3.Text = toplam.ToString();

        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            textBox1.Clear();
            textBox2.Clear();
            textBox3.Clear();
            listBox1.Items.Clear();

        }
    }
}
