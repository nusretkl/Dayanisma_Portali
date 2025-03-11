namespace Dayanisma_Portali.UI
{
	partial class Form1
	{
		/// <summary>
		///  Required designer variable.
		/// </summary>
		private System.ComponentModel.IContainer components = null;

		/// <summary>
		///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            button1 = new Button();
            button2 = new Button();
            button3 = new Button();
            button4 = new Button();
            label1 = new Label();
            panel1 = new Panel();
            panel2 = new Panel();
            panel1.SuspendLayout();
            panel2.SuspendLayout();
            SuspendLayout();
            // 
            // button1
            // 
            button1.BackColor = Color.White;
            button1.Location = new Point(44, 35);
            button1.Name = "button1";
            button1.Padding = new Padding(1);
            button1.Size = new Size(196, 51);
            button1.TabIndex = 0;
            button1.Text = "Kullanıcı Giriş";
            button1.UseVisualStyleBackColor = false;
            button1.Click += button1_Click;
            // 
            // button2
            // 
            button2.BackColor = Color.White;
            button2.Location = new Point(38, 35);
            button2.Name = "button2";
            button2.Size = new Size(196, 51);
            button2.TabIndex = 3;
            button2.Text = "Vakıf Giriş";
            button2.UseVisualStyleBackColor = false;
            button2.Click += button2_Click;
            // 
            // button3
            // 
            button3.BackColor = Color.White;
            button3.Location = new Point(44, 155);
            button3.Name = "button3";
            button3.Size = new Size(196, 51);
            button3.TabIndex = 1;
            button3.Text = "Kullanıcı Kayıt";
            button3.UseVisualStyleBackColor = false;
            button3.Click += button3_Click;
            // 
            // button4
            // 
            button4.BackColor = Color.White;
            button4.ForeColor = Color.Black;
            button4.Location = new Point(38, 155);
            button4.Name = "button4";
            button4.Size = new Size(196, 51);
            button4.TabIndex = 2;
            button4.Text = "Vakıf Kayıt";
            button4.UseVisualStyleBackColor = false;
            button4.Click += button4_Click;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI", 18F, FontStyle.Bold, GraphicsUnit.Point, 162);
            label1.Location = new Point(179, 41);
            label1.Name = "label1";
            label1.Size = new Size(401, 32);
            label1.TabIndex = 4;
            label1.Text = "Dayanışma Portalına Hoş Geldiniz";
            // 
            // panel1
            // 
            panel1.BackColor = SystemColors.ActiveCaption;
            panel1.Controls.Add(button1);
            panel1.Controls.Add(button3);
            panel1.Location = new Point(39, 123);
            panel1.Name = "panel1";
            panel1.Size = new Size(275, 267);
            panel1.TabIndex = 5;
            // 
            // panel2
            // 
            panel2.BackColor = SystemColors.ActiveCaption;
            panel2.Controls.Add(button4);
            panel2.Controls.Add(button2);
            panel2.Location = new Point(432, 123);
            panel2.Name = "panel2";
            panel2.Size = new Size(275, 267);
            panel2.TabIndex = 6;
            panel2.Paint += panel2_Paint;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.White;
            ClientSize = new Size(773, 457);
            Controls.Add(panel2);
            Controls.Add(panel1);
            Controls.Add(label1);
            Name = "Form1";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Dayanışma Portalı";
            Load += Form1_Load;
            panel1.ResumeLayout(false);
            panel2.ResumeLayout(false);
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Button button1;
		private Button button2;
		private Button button3;
        private Button button4;
        private Label label1;
        private Panel panel1;
        private Panel panel2;
    }
}
