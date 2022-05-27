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
    public partial class alınanrandevular : Form
    {
        public alınanrandevular()
        {
            InitializeComponent();
        }

        private void btnCikis_Click(object sender, EventArgs e)
        {
            admin anapanel = new admin();
            anapanel.Show();
            this.Hide();
        }

        private void alınanrandevular_Load(object sender, EventArgs e)
        {

        }
    }
}
