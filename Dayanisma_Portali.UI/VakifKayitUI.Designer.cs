namespace Dayanisma_Portali.UI
{
    partial class VakifKayitUI
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
            comboBox1 = new ComboBox();
            textBox4 = new TextBox();
            textBox3 = new TextBox();
            textBox1 = new TextBox();
            label5 = new Label();
            label4 = new Label();
            label3 = new Label();
            label1 = new Label();
            button1 = new Button();
            textBox2 = new TextBox();
            label6 = new Label();
            panel1 = new Panel();
            panel1.SuspendLayout();
            SuspendLayout();
            // 
            // comboBox1
            // 
            comboBox1.FormattingEnabled = true;
            comboBox1.Location = new Point(177, 90);
            comboBox1.Name = "comboBox1";
            comboBox1.Size = new Size(164, 23);
            comboBox1.TabIndex = 1;
            // 
            // textBox4
            // 
            textBox4.Location = new Point(177, 239);
            textBox4.Name = "textBox4";
            textBox4.PasswordChar = '*';
            textBox4.Size = new Size(164, 23);
            textBox4.TabIndex = 4;
            // 
            // textBox3
            // 
            textBox3.Location = new Point(177, 140);
            textBox3.Name = "textBox3";
            textBox3.Size = new Size(164, 23);
            textBox3.TabIndex = 2;
            // 
            // textBox1
            // 
            textBox1.Location = new Point(177, 35);
            textBox1.Name = "textBox1";
            textBox1.Size = new Size(164, 23);
            textBox1.TabIndex = 0;
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point, 162);
            label5.Location = new Point(134, 92);
            label5.Name = "label5";
            label5.Size = new Size(24, 21);
            label5.TabIndex = 20;
            label5.Text = "İl:";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point, 162);
            label4.Location = new Point(115, 241);
            label4.Name = "label4";
            label4.Size = new Size(49, 21);
            label4.TabIndex = 18;
            label4.Text = "Şifre:";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point, 162);
            label3.Location = new Point(101, 142);
            label3.Name = "label3";
            label3.Size = new Size(57, 21);
            label3.TabIndex = 17;
            label3.Text = "Adres:";
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point, 162);
            label1.Location = new Point(129, 37);
            label1.Name = "label1";
            label1.Size = new Size(35, 21);
            label1.TabIndex = 15;
            label1.Text = "Ad:";
            // 
            // button1
            // 
            button1.BackColor = Color.White;
            button1.Location = new Point(177, 316);
            button1.Name = "button1";
            button1.Size = new Size(139, 50);
            button1.TabIndex = 5;
            button1.Text = "Kayıt Ol";
            button1.UseVisualStyleBackColor = false;
            button1.Click += button1_Click;
            // 
            // textBox2
            // 
            textBox2.Location = new Point(177, 188);
            textBox2.Name = "textBox2";
            textBox2.Size = new Size(164, 23);
            textBox2.TabIndex = 3;
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point, 162);
            label6.Location = new Point(9, 188);
            label6.Name = "label6";
            label6.Size = new Size(149, 21);
            label6.TabIndex = 30;
            label6.Text = "Telefon Numarası:";
            // 
            // panel1
            // 
            panel1.BackColor = SystemColors.ActiveCaption;
            panel1.Controls.Add(button1);
            panel1.Controls.Add(textBox2);
            panel1.Controls.Add(label1);
            panel1.Controls.Add(label6);
            panel1.Controls.Add(label3);
            panel1.Controls.Add(label4);
            panel1.Controls.Add(label5);
            panel1.Controls.Add(comboBox1);
            panel1.Controls.Add(textBox1);
            panel1.Controls.Add(textBox4);
            panel1.Controls.Add(textBox3);
            panel1.Location = new Point(92, 46);
            panel1.Name = "panel1";
            panel1.Size = new Size(448, 397);
            panel1.TabIndex = 32;
            // 
            // VakifKayitUI
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.White;
            ClientSize = new Size(625, 492);
            Controls.Add(panel1);
            Name = "VakifKayitUI";
            StartPosition = FormStartPosition.CenterScreen;
            Text = " Vakıf Kayıt";
            Load += VakifKayitUI_Load;
            panel1.ResumeLayout(false);
            panel1.PerformLayout();
            ResumeLayout(false);
        }

        #endregion

        private ComboBox comboBox1;
        private TextBox textBox4;
        private TextBox textBox3;
        private TextBox textBox1;
        private Label label5;
        private Label label4;
        private Label label3;
        private Label label1;
        private Button button1;
        private TextBox textBox2;
        private Label label6;
        private Panel panel1;
    }
}