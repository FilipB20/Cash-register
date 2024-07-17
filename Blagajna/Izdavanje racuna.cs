using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Blagajna;

namespace Blagajna
{
    public partial class Izdavanje_racuna : Form
    {
        double Total;
        Form1 forma1Instance;
        Konobar konobar = new Konobar("Filip B");
        public Izdavanje_racuna(Form1 forma1,ListBox box)
        {
            InitializeComponent();
            forma1Instance = forma1;
            Total = forma1Instance.GetTotal();
            button1.Text = Total.ToString();
            foreach (object stavka in box.Items)
            {
                listBox1.Items.Add(stavka);
            }
            listBox1.Items.Add(konobar);
        }

        private void button1_Click(object sender, EventArgs e)//Ukupno
        {
            button1.Text = Total.ToString();
        }

        private void listBox1_SelectedIndexChanged(object sender, EventArgs e)
        {

        }
    }
}
