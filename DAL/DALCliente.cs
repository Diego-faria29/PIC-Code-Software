using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using MODELO;
using MySql.Data.MySqlClient;

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
                cmd.CommandText = "INSERT INTO cliente (id_cliente, nome, email, cpf, telefone, endereco) " +
                    "VALUES (NULL, @nome, @email, @cpf, @telefone, @endereco);";
                cmd.Parameters.AddWithValue("@nome", modeloCliente.Nome);
                cmd.Parameters.AddWithValue("@email", modeloCliente.Email);
                cmd.Parameters.AddWithValue("@cpf", modeloCliente.Cpf);
                cmd.Parameters.AddWithValue("@telefone", modeloCliente.Telefone);
                cmd.Parameters.AddWithValue("@endereco", modeloCliente.Endereco);


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
    }
}
