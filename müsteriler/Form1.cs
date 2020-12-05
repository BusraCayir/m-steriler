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

namespace müsteriler
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
            this.IsMdiContainer = true;
        }

        SqlConnection baglanti = new SqlConnection //veritabanı bağlantı 
   (@"Data Source=DESKTOP-H47EA7C;Initial Catalog=TestDevexpress;Integrated Security=True");
        müsteri fr2 = new müsteri();
        private void mÜŞTERİLERToolStripMenuItem_Click(object sender, EventArgs e)
        {
          
            fr2.MdiParent = this;
            fr2.Show();
            fr2.listele();
            
        }

        private void eKLEToolStripMenuItem_Click(object sender, EventArgs e)
        {
            baglanti.Open();
            SqlCommand command = new SqlCommand("insert into müsteriler (yil,ay,tarih,firma,sube,tutar1,tutar2,tutar3) values (@yili,@ayi,@tarihi,@firmasi,@subesi,@tutar1s,@tutar2s,@tutar3s)", baglanti);
            command.Parameters.AddWithValue("@yili", fr2.yil);
            command.Parameters.AddWithValue("@ayi", fr2.ay);
            command.Parameters.AddWithValue("@tarihi", fr2.tarih);
            command.Parameters.AddWithValue("@firmasi", fr2.firma);
            command.Parameters.AddWithValue("@subesi", fr2.sube);
            command.Parameters.AddWithValue("@tutar1s", fr2.tutar1);
            command.Parameters.AddWithValue("@tutar2s", fr2.tutar2);
            command.Parameters.AddWithValue("@tutar3s", fr2.tutar3);
            command.ExecuteNonQuery();
            fr2.listele();
            baglanti.Close();

            

            

          


        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void sİLToolStripMenuItem_Click(object sender, EventArgs e)
        {
            baglanti.Open();
            SqlCommand command = new SqlCommand("delete from müsteriler where id=@idi", baglanti);
            command.Parameters.AddWithValue("@idi", fr2.id);
            command.ExecuteNonQuery();
            fr2.listele();
            baglanti.Close();

           
        }

        private void gÜNCELLEToolStripMenuItem_Click(object sender, EventArgs e)
        {
            baglanti.Open();
            SqlCommand command = new SqlCommand("update müsteriler set yil='" + fr2.yil + "' ,ay='" + fr2.ay + "' ,tarih='" + fr2.tarih + "' ,firma='" + fr2.firma + "' ,sube='" + fr2.sube + "' ,tutar1='" + fr2.tutar1 + "' ,tutar2='" + fr2.tutar2 + "' ,tutar3='" + fr2.tutar3 + "' where id ='" + fr2.id + "'", baglanti);

            command.ExecuteNonQuery();
            fr2.listele();
            baglanti.Close();
        }
    }
}
