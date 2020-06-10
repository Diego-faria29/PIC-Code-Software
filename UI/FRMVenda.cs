using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using DAL;
using MODELO;
using BLL;
using MySql.Data.MySqlClient;

namespace SoftwarePIC
{
    public partial class FRMVenda : Form
    {
        public FRMVenda()
        {
            InitializeComponent();
        }

        private void BTNVender_Click(object sender, EventArgs e)
        {
            try
            {
                DadosDaConexao dc = new DadosDaConexao();
                DALConection cx = new DALConection(dc.StringConection);
                MySqlConnection con = new MySqlConnection();
                con.ConnectionString = dc.StringConection;
                MySqlCommand com = new MySqlCommand();
                com.Connection = con;

                BLLVenda bllvenda = new BLLVenda(cx);

                MODELOVenda modelovenda = new MODELOVenda();
                modelovenda.Data_dia = new DateTime(BOXData.Value.Year, BOXData.Value.Month, BOXData.Value.Day);
                modelovenda.Id_cliente = Convert.ToInt32(BOXID_cliente.Text);
                modelovenda.Produto = BOXproduto.Text;
                modelovenda.Quantidade = int.Parse(BOXQnt.Text);
                modelovenda.Valor_total = float.Parse(BOXVl.Text);
                modelovenda.Forma_pagamento = BOXFormapag.Text;




                bllvenda.Vender(modelovenda);
                MessageBox.Show("Venda concluida!!");
            }
            catch (MySqlException error)
            {
                if (error.Message.Contains("foreign key"))
                {
                    MessageBox.Show("Falha ao vender. ID de usuário não existente.");
                }
                if (error.Message.Contains("A cadeia de caracteres de entrada não estava em um formato correto."))
                {
                    MessageBox.Show("Falha ao vender. Algum campo não foi preenchido.");
                }
                
            }
            catch (Exception error2)
            {
                if (error2.Message.Contains("A cadeia de caracteres de entrada não estava em um formato correto."))
                {
                    MessageBox.Show("Falha ao vender. Algum campo não foi preenchido.");
                }
                else
                {
                    MessageBox.Show("Falha ao vender, erro geral:" + error2.Message);
                }
                
            }
        }
        private void popularcampos(MODELOCliente p)
        {

            if (p == null)
            {
                BOXID_cliente.Text =  "";

            }
            else
            {
                BOXID_cliente.Text = p.Id_cliente.ToString();
            }

        }
        private void BTNConsultac_Click(object sender, EventArgs e)
        {
            UI.FRMconsulta f = new UI.FRMconsulta();
            f.ShowDialog();

           popularcampos(f.modelcliente);
            alterapropriedades(2);
        }


        public void alterapropriedades(int op)
        {
            //op = operacao
            // 1 = Buscar
            // 2 = Buscar | alterar | deletar
            BTNConsultac.Enabled = false;
            BTNVender.Enabled = false;
            switch (op)
            {
                case 1:
                    BTNConsultac.Enabled = true;
                    break;
                case 2:
                    BTNVender.Enabled = true;
                    BTNConsultac.Enabled = true;
                    break;
            }
        }

        private void FRMVenda_Load(object sender, EventArgs e)
        {
            alterapropriedades(1);
        }
    }
}
