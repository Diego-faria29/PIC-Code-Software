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

namespace UI
{
    public partial class FRMconsulta : Form
    {
        public MODELOCliente modelcliente;
        public FRMconsulta()
        {
            InitializeComponent();
            
        }

        private void btnconsulta_Click(object sender, EventArgs e)
        {
            DadosDaConexao dc = new DadosDaConexao();
            DALConection con = new DALConection(dc.StringConection);

            MODELOCliente modelo = new MODELOCliente();

            BLLCLiente controle = new BLLCLiente(con);

            if (controle.mensagem.Equals(""))
            {
                dtgrid1.DataSource = controle.verificar(txtNome.Text);
            }
            else
            {
                MessageBox.Show(controle.mensagem);
            }

        }



        private void dtgrid1_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            // linha cliclada da celula 1;
            this.modelcliente = new MODELOCliente();

            this.modelcliente.Id_cliente = Convert.ToInt32(dtgrid1.Rows[e.RowIndex].Cells[0].Value);
            this.modelcliente.Nome = dtgrid1.Rows[e.RowIndex].Cells[1].Value.ToString();
            this.modelcliente.Email = dtgrid1.Rows[e.RowIndex].Cells[2].Value.ToString();
            this.modelcliente.Cpf = dtgrid1.Rows[e.RowIndex].Cells[3].Value.ToString();
            this.modelcliente.Telefone = dtgrid1.Rows[e.RowIndex].Cells[4].Value.ToString();
            this.modelcliente.Endereco = dtgrid1.Rows[e.RowIndex].Cells[5].Value.ToString();
            //this.modelcliente.Valor_pendente = float.Parse(dtgrid1.Rows[e.RowIndex].Cells[6].Value.ToString());

            this.Close();
            
        }

    }
}
