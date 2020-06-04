using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using MODELO;
using MySql.Data.MySqlClient;
using System.Data;
using System.ComponentModel.Design;

namespace DAL
{
    public class DALCliente
    {

        private DALConection conexao;

        public DALCliente(DALConection cx)
        {
            this.conexao = cx;
        }

        public void IncluirDados(MODELOCliente modeloCliente)
        {
            try
            {
                MySqlCommand cmd = new MySqlCommand();
                cmd.Connection = this.conexao.ObjConexao;
                cmd.CommandText = "INSERT INTO cliente (id_cliente, nome, email, cpf, telefone, endereco, valor_pendente) " +
                    "VALUES (@id_cliente, @nome, @email, @cpf, @telefone, @endereco, @valor_pendente);SELECT LAST_INSERT_ID();";
                    
                cmd.Parameters.AddWithValue("@nome", modeloCliente.Nome);
                cmd.Parameters.AddWithValue("@email", modeloCliente.Email);
                cmd.Parameters.AddWithValue("@cpf", modeloCliente.Cpf);
                cmd.Parameters.AddWithValue("@telefone", modeloCliente.Telefone);
                cmd.Parameters.AddWithValue("@endereco", modeloCliente.Endereco);
                cmd.Parameters.AddWithValue("@valor_pendente", modeloCliente.Valor_pendente);
                cmd.Parameters.AddWithValue("@id_cliente", modeloCliente.Id_cliente);

                conexao.Conectar();
                int ID = Convert.ToInt32(cmd.ExecuteScalar());

                modeloCliente.Id_cliente = ID;



            }
            catch (MySqlException error)
            {
                throw error;
            }
            catch (Exception error2)
            {
                throw error2;
            }
            finally
            {
                this.conexao.Desconectar();
            }
        }

        public void Alterar(MODELOCliente modeloCliente)
        {
            try
            {
                MySqlCommand cmd = new MySqlCommand();
                cmd.Connection = this.conexao.ObjConexao;
                cmd.CommandText = "UPDATE cliente SET nome = @nome," +
                                  " email = @email," +
                                  " cpf = @cpf," +
                                  " telefone = @telefone," +
                                  " endereco = @endereco," +
                                  " valor_pendente = @valor_pendente" +
                                  " WHERE " +
                                  " id_cliente = @id_cliente";
                cmd.Parameters.AddWithValue("@nome", modeloCliente.Nome);
                cmd.Parameters.AddWithValue("@email", modeloCliente.Email);
                cmd.Parameters.AddWithValue("@cpf", modeloCliente.Cpf);
                cmd.Parameters.AddWithValue("@telefone", modeloCliente.Telefone);
                cmd.Parameters.AddWithValue("@endereco", modeloCliente.Endereco);
                cmd.Parameters.AddWithValue("@valor_pendente", modeloCliente.Valor_pendente);
                cmd.Parameters.AddWithValue("@id_cliente", modeloCliente.Id_cliente);

                this.conexao.Conectar();
                cmd.ExecuteNonQuery();//executa carry no banco 
            }
            catch (MySqlException error)
            {
                throw error;
            }
            catch (Exception error2)
            {
                throw error2;
            }
            finally
            {
                this.conexao.Desconectar();
            }

        }

        public void Excluir(int codigo)
        {
            try
            {
                MySqlCommand cmd = new MySqlCommand();
                cmd.Connection = this.conexao.ObjConexao;

                cmd.CommandText = "DELETE FROM cliente WHERE id_cliente = @id_cliente";
                cmd.Parameters.AddWithValue("@id_cliente", codigo);
                this.conexao.Conectar();
                cmd.ExecuteNonQuery();
            }
            catch (MySqlException error)
            {
                throw error;
            }
            catch (Exception error2)
            {
                throw error2;
            }
            finally
            {
                this.conexao.Desconectar();
            }
        }



        public bool verficaCadastro = false;
        public String mensagem = "";
        MySqlCommand cmd = new MySqlCommand();
        public MySqlDataReader dr;


        public DataTable VefificarCadastro(String nome)
        {
            cmd.CommandText = "SELECT * FROM  cliente WHERE nome LIKE '%" + nome + "%'";

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
