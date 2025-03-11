namespace Dayanisma_Portali.UI
{
	partial class VakıfGirisUI
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
            button1 = new Button();
            textBox2 = new TextBox();
            textBox1 = new TextBox();
            label2 = new Label();
            label1 = new Label();
            panel2 = new Panel();
            panel2.SuspendLayout();
            SuspendLayout();
            // 
            // button1
            // 
            button1.BackColor = Color.White;
            button1.Location = new Point(109, 197);
            button1.Margin = new Padding(0);
            button1.Name = "button1";
            button1.Size = new Size(127, 36);
            button1.TabIndex = 3;
            button1.Text = "Giriş Yap";
            button1.UseVisualStyleBackColor = false;
            button1.Click += button1_Click;
            // 
            // textBox2
            // 
            textBox2.Location = new Point(109, 124);
            textBox2.Name = "textBox2";
            textBox2.PasswordChar = '*';
            textBox2.Size = new Size(181, 23);
            textBox2.TabIndex = 2;
            // 
            // textBox1
            // 
            textBox1.Location = new Point(109, 58);
            textBox1.Name = "textBox1";
            textBox1.Size = new Size(181, 23);
            textBox1.TabIndex = 1;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point, 162);
            label2.Location = new Point(49, 126);
            label2.Name = "label2";
            label2.Size = new Size(49, 21);
            label2.TabIndex = 6;
            label2.Text = "Şifre:";
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point, 162);
            label1.Location = new Point(15, 60);
            label1.Name = "label1";
            label1.Size = new Size(83, 21);
            label1.TabIndex = 5;
            label1.Text = "Vakıf Adı:";
            // 
            // panel2
            // 
            panel2.BackColor = SystemColors.ActiveCaption;
            panel2.Controls.Add(button1);
            panel2.Controls.Add(label1);
            panel2.Controls.Add(textBox2);
            panel2.Controls.Add(label2);
            panel2.Controls.Add(textBox1);
            panel2.Location = new Point(102, 65);
            panel2.Name = "panel2";
            panel2.Size = new Size(321, 267);
            panel2.TabIndex = 7;
            // 
            // VakıfGirisUI
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.White;
            ClientSize = new Size(573, 422);
            Controls.Add(panel2);
            Name = "VakıfGirisUI";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Vakıf Giriş";
            panel2.ResumeLayout(false);
            panel2.PerformLayout();
            ResumeLayout(false);
        }

        #endregion

        private Button button1;
		private TextBox textBox2;
		private TextBox textBox1;
		private Label label2;
		private Label label1;
        private Panel panel2;
    }
}