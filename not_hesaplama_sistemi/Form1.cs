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
            int s�nav1, s�nav2, proje;
            double ortalama;
            ad = textBox1.Text;
            soyad = textBox2.Text;
            s�nav1 = Convert.ToInt32(textBox3.Text);
            s�nav2 = Convert.ToInt32(textBox4.Text);
            proje= Convert.ToInt32(textBox5.Text);
            ortalama = (s�nav1 + s�nav2 + proje) / 3;
            listBox1.Items.Add("Ad:  " + ad + " Soyad:   " +  soyad    +  "Ortalama:   " +   ortalama);

        }
    }
}