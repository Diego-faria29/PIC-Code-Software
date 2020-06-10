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
    public partial class FRMCADCliente : Form
    {
        public FRMCADCliente()
        {
            InitializeComponent();
        }

        private void BTNCad_Click(object sender, EventArgs e)
        {
            try
            {
                DadosDaConexao dd = new DadosDaConexao();
                DALConection cx = new DALConection(dd.StringConection);

                BLLCLiente bllcliente = new BLLCLiente(cx);

                MODELOCliente modelocliente = new MODELOCliente();
                modelocliente.Nome = textBox1nome.Text;
                modelocliente.Email = textBox2email.Text;
                modelocliente.Cpf = textBox3CPF.Text;
                modelocliente.Telefone = textBox4Telefone.Text;
                modelocliente.Endereco = textBox5Endereco.Text;


                bllcliente.Incluir(modelocliente);
                MessageBox.Show("Cliente inserido com sucesso!") ;
                textBox1nome.Text = "Insira o nome";
                textBox2email.Text= "email@gmail.com";
                textBox3CPF.Text=  "123.456.789-10";
                textBox4Telefone.Text = "35 3221-1223";
                textBox5Endereco.Text = "Rua, numero, bairro";

            }
            catch (MySqlException error)
            {
                if(error.Message.Contains("Duplicate "))
                {
                    MessageBox.Show("Falha ao cadastrar. CPF ou Email já cadastrado.");
                }
                else
                {
                    MessageBox.Show("Falha ao cadastrar. Erro: " + error.Message);
                }
               
            }
            catch (Exception error2)
            {
                MessageBox.Show("Falha ao cadastrar. Erro inesperado: " + error2.Message);
            }
        }




    }
}
