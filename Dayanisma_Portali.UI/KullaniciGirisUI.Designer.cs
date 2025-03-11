namespace Dayanisma_Portali.UI
{
	partial class KullaniciGirisUI
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
            textBox1 = new TextBox();
            textBox2 = new TextBox();
            button1 = new Button();
            panel1 = new Panel();
            panel1.SuspendLayout();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point, 162);
            label1.Location = new Point(26, 54);
            label1.Name = "label1";
            label1.Size = new Size(63, 21);
            label1.TabIndex = 0;
            label1.Text = "E-Mail:";
            label1.Click += label1_Click;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point, 162);
            label2.Location = new Point(40, 119);
            label2.Name = "label2";
            label2.Size = new Size(49, 21);
            label2.TabIndex = 1;
            label2.Text = "Şifre:";
            label2.Click += label2_Click;
            // 
            // textBox1
            // 
            textBox1.Location = new Point(100, 51);
            textBox1.Name = "textBox1";
            textBox1.Size = new Size(181, 23);
            textBox1.TabIndex = 0;
            textBox1.TextChanged += textBox1_TextChanged;
            // 
            // textBox2
            // 
            textBox2.Location = new Point(100, 117);
            textBox2.Name = "textBox2";
            textBox2.PasswordChar = '*';
            textBox2.Size = new Size(181, 23);
            textBox2.TabIndex = 1;
            textBox2.Tag = "*";
            textBox2.TextChanged += textBox2_TextChanged;
            // 
            // button1
            // 
            button1.BackColor = Color.White;
            button1.Location = new Point(115, 201);
            button1.Name = "button1";
            button1.Size = new Size(127, 36);
            button1.TabIndex = 4;
            button1.Text = "Giriş Yap";
            button1.UseVisualStyleBackColor = false;
            button1.Click += button1_Click;
            // 
            // panel1
            // 
            panel1.BackColor = SystemColors.ActiveCaption;
            panel1.Controls.Add(button1);
            panel1.Controls.Add(label1);
            panel1.Controls.Add(textBox2);
            panel1.Controls.Add(label2);
            panel1.Controls.Add(textBox1);
            panel1.Location = new Point(129, 105);
            panel1.Name = "panel1";
            panel1.Size = new Size(344, 273);
            panel1.TabIndex = 5;
            // 
            // KullaniciGirisUI
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.White;
            ClientSize = new Size(627, 477);
            Controls.Add(panel1);
            Name = "KullaniciGirisUI";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Kullanıcı Girişi";
            panel1.ResumeLayout(false);
            panel1.PerformLayout();
            ResumeLayout(false);
        }

        #endregion

        private Label label1;
		private Label label2;
		private TextBox textBox1;
		private TextBox textBox2;
		private Button button1;
        private Panel panel1;
    }
}