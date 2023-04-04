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

namespace motel
{
    public partial class FrmOdalar : Form
    {
        public FrmOdalar()
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

        private void FrmOdalar_Load(object sender, EventArgs e)
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

        private void button10_Click(object sender, EventArgs e)
        {

        }

        private void button9_Click(object sender, EventArgs e)
        {

        }
    }
}
