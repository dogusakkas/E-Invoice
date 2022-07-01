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
    public partial class Invoice : Form
    {
        SqlConnection connection = new SqlConnection("Data Source=DESKTOP-BIVS41I;Initial Catalog=E-InvoiceDB;Integrated Security=True");
        public Invoice()
        {
            InitializeComponent();
        }
        public string id, faturano,tarih,fiyat;

        private void Btn_Guncelle_Click(object sender, EventArgs e)
        {
            // Tıklanan satıra göre verilen güncellendi

            string sorgu = "update Invoice set FaturaNo=@FaturaNo,Fiyat=@Fiyat,Tarih=@Tarih where Id=@Id";
            SqlCommand cmd = new SqlCommand(sorgu,connection);
            cmd.Parameters.AddWithValue("@Id",Convert.ToInt32(Txt_Id.Text));
            cmd.Parameters.AddWithValue("@Tarih",Convert.ToDateTime(Dtp_Tarih.Value));
            cmd.Parameters.AddWithValue("@FaturaNo",Txt_FaturaNo.Text);
            cmd.Parameters.AddWithValue("@Fiyat",Convert.ToDecimal(Txt_Fiyat.Text));

            connection.Open();
            cmd.ExecuteNonQuery();
            connection.Close();

            MessageBox.Show("Fatura Güncellendi");
        }

        private void Invoice_Load(object sender, EventArgs e)
        {
            Txt_Id.Text = id;
            Txt_FaturaNo.Text = faturano;
            Txt_Fiyat.Text = fiyat;
        }
    }
}
