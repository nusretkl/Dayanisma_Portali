using Microsoft.Data.SqlClient;
using System;
using System.Data;
using System.Windows.Forms;

namespace Dayanisma_Portali.UI
{
    public partial class VakifAnaSayfaUI : Form
    {
        public static int VakifID { get; set; }
        private string selectedIlanID; 

        public VakifAnaSayfaUI()
        {
            InitializeComponent();
        }

        private void VakifAnaSayfaUI_Load(object sender, EventArgs e)
        {
            string connectionString = "Server=LAPTOP-GGMIOG7S\\MSSQL;Database=DayanismaPortaliDB;Trusted_Connection=True;TrustServerCertificate=True;";
            string ilanQuery = "SELECT Id, Konu, Aciklama, Tarih, Saat, Adres, AktifMi FROM ilanlar WHERE VakifId = @VakifId";
            using (SqlConnection connection = new SqlConnection(connectionString))
            {
                connection.Open();

                string vakifAdQuery = "SELECT Name FROM Vakif WHERE Id = @VakifId";
                using (SqlCommand command = new SqlCommand(ilanQuery, connection))
                {
                    command.Parameters.AddWithValue("@VakifId", VakifID);

                    DataTable ilanTable = new DataTable();
                    using (SqlDataAdapter adapter = new SqlDataAdapter(command))
                    {
                        adapter.Fill(ilanTable);
                    }
                    dataGridView1.DataSource = ilanTable;

                   
                    if (dataGridView1.Columns["AktifMi"] != null)
                    {
                        dataGridView1.Columns["AktifMi"].HeaderText = "Aktif Mi";
                    }
                }

                using (SqlCommand command = new SqlCommand(vakifAdQuery, connection))
                {
                    command.Parameters.AddWithValue("@VakifId", VakifID);

                    object vakifAd = command.ExecuteScalar();
                    if (vakifAd != null)
                    {
                        label10.Text = vakifAd.ToString() + " " + "şubesi";
                    }
                }

            }
            using (SqlConnection connection = new SqlConnection(connectionString))
            {
                try
                {
                    connection.Open();

                    using (SqlCommand command = new SqlCommand(ilanQuery, connection))
                    {
                        command.Parameters.AddWithValue("@VakifId", VakifID);

                        DataTable ilanTable = new DataTable();
                        using (SqlDataAdapter adapter = new SqlDataAdapter(command))
                        {
                            adapter.Fill(ilanTable);
                        }
                        dataGridView1.DataSource = ilanTable;
                    }

                    string randevuQuery = @"
    SELECT 
        r.ID AS RandevuID,
        r.ilan_ID AS IlanID,
        k.Adi AS KullaniciAdi,
        r.Yapildi_mi AS YapildiMi
    FROM Randevu r
    LEFT JOIN ilanlar i ON r.ilan_ID = i.Id
    LEFT JOIN Kullanici k ON r.Kullanici_ID = k.Id
    WHERE r.VakifId = @VakifId";

                    using (SqlCommand command = new SqlCommand(randevuQuery, connection))
                    {
                        command.Parameters.AddWithValue("@VakifId", VakifID);

                        DataTable randevuTable = new DataTable();
                        using (SqlDataAdapter adapter = new SqlDataAdapter(command))
                        {
                            adapter.Fill(randevuTable);
                        }

                        if (randevuTable.Rows.Count > 0)
                        {
                            dataGridView2.DataSource = randevuTable;

                            dataGridView2.Columns["RandevuID"].HeaderText = "Randevu ID";
                            dataGridView2.Columns["IlanID"].HeaderText = "İlan ID";
                            dataGridView2.Columns["KullaniciAdi"].HeaderText = "Kullanıcı Adı";
                            dataGridView2.Columns["YapildiMi"].HeaderText = "Yapıldı Mı";
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

        private void button1_Click(object sender, EventArgs e)
        {
            string konu = textBox1.Text;
            string aciklama = textBox2.Text;
            string tarih = dateTimePicker1.Value.ToShortDateString();
            string baslangicSaati = mtbStartTime.Text;
            string bitisSaati = mtbEndTime.Text;
            string adres = textBox3.Text;

            if (string.IsNullOrWhiteSpace(konu) || string.IsNullOrWhiteSpace(aciklama) ||
                string.IsNullOrWhiteSpace(baslangicSaati) || string.IsNullOrWhiteSpace(bitisSaati) ||
                string.IsNullOrWhiteSpace(adres))
            {
                MessageBox.Show("Lütfen tüm alanları doldurun.", "Uyarı", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            string connectionString = "Server=LAPTOP-GGMIOG7S\\MSSQL;Database=DayanismaPortaliDB;Trusted_Connection=True;TrustServerCertificate=True;";
            string insertQuery = "INSERT INTO ilanlar (Konu, Aciklama, Tarih, Saat, Adres, VakifID, AktifMi) VALUES (@Konu, @Aciklama, @Tarih, @Saat, @Adres, @VakifID, @AktifMi)";

            using (SqlConnection connection = new SqlConnection(connectionString))
            {
                try
                {
                    connection.Open();
                    using (SqlCommand command = new SqlCommand(insertQuery, connection))
                    {
                        command.Parameters.AddWithValue("@Konu", konu);
                        command.Parameters.AddWithValue("@Aciklama", aciklama);
                        command.Parameters.AddWithValue("@Tarih", dateTimePicker1.Value.ToString("yyyy-MM-dd")); 
                        command.Parameters.AddWithValue("@Saat", $"{baslangicSaati} - {bitisSaati}"); 
                        command.Parameters.AddWithValue("@Adres", adres);
                        command.Parameters.AddWithValue("@VakifID", VakifID);
                        command.Parameters.AddWithValue("@AktifMi", true); 


                        int result = command.ExecuteNonQuery();

                        if (result > 0)
                        {
                            MessageBox.Show("İlan başarıyla eklendi.", "Bilgi", MessageBoxButtons.OK, MessageBoxIcon.Information);
                            VakifAnaSayfaUI_Load(sender, e); 
                        }
                        else
                        {
                            MessageBox.Show("İlan eklenirken bir hata oluştu.", "Hata", MessageBoxButtons.OK, MessageBoxIcon.Error);
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
        private void button2_Click(object sender, EventArgs e)
        {
            if (dataGridView1.CurrentRow == null)
            {
                MessageBox.Show("Lütfen silmek istediğiniz ilanı seçin.", "Uyarı", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            selectedIlanID = dataGridView1.CurrentRow.Cells["Id"].Value.ToString();
            string connectionString = "Server=LAPTOP-GGMIOG7S\\MSSQL;Database=DayanismaPortaliDB;Trusted_Connection=True;TrustServerCertificate=True;";
            string deleteQuery = "DELETE FROM ilanlar WHERE Id = @IlanID";

            using (SqlConnection connection = new SqlConnection(connectionString))
            {
                try
                {
                    connection.Open();
                    using (SqlCommand command = new SqlCommand(deleteQuery, connection))
                    {
                        command.Parameters.AddWithValue("@IlanID", selectedIlanID);

                        int result = command.ExecuteNonQuery();
                        if (result > 0)
                        {
                            MessageBox.Show("İlan başarıyla silindi.", "Bilgi", MessageBoxButtons.OK, MessageBoxIcon.Information);
                            VakifAnaSayfaUI_Load(sender, e); 
                        }
                        else
                        {
                            MessageBox.Show("Silme işlemi başarısız oldu.", "Hata", MessageBoxButtons.OK, MessageBoxIcon.Error);
                        }
                    }
                }
                catch (Exception ex)
                {
                    MessageBox.Show($"Bir hata oluştu: {ex.Message}", "Hata", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
        }

        private void dataGridView2_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void button3_Click(object sender, EventArgs e)
        {
            if (dataGridView2.CurrentRow == null)
            {
                MessageBox.Show("Lütfen bir randevu seçin.", "Uyarı", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            int randevuID = Convert.ToInt32(dataGridView2.CurrentRow.Cells["RandevuID"].Value);

            bool yapildiMi = Convert.ToBoolean(dataGridView2.CurrentRow.Cells["YapildiMi"].Value);

            string connectionString = "Server=LAPTOP-GGMIOG7S\\MSSQL;Database=DayanismaPortaliDB;Trusted_Connection=True;TrustServerCertificate=True;";
            string updateQuery = "UPDATE Randevu SET Yapildi_mi = @YapildiMi WHERE ID = @RandevuID";

            using (SqlConnection connection = new SqlConnection(connectionString))
            {
                try
                {
                    connection.Open();

                    using (SqlCommand command = new SqlCommand(updateQuery, connection))
                    {
                        command.Parameters.AddWithValue("@YapildiMi", yapildiMi); 
                        command.Parameters.AddWithValue("@RandevuID", randevuID);

                        int result = command.ExecuteNonQuery();

                        if (result > 0)
                        {
                            MessageBox.Show("Randevu durumu başarıyla güncellendi.", "Bilgi", MessageBoxButtons.OK, MessageBoxIcon.Information);

                            VakifAnaSayfaUI_Load(sender, e);
                        }
                        else
                        {
                            MessageBox.Show("Randevu güncelleme başarısız oldu.", "Hata", MessageBoxButtons.OK, MessageBoxIcon.Error);
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
    }
}