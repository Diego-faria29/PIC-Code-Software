using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using UI;

namespace SoftwarePIC
{
    public partial class Menu : Form
    {
        public Menu()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            UI.FRMconsulta f = new UI.FRMconsulta();
            f.ShowDialog();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            FRMCliente c = new FRMCliente();
            c.ShowDialog();
        }

        private void BTN_Venda_Click(object sender, EventArgs e)
        {
            Venda v = new Venda();
            v.ShowDialog();
        }
    }
}
