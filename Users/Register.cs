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

namespace E_InvoiceProject.Users
{
    public partial class Register : Form
    {

        SqlConnection connection = new SqlConnection("Data Source=DESKTOP-BIVS41I;Initial Catalog=E-InvoiceDB;Integrated Security=True");
        public Register()
        {
            InitializeComponent();
        }

        private void linkLabel1_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            Login lgn = new Login();
            lgn.Show();
            this.Hide();
        }

        private void Btn_UyeOl_Click(object sender, EventArgs e)
        {
            try
            {
                {
                    connection.Open();

                    SqlCommand cmd = new SqlCommand("INSERT INTO Register (Username, Name, Surname, Email, Password) VALUES (@Username, @Name, @Surname, @Email, @Password)", connection);

                    cmd.Parameters.AddWithValue("Username", Txt_Ad.Text);
                    cmd.Parameters.AddWithValue("Name", Txt_Soyad.Text);
                    cmd.Parameters.AddWithValue("Surname", Txt_Soyad.Text);
                    cmd.Parameters.AddWithValue("Email", Txt_Email.Text);
                    cmd.Parameters.AddWithValue("Password", Txt_Sifre.Text);
                    cmd.ExecuteNonQuery();

                    MessageBox.Show("Kaydınız Oluşturuldu", "Başarılı", MessageBoxButtons.OK);

                    connection.Close();

                    Login lgn = new Login();
                    lgn.Show();
                    this.Hide();
                }
            }
            catch (Exception)
            {
                MessageBox.Show("Hata");
            }

        }
    }
}
