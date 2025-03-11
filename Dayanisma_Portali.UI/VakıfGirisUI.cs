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
	public partial class VakıfGirisUI : Form
	{
		public VakıfGirisUI()
		{
			InitializeComponent();
		}

		private void button1_Click(object sender, EventArgs e)
		{
			string name = textBox1.Text.Trim(); 
			string sifre = textBox2.Text.Trim();

			if (string.IsNullOrEmpty(name) || string.IsNullOrEmpty(sifre))
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

					string query = "SELECT Id FROM Vakif WHERE Name = @Name AND Sifre = @Sifre";
					using (SqlCommand command = new SqlCommand(query, connection))
					{
						command.Parameters.AddWithValue("@Name", name);  
						command.Parameters.AddWithValue("@Sifre", sifre); 

						object result = command.ExecuteScalar();

						if (result != null)
						{
							VakifAnaSayfaUI.VakifID = Convert.ToInt32(result);  

							MessageBox.Show("Giriş başarılı!", "Bilgi", MessageBoxButtons.OK, MessageBoxIcon.Information);
							VakifAnaSayfaUI vakifAnaSayfaUI = new VakifAnaSayfaUI();
							vakifAnaSayfaUI.Show();  
							this.Hide();  
						}
						else
						{
							MessageBox.Show("Geçersiz kullanıcı adı veya şifre.", "Hata", MessageBoxButtons.OK, MessageBoxIcon.Error);
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
	}
}
