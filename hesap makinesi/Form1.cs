namespace hesap_makinesi
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            double sayi1, sayi2;

            sayi1 = Convert.ToDouble(textBox1.Text);
            sayi2 = Convert.ToDouble(textBox2.Text);
              
              double toplam = sayi1 + sayi2;
            label7.Text = toplam.ToString();

              double fark = sayi1 - sayi2;
            label8.Text = fark.ToString();

            double �arpma = sayi1 * sayi2;
            label9.Text = �arpma.ToString();

            double b�lme = sayi1 / sayi2;
            label10.Text = b�lme.ToString();
        }
    }
}