
namespace projemAKE
{
    partial class alınanrandevular
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(alınanrandevular));
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle2 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle3 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle4 = new System.Windows.Forms.DataGridViewCellStyle();
            this.label1 = new System.Windows.Forms.Label();
            this.picBoxDBColumnİsimleri = new System.Windows.Forms.PictureBox();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.RandevuTarihi = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.RandevuSaati = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Poliklinik = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.OnayKodu = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.İslem = new System.Windows.Forms.DataGridViewButtonColumn();
            this.btnCikis = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.picBoxDBColumnİsimleri)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.btnCikis)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label1.Location = new System.Drawing.Point(364, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(163, 25);
            this.label1.TabIndex = 1;
            this.label1.Text = "Randevularım ";
            // 
            // picBoxDBColumnİsimleri
            // 
            this.picBoxDBColumnİsimleri.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("picBoxDBColumnİsimleri.BackgroundImage")));
            this.picBoxDBColumnİsimleri.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.picBoxDBColumnİsimleri.Location = new System.Drawing.Point(12, 76);
            this.picBoxDBColumnİsimleri.Name = "picBoxDBColumnİsimleri";
            this.picBoxDBColumnİsimleri.Size = new System.Drawing.Size(919, 34);
            this.picBoxDBColumnİsimleri.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.picBoxDBColumnİsimleri.TabIndex = 129;
            this.picBoxDBColumnİsimleri.TabStop = false;
            // 
            // dataGridView1
            // 
            this.dataGridView1.BackgroundColor = System.Drawing.Color.White;
            this.dataGridView1.CellBorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.SingleHorizontal;
            dataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle1.BackColor = System.Drawing.SystemColors.WindowFrame;
            dataGridViewCellStyle1.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            dataGridViewCellStyle1.ForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle1.SelectionBackColor = System.Drawing.SystemColors.WindowFrame;
            dataGridViewCellStyle1.SelectionForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dataGridView1.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle1;
            this.dataGridView1.ColumnHeadersHeight = 30;
            this.dataGridView1.ColumnHeadersVisible = false;
            this.dataGridView1.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.RandevuTarihi,
            this.RandevuSaati,
            this.Poliklinik,
            this.OnayKodu,
            this.İslem});
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle2.BackColor = System.Drawing.Color.White;
            dataGridViewCellStyle2.Font = new System.Drawing.Font("Arial", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            dataGridViewCellStyle2.ForeColor = System.Drawing.Color.Black;
            dataGridViewCellStyle2.SelectionBackColor = System.Drawing.Color.White;
            dataGridViewCellStyle2.SelectionForeColor = System.Drawing.Color.Black;
            dataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.dataGridView1.DefaultCellStyle = dataGridViewCellStyle2;
            this.dataGridView1.GridColor = System.Drawing.SystemColors.WindowFrame;
            this.dataGridView1.Location = new System.Drawing.Point(12, 116);
            this.dataGridView1.MultiSelect = false;
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.ReadOnly = true;
            this.dataGridView1.RowHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.Single;
            dataGridViewCellStyle3.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dataGridView1.RowHeadersDefaultCellStyle = dataGridViewCellStyle3;
            this.dataGridView1.RowHeadersVisible = false;
            this.dataGridView1.RowHeadersWidth = 66;
            dataGridViewCellStyle4.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle4.BackColor = System.Drawing.Color.White;
            dataGridViewCellStyle4.Font = new System.Drawing.Font("Arial", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            dataGridViewCellStyle4.ForeColor = System.Drawing.Color.Black;
            dataGridViewCellStyle4.SelectionBackColor = System.Drawing.Color.White;
            dataGridViewCellStyle4.SelectionForeColor = System.Drawing.Color.Black;
            this.dataGridView1.RowsDefaultCellStyle = dataGridViewCellStyle4;
            this.dataGridView1.RowTemplate.ReadOnly = true;
            this.dataGridView1.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
            this.dataGridView1.Size = new System.Drawing.Size(919, 309);
            this.dataGridView1.TabIndex = 130;
            // 
            // RandevuTarihi
            // 
            this.RandevuTarihi.HeaderText = "Randevu Tarihi";
            this.RandevuTarihi.Name = "RandevuTarihi";
            this.RandevuTarihi.ReadOnly = true;
            // 
            // RandevuSaati
            // 
            this.RandevuSaati.HeaderText = "Randevu Saati";
            this.RandevuSaati.Name = "RandevuSaati";
            this.RandevuSaati.ReadOnly = true;
            this.RandevuSaati.Width = 230;
            // 
            // Poliklinik
            // 
            this.Poliklinik.HeaderText = "Poliklinik";
            this.Poliklinik.Name = "Poliklinik";
            this.Poliklinik.ReadOnly = true;
            this.Poliklinik.Width = 245;
            // 
            // OnayKodu
            // 
            this.OnayKodu.HeaderText = "Onay Kodu";
            this.OnayKodu.Name = "OnayKodu";
            this.OnayKodu.ReadOnly = true;
            this.OnayKodu.Width = 265;
            // 
            // İslem
            // 
            this.İslem.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.İslem.HeaderText = "İşlem";
            this.İslem.Name = "İslem";
            this.İslem.ReadOnly = true;
            this.İslem.Text = "İptal Et";
            this.İslem.UseColumnTextForButtonValue = true;
            this.İslem.Width = 56;
            // 
            // btnCikis
            // 
            this.btnCikis.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.btnCikis.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnCikis.Image = ((System.Drawing.Image)(resources.GetObject("btnCikis.Image")));
            this.btnCikis.Location = new System.Drawing.Point(886, 12);
            this.btnCikis.Name = "btnCikis";
            this.btnCikis.Size = new System.Drawing.Size(45, 40);
            this.btnCikis.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.btnCikis.TabIndex = 131;
            this.btnCikis.TabStop = false;
            this.btnCikis.Click += new System.EventHandler(this.btnCikis_Click);
            // 
            // alınanrandevular
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.MediumTurquoise;
            this.ClientSize = new System.Drawing.Size(943, 466);
            this.Controls.Add(this.btnCikis);
            this.Controls.Add(this.dataGridView1);
            this.Controls.Add(this.picBoxDBColumnİsimleri);
            this.Controls.Add(this.label1);
            this.Name = "alınanrandevular";
            this.Text = "alınanrandevular";
            this.Load += new System.EventHandler(this.alınanrandevular_Load);
            ((System.ComponentModel.ISupportInitialize)(this.picBoxDBColumnİsimleri)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.btnCikis)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Label label1;
        public System.Windows.Forms.PictureBox picBoxDBColumnİsimleri;
        public System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.DataGridViewTextBoxColumn RandevuTarihi;
        private System.Windows.Forms.DataGridViewTextBoxColumn RandevuSaati;
        private System.Windows.Forms.DataGridViewTextBoxColumn Poliklinik;
        private System.Windows.Forms.DataGridViewTextBoxColumn OnayKodu;
        private System.Windows.Forms.DataGridViewButtonColumn İslem;
        private System.Windows.Forms.PictureBox btnCikis;
    }
}