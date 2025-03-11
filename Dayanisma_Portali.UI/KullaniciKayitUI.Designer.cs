namespace Dayanisma_Portali.UI
{
	partial class KullaniciKayitUI
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
            label1 = new Label();
            label2 = new Label();
            label3 = new Label();
            label4 = new Label();
            label5 = new Label();
            label6 = new Label();
            label7 = new Label();
            textBox1 = new TextBox();
            textBox2 = new TextBox();
            textBox3 = new TextBox();
            textBox4 = new TextBox();
            textBox5 = new TextBox();
            comboBox1 = new ComboBox();
            comboBox2 = new ComboBox();
            button1 = new Button();
            panel1 = new Panel();
            label8 = new Label();
            panel1.SuspendLayout();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point, 162);
            label1.Location = new Point(35, 25);
            label1.Name = "label1";
            label1.Size = new Size(35, 21);
            label1.TabIndex = 1;
            label1.Text = "Ad:";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point, 162);
            label2.Location = new Point(35, 63);
            label2.Name = "label2";
            label2.Size = new Size(61, 21);
            label2.TabIndex = 2;
            label2.Text = "Soyad:";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point, 162);
            label3.Location = new Point(35, 100);
            label3.Name = "label3";
            label3.Size = new Size(63, 21);
            label3.TabIndex = 3;
            label3.Text = "E-Mail:";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point, 162);
            label4.Location = new Point(35, 136);
            label4.Name = "label4";
            label4.Size = new Size(49, 21);
            label4.TabIndex = 4;
            label4.Text = "Şifre:";
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point, 162);
            label5.Location = new Point(-21, 188);
            label5.Name = "label5";
            label5.Size = new Size(24, 21);
            label5.TabIndex = 6;
            label5.Text = "İl:";
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point, 162);
            label6.Location = new Point(35, 174);
            label6.Name = "label6";
            label6.Size = new Size(71, 21);
            label6.TabIndex = 5;
            label6.Text = "Telefon:";
            // 
            // label7
            // 
            label7.AutoSize = true;
            label7.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point, 162);
            label7.Location = new Point(35, 246);
            label7.Name = "label7";
            label7.Size = new Size(75, 21);
            label7.TabIndex = 7;
            label7.Text = "Cinsiyet:";
            // 
            // textBox1
            // 
            textBox1.Location = new Point(138, 25);
            textBox1.Name = "textBox1";
            textBox1.Size = new Size(164, 21);
            textBox1.TabIndex = 0;
            // 
            // textBox2
            // 
            textBox2.Location = new Point(138, 61);
            textBox2.Name = "textBox2";
            textBox2.Size = new Size(164, 21);
            textBox2.TabIndex = 1;
            // 
            // textBox3
            // 
            textBox3.Location = new Point(138, 98);
            textBox3.Name = "textBox3";
            textBox3.Size = new Size(164, 21);
            textBox3.TabIndex = 2;
            // 
            // textBox4
            // 
            textBox4.Location = new Point(138, 134);
            textBox4.Name = "textBox4";
            textBox4.PasswordChar = '*';
            textBox4.Size = new Size(164, 21);
            textBox4.TabIndex = 3;
            // 
            // textBox5
            // 
            textBox5.Location = new Point(138, 172);
            textBox5.Name = "textBox5";
            textBox5.Size = new Size(164, 21);
            textBox5.TabIndex = 4;
            // 
            // comboBox1
            // 
            comboBox1.FormattingEnabled = true;
            comboBox1.Location = new Point(138, 210);
            comboBox1.Name = "comboBox1";
            comboBox1.Size = new Size(165, 23);
            comboBox1.TabIndex = 5;
            comboBox1.DropDown += KullaniciKayitUI_Load;
            comboBox1.SelectedIndexChanged += comboBox1_SelectedIndexChanged;
            // 
            // comboBox2
            // 
            comboBox2.FormattingEnabled = true;
            comboBox2.Items.AddRange(new object[] { "Erkek", "Kız\t" });
            comboBox2.Location = new Point(138, 244);
            comboBox2.Name = "comboBox2";
            comboBox2.Size = new Size(164, 23);
            comboBox2.TabIndex = 6;
            // 
            // button1
            // 
            button1.BackColor = Color.White;
            button1.FlatStyle = FlatStyle.Flat;
            button1.Location = new Point(124, 315);
            button1.Margin = new Padding(0);
            button1.Name = "button1";
            button1.Size = new Size(150, 47);
            button1.TabIndex = 7;
            button1.Text = "Kayıt Ol";
            button1.UseVisualStyleBackColor = false;
            button1.Click += button1_Click;
            // 
            // panel1
            // 
            panel1.BackColor = SystemColors.ActiveCaption;
            panel1.Controls.Add(label8);
            panel1.Controls.Add(button1);
            panel1.Controls.Add(label1);
            panel1.Controls.Add(comboBox2);
            panel1.Controls.Add(label2);
            panel1.Controls.Add(comboBox1);
            panel1.Controls.Add(label3);
            panel1.Controls.Add(textBox5);
            panel1.Controls.Add(label4);
            panel1.Controls.Add(textBox4);
            panel1.Controls.Add(label6);
            panel1.Controls.Add(textBox3);
            panel1.Controls.Add(label5);
            panel1.Controls.Add(textBox2);
            panel1.Controls.Add(label7);
            panel1.Controls.Add(textBox1);
            panel1.Location = new Point(112, 51);
            panel1.Name = "panel1";
            panel1.Size = new Size(363, 391);
            panel1.TabIndex = 9;
            // 
            // label8
            // 
            label8.AutoSize = true;
            label8.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point, 162);
            label8.Location = new Point(35, 212);
            label8.Name = "label8";
            label8.Size = new Size(24, 21);
            label8.TabIndex = 10;
            label8.Text = "İl:";
            // 
            // KullaniciKayitUI
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.White;
            ClientSize = new Size(601, 498);
            Controls.Add(panel1);
            Font = new Font("Microsoft Sans Serif", 9F);
            Name = "KullaniciKayitUI";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Kullanıcı Kayıt";
            panel1.ResumeLayout(false);
            panel1.PerformLayout();
            ResumeLayout(false);
        }

        #endregion

        private Label label1;
		private Label label2;
		private Label label3;
		private Label label4;
		private Label label5;
		private Label label6;
		private Label label7;
		private TextBox textBox1;
		private TextBox textBox2;
		private TextBox textBox3;
		private TextBox textBox4;
		private TextBox textBox5;
		private ComboBox comboBox1;
		private ComboBox comboBox2;
		private Button button1;
        private Panel panel1;
        private Label label8;
    }
}