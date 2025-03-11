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
	public partial class KullaniciKayitUI : Form
	{
		public KullaniciKayitUI()
		{
			InitializeComponent();
		}
		private void KullaniciKayitUI_Load(object sender, EventArgs e)
		{
			LoadIller();
		}
		private void LoadIller()
		{
            string connectionString = "Server=LAPTOP-GGMIOG7S\\MSSQL;Database=DayanismaPortaliDB;Trusted_Connection=True;TrustServerCertificate=True;";
            string query = "SELECT ID, Adi FROM il"; 

            using (SqlConnection connection = new SqlConnection(connectionString))
            {
                try
                {
                    connection.Open();
                    using (SqlCommand command = new SqlCommand(query, connection))
                    {
                        SqlDataAdapter adapter = new SqlDataAdapter(command);
                        DataTable dt = new DataTable();

                        adapter.Fill(dt);

                        comboBox1.DataSource = dt;
                        comboBox1.DisplayMember = "Adi"; 
                        comboBox1.ValueMember = "ID";   
                        comboBox1.SelectedIndex = -1;   
                    }
                }
                catch (SqlException sqlEx)
                {
                    MessageBox.Show($"SQL Hatası: {sqlEx.Message}", "Hata", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
                catch (Exception ex)
                {
                    MessageBox.Show($"Bir hata oluştu: {ex.Message}", "Hata", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
        }

		private void button1_Click(object sender, EventArgs e)
		{
			string ad = textBox1.Text.Trim();
			string soyad = textBox2.Text.Trim();
			string email = textBox3.Text.Trim();
			string sifre = textBox4.Text.Trim();
			string telefon = textBox5.Text.Trim();

			if (comboBox1.SelectedItem == null)
			{
				MessageBox.Show("Lütfen bir il seçin.", "Uyarı", MessageBoxButtons.OK, MessageBoxIcon.Warning);
				return;
			}

			KeyValuePair<int, string> selectedIl = (KeyValuePair<int, string>)comboBox1.SelectedItem;
			int ilId = selectedIl.Key;  
			string ilAdi = selectedIl.Value;  

			string cinsiyet = comboBox2.SelectedItem?.ToString(); 

			if (string.IsNullOrEmpty(ad) || string.IsNullOrEmpty(soyad) || string.IsNullOrEmpty(email) ||
				string.IsNullOrEmpty(sifre) || string.IsNullOrEmpty(telefon) || string.IsNullOrEmpty(ilAdi) ||
				string.IsNullOrEmpty(cinsiyet))
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

					string query = @"
INSERT INTO Kullanici (Adi, Soyadi, Mail, Sifre, Telefon, Cinsiyet, ilId) 
VALUES (@Adi, @Soyadi, @Mail, @Sifre, @Telefon, @Cinsiyet, @IlId)";  

					using (SqlCommand command = new SqlCommand(query, connection))
					{
						command.Parameters.AddWithValue("@Adi", ad);
						command.Parameters.AddWithValue("@Soyadi", soyad);
						command.Parameters.AddWithValue("@Mail", email);
						command.Parameters.AddWithValue("@Sifre", sifre);
						command.Parameters.AddWithValue("@Telefon", telefon);
						command.Parameters.AddWithValue("@Cinsiyet", cinsiyet);
						command.Parameters.AddWithValue("@IlId", ilId);  

						int rowsAffected = command.ExecuteNonQuery();

						if (rowsAffected > 0)
						{
							MessageBox.Show("Kayıt başarılı!", "Bilgi", MessageBoxButtons.OK, MessageBoxIcon.Information);
						}
						else
						{
							MessageBox.Show("Bir hata oluştu, kayıt yapılamadı.", "Hata", MessageBoxButtons.OK, MessageBoxIcon.Error);
						}
					}
				}
				catch (SqlException sqlEx)
				{
					MessageBox.Show($"SQL Hatası: {sqlEx.Message}", "Hata", MessageBoxButtons.OK, MessageBoxIcon.Error);
				}
				catch (Exception ex)
				{
					MessageBox.Show($"Bir hata oluştu: {ex.Message}", "Hata", MessageBoxButtons.OK, MessageBoxIcon.Error);
				}
			}
		}

		private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
		{

		}
	}
}

