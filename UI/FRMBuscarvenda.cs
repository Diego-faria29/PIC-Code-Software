using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using BLL;
using DAL;
using MODELO;

namespace SoftwarePIC
{
    public partial class FRMBuscarvenda : Form
    {
        public MODELOVenda modelvenda;
        public FRMBuscarvenda()
        {
            InitializeComponent();
        }

        private void BTNbuscarvenda_Click(object sender, EventArgs e)
        {

            DadosDaConexao dc = new DadosDaConexao();
            DALConection cx = new DALConection(dc.StringConection);
            BLLVenda bllvenda = new BLLVenda(cx);
            DataTable tabela = bllvenda.localizar(TXTnull.Text);
            dataGridViewBscVnd.DataSource = tabela;
        }


        private void dataGridViewBscVnd_CellContentDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            // linha cliclada da celula 1;
            this.modelvenda = new MODELOVenda();

            this.modelvenda.Id_pedido = Convert.ToInt32(dataGridViewBscVnd.Rows[e.RowIndex].Cells[0].Value.ToString());
            this.modelvenda.Id_cliente = Convert.ToInt32(dataGridViewBscVnd.Rows[e.RowIndex].Cells[2].Value.ToString());
            this.modelvenda.Produto = (dataGridViewBscVnd.Rows[e.RowIndex].Cells[3].Value.ToString());
            this.modelvenda.Quantidade = Convert.ToInt32(dataGridViewBscVnd.Rows[e.RowIndex].Cells[4].Value.ToString());
            this.modelvenda.Valor_total = float.Parse(dataGridViewBscVnd.Rows[e.RowIndex].Cells[5].Value.ToString());
            this.modelvenda.Forma_pagamento = (dataGridViewBscVnd.Rows[e.RowIndex].Cells[6].Value.ToString());

            this.Close();
        }
    }
}
