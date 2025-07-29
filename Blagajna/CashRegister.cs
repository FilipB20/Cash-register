using CashRegister;
namespace CashRegister
{
    public partial class CashRegister : Form
    {
        double Ukupno = 0;

        public double GetTotal() { return Ukupno; }
        public CashRegister()
        {
            InitializeComponent();
        }

        private void CoffeeButton_Click(object sender, EventArgs e)//Kava
        {
            Receipt.Items.Add(new Coffee(1.3, "Nescaffe", "Mlijeko"));
            Ukupno += 1.3;
        }

        private void CedevitaButton_Click(object sender, EventArgs e)//Ceda
        {
            Receipt.Items.Add(new Cedevita("Cedevita", 1.5));
            Ukupno += 1.5;
        }
        private void BeerButton_Click(object sender, EventArgs e)//Pivo
        {
            Receipt.Items.Add(new Beer("Ozujsko", "Svijetlo pivo", 2));
            Ukupno += 2;
        }
        private void IssueButton_Click(object sender, EventArgs e)//Izdaj racun
        {
                ReceiptIssuer novaForma = new ReceiptIssuer(this,Receipt);
                novaForma.Show(); 
        }
        private void RakijaButton_Click(object sender, EventArgs e)//Rakija
        {
            Receipt.Items.Add(new Rakija("Maraska", 1, "Sljivovica"));
            Ukupno += 1;
        }

        private void TotalButton_Click(object sender, EventArgs e) // Ukupno
        {
            TotalButton.Text = Ukupno.ToString();
        }

        private void EmptyButton_Click(object sender, EventArgs e)
        {
            Ukupno = 0;
            TotalButton.Text = "Ukupno";
            Receipt.Items.Clear();
        }
    }
}