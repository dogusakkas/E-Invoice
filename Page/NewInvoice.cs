using E_InvoiceProject.Model;
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
    public partial class NewInvoice : Form
    {

        SqlConnection connection = new SqlConnection("Data Source=DESKTOP-BIVS41I;Initial Catalog=E-InvoiceDB;Integrated Security=True");
        Entities db = new Entities();
        public NewInvoice()
        {
            InitializeComponent();
        }


        private void Btn_Kaydet_Click(object sender, EventArgs e)
        {
            try
            {
                Order ord = new Order();
                Model.Invoice inv = new Model.Invoice();

                ord.Product = Txt_Urun.Text;
                ord.InvoiceId = Convert.ToInt32(Txt_InvoiceId.Text);

                string faturano = Txt_FaturaNo.Text;
                DateTime dateTime = Dtp_Tarih.Value.Date;
                string satislar = Cm_Satislar.Text;
                decimal fiyat = Convert.ToDecimal(Txt_Fiyat.Text);
                inv.FaturaNo = faturano;
                inv.Tarih = dateTime;
                inv.Satislar = satislar;
                inv.Fiyat = fiyat;

                db.Order.Add(ord);
                db.Invoice.Add(inv);

                db.SaveChanges();
                MessageBox.Show("Yeni Fatura Kaydı Yapıldı");
            }
            catch (Exception)
            {
                MessageBox.Show("Geçerli bir fatura numarası giriniz");
            }

            

        }

        private void Btn_YeniKayit_Click(object sender, EventArgs e)
        {
            this.Controls.Clear();
            this.InitializeComponent();
        }

        public void verilerigoster(string veriler)
        {
            // DataGridView üzerinde sayfa açıldığında verileri çağırdık

            SqlDataAdapter da = new SqlDataAdapter(veriler, connection);
            DataSet ds = new DataSet();
            da.Fill(ds);

            dataGridView1.DataSource = ds.Tables[0];
        }

        private void NewInvoice_Load(object sender, EventArgs e)
        {
            verilerigoster("Select * From Invoice");

            this.dataGridView1.Columns["Id"].Visible = false;


            SqlCommand cmd = new SqlCommand("Select * From Invoice", connection);
            cmd.CommandType = CommandType.Text;

            connection.Open();
            SqlDataReader dr = cmd.ExecuteReader();
            List<string> list = new List<string>();
            while (dr.Read())
            {
                list.Add(dr["Satislar"].ToString());
            }
            connection.Close();
            list = list.Distinct().ToList();
            list.Sort();
            Cm_Satislar.DataSource = list;

        }
    }
}
