namespace Dayanisma_Portali.UI
{
	partial class VakifAnaSayfaUI
	{
		/// <summary>
		/// Required designer variable.
		/// </summary>
		private System.ComponentModel.IContainer components = null;

		/// <summary>
		/// Clean up any resources being used.
		/// </summary>
		/// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
		protected override void Dispose(bool disposing)
		{
			if (disposing && (components != null))
			{
				components.Dispose();
			}
			base.Dispose(disposing);
		}

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            panel2 = new Panel();
            textBox3 = new TextBox();
            textBox2 = new TextBox();
            textBox1 = new TextBox();
            mtbEndTime = new MaskedTextBox();
            mtbStartTime = new MaskedTextBox();
            dateTimePicker1 = new DateTimePicker();
            label8 = new Label();
            label6 = new Label();
            label7 = new Label();
            label5 = new Label();
            label4 = new Label();
            button1 = new Button();
            dataGridView1 = new DataGridView();
            label3 = new Label();
            button2 = new Button();
            label1 = new Label();
            label2 = new Label();
            panel1 = new Panel();
            label12 = new Label();
            label11 = new Label();
            label9 = new Label();
            button3 = new Button();
            dataGridView2 = new DataGridView();
            label10 = new Label();
            panel2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)dataGridView1).BeginInit();
            panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)dataGridView2).BeginInit();
            SuspendLayout();
            // 
            // panel2
            // 
            panel2.BackColor = SystemColors.ActiveCaption;
            panel2.Controls.Add(textBox3);
            panel2.Controls.Add(textBox2);
            panel2.Controls.Add(textBox1);
            panel2.Controls.Add(mtbEndTime);
            panel2.Controls.Add(mtbStartTime);
            panel2.Controls.Add(dateTimePicker1);
            panel2.Controls.Add(label8);
            panel2.Controls.Add(label6);
            panel2.Controls.Add(label7);
            panel2.Controls.Add(label5);
            panel2.Controls.Add(label4);
            panel2.Controls.Add(button1);
            panel2.Location = new Point(33, 91);
            panel2.Name = "panel2";
            panel2.Size = new Size(409, 524);
            panel2.TabIndex = 1;
            // 
            // textBox3
            // 
            textBox3.Location = new Point(103, 296);
            textBox3.Multiline = true;
            textBox3.Name = "textBox3";
            textBox3.Size = new Size(236, 52);
            textBox3.TabIndex = 16;
            // 
            // textBox2
            // 
            textBox2.Location = new Point(127, 91);
            textBox2.Multiline = true;
            textBox2.Name = "textBox2";
            textBox2.Size = new Size(212, 57);
            textBox2.TabIndex = 15;
            // 
            // textBox1
            // 
            textBox1.Location = new Point(101, 43);
            textBox1.Name = "textBox1";
            textBox1.Size = new Size(131, 23);
            textBox1.TabIndex = 5;
            // 
            // mtbEndTime
            // 
            mtbEndTime.Location = new Point(219, 238);
            mtbEndTime.Mask = "90:00";
            mtbEndTime.Name = "mtbEndTime";
            mtbEndTime.Size = new Size(57, 23);
            mtbEndTime.TabIndex = 13;
            mtbEndTime.ValidatingType = typeof(DateTime);
            // 
            // mtbStartTime
            // 
            mtbStartTime.Location = new Point(154, 238);
            mtbStartTime.Mask = "90:00";
            mtbStartTime.Name = "mtbStartTime";
            mtbStartTime.Size = new Size(52, 23);
            mtbStartTime.TabIndex = 12;
            mtbStartTime.ValidatingType = typeof(DateTime);
            // 
            // dateTimePicker1
            // 
            dateTimePicker1.Location = new Point(95, 179);
            dateTimePicker1.Name = "dateTimePicker1";
            dateTimePicker1.Size = new Size(137, 23);
            dateTimePicker1.TabIndex = 11;
            // 
            // label8
            // 
            label8.AutoSize = true;
            label8.Font = new Font("Segoe UI", 14.25F, FontStyle.Bold, GraphicsUnit.Point, 162);
            label8.Location = new Point(26, 296);
            label8.Name = "label8";
            label8.Size = new Size(68, 25);
            label8.TabIndex = 8;
            label8.Text = "Adres:";
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Font = new Font("Segoe UI", 14.25F, FontStyle.Bold, GraphicsUnit.Point, 162);
            label6.Location = new Point(30, 238);
            label6.Name = "label6";
            label6.Size = new Size(118, 25);
            label6.TabIndex = 7;
            label6.Text = "Saat Aralığı:";
            // 
            // label7
            // 
            label7.AutoSize = true;
            label7.Font = new Font("Segoe UI", 14.25F, FontStyle.Bold, GraphicsUnit.Point, 162);
            label7.Location = new Point(29, 177);
            label7.Name = "label7";
            label7.Size = new Size(60, 25);
            label7.TabIndex = 6;
            label7.Text = "Tarih:";
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Font = new Font("Segoe UI", 14.25F, FontStyle.Bold, GraphicsUnit.Point, 162);
            label5.Location = new Point(24, 104);
            label5.Name = "label5";
            label5.Size = new Size(97, 25);
            label5.TabIndex = 5;
            label5.Text = "Açıklama:";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Font = new Font("Segoe UI", 14.25F, FontStyle.Bold, GraphicsUnit.Point, 162);
            label4.Location = new Point(30, 41);
            label4.Name = "label4";
            label4.Size = new Size(65, 25);
            label4.TabIndex = 4;
            label4.Text = "Konu:";
            // 
            // button1
            // 
            button1.BackColor = Color.White;
            button1.Location = new Point(111, 435);
            button1.Name = "button1";
            button1.Size = new Size(165, 57);
            button1.TabIndex = 0;
            button1.Text = "İlan Ver";
            button1.UseVisualStyleBackColor = false;
            button1.Click += button1_Click;
            // 
            // dataGridView1
            // 
            dataGridView1.BackgroundColor = Color.White;
            dataGridView1.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridView1.Location = new Point(16, 70);
            dataGridView1.Name = "dataGridView1";
            dataGridView1.Size = new Size(514, 108);
            dataGridView1.TabIndex = 15;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Segoe UI", 14.25F, FontStyle.Bold, GraphicsUnit.Point, 162);
            label3.Location = new Point(16, 38);
            label3.Name = "label3";
            label3.Size = new Size(112, 25);
            label3.TabIndex = 3;
            label3.Text = "Tüm İlanlar";
            // 
            // button2
            // 
            button2.BackColor = Color.White;
            button2.Location = new Point(16, 199);
            button2.Name = "button2";
            button2.Size = new Size(155, 33);
            button2.TabIndex = 1;
            button2.Text = "Sil";
            button2.UseVisualStyleBackColor = false;
            button2.Click += button2_Click;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI", 21.75F, FontStyle.Bold, GraphicsUnit.Point, 162);
            label1.Location = new Point(154, 48);
            label1.Name = "label1";
            label1.Size = new Size(121, 40);
            label1.TabIndex = 2;
            label1.Text = "İlan Ver";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Segoe UI", 21.75F, FontStyle.Bold, GraphicsUnit.Point, 162);
            label2.Location = new Point(855, 48);
            label2.Name = "label2";
            label2.Size = new Size(104, 40);
            label2.TabIndex = 3;
            label2.Text = "İlanlar";
            // 
            // panel1
            // 
            panel1.BackColor = SystemColors.ActiveCaption;
            panel1.Controls.Add(label12);
            panel1.Controls.Add(label11);
            panel1.Controls.Add(label9);
            panel1.Controls.Add(dataGridView1);
            panel1.Controls.Add(button3);
            panel1.Controls.Add(dataGridView2);
            panel1.Controls.Add(label3);
            panel1.Controls.Add(button2);
            panel1.Location = new Point(623, 91);
            panel1.Name = "panel1";
            panel1.Size = new Size(544, 525);
            panel1.TabIndex = 4;
            // 
            // label12
            // 
            label12.AutoSize = true;
            label12.Location = new Point(16, 417);
            label12.Name = "label12";
            label12.Size = new Size(413, 15);
            label12.TabIndex = 18;
            label12.Text = "Satırı seçtikten sonra butona tıklayarak ilanı yapıldı olarak güncelleyebilirsiniz.";
            // 
            // label11
            // 
            label11.AutoSize = true;
            label11.Location = new Point(16, 181);
            label11.Name = "label11";
            label11.Size = new Size(300, 15);
            label11.TabIndex = 17;
            label11.Text = "Satırı seçtikten sonra butona tıklayarak ilanı silebilirsiniz.";
            // 
            // label9
            // 
            label9.AutoSize = true;
            label9.Font = new Font("Segoe UI", 14.25F, FontStyle.Bold, GraphicsUnit.Point, 162);
            label9.Location = new Point(16, 279);
            label9.Name = "label9";
            label9.Size = new Size(143, 25);
            label9.TabIndex = 16;
            label9.Text = "Alınmış İlanlar ";
            // 
            // button3
            // 
            button3.BackColor = Color.White;
            button3.Location = new Point(16, 435);
            button3.Name = "button3";
            button3.Size = new Size(155, 33);
            button3.TabIndex = 1;
            button3.Text = "Güncelle";
            button3.UseVisualStyleBackColor = false;
            button3.Click += button3_Click;
            // 
            // dataGridView2
            // 
            dataGridView2.BackgroundColor = Color.White;
            dataGridView2.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridView2.Location = new Point(16, 307);
            dataGridView2.Name = "dataGridView2";
            dataGridView2.Size = new Size(514, 107);
            dataGridView2.TabIndex = 0;
            dataGridView2.CellContentClick += dataGridView2_CellContentClick;
            // 
            // label10
            // 
            label10.AutoSize = true;
            label10.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point, 162);
            label10.Location = new Point(37, 9);
            label10.Name = "label10";
            label10.Size = new Size(66, 21);
            label10.TabIndex = 7;
            label10.Text = "label10";
            // 
            // VakifAnaSayfaUI
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.White;
            ClientSize = new Size(1262, 648);
            Controls.Add(label10);
            Controls.Add(panel1);
            Controls.Add(label2);
            Controls.Add(label1);
            Controls.Add(panel2);
            Name = "VakifAnaSayfaUI";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Vakıf Anasayfa";
            Load += VakifAnaSayfaUI_Load;
            panel2.ResumeLayout(false);
            panel2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)dataGridView1).EndInit();
            panel1.ResumeLayout(false);
            panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)dataGridView2).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion
        private Panel panel2;
		private Button button2;
		private Button button1;
		private Label label1;
		private Label label2;
		private Label label3;
        private Label label8;
        private Label label6;
        private Label label7;
        private Label label5;
        private Label label4;
        private MaskedTextBox mtbStartTime;
        private DateTimePicker dateTimePicker1;
        private MaskedTextBox mtbEndTime;
        private TextBox textBox1;
        private TextBox textBox3;
        private TextBox textBox2;
        private DataGridView dataGridView1;
        private Panel panel1;
        private DataGridView dataGridView2;
        private Button button3;
        private Label label10;
        private Label label12;
        private Label label11;
        private Label label9;
    }
}