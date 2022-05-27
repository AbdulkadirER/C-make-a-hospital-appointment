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
    public partial class kayitol : Form
    {
        public kayitol()
        {
            InitializeComponent();
        }
        
        SqlConnection uyebaglantisi = new SqlConnection("Data Source=DESKTOP-VSA27DA;Initial Catalog=RANDEVUDB;Integrated Security=True");

        private void button1_Click(object sender, EventArgs e)
        {
            kontrol();
        
            
            //uyebaglantisi.Open();
            //SqlCommand baglanti = new SqlCommand("insert into hasta(TC,ADİ,SOYADİ,CİNSİYETİ,DOGUMYERİ,DOGUMTARİHİ,BABAADİ,ANNEADİ,CEPTEL,EPOSTA,Parola) values ('" + txttc.Text.ToString() + "','" + txtad.Text + "','" + txtsoyad.Text + "','" + cbxcins + "','" + txtdogum.Text + "','" + msktarih.Text.ToString() + "','" + txtbaba.Text + "','" + txtana.Text + "','" + msktel.Text.ToString() + "','" + txteposta.Text + "','" + txtparola.Text + "')", uyebaglantisi);
            //baglanti.ExecuteNonQuery();
            //uyebaglantisi.Close();
            ////giris girisyap = new giris();
            ////girisyap.Show();  
            ////this.Hide();   
        } 
        

        public void uyeEkle()
        {
           bool kayıtvarmı = false;
            uyebaglantisi.Open();
            SqlCommand comut = new SqlCommand("Select * From hasta", uyebaglantisi);
            comut.ExecuteNonQuery();
            SqlDataReader read = comut.ExecuteReader();
            while (read.Read())
            {
                if (read["TC"].ToString() == txttc.Text)
                {
                    kayıtvarmı = true;
                    uyebaglantisi.Close();
                    MessageBox.Show("sistemde kaydınız bulunmakta,şifreninizi unuttuysanız şifremi unuttum butonundan şifrenizi öğrenin");
                    break;
                }

            }   
            
            if (kayıtvarmı == false)

                {
                    read.Close();
                    SqlCommand baglanti = new SqlCommand("insert into hasta(TC,ADI,SOYADI,CINSIYETI,DOGUMYERI,DOGUMTARIHI,BABAAD,ANNEAD,CEPTEL,EPOSTA,Parola) values ('" + txttc.Text.ToString() + "','" + txtad.Text + "','" + txtsoyad.Text + "','" + cbxcins.SelectedItem + "','" + txtdogum.Text + "','" + msktarih.Text.ToString() + "','" + txtbaba.Text + "','" + txtana.Text + "','" + msktel.Text.ToString() + "','" + txteposta.Text + "','" + txtparola.Text + "')", uyebaglantisi);
                    baglanti.ExecuteNonQuery();


                    uyebaglantisi.Close();

                    MessageBox.Show("İşlem Başarılı");
                    giris grs = new giris();
                    grs.Show();
                    this.Close();

                   

                }




        }

     

        private void btnCikis_Click(object sender, EventArgs e)
        {
            giris grs = new giris();
            grs.Show();
            this.Close();

        }
        void kontrol()
        {
           
            if (txttc.Text == "" || txtad.Text == "" || txtsoyad.Text == "" || cbxcins.Text == "" || txtana.Text == "" || txtbaba.Text == "" || txtdogum.Text == "" || txteposta.Text == "" || txtparola.Text == "" || msktarih.Text == "" || msktarih.Text == "")
            {
                MessageBox.Show("Bütün Alanların Doldulurması Zorunludur.");
            }
            else
            {
                uyeEkle();
            }


        }

        private void kayitol_Load(object sender, EventArgs e)
        {

        }
    }
}
