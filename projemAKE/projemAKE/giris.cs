using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

using System.Data.SqlClient;

namespace projemAKE
{
    public partial class giris : Form
    {
        
        public giris()
        {
            InitializeComponent();
        }
        SqlConnection uyebaglantisi = new SqlConnection("Data Source=DESKTOP-VSA27DA;Initial Catalog=RANDEVUDB;Integrated Security=True");

        private void grsbtn_Click(object sender, EventArgs e)
        {

            Uye_Girisi();

            //uyebaglantisi.Open();
            //SqlCommand baglanti = new SqlCommand("Select * From hasta where TC='" + kimlik1.Text + "' and PAROLA='" + sifre1.Text + "'", uyebaglantisi); 
            //baglanti.ExecuteNonQuery();
            //uyebaglantisi.Close();


            //if (kimlik1.Text==""|| sifre1.Text=="")
            //{
            //    MessageBox.Show("kullanıcı adı ve şifre boş geçilemez");
            //}
            //else
            //{
            //    if (kimlik1.Text=="admin"&& sifre1.Text=="123")
            //    {
            //        admin admingrs = new admin();
            //        admingrs.Show();
            //        this.Hide();
            //    }
            //    else
            //    {
            //        MessageBox.Show("kullanıcı adı veya şifre hatalı");
            //    }

            //}
        }
        bool basarılımı = false;
        void Uye_Girisi()
        {
          
            try
            {
                uyebaglantisi.Open();
                SqlCommand baglanti = new SqlCommand("Select * From hasta where TC='" + kimlik1.Text + "' and PAROLA='" + sifre1.Text + "'", uyebaglantisi);
                baglanti.ExecuteNonQuery();
                SqlDataReader kurulubaglanti = baglanti.ExecuteReader();

                while (kurulubaglanti.Read())
                {
                        admin rara = new admin(kimlik1.Text, sifre1.Text);
                         rara.Show();
                        this.Hide();
                        basarılımı = true;
                }
                

                if (basarılımı == true)
                {
                    MessageBox.Show("Başarılı giriş");
                }

                if (basarılımı == false)
                {
                    MessageBox.Show("Hatalı Kullanıcı Adı veya Parola");
                }
            }
            catch (Exception)
            {
                uyebaglantisi.Close();
                MessageBox.Show("Bağlantı kurulamadı");
            }
            
        }
       

        private void button2_Click(object sender, EventArgs e)
        {
            kayitol kayıt = new kayitol();
            kayıt.Show();  
            this.Hide();   
        }


        private void button1_Click(object sender, EventArgs e)
        {
            sifreogren sifre = new sifreogren();
            sifre.Show();
            this.Hide();
        }

        private void giris_Load(object sender, EventArgs e)
        {

        }

        private void groupBox1_Enter(object sender, EventArgs e)
        {

        }
    }
}
