using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using MODELO;
using MySql.Data.MySqlClient;
using System.Data;

namespace DAL
{
    public class DALCliente
    {

        private DALConection conexao;

        public DALCliente(DALConection cx)
        {
            this.conexao = cx;
        }
        
        public void IncluirDados (MODELOCliente modeloCliente)
        {
            try
            {
                MySqlCommand cmd = new MySqlCommand();
                cmd.Connection = this.conexao.ObjConexao;
                cmd.CommandText = "INSERT INTO cliente (id_cliente, nome, email, cpf, telefone, endereco, valor_pendente) " +
                    "VALUES (NULL, @nome, @email, @cpf, @telefone, @endereco, @valor_pendente);" ;
                    
                cmd.Parameters.AddWithValue("@nome", modeloCliente.Nome);
                cmd.Parameters.AddWithValue("@email", modeloCliente.Email);
                cmd.Parameters.AddWithValue("@cpf", modeloCliente.Cpf);
                cmd.Parameters.AddWithValue("@telefone", modeloCliente.Telefone);
                cmd.Parameters.AddWithValue("@endereco", modeloCliente.Endereco);
                cmd.Parameters.AddWithValue("@valor_pendente", 0);

                conexao.Conectar();
                int ID = Convert.ToInt32(cmd.ExecuteScalar());

                modeloCliente.Id_cliente = ID;

                conexao.Desconectar();
            }
            catch (MySqlException error)
            {
                throw error;
            }
            catch (Exception error2)
            {
                throw error2;
            }
        }


        public bool verficaCadastro = false;
        public String mensagem = "";
        MySqlCommand cmd = new MySqlCommand();
        public MySqlDataReader dr;


        public DataTable VefificarCadastro(String nome, String cpf)
        {
            cmd.CommandText = "SELECT * FROM  cliente WHERE nome LIKE '%" + nome + "%' and cpf LIKE '%" + cpf + "%'";

            DataTable dt = new DataTable();
            try
            {
                cmd.Connection = this.conexao.Conectar();
                dr = cmd.ExecuteReader();
                if (dr.HasRows)
                {
                    dt.Load(dr);
                }
            }
            catch (MySqlException erro)
            {
                this.mensagem = "Erro ao tentar ler o banco de dados" + erro;
            }
            return dt;
        }
    }
}
