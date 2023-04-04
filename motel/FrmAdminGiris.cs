using System;
using System.Windows.Forms;

namespace motel
{
    public partial class FrmAdminGiris : Form
    {
        public FrmAdminGiris()
        {
            InitializeComponent();
        }
        private static log4net.ILog logManager = log4net.LogManager.GetLogger(typeof(FrmAdminGiris));

        private void button1_Click(object sender, EventArgs e)
        {
            AdminIslemleri admin = new AdminIslemleri();
            bool login = admin.Login(textBox1.Text, textBox2.Text);
            if (login)
            {
                logManager.Info("Login başarılı");
                FrmAnaForm fr = new FrmAnaForm(textBox1.Text);
                fr.Show();
                this.Hide();
            }
            else
            {
                logManager.Info("Login hatalı");
                MessageBox.Show("Kullanıcı Adı veya Şifre Hatalı");
            }

        }

        private void FrmAdminGiris_Load(object sender, EventArgs e)
        {

        }
    }
}