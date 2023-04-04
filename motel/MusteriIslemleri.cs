using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Data;
using System.Globalization;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace motel
{
    public class MusteriIslemleri
    {

        SqlConnection baglanti = new SqlConnection(DatabaseConstants.ConnectionString);

        private static log4net.ILog logManager = log4net.LogManager.GetLogger(typeof(MusteriIslemleri));
        public bool MusteriEkle(string adi, string soyad, string cinsiyet, string telefon, string mail, string tc, string odano, decimal ucret)
        {
            try
            {
                baglanti.Open();
                SqlCommand cmd = new SqlCommand("INSERT INTO Musteriler (Adi,Soyadi,Cinsiyet,Telefon,Mail,TC,OdaNo,Ucret) VALUES (@adi, @soyadi,@cinsiyet,@telefon,@mail,@tc,@odaNo,@ucret)", baglanti);

                cmd.Parameters.Add("@adi", SqlDbType.NVarChar).Value = adi;
                cmd.Parameters.Add("@soyadi", SqlDbType.NVarChar).Value = soyad;
                cmd.Parameters.Add("@cinsiyet", SqlDbType.NVarChar).Value = cinsiyet;
                cmd.Parameters.Add("@telefon", SqlDbType.NVarChar).Value = telefon;
                cmd.Parameters.Add("@mail", SqlDbType.NVarChar).Value = mail;
                cmd.Parameters.Add("@tc", SqlDbType.NVarChar).Value = tc;
                cmd.Parameters.Add("@odaNo", SqlDbType.NVarChar).Value = odano;
                cmd.Parameters.Add("@ucret", SqlDbType.Decimal).Value = ucret;
                cmd.ExecuteNonQuery();
                //SqlCommand komut = new SqlCommand("insert into Musteriler (Adi,Soyadi,Cinsiyet,Telefon,Mail,TC,OdaNo,Ucret) values ('" + textBox7.Text + "','" + textBox1.Text + "','" + comboBox1.Text + "','"+maskedTextBox1.Text+"','"+textBox4.Text +"','"+textBox5.Text+"',"+textBox3.Text+")", baglanti);
                //komut.ExecuteNonQuery();
                baglanti.Close();

                logManager.Info("Müşteri Eklendi. Ad Soyad: " + adi + " " + soyad);
                return true;
            }
            catch (Exception ex)
            {
                logManager.Error("Müşteri Ekleme İşlemi Hatalı. Hata: " + ex.Message);
                return false;
            }
        }

        public bool MusteriSil(int musteriId)
        {
            try
            {
                baglanti.Open();
                SqlCommand komut = new SqlCommand("delete from Musteriler where Musteriid = (" + musteriId + ")", baglanti);
                komut.ExecuteNonQuery();
                baglanti.Close();
                return true;
            }
            catch (Exception ex)
            {
                return false;
            }
        }
    }
}
