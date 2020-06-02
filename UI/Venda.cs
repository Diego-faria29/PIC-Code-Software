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
    public partial class Venda : Form
    {
        public Venda()
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
                if (BOXFormapag.Text == "Confiança")
                {
                    com.CommandText = "UPDATE cliente SET valor_pendente = valor_pendente + pedido.valor_total WHERE pedido.id_cliente = cliente.id_cliente";
                }
                else
                {
                    modelovenda.Forma_pagamento = BOXFormapag.Text;
                }



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


    }
}
