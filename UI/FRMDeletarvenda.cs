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
using MySql.Data.MySqlClient;
using UI;

namespace SoftwarePIC
{
    public partial class FRMDeletarvenda : Form
    {
        public FRMDeletarvenda()
        {
            InitializeComponent();
        }

        private void popularcampos1(MODELOVenda p)
        {
            try
            {
                if(p == null)
                {
                    BOXIDpediedodeletavnd.Text = "";
                    BOXVLdelvnd.Text = "";
                    BOXprodutoDL.Text = "";
                    alterapropriedades(2);
                }
                else
                {
                    BOXIDpediedodeletavnd.Text = p.Id_pedido.ToString();
                    BOXVLdelvnd.Text = p.Valor_total.ToString();
                    BOXprodutoDL.Text = p.Produto.ToString();
                }

            }
            catch (MySqlException error)
            {
                MessageBox.Show("Falha ao alterar. Erro: " + error.Message);

            }
            catch (Exception error2)
            {
                MessageBox.Show("Falha ao alterar. Erro inesperado: " + error2.Message);
            }


        }
        private void BTNConsultavendadel_Click(object sender, EventArgs e)
        {
            FRMBuscarvenda dl = new FRMBuscarvenda();
            dl.ShowDialog();
            alterapropriedades(3);
            popularcampos1(dl.modelvenda);

            
        }
        private void popularcampos(MODELOCliente p)
        {
            try
            {
                if(p == null)
                {
                    BOXIDdeletavnd.Text = "";
                    BOXNomeDL.Text = "";
                    BOXCPFDl.Text = "";
                    
                }
                else
                {
                    BOXIDdeletavnd.Text = p.Id_cliente.ToString();
                    BOXNomeDL.Text = p.Nome;
                    BOXCPFDl.Text = p.Cpf;
                }

            }
            catch (MySqlException error)
            {
                MessageBox.Show("Falha ao alterar. Erro: " + error.Message);

            }
            catch (Exception error2)
            {
                MessageBox.Show("Falha ao alterar. Erro inesperado: " + error2.Message);
            }

        }
        private void BTNDeletar_Click(object sender, EventArgs e)
        {
            try
            {
                DadosDaConexao dd = new DadosDaConexao();
                DALConection cx = new DALConection(dd.StringConection);
                BLLVenda bllpedido = new BLLVenda(cx);
                bllpedido.Excluir(Convert.ToInt32(BOXIDpediedodeletavnd.Text));
                MessageBox.Show("Venda deletada com sucesso!");
            }
            catch (MySqlException error)
            {
                MessageBox.Show("Falha ao deletar. Erro: " + error.Message);
            }
            catch (Exception error2)
            {
                MessageBox.Show("Falha ao deletar. Erro inesperado: " + error2.Message);
            }
        }

        private void BTNConclienteDL_Click(object sender, EventArgs e)
        {
            FRMconsulta dl = new FRMconsulta();
            dl.ShowDialog();
            alterapropriedades(2);
            popularcampos(dl.modelcliente);
            
        }

        public void alterapropriedades(int op)
        {
            //op = operacao
            // 1 = consultar cliente
            // 2 = consultar venda | CONS CLIENTE
            // 3 = OS 3 BTN
            BTNConclienteDL.Enabled = false;
            BTNConsultavendadel.Enabled = false;
            BTNDeletar.Enabled = false;
            PN_DL.Enabled = false;
            
            switch (op)
            {
                case 1:
                    BTNConclienteDL.Enabled = true;
                    break;
                case 2:
                    BTNConclienteDL.Enabled = true;
                    BTNConsultavendadel.Enabled = true;
                    PN_DL.Enabled = true;
                    break;
                case 3:
                    BTNConclienteDL.Enabled = true;
                    BTNConsultavendadel.Enabled = true;
                    BTNDeletar.Enabled = true;
                    PN_DL.Enabled = true;
                    break;
            }
        }

        private void FRMDeletarvenda_Load(object sender, EventArgs e)
        {
            alterapropriedades(1);
        }
    }
}
