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

namespace E_InvoiceProject.Page
{
    public partial class MainPage : Form
    {
        SqlConnection connection = new SqlConnection("Data Source=DESKTOP-BIVS41I;Initial Catalog=E-InvoiceDB;Integrated Security=True");
        public MainPage()
        {
            InitializeComponent();
        }

        public void verilerigoster(string veriler)
        {
            // DataGridView üzerinde sayfa açıldığında verileri çağırdık

            SqlDataAdapter da = new SqlDataAdapter(veriler, connection);
            DataSet ds = new DataSet();
            da.Fill(ds);

            dataGridView1.DataSource = ds.Tables[0];
        }

        private void MainPage_Load(object sender, EventArgs e)
        {
            verilerigoster("Select * From Invoice");
            Lbl_FaturaSayisi.Text = dataGridView1.RowCount.ToString(); // DataGridViewdeki verileri saydık

            this.dataGridView1.Columns["Id"].Visible = false;

        }

        private void Btn_Guncelle_Click(object sender, EventArgs e)
        {
            // Tıklanan satıra göre verilen güncellendi

            int id = Convert.ToInt32(dataGridView1.CurrentRow.Cells["Id"].Value);
            string faturano = dataGridView1.CurrentRow.Cells["FaturaNo"].Value.ToString();
            DateTime tarih = Convert.ToDateTime(dataGridView1.CurrentRow.Cells["Tarih"].Value);
            string satislar = dataGridView1.CurrentRow.Cells["Satislar"].Value.ToString();
            decimal fiyat = Convert.ToDecimal(dataGridView1.CurrentRow.Cells["Fiyat"].Value.ToString());



            connection.Open();
            SqlCommand komut = new SqlCommand("Update Invoice set FaturaNo='" + faturano + "',Tarih='" + tarih + "',Satislar='" + satislar + "',Fiyat='" + fiyat + "' where Id='" + id + "'", connection);
            komut.ExecuteNonQuery();
            connection.Close();
            MessageBox.Show("Fatura Güncellendi");

        }

        private void Btn_Goruntule_Click(object sender, EventArgs e)
        {
            // Seçilen Satırdaki veriler ayrı penceredeki textboxlara taşındı

            Invoice inv = new Invoice();
            inv.id = dataGridView1.CurrentRow.Cells["Id"].Value.ToString();
            inv.faturano = dataGridView1.CurrentRow.Cells["FaturaNo"].Value.ToString();
            inv.fiyat = dataGridView1.CurrentRow.Cells["Fiyat"].Value.ToString();

            inv.Show();
        }


        private void Btn_Yeni_FaturaKaydi_Click(object sender, EventArgs e)
        {
            NewInvoice ni = new NewInvoice();
            ni.Show();
            this.Hide();
        }
    }
}
