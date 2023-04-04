using System;
using System.Windows.Forms;
using System.Data.Sql;
using System.Data.SqlClient;
using System.Globalization;

namespace motel
{
    public partial class FrmMusteriler : Form
    {
        public FrmMusteriler()
        {
            InitializeComponent();
        }

        SqlConnection baglanti = new SqlConnection(DatabaseConstants.ConnectionString);

        private void verilergoster()
        {
            listView1.Items.Clear();
            baglanti.Open();
            SqlCommand komut = new SqlCommand("select * from Musteriler", baglanti);
            SqlDataReader oku = komut.ExecuteReader();

            while (oku.Read())
            {
                //müşteri eklekısmında otomatik artmasını ve eklemsini sağlar.
                ListViewItem ekle = new ListViewItem();
                ekle.Text = oku["Musteriid"].ToString();
                ekle.SubItems.Add(oku["Adi"].ToString());
                ekle.SubItems.Add(oku["Soyadi"].ToString());
                ekle.SubItems.Add(oku["Cinsiyet"].ToString());
                ekle.SubItems.Add(oku["Telefon"].ToString());
                ekle.SubItems.Add(oku["Mail"].ToString());
                ekle.SubItems.Add(oku["TC"].ToString());
                ekle.SubItems.Add(oku["OdaNo"].ToString());
                ekle.SubItems.Add(oku["Ucret"].ToString());
                ekle.SubItems.Add(oku["GirisTarihi"].ToString());
                ekle.SubItems.Add(oku["CikisTarihi"].ToString());

                listView1.Items.Add(ekle);

            }
            baglanti.Close();

        }
        int id = 0;

        private void button1_Click(object sender, EventArgs e)
        {

            listView1.Items.Clear();
            baglanti.Open();
            SqlCommand komut = new SqlCommand("Select * from Musteriler where adi like '%" + textBox2.Text + "%'", baglanti);
            SqlDataReader oku = komut.ExecuteReader();
            while (oku.Read())
            {
                ListViewItem ekle = new ListViewItem();
                ekle.Text = oku["Musteriid"].ToString();
                ekle.SubItems.Add(oku["Adi"].ToString());
                ekle.SubItems.Add(oku["Soyadi"].ToString());
                ekle.SubItems.Add(oku["Cinsiyet"].ToString());
                ekle.SubItems.Add(oku["Telefon"].ToString());
                ekle.SubItems.Add(oku["Mail"].ToString());
                ekle.SubItems.Add(oku["TC"].ToString());
                ekle.SubItems.Add(oku["OdaNo"].ToString());
                ekle.SubItems.Add(oku["Ucret"].ToString());
                ekle.SubItems.Add(oku["GirisTarihi"].ToString());
                ekle.SubItems.Add(oku["CikisTarihi"].ToString());


                listView1.Items.Add(ekle);
            }
            baglanti.Close();

        }


        private void button1_Click_1(object sender, EventArgs e)
        {
            verilergoster();
        }

        private void btnguncelle_Click(object sender, EventArgs e)
        {
            try
            {
                baglanti.Open();
                SqlCommand komut = new SqlCommand("update Musteriler set Adi='" + textBox7.Text + "',Soyadi='" + textBox1.Text + "',Cinsiyet='" + comboBox1.Text + "',Telefon='" + maskedTextBox1.Text + "',Mail='" + textBox4.Text + "',TC='" + textBox5.Text + "',OdaNo='" + textBox6.Text + "',Ucret='" + textBox3.Text + "',GirisTarihi ='" + dateTimePicker1.Value.ToString("yyyy-MM-dd") + "',CikisTarihi='" + dateTimePicker2.Value.ToString("yyyy-MM-dd") + "' where Musteriid=" + id + "", baglanti);

                komut.ExecuteNonQuery();
                baglanti.Close();
                verilergoster();
            }
            catch (Exception)
            {
                MessageBox.Show("Güncelleme Butonu Hatalı. ");
            }
        }

        private void btnsil_Click(object sender, EventArgs e)
        {
            MusteriIslemleri ms = new MusteriIslemleri();
            var result = ms.MusteriSil(id);
            if (result)
            {
                MessageBox.Show("Müşteri Silindi");
                verilergoster();
            }
            else
                MessageBox.Show("Müşteri Silme işlemi hatalı");

        }
        private void listView1_SelectedIndexChanged(object sender, EventArgs e)
        {
            id = 0;
        }

        private void textBox2_TextChanged(object sender, EventArgs e)
        {

        }

        private void FrmMusteriler_Load(object sender, EventArgs e)
        {

        }


