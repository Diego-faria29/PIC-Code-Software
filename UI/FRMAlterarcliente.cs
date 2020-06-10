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

namespace SoftwarePIC
{
    public partial class FRMAlterarcliente : Form
    {
        public FRMAlterarcliente()
        {
            InitializeComponent();
        }

        private void popularcampos(MODELOCliente p)
        {
            try
            {

                if(p == null)
                {
                    BOXAlteranome.Text = "";
                    BOXAlteraemail.Text = "";
                    BOXCpfaltera.Text = "";
                    BOXTelAltera.Text = "";
                    BOXEndaltera.Text = "";
                    BOXIDaltera.Text = "";
                    alterapropriedades(1);
                }
                else
                {
                    BOXAlteranome.Text = p.Nome;
                    BOXAlteraemail.Text = p.Email;
                    BOXCpfaltera.Text = p.Cpf;
                    BOXTelAltera.Text = p.Telefone;
                    BOXEndaltera.Text = p.Endereco;
                    BOXIDaltera.Text = p.Id_cliente.ToString();
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

        private void BTNbuscaaltera_Click(object sender, EventArgs e)
        {
            UI.FRMconsulta f = new UI.FRMconsulta();
            f.ShowDialog();
            alterapropriedades(2);
            popularcampos(f.modelcliente);
            
        }

        private void BTNalterar_Click(object sender, EventArgs e)
        {
            try
            {
                DadosDaConexao dd = new DadosDaConexao();
                DALConection cx = new DALConection(dd.StringConection);

                BLLCLiente bllcliente = new BLLCLiente(cx);

                MODELOCliente modelocliente = new MODELOCliente();
                modelocliente.Nome = BOXAlteranome.Text;
                modelocliente.Email = BOXAlteraemail.Text;
                modelocliente.Cpf = BOXCpfaltera.Text;
                modelocliente.Telefone = BOXTelAltera.Text;
                modelocliente.Endereco = BOXEndaltera.Text;
                modelocliente.Id_cliente = Convert.ToInt32(BOXIDaltera.Text);

                bllcliente.Alterar(modelocliente);
                MessageBox.Show("Cliente alterado com sucesso!");
                BOXAlteranome.Text = "";
                BOXAlteraemail.Text = "";
                BOXCpfaltera.Text = "";
                BOXTelAltera.Text = "";
                BOXEndaltera.Text = "";
                BOXIDaltera.Text = "";
                alterapropriedades(1);


            }
            catch (MySqlException error)
            {
                if (error.Message.Contains("Duplicate "))
                {
                    MessageBox.Show("Falha ao alterar. CPF ou Email já cadastrado.");
                }
                else
                {
                    MessageBox.Show("Falha ao alterar. Erro: " + error.Message);
                }

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
                BLLCLiente bllcliente = new BLLCLiente(cx);
                bllcliente.Excluir(Convert.ToInt32(BOXIDaltera.Text));
                MessageBox.Show("Cliente deletado com sucesso!");
                BOXAlteranome.Text = "";
                BOXAlteraemail.Text = "";
                BOXCpfaltera.Text = "";
                BOXTelAltera.Text = "";
                BOXEndaltera.Text = "";
                BOXIDaltera.Text = "";
                alterapropriedades(1);
            }
            catch (MySqlException error)
            {
                    MessageBox.Show("Falha ao excluir. Erro: " + error.Message);  

            }
            catch (Exception error2)
            {
                MessageBox.Show("Falha ao excluir. Erro inesperado: " + error2.Message);
            }
        }

        public void alterapropriedades(int op)
        {
            //op = operacao
            // 1 = Buscar
            // 2 = Buscar | alterar | deletar
            BTNalterar.Enabled = false;
            BTNbuscaaltera.Enabled = false;
            BTNDeletar.Enabled = false;
            PN_dadosAltera.Enabled = false;
            switch (op)
            {
                case 1:
                    BTNbuscaaltera.Enabled = true;
                    break;
                case 2:
                    BTNbuscaaltera.Enabled = true;
                    BTNalterar.Enabled = true;
                    BTNDeletar.Enabled = true;
                    PN_dadosAltera.Enabled = true;
                    break;
            }
        }

        private void FRMAlterarcliente_Load(object sender, EventArgs e)
        {
            alterapropriedades(1);
        }
    }
}
