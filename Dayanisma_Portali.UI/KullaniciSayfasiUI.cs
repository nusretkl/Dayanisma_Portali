using Microsoft.Data.SqlClient;
using System;
using System.Data;
using System.Windows.Forms;
using iTextSharp.text;
using iTextSharp.text.pdf;
using System.IO;
using System.Drawing;  
using iTextSharp.text.pdf;

namespace Dayanisma_Portali.UI
{
    public partial class KullaniciSayfasiUI : Form
    {
        public KullaniciSayfasiUI()
        {
            InitializeComponent();

        }

        private void LoadVakifAdlari()
        {
            string connectionString = "Server=LAPTOP-GGMIOG7S\\MSSQL;Database=DayanismaPortaliDB;Trusted_Connection=True;TrustServerCertificate=True;";
            string query = "SELECT Name FROM Vakif";

            comboBox1.Items.Clear();
            comboBox1.Items.Add("Hepsi"); 

            using (SqlConnection connection = new SqlConnection(connectionString))
            {
                try
                {
                    connection.Open();
                    using (SqlCommand command = new SqlCommand(query, connection))
                    {
                        using (SqlDataReader reader = command.ExecuteReader())
                        {
                            while (reader.Read())
                            {
                                comboBox1.Items.Add(reader["Name"].ToString());
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
                    MessageBox.Show($"Bir hata oluştu: {ex.Message}", "Hata", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }

            comboBox1.SelectedIndex = 0; // "Hepsi"yi varsayılan olarak seç
        }


        private void KullaniciSayfasiUI_Load(object sender, EventArgs e)
        {
            label1.Text = $"Hoşgeldin, {KullaniciSession.KullaniciAdi}!";
            LoadIlanlar();
            LoadRandevular();
            LoadVakifAdlari();
        }
        private void LoadRandevular()
        {
            string connectionString = "Server=LAPTOP-GGMIOG7S\\MSSQL;Database=DayanismaPortaliDB;Trusted_Connection=True;TrustServerCertificate=True;";
            string query = @"
        SELECT 
            r.Id as RandevuID, 
            i.Konu, 
            i.Aciklama, 
            r.ResimYolu,  -- Resim Yolu ekleniyor
            i.Tarih, 
            i.Saat, 
            i.Adres, 
            v.Name as VakifAdi
        FROM 
            Randevu r
        INNER JOIN 
            ilanlar i ON r.ilan_ID = i.Id
        INNER JOIN 
            Vakif v ON r.VakifId = v.Id
        WHERE 
            r.Kullanici_ID = @KullaniciID AND r.Yapildi_mi = 1 AND r. Yapildi_mi IS NOT NULL"; 

            using (SqlConnection connection = new SqlConnection(connectionString))
            {
                try
                {
                    connection.Open();
                    using (SqlCommand command = new SqlCommand(query, connection))
                    {
                        int kullaniciID = Convert.ToInt32(KullaniciSession.KullaniciID);

                        command.Parameters.AddWithValue("@KullaniciID", KullaniciSession.KullaniciID);

                        DataTable dt = new DataTable();
                        using (SqlDataAdapter adapter = new SqlDataAdapter(command))
                        {
                            adapter.Fill(dt);
                        }

                        dataGridView2.DataSource = dt;

                        if (!dataGridView2.Columns.Contains("ResimYolu"))
                        {
                            dataGridView2.Columns.Add("ResimYolu", "Resim Yolu");
                        }

                        dataGridView2.Columns["Konu"].HeaderText = "Konu";
                        dataGridView2.Columns["Aciklama"].HeaderText = "Açıklama";
                        dataGridView2.Columns["Tarih"].HeaderText = "Tarih";
                        dataGridView2.Columns["Saat"].HeaderText = "Saat";
                        dataGridView2.Columns["Adres"].HeaderText = "Adres";
                        dataGridView2.Columns["VakifAdi"].HeaderText = "Vakıf Adı";
                        dataGridView2.Columns["ResimYolu"].HeaderText = "Resim Yolu"; 

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
        private void LoadIlanlar()
        {
            string connectionString = "Server=LAPTOP-GGMIOG7S\\MSSQL;Database=DayanismaPortaliDB;Trusted_Connection=True;TrustServerCertificate=True;";
            string query = @"
        SELECT 
            i.Id as IlanID, 
            i.Konu, 
            i.Aciklama, 
            i.Tarih, 
            i.Saat, 
            i.Adres, 
            v.Name
        FROM 
            ilanlar i
        INNER JOIN 
            Vakif v ON i.VakifId = v.Id
        WHERE 
            i.AktifMi = 1"; // Yalnızca Aktif olanları al

            using (SqlConnection connection = new SqlConnection(connectionString))
            {
                try
                {
                    connection.Open();
                    using (SqlCommand command = new SqlCommand(query, connection))
                    {
                        DataTable dt = new DataTable();
                        using (SqlDataAdapter adapter = new SqlDataAdapter(command))
                        {
                            adapter.Fill(dt);
                        }

                        dataGridView1.DataSource = dt;
                        dataGridView1.Columns["Konu"].HeaderText = "Konu";
                        dataGridView1.Columns["Aciklama"].HeaderText = "Açıklama";
                        dataGridView1.Columns["Tarih"].HeaderText = "Tarih";
                        dataGridView1.Columns["Saat"].HeaderText = "Saat";
                        dataGridView1.Columns["Adres"].HeaderText = "Adres";
                        dataGridView1.Columns["Name"].HeaderText = "Vakıf Adı";
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


        private int GetVakifID(string vakifAdi)
        {
            string connectionString = "Server=LAPTOP-GGMIOG7S\\MSSQL;Database=DayanismaPortaliDB;Trusted_Connection=True;TrustServerCertificate=True;";
            string query = "SELECT Id FROM Vakif WHERE Name = @Name";

            using (SqlConnection connection = new SqlConnection(connectionString))
            {
                connection.Open();
                using (SqlCommand command = new SqlCommand(query, connection))
                {
                    command.Parameters.AddWithValue("@Name", vakifAdi);
                    return (int)command.ExecuteScalar();
                }
            }
        }
        private void button3_Click(object sender, EventArgs e)
        {
            if (dataGridView2.SelectedRows.Count > 0)
            {
                var selectedRow = dataGridView2.SelectedRows[0];

                string randevuID = selectedRow.Cells["RandevuID"].Value?.ToString();
                string konu = selectedRow.Cells["Konu"].Value?.ToString();
                string aciklama = selectedRow.Cells["Aciklama"].Value?.ToString();
                string tarih = selectedRow.Cells["Tarih"].Value?.ToString();
                string saat = selectedRow.Cells["Saat"].Value?.ToString();
                string adres = selectedRow.Cells["Adres"].Value?.ToString();
                string vakifAdi = selectedRow.Cells["VakifAdi"].Value?.ToString();
                string resimYolu = selectedRow.Cells["ResimYolu"].Value?.ToString();

                using (SaveFileDialog saveFileDialog = new SaveFileDialog())
                {
                    saveFileDialog.Filter = "PDF Dosyaları (*.pdf)|*.pdf";
                    saveFileDialog.FileName = $"Randevu_{randevuID}.pdf";

                    if (saveFileDialog.ShowDialog() == DialogResult.OK)
                    {
                        string filePath = saveFileDialog.FileName;

                        using (FileStream fs = new FileStream(filePath, FileMode.Create))
                        {
                            Document document = new Document(PageSize.A4, 25, 25, 30, 30);
                            PdfWriter.GetInstance(document, fs);

                            document.Open();

                            iTextSharp.text.Font baslikFont = new iTextSharp.text.Font(iTextSharp.text.Font.HELVETICA, 18, iTextSharp.text.Font.BOLD, BaseColor.Gray);
                            Paragraph baslik = new Paragraph("Randevu Bilgileri", baslikFont) { Alignment = Element.ALIGN_CENTER };
                            document.Add(baslik);
                            document.Add(new Paragraph(" "));

                            iTextSharp.text.Font icerikFont = new iTextSharp.text.Font(iTextSharp.text.Font.HELVETICA, 12, iTextSharp.text.Font.NORMAL, BaseColor.Black);
                            document.Add(new Paragraph($"Konu: {konu}", icerikFont));
                            document.Add(new Paragraph(" "));
                            document.Add(new Paragraph($"Açıklama: {aciklama}", icerikFont));
                            document.Add(new Paragraph(" ")); 
                            document.Add(new Paragraph($"Tarih: {tarih}", icerikFont));
                            document.Add(new Paragraph(" ")); 
                            document.Add(new Paragraph($"Saat: {saat}", icerikFont));
                            document.Add(new Paragraph(" ")); 
                            document.Add(new Paragraph($"Adres: {adres}", icerikFont));
                            document.Add(new Paragraph(" ")); 
                            document.Add(new Paragraph($"Vakıf Adı: {vakifAdi}", icerikFont));
                            document.Add(new Paragraph(" ")); 
                            document.Add(new Paragraph(" "));
                            document.Add(new Paragraph(" ")); 
                            document.Add(new Paragraph(" ")); 

                            if (!string.IsNullOrEmpty(resimYolu) && File.Exists(resimYolu))
                            {
                                iTextSharp.text.Image img = iTextSharp.text.Image.GetInstance(resimYolu);
                                img.ScaleToFit(500f, 300f); 
                                img.Alignment = Element.ALIGN_CENTER;
                                document.Add(img);
                            }

                            document.Close();
                        }
                        MessageBox.Show($"PDF dosyası başarıyla oluşturuldu: {filePath}", "Başarılı", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    }
                }
            }
            else
            {
                MessageBox.Show("Lütfen bir satır seçin.", "Uyarı", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
        }

            private void UpdateResimYoluInDatabase(int randevuID, string resimYolu)
        {
            string connectionString = "Server=LAPTOP-GGMIOG7S\\MSSQL;Database=DayanismaPortaliDB;Trusted_Connection=True;TrustServerCertificate=True;";
            string query = "UPDATE Randevu SET ResimYolu = @ResimYolu WHERE Id = @RandevuID";

            using (SqlConnection connection = new SqlConnection(connectionString))
            {
                try
                {
                    connection.Open();
                    using (SqlCommand command = new SqlCommand(query, connection))
                    {
                        command.Parameters.AddWithValue("@ResimYolu", resimYolu);
                        command.Parameters.AddWithValue("@RandevuID", randevuID);

                        command.ExecuteNonQuery();
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

        private void button2_Click_1(object sender, EventArgs e)
        {
            string vakifAdi = comboBox1.SelectedItem?.ToString(); 
            DateTime baslangicTarihi = dateTimePicker1.Value.Date;
            DateTime bitisTarihi = dateTimePicker2.Value.Date;

            string connectionString = "Server=LAPTOP-GGMIOG7S\\MSSQL;Database=DayanismaPortaliDB;Trusted_Connection=True;TrustServerCertificate=True;";

            string query = @"
    SELECT 
        i.Id as IlanID, 
        i.Konu, 
        i.Aciklama, 
        i.Tarih, 
        i.Saat, 
        i.Adres, 
        v.Name
    FROM 
        ilanlar i
    INNER JOIN 
        Vakif v ON i.VakifId = v.Id
    WHERE 
        i.AktifMi = 1 
        AND i.Tarih BETWEEN @BaslangicTarihi AND @BitisTarihi";

            if (!string.IsNullOrEmpty(vakifAdi))
            {
                query += " AND v.Name = @VakifAdi";
            }

            using (SqlConnection connection = new SqlConnection(connectionString))
            {
                try
                {
                    connection.Open();
                    using (SqlCommand command = new SqlCommand(query, connection))
                    {
                        command.Parameters.AddWithValue("@BaslangicTarihi", baslangicTarihi);
                        command.Parameters.AddWithValue("@BitisTarihi", bitisTarihi);

                        if (!string.IsNullOrEmpty(vakifAdi))
                        {
                            command.Parameters.AddWithValue("@VakifAdi", vakifAdi);
                        }

                        DataTable dt = new DataTable();
                        using (SqlDataAdapter adapter = new SqlDataAdapter(command))
                        {
                            adapter.Fill(dt);
                        }

                        dataGridView1.DataSource = dt;

                        dataGridView1.Columns["Konu"].HeaderText = "Konu";
                        dataGridView1.Columns["Aciklama"].HeaderText = "Açiklama";
                        dataGridView1.Columns["Tarih"].HeaderText = "Tarih";
                        dataGridView1.Columns["Saat"].HeaderText = "Saat";
                        dataGridView1.Columns["Adres"].HeaderText = "Adres";
                        dataGridView1.Columns["Name"].HeaderText = "Vakif Adi";
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

        private void button4_Click(object sender, EventArgs e)
        {
            if (dataGridView2.SelectedRows.Count > 0)
            {
                int randevuID = Convert.ToInt32(dataGridView2.SelectedRows[0].Cells["RandevuID"].Value);

                OpenFileDialog openFileDialog = new OpenFileDialog
                {
                    Filter = "Görsel Dosyaları|*.jpg;*.jpeg;*.png;*.bmp;*.gif",
                    Title = "Bir görsel seçin"
                };

                if (openFileDialog.ShowDialog() == DialogResult.OK)
                {
                    string selectedFilePath = openFileDialog.FileName;

                    dataGridView2.SelectedRows[0].Cells["ResimYolu"].Value = selectedFilePath;

                    UpdateResimYoluInDatabase(randevuID, selectedFilePath);

                    MessageBox.Show("Görsel başarıyla yüklendi ve kaydedildi.", "Başarılı", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
            }
            else
            {
                MessageBox.Show("Lütfen bir satır seçin.", "Uyarı", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
        }

        private void button1_Click_1(object sender, EventArgs e)
        {
            if (dataGridView1.SelectedRows.Count > 0)
            {
                int ilanID = Convert.ToInt32(dataGridView1.SelectedRows[0].Cells["IlanID"].Value);
                string vakifAdi = dataGridView1.SelectedRows[0].Cells["Name"].Value.ToString();

                string connectionString = "Server=LAPTOP-GGMIOG7S\\MSSQL;Database=DayanismaPortaliDB;Trusted_Connection=True;TrustServerCertificate=True;";

                string insertQuery = @"
            INSERT INTO Randevu (Kullanici_ID, VakifId, ilan_ID, Yapildi_mi) 
            VALUES (@Kullanici_ID, @VakifId, @ilan_ID, 0)";

                string updateQuery = "UPDATE ilanlar SET AktifMi = 0 WHERE Id = @ilanID";

                using (SqlConnection connection = new SqlConnection(connectionString))
                {
                    try
                    {
                        connection.Open();

                        using (SqlCommand insertCommand = new SqlCommand(insertQuery, connection))
                        {
                            insertCommand.Parameters.AddWithValue("@Kullanici_ID", KullaniciSession.KullaniciID); 
                            insertCommand.Parameters.AddWithValue("@VakifId", GetVakifID(vakifAdi)); 
                            insertCommand.Parameters.AddWithValue("@ilan_ID", ilanID);

                            insertCommand.ExecuteNonQuery();
                        }

                        using (SqlCommand updateCommand = new SqlCommand(updateQuery, connection))
                        {
                            updateCommand.Parameters.AddWithValue("@ilanID", ilanID);
                            updateCommand.ExecuteNonQuery();
                        }

                        MessageBox.Show("Randevunuz başarıyla alındı ve ilan pasif hale getirildi.", "Başarılı", MessageBoxButtons.OK, MessageBoxIcon.Information);

                        LoadIlanlar();
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
            else
            {
                MessageBox.Show("Lütfen bir ilan seçin.", "Uyarı", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
        }
    }
}
