using Blagajna;
namespace Blagajna
{
    public partial class Form1 : Form
    {
        double Ukupno = 0;

        public double GetTotal() { return Ukupno; }
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)//Kava
        {
            listBox1.Items.Add(new Coffee(1.3, "Nescaffe", "Mlijeko"));
            Ukupno += 1.3;
        }

        private void button2_Click(object sender, EventArgs e)//Ceda
        {
            listBox1.Items.Add(new Cedevita("Cedevita", 1.5));
            Ukupno += 1.5;
        }
        private void button3_Click(object sender, EventArgs e)//Pivo
        {
            listBox1.Items.Add(new Beer("Ozujsko", "Svijetlo pivo", 2));
            Ukupno += 2;
        }
        private void button5_Click(object sender, EventArgs e)//Izdaj racun
        {
                Izdavanje_racuna novaForma = new Izdavanje_racuna(this,listBox1);
                novaForma.Show(); 
        }
        private void button4_Click(object sender, EventArgs e)//Rakija
        {
            listBox1.Items.Add(new Rakija("Maraska", 1, "Sljivovica"));
            Ukupno += 1;
        }
        private void listBox1_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void button6_Click(object sender, EventArgs e) // Ukupno
        {
            button6.Text = Ukupno.ToString();
        }

        private void button7_Click(object sender, EventArgs e)
        {
            Ukupno = 0;
            button6.Text = "Ukupno";
            listBox1.Items.Clear();
        }
    }
}