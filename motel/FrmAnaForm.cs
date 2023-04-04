using System;
using System.Windows.Forms;

namespace motel
{
    public partial class FrmAnaForm : Form
    {
        private string kullaniciAdi = "";
        public FrmAnaForm()
        {
            InitializeComponent();
        }
        public FrmAnaForm(string kullaniciAdi)
        {
            this.kullaniciAdi = kullaniciAdi;
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {

        }

        private void button2_Click(object sender, EventArgs e)
        {
            FrmYeniMusteri fr = new FrmYeniMusteri();
            fr.Show();
            
            
        }

        private void button3_Click(object sender, EventArgs e)
        {
            FrmOdalar fr = new FrmOdalar();
            fr.Show();
        }
        private void button4_Click(object sender, EventArgs e)
        {
            FrmMusteriler fr = new FrmMusteriler();
            fr.Show();
        }

        private void buttcikis_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void FrmAnaForm_Load(object sender, EventArgs e)
        {
            timer1.Start();
        }
        
        private void timer1_Tick_1(object sender, EventArgs e)
        {
            label1.Text = DateTime.Now.ToLongDateString();
            label2.Text = DateTime.Now.ToLongTimeString();

        }
    }

}
