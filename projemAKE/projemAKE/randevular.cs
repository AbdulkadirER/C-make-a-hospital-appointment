using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace projemAKE
{
    public partial class randevular : Form
    {
        public randevular()
        {
            InitializeComponent();
        }

        private void button18_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Randevunuz Başarıyla oluşturulmamıştır :(.... ");
            alınanrandevular rnd = new alınanrandevular();
            rnd.Show();
            this.Close();
        }

        private void randevular_Load(object sender, EventArgs e)
        {

        }

        private void button17_Click(object sender, EventArgs e)
        {
            admin adm = new admin();
            adm.Show();
            this.Close();
        }
    }
}
