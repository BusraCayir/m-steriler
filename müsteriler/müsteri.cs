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
    public partial class müsteri : Form
    {
        public müsteri()
        {
            InitializeComponent();
        }

        SqlConnection baglanti = new SqlConnection //veritabanı bağlantı 
    (@"Data Source=DESKTOP-H47EA7C;Initial Catalog=TestDevexpress;Integrated Security=True");


        public void listele()
        {
            SqlDataAdapter da = new SqlDataAdapter("select * from müsteriler",baglanti);
            DataTable dt = new DataTable();
            da.Fill(dt);
            dataGridView1.DataSource = dt;
        }

        public string yil, ay, tarih, firma, sube, tutar1, tutar2, tutar3,id;

        private void TxtTutar2_TextChanged(object sender, EventArgs e)
        {
            tutar2 = TxtTutar2.Text;
        }

        private void TxtTtutar3_TextChanged(object sender, EventArgs e)
        {
            tutar3=TxtTtutar3.Text;
        }

        private void TxtTarih_TextChanged(object sender, EventArgs e)
        {
            tarih = TxtTarih.Text;
        }

        private void BtnTemizle_Click(object sender, EventArgs e)
        {
            TxtYil.Clear();
            TxtAy.Clear();
            TxtTarih.Clear();
            TxtFirma.Clear();
            TxtSube.Clear();
            TxtTutar1.Clear();
            TxtTutar2.Clear();
            TxtTtutar3.Clear();
            TxtID.Clear();
            TxtYil.Focus();
        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
           
        }

        private void dataGridView1_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            int seçilialan = dataGridView1.SelectedCells[0].RowIndex;
            id = dataGridView1.Rows[seçilialan].Cells[0].Value.ToString();
            yil = dataGridView1.Rows[seçilialan].Cells[1].Value.ToString();
            ay = dataGridView1.Rows[seçilialan].Cells[2].Value.ToString();
            tarih = dataGridView1.Rows[seçilialan].Cells[3].Value.ToString();
            firma = dataGridView1.Rows[seçilialan].Cells[4].Value.ToString();
            sube = dataGridView1.Rows[seçilialan].Cells[5].Value.ToString();
            tutar1 = dataGridView1.Rows[seçilialan].Cells[6].Value.ToString();
            tutar2 = dataGridView1.Rows[seçilialan].Cells[7].Value.ToString();
            tutar3 = dataGridView1.Rows[seçilialan].Cells[8].Value.ToString();


            TxtYil.Text = yil;
            TxtAy.Text = ay;
            TxtTarih.Text = tarih;
            TxtFirma.Text = firma;
            TxtSube.Text = sube;
            TxtTutar1.Text = tutar1;
            TxtTutar2.Text = tutar2;
            TxtTtutar3.Text = tutar3;
            TxtID.Text = id;
        }

        private void TxtID_TextChanged(object sender, EventArgs e)
        {
            id = TxtID.Text;
        }

        private void TxtTutar1_TextChanged(object sender, EventArgs e)
        {
            tutar1 = TxtTutar1.Text;

        }

        private void TxtSube_TextChanged(object sender, EventArgs e)
        {
            sube = TxtSube.Text;
        }

        private void TxtFirma_TextChanged(object sender, EventArgs e)
        {
            firma = TxtFirma.Text;
        }

        private void TxtAy_TextChanged(object sender, EventArgs e)
        {
            ay = TxtAy.Text;
        }

        private void TxtYil_TextChanged_1(object sender, EventArgs e)
        {
            yil = TxtYil.Text;
        }

        private void müsteri_Load(object sender, EventArgs e)
        {

        }
       
        private void TxtYil_TextChanged(object sender, EventArgs e)
        {
           
        }
    }
}
