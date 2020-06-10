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
    public partial class FRMMenu : Form
    {
        public FRMMenu()
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
            FRMCADCliente c = new FRMCADCliente();
            c.ShowDialog();
        }

        private void BTN_Venda_Click(object sender, EventArgs e)
        {
            FRMVenda v = new FRMVenda();
            v.ShowDialog();
        }

        private void BTN_ConsultarVenda_Click(object sender, EventArgs e)
        {
            FRMBuscarvenda bv = new FRMBuscarvenda();
            bv.ShowDialog();
        }

        private void BTNalteraedeleta_Click(object sender, EventArgs e)
        {
            FRMAlterarcliente ad = new FRMAlterarcliente();
            ad.ShowDialog();
        }

        private void BTNdeletemenu_Click(object sender, EventArgs e)
        {
            FRMDeletarvenda dl = new FRMDeletarvenda();
            dl.ShowDialog();
        }

        private void BTNSair_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }
    }
}
