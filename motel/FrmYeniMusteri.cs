using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.Sql;
using System.Data.SqlClient;
using System.Xml.Linq;
using System.Globalization;

namespace motel
{
    public partial class FrmYeniMusteri : Form
    {
        public FrmYeniMusteri()
        {
            InitializeComponent();
        }
        SqlConnection baglanti = new SqlConnection(DatabaseConstants.ConnectionString);


        private void OdaDurumunuGoster(Button odaButton, string odaNumarasi)
        {
            baglanti.Open();
            SqlCommand komut = new SqlCommand("select * from Oda" + odaNumarasi, baglanti);
            SqlDataReader oku = komut.ExecuteReader();

            while (oku.Read())
            {
                odaButton.Text = oku["Adi"].ToString() + " " + oku["Soyadi"].ToString();
            }
            baglanti.Close();
            if (odaButton.Text != odaNumarasi)
            {
                odaButton.BackColor = Color.Red;
                odaButton.Enabled = false;
            }
        }

        private void OdaEkle(string odaNumarasi)
        {
            if (string.IsNullOrEmpty(textBox7.Text) || string.IsNullOrEmpty(textBox1.Text))
            {
                MessageBox.Show("Lütfen ad ve soyad alanlarını doldurunuz!", "Hata", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            textBox6.Text = odaNumarasi;
            baglanti.Open();
            SqlCommand komut = new SqlCommand("insert into Oda" + odaNumarasi + " values('" + textBox7.Text + "','" + textBox1.Text + "')", baglanti);
            komut.ExecuteNonQuery();
            baglanti.Close();
        }
        private void button2_Click(object sender, EventArgs e)
        {
            try
            {
                OdaEkle("21");
                OdaDurumunuGoster(button2, "21");
            }
            catch (Exception)
            {
                MessageBox.Show("oda 21 hata");
            }
        }

        private void button9_Click(object sender, EventArgs e)
        {
            try
            {
                OdaEkle("22");
                OdaDurumunuGoster(button9, "22");
            }
            catch (Exception)
            {
                MessageBox.Show("oda 22 hata");
            }
        }

        private void button8_Click(object sender, EventArgs e)
        {
            try
            {
                OdaEkle("23");
                OdaDurumunuGoster(button8, "23");
            }
            catch (Exception)
            {
                MessageBox.Show("oda 23 hata");
            }
        }

        private void button3_Click(object sender, EventArgs e)
        {
            try
            {
                OdaEkle("24");
                OdaDurumunuGoster(button3, "24");
            }
            catch (Exception)
            {
                MessageBox.Show("oda 24 hata");
            }
        }

        private void button10_Click(object sender, EventArgs e)
        {
            try
            {
                OdaEkle("25");
                OdaDurumunuGoster(button10, "25");
            }
            catch (Exception)
            {
                MessageBox.Show("oda 25 hata");
            }
        }

        private void button7_Click(object sender, EventArgs e)
        {
            try
            {
                OdaEkle("26");
                OdaDurumunuGoster(button7, "26");
            }
            catch (Exception)
            {
                MessageBox.Show("oda 26 hata");
            }
        }

        private void button4_Click(object sender, EventArgs e)
        {
            try
            {
                OdaEkle("27");
                OdaDurumunuGoster(button4, "27");
            }
            catch (Exception)
            {
                MessageBox.Show("oda 27 hata");
            }
        }

        private void button5_Click(object sender, EventArgs e)
        {
            try
            {
                OdaEkle("28");
                OdaDurumunuGoster(button5, "28");
            }
            catch (Exception)
            {
                MessageBox.Show("oda 28 hata");
            }
        }

        private void button6_Click(object sender, EventArgs e)
        {
            try
            {
                OdaEkle("29");
                OdaDurumunuGoster(button6, "29");
            }
            catch (Exception)
            {
                MessageBox.Show("oda 29 hata");
            }
        }

        private void button11_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Kırmızı Renkli Odalar Dolu Olduğunu Gösterir");
        }

        private void button12_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Yeşil Renkli Odalar Boş Olduğunu Gösterir");
        }


