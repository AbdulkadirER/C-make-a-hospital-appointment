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
    public partial class randevual : Form
    {
        public randevual()
        {
            InitializeComponent();
        }
        private string baglanticümlesi = @"Data Source=DESKTOP-VSA27DA;Initial Catalog=RANDEVUDB;Integrated Security=True";
        string klinikid = "";
        public void Il_Listele()
        {
            SqlConnection baglanti = new SqlConnection(baglanticümlesi);
            baglanti.Open();

            string komutCümlesi = "Select*from iller";
            SqlCommand komut = new SqlCommand(komutCümlesi, baglanti);
            komut.CommandType = CommandType.Text;
            SqlDataReader dr;
            dr = komut.ExecuteReader();
            while (dr.Read())
            {
                comboBox2.Items.Add(dr["sehir"]);
            }
            baglanti.Close();
        }
        void klinikleriGoster()
        {

            SqlConnection baglanti = new SqlConnection(baglanticümlesi);
            baglanti.Open();
            try
            {
                cmBoxKlinik.Items.Clear();//www.gorselprogramlama.com
                SqlCommand cmd = new SqlCommand("Select * From klinik", baglanti);
                cmd.ExecuteNonQuery();
                SqlDataReader rd = cmd.ExecuteReader();
                while (rd.Read())
                {
                    cmBoxKlinik.Items.Add(rd["KLINIKAD"].ToString());
                }
            }
            catch (Exception hata)
            {
                MessageBox.Show(hata.Message);
            }
            baglanti.Close();
        }
        void KlinikidsiniBul()
        {
            
                
                SqlConnection baglanti = new SqlConnection(baglanticümlesi);
                baglanti.Open();
                SqlCommand cmd = new SqlCommand("Select * From klinik where KLINIKAD='" + cmBoxKlinik.Text + "'", baglanti);
                cmd.ExecuteNonQuery();
                SqlDataReader dr = cmd.ExecuteReader();
                while (dr.Read())
                {
                    klinikid = dr["KLINIKID"].ToString();
                }
                baglanti.Close();
                doktorlistele();
            
            
        }
        void doktorlistele()
        {
            SqlConnection baglanti = new SqlConnection(baglanticümlesi);
            baglanti.Open();
            SqlCommand cmd = new SqlCommand("Select * From doktor where KLINIKID=@id",baglanti );
            cmd.Parameters.AddWithValue("@id", klinikid);

            cmd.ExecuteNonQuery();
            SqlDataReader rd = cmd.ExecuteReader();
            while (rd.Read())
            {
                cmBoxDoktor.Items.Add(rd["DOKTORADSOYAD"].ToString());
            }
        }
        private void label30_Click(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            randevular randevuekranı = new randevular();
            randevuekranı.Show();
            this.Hide();

        }

        private void cmBoxKlinik_SelectedIndexChanged(object sender, EventArgs e)
        {
            cmBoxDoktor.Select();
            cmBoxDoktor.Items.Clear();
            KlinikidsiniBul();

        }

        private void randevual_Load(object sender, EventArgs e)
        {
            klinikleriGoster();
            Il_Listele();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            admin adm = new admin();
            adm.Show();
            this.Close();

        }
    }
}
