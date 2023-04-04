using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace motel
{
    internal class AdminIslemleri
    {
        SqlConnection baglanti = new SqlConnection(DatabaseConstants.ConnectionString);

        public bool Login(string kullaniciAdi, string sifre)
        {
            bool girisBasarili = false;
            try
            {
                baglanti.Open();
                string sql = "select * from AdminUsers where userName=@Kullaniciadi AND password=@Sifresi";
                SqlParameter prm1 = new SqlParameter("Kullaniciadi", kullaniciAdi);
                SqlParameter prm2 = new SqlParameter("Sifresi", sifre);
                SqlCommand komut = new SqlCommand(sql, baglanti);
                komut.Parameters.Add(prm1);
                komut.Parameters.Add(prm2);

                DataTable dt = new DataTable();
                SqlDataAdapter da = new SqlDataAdapter(komut);
                da.Fill(dt);

                if (dt.Rows.Count > 0)
                {
                    girisBasarili = true;
                }

                baglanti.Close();
            }
            catch (Exception ex)
            {
                // ex.Message loglama
                girisBasarili = false;
            }

            return girisBasarili;
        }
    }
}