        private void dateTimePicker2_ValueChanged(object sender, EventArgs e)
        {
            int Ucret;
            DateTime KucukTarih = Convert.ToDateTime(dateTimePicker1.Text);
            DateTime BuyukTarih = Convert.ToDateTime(dateTimePicker2.Text);

            TimeSpan Sonuc;
            Sonuc = BuyukTarih - KucukTarih;

            label11.Text = Sonuc.TotalDays.ToString();

            Ucret = Convert.ToInt32(label11.Text) * 400;
            textBox3.Text = Ucret.ToString();

            
        }

        private void button1_Click(object sender, EventArgs e)
        {
            MusteriIslemleri ms = new MusteriIslemleri();
            decimal ucret = Convert.ToDecimal(textBox3.Text, CultureInfo.CurrentCulture);
            var result = ms.MusteriEkle(textBox7.Text, textBox1.Text, comboBox1.Text, maskedTextBox1.Text, textBox4.Text, textBox5.Text, textBox6.Text, ucret);
            if (result)
                MessageBox.Show("Müşteri Kaydı Yapıldı");
            else
                MessageBox.Show("İşlem sırasında hata oluştu.");
            //baglanti.Open();
            //SqlCommand cmd = new SqlCommand("INSERT INTO Musteriler (Adi,Soyadi,Cinsiyet,Telefon,Mail,TC,OdaNo,Ucret) VALUES (@adi, @soyadi,@cinsiyet,@telefon,@mail,@tc,@odaNo,@ucret)", baglanti);

            //cmd.Parameters.Add("@adi", SqlDbType.NVarChar).Value = textBox7.Text;
            //cmd.Parameters.Add("@soyadi", SqlDbType.NVarChar).Value = textBox1.Text;
            //cmd.Parameters.Add("@cinsiyet", SqlDbType.NVarChar).Value = comboBox1.Text;
            //cmd.Parameters.Add("@telefon", SqlDbType.NVarChar).Value = maskedTextBox1.Text;
            //cmd.Parameters.Add("@mail", SqlDbType.NVarChar).Value = textBox4.Text;
            //cmd.Parameters.Add("@tc", SqlDbType.NVarChar).Value = textBox5.Text;
            //cmd.Parameters.Add("@odaNo", SqlDbType.NVarChar).Value = textBox6.Text;
            //cmd.Parameters.Add("@ucret", SqlDbType.Decimal).Value = Convert.ToDecimal(textBox3.Text, CultureInfo.CurrentCulture);
            //cmd.ExecuteNonQuery();
            ////SqlCommand komut = new SqlCommand("insert into Musteriler (Adi,Soyadi,Cinsiyet,Telefon,Mail,TC,OdaNo,Ucret) values ('" + textBox7.Text + "','" + textBox1.Text + "','" + comboBox1.Text + "','"+maskedTextBox1.Text+"','"+textBox4.Text +"','"+textBox5.Text+"',"+textBox3.Text+")", baglanti);
            ////komut.ExecuteNonQuery();
            //baglanti.Close();
        }

        private void FrmYeniMusteri_Load(object sender, EventArgs e)
        {
            OdaDurumunuGoster(button2, "21");
            OdaDurumunuGoster(button9, "22");
            OdaDurumunuGoster(button8, "23");
            OdaDurumunuGoster(button3, "24");
            OdaDurumunuGoster(button10, "25");
            OdaDurumunuGoster(button7, "26");
            OdaDurumunuGoster(button4, "27");
            OdaDurumunuGoster(button5, "28");
            OdaDurumunuGoster(button6, "29");
        }

        private void label10_Click(object sender, EventArgs e)
        {

        }

        private void textBox6_TextChanged(object sender, EventArgs e)
        {

        }

        private void maskedTextBox1_MaskInputRejected(object sender, MaskInputRejectedEventArgs e)
        {

        }

        private void groupBox2_Enter(object sender, EventArgs e)
        {

        }
    }
}
//Data Source=DESKTOP-1N99DOO\SQLEXPRESS;Initial Catalog=Motel;Integrated Security=True


