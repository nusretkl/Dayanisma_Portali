namespace Dayanisma_Portali.UI
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            KullaniciGirisUI kullaniciGirisUI = new KullaniciGirisUI();
            kullaniciGirisUI.Show();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            KullaniciKayitUI kay�tUI = new KullaniciKayitUI();
            kay�tUI.Show();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            Vak�fGirisUI vakifUI = new Vak�fGirisUI();
            vakifUI.Show();
        }

        private void button4_Click(object sender, EventArgs e)
        {
            VakifKayitUI vakifKayitUI = new VakifKayitUI();
            vakifKayitUI.Show();
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void panel2_Paint(object sender, PaintEventArgs e)
        {

        }
    }
}
