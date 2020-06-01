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
        public int codigo = 0;
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
                dtgrid1.DataSource = controle.verificar(txtNome.Text, txtCPF.Text);
            }
            else
            {
                MessageBox.Show(controle.mensagem);
            }
        }

        private void btnsair_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }



        private void dtgrid1_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            if(e.RowIndex >= 0)
            {
                this.codigo = Convert.ToInt32(dtgrid1.Rows[e.RowIndex].Cells[0].Value);
                this.Close();
            }
        }


    }
}
