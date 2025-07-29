using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using CashRegister;

namespace CashRegister
{
    public partial class ReceiptIssuer : Form
    {
        double Total;
        CashRegister cashRegister;
        Waiter konobar = new Waiter("Filip B");
        public ReceiptIssuer(CashRegister cashRegister,ListBox box)
        {
            InitializeComponent();
            this.cashRegister = cashRegister;
            Total = this.cashRegister.GetTotal();
            button1.Text = Total.ToString();
            foreach (object stavka in box.Items)
            {
                FinalReceipt.Items.Add(stavka);
            }
            FinalReceipt.Items.Add(konobar);
        }

        private void button1_Click(object sender, EventArgs e)//Ukupno
        {
            button1.Text = Total.ToString();
        }

    }
}
