using E_InvoiceProject.Page;
using E_InvoiceProject.Users;
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

namespace E_InvoiceProject
{
    public partial class Login : Form
    {

        SqlConnection connection = new SqlConnection("Data Source=DESKTOP-BIVS41I;Initial Catalog=E-InvoiceDB;Integrated Security=True");
        public Login()
        {
            InitializeComponent();
        }

        private void linkLabel1_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            Register rgs = new Register();
            rgs.Show();
            this.Hide();
        }

        private void Btn_GirisYap_Click(object sender, EventArgs e)
        {
            string user = Txt_Email.Text;
            string password = Txt_Sifre.Text;


            SqlCommand com = new SqlCommand();
            connection.Open();
            com.Connection = connection;
            com.CommandText = "Select * From Register where Email='" + Txt_Email.Text + "'And Password='" + Txt_Sifre.Text + "'";
            SqlDataReader dr = com.ExecuteReader();
            if (dr.Read())
            {
                MainPage mp = new MainPage();
                mp.Show();
                this.Hide();
            }
            connection.Close();
        }
    }
}