        private void listView1_DoubleClick_1(object sender, EventArgs e)
        {
            id = int.Parse(listView1.SelectedItems[0].SubItems[0].Text);
            textBox7.Text = listView1.SelectedItems[0].SubItems[1].Text;
            textBox1.Text = listView1.SelectedItems[0].SubItems[2].Text;
            comboBox1.Text = listView1.SelectedItems[0].SubItems[3].Text;
            maskedTextBox1.Text = listView1.SelectedItems[0].SubItems[4].Text;
            textBox4.Text = listView1.SelectedItems[0].SubItems[5].Text;
            textBox5.Text = listView1.SelectedItems[0].SubItems[6].Text;
            textBox6.Text = listView1.SelectedItems[0].SubItems[7].Text;
            textBox3.Text = listView1.SelectedItems[0].SubItems[8].Text;
            dateTimePicker1.Text = listView1.SelectedItems[0].SubItems[9].Text;
            dateTimePicker2.Text = listView1.SelectedItems[0].SubItems[10].Text;
        }

        private void btntemiz_Click(object sender, EventArgs e)
        {
            try
            {
                textBox7.Clear();
                textBox1.Clear();
                comboBox1.Text = "";
                maskedTextBox1.Clear();
                textBox4.Clear();
                textBox5.Clear();
                textBox6.Clear();
                textBox3.Clear();
                dateTimePicker1.Text = "";
                dateTimePicker2.Text = "";
            }
            catch (Exception)
            {
                MessageBox.Show("Temizleme Butonu Hatalı. ");
            }
        }
    }
}
//Data Source = DESKTOP - 1N99DOO\SQLEXPRESS; Initial Catalog = model; Integrated Security = True

/*MessageBox.Show("ODA ÇIKIŞI YAPILDI.");
try
{
    if (textBox6.Text == "21")
    {
        baglanti.Open();
        SqlCommand komut = new SqlCommand("delete from Oda21", baglanti);
        komut.ExecuteNonQuery();
        baglanti.Close();
        verilergoster();
    }
}
catch (Exception)
{
    MessageBox.Show("Silme Butonu Hatalı.");
}




try
{
    if (textBox6.Text == "22")
    {
        baglanti.Open();
        SqlCommand komut = new SqlCommand("delete from Oda22", baglanti);
        komut.ExecuteNonQuery();
        baglanti.Close();
        verilergoster();
    }
}
catch (Exception)
{
    MessageBox.Show("Silme Butonu Hatalı. ");
}

try
{
    if (textBox6.Text == "23")
    {
        baglanti.Open();
        SqlCommand komut = new SqlCommand("delete from Oda23", baglanti);
        komut.ExecuteNonQuery();
        baglanti.Close();
        verilergoster();
    }
}
catch (Exception)
{
    MessageBox.Show("Silme Butonu Hatalı. ");
}

try
{
    if (textBox6.Text == "24")
    {
        baglanti.Open();
        SqlCommand komut = new SqlCommand("delete from Oda24", baglanti);
        komut.ExecuteNonQuery();
        baglanti.Close();
        verilergoster();
    }

}
catch (Exception)
{
    MessageBox.Show("Silme Butonu Hatalı. ");

}

try
{
    if (textBox6.Text == "25")
    {
        baglanti.Open();
        SqlCommand komut = new SqlCommand("delete from Oda25", baglanti);
        komut.ExecuteNonQuery();
        baglanti.Close();
        verilergoster();
    }
}
catch (Exception)
{
    MessageBox.Show("Silme Butonu Hatalı. ");
}

try
{
    if (textBox6.Text == "26")
    {
        baglanti.Open();
        SqlCommand komut = new SqlCommand("delete from Oda26", baglanti);
        komut.ExecuteNonQuery();
        baglanti.Close();
        verilergoster();
    }
}
catch (Exception)
{
    MessageBox.Show("Silme Butonu Hatalı. ");
}

try
{
    if (textBox6.Text == "27")
    {
        baglanti.Open();
        SqlCommand komut = new SqlCommand("delete from Oda27", baglanti);
        komut.ExecuteNonQuery();
        baglanti.Close();
        verilergoster();
    }
}
catch (Exception)
{
    MessageBox.Show("Silme Butonu Hatalı. ");

}

try
{
    if (textBox6.Text == "28")
    {
        baglanti.Open();
        SqlCommand komut = new SqlCommand("delete from Oda28", baglanti);
        komut.ExecuteNonQuery();
        baglanti.Close();
        verilergoster();
    }
}
catch (Exception)
{
    MessageBox.Show("Silme Butonu Hatalı. ");

}

try
{
    if (textBox6.Text == "29")
    {
        baglanti.Open();
        SqlCommand komut = new SqlCommand("delete from Oda29,", baglanti);
        komut.ExecuteNonQuery();
        baglanti.Close();
        verilergoster();
    }
}
catch (Exception)
{
    MessageBox.Show("Silme Butonu Hatalı. ");
}*/
