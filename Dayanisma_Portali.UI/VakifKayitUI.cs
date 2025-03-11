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
using static System.Windows.Forms.VisualStyles.VisualStyleElement;

namespace Dayanisma_Portali.UI
{
    public partial class VakifKayitUI : Form
    {
        public VakifKayitUI()
        {
            InitializeComponent();
        }

        private void VakifKayitUI_Load(object sender, EventArgs e)
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
            string vakifAdi = textBox1.Text.Trim();      
            int ilID = (int)comboBox1.SelectedValue;    
            string adres = textBox3.Text.Trim();         
            string sifre = textBox4.Text.Trim();        
            string telno = textBox2.Text.Trim();

            string connectionString = "Server=LAPTOP-GGMIOG7S\\MSSQL;Database=DayanismaPortaliDB;Trusted_Connection=True;TrustServerCertificate=True;";
            string insertQuery = @"
        INSERT INTO Vakif (Name, ilID, Adres, Sifre, Tel_No) 
        VALUES (@Name, @ilID, @Adres, @Sifre, @Tel_No)";

            using (SqlConnection connection = new SqlConnection(connectionString))
            {
                try
                {
                    connection.Open();

                    using (SqlCommand command = new SqlCommand(insertQuery, connection))
                    {
                        command.Parameters.AddWithValue("@Name", vakifAdi);
                        command.Parameters.AddWithValue("@ilID", ilID);
                        command.Parameters.AddWithValue("@Adres", adres);
                        command.Parameters.AddWithValue("@Sifre", sifre);
                        command.Parameters.AddWithValue("@Tel_No", telno);

                        command.ExecuteNonQuery();

                        MessageBox.Show("Vakif başarıyla kaydedildi.", "Başarılı", MessageBoxButtons.OK, MessageBoxIcon.Information);

                        textBox1.Clear();
                        comboBox1.SelectedIndex = -1;
                        textBox3.Clear();
                        textBox4.Clear();
                        textBox2.Clear();
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

    }
}
