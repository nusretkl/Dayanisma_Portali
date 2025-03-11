using Microsoft.Data.SqlClient;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Dayanisma_Portali.UI
{
	public partial class KullaniciGirisUI : Form
	{
		public KullaniciGirisUI()
		{
			InitializeComponent();
		}
		private void textBox1_TextChanged(object sender, EventArgs e)
		{

		}
		private void textBox2_TextChanged(object sender, EventArgs e)
		{

		}
		private void button1_Click(object sender, EventArgs e)
		{
			string email = textBox1.Text.Trim();
			string sifre = textBox2.Text.Trim();

			if (string.IsNullOrEmpty(email) || string.IsNullOrEmpty(sifre))
			{
				MessageBox.Show("Lütfen tüm alanları doldurun.", "Uyarı", MessageBoxButtons.OK, MessageBoxIcon.Warning);
				return;
			}

			string connectionString = "Server=LAPTOP-GGMIOG7S\\MSSQL;Database=DayanismaPortaliDB;Trusted_Connection=True;TrustServerCertificate=True;";


			using (SqlConnection connection = new SqlConnection(connectionString))
			{
				try
				{
					connection.Open();

                    string query = "SELECT Id, Adi FROM Kullanici WHERE Mail = @Mail AND Sifre = @Sifre";
                    using (SqlCommand command = new SqlCommand(query, connection))
                    {
                        command.Parameters.AddWithValue("@Mail", email);
                        command.Parameters.AddWithValue("@Sifre", sifre);

                        using (SqlDataReader reader = command.ExecuteReader())
                        {
                            if (reader.Read()) 
                            {
                                KullaniciSession.KullaniciID = Convert.ToInt32(reader["Id"]);
                                KullaniciSession.KullaniciAdi = reader["Adi"].ToString();

                                MessageBox.Show("Giriş başarılı!", "Bilgi", MessageBoxButtons.OK, MessageBoxIcon.Information);

                                KullaniciSayfasiUI kullaniciSayfasiUI = new KullaniciSayfasiUI();
                                kullaniciSayfasiUI.Show();
                                this.Hide();
                            }
                            else
                            {
                                MessageBox.Show("Geçersiz e-posta veya şifre.", "Hata", MessageBoxButtons.OK, MessageBoxIcon.Error);
                            }
                        }
                    }

                }
                catch (SqlException sqlEx)
				{
					MessageBox.Show($"SQL Hatası: {sqlEx.Message}", "Hata", MessageBoxButtons.OK, MessageBoxIcon.Error);
				}
				catch (Exception ex)
				{
					MessageBox.Show($"Bir hata oluştu: {ex.Message}\n{ex.StackTrace}", "Hata", MessageBoxButtons.OK, MessageBoxIcon.Error);
				}
			}
		}
		private void label1_Click(object sender, EventArgs e)
		{

		}
		private void label2_Click(object sender, EventArgs e)
		{

		}
	}
}
