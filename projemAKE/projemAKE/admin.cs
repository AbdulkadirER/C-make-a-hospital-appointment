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

namespace projemAKE
{
    public partial class admin : Form
    {
        public admin()
        {
            InitializeComponent();
        }
        SqlConnection uyebaglantisi = new SqlConnection("Data Source=DESKTOP-VSA27DA;Initial Catalog=RANDEVUDB;Integrated Security=True");
        private void btnCikis_Click(object sender, EventArgs e)
        {
            
            MessageBox.Show("çıkış yapıldı");
            giris girisyap = new giris();
            girisyap.Show();  
            this.Hide();   
        }
        string tcNo = "";
        string Parola = "";
        public admin(string tc, string parola)
        {
            InitializeComponent();
            tcNo = tc;
            Parola = parola;
        }

        private void btnHesap_Click(object sender, EventArgs e)
        {
            bilgi_güncel bilgi = new bilgi_güncel();
            bilgi.ShowDialog();
            
        }


        private void button2_Click(object sender, EventArgs e)
        {
            randevual randevu = new randevual();
            randevu.Show();
            this.Hide();
        }
        void uyeBilgileriniGoster()
        {
            uyebaglantisi.Open();
            SqlCommand cmd = new SqlCommand("Select * From hasta where TC='" + tcNo + "' ", uyebaglantisi);
            cmd.ExecuteNonQuery();
            SqlDataReader read = cmd.ExecuteReader();
            while (read.Read())
            {
                lblTC.Text = read["TC"].ToString();
                lblAdSoyad.Text = read["ADI"].ToString() + " " + read["SOYADI"].ToString();
                lblDogumYeriTarihi.Text = read["DOGUMYERI"].ToString() + " / " + read["DOGUMTARIHI"].ToString();
                lblCinsiyet.Text = read["CINSIYETI"].ToString();
                lblTel.Text = read["CEPTEL"].ToString();

            }
           uyebaglantisi.Close();
        }


        private void admin_Load_1(object sender, EventArgs e)
        {
            uyeBilgileriniGoster();
        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {
            uyeBilgileriniGoster();
        }

        private void panel2_Paint(object sender, PaintEventArgs e)
        {

        }
    }
}
