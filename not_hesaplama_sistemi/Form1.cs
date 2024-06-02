namespace not_hesaplama_sistemi
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            string ad, soyad;
            int sýnav1, sýnav2, proje;
            double ortalama;
            ad = textBox1.Text;
            soyad = textBox2.Text;
            sýnav1 = Convert.ToInt32(textBox3.Text);
            sýnav2 = Convert.ToInt32(textBox4.Text);
            proje= Convert.ToInt32(textBox5.Text);
            ortalama = (sýnav1 + sýnav2 + proje) / 3;
            listBox1.Items.Add("Ad:  " + ad + " Soyad:   " +  soyad    +  "Ortalama:   " +   ortalama);

        }
    }
}